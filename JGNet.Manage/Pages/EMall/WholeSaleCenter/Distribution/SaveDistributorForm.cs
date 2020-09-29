using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Core.InteractEntity;
using JGNet.Manage; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class SaveDistributorForm : 
        BaseForm
    {
        public CJBasic.Action<Distributor, SaveDistributorForm> ConfirmClick;
        public SaveDistributorForm(Distributor item)
        {
            InitializeComponent(); 
            this.skinTextBoxID.KeyDown += SkinTxt_KeyDown;
            if (item != null) {
                skinTextBoxID.Text = item.ID;
                skinTextBoxName.Text = item.Name;
                textBoxPwd.Text = item.Password;
                skinTextBoxID.Enabled = false;
            } else { 
            this.skinTextBoxID.Text = GetNewId();
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
            if (String.IsNullOrEmpty(skinTextBoxID.Text.Trim())) {
                GlobalMessageBox.Show("编号不能为空！");
                skinTextBoxID.Focus();
                return;
            } else if (String.IsNullOrEmpty(skinTextBoxName.Text.Trim())) {
                GlobalMessageBox.Show("名称不能为空！");
                skinTextBoxName.Focus();
                return;
            } else if (String.IsNullOrEmpty(textBoxPwd.Text.Trim())) {
                GlobalMessageBox.Show("密码不能为空！");
                textBoxPwd.Focus();
                return;
            }



            Distributor result = new Distributor()
            { 
                ID = skinTextBoxID.Text,
                Name = skinTextBoxName.Text,
                Password = textBoxPwd.Text
            };
            this.Enabled = false;
            ConfirmClick?.Invoke(result, this);
        } 

        private void skinTextBoxID_Leave(object sender, EventArgs e)
        {
            Distributor listItem = GlobalCache.DistributorList?.Find(t => t.ID == skinTextBoxID.Text);
            if (listItem != null)
            {
                GlobalMessageBox.Show("编号已存在！");
                skinTextBoxID.Text = string.Empty;
                skinTextBoxID.Focus();
            }
        }

        private void skinTextBoxName_Leave(object sender, EventArgs e)
        {
            Distributor listItem = GlobalCache.DistributorList?.Find(t => t.ID != skinTextBoxID.Text
            && t.Name == skinTextBoxName.Text);
            if (listItem != null)
            {
                GlobalMessageBox.Show("名称已存在！");
                skinTextBoxName.Text = string.Empty;
                skinTextBoxName.Focus();
            }
        }

        private String GetNewId()
        {
            String id = string.Empty;
            try
            {
                InteractResult result =   GlobalCache.ServerProxy.GetDistributorID();
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
            }
            catch (Exception ex) {
                //ex.StackTrace();
            }
            return id;
        }

        internal void Cancel()
        {
            this.Enabled = true;
        }

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
