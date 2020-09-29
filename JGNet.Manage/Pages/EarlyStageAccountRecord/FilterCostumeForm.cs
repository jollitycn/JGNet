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
using CJBasic.Helpers;
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
    public partial class FilterCostumeForm :
        BaseForm
    {
        public FilterCostumeForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
            skinComboBox_Year.Initialize();
        }

        public Action<Costume> ConfirmClick;
        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaseButtonSave_Click(object sender, EventArgs e)
        {
            Costume item = new Costume() { };
            item.ID = this.skinTextBox_ID.Text;
            item.Name = skinTextBox_Name.Text;
            item.SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBox_SupplierID.SelectedValue);
            Supplier supplier = this.skinComboBox_SupplierID.SelectedItem as Supplier;
            if (supplier != null)
            {
                item.SupplierID = supplier.ID;
                item.SupplierName= supplier.Name;
            }

            Brand brand = this.skinComboBox_Brand.SelectedItem as Brand;
            if (brand != null)
            {
                item.BrandID = brand.AutoID;
                item.BrandName = brand.Name;
            }

            item.Year =  (int)this.skinComboBox_Year.SelectedValue ;
            item.Season = ValidateUtil.CheckEmptyValue(this.skinComboBox_Season.SelectedValue);
            item.ClassID = this.skinComboBoxBigClass.SelectedValue.ClassID;
            //item.BigClass = this.skinComboBoxBigClass.SelectedValue?.BigClass;
            //item.SmallClass = this.skinComboBoxBigClass.SelectedValue?.SmallClass;
            //item.SubSmallClass = this.skinComboBoxBigClass.SelectedValue?.SubSmallClass;
            this.ConfirmClick?.Invoke(item);
            this.DialogResult = DialogResult.OK;
        }
    }
}
