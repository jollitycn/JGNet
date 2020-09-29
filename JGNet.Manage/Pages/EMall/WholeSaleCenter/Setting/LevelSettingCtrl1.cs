using System; 

using System.Windows.Forms; 
using CJBasic.Security;
using JGNet.Common.Core;   
using JGNet.Core.Dev.InteractEntity;
using JGNet.Core.InteractEntity;
using JGNet.Common;

namespace JGNet.Manage
{
    public partial class LevelSettingCtrl1 : BaseModifyUserControl
    { 
         
        public LevelSettingCtrl1()
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.层级收益;
        }

        private void ChangePasswordAdminUserCtrl_Load(object sender, EventArgs e)
        {
            Display();
            this.skinTextBox_Percent.SkinTxt.KeyDown += SkinTxt_KeyDown; 
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (String.IsNullOrEmpty(this.skinTextBox_Percent.Text.Trim()))
                    {
                        this.skinTextBox_Percent.Focus();
                        this.skinTextBox_Percent.ResetText();
                        return;
                    }
                  
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    InteractResult result =  GlobalCache.ServerProxy.UpdateCommissionRatio(decimal.ToInt32( skinTextBox_Percent.Value));
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            GlobalMessageBox.Show("保存成功！"); 
                            break;
                     
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
         

        private void Display()
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            WebResponseObj<int> result=  GlobalCache.ServerProxy.GetCommissionRatio();
            int value = 0;
            if (result.Status == 0)
            {
                value = result.Data;
                this.skinTextBox_Percent.Text = value.ToString();
            }
            else
            {
                GlobalMessageBox.Show(result.Info);
            } 
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
