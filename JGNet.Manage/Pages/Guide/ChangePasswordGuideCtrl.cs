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

namespace JGNet.Manage.Pages
{
    public partial class ChangePasswordGuideCtrl : BaseModifyUserControl
    { 

        private Guide curAdminUser = null; 
        public ChangePasswordGuideCtrl(Guide guide)
        {
            InitializeComponent();
            this.curAdminUser = guide;
        }

        private void ChangePasswordAdminUserCtrl_Load(object sender, EventArgs e)
        {
            Display();
            this.skinTextBox_Name.SkinTxt.KeyDown += SkinTxt_KeyDown;
            this.skinTextBox_Password.SkinTxt.KeyDown += SkinTxt_KeyDown;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (curAdminUser != null)
                {

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
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    this.curAdminUser.Password = SecurityHelper.MD5String2(this.skinTextBox_Password.SkinTxt.Text.Trim());
                    InteractResult result = GlobalCache.ServerProxy.UpdateGuide(curAdminUser);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            GlobalMessageBox.Show("保存成功！");
                            this.TabPage_Close?.Invoke(CurrentTabPage, SourceCtrlType);
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

        public void Refresh(Guide e)
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
            // this.skinTextBox_ID.Text = null;
            this.skinLabelGuideID.Text = this.curAdminUser.ID;
            this.skinLabelGuideName.Text = this.curAdminUser.Name;
            this.skinTextBox_Name.Text = null;
            this.skinTextBox_Password.Text = null;
        }
         
        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Btn_Save_Click(null, null);
            }
        }
    }

}
