using JGNet.Common.cache.Wholesale;
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
    public partial class NewWholesaleCustomerSimpleForm : 
        BaseForm
    {
        private PfCustomer result;
        public PfCustomer Result { get { return result; } } 
        public NewWholesaleCustomerSimpleForm( )
        {
            InitializeComponent(); 
            //this.DialogResult = DialogResult.No;
            //this.skinTextBoxValue.Focus(); 
            // skinLabel.Text = labelName + "：";
            this.skinTextBoxID.SkinTxt.KeyDown += SkinTxt_KeyDown;
            this.skinTextBoxID.Text = GetNewId();
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
            String pwd = this.textBoxPwd.SkinTxt.Text.Trim();
            if (String.IsNullOrEmpty(id))
            {
                this.skinTextBoxID.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(name))
            {
                this.skinTextBoxName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(pwd))
            {
                this.textBoxPwd.Focus();
                return;
            }
            byte customerType = 0;
            if (skinRadioButtonSale.Checked) { customerType = 1; }
            else if (skinRadioButtonBuyout.Checked) { customerType = 0; }
            //skinRadioButtonBuyout.Checked = this.curPfCustomer.CustomerType == 0;
            decimal pfDiscount = this.textBoxDicount.Value;
            this.result = new PfCustomer()
            {
                ID = id,
                Name = name,
                Password =pwd,
                FirstCharSpell = DisplayUtil.GetPYString(name),
               CustomerType= customerType,
                PfDiscount= pfDiscount,
                // SupplyDiscount = Decimal.ToByte(numericUpDownSupplyDiscount.Value)
            };

             
           
            this.DialogResult = DialogResult.OK;

        }
         
         

        private void NewPfCustomerComboBoxForm_Shown(object sender, EventArgs e)
        {
            //this.skinTextBoxValue.Text = "";
            //this.skinTextBoxValue.Select();
            //this.skinTextBoxValue.Focus();
        }

        private void skinTextBoxID_Leave(object sender, EventArgs e)
        {
            PfCustomer listItem = PfCustomerCache.PfCustomerList?.Find(t => t.ID == skinTextBoxID.Text);
            if (listItem != null)
            {
                GlobalMessageBox.Show("客户编号已存在");
                skinTextBoxID.Text = string.Empty;
                skinTextBoxID.Focus();
            }
        }

        private void skinTextBoxName_Leave(object sender, EventArgs e)
        {
            PfCustomer listItem = PfCustomerCache.PfCustomerList?.Find(t => t.Name == skinTextBoxName.Text);
            if (listItem != null)
            {
                GlobalMessageBox.Show("客户名称已存在");
                skinTextBoxName.Text = string.Empty;
                skinTextBoxName.Focus();
            }
        }


        private String GetNewId()
        {
            String id = string.Empty;
            InteractResult result = GlobalCache.ServerProxy.GetPfCustomerId();
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

        private void skinLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
