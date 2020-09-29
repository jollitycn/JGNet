using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class SupplierAccountSummaryShouldPayForm :
        BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public SupplierAccountSummaryShouldPayForm()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new string[] {
                  accountMoneyDataGridViewTextBoxColumn.DataPropertyName});
            dataGridViewPagingSumCtrl.Initialize();
        }

        private SupplierAccountRecord4SummaryPara para;
        private String orderId;
        public void ShowDialog(SupplierAccountRecord4SummaryPara para,string orderId= null)
        {
            try
            {
                this.para = para;
                this.orderId = orderId;
                    switch (para.Type)
                {
                    case SARSQueryType.ShouldPay:
                        accountTypeNameDataGridViewTextBoxColumn.Visible = false;
                        createTimeDataGridViewTextBoxColumn.HeaderText = "单据日期";
                        accountMoneyDataGridViewTextBoxColumn.HeaderText = "总金额";
                        SourceOrderID.Visible = false;
                        sourceOrderIDDataGridViewTextBoxColumn.Visible = true;
                        this.Text = "应付货款明细";

                        break;
                    case SARSQueryType.OtherMoney:
                        accountTypeNameDataGridViewTextBoxColumn.Visible = false;
                        createTimeDataGridViewTextBoxColumn.HeaderText = "付款日期";
                        accountMoneyDataGridViewTextBoxColumn.HeaderText = "付款金额";
                        SourceOrderID.Visible = true;
                        sourceOrderIDDataGridViewTextBoxColumn.Visible = false;
                        this.Text = "其他费用明细";
                        break;
                    case SARSQueryType.PayMoney:
                        accountTypeNameDataGridViewTextBoxColumn.Visible = true;
                        accountTypeNameDataGridViewTextBoxColumn.HeaderText = "付款类型";
                        createTimeDataGridViewTextBoxColumn.HeaderText = "付款日期";
                        accountMoneyDataGridViewTextBoxColumn.HeaderText = "付款金额";
                        SourceOrderID.Visible = true;
                        sourceOrderIDDataGridViewTextBoxColumn.Visible = false;
                        this.Text = "已付金额明细";
                        break;
                    default:
                        break;
                }
                this.ShowDialog();
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void Search()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (!String.IsNullOrEmpty(orderId))
                {
                    InteractResult<SupplierAccountRecord> result = GlobalCache.ServerProxy.GetSupplierAccountRecord(orderId, para.Type);
                    List<SupplierAccountRecord> listPage = new List<SupplierAccountRecord>();
                    listPage.Add(result.Data);
                    this.dataGridViewPagingSumCtrl.BindingDataSource(listPage);
                }
                else
                {
                    InteractResult<List<SupplierAccountRecord>> listPage = GlobalCache.ServerProxy.GetSupplierAccountRecord4Summary(para);
                    this.dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
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

        private void SupplierAccountRecordOrderDetailForm_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

            List<SupplierAccountRecord> list = (List<SupplierAccountRecord>)this.dataGridView1.DataSource;
            SupplierAccountRecord item = (SupplierAccountRecord)list[e.RowIndex];
            if (e.ColumnIndex == sourceOrderIDDataGridViewTextBoxColumn.Index) {
                SupplierAccountRecordOrderDetailForm form = new SupplierAccountRecordOrderDetailForm();
                form.ShowDialog(item);
            }
        }
    }
}
