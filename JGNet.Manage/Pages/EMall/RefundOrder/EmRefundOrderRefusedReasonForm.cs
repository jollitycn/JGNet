using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common.Components
{
    public partial class EmRefundOrderRefusedReasonForm : 
        BaseForm
    {
        private String result;
        public String Result { get { return result; } } 

        public EmRefundOrderRefusedReasonForm()
        {
            InitializeComponent();
            //this.DialogResult = DialogResult.No;
            //this.skinTextBoxValue.Focus(); 
            // skinLabel.Text = labelName + "：";
             this.skinTextBoxReason.SkinTxt.KeyDown += SkinTxt_KeyDown;
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
            String id = this.skinTextBoxReason.SkinTxt.Text.Trim();
            this.result = id;
            this.DialogResult = DialogResult.OK;

        }
         
         

        private void EmRefundOrderRefusedReasonForm_Shown(object sender, EventArgs e)
        {
            //this.skinTextBoxValue.Text = "";
            //this.skinTextBoxValue.Select();
            //this.skinTextBoxValue.Focus();
        }

        private void BaseButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
