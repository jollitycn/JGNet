using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core.InteractEntity;
using CCWin;

using JGNet.Common.Core;  
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using CCWin.SkinControl;
using JGNet.Manage.Components;
using JGNet.Common.cache.Wholesale;
using JGNet.Common;
using JGNet.Core.Tools;
using CJBasic;
using JieXi.Common;

namespace JGNet.Manage
{
    public partial class WholesaleCollectionManageCtrl : BaseModifyUserControl
    {

        private PfCollectionManagePara pagePara;
        public event CJBasic.Action<String, BaseUserControl, Panel> SourceOrderDetailClick;

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<PfCustomerAccountRecord,Type>PfCustomerAccountRecordDetailClick;
        public WholesaleCollectionManageCtrl()
        {
            InitializeComponent();

            MenuPermission =RolePermissionMenuEnum.销售收款管理;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click, new string[] {
            accountMoneyDataGridViewTextBoxColumn.DataPropertyName}); 
            dataGridViewPagingSumCtrl.Initialize();
            //  dataGridViewPagingSumCtrl.SpecAutoSizeMode(new TKeyValue<DataGridViewColumn, DataGridViewAutoSizeColumnMode>(remarksDataGridViewTextBoxColumn, DataGridViewAutoSizeColumnMode.ColumnHeader));
             
            this.createTimeDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATETIME_FORMAT;
            Initialize();
        } 
        private void Initialize()
        { 
            this.dataGridViewPagingSumCtrl.SetDataSource<PfAccountRecord>(null); 
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            skinComboBoxSupplier.Initialize(false, true);
            SetPayType();
        }
        //skinComboBox1

        private void SetPayType()
        {
            List<ListItem<PfAccountRecordType>> list = new List<ListItem<PfAccountRecordType>>();
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.All), PfAccountRecordType.All));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.WeiXin), PfAccountRecordType.WeiXin));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.Balance), PfAccountRecordType.Balance));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.Alipay), PfAccountRecordType.Alipay));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.BankCard), PfAccountRecordType.BankCard));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.Cash), PfAccountRecordType.Cash));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.Other), PfAccountRecordType.Other));
            this.skinComboBox1.DisplayMember = "Key";
            this.skinComboBox1.ValueMember = "Value";
            this.skinComboBox1.DataSource = list;
        }
        private void SetFeeType(SkinComboBox skinComboBox_FeeType, Boolean isSave = false)
        {

            List<TKeyValue<String, PfAccountType>> accountTypeList = new List<TKeyValue<string, PfAccountType>>();
            accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.All), PfAccountType.All));
            accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.Delivery), PfAccountType.Delivery));
            accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.Return), PfAccountType.Return));
            accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.Collection), PfAccountType.Collection));
            accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.Other), PfAccountType.Other));

            skinComboBox_FeeType.DisplayMember = "Key";
            skinComboBox_FeeType.ValueMember = "Value";
            skinComboBox_FeeType.DataSource = accountTypeList;
        }

        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (this.pagePara == null)
                {
                    return;
                }
                this.pagePara.PageIndex = index;
                InteractResult<PfAccountRecordPage> listPage = GlobalCache.ServerProxy.PfCollectionManage(this.pagePara);
                this.BindingSource(listPage.Data);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        public void Search()
        {
            this.dataGridViewPagingSumCtrl.SetDataSource<PfAccountRecord>(null);

            if (this.pagePara != null)
            {
                this.pagePara.PfCustomerID = pfCustomer?.ID;
            }
            else
            {
                this.pagePara = new PfCollectionManagePara()
                {
                    PfCustomerID = pfCustomer?.ID,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize, 
                     PayType=(PfAccountRecordType)this.skinComboBox1.SelectedValue,
                };

                if (pfCustomer != null)
                {
                    skinComboBoxSupplier.SelectedValue = pfCustomer?.ID;
                }
                Search(this.pagePara);
            }
        }




        public void Search(PfCollectionManagePara para)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult<PfAccountRecordPage> listPage = GlobalCache.ServerProxy.PfCollectionManage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage.Data);
                this.BindingSource(listPage.Data);
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

        PfCustomer pfCustomer;
        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            if (pfCustomer == null)
            {
                GlobalMessageBox.Show("客户不存在，请重新选择！");
                skinComboBoxSupplier.Focus();
                return;
            }

            this.pagePara = new PfCollectionManagePara()
            {
                PfCustomerID = pfCustomer?.ID,
                StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                PageIndex = 0,
                 PayType= (PfAccountRecordType)this.skinComboBox1.SelectedValue,
                PageSize = this.dataGridViewPagingSumCtrl.PageSize,
            };
            Search(pagePara);
        }

        private void BindingSource(PfAccountRecordPage listPage)
        {
             
            if (listPage != null && listPage.PfAccountRecords != null && listPage.PfAccountRecords.Count > 0)
            {
                foreach (var item in listPage.PfAccountRecords)
                {
                    item.PfCustomerName = PfCustomerCache.GetPfCustomerName(item.PfCustomerID);
                    item.AccountTypeName = GlobalUtil.GetPfAccountTypeName(item.AccountType);
                    //item.AdminUserName = PfCustomerCache.GetUserNameWithPf(item.AdminUserID);
                }
            }

            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.PfAccountRecords, null, listPage?.TotalEntityCount, listPage?.Sum);
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
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                List<PfAccountRecord> list = (List<PfAccountRecord>)this.dataGridView1.DataSource;
                PfAccountRecord item = (PfAccountRecord)list[e.RowIndex];
                if (e.ColumnIndex == sourceOrderIDDataGridViewTextBoxColumn.Index)
                {
                    if ((AccountType)item.AccountType == AccountType.PurchaseCollection || (AccountType)item.AccountType == AccountType.Other)
                    {
                        //WholesaleAccountSearchForm form = new WholesaleAccountSearchForm();
                        //if (form.ShowDialog(item, true) == DialogResult.OK)
                        //{
                        //    RefreshPage();
                        //}
                        WholesaleAccountRecordOrderDetailForm form = new WholesaleAccountRecordOrderDetailForm();
                        form.ShowDialog(item);
                    }
                    else
                    {
                        WholesaleAccountSearchForm form = new WholesaleAccountSearchForm();
                        if (form.ShowDialog(item, true) == DialogResult.OK)
                        {
                            RefreshPage();
                        }
                        //WholesaleAccountRecordOrderDetailForm form = new WholesaleAccountRecordOrderDetailForm();
                        //form.ShowDialog(item);
                    }
                    //402 在“客户往来账明细”窗口内，增加点击单据 弹出单据明细窗口 功能。
                    //   this.skinSplitContainer1.Panel2Collapsed = false;
                    //  this.SourceOrderDetailClick?.Invoke(item.SourceOrderID, this, this.skinSplitContainer1.Panel2);

                }
                else if (e.ColumnIndex == ColumnDelete.Index)
                {
                    Delete(item);
                }
                else if (e.ColumnIndex == ColumnEdit.Index)
                {
                    Edit(item);
                }
                else if (e.ColumnIndex == Column2.Index)
                {
                    Print(item);
                }

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
        private void Print(PfAccountRecord item)
        {
            SalePayPrintUtil payPrint = new SalePayPrintUtil();
            payPrint.Print(item, 1);
        }

        private void Edit(PfAccountRecord item)
        {
            WholesaleAccountSearchForm form = new WholesaleAccountSearchForm();
            if (form.ShowDialog(item, false) == DialogResult.OK)
            {
                //RefreshPage();
                Search(this.pagePara);
            }
        }

        private void Delete(PfAccountRecord item)
        {
            DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            InteractResult result = GlobalCache.ServerProxy.DeletePfAccountRecord(item.AutoID);

            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    GlobalMessageBox.Show("删除成功！");
                    DeleteSelectedHangedOrder(item);
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    break;
            }
        }

        private void DeleteSelectedHangedOrder(PfAccountRecord order)
        {
            try
            {
                List<PfAccountRecord> orders = (List<PfAccountRecord>)this.dataGridView1.DataSource;
                orders.Remove(order);
                // dataGridViewPagingSumCtrl.BindingDataSource(orders);
                Search(this.pagePara);
            }
            catch { }
        }


        #endregion

        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }

        private void PfCustomerAccountRecordSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void skinComboBoxSupplier_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
                DataGridView view = sender as DataGridView;
                PfAccountRecord row = view.Rows[e.RowIndex].DataBoundItem as PfAccountRecord;
                if (row != null)
                {
                    if (ColumnDelete.Index == e.ColumnIndex)
                    {
                        switch ((PfAccountType)row.AccountType)
                        {
                            case PfAccountType.Collection:
                            case PfAccountType.Other:
                                break;
                            default:
                                e.Value = null;
                                break;
                        }
                    }
                    else if (ColumnEdit.Index == e.ColumnIndex)
                    {
                        switch ((PfAccountType)row.AccountType)
                        {
                            case PfAccountType.Collection:
                            case PfAccountType.Other:
                                break;
                            default:
                                e.Value = null;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex) {

            }
        }

        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            WholesaleAccountSearchForm form = new WholesaleAccountSearchForm();
            if (form.ShowDialog(this.FindForm()) == DialogResult.OK)
            {
                this.RefreshPage();
            }
        }

        private String path;
        private void baseButton2_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "销售收款管理" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoExport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
        }
        private void DoExport()
        {
            try
            {
                if (dataGridView1.DataSource != null && dataGridView1.Rows.Count > 0)
                {
                    List<PfAccountRecord> list = (dataGridView1.DataSource) as List<PfAccountRecord>;
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {
                            if (item.Name != "ColumnDelete" && item.Name != "ColumnEdit" && item.Name!= "Column2")
                            {
                            keys.Add(item.DataPropertyName);
                                values.Add(item.HeaderText);
                            }





                        }
                    }



                    NPOIHelper.Keys = keys.ToArray();
                    NPOIHelper.Values = values.ToArray();
                    NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);

                    GlobalMessageBox.Show("导出完毕！");
                }
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }
    }
}

