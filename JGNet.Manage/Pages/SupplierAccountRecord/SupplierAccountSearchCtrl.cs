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
    public partial class SupplierAccountSearchCtrl : BaseUserControl
    {

        //   public CJBasic.Action<String, BaseUserControl> SourceOrderDetailClick;
        public CJBasic.Action<Supplier, BaseUserControl> RecordSearchClick;


        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private SupplierAccountRecordPagePara pagePara;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public SupplierAccountSearchCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize(); 
            createTimeDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
        } 

        private void BindingSource(List<Supplier> listPage)
        {
            this.dataGridView1.DataSource = null;
            if (listPage != null)
            {

                dataGridViewPagingSumCtrl.BindingDataSource<Supplier>(listPage, new String[] { paymentBalanceDataGridViewTextBoxColumn.DataPropertyName }, listPage.Count);
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
                List<Supplier> listPage = GlobalCache.ServerProxy.GetSupplierList();

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


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Supplier supplier = dataGridView1.CurrentRow.DataBoundItem as Supplier;

        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                    List<Supplier> list = (List<Supplier>)view.DataSource;
                    Supplier item = (Supplier)list[e.RowIndex];
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

        SupplierAccountRecordDetailForm form = new SupplierAccountRecordDetailForm();
        private void ShowForm(Supplier item)
        {
            form.ShowDialog(item);
        }

        private void RecordSearch()
        {
            SupplierAccountRecordSearchForm recordSearchForm = new SupplierAccountRecordSearchForm();
            recordSearchForm.ShowDialog();
            // RecordSearchClick?.Invoke(supplier, this);
        }


        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            SupplierAccountSearchForm form = new SupplierAccountSearchForm();
            if (form.ShowDialog(this.FindForm()) == DialogResult.OK)
            {
                this.RefreshPage();
            }
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            RecordSearch();
        }

        private void baseButton3_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
    }
}

