using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Core.InteractEntity; 
using CJBasic.Security;
using JGNet.Common.cache.Wholesale;
using JGNet.Common;
using JGNet.Core.Util;

namespace JGNet.Manage.Pages
{
    public partial class WholesaleCustomerSaveCtrl : BaseModifyUserControl
    {

        public Action<PfCustomer> SaveResult;
        private PfCustomer curPfCustomer = null; 
        public WholesaleCustomerSaveCtrl()
        {
            InitializeComponent();
        }

        public WholesaleCustomerSaveCtrl(PfCustomer PfCustomer)
        {
            InitializeComponent();
            this.curPfCustomer = PfCustomer;
            Display(); 
        }


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                //ShowMessage(Pinyin.GetInitials("埼", Encoding.GetEncoding("GB2312")));

                if (curPfCustomer == null)
                {
                    String name= this.skinTextBox_Name.SkinTxt.Text.Trim();
                    PfCustomer pfCustomer = new PfCustomer()
                    {
                        ID = this.skinTextBox_ID.SkinTxt.Text.Trim(),
                        Name = name,
                        Contact = this.skinTextBox_Contact.SkinTxt.Text.Trim(),
                        ContactPhone = this.skinTextBox_ContactPhone.SkinTxt.Text.Trim(),
                        BankInfo = this.skinTextBox_BankInfo.SkinTxt.Text.Trim(),
                        Remarks = this.skinTextBox_Remarks.SkinTxt.Text.Trim(),
                        PfDiscount = this.textBoxDicount.Value,
                        BusinessAccountID = textBoxBusinessAccount.Text.Trim(),
                        Password = this.textBoxPwd.Text.Trim(),
                        LastAccountTime = DateTime.Now,
                        DefaultAddressID = 0,
                        Balance = 0,
                        PaymentBalance = 0,
                        FirstCharSpell = DisplayUtil.GetPYString(name),
                        //  SupplyDiscount = Decimal.ToByte(this.numericUpDownSupplyDiscount.Value),
                        Enabled = this.skinCheckBox_Enabled.Checked,
                        CreateTime = DateTime.Now,
                        CustomerType = (byte)(skinRadioButtonSale.Checked ? 1 : 0)
                    };
                    
                    if (String.IsNullOrEmpty(pfCustomer.ID))
                    {
                        GlobalMessageBox.Show("客户编号不能为空，请输入编号！");
                        this.skinTextBox_ID.Focus();
                        return;
                    }
                    else if (String.IsNullOrEmpty(pfCustomer.Name))
                    {
                        GlobalMessageBox.Show("客户名称不能为空，请输入名称！");
                        this.skinTextBox_Name.Focus();
                        return;
                    }
                    else if (String.IsNullOrEmpty(pfCustomer.Password))
                    {
                        GlobalMessageBox.Show("客户密码不能为空，请输入密码！");
                        this.textBoxPwd.Focus();
                        return;
                    }
                    //BusinessAccountID 账套不能为当前账套
                   string CurrbusinessAccountId= CommonGlobalCache.BusinessAccount.ID.ToUpper();
                    if (pfCustomer.BusinessAccountID.ToUpper() == CurrbusinessAccountId)
                    {
                        GlobalMessageBox.Show("不能绑定当前账套！");
                        this.textBoxBusinessAccount.Focus();
                        return;
                    }
                   InteractResult result = PfCustomerCache.PfCustomer_OnInsert(pfCustomer);

                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            TreeModel treeN = new TreeModel();
                            treeN.ID = pfCustomer.ID;
                            treeN.Name = pfCustomer.Name;
                            CommonGlobalCache.InsertPFDistributor(treeN);
                            //CommonGlobalCache.DistributorPFList.Clear();
                            
                            GlobalMessageBox.Show("添加成功！");
                            TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
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
                    this.curPfCustomer.ID = this.skinTextBox_ID.SkinTxt.Text.Trim();
                    this.curPfCustomer.Name = this.skinTextBox_Name.SkinTxt.Text.Trim();
                    this.curPfCustomer.Contact = this.skinTextBox_Contact.SkinTxt.Text.Trim();
                    this.curPfCustomer.ContactPhone = this.skinTextBox_ContactPhone.SkinTxt.Text.Trim();
                    this.curPfCustomer.BankInfo = this.skinTextBox_BankInfo.SkinTxt.Text.Trim();
                    this.curPfCustomer.Remarks = this.skinTextBox_Remarks.SkinTxt.Text.Trim();
                    this.curPfCustomer.PfDiscount = this.textBoxDicount.Value;
                    this.curPfCustomer.BusinessAccountID = this.textBoxBusinessAccount.Text.Trim();
                    this.curPfCustomer.Password = this.textBoxPwd.Text;
                    this.curPfCustomer.Enabled = this.skinCheckBox_Enabled.Checked;
                    this.curPfCustomer.FirstCharSpell = DisplayUtil.GetPYString(this.curPfCustomer.Name);
                    this.curPfCustomer.CustomerType = (byte)(skinRadioButtonSale.Checked ? 1 : 0);
                    if (String.IsNullOrEmpty(curPfCustomer.Password))
                    {
                        this.textBoxPwd.Focus();
                        return;
                    }
                    //BusinessAccountID 账套不能为当前账套
                    string CurrbusinessAccountId = CommonGlobalCache.BusinessAccount.ID.ToUpper();
                    if (curPfCustomer.BusinessAccountID.ToUpper() == CurrbusinessAccountId)
                    {
                        this.textBoxBusinessAccount.Focus();
                        GlobalMessageBox.Show("不能绑定当前账套！");
                        return;
                    }

                    InteractResult result = PfCustomerCache.PfCustomer_OnUpdate(curPfCustomer);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            TreeModel treeN = new TreeModel();
                            treeN.ID = curPfCustomer.ID;
                            treeN.Name = curPfCustomer.Name;
                            CommonGlobalCache.UpdatePFDistributor(treeN);
                            GlobalMessageBox.Show("保存成功！");
                            SaveResult?.Invoke(curPfCustomer);
                            TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
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

        public void RefreshPfCustomer(PfCustomer e)
        {
            curPfCustomer = e;
            Display();

        }

        private void Display()
        {
            if (curPfCustomer != null)
            {
                this.skinTextBox_ID.Text = this.curPfCustomer.ID;
                this.skinTextBox_Name.Text = this.curPfCustomer.Name;
                this.skinTextBox_Contact.Text = this.curPfCustomer.Contact;
                this.skinTextBox_ContactPhone.Text = this.curPfCustomer.ContactPhone;
                this.skinTextBox_BankInfo.Text = this.curPfCustomer.BankInfo;
                this.skinTextBox_Remarks.Text = this.curPfCustomer.Remarks; 
                this.textBoxDicount.Value = this.curPfCustomer.PfDiscount;
                this.textBoxPwd.Text = this.curPfCustomer.Password;
                skinRadioButtonSale.Checked = this.curPfCustomer.CustomerType == 1;
                skinRadioButtonBuyout.Checked = this.curPfCustomer.CustomerType == 0;
                textBoxBusinessAccount.Text =  this.curPfCustomer.BusinessAccountID; 
                skinTextBox_ID.Enabled = false;
                skinCheckBox_Enabled.Checked = this.curPfCustomer.Enabled;
               // this.skinTextBox_Name.Enabled = false;
            }
            else
            {
                ResetAll();
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


        private void ResetAll()
        {
            this.skinTextBox_ID.Text = GetNewId();
            this.skinTextBox_Name.Text = null;
            this.skinTextBox_Contact.Text = null;
            this.skinTextBox_ContactPhone.Text = null;
            this.skinTextBox_BankInfo.Text = null;
            this.skinTextBox_Remarks.Text = null;
            //   this.numericUpDownSupplyDiscount.Value = 100;
            this.skinCheckBox_Enabled.Checked = true;
            skinRadioButtonSale.Checked = true;
            this.textBoxBusinessAccount.Text = null;
        }

        private void skinTextBox_Name_Leave(object sender, EventArgs e)
        {
            //检查名称是否重复
            String PfCustomerName = skinTextBox_Name.Text;
            PfCustomer PfCustomer = PfCustomerCache.PfCustomerList.Find(t => t.Name.Equals(PfCustomerName));
            if (PfCustomer != null)
            {
                if (curPfCustomer != null && curPfCustomer.ID != PfCustomer.ID)
                {
                    GlobalMessageBox.Show("客户名称已存在！");
                    skinTextBox_Name.Focus();
                }
            }
        }


        private void skinTextBox_ID_Leave(object sender, EventArgs e)
        {
            //检查名称是否重复
            String id = skinTextBox_ID.Text;
            PfCustomer PfCustomer = PfCustomerCache.PfCustomerList.Find(t => t.ID.Equals(id));
            if (PfCustomer != null)
            {
                GlobalMessageBox.Show("客户编号已存在");
           //     skinTextBox_ID.Text = string.Empty;
                skinTextBox_ID.Focus();
            }
        }

        private void skinCheckBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (skinCheckBoxShowPwd.Checked)
            {
                textBoxPwd.IsSystemPasswordChar = false;
                textBoxPwd.IsPasswordChat = default(char);
            } else
            {
                textBoxPwd.IsSystemPasswordChar = true; 
            }
        }
    }

}
