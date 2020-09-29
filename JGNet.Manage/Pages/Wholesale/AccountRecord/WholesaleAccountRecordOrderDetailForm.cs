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
    public partial class WholesaleAccountRecordOrderDetailForm : BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public WholesaleAccountRecordOrderDetailForm()
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

        private bool reportShowZero;
        private PfAccountRecord record;
        public DialogResult ShowDialog(PfAccountRecord record)
        {

            this.record = record;
            if (record.SourceOrderID.StartsWith("PF")) { this.Text = "批发发货单明细"; }
            else if(record.SourceOrderID.StartsWith("PT")) { this.Text = "批发退货单明细"; }
            return  ShowDialog();
        }

        private void Search(PfAccountRecord record)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                skinLabelOrder.Text = record.SourceOrderID;
                skinLabelOpreator.Text = record.AdminUserName;
                skinLabelSupplier.Text =    record.PfCustomerName;
                List<PfOrderDetail> listPage = null;
               listPage = GlobalCache.ServerProxy.GetPfAccountRecordDetails(record.SourceOrderID);

                if (listPage != null)
                {
                    int totalCount = 0;
                    decimal totalPrice = 0;
                    for (int i = 0; i < listPage.Count; i++)
                    {
                        totalCount += listPage[i].SumCount;
                        totalPrice += listPage[i].SumCost;
                    }
                    skinLabelCount.Text = totalCount.ToString();
                    skinLabelPrice.Text = totalPrice.ToString();
                    foreach (var item in listPage)
                    {
                        item.CostumeName = CommonGlobalCache.GetCostumeName(item.CostumeID);
                    }
                }

                this.dataGridViewPagingSumCtrl.BindingDataSource<PfOrderDetail>(DataGridViewUtil.ToDataTable(listPage));
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
