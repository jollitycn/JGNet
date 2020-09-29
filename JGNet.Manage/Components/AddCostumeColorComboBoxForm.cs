using JGNet.Common.Core.Util;
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
    public partial class AddCostumeColorComboBoxForm : 
        BaseForm
    {
        private CostumeColor result;
        public CostumeColor Result { get { return result; } } 
        public AddCostumeColorComboBoxForm( )
        {
            InitializeComponent();
          
             this.skinTextBoxID.SkinTxt.KeyDown += SkinTxt_KeyDown;
            skinTextBoxID.Text = this.GetNewColorID();

        }
        private String GetNewColorID()
        {
            String id = string.Empty;
            InteractResult result = GlobalCache.ServerProxy.GetCostumeColorId();
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

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButton1_Click(null, null);
            }
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {

            String id = this.skinTextBoxID.SkinTxt.Text.Trim();
            String name = this.skinTextBoxName.SkinTxt.Text.Trim();
            if (String.IsNullOrEmpty(id) || !ValidateUtil.CheckMoney(id))
            {
                this.skinTextBoxID.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(name))
            {
                this.skinTextBoxName.Focus();
                return;
            }
            this.result = new CostumeColor()
            {
                ID = id,
                Name = name,
                FirstCharSpell = DisplayUtil.GetPYString(name)
                //  SupplyDiscount = Decimal.ToByte(numericUpDownSupplyDiscount.Value)
            };
            this.DialogResult = DialogResult.OK;

        }
         
         

        private void AddCostumeColorComboBoxForm_Shown(object sender, EventArgs e)
        {
            //this.skinTextBoxValue.Text = "";
            //this.skinTextBoxValue.Select();
            //this.skinTextBoxValue.Focus();
        }

        private void skinTextBoxID_Leave(object sender, EventArgs e)
        {
            CostumeColor listItem = GlobalCache.CostumeColorList?.Find(t => t.ID == skinTextBoxID.Text);
            if (listItem != null)
            {
                GlobalMessageBox.Show("编号已存在！");
                skinTextBoxID.Text = string.Empty;
                skinTextBoxID.Focus();
            } 
        }

        private void skinTextBoxName_Leave(object sender, EventArgs e)
        {
            CostumeColor listItem = GlobalCache.CostumeColorList?.Find(t => t.Name == skinTextBoxName.Text);
            if (listItem != null)
            {
                GlobalMessageBox.Show("名称已存在！");
                skinTextBoxName.Text = string.Empty;
                skinTextBoxName.Focus();
            }

        }
    }
}
