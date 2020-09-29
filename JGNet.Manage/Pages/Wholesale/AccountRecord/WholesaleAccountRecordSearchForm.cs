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
    public partial class WholesaleAccountRecordSearchForm : 
        BaseForm
    { 

        public WholesaleAccountRecordSearchForm()
        { 
            InitializeComponent(); 
        }

        private void PfCustomerAccountRecordSearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void supplierAccountRecordSearchCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void WholesaleAccountRecordSearchForm_Shown(object sender, EventArgs e)
        {
            supplierAccountRecordSearchCtrl1.Search();
        }
    }
}
