using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using JGNet.Manage;
using JGNet.Manage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common.Components
{
    public partial class PrintBarcodeForm : BaseForm
    {
        private PrintBarcodeSetting result;
        private Costume curItem;
        public PrintBarcodeSetting Result { get { return result; } }
        public PrintBarcodeForm(Costume item)
        {
            InitializeComponent();
            skinLabelCostumeID.Text = string.Empty;
            //skinLabelBalance.Text = string.Empty;
            //textBoxCustomer.Initialize(true, true);
            this.curItem = item;
            LoadItemInfo();
        }

        private void LoadItemInfo()
        {
            if (this.curItem != null) {
                skinLabelCostumeID.Text = this.curItem.ID;
                this.skinComboBox_Color.DataSource = curItem.ColorList;
                this.skinComboBox_Color.SelectedIndex = 0;
                CommonGlobalUtil.SetCostumeSize(skinComboBox_Size, curItem);
            }
        }

        private void BaseButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //if (this.bean == null) {
                //    GlobalMessageBox.Show(this,"找不到客户信息");
                //    this.textBoxCustomer.Focus();
                //    return; 
                //}

                if (this.textBoxAmount.Value == 0)
                {
                    GlobalMessageBox.Show(this, "请输入打印数量");
                    this.textBoxAmount.Focus();
                    return;
                }



                result = new PrintBarcodeSetting()
                {
                    ColorName = ValidateUtil.CheckEmptyValue(skinComboBox_Color.SelectedValue),
                    CostumeID = curItem.ID,
                    SizeName = ValidateUtil.CheckEmptyValue(skinComboBox_Size.SelectedValue),
                    Times = Decimal.ToInt32(textBoxAmount.Value)
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
        }

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private PfCustomer bean;

        private void textBoxCustomer_ItemSelected(PfCustomer bean)
        {
            this.bean = bean;
            skinLabelCostumeID.Text = bean?.Name.ToString();
        } 
    }
}
