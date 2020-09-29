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
using JGNet.Core.Const;
using JGNet.Common;
using JGNet.Core.InteractEntity;

namespace JGNet.Manage.Pages
{
    public partial class FirstChangePasswordAdminUserCtrl : BaseModifyUserControl
    {
        public Boolean DoClose { get; set; }

        private AdminUser curAdminUser = null; 
             public FirstChangePasswordAdminUserCtrl()
        {
            InitializeComponent();
          
                this.curAdminUser = GlobalCache.GetAdminUser(GlobalCache.CurrentUser.ID);
            
            Display();
         //   this.skinTextBox_ID.SkinTxt.KeyDown += SkinTxt_KeyDown;
          //  this.skinTextBox_Name.SkinTxt.KeyDown += SkinTxt_KeyDown;
           // this.skinTextBox_Password.SkinTxt.KeyDown += SkinTxt_KeyDown;

        }
        public FirstChangePasswordAdminUserCtrl(AdminUser adminUser)
        {
            InitializeComponent();
            if (adminUser != null)
            {
                this.curAdminUser = adminUser;
            }
            else
            {
                this.curAdminUser = GlobalCache.GetAdminUser(GlobalCache.CurrentUser.ID);
            }
            Display();
         //   this.skinTextBox_ID.SkinTxt.KeyDown += SkinTxt_KeyDown;
         //   this.skinTextBox_Name.SkinTxt.KeyDown += SkinTxt_KeyDown;
          //  this.skinTextBox_Password.SkinTxt.KeyDown += SkinTxt_KeyDown;

        }

        private void ChangePasswordAdminUserCtrl_Load(object sender, EventArgs e)
        {

        }

        public void BaseButtonSave_Click(object sender, EventArgs e)
        {
            //try
            //{

            if (curAdminUser != null)
            {
                //   468 管理员：在删除后加设置密码 20180525 原密码不需要了
                //if (curAdminUser.Password != SecurityHelper.MD5String2(this.skinTextBox_ID.SkinTxt.Text.Trim()))
                //{
                //    this.skinTextBox_ID.Focus();
                //    this.skinTextBox_ID.ResetText();
                //    GlobalMessageBox.Show("原密码错误！");
                //    this.skinTextBox_Name.ResetText();
                //    this.skinTextBox_Password.ResetText();
                //    return;
                //}
                if (String.IsNullOrEmpty(this.skinTextBox_Name.SkinTxt.Text.Trim()))
                {
                    this.skinTextBox_Name.Focus();
                    this.skinTextBox_Name.ResetText();
                    return;

                }
                else
                if (GlobalCache.CurrentUserID == SystemDefault.DefaultAdmin && this.skinTextBox_Name.SkinTxt.Text.Trim() == SystemDefault.DefaultAdminPassword)
                {
                    GlobalMessageBox.Show("密码不能是初始密码：" + SystemDefault.DefaultAdminPassword);
                    this.skinTextBox_Name.Focus();
                    this.skinTextBox_Name.ResetText();
                    return;

                }
                else if (String.IsNullOrEmpty(this.skinTextBox_Password.SkinTxt.Text.Trim()))
                {
                    this.skinTextBox_Password.Focus();
                    this.skinTextBox_Password.ResetText();

                    return;
                }
                else if (this.skinTextBox_Password.SkinTxt.Text.Trim() != this.skinTextBox_Name.SkinTxt.Text.Trim())
                {
                    GlobalMessageBox.Show("两次新密码输入不相同，请重新确认！");
                    this.skinTextBox_Name.Focus();
                    return;
                }
                //if (GlobalUtil.EngineUnconnectioned(this))
                //{
                //    return;
                //}
                this.curAdminUser.Password = SecurityHelper.MD5String2(this.skinTextBox_Password.SkinTxt.Text.Trim());
                InteractResult result = GlobalCache.AdminUser_OnUpdate(curAdminUser);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        GlobalMessageBox.Show("保存成功！");
                        //if (DoClose)
                        //{
                        this.TabPage_Close?.Invoke(this.CurrentTabPage, SourceCtrlType);
                        //  } 
                        break;
                }
            }
            //}

            //catch (Exception ex)
            //{
            //    GlobalUtil.ShowError(ex );
            //}

            //finally
            //{
            //    GlobalUtil.UnLockPage(this);
            //}

        }

        public void Refresh(AdminUser e)
        {
            curAdminUser = e;
            Display();

        }

        private void Display()
        {
            
                ResetAll();
           
        }

        private void ResetAll()
        {
            this.skinTextBox_ID.Text = null;
            this.skinTextBox_Name.Text = null;
            this.skinTextBox_Password.Text = null;  
        }
         
        //private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        this.BaseButtonSave_Click(null, null);
        //    }
        //}
    }

}
