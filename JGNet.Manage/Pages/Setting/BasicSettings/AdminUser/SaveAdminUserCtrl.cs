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
using CJBasic.Security;
using JGNet.Common.Core;
using JGNet.Common;
using JGNet.Core.InteractEntity;
using JGNet.Core.Const;
using CJBasic.Helpers;

namespace JGNet.Manage.Pages
{
    public partial class SaveAdminUserCtrl : BaseModifyUserControl
    { 

        private AdminUser curAdminUser = null;
        private int NoAllowEdit = -1;
        public SaveAdminUserCtrl(AdminUser adminUser)
        {
            InitializeComponent();
            dataGridViewRole.AutoGenerateColumns = false;
            this.curAdminUser = adminUser;
            this.skinTextBox_ID.SkinTxt.KeyDown += SkinTxt_KeyDown;
            this.skinTextBox_Name.SkinTxt.KeyDown += SkinTxt_KeyDown;
            this.skinTextBox_Remarks.SkinTxt.KeyDown += SkinTxt_KeyDown;

            InteractResult<List<Role>> result= GlobalCache.ServerProxy.GetRoles();
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
            if (dataGridViewRole.DataSource != null)
            {
                List<Role> RList = result.Data;
                 
                for (int i = 0; i < RList.Count ;i++)
                {
                    if (RList[i].Name == "注册人")
                    {
                        NoAllowEdit=i;
                    }
                        
                }
            }
        }

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Btn_Save_Click(null, null);
            }
        }

        private void SaveAdminUserCtrl_Load(object sender, EventArgs e)
        {
            this.dataGridViewRole.AutoGenerateColumns = false;
            this.skinTextBox_ID.SkinTxt.Text = string.Empty;
            this.skinTextBox_Name.SkinTxt.Text = string.Empty;
            this.skinTextBox_Remarks.SkinTxt.Text = string.Empty;
            this.skinCheckBox_State.Checked = true;
            Display();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.skinTextBox_ID.SkinTxt.Text.Trim()))
                {
                    this.skinTextBox_ID.Focus();
                    return;
                }
                else
                if (String.IsNullOrEmpty(this.skinTextBox_Name.SkinTxt.Text.Trim()))
                {
                    this.skinTextBox_Name.Focus();
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (curAdminUser == null)
                {

                    AdminUser adminUser = new AdminUser()
                    {
                        RoleIDs = GetRoles(),
                        ID = this.skinTextBox_ID.SkinTxt.Text.ToLower().Trim(),
                        Remarks = skinTextBox_Remarks.SkinTxt.Text.Trim(),
                        Name = this.skinTextBox_Name.SkinTxt.Text.Trim(),
                        Password = SecurityHelper.MD5String2("888888"),
                        State = (byte)(this.skinCheckBox_State.Checked ? 0 : 1),
                        CreateTime = DateTime.Now,
                    };

                    if (String.IsNullOrEmpty(adminUser.ID))
                    {
                        this.skinTextBox_ID.Focus();
                        return;
                    }
                    else if (String.IsNullOrEmpty(adminUser.Name))
                    {
                        this.skinTextBox_Name.Focus();
                        return;
                    }
                    //  curAdminUser = AdminUser;

                    InteractResult result = GlobalCache.AdminUser_OnInsert(adminUser);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            GlobalMessageBox.Show("添加成功！");
                            base.TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                            break;

                    }
                }
                else
                {
                    AdminUser adminUser = new AdminUser() { };
                    ReflectionHelper.CopyProperty(curAdminUser, adminUser);
                    adminUser.Name = this.skinTextBox_Name.SkinTxt.Text.ToLower().Trim();
                    adminUser.State = (byte)(this.skinCheckBox_State.Checked ? 0 : 1);
                    adminUser.Remarks = skinTextBox_Remarks.SkinTxt.Text.Trim();
                    adminUser.RoleIDs = GetRoles();
                    InteractResult result = GlobalCache.AdminUser_OnUpdate(adminUser);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            GlobalMessageBox.Show("保存成功！");
                            base.TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
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

        public void Refresh(AdminUser e)
        {
            curAdminUser = e;
            Display();

        }

        private void Display()
        {
            if (curAdminUser != null)
            {
                this.skinTextBox_ID.Text = this.curAdminUser.ID;
                this.skinTextBox_Name.Text = this.curAdminUser.Name; 
                this.skinCheckBox_State.Checked = (this.curAdminUser.State==0);
                skinTextBox_Remarks.Text = this.curAdminUser.Remarks;  
                this.skinTextBox_ID.Enabled = false;
                skinLabel3.Visible = false;
                SetUpShopView();
                if (curAdminUser.ID == SystemDefault.DefaultAdmin) {
                    dataGridViewRole.Enabled = false;
                }
            }
            else
            {
                skinLabel3.Visible = true;
                ResetAll();
            }
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
            //设置角色列表

            List<Role> keyValues = (List<Role>)this.dataGridViewRole.DataSource;
            String[] shopIds = this.curAdminUser.RoleIDs.Split(',');
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

        private void ResetAll()
        {
            this.skinTextBox_ID.Text = null;
            this.skinTextBox_Name.Text = null;
            this.skinCheckBox_State.Checked = true; skinTextBox_Remarks.Text = null;
        }

        private void dataGridViewRole_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex  == Column5.Index)
            {
                //不能编辑  
                if (NoAllowEdit >-1 && e.RowIndex == NoAllowEdit)
                {
                    e.Cancel = true;
                }
            }
        }
    }

}
