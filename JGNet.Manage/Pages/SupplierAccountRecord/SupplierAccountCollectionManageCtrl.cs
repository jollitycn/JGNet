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
using JGNet.Common;
using JieXi.Common;
using CJBasic;
using JGNet.Core.Tools;

namespace JGNet.Manage
{
    public partial class SupplierAccountCollectionManageCtrl : BaseModifyUserControl
    {

        private PurchasePayManagePara pagePara;
        public event CJBasic.Action<String, BaseUserControl, Panel> SourceOrderDetailClick;
        private Supplier supplier;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        public SupplierAccountCollectionManageCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.采购付款管理;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click, new String[] {
                accountMoneyDataGridViewTextBoxColumn.DataPropertyName
            }); 
            dataGridViewPagingSumCtrl.Initialize(); 
            this.createTimeDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATETIME_FORMAT;
            Initialize();
            this.skinComboBoxSupplier.HideAll = false;
        } 

        private void Initialize()
        {
            this.dataGridViewPagingSumCtrl.SetDataSource<SupplierAccountRecord>(null); 
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            SetPayType();
        }
        //skinComboBox1
        private void SetPayType()
        {
            List<ListItem<SupplierAccountRecordPayType>> list = new List<ListItem<SupplierAccountRecordPayType>>();
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.All), SupplierAccountRecordPayType.All));
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.Cash), SupplierAccountRecordPayType.Cash));
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.BankCard), SupplierAccountRecordPayType.BankCard));
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.WeiXin), SupplierAccountRecordPayType.WeiXin));
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.Alipay), SupplierAccountRecordPayType.Alipay)); 
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.Other), SupplierAccountRecordPayType.Other));
            this.skinComboBox1.DisplayMember = "Key";
            this.skinComboBox1.ValueMember = "Value";
            this.skinComboBox1.DataSource = list;
        }

        private void SetFeeType(SkinComboBox skinComboBox_FeeType, Boolean isSave = false)
        {
            List<TKeyValue<String, AccountType>> accountTypeList = new List<TKeyValue<string, AccountType>>();
            if (!isSave)
            {
                accountTypeList.Add(new TKeyValue<string, AccountType>(GlobalUtil.COMBOBOX_ALL, AccountType.All));
                accountTypeList.Add(new TKeyValue<string, AccountType>("进货", AccountType.Purchase));
                accountTypeList.Add(new TKeyValue<string, AccountType>("退货", AccountType.Return));
            }
            accountTypeList.Add(new TKeyValue<string, AccountType>("采购付款", AccountType.PurchaseCollection));
            accountTypeList.Add(new TKeyValue<string, AccountType>("其他", AccountType.Other));

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
                InteractResult<SupplierAccountRecordPage> listPage = GlobalCache.ServerProxy.PurchasePayManage(this.pagePara);
                this.BindingSource(listPage.Data);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        public void Search()
        {
            this.dataGridViewPagingSumCtrl.SetDataSource<SupplierAccountRecord>(null);

            if (this.pagePara != null)
            {
                this.pagePara.SupplierID = supplier?.ID;
            }
            else
            {
                this.pagePara = new PurchasePayManagePara()
                {
                    SupplierID = supplier?.ID,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize, 
                     PayType=(SupplierAccountRecordPayType)this.skinComboBox1.SelectedValue,
                };
            }
            if (supplier != null)
            {
                skinComboBoxSupplier.SelectedValue = supplier.ID;
            }
            Search(this.pagePara);
        }

        public void Search(PurchasePayManagePara para)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult<SupplierAccountRecordPage> listPage = GlobalCache.ServerProxy.PurchasePayManage(this.pagePara);
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

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            this.pagePara = new PurchasePayManagePara()
            {
                SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBoxSupplier.SelectedValue),
                StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                PageIndex = 0,
                PageSize = this.dataGridViewPagingSumCtrl.PageSize, 
                 PayType= (SupplierAccountRecordPayType)this.skinComboBox1.SelectedValue,
            };
            Search(pagePara);
        }

        private void BindingSource(SupplierAccountRecordPage listPage)
        { 
            if (listPage != null && listPage.SupplierAccountRecords != null && listPage.SupplierAccountRecords.Count > 0)
            {
                foreach (var item in listPage.SupplierAccountRecords)
                {
                    item.SupplierName = GlobalCache.GetSupplierName(item.SupplierID);
                    item.AdminUserName = GlobalCache.GetUserName(item.AdminUserID);
                    item.AccountTypeName = GlobalUtil.GetAccountTypeName(item.AccountType);
                }
            }

            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage.SupplierAccountRecords, null, listPage?.TotalEntityCount, listPage?.Sum);
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

                List<SupplierAccountRecord> list = (List<SupplierAccountRecord>)this.dataGridView1.DataSource;
                SupplierAccountRecord item = (SupplierAccountRecord)list[e.RowIndex];
                if (e.ColumnIndex == sourceOrderIDDataGridViewTextBoxColumn.Index)
                {
                    if ((AccountType)item.AccountType == AccountType.PurchaseCollection || (AccountType)item.AccountType == AccountType.Other)
                    {
                        SupplierAccountSearchForm form = new SupplierAccountSearchForm();
                        if (form.ShowDialog(item, true) == DialogResult.OK)
                        {
                            RefreshPage();
                        }
                    }
                    else
                    {
                        SupplierAccountRecordOrderDetailForm form = new SupplierAccountRecordOrderDetailForm();
                        form.ShowDialog(item);
                    }
                    //402 在“供应商往来账明细”窗口内，增加点击单据 弹出单据明细窗口 功能。
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
                    PayPrint(item);
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
        private void PayPrint(SupplierAccountRecord item)
        {
            PurchasePayPrintUtil payPrint = new PurchasePayPrintUtil();
            payPrint.Print(item, 1);

        }

        private void Edit(SupplierAccountRecord item)
        {
            SupplierAccountSearchForm form = new SupplierAccountSearchForm();
            if (form.ShowDialog(item, false) == DialogResult.OK)
            {
                Search(pagePara);
                // RefreshPage();
            }
        }

        private void Delete(SupplierAccountRecord item)
        {
            try
            {
                DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult != DialogResult.OK)
                {
                    return;
                }
                InteractResult result = GlobalCache.ServerProxy.DeleteSupplierAccountRecord(item.AutoID);

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
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
}

        private void DeleteSelectedHangedOrder(SupplierAccountRecord order)
        {
            try
            {
                List<SupplierAccountRecord> orders = (List<SupplierAccountRecord>)this.dataGridView1.DataSource;
                orders.Remove(order); 
                Search(pagePara);
                //dataGridViewPagingSumCtrl.BindingDataSource(orders);
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

        private void SupplierAccountRecordSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
                DataGridView view = sender as DataGridView;
                SupplierAccountRecord row = view.Rows[e.RowIndex].DataBoundItem as SupplierAccountRecord;
                if (ColumnDelete.Index == e.ColumnIndex || ColumnEdit.Index == e.ColumnIndex)
                {
                    if (row != null)
                    {
                        switch ((AccountType)row.AccountType)
                        {
                            case AccountType.All:
                            case AccountType.Purchase:
                            case AccountType.Return:
                                e.Value = null;
                                break;
                            case AccountType.PurchaseCollection:
                            case AccountType.Other:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch { }
        }

        private void skinComboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                supplier = skinComboBoxSupplier.SelectedItem as Supplier;
            }
            catch { }
        }

        private String path;
        private void baseButton2_Click(object sender, EventArgs e)
        {
            SupplierAccountSearchForm form = new SupplierAccountSearchForm();
            if (form.ShowDialog(this.FindForm()) == DialogResult.OK)
            {
                this.RefreshPage();
            }
        }

        private void baseButton3_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "采购付款管理" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                    List<SupplierAccountRecord> list = (dataGridView1.DataSource) as List<SupplierAccountRecord>;
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {
                            if (item.Name != "ColumnDelete" && item.Name != "ColumnEdit" && item.Name != "Column2") {
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

