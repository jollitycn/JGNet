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

namespace JGNet.Manage
{
    public partial class SupplierAccountRecordSearchCtrl : BaseModifyUserControl
    {

        private SupplierAccountRecordPagePara pagePara;
        public event CJBasic.Action<String, BaseUserControl, Panel> SourceOrderDetailClick;
        private Supplier supplier;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public SupplierAccountRecordSearchCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click, new String[] {
                accountMoneyDataGridViewTextBoxColumn.DataPropertyName
            });

            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 remarksDataGridViewTextBoxColumn });
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;
            this.createTimeDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATETIME_FORMAT;
            Initialize();
        }
        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        private void Initialize()
        {

            this.dataGridViewPagingSumCtrl.SetDataSource<SupplierAccountRecord>(null);
            this.skinSplitContainer1.Panel2Collapsed = true;
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
           // GlobalUtil.SetSupplier(this.skinComboBoxSupplier,true);
            SetFeeType(this.skinComboBox_FeeType);
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
                SupplierAccountRecordPage listPage = GlobalCache.ServerProxy.GetSupplierAccountRecordPage(this.pagePara);
                this.BindingSource(listPage);
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
                this.pagePara = new SupplierAccountRecordPagePara()
                {
                    SupplierID = supplier?.ID,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    AccountType = (AccountType)this.skinComboBox_FeeType.SelectedValue,
                };
            }
            if (supplier != null)
            {
                skinComboBoxSupplier.SelectedValue = supplier.ID;
            }
            Search(this.pagePara);

        }




        public void Search(SupplierAccountRecordPagePara para)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                SupplierAccountRecordPage listPage = GlobalCache.ServerProxy.GetSupplierAccountRecordPage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingSource(listPage);
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
            this.pagePara = new SupplierAccountRecordPagePara()
            {
                SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBoxSupplier.SelectedValue),
                StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                PageIndex = 0,
                PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                AccountType = (AccountType)this.skinComboBox_FeeType.SelectedValue,
            };
            Search(pagePara);
        }

        private void BindingSource(SupplierAccountRecordPage listPage)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
            if (listPage != null && listPage.SupplierAccountRecords != null && listPage.SupplierAccountRecords.Count > 0)
            {
                foreach (var item in listPage.SupplierAccountRecords)
                {
                    item.SupplierName = GlobalCache.GetSupplierName(item.SupplierID);
                    item.AdminUserName = GlobalCache.GetUserName(item.AdminUserID);
                    item.AccountTypeName = GlobalUtil.GetAccountTypeName(item.AccountType);

                }
            }

            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage.SupplierAccountRecords, null, listPage?.TotalEntityCount);
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

        private void Edit(SupplierAccountRecord item)
        {
            SupplierAccountSearchForm form = new SupplierAccountSearchForm();
            if (form.ShowDialog(item, false) == DialogResult.OK)
            {
                RefreshPage();
            }
        }

        private void Delete(SupplierAccountRecord item)
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

        private void DeleteSelectedHangedOrder(SupplierAccountRecord order)
        {
            try
            {
                List<SupplierAccountRecord> orders = (List<SupplierAccountRecord>)this.dataGridView1.DataSource;
                orders.Remove(order);
                dataGridViewPagingSumCtrl.BindingDataSource(orders);
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
    }
}

