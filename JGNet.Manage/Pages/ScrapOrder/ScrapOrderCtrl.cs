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
using JGNet.Core.Const;
using JGNet.Common;
using JGNet.Core.Tools;
using CJBasic.Helpers;

namespace JGNet.Manage
{
    public partial class ScrapOrderCtrl : BaseModifyUserControl
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
        private List<BoundDetail> curOutboundDetailList = new List<BoundDetail>();//当前要入库的CostumeStore

        public object GeneralStoreShopID { get; private set; }
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;
        private ScrapOrder order;
        public ScrapOrderCtrl()
        {
            InitializeComponent();
            Init();
            this.IsShowOnePage = true;
        }

        public ScrapOrderCtrl(ScrapOrder order)
        {
            InitializeComponent();
            Init();
            this.order = order;

            if (!HasPermission(RolePermissionMenuEnum.报损单查询, RolePermissionEnum.重做_单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
        }

        private void Init()
        {
            dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl1.ShowRowCounts = false;
            dataGridViewPagingSumCtrl1.Initialize();
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2, new String[] {
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
            SumMoney.DataPropertyName,
            SumCount.DataPropertyName});

            dataGridViewPagingSumCtrl2.ShowRowCounts = false;
            dataGridViewPagingSumCtrl2.Initialize();
            MenuPermission = RolePermissionMenuEnum.报损;
        }

        private void Initialize()
        {
            try
            {
                DataGridViewUtil.SetAlternatingColor(dataGridView1, Color.Gainsboro, Color.White);
                //默认选择总仓
               skinComboBoxShopID.Initialize(true);
                ResetAll();
                GeneralStoreShopID = GlobalCache.GeneralStoreShopID;
                this.skinComboBoxShopID.SelectedValue = GeneralStoreShopID;

                if (order != null)
                { //冲单重做
                    dateTimePicker_Start.Value = order.CreateTime;
                    skinComboBoxShopID.SelectedValue = order.ShopID;
                    List<ScrapDetail> scrapDetails= GlobalCache.ServerProxy.GetScrapDetails(order.ID);
                    this.skinTextBox_Remarks.Text = order.Remarks;
                    curOutboundDetailList =ToBoundDetail(scrapDetails) ;
                }

                this.BindingSource(curOutboundDetailList);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        } 
        private List<BoundDetail> ToBoundDetail(List<ScrapDetail> scrapDetails)
        {
            List<BoundDetail> details = new List<BoundDetail>();
                 

            foreach (var item in scrapDetails)
            {
                BoundDetail detail = new BoundDetail();
                
                ReflectionHelper.CopyProperty(item, detail);
                if (item.SizeName == "F")
                {
                    detail.F =(short)item.ScrapCount;
                }
                if (item.SizeName == "XS")
                {
                    detail.XS = (short)item.ScrapCount;
                }
                if (item.SizeName == "S")
                {
                    detail.S = (short)item.ScrapCount;
                }

                if (item.SizeName == "M")
                {
                    detail.M = (short)item.ScrapCount;
                }
                if (item.SizeName == "L")
                {
                    detail.L = (short)item.ScrapCount;
                }
                if (item.SizeName == "XL")
                {
                    detail.XL = (short)item.ScrapCount;
                }
                if (item.SizeName == "XL2")
                {
                    detail.XL2 = (short)item.ScrapCount;
                }
                if (item.SizeName == "XL3")
                {
                    detail.XL3 = (short)item.ScrapCount;
                }
                if (item.SizeName == "XL4")
                {
                    detail.XL4 = (short)item.ScrapCount;
                }
                if (item.SizeName == "XL5")
                {
                    detail.XL5 = (short)item.ScrapCount;
                }
                if (item.SizeName == "XL6")
                {
                    detail.XL6 = (short)item.ScrapCount;
                }
                details.Add(detail);
            }
            return details;
        }

        private void BindingSource(List<BoundDetail> list)
        {
            this.dataGridView2.DataSource = null;
            if (list != null && list.Count > 0)
            {
                foreach (BoundDetail detail in list)
                {
                    detail.CostumeName = GlobalCache.GetCostumeName(detail.CostumeID);
                }
                this.dataGridView2.DataSource = DataGridViewUtil.ListToBindingList(list);
            }
        }



        //点击出库按钮
        private void BaseButton_Inbound_Click(object sender, EventArgs e)
        {
            try
            {

                ScrapCostume item = this.Build();
                if (item == null || item.OutboundOrder.TotalCount == 0 || item.OutboundDetails.Count == 0)
                {
                    GlobalMessageBox.Show("报损单为空,不能报损！");
                    return;
                }
                if (GlobalMessageBox.Show("确定报损吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                { return; }
 
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = GlobalCache.ServerProxy.Scrap(item);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("报损成功！");
                        if (skinCheckBoxPrint.Checked)
                        {
                            ScrapOrderPrinter.Print(item.ScrapOrder, dataGridView2, 2);
                        }
                        ResetAll();
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

        private void ResetAll()
        {
            costumeFromShopTextBox1.SkinTxt.Text = string.Empty;
            curOutboundDetailList = new List<BoundDetail>();
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;
            this.skinTextBox_Remarks.SkinTxt.Text = string.Empty;
        }

        private ScrapCostume Build()
        {
            if (this.curOutboundDetailList == null || this.curOutboundDetailList.Count == 0)
            {
                return null;
            }
            int totalCount = 0;
            decimal totalPrice = 0;
            decimal totalCost = 0;
            List<BoundDetail> outboundDetails = new List<BoundDetail>();

            //使用报损单的店铺ID信息

            // Shop shop = GlobalCache.ShopList.Find(t => t.ID == this.curReplenishOrder.ShopID);
            Shop shop = (Shop)this.skinComboBoxShopID.SelectedItem;
            string id = IDHelper.GetID(OrderPrefix.OutboundOrder, shop.AutoCode);
            string pOrderID = IDHelper.GetID(OrderPrefix.ScrapOrder, shop.AutoCode);
            foreach (BoundDetail detail in this.curOutboundDetailList)
            {
                if (detail.SumCount <= 0)
                {
                    continue;
                }
                if (detail.Comment == null)
                {
                    detail.Comment = "";
                }
                totalCount += detail.SumCount;
                totalPrice += detail.SumMoney;
                totalCost += detail.SumCost;
                detail.BoundOrderID = id;
                outboundDetails.Add(detail);
            }

            OutboundOrder order = new OutboundOrder()
            { SourceOrderID = pOrderID,
                ID = id,
                OperatorUserID = GlobalCache.CurrentUserID,
                ShopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue),
                CreateTime = dateTimePicker_Start.Value,
                EntryTime = DateTime.Now, 
                TotalCount = totalCount,
                 TotalCost = totalCost,
                TotalPrice = totalPrice,
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text
            };


            ScrapOrder pOrder = new ScrapOrder()
            {
                // GuideID = ValidateUtil.CheckEmptyValue(this.guideComboBox1.SelectedValue),
                ID = pOrderID,
                OperatorUserID = GlobalCache.CurrentUserID,
                OutboundOrderID = order.ID,
                ShopID = order.ShopID, 
                CreateTime =  dateTimePicker_Start.Value,
                EntryTime = DateTime.Now,  
                TotalCount = totalCount, 
                TotalPrice = totalPrice,
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text 
            };

            List<ScrapDetail> scrapDetails = OutboundDetail2ScrapDetail(outboundDetails, pOrderID);
            return new ScrapCostume()
            { 
                ScrapOrder = pOrder,
                OutboundOrder = order,
                OutboundDetails = outboundDetails,
                ScrapDetails = scrapDetails
            };
        }

        private List<ScrapDetail> OutboundDetail2ScrapDetail(List<BoundDetail> outboundDetails, String orderID)
        {
            List<ScrapDetail>
             scrapDetails = new List<ScrapDetail>();

            foreach (var item in outboundDetails)
            {
                if (item.XS > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.XS, item.XS));
                }
                if (item.S > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.S, item.S));
                }
                if (item.M > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.M, item.M));
                }
                if (item.L > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.L, item.L));
                }
                if (item.XL > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.XL, item.XL));
                }
                if (item.XL2 > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.XL2, item.XL2));
                }
                if (item.XL3 > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.XL3, item.XL3));
                }
                if (item.XL4 > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.XL4, item.XL4));
                }
                if (item.XL5 > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.XL5, item.XL5));
                }
                if (item.XL6 > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.XL6, item.XL6));
                }
                if (item.F > 0)
                {
                    scrapDetails.Add(NewScrapDetail(orderID, item, CostumeSize.F, item.F));
                }

            }
            return scrapDetails;
        }

        private ScrapDetail NewScrapDetail(string orderID, BoundDetail item, string sizeName, short count)
        {
            ScrapDetail scrap = new ScrapDetail();
            scrap.ScrapOrderID = orderID;
            scrap.CostumeID = item.CostumeID;
            scrap.ColorName = item.ColorName;
            scrap.Price = item.Price;
            scrap.SizeName = sizeName;
            scrap.ScrapCount = count;
            return scrap;
        }


        #region 验证单元格中的值




        #endregion

        private void costumeFromSupplierTextBox1_CostumeSelected(CostumeItem costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                if (costumeItem == null)
                {
                    //this.costumeFromShopTextBox1.SkinTxt.Text = "";
                    this.curSelectedCostumeStoreList = null;
                }
                else
                {
                    this.curSelectedCostumeStoreList = new List<CostumeStore>();
                    //    this.costumeFromShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
                    List<CostumeStore> stores = CostumeFromShopTextBox.GetCostumeStores(costumeItem, false);
                    foreach (var item in stores)
                    {
                        AddItem4Display(item);
                    }
                }

                this.BindingSelectedCostumeStoreSource();
            }
        }

        /// <summary>
          /// 添加库存到绑定源中用于显示
          /// </summary>
          /// <param name="store"></param>
          /// <param name="isUpdate">是否是修改盘点单(新增时为false，修改时为true) </param>
        private void AddItem4Display(CostumeStore store)
        {
            store.Title = "库存";
            this.curSelectedCostumeStoreList.Add(store);
            this.curSelectedCostumeStoreList.Add(this.ReSetCostumeStoreCount(store));
        }

        /// <summary>
        /// 根据条件 将库存数是否重置为0，便于盘点修改
        /// </summary>
        /// <param name="store"></param>
        /// <param name="isUpdate">是否是修改盘点单(新增时为false，修改时为true) </param>
        private CostumeStore ReSetCostumeStoreCount(CostumeStore store)
        {

            if (store == null)
            {
                return null;
            }
            CostumeStore costumeStore = new CostumeStore();
            CJBasic.Helpers.ReflectionHelper.CopyProperty(store, costumeStore);
            costumeStore.Title = "报损";
            //if (this.curUpdatedCheckStoreOrder == null)
            //{
            costumeStore.XS = 0;
            costumeStore.L = 0;
            costumeStore.M = 0;
            costumeStore.S = 0;
            costumeStore.XL = 0;
            costumeStore.XL2 = 0;
            costumeStore.XL3 = 0;
            costumeStore.XL4 = 0;
            costumeStore.XL5 = 0;
            costumeStore.XL6 = 0;
            costumeStore.F = 0;
            //  }
            return costumeStore;
        }


        /// <summary>
        /// 绑定要报损的集合源
        /// </summary>
        private void BindingOutboundDetailSource()
        { 
            if (this.curOutboundDetailList != null && this.curOutboundDetailList.Count > 0)
            {
                foreach (BoundDetail detail in this.curOutboundDetailList)
                {
                    detail.CostumeName = GlobalCache.GetCostumeName(detail.CostumeID);
                }
            }
            dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(DataGridViewUtil.ListToBindingList(this.curOutboundDetailList));
        }

        /// <summary>
        /// 绑定选定款号对应的CostumeStore集合
        /// </summary>
        private void BindingSelectedCostumeStoreSource()
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
                    //重新排序，同款同颜色排一起，且将报损数量拍在库存后面
                    this.curSelectedCostumeStoreList.Sort((x, y) =>
                    {
                        int sort = x.ColorName.CompareTo(y.ColorName);
                        if (sort == 0)
                        {
                            sort = -x.Title.CompareTo(y.Title);
                        }
                        return sort;
                    });
                    this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList( this.curSelectedCostumeStoreList);
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
                    row.HeaderCell.Value = "报损";
                }
            }

            this.dataGridView1.Refresh();
            dataGridViewPagingSumCtrl1.AutoFocusToWritableCell();
        }
 
         
        private void BaseButton_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.curSelectedCostumeStoreList == null || this.curSelectedCostumeStoreList.Count == 0)
                {
                    return;
                }
                List<CostumeStore> costumeStoreList = this.curSelectedCostumeStoreList;
                
                foreach (CostumeStore store in costumeStoreList)
                {
                    if (store.Title=="库存" || store.SumCount == 0)
                    {
                        continue;
                    }
                    BoundDetail detail = this.CostumeStoreConvertToOutboundDetail(store);
                    this.OutboundDetailListAddItem(detail);
                }
                
                
                
                //清空dataGirdView1的绑定源
                this.costumeFromShopTextBox1.Text = string.Empty;
                this.dataGridView1.DataSource = null;
                this.BindingOutboundDetailSource();
                this.costumeFromShopTextBox1.Focus();
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee); 
            }
        }


        /// <summary>
        /// 将CostumeStore转化为OutboundDetail  
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        private BoundDetail CostumeStoreConvertToOutboundDetail(CostumeStore store)
        {
            if (store == null)
            {
                return null;
            }
            return new BoundDetail()
            {
                CostumeID = store.CostumeID,
                CostumeName = GlobalCache.GetCostumeName(store.CostumeID),
                ColorName = store.ColorName,
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
                Price = store.Price,
                CostPrice = store.CostPrice,
                Comment = store.Remarks
            };
        }

        private void OutboundDetailListAddItem(BoundDetail detail)
        {
            bool existed = false;
            DialogResult result = DialogResult.No;
            BoundDetail repeatItem = null;
            foreach (BoundDetail item in this.curOutboundDetailList)
            {
                if (item.CostumeID.ToUpper() == detail.CostumeID.ToUpper() && item.ColorName == detail.ColorName)
                {
                    repeatItem = item;
                       existed = true; 
                    result = GlobalMessageBox.Show(string.Format("款号：{0}  颜色：{1} 的服装已经存在待报损列表中，是否覆盖", item.CostumeID, item.ColorName),"", MessageBoxButtons.YesNo);
                     
                    break;
                }
            }

            if (!existed || result == DialogResult.Yes)
            {
                //不存在或者重复时直接覆盖
                if (repeatItem != null)
                {
                    this.curOutboundDetailList.Remove(repeatItem);
                }

                this.curOutboundDetailList.Add(detail);
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
                        this.curOutboundDetailList.RemoveAt(e.RowIndex);
                        this.BindingOutboundDetailSource();
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

                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = decimal.Parse(e.FormattedValue.ToString());
                }
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > e.RowIndex &&  this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
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
                    GlobalMessageBox.Show("报损数不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }
            }
            catch(Exception ex)
            {  GlobalMessageBox.Show("输入格式错误！" );
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

 

        private void ScrapOrderCtrl_Load(object sender, EventArgs e)
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
            costumeFromShopTextBox1.ShopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);
        }
         
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //库存 也不用变色
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex % 2 == 0 || dataGridView1.Rows.Count < 0) { return; }

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewUtil.CellPainting_SetCellFont(dataGridView1, cell, 3, 14, Color.Green, FontStyle.Bold);
        }

        private void dataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //库存 也不用变色
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dataGridView2.Rows.Count < 0) { return; }

            DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewUtil.CellPainting_SetCellFont(dataGridView2, cell, 4, 15, Color.Green, FontStyle.Bold);
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
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > e.RowIndex  && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
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
                    GlobalMessageBox.Show("报损数不能小于0！");
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

        private void baseButton1_Click(object sender, EventArgs e)
        {
            if (GlobalMessageBox.Show("确定清空下表数据吗？", "友情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView2.DataSource = null;
                curOutboundDetailList?.Clear();
                dataGridView2.Refresh();
            }
        }
         
    }
}
