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
using JGNet.Core.MyEnum;
using JGNet.Common.cache.Wholesale;
using JieXi.Common;

namespace JGNet.Manage

{
    public partial class WholesaleEmOrderManageCtrl : BaseModifyUserControl
    {
        private GetPfCustomerOrderPagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public CJBasic.Action<PfCustomerOrder, BaseUserControl, Panel> DetailClick;
        public CJBasic.Action<PfCustomerOrder, BaseUserControl> DeliveryClick;

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

        public WholesaleEmOrderManageCtrl(int type, CJBasic.Action<PfCustomerOrder, BaseUserControl, Panel> DetailClick)
        {
            InitializeComponent();
            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click);
            dataGridViewPagingSumCtrl.Initialize();
            this.DetailClick += DetailClick;
            SetOrderState();
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            if (type == 0)
            {
                tabControl1.SelectTab(1);
                tabControl1_SelectedIndexChanged(null, null);
            }
            skinComboBox_PfCustomer.Initialize(false, true);
        }

        private void SetOrderState()
        {
            List<ListItem<PfCustomerOrderState>> list = new List<ListItem<PfCustomerOrderState>>();
            list.Add(new ListItem<PfCustomerOrderState>(EnumHelper.GetDescription(PfCustomerOrderState.All), PfCustomerOrderState.All)); 
            list.Add(new ListItem<PfCustomerOrderState>(EnumHelper.GetDescription(PfCustomerOrderState.WaitDelivery), PfCustomerOrderState.WaitDelivery));
            list.Add(new ListItem<PfCustomerOrderState>(EnumHelper.GetDescription(PfCustomerOrderState.PartDelivery), PfCustomerOrderState.PartDelivery));
            list.Add(new ListItem<PfCustomerOrderState>(EnumHelper.GetDescription(PfCustomerOrderState.Finish), PfCustomerOrderState.Finish));
            list.Add(new ListItem<PfCustomerOrderState>(EnumHelper.GetDescription(PfCustomerOrderState.Invalid), PfCustomerOrderState.Invalid));
            skinComboBoxOrderState.DisplayMember = "Key";
            skinComboBoxOrderState.ValueMember = "Value";
            skinComboBoxOrderState.DataSource = list;
        }
         



        //public void WorkDeskCtrlSearch(PfCustomerOrderState orderState, RefundStatus refund)
        //{
        //    //skinComboBoxOrderState.SelectedValue = orderState;
        //    //skinComboBoxRefundState.SelectedValue = refund;
        //    //DateTimeUtil.DateTimePicker_All(dateTimePicker_Start, dateTimePicker_End);
        //    if (orderState == PfCustomerOrderState.All && refund == RefundStatus.Refunding)
        //    {
        //        tabControl1.SelectTab(4);
        //    }
        //    else if(orderState == PfCustomerOrderState.WaitDelivery && refund == RefundStatus.NotSelect)
        //    {
        //        tabControl1.SelectTab(1);
        //    }
            
        //    // tabControl1_SelectedIndexChanged(null, null);
        //    //  BaseButton_Search_Click(null, null);
        //}


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
                PfCustomerOrderPage listPage = GlobalCache.EMallServerProxy.GetPfCustomerOrderPage(this.pagePara);
                this.BindingDataSource(listPage);
                UpdateTabPageTitle(false);

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
                pagePara = new GetPfCustomerOrderPagePara()
                {
                    CustomerOrderId = this.skinTextBoxOrderId.Text,
                    StartDate = new Date(this.dateTimePicker_Start.Value),
                    EndDate = new Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    PfCustomerID = (String)this.skinComboBox_PfCustomer.SelectedValue,
                    CostumeID = this.skinTextBoxID.Text,
                    PfCustomerOrderState = (PfCustomerOrderState)(this.skinComboBoxOrderState.SelectedValue), 
                };

                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                PfCustomerOrderPage listPage = GlobalCache.EMallServerProxy.GetPfCustomerOrderPage(this.pagePara);
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


        private void BindingDataSource(PfCustomerOrderPage listPage)
        {
            splitContainer1.Panel2Collapsed = true;
            if (listPage != null && listPage.PfCustomerOrders != null && listPage.PfCustomerOrders.Count > 0)
            {
                foreach (var item in listPage.PfCustomerOrders)
                {
                    item.PfCustomerName = PfCustomerCache.GetPfCustomerName(item.PfCustomerID);
                }

                this.dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerOrder>(listPage?.PfCustomerOrders, null, listPage?.TotalEntityCount);
            }
            else
            {
                this.dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerOrder>(listPage?.PfCustomerOrders, null, 0);
            }
        }


        private void EmOrderManageCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.Panel2Collapsed = true;
                dataGridView1.DataSource = null;
                pagePara = new GetPfCustomerOrderPagePara() {
                    CustomerOrderId = this.skinTextBoxOrderId.Text,
                    StartDate = new Date(this.dateTimePicker_Start.Value),
                    EndDate = new Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    PfCustomerID = (String)this.skinComboBox_PfCustomer.SelectedValue,
                    CostumeID = this.skinTextBoxID.Text,
                    PfCustomerOrderState = (PfCustomerOrderState)(this.skinComboBoxOrderState.SelectedValue),
                };

                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                //  BaseButton_Search_Click(null,null);
            }
            catch (Exception ex)
            {

                GlobalUtil.ShowError(ex);
            }
        }

        public event CJBasic.Action<PfCustomerOrder, BaseUserControl> OpenModifyDialog;

         
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {

                if (e.RowIndex > -1 && e.ColumnIndex > -1 &&  !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    List<PfCustomerOrder> list = (List<PfCustomerOrder>)view.DataSource;
                    PfCustomerOrder item = (PfCustomerOrder)list[e.RowIndex];
                    //    splitContainer1.Panel2Collapsed = true;
                    DataGridViewCell cell = view.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    switch (cell.OwningColumn.HeaderText)
                    {
                        case "查看物流":
                          //  this.LogisticsClick?.Invoke(item, this.splitContainer1.Panel2);
                          //  splitContainer1.Panel2Collapsed = false;
                            break;
                        case "":
                            // splitContainer1.Panel2Collapsed = false;
                            // this.DetailClick?.Invoke(item, this, this.splitContainer1.Panel2);
                            if ("详情".Equals(cell.FormattedValue))
                            {
                                Detail(item);
                               
                            } 

                            //if ("发货".Equals(cell.FormattedValue)) {
                            //    ShowDeliver(item);
                            //} else if ("查看物流".Equals(cell.FormattedValue)) {
                            //  //  ShowLogistic(item);
                            //}
                            //else if ("待商家处理".Equals(cell.FormattedValue))
                            //{
                            //    ShowWaitSeller(item);
                            //}
                            //else if ("待买家处理".Equals(cell.FormattedValue))
                            //{
                            //    ShowWaitBuyer(item);
                            //}
                            //else if ("退款成功".Equals(cell.FormattedValue))
                            //{
                            //    ShowReturnSuccess(item);
                            //}
                            break;
                        case "导出":
                            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "批发订单" + item.ID + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
                            if (String.IsNullOrEmpty(path))
                            {
                                return;
                            }
                            Export(item);
                            break;
                        //case "订单编号":
                        //     splitContainer1.Panel2Collapsed = false;
                        //    this.DetailClick?.Invoke(item, this, this.splitContainer1.Panel2);
                        //    break;
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

        private void Export(PfCustomerOrder order)
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
              //  keys.Add("F");
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
               // dt.Columns.Add("F");
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


                int noticeNum = 0;
                //  List<EmRetailDetail> listPage = GlobalCache.EMallServerProxy.GetEmRetailDetail(order.ID);
                InteractResult<EmOrderExportData> exportList = GlobalCache.ServerProxy.GetEmPfOrderExportData(order.ID);
                //  exportList.Data.Details
                if (exportList.Data != null && exportList.Data.Details != null && exportList.Data.Details.Count > 0)
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
                        dr["XS"] = eDetail.XS.ToString() == "0" ? "" : eDetail.XS.ToString();
                        dr["S"] = eDetail.S.ToString() == "0" ? "" : eDetail.S.ToString();
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
                        dr["NOticeCount"] = eDetail.NoticeCount;
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
        private void Detail(PfCustomerOrder item)
        {
            WholesaleEmOrderFinishForm form = new WholesaleEmOrderFinishForm(item);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //发货，跳转
                this.DeliveryClick?.Invoke(item, this);
            }
            else if (result == DialogResult.Yes)
            {
                //作废成功
                this.RefreshPage();
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
              //  string pfCustomerOrderID, string adminUserID, List< PfCustomerDetail > details
                InteractResult result = GlobalCache.EMallServerProxy.PfCustomerOrderDelivery(para.EmRetailOrderID,para.ShopID,null);
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
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void EmOrderDeliverForm_RefreshPageAction(EmOutboundPara para) {
            this.RefreshPage();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            DataGridView view = sender as DataGridView;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            PfCustomerOrder order = (PfCustomerOrder)row.DataBoundItem;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

           DateTimeUtil.DateTimePicker_All(dateTimePicker_Start, dateTimePicker_End);
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    skinComboBoxOrderState.SelectedValue = PfCustomerOrderState.All; 
                    //全部
                    break; 
                case 1:
                    skinComboBoxOrderState.SelectedValue = PfCustomerOrderState.WaitDelivery; 
                    //待发货
                    break;
                case 2:
                    skinComboBoxOrderState.SelectedValue = PfCustomerOrderState.PartDelivery; 
                    //部分发货
                    break;
                case 3:
                    skinComboBoxOrderState.SelectedValue = PfCustomerOrderState.Finish; 
                    //已完成
                    break;
                case 4:
                    skinComboBoxOrderState.SelectedValue = PfCustomerOrderState.Invalid; 
                    //已作废
                    break; 
                default:
                    break;
            }

            BaseButton_Search_Click(null, null);
            //重新获取数量
            UpdateTabPageTitle(true);
        }

        private void UpdateTabPageTitle(bool show=false) {

            try
            {
                if (show)
                {
                    PfCustomerOrderCount states = GlobalCache.EMallServerProxy.GetPfCustomerOrderCount();
                    tabPageWaitDeliver.Text = EnumHelper.GetDescription(PfCustomerOrderState.WaitDelivery); 
                    tabPageWaitDeliver.Text += states.WaitDelivery == 0 ? String.Empty: "（" + states.WaitDelivery + "）";
                    tabPagePartDeliver.Text = EnumHelper.GetDescription(PfCustomerOrderState.PartDelivery);
                    tabPagePartDeliver.Text += states.WaitDelivery == 0 ? String.Empty : "（" + states.PartDelivery + "）";
                }
                else
                {
                    tabPageWaitDeliver.Text = EnumHelper.GetDescription(PfCustomerOrderState.WaitDelivery);
                    tabPagePartDeliver.Text = EnumHelper.GetDescription(PfCustomerOrderState.PartDelivery); 
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
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
