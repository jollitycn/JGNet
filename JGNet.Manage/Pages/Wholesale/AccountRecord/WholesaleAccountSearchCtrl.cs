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
using JGNet.Common.cache.Wholesale;

namespace JGNet.Manage
{
    public partial class WholesaleAccountSearchCtrl : BaseUserControl
    {

        //   public CJBasic.Action<String, BaseUserControl> SourceOrderDetailClick;
        public CJBasic.Action<PfCustomer, BaseUserControl> RecordSearchClick;


        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
         

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<PfCustomerAccountRecord,Type>PfCustomerAccountRecordDetailClick;
        public WholesaleAccountSearchCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;
            createTimeDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
           

        }
        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
        }
         


        private void BindingSource(List<PfCustomer> listPage)
        {
            this.dataGridView1.DataSource = null;
            if (listPage != null)
            {

                dataGridViewPagingSumCtrl.BindingDataSource<PfCustomer>(listPage, new String[] { paymentBalanceDataGridViewTextBoxColumn.DataPropertyName }, listPage.Count);
                // this.dataGridView1.DataSource = listPage;
            }
            this.dataGridView1.Refresh();
        }



        public override void RefreshPage()
        {
            this.BaseButton_Search_Click(null, null);
        }


        private void SupplierAccountSearchCtrl_Load(object sender, EventArgs e)
        { 
            this.BaseButton_Search_Click(null, null);
        }
        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                GetPfCustomerPagePara para =  new GetPfCustomerPagePara() {
                 PageIndex=0,
                 PageSize = Int32.MaxValue};
                PfCustomerPage listPage = GlobalCache.ServerProxy.GetPfCustomerPage(para);

                this.BindingSource(listPage?.PfCustomers);

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
        
        //private int ShowPayTypeForm(PfAccountRecord item)
        //{
        //    int selectType = -1;
        //    if (item.AccountType == (int)PfAccountType.Collection)
        //    {
        //        WholesaleAccountRecordReceivedForm form = new WholesaleAccountRecordReceivedForm(pfCustomer, Math.Abs(item.AccountMoney));
        //        if (form.ShowDialog() == DialogResult.OK)
        //        {
        //            selectType = form.Result;
        //        } 
        //    }
        //    //else if (item.AccountType == (int)PfAccountType.Refund)
        //    //{
        //    //    WholesaleAccountRecordRefundForm form = new WholesaleAccountRecordRefundForm(pfCustomer, Math.Abs(item.AccountMoney));
        //    //    if (form.ShowDialog() == DialogResult.OK)
        //    //    {
        //    //        selectType = form.Result;
        //    //    }
        //    //}
        //    return selectType;
        //}

        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            WholesaleAccountSearchForm form = new WholesaleAccountSearchForm();
            if (form.ShowDialog(this.FindForm()) == DialogResult.OK)
            {
                this.RefreshPage();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PfCustomer PfCustomer = dataGridView1.CurrentRow.DataBoundItem as PfCustomer;

        }
         
        private void BaseButtonRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshPage();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    DataGridView view = (DataGridView)sender;
                    List<PfCustomer> list = (List<PfCustomer>)view.DataSource;
                    PfCustomer item = (PfCustomer)list[e.RowIndex];
                    switch (view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {
                        case "查询":
                            ShowForm(item);
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

        WholesaleAccountRecordDetailForm form = new WholesaleAccountRecordDetailForm();
        private void ShowForm(PfCustomer item)
        {
            form.ShowDialog(item);
        } 
        
        private void RecordSearch()
        {
            WholesaleAccountRecordSearchForm recordSearchForm = new WholesaleAccountRecordSearchForm();
            recordSearchForm.ShowDialog();
           // RecordSearchClick?.Invoke(PfCustomer, this);
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            this.BaseButton_Search_Click(null, null);

        }

        private void baseButton2_Click_1(object sender, EventArgs e)
        {
            RecordSearch();
        }

        private void baseButton3_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
    }
}

