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
    public partial class PFCostumeOrderDetailForm :
        BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public PFCostumeOrderDetailForm()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            skinLabelCount.Text = String.Empty;
            skinLabelPrice.Text = String.Empty;
            skinLabelOrder.Text = String.Empty;
            skinLabelOpreator.Text = String.Empty;
            skinLabelSupplier.Text = String.Empty;

            
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
                skinLabelOpreator.Text = record.AdminUserName;
                skinLabelSupplier.Text = record.PfCustomerName;
                //List<BoundDetail> listPage = GlobalCache.ServerProxy.
                //GetDetail4SupplierAccountRecord(record.SourceOrderID);
                //GetPfOrderDetails
                //ShowMessage(record.OrderType);
                this.Text = record.OrderType + "单明细";
               List<PfOrderDetail> pflistPage= GlobalCache.ServerProxy.GetPfOrderDetails(record.ID);
                
                if (pflistPage != null)
                {
                    int totalCount = 0;
                    decimal totalPrice = 0;
                    for (int i = 0; i < pflistPage.Count; i++)
                    {
                        totalCount += pflistPage[i].SumCount;
                        totalPrice += pflistPage[i].SumCost;
                    }
                    skinLabelCount.Text = totalCount.ToString();
                    skinLabelPrice.Text = totalPrice.ToString();
                    foreach (var item in pflistPage)
                    {
                        item.CostumeName = CommonGlobalCache.GetCostumeName(item.CostumeID);

                    }
                }

                this.dataGridViewPagingSumCtrl.BindingDataSource<BoundDetail>(DataGridViewUtil.ToDataTable(pflistPage));
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
