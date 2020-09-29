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
    public partial class WholesaleAccountContrastForm :
        BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public WholesaleAccountContrastForm()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new string[] {
                  accountMoneyDataGridViewTextBoxColumn.DataPropertyName});
            dataGridViewPagingSumCtrl.Initialize();
        }

        private PfAccountRecord4SummaryPara para;
        public void ShowDialog(PfAccountRecord4SummaryPara para)
        {
            try
            {
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
                        accountTypeNameDataGridViewTextBoxColumn.Visible = true;
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
                 
                InteractResult<List<PfAccountRecord>> listPage = GlobalCache.ServerProxy.GetPfAccountRecord4Summary(para);
                this.dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
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
