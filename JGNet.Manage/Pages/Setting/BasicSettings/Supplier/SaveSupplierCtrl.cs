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
using JGNet.Common;
using CJBasic;

namespace JGNet.Manage.Pages
{
    public partial class SaveSupplierCtrl : BaseModifyUserControl
    { 

        private Supplier curSupplier = null;

        public Action<bool,String> SaveClick;

        public SaveSupplierCtrl()
        {
            InitializeComponent();
        }

        private String GetNewColorID()
        {
            String id = string.Empty;
            InteractResult result = GlobalCache.ServerProxy.GetSupplierId();
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

        public SaveSupplierCtrl(Supplier supplier)
        {
            InitializeComponent();
            curSupplier = supplier;
            Display();
        }
         
        private void SaveClickInvoke(bool success, String msg)
        { 
                SaveClick?.Invoke(success, msg);
        }

        String skinTextBox_ID;

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //if (GlobalUtil.EngineUnconnectioned(this))
                //{
                //    return;
                //}
                Supplier supplier = new Supplier()
                {
                    ID = skinTextBox_ID,
                    Name = this.skinTextBox_Name.SkinTxt.Text.Trim(),
                    Contact = this.skinTextBox_Contact.SkinTxt.Text.Trim(),
                    ContactPhone = this.skinTextBox_ContactPhone.SkinTxt.Text.Trim(),
                    BankInfo = this.skinTextBox_BankInfo.SkinTxt.Text.Trim(),
                    Remarks = this.skinTextBox_Remarks.SkinTxt.Text.Trim(),
                    //  SupplyDiscount = Decimal.ToByte(this.numericUpDownSupplyDiscount.Value),
                    Enabled = this.skinCheckBox_Enabled.Checked,
                    BusinessAccountID = textBoxBusinessAccount.Text,
                    CreateTime = DateTime.Now,
                    OrderNo = Decimal.ToInt32(textBoxSort.Value),
                };
                if (curSupplier == null)
                {
                  
                    if (String.IsNullOrEmpty(supplier.Name))
                    {
                        this.skinTextBox_Name.Focus();
                        GlobalMessageBox.Show("供应商名称不能为空！");
                        return;
                    }
                    //BusinessAccountID 账套不能为当前账套
                    string CurrbusinessAccountId = CommonGlobalCache.BusinessAccount.ID.ToUpper();
                    if (supplier.BusinessAccountID.ToUpper() == CurrbusinessAccountId)
                    {
                        this.textBoxBusinessAccount.Text = "";
                        this.textBoxBusinessAccount.Focus();                        
                        GlobalMessageBox.Show("不能绑定当前账套！");
                        return;
                    }
                    //  curSupplier = supplier;

                    InteractResult result = GlobalCache.Supllier_OnInsert(supplier);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            //GlobalMessageBox.Show(this.FindForm(),"内部错误！");

                            SaveClickInvoke(false, result.Msg);
                            break;
                        case ExeResult.Success:
                            SaveClickInvoke(true, "添加成功！"); 
                            break; 
                    }
                }
                else
                {


                    if (String.IsNullOrEmpty(this.skinTextBox_Name.SkinTxt.Text.Trim()))
                    {
                        this.skinTextBox_Name.Focus();
                        return;
                    }
                    //BusinessAccountID 账套不能为当前账套
                    string tempAccountID = textBoxBusinessAccount.SkinTxt.Text.Trim();
                    string CurrbusinessAccountId = CommonGlobalCache.BusinessAccount.ID.ToUpper();
                    if (tempAccountID.ToUpper() == CurrbusinessAccountId)
                    { 
                        this.textBoxBusinessAccount.Focus();
                        GlobalMessageBox.Show("不能绑定当前账套！");
                        return;
                    }
                     
                    
                    InteractResult result = GlobalCache.Supplier_OnUpdate(supplier);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            //  SaveClick?.Invoke(false);
                            //GlobalMessageBox.Show("内部错误！");

                            SaveClickInvoke(false, result.Msg);
                            break;
                        default:
                            //GlobalMessageBox.Show("保存成功！");
                            SaveClickInvoke(true, "保存成功!");
                            curSupplier = supplier;
                            //TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
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
                //    GlobalUtil.UnLockPage(this);
            }

        }

        public void RefreshSupplier(Supplier e)
        {
            curSupplier = e;
            Display();
        }

        private void Display()
        {
            if (curSupplier != null)
            {
                this.skinTextBox_ID = this.curSupplier.ID;
                this.skinTextBox_Name.Text = this.curSupplier.Name;
                this.skinTextBox_Contact.Text = this.curSupplier.Contact;
                this.skinTextBox_ContactPhone.Text = this.curSupplier.ContactPhone;
                this.skinTextBox_BankInfo.Text = this.curSupplier.BankInfo;
                this.skinTextBox_Remarks.Text = this.curSupplier.Remarks;
                this.skinCheckBox_Enabled.Checked = this.curSupplier.Enabled;
                textBoxBusinessAccount.Text = this.curSupplier.BusinessAccountID;
                textBoxSort.Value = curSupplier.OrderNo;
                this.skinTextBox_Name.Enabled = false;
            }
            else
            {
                ResetAll();
            }
        }

        private void ResetAll()
        {
            this.skinTextBox_ID = GetNewColorID();
            this.skinTextBox_Name.Text = null;
            this.skinTextBox_Contact.Text = null;
            this.skinTextBox_ContactPhone.Text = null;
            this.skinTextBox_BankInfo.Text = null;
            this.skinTextBox_Remarks.Text = null;
            this.textBoxBusinessAccount.Text = null;
            this.skinCheckBox_Enabled.Checked = true;
            textBoxSort.Value = 100;
        }

        private void skinTextBox_Name_Leave(object sender, EventArgs e)
        {
            //检查名称是否重复
            String supplierName = skinTextBox_Name.Text;
            Supplier supplier =  CommonGlobalCache.SupplierList.Find(t => t.Name.Equals(supplierName));
            if (supplier != null) {
                GlobalMessageBox.Show("供应商名称已存在！");
                skinTextBox_Name.Focus();
            }
        }
    }
}
