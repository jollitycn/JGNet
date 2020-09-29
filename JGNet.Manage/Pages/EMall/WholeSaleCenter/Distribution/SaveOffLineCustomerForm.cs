using JGNet.Common;
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

namespace JGNet.Manage
{
    public partial class SaveOffLineCustomerForm :  BaseForm
    { 

        public CJBasic.Action<PfCustomer, SaveOffLineCustomerForm> ConfirmClick;
        private PfCustomer curPfCustomer = null;
        private String curItemID;
        private TreeNode node;
        public SaveOffLineCustomerForm(String distributorID, PfCustomer item, TreeNode curNode=null)
        {
            InitializeComponent();
            // this.skinTextBoxID.KeyDown += SkinTxt_KeyDown;
            node = curNode;
            curItemID = distributorID;
            if (item != null)
            {
                if (node != null)
                {
                    this.Text = "编辑";
                }
                else
                {
                    this.Text = "修改下线客户";
                }
                curPfCustomer = item;
            }
            else
            {
                this.skinTextBoxID.Text = GetNewId();
                 
            }

            Display();
        }

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButton1_Click(null, null);
            }
        }

        private void Display()
        {
            if (curPfCustomer != null)
            {
                this.skinTextBoxID.Text = this.curPfCustomer.ID;
                this.skinTextBoxName.Text = this.curPfCustomer.Name;
                this.skinTextBox_Contact.Text = this.curPfCustomer.Contact;
                this.skinTextBox_ContactPhone.Text = this.curPfCustomer.ContactPhone;
                this.skinTextBox_BankInfo.Text = this.curPfCustomer.BankInfo;
                this.skinTextBox_Remarks.Text = this.curPfCustomer.Remarks;
                this.skinTextBox_Percent.Value = this.curPfCustomer.PfDiscount;
                this.textBoxPwd.Text = this.curPfCustomer.Password;
                skinRadioButtonSale.Checked = this.curPfCustomer.CustomerType == 1;
                skinRadioButtonBuyout.Checked = this.curPfCustomer.CustomerType == 0;
                textBoxBusinessAccount.Text = this.curPfCustomer.BusinessAccountID;
                skinTextBoxID.Enabled = false;
                skinCheckBox_Enabled.Checked = this.curPfCustomer.Enabled;
                // this.skinTextBox_Name.Enabled = false;
            }
            else
            {
                ResetAll();
            }
        }

        private void ResetAll()
        {
            this.skinTextBoxID.Text = GetNewId();
            this.skinTextBoxName.Text = null;
            this.skinTextBox_Contact.Text = null;
            this.skinTextBox_ContactPhone.Text = null;
            this.skinTextBox_BankInfo.Text = null;
            this.skinTextBox_Remarks.Text = null;
            //   this.numericUpDownSupplyDiscount.Value = 100;
            this.skinCheckBox_Enabled.Checked = true;
            skinRadioButtonSale.Checked = true;
            this.textBoxBusinessAccount.Text = null;
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        { 
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                PfCustomer pfCustomer = Build();
                if (!ValidateItem(pfCustomer)) { return; }
                if (curPfCustomer == null)
                { 

                    InteractResult result = PfCustomerCache.PfCustomer_OnInsert(pfCustomer);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("添加成功！");
                            if (node != null)
                            {
                                TreeModel CurChildrenClass = new TreeModel();
                                TreeNode newNode = new TreeNode(pfCustomer.Name);
                                CurChildrenClass.Name = pfCustomer.Name;
                                CurChildrenClass.ID = pfCustomer.ID;
                                CurChildrenClass.ParentID = curItemID;
                                newNode.Tag = CurChildrenClass;
                                newNode.Text = pfCustomer.Name + "/" + pfCustomer.ContactPhone+"(0.00)";
                                node.Nodes.Add(newNode);
                                CommonGlobalCache.InsertPFDistributor(CurChildrenClass);

                            }
                            ConfirmClick?.Invoke(curPfCustomer, this);
                            this.Close();
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    pfCustomer.CreateTime = curPfCustomer.CreateTime;
                    InteractResult result = PfCustomerCache.PfCustomer_OnUpdate(pfCustomer);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            GlobalMessageBox.Show("保存成功！");
                            this.DialogResult = DialogResult.OK;
                            if (node != null)
                            {
                                List<TreeModel> treeModelL=CommonGlobalCache.DistributorPFList.FindAll(t => t.ID == pfCustomer.ID);
                                TreeModel bigClass = node.Tag as TreeModel;
                                bigClass.ID = pfCustomer.ID;
                                bigClass.Name = pfCustomer.Name;
                                bigClass.AccruedCommission = curPfCustomer.AccruedCommission;
                                string accruedC = "0.00"; 
                                if (treeModelL.Count > 0)
                                {
                                    accruedC = treeModelL[0].AccruedCommission.ToString();
                                }
                                //JGNet.Common.ServerProxy.GetPfCustomer
                                 InteractResult<PfCustomer> selectPfCus=CommonGlobalCache.ServerProxy.GetPfCustomer(pfCustomer.ID);
                                if (selectPfCus != null) {
                                    accruedC =Math.Round(selectPfCus.Data.AccruedCommission,2).ToString();
                                }
                                node.Text = pfCustomer.Name+"/"+pfCustomer.ContactPhone+"("+ accruedC + ")";
                                
                                node.Tag = bigClass;
                            CommonGlobalCache.UpdatePFDistributor(bigClass);
                            }
                            this.curPfCustomer = pfCustomer;
                            ConfirmClick?.Invoke(curPfCustomer,this);
                            this.Close();
                            break;
                    }
                }
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

        private bool ValidateItem(PfCustomer pfCustomer)
        {
            bool validate = true;
            if (String.IsNullOrEmpty(pfCustomer.ID))
            {
                GlobalMessageBox.Show("客户编号不能为空，请输入编号！");
                this.skinTextBoxID.Focus();
                validate = false;
            }
            else if (String.IsNullOrEmpty(pfCustomer.Name))
            {
                GlobalMessageBox.Show("客户名称不能为空，请输入名称！");
                this.skinTextBoxName.Focus();
                validate = false;
            }
            else if (String.IsNullOrEmpty(pfCustomer.Password))
            {
                GlobalMessageBox.Show("客户密码不能为空，请输入密码！");
                this.textBoxPwd.Focus();
                validate = false;
            }
            //BusinessAccountID 账套不能为当前账套
            string CurrbusinessAccountId = CommonGlobalCache.BusinessAccount.ID.ToUpper();
            if (pfCustomer.BusinessAccountID.ToUpper() == CurrbusinessAccountId)
            {
                GlobalMessageBox.Show("不能绑定当前账套！");
                this.textBoxBusinessAccount.Focus();
                validate = false;
            }
            return validate;
        }

        private PfCustomer Build()
        {

            PfCustomer customer = new PfCustomer();


            customer.ID = this.skinTextBoxID.SkinTxt.Text.Trim();
            customer.FirstCharSpell = DisplayUtil.GetPYString(this.skinTextBoxName.SkinTxt.Text.Trim());
            customer.Name = this.skinTextBoxName.SkinTxt.Text.Trim();
            customer.Contact = this.skinTextBox_Contact.SkinTxt.Text.Trim();
            customer.ContactPhone = this.skinTextBox_ContactPhone.SkinTxt.Text.Trim();
            customer.BankInfo = this.skinTextBox_BankInfo.SkinTxt.Text.Trim();
            customer.Remarks = this.skinTextBox_Remarks.SkinTxt.Text.Trim();
            customer.PfDiscount = this.skinTextBox_Percent.Value;
            customer.BusinessAccountID = textBoxBusinessAccount.Text.Trim();
            customer.Password = this.textBoxPwd.Text.Trim();
            customer.LastAccountTime = DateTime.Now;
            customer.DefaultAddressID = 0;
            customer.Balance = 0;
            customer.PaymentBalance = 0;
            if (node.Text != "所有分销客户")
            {
                customer.DistributorID = curItemID;
            }

            //  SupplyDiscount = Decimal.ToByte(this.numericUpDownSupplyDiscount.Value),
            customer.Enabled = this.skinCheckBox_Enabled.Checked;
            customer.CreateTime = DateTime.Now;
            customer.CustomerType = (byte)(skinRadioButtonSale.Checked ? 1 : 0);
            

            return customer;
        }

        private void skinTextBoxID_Leave(object sender, EventArgs e)
        {
            PfCustomer listItem = PfCustomerCache.PfCustomerList?.Find(t => t.ID == skinTextBoxID.Text);
            if (listItem != null)
            {
                if (skinTextBoxName.Text != listItem.ID)
                {
                    GlobalMessageBox.Show("编号已存在");
                    skinTextBoxID.Text = string.Empty;
                    skinTextBoxID.Focus();
                }
            }
        }

        private void skinTextBoxName_Leave(object sender, EventArgs e)
        {
            PfCustomer listItem = PfCustomerCache.PfCustomerList?.Find(t => t.Name == skinTextBoxName.Text);
            if (listItem != null)
            {
                if (skinTextBoxID.Text != listItem.ID)
                {
                    GlobalMessageBox.Show("名称已存在");
                    skinTextBoxName.Text = string.Empty;
                    skinTextBoxName.Focus();
                }
            }
        }


        private String GetNewId()
        {
            String id = string.Empty;
            InteractResult result =  GlobalCache.ServerProxy.GetPfCustomerId();
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

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        internal void Cancel()
        {
            this.Enabled = true;
        }

        private void textBoxPwd_Leave(object sender, EventArgs e)
        {
            if (skinCheckBoxShowPwd.Checked)
            {
                textBoxPwd.IsSystemPasswordChar = false;
                textBoxPwd.IsPasswordChat = default(char);
            }
            else
            {
                textBoxPwd.IsSystemPasswordChar = true;
            }
        }
    }
}
