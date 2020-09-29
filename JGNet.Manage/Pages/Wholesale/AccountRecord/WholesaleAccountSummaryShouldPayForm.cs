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
    public partial class WholesaleAccountSummaryShouldPayForm :
        BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public WholesaleAccountSummaryShouldPayForm()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new string[] {
                  accountMoneyDataGridViewTextBoxColumn.DataPropertyName});
            dataGridViewPagingSumCtrl.Initialize();
        }

        private PfAccountRecord4SummaryPara para;
        private String orderId;

        public void ShowDialog(PfAccountRecord4SummaryPara  para, String orderId=null)
        {
            try
            {
                this.orderId = orderId;
                this.para = para;
                switch (para.Type)
                {
                    case PARSQueryType.ShouldPay:
                        accountTypeNameDataGridViewTextBoxColumn.Visible = false;
                        createTimeDataGridViewTextBoxColumn.HeaderText = "单据日期";
                        accountMoneyDataGridViewTextBoxColumn.HeaderText = "总金额";
                        SourceOrderID.Visible = false;
                        sourceOrderIDDataGridViewTextBoxColumn.Visible = true;
                        this.Text = "应收货款明细";

                        break;
                    case PARSQueryType.OtherMoney:
                        accountTypeNameDataGridViewTextBoxColumn.Visible = false;
                        createTimeDataGridViewTextBoxColumn.HeaderText = "收款日期";
                        accountMoneyDataGridViewTextBoxColumn.HeaderText = "收款金额";
                        SourceOrderID.Visible = true;
                        sourceOrderIDDataGridViewTextBoxColumn.Visible = false;
                        this.Text = "其他费用明细";
                        break;
                    case PARSQueryType.PayMoney:
                        accountTypeNameDataGridViewTextBoxColumn.Visible = true;
                        accountTypeNameDataGridViewTextBoxColumn.HeaderText = "收款类型";
                        createTimeDataGridViewTextBoxColumn.HeaderText = "收款日期";
                        accountMoneyDataGridViewTextBoxColumn.HeaderText = "收款金额";
                        SourceOrderID.Visible = true;
                        sourceOrderIDDataGridViewTextBoxColumn.Visible = false;
                        this.Text = "已收金额明细";
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
                    InteractResult<PfAccountRecord> result = GlobalCache.ServerProxy.GetPfAccountRecord(orderId  ,para.Type);
                    List<PfAccountRecord> listPage = new List<PfAccountRecord>();
                    listPage.Add(result.Data);
                    this.dataGridViewPagingSumCtrl.BindingDataSource(listPage);
                }
                else
                {
                    InteractResult<List<PfAccountRecord>> listPage = GlobalCache.ServerProxy.GetPfAccountRecord4Summary(para);
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

        private void PfAccountRecordOrderDetailForm_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

            List<PfAccountRecord> list = (List<PfAccountRecord>)this.dataGridView1.DataSource;
            PfAccountRecord item = (PfAccountRecord)list[e.RowIndex];
            if (e.ColumnIndex == sourceOrderIDDataGridViewTextBoxColumn.Index) {
                WholesaleAccountRecordOrderDetailForm form = new WholesaleAccountRecordOrderDetailForm();
                form.ShowDialog(item);
            }
        }
    }
}
