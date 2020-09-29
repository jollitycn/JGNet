using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Manage;
using JGNet.Core.InteractEntity;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Common.Core;  
using JGNet.Common;
using JGNet.Core.Tools;
using JGNet.Common.Printers;
using CJBasic.Helpers;

namespace JGNet.Manage
{/// <summary>
/// 采购退货
/// </summary>
    public partial class ReturnOrderCtrl : BaseModifyUserControl
    {
        public override void HandleShortKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F3:
                    BaseButton2.PerformClick();
                    break;
                case Keys.F4:
                    BaseButtonConfirm.PerformClick();
                    break;
                default:
                    break;
            }
        }
        private List<CostumeStore> curSelectedCostumeStoreList;//当前被选中的CostumeStore集合
        private List<BoundDetail> curDetailList = new List<BoundDetail>();//当前要入库的CostumeStore
        private List<CostumeStore> orderStoreCache = new List<CostumeStore>();//临时缓存信息
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;
        private Shop shop;
        private PurchaseOrder order;
        private OperationEnum action;
        public ReturnOrderCtrl()
        {
            InitializeComponent();
            Init();
            IsShowOnePage = true;
        }
        public ReturnOrderCtrl(PurchaseOrder order,OperationEnum aciton = OperationEnum.Add)
        {
            InitializeComponent();
            Init();
            //IsShowOnePage = true;
            this.order = order;
            this.action = aciton;
            if (action == OperationEnum.Redo)
            {
                if (!HasPermission(RolePermissionMenuEnum.采购进货退货单查询, RolePermissionEnum.重做_单据时间))
                {
                    dateTimePicker_Start.Enabled = false;
                }
            }
            this.skinComboBoxSupplierID.SelectedValue = order.SupplierID;


        }
        private void Init()
        {
            DataGridViewUtil.SetAlternatingColor(dataGridView1, Color.Gainsboro, Color.White);
            dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl1.ShowRowCounts = false;
            dataGridViewPagingSumCtrl1.Initialize();
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2, new string[] {
       xSDataGridViewTextBoxColumn.DataPropertyName,
       sDataGridViewTextBoxColumn.DataPropertyName,
       mDataGridViewTextBoxColumn.DataPropertyName,
       lDataGridViewTextBoxColumn.DataPropertyName,
       xLDataGridViewTextBoxColumn.DataPropertyName,
       xL2DataGridViewTextBoxColumn.DataPropertyName,
       xL3DataGridViewTextBoxColumn.DataPropertyName,
       xL4DataGridViewTextBoxColumn.DataPropertyName,
       xL5DataGridViewTextBoxColumn.DataPropertyName,
       xL6DataGridViewTextBoxColumn.DataPropertyName,
       fDataGridViewTextBoxColumn.DataPropertyName,
            SumCount.DataPropertyName,
            SumCost.DataPropertyName,
            SumMoney.DataPropertyName});
            dataGridViewPagingSumCtrl2.ShowRowCounts = false;
            dataGridViewPagingSumCtrl2.Initialize();
            MenuPermission = RolePermissionMenuEnum.采购退货;

            if (!HasPermission(RolePermissionMenuEnum.采购退货, RolePermissionEnum.单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
        }
        private void Initialize()
        {
            try
            {
                ResetAll(false);
                if (order != null)
                { //冲单重做
                    dateTimePicker_Start.Value = order.CreateTime;
                    skinComboBoxShopID.SelectedValue = order.DestShopID;
                    curDetailList = GlobalCache.ServerProxy.GetPurchaseDetails(order.ID);

                }
                this.BindingSource(curDetailList);

            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        private void BindingSource(List<BoundDetail> list)
        {
            this.dataGridView2.DataSource = null;
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    Costume costume = CommonGlobalCache.GetCostume(item.CostumeID);
                    item.SupplierName = CommonGlobalCache.GetSupplierName(item.SupplierID);
                    item.BrandName = CommonGlobalCache.GetBrandName(costume.BrandID);
                    item.Year = costume.Year;
                    item.Season = costume.Season;
                    item.CostumeName = costume.Name;

                }
                dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(DataGridViewUtil.ListToBindingList(curDetailList));
                //this.dataGridView2.DataSource = list;
            }
        }
        private void ResetAll(Boolean resetAction)
        {
            shop = GlobalCache.GeneralStoreShop;
            curDetailList = new List<BoundDetail>();
            this.dataGridView1.DataSource = null;
            this.dataGridViewPagingSumCtrl2.SetDataSource<BoundDetail>(null);
            if (this.order != null)
            {
                this.skinTextBox_Remarks.SkinTxt.Text = this.order.Remarks;
            }
            else
            {
                this.skinTextBox_Remarks.SkinTxt.Text = string.Empty;
            }
            orderStoreCache = new List<CostumeStore>();
            this.skinComboBoxShopID.Initialize(true);
            this.skinComboBoxShopID.SelectedValue = shop.ID;
            if (resetAction)
            {
                action = OperationEnum.Add;
            }
        }
        private ReturnCostume Build()
        {
            if (
                this.curDetailList == null || this.curDetailList.Count == 0)
            {
                return null;
            }
            int totalCount = 0;
            decimal totalPrice = 0;
            decimal totalCost = 0;
            List<BoundDetail> details = new List<BoundDetail>();

            //使用补货申请单的店铺ID信息

            // Shop shop = GlobalCache.ShopList.Find(t => t.ID == this.curReplenishOrder.ShopID);
            Shop shop = (Shop)this.skinComboBoxShopID.SelectedItem;
            string id = IDHelper.GetID(OrderPrefix.OutboundOrder, shop.AutoCode);
            string returnOrderId = IDHelper.GetID(OrderPrefix.ReturnOrder, shop.AutoCode);
            if (action == OperationEnum.Pick)
            {
                returnOrderId = this.order?.ID;
            }
            foreach (BoundDetail detail in this.curDetailList)
            {
                if (detail.SumCount <= 0)
                {
                    continue;
                }
                detail.SumCount = -detail.SumCount;
                detail.SumMoney = -detail.SumMoney;
                //  detail.SumCount = -detail.SumMoney;
                totalCount += detail.SumCount;
                totalPrice += detail.SumMoney;
                totalCost += detail.SumCost;
                detail.BoundOrderID = id;
                detail.SupplierID = ValidateUtil.CheckEmptyValue(skinComboBoxSupplierID.SelectedValue);
                details.Add(detail);
                //   details.Add(this.OutboundDetailConvertToOutboundDetail(detail, id));
            }

            OutboundOrder order = new OutboundOrder()
            {
                SourceOrderID = returnOrderId,
                ID = id,
                OperatorUserID = GlobalCache.CurrentUserID,
                ShopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue),
                CreateTime = dateTimePicker_Start.Value,
                EntryTime = DateTime.Now,
                TotalCount = totalCount,
                TotalPrice = totalPrice,
                TotalCost = totalCost,
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text
            };


            PurchaseOrder pOrder = new PurchaseOrder()
            {
                SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBoxSupplierID.SelectedValue),
                ID = returnOrderId,
                AdminUserID = GlobalCache.CurrentUserID,
                InboundOrderID = order.ID,
                DestShopID = order.ShopID,
                CreateTime = dateTimePicker_Start.Value,
                EntryTime = DateTime.Now,
                TotalCount = totalCount,
                TotalPrice = totalPrice,
                TotalCost = totalCost,
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text
            };

            return new ReturnCostume()
            {
                ReturnOrder = pOrder,
                OutboundOrder = order,
                OutboundDetailList = details
            };
        }
        private BoundDetail OutboundDetailConvertToOutboundDetail(BoundDetail from, string id)
        {

            return new BoundDetail()
            {
                CostumeID = from.CostumeID,
                ColorName = from.ColorName,
                CostPrice = from.CostPrice,
                BoundOrderID = id,
                Price = from.Price,
                S = from.S,
                M = from.M,
                XS = from.XS,
                L = from.L,
                F = from.F,
                XL = from.XL,
                XL2 = from.XL2,
                XL3 = from.XL3,
                XL4 = from.XL4,
                XL5 = from.XL5,
                XL6 = from.XL6,
                Comment = from.Comment
            };

        }
        private void CostumeCurrentShopTextBox1_CostumeSelected(CostumeItem costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                if (costumeItem == null)
                {
                    // this.CostumeCurrentShopTextBox1.SkinTxt.Text = "";
                    this.curSelectedCostumeStoreList = null;
                }
                else

                {
                    //this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
                    this.curSelectedCostumeStoreList = CostumeFromShopTextBox.GetCostumeStores(costumeItem, false);
                }

                this.BindingSelectedCostumeStoreSource(null);
            }
        }
        private void BindingOutboundDetailSource()
        {
            if (this.curDetailList != null && this.curDetailList.Count > 0)
            {
                foreach (BoundDetail detail in this.curDetailList)
                {
                    Costume curCostume = GlobalCache.GetCostume(detail.CostumeID);
                    detail.CostumeName = curCostume.Name;
                    detail.BrandName = GlobalCache.GetBrandName(curCostume.BrandID);
                    detail.Year = curCostume.Year;
                    detail.Season = curCostume.Season;
                }
            }
            
            dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(DataGridViewUtil.ListToBindingList(curDetailList));
        } 
        private void BindingSelectedCostumeStoreSource(BoundDetail detail)
        {
            if (this.curSelectedCostumeStoreList == null)
            {
                this.dataGridView1.DataSource = null;
            }
            else
            {

                this.dataGridView1.DataSource = null;
                if (this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > 0)
                {
                    List<CostumeStore> tempList = new List<CostumeStore>();
                    foreach (CostumeStore store in this.curSelectedCostumeStoreList)
                    {
                        store.Title = "库存"; 
                        CostumeStore tempStore = this.BuildCostumeStore4NeedReplenish(store, detail);
                        //CJBasic.Helpers.ReflectionHelper.CopyProperty(store, obj);
                        tempList.Add(store);
                        tempList.Add(tempStore);
                    }
                    this.curSelectedCostumeStoreList = tempList;
                    this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(this.curSelectedCostumeStoreList);
                }
            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.ReadOnly = true;
                    row.HeaderCell.Value = "库存";

                }
                else
                {
                    row.ReadOnly = false;
                    row.HeaderCell.Value = "退货";
                }
            }
            // cell获取焦点
            dataGridViewPagingSumCtrl1.AutoFocusToWritableCell();
            // this.dataGridView1.Refresh();
        } 
        private CostumeStore BuildCostumeStore4NeedReplenish(CostumeStore oldCostumeStore, BoundDetail detail)
        {
            CostumeStore store = null;
            if (oldCostumeStore != null)
            {
                store = new CostumeStore()
                {
                     
                };
                ReflectionHelper.CopyProperty(oldCostumeStore, store);
                store.Title = "退货";
                    store.F = 0;
                    store.L = 0;
                    store.XS = 0;
                    store.M = 0;
                    store.S = 0;
                    store.XL = 0;
                    store.XL2 = 0;
                    store.XL3 = 0;
                    store.XL4 = 0;
                    store.XL5 = 0;
                    store.XL6 = 0;
            

                if (detail != null)
                {
                    store.F = detail.F;
                    store.L = detail.L;
                    store.XS = detail.XS;
                    store.M = detail.M;
                    store.S = detail.S;
                    store.XL = detail.XL;
                    store.XL2 = detail.XL2;
                    store.XL3 = detail.XL3;
                    store.XL4 = detail.XL4;
                    store.XL5 = detail.XL5;
                    store.XL6 = detail.XL6;
                    store.CostPrice = detail.CostPrice;
                }
            }
            return store;
        } 
        private void SetCostumeDetails(CostumeItem costumeItem)
        {
            if (costumeItem == null)
            {
                this.CostumeCurrentShopTextBox1.SkinTxt.Text = "";
                this.curSelectedCostumeStoreList = null;
                this.BindingSelectedCostumeStoreSource(null);
            }
            else
            {
                this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
                this.curSelectedCostumeStoreList = costumeItem.CostumeStoreList;
                this.BindingSelectedCostumeStoreSource(null);
            }
            this.skinTextBox_Remarks.SkinTxt.Text = "";
        }
        private void BaseButton_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.curSelectedCostumeStoreList == null || this.curSelectedCostumeStoreList.Count == 0)
                {
                    return;
                }
                List<CostumeStore> costumeStoreList = this.curSelectedCostumeStoreList.FindAll((x) => x.Title == "退货");
                AddStoreCache(this.curSelectedCostumeStoreList.FindAll((x) => x.Title == "库存"));
                foreach (CostumeStore store in costumeStoreList)
                {
                    if (store.SumCount == 0)
                    {
                        continue;
                    }
                    if (store.Remarks == null)
                    {
                        store.Remarks = "";
                    }
                   
                    BoundDetail detail = this.CostumeStoreConvertToOutboundDetail(store, "");
                    detail.Comment = store.Remarks;
                    detail.Year = GlobalCache.GetCostume(store.CostumeID).Year;
                    detail.Season = GlobalCache.GetCostume(store.CostumeID).Season;
                    this.OutboundDetailListAddItem(detail);
                }
                //清空dataGirdView1的绑定源
                this.SetCostumeDetails(null);
                this.BindingOutboundDetailSource();
                this.CostumeCurrentShopTextBox1.Focus();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        private void AddStoreCache(List<CostumeStore> list)
        {
            foreach (var item in list)
            {
                CostumeStore c = orderStoreCache.Find(t => t.CostumeID.ToUpper() == item.CostumeID.ToUpper() && t.ColorName == item.ColorName);
                if (c != null)
                {
                    orderStoreCache.Remove(c);
                }
                orderStoreCache.Add(item);
            }
        }
        private BoundDetail CostumeStoreConvertToOutboundDetail(CostumeStore store, string replenishOrderID)
        {
            if (store == null)
            {
                return null;
            }
            Costume costume = GlobalCache.GetCostume(store.CostumeID);
            BoundDetail boundDetail=  new BoundDetail();
            ReflectionHelper.CopyProperty(costume, boundDetail);
            ReflectionHelper.CopyProperty(store, boundDetail);
            boundDetail.SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBoxSupplierID.SelectedValue);
            return boundDetail;
        }
        private void OutboundDetailListAddItem(BoundDetail detail)
        {
            bool existed = false;
            DialogResult result = DialogResult.No;
            BoundDetail repeatItem = null;
            foreach (BoundDetail item in this.curDetailList)
            {
                if (item.CostumeID.ToUpper() == detail.CostumeID.ToUpper() && item.ColorName == detail.ColorName)
                {
                    repeatItem = item;
                    existed = true;
                    result = GlobalMessageBox.Show(string.Format("款号：{0}  颜色：{1} 的服装已经存在待补货列表中，是否覆盖", item.CostumeID, item.ColorName), "", MessageBoxButtons.YesNo);

                    break;
                }
            }

            if (!existed || result == DialogResult.Yes)
            {
                //不存在或者重复时直接覆盖
                if (repeatItem != null)
                {
                    this.curDetailList.Remove(repeatItem);
                }
                //this.curDetailList.Insert(0, detail);

                this.curDetailList.Add(detail);
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                switch (this.dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    case "删除":
                        this.curDetailList.RemoveAt(e.RowIndex);
                        this.BindingOutboundDetailSource();
                        break;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        } 
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            if (isCostumeStoreList)
            {
                this.dataGridView1.Refresh();
                return;
            }
            this.dataGridView2.Refresh();
        }
        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //加载库存信息
            if (this.dataGridView2!=null && this.dataGridView2.Rows.Count > 0)
            {
                BoundDetail detail = (BoundDetail)this.dataGridView2.CurrentRow.DataBoundItem;
                List<CostumeStore> stores = orderStoreCache.FindAll(t => t.CostumeID == detail.CostumeID && detail.ColorName == t.ColorName);
                this.curSelectedCostumeStoreList = stores;
                this.BindingSelectedCostumeStoreSource(detail);
            }
        }
        private void ReturnOrderCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                this.Initialize();

            }
            catch (Exception ex)
            {

                GlobalUtil.ShowError(ex);
            }
        }
        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CostumeCurrentShopTextBox1.ShopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue);
        } 
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            CostumeStore item = (CostumeStore)row.DataBoundItem;
            if (row.DataBoundItem != null)
            {
                if (costumeNameDataGridViewTextBoxColumn.Index == e.ColumnIndex)
                {
                    e.Value = GlobalCache.GetCostumeName(item.CostumeID);
                }
            }
        }
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //库存 也不用变色
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex % 2 == 0 || dataGridView1.Rows.Count < 0) { return; }
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewUtil.CellPainting_SetCellFont(dataGridView1, cell, 4, 15, Color.Green, FontStyle.Bold);
        }
        private void dataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //库存 也不用变色
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dataGridView2.Rows.Count < 0) { return; }
            DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewUtil.CellPainting_SetCellFont(dataGridView2, cell, 5, 16, Color.Green, FontStyle.Bold);
        } 
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           CheckValidate(sender, e, Price, dataGridViewTextBoxColumn13);
        }
        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            CheckValidate(sender, e, priceDataGridViewTextBoxColumn, xL6DataGridViewTextBoxColumn);
        }
        private void CheckValidate(object sender, DataGridViewCellValidatingEventArgs e, DataGridViewColumn fromColumn, DataGridViewColumn toColumn)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            try
            {
                if (CommonGlobalUtil.NotStoreColumnIndex(e.ColumnIndex, fromColumn.Index, toColumn.Index)
                 )
                {
                    return;
                }
                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Decimal.Parse(e.FormattedValue.ToString());
                }
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > e.RowIndex && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
                {
                    Decimal oldCount = 0;
                    if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                    {
                        oldCount = Decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
                    }
                    if (newCount == oldCount)
                    {
                        return;
                    }
                    GlobalMessageBox.Show("库存不能修改！");
                    dataGridView.CancelEdit();
                    return;
                }
              /*  if (newCount < 0)
                {
                    GlobalMessageBox.Show("退货数不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }*/
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
        }
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            dataGridView.Refresh();
        }
        private void baseButton1_Click(object sender, EventArgs e)
        {
            if (GlobalMessageBox.Show("确定清空下表数据吗？", "友情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView2.DataSource = null;
                curDetailList?.Clear();
                dataGridView2.Refresh();
                if (action == OperationEnum.Pick)
                {
                    order = null;
                    action = OperationEnum.Add;
                }
            }
        }
        private void baseButtonPick_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrderPickForm tiDanForm = new PurchaseOrderPickForm(false);
                tiDanForm.HangedOrderSelected += TiDanForm_HangedOrderSelected;//提单被选择后触发
                tiDanForm.ShowDialog();
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }
        private void TiDanForm_HangedOrderSelected(PurchaseOrder hangedOrder)
        {
            action = OperationEnum.Pick; 
            LoadOrder(hangedOrder);
            BindingOutboundDetailSource();
        }
        private void LoadOrder(PurchaseOrder order)
        {
            this.order = order;
            if (order != null)
            {
                skinTextBox_Remarks.Text = order.Remarks;
                //冲单重做
                skinComboBoxShopID.SelectedValue = order.DestShopID;
                if (shop == null)
                {
                    GlobalMessageBox.Show("店铺无效！");
                }

                curDetailList.Clear();
                BindingOutboundDetailSource();
                dateTimePicker_Start.Value = order.CreateTime;
                numericTextBoxMoney.Value = order.PayMoney;
                skinComboBoxSupplierID.SelectedValue = order.SupplierID;
                curDetailList = GlobalCache.ServerProxy.GetPurchaseDetails(order.ID);
                foreach (var detail in curDetailList)
                {
                    detail.SupplierName = GlobalCache.GetSupplierName(detail.SupplierID);
                    detail.Discount = detail.Price == 0 ? 0 : Math.Round(detail.CostPrice * 100 / detail.Price, MidpointRounding.AwayFromZero);
                }
            }
        } 
        private void baseButtonHang_Click(object sender, EventArgs e)
        {
            Save(true);
        }
        private void BaseButton_Inbound_Click(object sender, EventArgs e)
        {
            Save(false);
        }
        private bool CheckValidate()
        {
            bool success = true;
            string msg = string.Empty;

            if (shop == null)
            {
                msg = "请选择店铺！";
                success = false;
            }
            //CostPrice
            foreach (BoundDetail detail in this.curDetailList)
            {
                if (detail.CostPrice > Convert.ToDecimal(99999999.99) || detail.Price > Convert.ToDecimal(99999999.99) || detail.SumMoney > Convert.ToDecimal(99999999.99))
                {
                    msg = "请检查吊牌价、成本价或单款总金额是否大于99999999.99！";
                    success = false;
                    break;
                }
            }

            if (!success)
            {
                GlobalMessageBox.Show(this.FindForm(), msg);
            }
            return success;
        }


        private DataGridView deepCopyDataGridView()
        {
            DataGridView dgvTmp = new DataGridView();

            dgvTmp.Name = "dgvTmp";
            this.Controls.Add(dgvTmp);
            dgvTmp.AutoGenerateColumns = false;
            //  dgvTmp.AllowUserToAddRows = false; //不允许用户生成行，否则导出后会多出最后一行
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                dgvTmp.Columns.Add(dataGridView2.Columns[i].Name, dataGridView2.Columns[i].HeaderText);
                if (dataGridView2.Columns[i].DefaultCellStyle.Format.Contains("N")) //使导出Excel文档金额列可做SUM运算
                {
                    dgvTmp.Columns[i].DefaultCellStyle.Format = dataGridView2.Columns[i].DefaultCellStyle.Format;

                }
                if (!dataGridView2.Columns[i].Visible)
                {
                    dgvTmp.Columns[i].Visible = false;
                }
                dgvTmp.Columns[i].DataPropertyName = dataGridView2.Columns[i].DataPropertyName;
                dgvTmp.Columns[i].HeaderText = dataGridView2.Columns[i].HeaderText;
                dgvTmp.Columns[i].Tag = dataGridView2.Columns[i].Tag;
                dgvTmp.Columns[i].Name = dataGridView2.Columns[i].Name;
            }
            


            List<BoundDetail> listtb1 = DataGridViewUtil.BindingListToList<BoundDetail>(dataGridView2.DataSource);

            List<BoundDetail> tb2 = new List<BoundDetail>();
            foreach (BoundDetail idetail in listtb1)
            {
                BoundDetail tDetail = new BoundDetail();
                ReflectionHelper.CopyProperty(idetail, tDetail);
                tb2.Add(tDetail);

            }

            dgvTmp.DataSource = tb2;

 

            return dgvTmp;
        }

        private void Save(bool isHang)
        {
            try
            {
                if (!CheckValidate()) { return; }
                ReturnCostume item = this.Build();
                if (item == null || item.OutboundOrder.TotalCount == 0)
                {
                    GlobalMessageBox.Show("采购单为空,不能退货！");
                    return;
                }
                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }


                InteractResult result;
                if (isHang)
                {
                    result = GlobalCache.ServerProxy.HangUpReturn(item);
                }
                else
                {
                    //输入金额
                    //SelectMoneyForm form = new SelectMoneyForm();
                    //if (form.ShowDialog(this.FindForm()) == DialogResult.OK)
                    //{
                        item.ReturnOrder.PayMoney = numericTextBoxMoney.Value;// form.result;
                    //}
                    //else
                    //{
                    //    return;
                    //}
                    result = GlobalCache.ServerProxy.ReturnCostume(item);
                }


                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        if (isHang)
                        {
                            GlobalMessageBox.Show("挂单成功！");
                        }
                        else
                        {
                            GlobalMessageBox.Show("退货成功！");
                            numericTextBoxMoney.Text = string.Empty;
                            if (skinCheckBoxPrint.Checked)
                            {
                               DataGridView dgv= deepCopyDataGridView();
                                //SumMoney.Visible = false;
                                //SumMoney.Tag = PurchaseReturnOrderPrinter.PrinterNoCount;
                                //Column2.Visible = false;
                                //Column2.Tag = PurchaseReturnOrderPrinter.PrinterNoCount;
                                PurchaseReturnOrderPrinter.Print(item.ReturnOrder, dgv, 2); 
                                //SumMoney.Visible = true;
                                //Column2.Visible = true;
                            }
                        }

                        ResetAll(true);
                        if (!IsShowOnePage) { 
                            TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                        } 
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void skinPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
