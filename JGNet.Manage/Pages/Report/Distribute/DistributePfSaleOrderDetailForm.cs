using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using JGNet.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common
{
    public partial class DistributePfSaleOrderDetailForm : BaseDialogCostumeIDForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public DistributePfSaleOrderDetailForm()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            skinLabelOrder.Text = String.Empty;

            
        }

        private bool reportShowZero;
        private string recordId;
        public void ShowDialog(string recordId)
        {
            this.recordId = recordId;
            this.Text = "销售明细-" + recordId;
            this.ShowDialog();

           Search(recordId); 

        }

        private void Search(string recordID)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                skinLabelOrder.Text ="";

                skinLabel1.Text = "";
                List<PfCustomerRetailDetail> listPage = null;
               listPage = GlobalCache.ServerProxy.GetPfCustomerRetailDetails(recordID);

                if (listPage != null)
                {
                   /* int totalCount = 0;
                    decimal totalPrice = 0;
                    for (int i = 0; i < listPage.Count; i++)
                    {
                        totalCount += listPage[i].SumCount;
                        totalPrice += listPage[i].SumCost;
                    }
                    
                    skinLabelCount.Text = totalCount.ToString();
                    skinLabelPrice.Text = totalPrice.ToString();*/
                    foreach (var item in listPage)
                    {
                        item.CostumeName = CommonGlobalCache.GetCostumeName(item.CostumeID);
                    }
                }

                this.dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerRetailDetail>(DataGridViewUtil.ToDataTable(listPage));
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
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }
        public override void HighlightCostume()
        {
            if (dataGridView1.DataSource != null)
            {
                if (!String.IsNullOrEmpty(BaseModifyCostumeID))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        PfCustomerRetailDetail detail = row.DataBoundItem as PfCustomerRetailDetail;
                        HighlightCostume(row, detail?.CostumeID);
                    }
                }
                dataGridView1.Refresh();
            }
        }
        private void WholesaleAccountRecordOrderDetailForm_Shown(object sender, EventArgs e)
        {
            Search(recordId);
        }

        private void DistributePfSaleOrderDetailForm_Load(object sender, EventArgs e)
        {
            HighlightCostume();
        }
    }
}
