using JGNet.Core.Const;
using JGNet.ForManage;
using JGNet;
using System;
using System.Collections.Generic;


using System.Windows.Forms;
using JGNet.Common;
using JGNet.Common.Entitys;
using OAUS.Core;
using JGNet.Core.RemotingEntity;
using System.Configuration;
using System.Net;

namespace JGNet.Manage
{

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
              //  GlobalUtil.Initialize(false);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                LoadingForm loadingForm = new Common.LoadingForm();
                loadingForm.TopMost = true;
                loadingForm.Show();
                String DEBUG = ConfigurationManager.AppSettings["DEBUG"];
                if (String.IsNullOrEmpty(DEBUG) || DEBUG.ToLower() != "true")
                {
                    LoginAgileConfiguration loginInfo = null;
                    try
                    {
                        loginInfo = LoginAgileConfiguration.Load(CommonGlobalUtil.AgileConfiguration("Manage.LoginAgileConfiguration")) as LoginAgileConfiguration;
                    }
                    catch (Exception ex)
                    {
                        GlobalUtil.ShowError(ex);
                        CommonGlobalUtil.logger.Log(ex, "Program.Main：", CJBasic.Loggers.ErrorLevel.Standard);
                        return;
                    }
                    if (loginInfo == null)
                    {
                        loginInfo = new LoginAgileConfiguration();
                        loginInfo.LoginInfos = new List<LoginInfo>();
                        loginInfo.BusinessAccount = new BusinessAccount();
                        loginInfo.AutoUpgradeInfo = new AutoUpgradeInfo();
                    }
                    //try
                    //{
                    //    AutoUpgradeInfo config = GlobalUtil.GetAutoUpgradeInfo(loginInfo, 1);
                    //    if (config != null)
                    //    {
                    //        if (VersionHelper.HasNewVersion(config.IP, config.Port))
                    //        {
                    //            string updateExePath = AppDomain.CurrentDomain.BaseDirectory + "AutoUpdater\\易联售自动升级系统.exe";
                    //            System.Diagnostics.Process myProcess = System.Diagnostics.Process.Start(updateExePath, config.IP + " " + config.Port);
                    //            return;
                    //        }
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    if (ex.Message.Contains("无法连接到远程服务器"))
                    //    {
                    //        GlobalMessageBox.Show("登录超时，请检查您的网络或者本机防火墙设置");
                    //    }
                    //    else if (ex.Message.Contains("操作已被用户取消"))
                    //    {

                    //        GlobalMessageBox.Show("操作已被用户取消");
                    //    }
                    //    else
                    //    {
                    //        GlobalMessageBox.Show("获取版本升级信息时出错：" + ex.Message + " @ " + ex.StackTrace);
                    //    }
                    //    CommonGlobalUtil.logger.Log(ex, "Program.Main", CJBasic.Loggers.ErrorLevel.Standard);
                    //    return;
                    //}
                }
                loadingForm.Close();
                CJPlus.GlobalUtil.SetMaxLengthOfMessage(1024 * 1024 * 10);
                RapidPassiveEngine rapidPassiveEngine = CJPlus.Rapid.RapidEngineFactory.CreatePassiveEngine();
                rapidPassiveEngine.WaitResponseTimeoutInSecs = 30;
                rapidPassiveEngine.SystemToken = SystemToken.Manage;

                LoginForm loginForm = new LoginForm(rapidPassiveEngine);
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                GlobalUtil.Engine = rapidPassiveEngine;
                MainForm mainForm = new MainForm(null);
                Application.Run(mainForm);
            }
            catch (Exception ee)
            {
                 GlobalUtil.ShowError(ee);
                
            }
        }
    }
}
