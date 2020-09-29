using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core.Const;
using CCWin;
using JGNet.Core;
using CJBasic.Loggers;
using CJPlus;
using JGNet.ForManage;
using JGNet.Manage.Pages.RuleSettings;
using System.Reflection;
using JGNet.Common.Core;  
using CJBasic.Security;
using JGNet.Core.InteractEntity;
using JGNet.Common;

namespace JGNet.Manage.Retail

{
    public partial class GuideEditCtrl : BaseModifyUserControl
    {

        public GuideEditCtrl()
        {
            InitializeComponent(); dataGridViewRole.AutoGenerateColumns = false;
        }

        public GuideEditCtrl(Guide guide)
        {
            InitializeComponent();
            this.guide = guide; dataGridViewRole.AutoGenerateColumns = false;
        }


        private String GetNewColorID()
        {
            String id = string.Empty;
            InteractResult result = GlobalCache.ServerProxy.GetGuideId();
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

        public void RefreshGuide(Guide e) {
            this.guide = e;
            Display();

        }

        private Guide guide { get; set; }

        private Boolean editMode= false;
      

        public void Display()
        {

            if (guide != null)
            {
                skinLabel4.Visible = false;
                editMode = true;

                this.skinTextBoxContact.Text = this.guide.Contact;

                this.skinTextBoxBankNumber.Text = this.guide.BankCard;

                this.skinComboBoxShopID.SelectedValue = this.guide.ShopID;

                this.skinTextBoxHPhone.Text = this.guide.HomePhone;
                this.skinTextBoxHomeAddress.Text = this.guide.HomeAddress;
                this.skinTextBoxPhone.Text = this.guide.MobilePhone;
                this.dateTimePickerBirthday.Value = this.guide.Birthday;

                this.skinTextBoxRemarks.Text = this.guide.Remarks;
                this.skinTextBoxGuideName.Text = this.guide.Name;
                this.skinTextBoxIdentify.Text = this.guide.IdentityNo;
                this.skinTextBoxID.Text = this.guide.ID;

                this.skinRadioButtonSexMan.Checked = this.guide.Sex;
                this.skinRadioButtonSexFemale.Checked = !this.skinRadioButtonSexMan.Checked;
                this.skinRadioButtonMarrayed.Checked = this.guide.Marriaged;
                this.skinRadioButtonUnMarrayed.Checked = !this.skinRadioButtonMarrayed.Checked;
                this.skinCheckBoxState.Checked = (this.guide.State == 0);
                this.skinComboBoxShopID.Enabled = false;
                this.skinTextBoxID.Enabled = false;
                SetUpShopView();
            }
            else
            {
                skinTextBoxID.Text = GetNewColorID();
            }
        }

        private void GuideEditCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewRole.AutoGenerateColumns = false;
                InteractResult<List<Role>> result = GlobalCache.ServerProxy.GetRolesFilterAdmin();
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        dataGridViewRole.DataSource = result.Data;
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
                this.skinComboBoxShopID.Initialize(true);
                Display();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }


        }

        private bool ValidateInput()
        {
            bool success = true;
            if (String.IsNullOrEmpty(guide.ID))
            {
                this.skinTextBoxID.Focus();
                GlobalMessageBox.Show("导购编号不能为空！");
                success = false;
            }
            else if (String.IsNullOrEmpty(guide.Name))
            {
                this.skinTextBoxGuideName.Focus();
                GlobalMessageBox.Show("导购姓名不能为空！");
                success = false;
            }
            else if (String.IsNullOrEmpty(guide.ShopID))
            {
                this.skinComboBoxShopID.Focus();
                GlobalMessageBox.Show("请选择店铺！");
                success = false;
            }
            return success;
        }
        private void BaseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                setGuide();
                if (!ValidateInput()) { return; }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                if (editMode)
                {
                    InteractResult result = GlobalCache.GuideList_OnUpdate(guide);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("保存成功！");
                            this.TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
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


                    //set default value
                    // this.guide.JoinTime = DateTime.Now;
                    // this.guide.PositiveTime = DateTime.Now;
                    //this.guide.DimissionTime = DateTime.Now;
                    InteractResult result = GlobalCache.GuideList_OnInsert(guide);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("添加成功！");
                            this.TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
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

        private void setGuide()
        {
            if (this.guide == null) {
                guide = new Guide();

                this.guide.Password = SecurityHelper.MD5String2(SystemDefault.Pwd);
            }
            this.guide.Contact = this.skinTextBoxContact.Text;

            this.guide.BankCard = this.skinTextBoxBankNumber.Text;
            if (!String.IsNullOrEmpty(this.dateTimePickerBirthday.Text))
            {
                this.guide.Birthday = dateTimePickerBirthday.Value;
            }
            if (this.skinComboBoxShopID.SelectedValue != null)
            {
                this.guide.ShopID = this.skinComboBoxShopID.SelectedValue.ToString();
            }
            this.guide.MobilePhone = this.skinTextBoxPhone.Text;
            //this.guide.Marriaged
            this.guide.HomeAddress = this.skinTextBoxHomeAddress.Text;
            this.guide.HomePhone = this.skinTextBoxHPhone.Text;


            this.guide.Remarks = this.skinTextBoxRemarks.Text;
            this.guide.Name = this.skinTextBoxGuideName.Text;
            this.guide.IdentityNo = this.skinTextBoxIdentify.Text;
            this.guide.ID = this.skinTextBoxID.Text.ToLower();

            this.guide.Sex = this.skinRadioButtonSexMan.Checked ? true : false;
            this.guide.Marriaged = this.skinRadioButtonMarrayed.Checked ? true : false;
            this.guide.State  =(byte)( !this.skinCheckBoxState.Checked ? 1 : 0);
          // this.guide.HeadImage = null;
            this.guide.RoleIDs = GetRoles();
        }


        private string GetRoles()
        {
            String shopIDStr = "";
            List<Role> shops = (List<Role>)this.dataGridViewRole.DataSource;
            foreach (var item in shops)
            {
                if (item.Selected)
                {
                    shopIDStr += item.AutoID + ",";
                }

            }
            if (shopIDStr.Length > 0)
            {
                shopIDStr = shopIDStr.Remove(shopIDStr.LastIndexOf(","));
            }
            return shopIDStr;
        }
        private void SetUpShopView()
        {
            //设置店铺列表

            List<Role> keyValues = (List<Role>)this.dataGridViewRole.DataSource;
            String[] shopIds = this.guide.RoleIDs.Split(',');
            foreach (var item in shopIds)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    Role shop = keyValues.Find(t => t.AutoID.Equals(int.Parse(item)));
                    if (shop != null)
                    {
                        shop.Selected = true;
                    }
                }
            }
            this.dataGridViewRole.DataSource = null;
            this.dataGridViewRole.DataSource = keyValues;
        }
    }
}
