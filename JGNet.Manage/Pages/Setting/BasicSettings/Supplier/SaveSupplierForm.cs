using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using JGNet.Manage.Pages;
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
    public partial class SaveSupplierForm :
        BaseForm
    {
        public Action<bool> Form_Save;
        SaveSupplierCtrl saveSupplierCtrl;
        public SaveSupplierForm(Supplier item)
        {
            InitializeComponent();
            saveSupplierCtrl = new SaveSupplierCtrl(item);
            if (item == null)
            {
                this.Text = "添加供应商";
            }
            saveSupplierCtrl.BackColor = Color.Transparent;
            saveSupplierCtrl.SaveClick += SaveClick;
            this.Controls.Add(saveSupplierCtrl);
            this.saveSupplierCtrl.Dock = DockStyle.Fill;
        }

        private void SaveClick(bool success, String msg)
        {
                if (success)
            {
                GlobalMessageBox.Show(msg);
                Form_Save?.Invoke(success);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    GlobalMessageBox.Show(msg);
                } 
        }
    }
}
