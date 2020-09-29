using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CJBasic.Widget;
using CJBasic;
using CJBasic.Loggers;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
 
using CCWin.SkinControl;
using JGNet.Core.Tools;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Manage.Components;
using JieXi.Common;

namespace JGNet.Manage

{
    public partial class EmOrderManageCtrl : BaseModifyUserControl
    {
        private GetEmOrderPagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;


        public CJBasic.Action<EmRetailOrder, BaseUserControl, Panel> DetailClick;
        public CJBasic.Action<EmRetailOrder, Panel> LogisticsClick;

        public override void RefreshPage()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.RefreshPage));
            }
            else
            {
                if (pagePara != null)
                {
                    this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
                }
            }

        }



        public EmOrderManageCtrl(int type, CJBasic.Action<EmRetailOrder, BaseUserControl, Panel> DetailClick, CJBasic.Action<EmRetailOrder, Panel> LogisticsClick)
        {
            InitializeComponent();

            MenuPermission = RolePermissionMenuEnum.订单管理;
            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click);
            dataGridViewPagingSumCtrl.Initialize();
            this.DetailClick += DetailClick;
            this.LogisticsClick += LogisticsClick;
            dataGridViewPagingSumCtrl.SelectionChanged = dataGridView1_SelectionChanged;


            SetOrderState();
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            SetRefundStateEnum();
            if (type == 0)
            {
                tabControl1.SelectTab(2);
                tabControl1_SelectedIndexChanged(null, null);
            }
        }

        private void SetOrderState()
        {
            List<ListItem<EmRetailOrderState>> list = new List<ListItem<EmRetailOrderState>>();
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.All), EmRetailOrderState.All));
            //list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.Closed), OrderState.Closed));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.WaitPay), EmRetailOrderState.WaitPay));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.WaitDelivery), EmRetailOrderState.WaitDelivery));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.WaitSign), EmRetailOrderState.WaitSign));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.Finish), EmRetailOrderState.Finish));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.Closed), EmRetailOrderState.Closed));
            skinComboBoxOrderState.DisplayMember = "Key";
            skinComboBoxOrderState.ValueMember = "Value";
            skinComboBoxOrderState.DataSource = list;
        }

        private void SetRefundStateEnum()
        {
            List<ListItem<RefundStatus>> list = new List<ListItem<RefundStatus>>();
            list.Add(new ListItem<RefundStatus>(EnumHelper.GetDescription(RefundStatus.NotSelect), RefundStatus.NotSelect));
            list.Add(new ListItem<RefundStatus>(EnumHelper.GetDescription(RefundStatus.RefundingRefundSuccess), RefundStatus.RefundingRefundSuccess));
            list.Add(new ListItem<RefundStatus>(EnumHelper.GetDescription(RefundStatus.Refunding), RefundStatus.Refunding));
            list.Add(new ListItem<RefundStatus>(EnumHelper.GetDescription(RefundStatus.RefundSuccess), RefundStatus.RefundSuccess));
            skinComboBoxRefundState.DisplayMember = "Key";
            skinComboBoxRefundState.ValueMember = "Value";
            skinComboBoxRefundState.DataSource = list;
        }


        public void WorkDeskFilteCtrlSearch(EmRetailOrderState orderState, RefundStatus refund)
        {
            if (orderState == EmRetailOrderState.All && refund == RefundStatus.Refunding)
            {
                tabControl1.SelectTab(4);
            }
            else if (orderState == EmRetailOrderState.WaitDelivery && refund == RefundStatus.NotSelect)
            {
                tabControl1.SelectTab(2);
            }

            DateTimeUtil.DateTimePicker_All(dateTimePicker_Start, dateTimePicker_End);
            GetEmOrderPagePara pageParaOfWork = new GetEmOrderPagePara()
            {
                OrderID = this.skinTextBoxOrderId.Text,
                StartDate = new Date(this.dateTimePicker_Start.Value),
                EndDate = new Date(this.dateTimePicker_End.Value),
                PageIndex = 0,
                PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                MemberPhoneOrName = null,
                CostumeIDOrName = null,
                OrderState = EmRetailOrderState.All,
                RefundStatus = RefundStatus.Refunding,
            };

            EmOrderPage listPage = GlobalCache.EMallServerProxy.GetEmOrderPage(pageParaOfWork);
            List<EmRetailOrder> orderList = listPage.ResultList.FindAll(t => t.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.RefundApplication) || t.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.Refunding));

            dataGridViewPagingSumCtrl.OrderPara = pagePara;
            //this.dataGridViewPagingSumCtrl.Initialize(orderList);

            splitContainer1.Panel2Collapsed = true;
            this.dataGridViewPagingSumCtrl.BindingDataSource<EmRetailOrder>(orderList, null, orderList.Count);
            if (orderList != null && orderList.Count > 0)
            {
                dataGridView1_SelectionChanged(dataGridView1, null);
            }

            UpdateTabPageTitle(false);


        }


        public void WorkDeskCtrlSearch(EmRetailOrderState orderState, RefundStatus refund)
        {
            //skinComboBoxOrderState.SelectedValue = orderState;
            //skinComboBoxRefundState.SelectedValue = refund;
            //DateTimeUtil.DateTimePicker_All(dateTimePicker_Start, dateTimePicker_End);
            if (orderState == EmRetailOrderState.All && refund == RefundStatus.Refunding)
            {
                tabControl1.SelectTab(4);
            }
            else if (orderState == EmRetailOrderState.WaitDelivery && refund == RefundStatus.NotSelect)
            {
                tabControl1.SelectTab(2);
            }

            // tabControl1_SelectedIndexChanged(null, null);
            //  BaseButton_Search_Click(null, null);
        }


        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (this.pagePara == null)
                {
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                pagePara.PageIndex = index;
                EmOrderPage listPage = GlobalCache.EMallServerProxy.GetEmOrderPage(this.pagePara);
                this.BindingDataSource(listPage);

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
                pagePara = new GetEmOrderPagePara()
                {
                    OrderID = this.skinTextBoxOrderId.Text,
                    StartDate = new Date(this.dateTimePicker_Start.Value),
                    EndDate = new Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    MemberPhoneOrName = this.textBoxPhoneOrName.Text,
                    CostumeIDOrName = this.skinTextBoxID.Text,
                    OrderState = (EmRetailOrderState)(this.skinComboBoxOrderState.SelectedValue),
                    RefundStatus = (RefundStatus)(this.skinComboBoxRefundState.SelectedValue),
                };

                EmOrderPage listPage = GlobalCache.EMallServerProxy.GetEmOrderPage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingDataSource(listPage);
                UpdateTabPageTitle(false);
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


        private void BindingDataSource(EmOrderPage listPage)
        {
            splitContainer1.Panel2Collapsed = true;
            this.dataGridViewPagingSumCtrl.BindingDataSource<EmRetailOrder>(listPage?.ResultList, null, listPage?.TotalEntityCount);
            if (listPage != null && listPage.ResultList != null && listPage.ResultList.Count > 0)
            {

                dataGridView1_SelectionChanged(dataGridView1, null);
            }
        }


        private void EmOrderManageCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.Panel2Collapsed = true;
                dataGridView1.DataSource = null;
                //pagePara = new GetEmOrderPagePara();
            }
            catch (Exception ex)
            {

                GlobalUtil.ShowError(ex);
            }
        }

        public event CJBasic.Action<EmRetailOrder, BaseUserControl> OpenModifyDialog;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {

                if (e.RowIndex > -1 && e.ColumnIndex > -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    List<EmRetailOrder> list = (List<EmRetailOrder>)view.DataSource;
                    EmRetailOrder item = (EmRetailOrder)list[e.RowIndex];
                    //    splitContainer1.Panel2Collapsed = true;
                    DataGridViewCell cell = view.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    switch (cell.OwningColumn.HeaderText)
                    {
                        case "查看物流":
                            //  this.LogisticsClick?.Invoke(item, this.splitContainer1.Panel2);
                            //  splitContainer1.Panel2Collapsed = false;
                            break;
                        case "操作":
                            // splitContainer1.Panel2Collapsed = false;
                            // this.DetailClick?.Invoke(item, this, this.splitContainer1.Panel2);
                            if ("发货".Equals(cell.FormattedValue))
                            {
                                ShowDeliver(item);
                            }
                            else if ("查看物流".Equals(cell.FormattedValue))
                            {
                                ShowLogistic(item);
                            }
                            else if ("待商家处理".Equals(cell.FormattedValue))
                            {
                                ShowWaitSeller(item);
                            }
                            else if ("待买家处理".Equals(cell.FormattedValue))
                            {
                                ShowWaitBuyer(item);
                            }
                            else if ("退款成功".Equals(cell.FormattedValue))
                            {
                                ShowReturnSuccess(item);
                            }
                            break;
                        case "订单编号":
                            splitContainer1.Panel2Collapsed = false;
                            this.DetailClick?.Invoke(item, this, this.splitContainer1.Panel2);
                            break;
                        case "导出":

                            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "零售订单" + item.ID + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
                            if (String.IsNullOrEmpty(path))
                            {
                                return;
                            }
                            Export(item);
                            break;
                        default: break;

                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        private string path = string.Empty;


        private void Export(EmRetailOrder order)
        {


            try
            {


                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                keys.Add("CostumeID");
                keys.Add("CostumeName");
                keys.Add("单位");
                keys.Add("渠道供货商");
                keys.Add("ColorID");
                keys.Add("ColorName");
                keys.Add("Size");
               // keys.Add("F");
                keys.Add("XS");
                keys.Add("S");
                keys.Add("M");
                keys.Add("L");
                keys.Add("XL");
                keys.Add("2XL");
                keys.Add("3XL");
                keys.Add("4XL");
                keys.Add("5XL");
                keys.Add("6XL");
                keys.Add("SameSize");
                keys.Add("Count");
                keys.Add("NOticeCount");
                keys.Add("DiffCount");
                keys.Add("SalePrice");
                keys.Add("Discount");
                keys.Add("SaleSinglePrice");
                keys.Add("SaleTotalPrice");
                keys.Add("Remark");

                #region
                values.Add("商品代码");
                values.Add("商品名称");
                values.Add("单位");
                values.Add("渠道供货商");
                values.Add("色号");
                values.Add("颜色");
                values.Add("尺码档");
              //  values.Add("F");
                values.Add("XS");
                values.Add("S");
                values.Add("M");
                values.Add("L");
                values.Add("XL");
                values.Add("2XL");
                values.Add("3XL");
                values.Add("4XL");
                values.Add("5XL");
                values.Add("6XL");
                values.Add("均码");
                values.Add("数量");
                values.Add("通知数");
                values.Add("差异数");
                values.Add("标准价");
                values.Add("折扣");
                values.Add("单价");
                values.Add("金额");
                values.Add("摘要");
                #endregion

                DataTable dt = new DataTable();
                dt.Columns.Add("CostumeID");
                dt.Columns.Add("CostumeName");
                dt.Columns.Add("单位");
                dt.Columns.Add("渠道供货商");
                dt.Columns.Add("ColorID");
                dt.Columns.Add("ColorName");
                dt.Columns.Add("Size");
             //  dt.Columns.Add("F");
                dt.Columns.Add("XS");
                dt.Columns.Add("S");
                dt.Columns.Add("M");
                dt.Columns.Add("L");
                dt.Columns.Add("XL");
                dt.Columns.Add("2XL");
                dt.Columns.Add("3XL");
                dt.Columns.Add("4XL");
                dt.Columns.Add("5XL");
                dt.Columns.Add("6XL");
                dt.Columns.Add("SameSize");
                dt.Columns.Add("Count");
                dt.Columns.Add("NOticeCount");
                dt.Columns.Add("DiffCount");
                dt.Columns.Add("SalePrice");
                dt.Columns.Add("Discount");
                dt.Columns.Add("SaleSinglePrice");
                dt.Columns.Add("SaleTotalPrice");
                dt.Columns.Add("Remark");



              //  List<EmRetailDetail> listPage = GlobalCache.EMallServerProxy.GetEmRetailDetail(order.ID);
                 InteractResult<EmOrderExportData> exportList=GlobalCache.ServerProxy.GetEmRetailOrderExportData(order.ID);
                //  exportList.Data.Details
                int noticeNum = 0;
                if (exportList.Data != null && exportList.Data.Details!=null && exportList.Data.Details.Count > 0)
                {
                    foreach (EmOrderExportDetail eDetail in exportList.Data.Details)
                    {
                        DataRow dr = dt.NewRow();
                        dr["CostumeID"] = eDetail.CostumeID; 
                        dr["CostumeName"] = eDetail.CostumeName;
                        dr["ColorID"] = eDetail.ColorID;
                        dr["ColorName"] = eDetail.ColorName;
                        dr["Size"] = "";
                       // dr["F"] = eDetail.F;
                        dr["XS"] = eDetail.XS.ToString()=="0"? "": eDetail.XS.ToString();
                        dr["S"] = eDetail.S.ToString()=="0"?"": eDetail.S.ToString();
 
                        dr["M"] = eDetail.M.ToString() == "0" ? "" : eDetail.M.ToString();
                        dr["L"] = eDetail.L.ToString() == "0" ? "" : eDetail.L.ToString();
                        dr["XL"] = eDetail.XL.ToString() == "0" ? "" : eDetail.XL.ToString();
                        dr["2XL"] = eDetail.XL2.ToString() == "0" ? "" : eDetail.XL2.ToString();
                        dr["3XL"] = eDetail.XL3.ToString() == "0" ? "" : eDetail.XL3.ToString();
                        dr["4XL"] = eDetail.XL4.ToString() == "0" ? "" : eDetail.XL4.ToString();
                        dr["5XL"] = eDetail.XL5.ToString() == "0" ? "" : eDetail.XL5.ToString();
                        dr["6XL"] = eDetail.XL6.ToString() == "0" ? "" : eDetail.XL6.ToString();
                        dr["SameSize"] = eDetail.F.ToString() == "0" ? "" : eDetail.F.ToString();
                        dr["Count"] = eDetail.Count.ToString() == "0" ? "" : eDetail.Count.ToString();
                        dr["NOticeCount"] =eDetail.NoticeCount;
                        dr["DiffCount"] = eDetail.DifferenceCount;
                        dr["SalePrice"] = eDetail.OnlinePrice;
                        dr["Discount"] = eDetail.Discount;
                        dr["SaleSinglePrice"] = eDetail.Price;
                        dr["SaleTotalPrice"] = eDetail.SumMoney;
                        dr["Remark"] = eDetail.Remarks;
                        dt.Rows.Add(dr);

                        noticeNum += eDetail.NoticeCount;
                    }
                }


                NPOIHelper.hsRowCount = 22;
                List<CellType> cellList = EmExportUtil.getSaleCellList(exportList.Data);
                NPOIHelper.CellValues = cellList;



                List<CellType> cellButtomList = new List<CellType>();
                NPOIHelper.bottomHsRowCount = 1;

                CellType curCellIT = new CellType();
                curCellIT.RowIndex = dt.Rows.Count + 23;
                curCellIT.CellName = "合计：";
                curCellIT.IsCollect = true;
                curCellIT.CellMergeNum = 1;

                cellButtomList.Add(curCellIT);
                for (int k = 0; k < 18; k++)
                {
                    CellType curCellI = new CellType();
                    curCellI.RowIndex = dt.Rows.Count + 23;
                    curCellI.CellName = "";
                    curCellI.CellMergeNum = 1;

                    cellButtomList.Add(curCellI);
                }

                CellType curCellTotal = new CellType();
                curCellTotal.RowIndex = dt.Rows.Count + 23;//1是要多加一行标题列
                curCellTotal.CellName = noticeNum.ToString();
                curCellTotal.IsCollect = true;
                curCellTotal.CellMergeNum = 1;

                cellButtomList.Add(curCellTotal); 
                NPOIHelper.BottomCellValues = cellButtomList;





                NPOIHelper.Keys = keys.ToArray();
                NPOIHelper.Values = values.ToArray();







                NPOIHelper.ExportExcel(dt, path);




                GlobalMessageBox.Show("导出完毕！");
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }
        private void ShowReturnSuccess(EmRetailOrder item)
        {
            EmOrderSellerForm form
                  = new EmOrderSellerForm(item);
            form.ShowDialog();
        }

        private void ShowWaitBuyer(EmRetailOrder item)
        {
            EmOrderSellerForm form
                  = new EmOrderSellerForm(item);
            form.ShowDialog();
        }

        private void ShowWaitSeller(EmRetailOrder item)
        {
            EmOrderSellerForm form
                = new EmOrderSellerForm(item);
            form.ShowDialog();
        }



        private void ShowLogistic(EmRetailOrder item)
        {
            EmOrderLogisticsForm form
                = new EmOrderLogisticsForm(item);
            //form.RefreshPageAction += EmOrderDeliverForm_RefreshPageAction;
            form.ShowDialog();
        }


        private void ShowDeliver(EmRetailOrder item)
        {
            try
            {
                EmOrderDeliverForm2 form = new EmOrderDeliverForm2(item);
                // form.RefreshPageAction += EmOrderDeliverForm_RefreshPageAction;
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (GlobalUtil.EngineUnconnectioned(this))
                        {
                            return;
                        }

                        para = form.Result;
                        CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.GetInfo);
                        cb.BeginInvoke(null, null);
                    }
                }
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                //   GlobalUtil.UnLockPage(this);
            }
        }


        private EmOutboundPara para;


        private void GetInfo()
        {
            try
            {

                if (!String.IsNullOrEmpty(para.ExpressCompany))
                {
                    bool rightExpress = KuaiDi100Helper.CheckKuaiDi(GlobalUtil.GetExpressCode(this, para.ExpressCompany), para.ExpressOrderID);

                    if (!rightExpress)
                    {
                        ShowMessage("单号不存在或者已过期！");
                        return;
                    }
                }

                InteractResult result = GlobalCache.EMallServerProxy.EmOutbound(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        ShowMessage("发货成功！");
                        RefreshPage();
                        break;
                    case ExeResult.Error:
                        ShowMessage(result.Msg);
                        break;
                    default:
                        break;
                }

            }
            catch (KuaiDiException ex)
            {
                ShowErrorMessage(ex.Message);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }


        private void EmOrderDeliverForm_RefreshPageAction(EmOutboundPara para)
        {
            this.RefreshPage();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            DataGridView view = sender as DataGridView;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            EmRetailOrder order = (EmRetailOrder)row.DataBoundItem;

            if (orderStateDataGridViewTextBoxColumn.Index == e.ColumnIndex)
            {
                if (order.IsClosed)
                {
                    e.Value = "已关闭";
                }
            }
            else
            if (Column1.Index == e.ColumnIndex)
            {
                // e.Value = "待商家处理";
                if (order.OrderStateName == EmRetailOrder.GetOrderState(EmRetailOrderState.WaitPay))
                {
                    //待付款
                    e.Value = String.Empty;
                }
                else
                if (order.OrderStateName == EmRetailOrder.GetOrderState(EmRetailOrderState.WaitDelivery))
                {
                    //待发货
                    e.Value = "发货";
                }
                else
                if (order.OrderStateName == EmRetailOrder.GetOrderState(EmRetailOrderState.WaitSign))
                {
                    //待收货=已发货
                    e.Value = "查看物流";
                }

                if (order.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.RefundApplication) || order.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.Refunding))
                {
                    //  判断订单处于：“0：退款申请中”、“3：退款中”，则这些订单的操作是：【待商家处理】。
                    e.Value = "待商家处理";
                }
                else
                if (order.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.Refused) || order.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.WriteExpress))
                {
                    //  判断订单处于：“0：退款申请中”、“3：退款中”，则这些订单的操作是：【待商家处理】。
                    e.Value = "待买家处理";
                }
                else
                if (order.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.Refunded))
                {
                    // 判断订单处于：“4：已退款” ，则这些订单的操作是：【退款成功】
                    e.Value = "退款成功";
                }
                //   待买家处理
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView view = (DataGridView)sender;
                EmRetailOrder item = view.CurrentRow.DataBoundItem as EmRetailOrder;
                splitContainer1.Panel2Collapsed = false;
                this.DetailClick?.Invoke(item, this, this.splitContainer1.Panel2);

            }
            catch (Exception ex)
            {
                //   ShowError(ex);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DateTimeUtil.DateTimePicker_All(dateTimePicker_Start, dateTimePicker_End);
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    skinComboBoxOrderState.SelectedValue = EmRetailOrderState.All;
                    skinComboBoxRefundState.SelectedValue = RefundStatus.NotSelect;
                    //全部
                    break;
                case 1:
                    skinComboBoxOrderState.SelectedValue = EmRetailOrderState.WaitPay;
                    skinComboBoxRefundState.SelectedValue = RefundStatus.NotSelect;
                    //待付款
                    break;
                case 2:
                    skinComboBoxOrderState.SelectedValue = EmRetailOrderState.WaitDelivery;
                    skinComboBoxRefundState.SelectedValue = RefundStatus.NotSelect;
                    //待发货
                    break;
                case 3:
                    skinComboBoxOrderState.SelectedValue = EmRetailOrderState.WaitSign;
                    skinComboBoxRefundState.SelectedValue = RefundStatus.NotSelect;
                    //已发货
                    break;
                case 4:
                    skinComboBoxOrderState.SelectedValue = EmRetailOrderState.All;
                    skinComboBoxRefundState.SelectedValue = RefundStatus.Refunding;
                    //退款售后
                    break;
                case 5:
                    skinComboBoxOrderState.SelectedValue = EmRetailOrderState.Finish;
                    skinComboBoxRefundState.SelectedValue = RefundStatus.NotSelect;
                    //已完成
                    break;
                case 6:
                    skinComboBoxOrderState.SelectedValue = EmRetailOrderState.Closed;
                    skinComboBoxRefundState.SelectedValue = RefundStatus.NotSelect;
                    //已关闭
                    break;
                default:
                    break;
            }

            BaseButton_Search_Click(null, null);
            //重新获取数量
            UpdateTabPageTitle(true);
        }

        private void UpdateTabPageTitle(bool show = false)
        {

            try
            {
                if (show)
                {

                    EmOrderCount4State states = GlobalCache.EMallServerProxy.GetEmOrderCount4State();
                    tabPage2.Text = states.WaitPay == 0 ? "待付款" : "待付款（" + states.WaitPay + "）";
                    tabPage3.Text = states.WaitDelivery == 0 ? "待发货" : "待发货（" + states.WaitDelivery + "）";
                    tabPage4.Text = states.WaitSign == 0 ? "已发货" : "已发货（" + states.WaitSign + "）";
                    tabPage5.Text = states.Refunding == 0 ? "退款|售后" : "退款|售后（" + states.Refunding + "）";

                }
                else
                {
                    tabPage2.Text = "待付款";
                    tabPage3.Text = "待发货";
                    tabPage4.Text = "已发货";
                    tabPage5.Text = "退款|售后";
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                tabControl1.Invalidate();
            }
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            EmOrderExportConfigSetForm AddBrand = new EmOrderExportConfigSetForm();
            try
            {
                if (AddBrand.ShowDialog(this) == DialogResult.OK)
                {

                    this.RefreshPage();
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
    }


}
