using JGNet.Core.InteractEntity;
using JGNet.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common.Components
{
    public partial class SelectSupplierForm : 
        BaseForm
    {
        private Supplier result;
        public Supplier Result { get { return result; } }
        public SelectSupplierForm()
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
            // this.result = 
            this.result = skinComboBoxSupplier.SelectedItem as Supplier;
            this.DialogResult = DialogResult.OK;
        }

        private void BaseButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
