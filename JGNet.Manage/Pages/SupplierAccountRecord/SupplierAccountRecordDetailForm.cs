using JGNet.Common;
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
    public partial class SupplierAccountRecordDetailForm :
        BaseForm
    {

        public SupplierAccountRecordDetailForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Supplier supplier)
        {
            this.skinLabelSupplier.Text = supplier.Name;
            try
            {
                if (
                CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                SupplierAccountRecordDetailInfo supplierAccountRecordDetailInfo = GlobalCache.ServerProxy.GetSupplierAccountRecordDetailInfo(supplier.ID);
                if (supplierAccountRecordDetailInfo != null)
                {
                    skinLabelStore.Text = supplierAccountRecordDetailInfo.SummaryCount.ToString();
                    skinLabelCost.Text = supplierAccountRecordDetailInfo.TotalCost.ToString();
                    skinLabelPrice.Text = supplierAccountRecordDetailInfo.TotalPrice.ToString();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
                this.TopMost = true;
                this.Show();
                this.TopMost = false;
            }
            //   this.skinLabelStore.Text =  supplier.s

        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



    }
}
