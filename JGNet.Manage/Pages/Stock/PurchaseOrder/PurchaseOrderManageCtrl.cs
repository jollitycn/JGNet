using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
using CCWin;

using JGNet.Common.Core.Util;
using JGNet.Common.Core;  
using JGNet.Common.Components;

namespace JGNet.Manage
{
    public partial class PurchaseOrderManageCtrl : BaseModifyUserControl
    {
        
        private PurchaseCostumePagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        /// <summary>
        /// 点击补货申请单明细触发
        /// </summary>
        public event CJBasic.Action<PurchaseOrder,Panel> DetailClick;
        /// <summary>
        /// 点击收货按钮触发
        /// </summary>
       // public event CJBasic.Action<PurchaseOrder> InboundClick;
        public override void RefreshPage()
        {
            if (pagePara != null) { 
            this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }

        private String OrderID { get; set; }
        public PurchaseOrderManageCtrl(String orderID=null)
        {
           InitializeComponent();
            OrderID = orderID;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged,BaseButton_Search_Click, new string[] { totalCountDataGridViewTextBoxColumn.DataPropertyName, totalPriceDataGridViewTextBoxColumn.DataPropertyName });
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 Column6 });
            dataGridViewPagingSumCtrl.Initialize(); 
          
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;
        
        }


        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        public void Search(String memberID)
        { 
            this.skinTextBox_OrderID.Text = memberID;
            pagePara.IsOpenDate = false;
            this.BaseButton_Search_Click(null, null);
            pagePara.IsOpenDate = true;
        }

        private void Initialize()
        {
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            this.pagePara = new PurchaseCostumePagePara();
            this.dataGridViewPagingSumCtrl.Initialize(1);
            this.BindingPurchaseOrderSource(null);
            this.skinTextBox_costumeID.SkinTxt.Text = string.Empty;
            this.skinTextBox_OrderID.SkinTxt.Text = string.Empty;
            GlobalUtil. SetShop(skinComboBoxShopID);
            skinSplitContainer1.Panel2Collapsed = true;
        }

        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (this.pagePara == null)
                {
                    return;
                }
                pagePara.PageIndex = index;
                PurchaseCostumePage listPage = GlobalCache.ServerProxy.GetPurchaseCostumePage(this.pagePara);
                this.BindingPurchaseOrderSource(listPage);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                string orderID = string.IsNullOrEmpty(this.skinTextBox_OrderID.SkinTxt.Text) ? null : this.skinTextBox_OrderID.SkinTxt.Text;
                    this.pagePara = new PurchaseCostumePagePara()
                    {
                        PurchaseOrderID = orderID,
                        IsOpenDate = true,
                        StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                        EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                        PageIndex = 0,
                        PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                        ShopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue),
                        CostumeID = ValidateUtil.CheckEmptyValue(skinTextBox_costumeID.SkinTxt.Text)

                    };
                    PurchaseCostumePage listPage = GlobalCache.ServerProxy.GetPurchaseCostumePage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                    this.BindingPurchaseOrderSource(listPage);
                
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }

        }

        /// <summary>
        /// 绑定plenishOrderSource源到dataGridView中
        /// </summary>
        /// <param name="listPage"></param>
        private void BindingPurchaseOrderSource(PurchaseCostumePage listPage)
        {
            
            if (listPage != null && listPage.PurchaseOrderList != null && listPage.PurchaseOrderList.Count > 0)
            {

                List<PurchaseOrder> details = listPage.PurchaseOrderList;
                foreach (var item in details)
                {
                    if (!String.IsNullOrEmpty(item.DestShopID))
                    {
                        item.ShopName = GlobalCache.GetShopName(item.DestShopID);
                        item.UserName = GlobalCache.GetUserName(item.AdminUserID);
                    }
                }

            }
            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.PurchaseOrderList, null, listPage?.TotalEntityCount, listPage?.PurchaseOrderSum);
            this.skinSplitContainer1.Panel2Collapsed = true; 
        }

        #region 点击单元格
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                List < PurchaseOrder > curPurchaseOrderListSource = (List<PurchaseOrder>)this.dataGridView1.DataSource;
                PurchaseOrder item = curPurchaseOrderListSource[e.RowIndex];
                switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.HeaderText)
                {
                    case "采购进货单明细":
                        if (this.DetailClick != null)
                        {
                            this.skinSplitContainer1.Panel2Collapsed = false;
                            this.DetailClick(item,this.skinSplitContainer1.Panel2);
                        }
                        break; 
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
        }


        #endregion

        private void PurchaseOrderManageCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
            if (!String.IsNullOrEmpty(OrderID)) {
                Search(OrderID);
            }
        }

        private void skinTextBox_costumeID_CostumeSelected(Costume costume, bool isEnter)
        {
            if (costume != null && isEnter)
            {
                BaseButton_Search_Click(null, null);
            }
        }

    }
}
