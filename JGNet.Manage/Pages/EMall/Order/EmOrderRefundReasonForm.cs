using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Common.Models;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using CJBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class EmOrderRefundReasonForm :
        BaseForm
    { 
        public String result { get; internal set; } 
        public EmOrderRefundReasonForm()
        {
            InitializeComponent(); 

        } 

        private void BaseButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                 
                result = rtfRichTextBox_Detail.Text;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }


        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         
         
    }
}
