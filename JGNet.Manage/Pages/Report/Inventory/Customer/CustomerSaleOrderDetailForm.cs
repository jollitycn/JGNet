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
    public partial class CustomerSaleOrderDetailForm : BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public CustomerSaleOrderDetailForm()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            skinLabelOrder.Text = String.Empty;

            
        }

        private bool reportShowZero;
        private PfCustomerRetailOrder record;
        public DialogResult ShowDialog(PfCustomerRetailOrder record)
        {
            this.record = record;
            this.Text = "销售明细-" + record.ID;
            return  ShowDialog();
        }

        private void Search(PfCustomerRetailOrder record)
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
               listPage = GlobalCache.ServerProxy.GetPfCustomerRetailDetails(record.ID);

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

        private void WholesaleAccountRecordOrderDetailForm_Shown(object sender, EventArgs e)
        {
            Search(record);
        }
    }
}
