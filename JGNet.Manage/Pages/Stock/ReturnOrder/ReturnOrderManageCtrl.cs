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
using JGNet.Common;
using JGNet.Core.Const;
using JGNet.Core.Tools;
using JGNet.Core.Dev.InteractEntity;
using JGNet.Core;
using CJBasic.Helpers;
using EnumHelper = JGNet.Core.Tools.EnumHelper;
using CJBasic;
using JieXi.Common;

namespace JGNet.Manage
{/// <summary>
/// 采购退货查询
/// </summary>
    public partial class ReturnOrderManageCtrl : BaseModifyCostumeIDUserControl
    {

        private ReturnOrderPagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;

        public string OrderID { get; private set; }

        /// <summary>
        /// 点击补货申请单明细触发
        /// </summary>
        public event CJBasic.Action<PurchaseOrder, Panel, bool> DetailClick;
        public event CJBasic.Action<PurchaseOrder, Panel, string> DetailExcept;
        public event CJBasic.Action<PurchaseOrder, BaseUserControl> RedoClick;
        public event CJBasic.Action<PurchaseOrder, BaseUserControl> PickClick;
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

        public ReturnOrderManageCtrl(String orderID = null)
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.采购进货退货单查询;
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2);
            dataGridViewPagingSumCtrl2.Initialize();
            OrderID = orderID;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click, new string[] {
                totalCountDataGridViewTextBoxColumn.DataPropertyName,
                totalPriceDataGridViewTextBoxColumn.DataPropertyName });
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 Column6 });
            dataGridViewPagingSumCtrl.Initialize();
            //dataGridViewPagingSumCtrl.SpecAutoSizeMode(new TKeyValue<DataGridViewColumn, DataGridViewAutoSizeColumnMode>(Column6, DataGridViewAutoSizeColumnMode.ColumnHeader));


            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;
            skinComboBoxShopID.Initialize();

        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        public void Search(String memberID)
        {
            Initialize();
            this.skinTextBox_OrderID.SkinTxt.Text = memberID;
            pagePara.IsOpenDate = false;
            this.BaseButton_Search_Click(null, null);
            pagePara.IsOpenDate = true;
        }

        private void Initialize()
        {
            DateTimeUtil.DateTimePicker_Today(dateTimePicker_Start, dateTimePicker_End);
            this.pagePara = new ReturnOrderPagePara();
            this.dataGridViewPagingSumCtrl.Initialize(1);
            this.BindingReturnOrderSource(null);
            this.skinTextBox_costumeID.SkinTxt.Text = string.Empty;
            this.skinTextBox_OrderID.SkinTxt.Text = string.Empty;
           // CommonGlobalUtil.SetSupplier(skinComboBoxSupplierID,false, true);
            SetType();
            SetState();
        }

        private void SetState()
        {
            List<ListItem<PurchaseOrderStateEnum>> stateList = new List<ListItem<PurchaseOrderStateEnum>>();
            stateList.Add(new ListItem<PurchaseOrderStateEnum>(EnumHelper.GetDescription(PurchaseOrderStateEnum.All), PurchaseOrderStateEnum.All));
            stateList.Add(new ListItem<PurchaseOrderStateEnum>(EnumHelper.GetDescription(PurchaseOrderStateEnum.Normal), PurchaseOrderStateEnum.Normal));
            stateList.Add(new ListItem<PurchaseOrderStateEnum>(EnumHelper.GetDescription(PurchaseOrderStateEnum.HangUp), PurchaseOrderStateEnum.HangUp));
            stateList.Add(new ListItem<PurchaseOrderStateEnum>(EnumHelper.GetDescription(PurchaseOrderStateEnum.Cancel), PurchaseOrderStateEnum.Cancel));
            this.skinComboBox_State.DisplayMember = "Key";
            this.skinComboBox_State.ValueMember = "Value";
            this.skinComboBox_State.DataSource = stateList;
        }

        private void SetType()
        {
            List<ListItem<PurchaseOrderState>> stateList = new List<ListItem<PurchaseOrderState>>();
            stateList.Add(new ListItem<PurchaseOrderState>(EnumHelper.GetDescription(PurchaseOrderState.All), PurchaseOrderState.All));
            stateList.Add(new ListItem<PurchaseOrderState>(EnumHelper.GetDescription(PurchaseOrderState.Purchase), PurchaseOrderState.Purchase));
            stateList.Add(new ListItem<PurchaseOrderState>(EnumHelper.GetDescription(PurchaseOrderState.Return), PurchaseOrderState.Return));
            this.rtType.DisplayMember = "Key";
            this.rtType.ValueMember = "Value";
            this.rtType.DataSource = stateList;
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
                ReturnOrderPage listPage = GlobalCache.ServerProxy.GetReturnOrderPage(this.pagePara);
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
                string orderID = string.IsNullOrEmpty(this.skinTextBox_OrderID.SkinTxt.Text) ? null : this.skinTextBox_OrderID.SkinTxt.Text;
                this.pagePara = new ReturnOrderPagePara()
                {
                    ReturnOrderID = orderID,
                    IsOpenDate = true,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBoxSupplierID.SelectedValue),
                    CostumeID = ValidateUtil.CheckEmptyValue(skinTextBox_costumeID.SkinTxt.Text),
                    PurchaseOrderState = (PurchaseOrderState)rtType.SelectedValue,
                    PurchaseOrderStateEnum = (PurchaseOrderStateEnum)skinComboBox_State.SelectedValue,
                    DestShopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue),
                     Remarks=ValidateUtil.CheckEmptyValue(this.txtRemark.SkinTxt.Text),
                };
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                ReturnOrderPage listPage = GlobalCache.ServerProxy.GetReturnOrderPage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingReturnOrderSource(listPage);
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
        private void BindingReturnOrderSource(ReturnOrderPage listPage)
        {
            //   this.dataGridViewPagingSumCtrl.SetDataSource<PurchaseOrder>(null);
            if (listPage != null && listPage.ReturnOrderList != null && listPage.ReturnOrderList.Count > 0)
            {

                List<PurchaseOrder> details = listPage.ReturnOrderList;
                foreach (var item in details)
                {
                    if (item.AdminUserID != null)
                    {
                        try
                        {
                            item.UserName = GlobalCache.GetUserName(item.AdminUserID);
                        } catch (Exception ex)
                        {
                            item.UserName = "";
                        }
                    }
                    if (item.SupplierID != null)
                    {
                        item.SupplierName = GlobalCache.GetSupplierName(item.SupplierID);
                    }
                    item.DestShopName = GlobalCache.GetShopName(item.DestShopID);
                }
            }

            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.ReturnOrderList, null, listPage?.TotalEntityCount, listPage?.ReturnOrderSum);
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
                List<PurchaseOrder> curReturnOrderListSource = (List<PurchaseOrder>)this.dataGridView1.DataSource;
                PurchaseOrder item = curReturnOrderListSource[e.RowIndex];

                if (ColumnOrder.Index == e.ColumnIndex)
                {
                    this.skinSplitContainer1.Panel2Collapsed = false;
                    this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2, false);
                }
                else if (ColumnPrint.Index == e.ColumnIndex)
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
                else if (ColumnPrintBarcode.Index == e.ColumnIndex)
                {
                    this.PrintBarcode(item);
                }
                else if (Column4.Index == e.ColumnIndex)
                {
                    string fileName = "";
                    if (item.ID.StartsWith("U"))
                    {
                        fileName = "采购退货单";
                    }
                    else if (item.ID.StartsWith("A"))
                    {

                        fileName = "采购进货单";
                    } 
                    path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", fileName + item.ID + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
                    if (String.IsNullOrEmpty(path))
                    {
                        return;
                    }
                    this.DetailExcept?.Invoke(item, this.skinSplitContainer1.Panel2, path);
                    
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
        }
        private string path = string.Empty;
        private List<BarCode4Costume> CheckDetailBarCodes(BoundDetail detail)
        {
            List<BarCode4Costume> barCode4Costumes = new List<BarCode4Costume>();

            foreach (var sizeName in CostumeStoreHelper.CostumeSizeColumn)
            {
                barCode4Costumes.AddRange(GetDetailBarCodesCount(detail, sizeName));
            }

            return barCode4Costumes;
        }

        /// <summary>
        /// 获取对应的尺码的数量值
        /// </summary>
        /// <param name="sizeName"></param>
        /// <returns></returns>
        private Int16 GetSizeCount(string sizeName, BoundDetail detail)
        {
            return Int16.Parse(ReflectUtil.GetModelValue(sizeName, detail));
        }

        private List<BarCode4Costume> GetDetailBarCodesCount(BoundDetail detail, string sizeName)
        {
            List<BarCode4Costume> barCode4Costumes = new List<BarCode4Costume>();
            //获取对应尺码的值

            short count = GetSizeCount(sizeName, detail);

            for (int i = 0; i < count; i++)
            {
                BarCode4Costume costume = new BarCode4Costume();
                ReflectionHelper.CopyProperty(detail, costume);
                costume.SizeName = sizeName;
                barCode4Costumes.Add(costume);
            }
            return barCode4Costumes;
        }

        private void PrintBarcode(PurchaseOrder item)
        {
            List<BoundDetail> list = CommonGlobalCache.ServerProxy.GetOutboundDetail(item.InboundOrderID);
            List<BarCode4Costume> barCode4s = new List<BarCode4Costume>();
            foreach (BoundDetail detail in list)
            {
                List<BarCode4Costume> codes = CheckDetailBarCodes(detail);
                barCode4s.AddRange(codes);
            }

            WebResponseObj<List<BarCode4CostumeInfo>> response = GlobalCache.ServerProxy.GetBarCode4CostumeInfos(barCode4s);
            CostumeBarcodePrinter printer = new CostumeBarcodePrinter();
            printer.Print(response?.Data, 1);
        }


        private void SkinTextBox_costumeID_CostumeSelected(Costume costume, bool isEnter)
        { if (costume != null && isEnter) {
                BaseButton_Search_Click(null, null);
            }
        }


        private void Pick(PurchaseOrder item)
        {

            if (String.IsNullOrEmpty(item.SupplierID) && !String.IsNullOrEmpty(item.SupplierAccountID))
            {

                //show form

                //GlobalCache.ServerProxy.PurchaseBindingSupplierID(item.ID,);
                SelectSupplierForm form = new SelectSupplierForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Supplier supplier = form.Result;
                    if (supplier != null)
                    {
                        item.SupplierID = supplier.ID;

                        InteractResult result = GlobalCache.ServerProxy.PurchaseBindingSupplierID(item.ID, item.SupplierID);
                        switch (result.ExeResult)
                        {
                            case ExeResult.Success:
                                this.PickClick?.Invoke(item, this);
                                break;
                            case ExeResult.Error:
                                GlobalMessageBox.Show(result.Msg);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else { 
                    this.PickClick?.Invoke(item, this);
            }
        }

        private void Cancel(PurchaseOrder allocateOrder)
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
                //if (allocateOrder.Type == CostumeStoreTrackChangeType.ReturnOutbound) {
                //    result = GlobalCache.ServerProxy.CancelReturn(allocateOrder.ID, CommonGlobalCache.CurrentUserID);
                //}
                //else
                //{
                allocateOrder.CancelUserID = CommonGlobalCache.CurrentUserID;
                result = GlobalCache.ServerProxy.CancelPurchase(allocateOrder.ID, CommonGlobalCache.CurrentUserID);
                //  }

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

        private void Redo(PurchaseOrder allocateOrder)
        {
            if (this.RedoClick != null)
            {
                this.RedoClick(allocateOrder, this);
            }
        }

        private void BindingOutboundDetailSource(List<BoundDetail> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (BoundDetail detail in list)
                {
                    detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
                }
            }
            dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(DataGridViewUtil.ToDataTable(list));
            //dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(DataGridViewUtil.ListToBindingList(list));

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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < -1 || e.ColumnIndex < -1) { return; }
            if (e.Value == null)
            {
                return;
            }

            DataGridView view = sender as DataGridView;
            PurchaseOrder order = view.Rows[e.RowIndex].DataBoundItem as PurchaseOrder;


            if (e.ColumnIndex == ColumnCancel.Index)
            {
                if (order.IsCancel || (PurchaseOrderStateEnum)order.State == PurchaseOrderStateEnum.HangUp)
                {
                    e.Value = null;
                }
            }
            else if (e.ColumnIndex == ColumnRedo.Index)
            {
                if (!order.IsCancel || (PurchaseOrderStateEnum)order.State == PurchaseOrderStateEnum.HangUp)
                {
                    e.Value = null;
                }
            }
            else if (e.ColumnIndex == ColumnPick.Index) {
                if ((PurchaseOrderStateEnum)order.State == PurchaseOrderStateEnum.Normal)
                {
                    e.Value = null;
                }
            }
           
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index >-1)
            {
                e.Column.Width = 50;
            }
        }
    }
}
 