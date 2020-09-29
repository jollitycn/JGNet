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
    public partial class WholesaleAccountRecordDetailForm :
        BaseForm
    {

        public WholesaleAccountRecordDetailForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(PfCustomer PfCustomer)
        {
            this.skinLabelSupplier.Text = PfCustomer.Name;
            try
            {
                if (
                CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                 PfCostumeStoreInfo PfCustomerAccountRecordDetailInfo = GlobalCache.ServerProxy.GetPfCostumeStoreInfo(PfCustomer.ID);
                if (PfCustomerAccountRecordDetailInfo != null)
                {
                    skinLabelStore.Text = PfCustomerAccountRecordDetailInfo.Count.ToString();
                    skinLabelCost.Text = PfCustomerAccountRecordDetailInfo.Money.ToString(); 
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
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



    }
}
