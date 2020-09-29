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
    public partial class OperationInfoForm : 
        BaseForm
    { 

        public OperationInfoForm()
        {
            InitializeComponent();  
        }

        public void Search()
        {
            try
            {
                if (
                CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                OperationInfo operationInfo = GlobalCache.ServerProxy.GetOperationInfo();
                if (operationInfo != null)
                {
                    skinLabelSummaryCount.Text = operationInfo.SummaryCount.ToString();
                    skinLabelTotalCostInStore.Text = operationInfo.TotalCostInStore.ToString();
                    skinLabelTotalPriceInStore.Text = operationInfo.TotalPriceInStore.ToString();
                    skinLabelTotalMemberBalance.Text = operationInfo.TotalMemberBalance.ToString();
                    skinLabelPaymentBalanceSum.Text = operationInfo.PaymentBalanceSum.ToString();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Search();
            }
        }
    }
}
