using JGNet.Common;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using JGNet.Manage.Pages;
using JGNet.Manage.Retail;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class SystemSettingForm : BaseForm
    { 

        public SystemSettingForm()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.系统设置;
            optionCtrl1.Init();
            skinTabControl1.SelectTab(0);
            //barCodeCtrl1.CheckChanged += barCodeCtrl1_CheckChanged;
        }
       // bool barCodeChanged = false;
      //  private void barCodeCtrl1_CheckChanged(bool changed)
       // {
      //      barCodeChanged = changed;
      //  }

        private void BaseButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                integralCtrl1.BaseButtonSave_Click(sender, e);
                InteractResult result=  optionCtrl1.BaseButtonSave_Click(sender, e);
                if (result.ExeResult == ExeResult.Error) {
                    GlobalMessageBox.Show(result.Msg);
                    return;
                }



                //if (barCodeChanged)
                //{
                  //  if (GlobalMessageBox.Show("修改模板后将清空已生成的商品条码", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                   // {
                        barCodeCtrl1.BaseButtonSave_Click(sender, e);
                //  }
                //    else {
                //        barCodeCtrl1.LoadConfig();
                //        barCodeChanged = false;
                //    }
                //}  
                if (changePasswordAdminUserCtrl1.Visible)
                {
                    changePasswordAdminUserCtrl1.BaseButtonSave_Click(sender, e);
                }
                else if(changePasswordGuidCtrl1!=null && changePasswordGuidCtrl1.Visible)
                {
                    changePasswordGuidCtrl1.Btn_Save_Click(sender, e);
                }
                
                //changePasswordGuidCtrl1.
                GlobalMessageBox.Show("保存成功！");
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
            finally
            {
                UnLockPage();
            }

        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barCodeCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void skinTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skinTabControl1.SelectedTab.Name == "skinTabPage4")
            {
                if (CommonGlobalCache.CurrentUser.Type == UserInfoType.Guide)
                {
                     Guide item = new Guide();
                     item.Name = CommonGlobalCache.GetUserName(CommonGlobalCache.CurrentUserID);
                     item.ID = CommonGlobalCache.CurrentUserID;

                     GuideCtrl guideCtrl = new GuideCtrl();
                     string tabName = "导购员密码";                   
                      changePasswordGuidCtrl1 = new ChangePasswordGuideOfSystemCtrl(item);  
                    this.changePasswordAdminUserCtrl1.Visible = false;

                    this.skinTabPage4.Controls.Add(changePasswordGuidCtrl1);
                    this.changePasswordGuidCtrl1.Visible = true;
                }
                else
                {
                    this.changePasswordAdminUserCtrl1.Visible = true;
                    if (changePasswordGuidCtrl1 != null) { 
                    this.changePasswordGuidCtrl1.Visible = false;
                    }
                }
            }
        }
    }
}
