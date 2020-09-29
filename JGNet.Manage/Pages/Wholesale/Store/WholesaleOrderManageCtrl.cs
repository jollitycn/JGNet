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
using JGNet.Core;
using JGNet.Common.cache.Wholesale;
using JGNet.Common;
using JGNet.Core.Tools;
using CJBasic;

namespace JGNet.Manage
{/// <summary>
/// 采购退货查询
/// </summary>
    public partial class WholesaleOrderManageCtrl : BaseModifyCostumeIDUserControl
    {

        private GetPfOrderPagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;

        public string OrderID { get; private set; }

        /// <summary>
        /// 点击补货申请单明细触发
        /// </summary>
        public event CJBasic.Action<PfOrder, Panel, bool> DetailClick;
        public event CJBasic.Action<PfOrder, Panel,string> DetailExcept;
        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }
        /// <summary>
        /// 点击收货按钮触发
        /// </summary>
       // public event CJBasic.Action<ReturnOrder> InboundClick;

        public WholesaleOrderManageCtrl(String orderID = null)
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.批发发货退货单查询;
            OrderID = orderID;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click, new string[] {
                totalCountDataGridViewTextBoxColumn.DataPropertyName, totalPriceDataGridViewTextBoxColumn.DataPropertyName });
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 Column6 });
            dataGridViewPagingSumCtrl.Initialize();
            //dataGridViewPagingSumCtrl.SpecAutoSizeMode(new TKeyValue<DataGridViewColumn, DataGridViewAutoSizeColumnMode>(Column6, DataGridViewAutoSizeColumnMode.ColumnHeader));


            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;

        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        public void Search(String memberID)
        {
            Initialize();
            this.skinTextBox_OrderID.SkinTxt.Text = memberID;
            this.BaseButton_Search_Click(null, null);
        }

        private void Initialize()
        {

            DateTimeUtil.DateTimePicker_Today(dateTimePicker_Start, dateTimePicker_End);
            this.pagePara = new GetPfOrderPagePara();
            this.dataGridViewPagingSumCtrl.Initialize(1);
            this.BindingReturnOrderSource(null);
            this.skinTextBox_costumeID.SkinTxt.Text = string.Empty;
            this.skinTextBox_OrderID.SkinTxt.Text = string.Empty;
            skinComboBox_PfCustomer.Initialize(false, true);

            List<ListItem<PfOrderState>> stateList = new List<ListItem<PfOrderState>>();
            stateList.Add(new ListItem<PfOrderState>(EnumHelper.GetDescription(PfOrderState.All), PfOrderState.All));
            stateList.Add(new ListItem<PfOrderState>(EnumHelper.GetDescription(PfOrderState.Delivery), PfOrderState.Delivery));
            stateList.Add(new ListItem<PfOrderState>(EnumHelper.GetDescription(PfOrderState.Return), PfOrderState.Return));
            this.pfType.DisplayMember = "Key";
            this.pfType.ValueMember = "Value";
            this.pfType.DataSource = stateList;
            SetState();
        }

        private void SetState()
        {
            List<ListItem<PfOrderStateEnum>> stateList = new List<ListItem<PfOrderStateEnum>>();
            stateList.Add(new ListItem<PfOrderStateEnum>(EnumHelper.GetDescription(PfOrderStateEnum.All), PfOrderStateEnum.All));
            stateList.Add(new ListItem<PfOrderStateEnum>(EnumHelper.GetDescription(PfOrderStateEnum.Normal), PfOrderStateEnum.Normal));
            stateList.Add(new ListItem<PfOrderStateEnum>(EnumHelper.GetDescription(PfOrderStateEnum.HangUp), PfOrderStateEnum.HangUp));
            stateList.Add(new ListItem<PfOrderStateEnum>(EnumHelper.GetDescription(PfOrderStateEnum.Cancel), PfOrderStateEnum.Cancel));
            this.skinComboBox_State.DisplayMember = "Key";
            this.skinComboBox_State.ValueMember = "Value";
            this.skinComboBox_State.DataSource = stateList;
        }

        private void BindingDetailSource(List<PfOrderDetail> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (PfOrderDetail detail in list)
                {
                    detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
                }
            }
            this.dataGridViewPagingSumCtrl2.BindingDataSource<PfOrderDetail>(list);
        }

        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (this.pagePara == null)
                {
                    return;
                }
                pagePara.PageIndex = index;
                PfOrderPage listPage = GlobalCache.ServerProxy.GetPfOrderPage(this.pagePara);
                this.BindingReturnOrderSource(listPage);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
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
                if ((pfCustomer.ID == null || pfCustomer.ID == ""|| pfCustomer == null)  && skinComboBox_PfCustomer.Text!="所有")
                {
                   
                        ShowMessage("客户不存在，请重新选择！");
                        skinComboBox_PfCustomer.Focus();
                        return;
                    
                }

                string orderID = string.IsNullOrEmpty(this.skinTextBox_OrderID.SkinTxt.Text) ? null : this.skinTextBox_OrderID.SkinTxt.Text;
                this.pagePara = new GetPfOrderPagePara()
                {
                    PfOrderID = orderID,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    PfCustomerID = pfCustomer.ID,
                    //  SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBox_PfCustomer.SelectedValue),
                    CostumeID = ValidateUtil.CheckEmptyValue(skinTextBox_costumeID.SkinTxt.Text),
                    PfOrderState = (PfOrderState)pfType.SelectedValue,
                    PfOrderStateEnum = (PfOrderStateEnum)skinComboBox_State.SelectedValue

                };
                PfOrderPage listPage = GlobalCache.ServerProxy.GetPfOrderPage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                dataGridViewPagingSumCtrl.Initialize(listPage);
                BindingReturnOrderSource(listPage);
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
        private void BindingReturnOrderSource(PfOrderPage listPage)
        {
            if (listPage != null && listPage.PfOrders != null && listPage.PfOrders.Count > 0)
            {
                List<PfOrder> details = listPage.PfOrders;
                foreach (var item in details)
                {
                    item.PfCustomerName = PfCustomerCache.GetPfCustomerName(item.PfCustomerID);
                    item.AdminUserName = CommonGlobalCache.GetUserName(item.AdminUserID);
                }
            }

            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.PfOrders, null, listPage?.TotalEntityCount, listPage?.PfOrderSum);
            this.skinSplitContainer1.Panel2Collapsed = true;
        }


        private String path;
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
                List<PfOrder> curReturnOrderListSource = (List<PfOrder>)this.dataGridView1.DataSource;
                PfOrder item = curReturnOrderListSource[e.RowIndex];
                if (Column1.Index == e.ColumnIndex)
                {
                    this.skinSplitContainer1.Panel2Collapsed = false;
                    this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2, false);
                }
                else if (Column2.Index == e.ColumnIndex)
                {
                    this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2, true);
                }
                else if (ColumnCancel.Index == e.ColumnIndex)
                {
                    this.Cancel(item);
                }
                else if (ColumnRedo.Index == e.ColumnIndex)
                {
                    this.Redo(item);
                }
                else if (ColumnPick.Index == e.ColumnIndex)
                {
                    this.Pick(item);
                }
                else if (Column4.Index == e.ColumnIndex)
                {
                    string fileName = "";
                    if (item.IsRefundOrder)
                    {
                        fileName = "批发退货单";
                    }
                    else {

                        fileName = "批发发货单";
                    }
                    path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", fileName + item.ID + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
                    if (String.IsNullOrEmpty(path))
                    {
                        return;
                    } 
                    DetailExcept?.Invoke(item, this.skinSplitContainer1.Panel2,path);
                }

            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
        }
        private void Export(PfOrder item)
        {

        }
        private void Cancel(PfOrder allocateOrder)
        {
            try
            {
                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = null;
                allocateOrder.CancelUserID = CommonGlobalCache.CurrentUserID;
                if (allocateOrder.IsRefundOrder)
                {
                    result = GlobalCache.ServerProxy.CancelPfReturn(allocateOrder.ID, CommonGlobalCache.CurrentUserID);
                }
                else
                {
                    result = GlobalCache.ServerProxy.CancelPfDelivery(allocateOrder.ID, CommonGlobalCache.CurrentUserID);
                }
                switch (result?.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("冲单成功！");
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
                this.RefreshPage();
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
            finally
            {
                UnLockPage();
            }
        }
        public event CJBasic.Action<PfOrder, BaseUserControl> RedoClick;

        private void Redo(PfOrder allocateOrder)
        {
            if (this.RedoClick != null)
            {
                this.RedoClick(allocateOrder, this);
            }
        }

        public event CJBasic.Action<PfOrder, BaseUserControl> PickClick;
        private void Pick(PfOrder allocateOrder)
        {
            if (this.PickClick != null)
            {
                this.PickClick(allocateOrder, this);
            }
        }

        #endregion

        private void ReturnOrderManageCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
            if (!String.IsNullOrEmpty(OrderID))
            {
                Search(OrderID);
            }
        }

        public override void HighlightCostume()
        {
            if (dataGridView1.DataSource != null)
            {
                if (!String.IsNullOrEmpty(BaseModifyCostumeID))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        RetailDetail detail = row.DataBoundItem as RetailDetail;
                        HighlightCostume(row, detail?.CostumeID);
                    }
                }
            }
        }

        PfCustomer pfCustomer;
        private void skinComboBox_PfCustomer_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex < -1 || e.ColumnIndex < -1) { return; }
                if (e.Value == null)
                {
                    return;
                }

                DataGridView view = sender as DataGridView;
                PfOrder order = view.Rows[e.RowIndex].DataBoundItem as PfOrder;

                if (e.ColumnIndex == ColumnPick.Index)
                {
                    if ((PfOrderStateEnum)order.State == PfOrderStateEnum.Normal)
                    {
                        e.Value = null;
                    }
                }
                if (e.ColumnIndex == ColumnCancel.Index)
                {
                    if (order.IsCancel || (PfOrderStateEnum)order.State == PfOrderStateEnum.HangUp)
                    {
                        e.Value = null;
                    }
                }
                else if (e.ColumnIndex == ColumnRedo.Index)
                {
                    if (!order.IsCancel || (PfOrderStateEnum)order.State == PfOrderStateEnum.HangUp)
                    {
                        e.Value = null;
                    }
                }
                else if (e.ColumnIndex == ColumnPick.Index)
                {
                    if ((PfOrderStateEnum)order.State == PfOrderStateEnum.Normal)
                    {
                        e.Value = null;
                    }
                }
            }
            catch {
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
 