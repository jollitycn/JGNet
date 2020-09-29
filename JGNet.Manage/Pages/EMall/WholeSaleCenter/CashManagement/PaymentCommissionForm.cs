using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Core.InteractEntity;
using JGNet.Manage; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class PaymentCommissionForm : 
        BaseForm
    {
        private ScrapOrder result;
        private ScrapOrder Result { get { return result; } } 

        public CJBasic.Action<ScrapOrder, PaymentCommissionForm> ConfirmClick;
        public PaymentCommissionForm(ScrapOrder item)
        {
            InitializeComponent();  
        }

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButton1_Click(null, null);
            }
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            ConfirmClick?.Invoke(result, this);
        }   

        private String GetNewId()
        {
            String id = string.Empty;
            InteractResult result = null;// = GlobalCache.ServerProxy.GetPfCustomerId();
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    id = result.Msg;
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    break;
            }
            return id;
        }

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
