using CCWin;
using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.ForManage;
using CJBasic;
using CJBasic.Loggers;
using CJBasic.Security;
using CJPlus.Application.Basic;
using CJPlus.Rapid;
using CJPlus.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;   

using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class LoginForm : BaseForm
    {
        public static String CONFIG_PATH = CommonGlobalUtil.AgileConfiguration("Manage.LoginAgileConfiguration");

        //public static String PERMINSSON_CONFIG_PATH = System.Environment.CurrentDirectory + "//Manage/pc";
        private IRapidPassiveEngine passiveEngine;

        PermissonConfiguration permissonConfig = null;
        public LoginForm(IRapidPassiveEngine rapidPassiveEngine)
        {
            InitializeComponent();
            passiveEngine = rapidPassiveEngine;
            skinLabelVersion.Text = GlobalUtil.GetSystemVersion(); 
        }

        //private void SaveConfigOnce()
        //{
        //    if (permissonConfig == null || permissonConfig.Version != GlobalUtil.GetSystemVersion())
        //    {
        //        permissonConfig = new PermissonConfiguration();
        //        permissonConfig.Version = GlobalUtil.GetSystemVersion();
        //        permissonConfig.Names = new List<string>();
        //        List<TreeNode> treeNodes = PermissonUtil.GetTreeNodes();
        //        foreach (var item in treeNodes)
        //        {
        //            permissonConfig.Names.Add(gl);
        //        }
        //    }
        //}

        LoginAgileConfiguration config = null;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                config = LoginAgileConfiguration.Load(CONFIG_PATH) as LoginAgileConfiguration;
                if (config != null)
                {
                    this.skinTextBoxBusinessAccount.Text = config.BusinessAccount?.ID;
                    if (config.LoginInfos?.Count > 0)
                    {
                        LoginInfo info = config.LoginInfos[0];
                        this.skinCheckBoxSavePwd.Checked = info.SavePassword;

                        if (info.SavePassword)
                        {
                            this.skinTextBoxPwd.Text = info.Password;
                        }
                        this.skinTextBoxUser.Text = info.LastLoginID;
                    }
                }
                else
                {
                    config = new LoginAgileConfiguration() { LoginInfos = new List<LoginInfo>() };
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void skinBtnOK_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void CheckLogin()
        {
            try
            {
                if (!CheckValidate()) { return; }
                if (CommonGlobalUtil.EngineUnconnectioned(this, true)) { return; }
                skinLabelLinkState.Text = "连接中……";
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoConnect);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show(ex.Message);

            } 



        }

        private Boolean CheckValidate()
        {
            String userId = this.skinTextBoxUser.Text.Trim();
            if (String.IsNullOrEmpty(userId))
            {
                GlobalMessageBox.Show("请输入账号!");
                this.skinTextBoxUser.Focus();
                return false;
            }

            String pwd = this.skinTextBoxPwd.Text.Trim();
            if (String.IsNullOrEmpty(pwd))
            {
                GlobalMessageBox.Show("请输入密码!");
                this.skinTextBoxPwd.Focus();
                return false;
            }
            //根据账套信息连接Server，连接失败则去web端获取账套信息。
            if (String.IsNullOrEmpty(this.skinTextBoxBusinessAccount.Text.Trim()))
            {
                GlobalMessageBox.Show("请输入对应账套！");
                this.skinTextBoxBusinessAccount.Focus();
                return false;
            }
            return true;
        }

        private void ShowConnectingMessage(string msg, Boolean isError = false, SkinTextBox skinText = null)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<string, Boolean, SkinTextBox>(this.ShowConnectingMessage), msg, isError, skinText);
            }
            else
            {
                skinLabelLinkState.Text = msg;
                skinLabelLinkState.ForeColor = isError ? Color.Red : Color.Black;
                if (skinText != null)
                {
                    skinText.Focus();
                }
            }
        }
        
        private void DoConnect()
        {
            try
            {
                if (this.skinTextBoxBusinessAccount.Text != config.BusinessAccount?.ID)
                {
                    //更改了账套重新获取
                    if (ConnectionSiteWeb())
                    {
                        ConnectToServer(false);
                    }
                }
                else
                {
                    if (ConnectionSiteWeb())
                    {
                        if (!ConnectToServer(true))
                        {
                            //如果连不上，就重新获取地址，这里可能账套信息更改
                            if (ConnectionSiteWeb())
                            {
                                ConnectToServer(false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

       

        private Boolean ConnectionSiteWeb()
        {
            try
            {
                this.ShowConnectingMessage("获取账套中……");
                String response = null;
                if (!GlobalUtil.GetBusinessAccountFromAPI(config, out response,this.skinTextBoxBusinessAccount.Text))
                {
                    this.ShowConnectingMessage(response, true, skinTextBoxBusinessAccount);
                    //skinTextBoxBusinessAccount.Focus();
                    return false;
                }
                else
                {
                    this.ShowConnectingMessage("账套获取成功！");

                    //保存商户网站信息

                    //if (DateTime.Now > config.BusinessAccount.ExpiredDate) {
                    //    this.ShowConnectingMessage("账号", true, skinTextBoxBusinessAccount);
                    //}

                    config.Save(CONFIG_PATH);

                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
                this.ShowConnectingMessage("连接不到站点,请联系客服！", true, null);
                return false;
            }
        }

        private Boolean  ConnectToServer(Boolean isFirstTime)
        {
            try
            {
                this.ShowConnectingMessage("验证登录中……");


                //如果连不上？重新获取服务器连接
                passiveEngine.SystemToken = SystemToken.Manage + "#" + this.skinTextBoxBusinessAccount.Text + "#" + skinLabelVersion.Text;
                //if (!GlobalUtil.IPAndPort(new IPEndPoint(IPAddress.Parse(config.BusinessAccount.ServerIP), config.BusinessAccount.ServerPort)))
                //{
                //    GlobalMessageBox.Show("连接不到服务地址，请联系客服！");
                //    return false;
                //}
              //  CommonGlobalUtil.WriteLog(this.skinTextBoxUser.Text + "," + skinTextBoxPwd.Text + "," + config.BusinessAccount.ServerIP + "," + config.BusinessAccount.ServerPort);
                String pwdMd5 = SecurityHelper.MD5String2(this.skinTextBoxPwd.Text);
                LogonResponse result = this.passiveEngine.Initialize(this.skinTextBoxUser.Text.ToLower(), pwdMd5, config.BusinessAccount.ServerIP, config.BusinessAccount.ServerPort, new CustomizeHandler());
                switch (result.LogonResult)
                {
                    case LogonResult.Succeed:
                        
                        LoginInfo info = new LoginInfo();
                        info.LastLoginID = this.skinTextBoxUser.Text.ToLower();
                        info.SavePassword = this.skinCheckBoxSavePwd.Checked;
                        if (info.SavePassword)
                        {
                            info.Password = this.skinTextBoxPwd.Text;
                        }
                        else
                        {
                            info.Password = null;
                        }
                

                        info.loginTime = DateTime.Now;
                        LoginInfo orgInfo = config.LoginInfos.Find(t => t.LastLoginID.ToLower() == info.LastLoginID.ToLower());
                        if (orgInfo != null)
                        {
                            config.LoginInfos.Remove(orgInfo);
                        }

                        config.LoginInfos.Insert(0, info);
                        config.Save(CONFIG_PATH);
                    
                        CommonGlobalCache.SetBusinessAccount(config.BusinessAccount);
                        this.UpdateDialogResult();
                        if (!String.IsNullOrEmpty(result.FailureCause))
                        { 
                            ShowDialogMessage(result.FailureCause);
                            CommonGlobalCache.SystemUpdateMessage = result.FailureCause;
                        } 
                        break;
                    case LogonResult.Failed:
                        this.ShowConnectingMessage(result.FailureCause,true);
                        break;
                    case LogonResult.HadLoggedOn:
                        this.ShowConnectingMessage("该帐号已经在其它地方登录！",true);
                        break;
                    case LogonResult.VersionMismatched:
                        this.ShowConnectingMessage("客户端与服务器的CJFramework版本不一致！",true);
                        break;
                    default:
                        break;
                }
            }
            catch (SocketException ex)
            {
                if (!isFirstTime)
                {
                    GlobalUtil.WriteLog(ex + "!isFirstTime1 ERROR Message=" + ex.Message + "Exception StackTrace=" + ex.StackTrace); 
                    this.ShowConnectingMessage("连接不到服务端，请联系客服！",true);
                }
                else { GlobalUtil.WriteLog(ex+ "1ERROR Message=" + ex.Message+ "Exception StackTrace=" + ex.StackTrace); return false; }
            }
            catch (Exception ex)
            {
                if (!isFirstTime)
                {
                    this.ShowConnectingMessage("系统异常" + ex.Message, true);
                    GlobalUtil.WriteLog(ex+ "!isFirstTime2 ERROR Message=" + ex.Message + "Exception StackTrace=" + ex.StackTrace);
                }
                else { GlobalUtil.WriteLog(ex + "2ERROR Message=" + ex.Message + "Exception StackTrace=" + ex.StackTrace); return false; }
            }
            return true;
        }

        private void UpdateDialogResult()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.UpdateDialogResult));
            }
            else
            {
                if (CommonGlobalUtil.CheckExpiredDate())
                {
                    //2个月内，提示到期
                    String msg = CommonGlobalUtil.GetExpiredRemainDaysStr();
                    GlobalMessageBox.Show(this, msg);
                    if (CommonGlobalUtil.GetExpiredRemainDays() > 0)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    } 
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        private void ShowDialogMessage(string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<string>(this.ShowDialogMessage), msg);
            }
            else
            {
                GlobalMessageBox.Show(this, msg);
            }
        }

        private void BaseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinTextBoxUser_TextChanged(object sender, EventArgs e)
        {
            this.skinTextBoxPwd.Text = string.Empty;
        }
         
    }
}
