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
    public partial class SupplierAccountRecordOrderDetailForm :
        BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public SupplierAccountRecordOrderDetailForm()
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

        private SupplierAccountRecord record;
        private bool reportShowZero;
        public void ShowDialog(SupplierAccountRecord record)
        {

            try
            {
                this.record = record;

                if (record.SourceOrderID.StartsWith("A")) { this.Text = "采购发货明细单"; }
                else if(record.SourceOrderID.StartsWith("U"))
                {
                    this.Text = "采购退货明细";
                }

                this.ShowDialog();
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }

        }

        private void Search(SupplierAccountRecord record)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                skinLabelOrder.Text = record.SourceOrderID;
                skinLabelOpreator.Text = record.AdminUserName;
                skinLabelSupplier.Text =GlobalCache.GetSupplierName(record.SupplierID);
                List<BoundDetail> listPage = GlobalCache.ServerProxy.
                GetDetail4SupplierAccountRecord(record.SourceOrderID);

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

                this.dataGridViewPagingSumCtrl.BindingDataSource<BoundDetail>(DataGridViewUtil.ToDataTable(listPage));
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
