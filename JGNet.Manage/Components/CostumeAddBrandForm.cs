using JGNet.Common.Core;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
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
    public partial class CostumeAddBrandForm : BaseForm
    {

        private Brand item;
     
        public Brand Result { get { return item; } }
        private OperationEnum action;
        public CostumeAddBrandForm(Brand brand = null,OperationEnum action=  OperationEnum.Add)
        {
            InitializeComponent();
            this.item = brand;
            this.action = action;
            Initialize();
        }

        private void Initialize()
        {
            skinTextBoxID.SkinTxt.Text = string.Empty;
            textBoxSort.Value = 100;
            if (action== OperationEnum.Edit)
            {
                skinTextBoxID.Text = item.Name;
                textBoxSort.Value = item.OrderNo;
                skinCheckBoxEnable.Checked = !item.IsDisable;
                this.Text = "修改品牌";
            }
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
            try
            {
                string brandName = skinTextBoxID.SkinTxt.Text;

                if (string.IsNullOrEmpty(brandName))
                {
                    MessageBox.Show("名称不能为空！");
                    this.skinTextBoxID.Focus();
                    return;
                }

                if (action == OperationEnum.Edit)
                {
                    item.Name = brandName;
                    item.FirstCharSpell = DisplayUtil.GetPYString(item.Name);
                    item.OrderNo = Decimal.ToInt32(textBoxSort.Value);
                    item.IsDisable = !skinCheckBoxEnable.Checked;
                    if (GlobalCache.BrandList.Exists(t => t.Name == item.Name && t.AutoID != item.AutoID))
                    {
                        GlobalMessageBox.Show("品牌已存在！");
                        return;
                    }
                }
                else
                {
                    this.item = new Brand()
                    {
                        Name = brandName,
                        OrderNo = Decimal.ToInt32(textBoxSort.Value),
                        FirstCharSpell = DisplayUtil.GetPYString(brandName),
                         IsDisable= !skinCheckBoxEnable.Checked,
                    };
                    if (GlobalCache.BrandList.Exists(t => t.Name == item.Name))
                    {
                        GlobalMessageBox.Show("品牌已存在！");
                        return;
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }
    }
}
