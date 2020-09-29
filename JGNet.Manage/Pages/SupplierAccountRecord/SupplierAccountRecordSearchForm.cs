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
    public partial class SupplierAccountRecordSearchForm : BaseForm
    { 

        public SupplierAccountRecordSearchForm()
        {
            InitializeComponent(); 
        }


        public Supplier supplier;


        public void ShowDialog(Supplier supplier)
        {
            try
            {

                this.supplier = supplier;
                this.ShowDialog();
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }

        }

        private void SupplierAccountRecordSearchForm_Shown(object sender, EventArgs e)
        {
            supplierAccountRecordSearchCtrl1.Search();
        }
    }
}
