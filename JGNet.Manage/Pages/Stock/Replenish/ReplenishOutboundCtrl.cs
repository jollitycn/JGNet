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
using JGNet.Common.Core;  
using JGNet.Common.Core.Util;
using JGNet.Core.Tools;
using JGNet.Common;
using CJBasic.Helpers;

namespace JGNet.Manage
{
    public partial class ReplenishOutboundCtrl : BaseModifyUserControl
    {
        public override void HandleShortKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F3:
                    BaseButton1.PerformClick();
                    break;
                case Keys.F4:
                    BaseButtonConfirm.PerformClick();
                    break;
                    
                default:
                    break;
            }
        }

        private List<CostumeStore> curSelectedCostumeStoreList;//当前被选中的CostumeStore集合
        private List<ReplenishDetail> curReplenishDetailList = new List<ReplenishDetail>();//当前要补货的CostumeStore

       // public TabPage TabPage { get; set; }
        private List<CostumeStore> orderStoreCache = new List<CostumeStore>();//临时缓存信息
         
        private ReplenishOrder curReplenishOrder;
        public CJBasic.Action<bool,EventArgs> WorkDesk_Refresh;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2; 
        public ReplenishOutboundCtrl(ReplenishOrder replenishOrder)
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl1.Initialize();
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2,
                new string[] {
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
                SumMoney.DataPropertyName});
            dataGridViewPagingSumCtrl2.Initialize(); 
            curReplenishOrder = replenishOrder;
            // this.curOutbound = GlobalCache.ServerProxy.GetOneOutbound(replenishOrder.ID);
            this.Initialize();

            orderStoreCache = GlobalCache.ServerProxy.GetCostumeStore4ReplenishInfo(new CostumeStore4ReplenishInfoPara() { ReplenishOrderID = replenishOrder.ID, ShopID = GlobalCache.ServerProxy.GetGeneralStoreShopID() });
        }

        private void Initialize()
        {

            if (this.curReplenishOrder == null)
            {
                return;
            }
            try
            {
                DataGridViewUtil.SetAlternatingColor(dataGridView1, Color.Gainsboro, Color.White);
                this.skinTextBox_OrderID.Text = "补货申请单号：" + this.curReplenishOrder.ID;
                this.skinLabel_ShopName.Text = "店铺名称：" + GlobalCache.GetShopName(this.curReplenishOrder.ShopID);
                curReplenishDetailList = GlobalCache.ServerProxy.GetReplenishDetail(this.curReplenishOrder.ID);
                foreach (var item in curReplenishDetailList)
                {
                    Costume costume= CommonGlobalCache.GetCostume(item.CostumeID);
                    if (costume != null) {
                        item.CostPrice = costume.CostPrice;
                    }
                }
                this.BindingSource(curReplenishDetailList);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void BindingSource(List<ReplenishDetail> list)
        {
            this.dataGridView2.DataSource = null;
            if (list != null && list.Count > 0)
            {
                foreach (ReplenishDetail detail in list)
                {
                    detail.CostumeName = GlobalCache.GetCostumeName(detail.CostumeID);
                } 
                        dataGridViewPagingSumCtrl2.BindingDataSource<ReplenishDetail>(list); 
                // this.dataGridView2.DataSource = list;
            }
        }


        //点击出库按钮
        private void BaseButton_Inbound_Click(object sender, EventArgs e)
        {
            try
            {
               
                    Outbound item = this.BuildOutbound();
                    if (item == null || item.OutboundOrder.TotalCount == 0 || item.OutboundDetails.Count == 0)
                    {
                        GlobalMessageBox.Show("出库单为空,不能发货！");
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
                InteractResult result = GlobalCache.ServerProxy.ReplenishOutbound(item);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("发货成功！");

                        if (skinCheckBoxPrint.Checked)
                        {
                            DataGridView dgv = deepCopyDataGridView();
                            ReplenishOrderPrinter.Print( this.curReplenishOrder, dgv, 2);
                        }

                        WorkDesk_Refresh?.Invoke(false, null);
                        TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
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
                GlobalMessageBox.Show("出库失败！");
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }

        }


        private DataGridView deepCopyDataGridView()
        {
            DataGridView dgvTmp = new DataGridView();

            dgvTmp.Name = "dgvTmp";
            this.Controls.Add(dgvTmp);
            dgvTmp.AutoGenerateColumns = false;
            //  dgvTmp.AllowUserToAddRows = false; //不允许用户生成行，否则导出后会多出最后一行
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dgvTmp.Columns.Add(dataGridView1.Columns[i].Name, dataGridView1.Columns[i].HeaderText);
                if (dataGridView1.Columns[i].DefaultCellStyle.Format.Contains("N")) //使导出Excel文档金额列可做SUM运算
                {
                    dgvTmp.Columns[i].DefaultCellStyle.Format = dataGridView1.Columns[i].DefaultCellStyle.Format;

                }
                if (!dataGridView1.Columns[i].Visible)
                {
                    dgvTmp.Columns[i].Visible = false;
                }
                dgvTmp.Columns[i].DataPropertyName = dataGridView1.Columns[i].DataPropertyName;
                dgvTmp.Columns[i].HeaderText = dataGridView1.Columns[i].HeaderText;
                dgvTmp.Columns[i].Tag = dataGridView1.Columns[i].Tag;
                dgvTmp.Columns[i].Name = dataGridView1.Columns[i].Name;
            }



            List<ReplenishDetail> listtb1 = (List<ReplenishDetail>)(dataGridView1.DataSource);

            List<ReplenishDetail> tb2 = new List<ReplenishDetail>();
            foreach (ReplenishDetail idetail in listtb1)
            {
                ReplenishDetail tDetail = new ReplenishDetail();
                ReflectionHelper.CopyProperty(idetail, tDetail);
                tb2.Add(tDetail);

            }

            dgvTmp.DataSource = tb2;



            return dgvTmp;
        }
        private Outbound BuildOutbound()
        {
            if (this.curReplenishOrder == null || this.curReplenishDetailList == null || this.curReplenishDetailList.Count == 0)
            {
                return null;
            }
            int totalCount = 0;
            decimal totalPrice = 0;
            decimal totalCost = 0;
            List<BoundDetail> details = new List<BoundDetail>();

            //使用补货申请单的店铺ID信息

            Shop shop = GlobalCache.ShopList.Find(t => t.ID == this.curReplenishOrder.ShopID);
            string id = IDHelper.GetID(OrderPrefix.OutboundOrder, shop.AutoCode);
            string replenishOrderid = IDHelper.GetID(OrderPrefix.ReplenishOrder, shop.AutoCode);
            foreach (ReplenishDetail detail in this.curReplenishDetailList)

            {
                if (detail.SumCount <= 0)
                {
                    continue;
                }
                totalCost += detail.SumCost;
                totalCount += detail.SumCount;
                totalPrice += detail.SumMoney;
                details.Add(this.ReplenishDetailConvertToOutboundDetail(detail, id));
            }

            OutboundOrder order = new OutboundOrder()
            {
                SourceOrderID = curReplenishOrder.IsRedo?  replenishOrderid:this.curReplenishOrder.ID ,
                ID = id,
                OperatorUserID = GlobalCache.CurrentUserID,
                ShopID = GlobalCache.ServerProxy.GetGeneralStoreShopID(),
                CreateTime = DateTime.Now,
                TotalCount = totalCount,
                TotalPrice = totalPrice, 
                TotalCost = totalCost,
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text
            };

            return new Outbound()
            {  
                OutboundDetails = details,
                OutboundOrder = order
            };
        }

        private BoundDetail ReplenishDetailConvertToOutboundDetail(ReplenishDetail from, string id)
        {

            return new BoundDetail()
            {
                CostumeID = from.CostumeID,
                ColorName = from.ColorName,
                 BoundOrderID = id,
                Price = from.Price,
                CostPrice = from.CostPrice,
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
                XL6 = from.XL6
            };

        }


        #region 验证单元格中的值




        #endregion

        private void CostumeCurrentShopTextBox1_CostumeSelected(CostumeItem costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                if (costumeItem == null)
                {
                    //   this.CostumeCurrentShopTextBox1.SkinTxt.Text = "";
                    this.curSelectedCostumeStoreList = null;
                }
                else
                {
                    //this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
                    this.curSelectedCostumeStoreList = costumeItem.CostumeStoreList;
                }
                this.BindingSelectedCostumeStoreSource(null);
            }

        }


        /// <summary>
        /// 绑定要补货的集合源
        /// </summary>
        private void BindingReplenishDetailSource()
        {
            if (this.curReplenishDetailList != null && this.curReplenishDetailList.Count > 0)
            {
                foreach (ReplenishDetail detail in this.curReplenishDetailList)
                {
                    detail.CostumeName = GlobalCache.GetCostumeName(detail.CostumeID);
                }
            }
            dataGridViewPagingSumCtrl2.BindingDataSource<ReplenishDetail>(this.curReplenishDetailList);

        }

        /// <summary>
        /// 绑定选定款号对应的CostumeStore集合
        /// </summary>
        private void BindingSelectedCostumeStoreSource(ReplenishDetail detail)
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
                        store.CostumeName = GlobalCache.GetCostumeName(store.CostumeID);
                        CostumeStore tempStore = this.BuildCostumeStore4NeedReplenish(store, detail);
                        //CJBasic.Helpers.ReflectionHelper.CopyProperty(store, obj);
                        tempList.Add(store);
                        tempList.Add(tempStore);
                    }
                    this.curSelectedCostumeStoreList=tempList;

                    ////重新排序，同款同颜色排一起，且将补货数量拍在库存后面
                    //this.curSelectedCostumeStoreList.Sort((x, y) =>
                    //{
                    //    int sort = x.ColorName.CompareTo(y.ColorName);
                    //    if (sort == 0)
                    //    {
                    //        sort = -x.Title.CompareTo(y.Title);
                    //    }
                    //    return sort;
                    //});
                    this.dataGridView1.DataSource = this.curSelectedCostumeStoreList;
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
                    row.HeaderCell.Value = "补货申请";
                }
            } 
            this.dataGridView1.Refresh();
            dataGridViewPagingSumCtrl1.AutoFocusToWritableCell();
        }

        /// <summary>
        /// 根据现在库存对象生成需补货的库存对象
        /// </summary>
        /// <param name="oldCostumeStore"></param>
        /// <returns></returns>
        private CostumeStore BuildCostumeStore4NeedReplenish(CostumeStore oldCostumeStore, ReplenishDetail detail)
        {
            CostumeStore store = null;
            if (oldCostumeStore != null)
            {
                store = new CostumeStore()
                {
                    CostumeID = oldCostumeStore.CostumeID,
                    CostumeName = oldCostumeStore.CostumeName,
                    ColorName = oldCostumeStore.ColorName,
                    AllowReviseDiscount = oldCostumeStore.AllowReviseDiscount,
                    ShopID = oldCostumeStore.ShopID,
                    Price = oldCostumeStore.Price,
                    CostPrice = oldCostumeStore.CostPrice,
                    Title = "补货申请",
                    F = 0,
                    L = 0,
                    XS = 0,
                    M = 0,
                    S = 0,
                    XL = 0,
                    XL2 = 0,
                    XL3 = 0,
                    XL4 = 0,
                    XL5 = 0,
                    XL6 = 0
                };

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
                }
            }
            return store;
        }

        /// <summary>
        /// 设置界面上服装的明细
        /// </summary>
        /// <param name="costumeItem"></param>
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
                List<CostumeStore> costumeStoreList = this.curSelectedCostumeStoreList.FindAll((x) => x.Title == "补货申请");
                AddStoreCache(this.curSelectedCostumeStoreList.FindAll((x) => x.Title == "库存"));
                foreach (CostumeStore store in costumeStoreList)
                {
                    if (store.SumCount == 0)
                    {
                        continue;
                    }
                    ReplenishDetail detail = this.CostumeStoreConvertToReplenishDetail(store, "");
                    this.ReplenishDetailListAddItem(detail);
                }
                //清空dataGirdView1的绑定源
                this.SetCostumeDetails(null);
                this.BindingReplenishDetailSource();
                this.CostumeCurrentShopTextBox1.Focus();
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
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

        /// <summary>
        /// 将CostumeStore转化为ReplenishDetail  
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        private ReplenishDetail CostumeStoreConvertToReplenishDetail(CostumeStore store, string replenishOrderID)
        {
            if (store == null)
            {
                return null;
            }

              ReplenishDetail detail =  new ReplenishDetail();

             
            return new ReplenishDetail()
            {
                ReplenishOrderID = replenishOrderID,
                CostumeID = store.CostumeID,
                CostumeName = GlobalCache.GetCostumeName(store.CostumeID),
                ColorName = store.ColorName,
                CostPrice = store.CostPrice,
                XS = store.XS,
                S = store.S,
                M = store.M,
                L = store.L,
                F = store.F,
                XL = store.XL,
                XL2 = store.XL2,
                XL3 = store.XL3,
                XL4 = store.XL4,
                XL5 = store.XL5,
                XL6 = store.XL6,
                Price = store.Price
            };
        }

        private void ReplenishDetailListAddItem(ReplenishDetail detail)
        {
            bool existed = false;
            DialogResult result = DialogResult.No;
            ReplenishDetail repeatItem = null;
            foreach (ReplenishDetail item in this.curReplenishDetailList)
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
                    this.curReplenishDetailList.Remove(repeatItem);
                }
                //   this.curReplenishDetailList.Insert(0, detail);
                this.curReplenishDetailList.Add(detail);
                
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
                        this.curReplenishDetailList.RemoveAt(e.RowIndex);
                        this.BindingReplenishDetailSource();
                        break;
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            try
            { 

                if (CommonGlobalUtil.NotStoreColumnIndex(e.ColumnIndex, fDataGridViewTextBoxColumn.Index, xL6DataGridViewTextBoxColumn.Index)
                 )
                {
                    return;
                }


                int newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Convert.ToInt32(e.FormattedValue);
                }
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
                {
                    int oldCount = 0;
                    if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                    {
                        oldCount = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue);
                    }
                    if (newCount == oldCount)
                    {
                        return;
                    }
                    GlobalMessageBox.Show("原始库存不能修改！");
                    dataGridView.CancelEdit();
                    return;
                }
                if (newCount < 0)
                {
                    GlobalMessageBox.Show("补货数不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }
            }
            catch (Exception ex)
            {
               GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
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
            ReplenishDetail detail = (ReplenishDetail)this.dataGridView2.CurrentRow.DataBoundItem;
            List<CostumeStore> stores = orderStoreCache.FindAll(t => t.CostumeID == detail.CostumeID && detail.ColorName == t.ColorName);
            this.curSelectedCostumeStoreList = stores;
            this.BindingSelectedCostumeStoreSource(detail);
        }

        private void OutboundCtrl_Load(object sender, EventArgs e)
        {
            this.CostumeCurrentShopTextBox1.ShopID = GlobalCache.GeneralStoreShopID;
        }
         

        private void dataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //库存 也不用变色
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dataGridView2.Rows.Count < 0) { return; }

            DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewUtil.CellPainting_SetCellFont(dataGridView2, cell, 4, 15, Color.Green, FontStyle.Bold);
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //库存 也不用变色
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dataGridView1.Rows.Count < 0) { return; }

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewUtil.CellPainting_SetCellFont(dataGridView1, cell, 3, 14, Color.Green, FontStyle.Bold);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            try
            {
                 

                if (CommonGlobalUtil.NotStoreColumnIndex(e.ColumnIndex, dataGridViewTextBoxColumn13.Index, dataGridViewTextBoxColumn12.Index)
                 )
                {
                    return;
                }

                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = decimal.Parse(e.FormattedValue.ToString());
                }
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count>e.RowIndex && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
                {
                    decimal oldCount = 0;
                    if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                    {
                        oldCount = decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
                    }
                    if (newCount == oldCount)
                    {
                        return;
                    }
                    GlobalMessageBox.Show("原始库存不能修改！");
                    dataGridView.CancelEdit();
                    return;
                }
                if (newCount < 0)
                {
                    GlobalMessageBox.Show("补货数不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
        }
    }
}
