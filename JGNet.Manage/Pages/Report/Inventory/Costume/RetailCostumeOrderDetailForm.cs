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
    public partial class RetailCostumeOrderDetailForm :
        BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public RetailCostumeOrderDetailForm()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
           
            skinLabelOrder.Text = String.Empty;

            
        }

        private PfOrder record;
        private bool reportShowZero;
        public void ShowDialog(PfOrder record)
        {
            try
            {
                this.record = record;
                this.ShowDialog();
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }

        }

        private void Search(PfOrder record)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                skinLabelOrder.Text = record.ID;
                //List<BoundDetail> listPage = GlobalCache.ServerProxy.
                //GetDetail4SupplierAccountRecord(record.SourceOrderID);
               List<PfCustomerRetailDetail> listitems=new List<PfCustomerRetailDetail>();
                    listitems = GlobalCache.ServerProxy.GetPfCustomerRetailDetails(record.ID);
               /*  List<PfOrderDetail> pfListItems=new List<PfOrderDetail>();
                // 
                if (record.IsRetail)
                {
                }
                else
                {*/

                 //   pfListItems = GlobalCache.ServerProxy.GetPfOrderDetails(record.ID);
               // }
                //GetPfCustomerRetailDetails
               /* if (listitems != null)
                {
                    int totalCount = 0;
                    decimal totalPrice = 0;
                    for (int i = 0; i < listitems.Count; i++)
                     {
                         totalCount += listitems[i].BuyCount;
                         //totalPrice += listitems[i].;
                     }
                    skinLabelCount.Text = totalCount.ToString();
                    skinLabelPrice.Text = totalPrice.ToString();
                    foreach (var item in listitems)
                    {
                        item.CostumeName = CommonGlobalCache.GetCostumeName(item.CostumeID);

                    }
                    this.dataGridViewPagingSumCtrl.BindingDataSource<BoundDetail>(DataGridViewUtil.ToDataTable(listitems));
                }*/
                if(listitems != null)
                {

                    this.dataGridViewPagingSumCtrl.BindingDataSource<BoundDetail>(DataGridViewUtil.ToDataTable(listitems));
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
            Search(record);
        }
    }
}
