using CCWin;
using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Core;
using JGNet.Common.Pages.Guide.SignRecord;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.ForManage;
using JGNet.Manage.Pages;
using JGNet.Manage.Pages.BasicSettings.Costume;
using JGNet.Manage.Pages.RuleSettings;
using JGNet.Manage.Retail;
using CJBasic.Helpers;
using CJBasic.Loggers;
using CJBasic.Security;
using CJPlus;
using CJPlus.Application.Basic;
using CJPlus.Rapid;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using OAUS.Core;
using CJBasic;
using JGNet.Manage.Components;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core.MyEnum;
using System.Runtime.Serialization;
using JGNet.Manage;
using JGNet.Manage;

namespace JGNet.Manage
{
    public partial class MainForm : BaseForm
    {
        private void GlobalCache_IniFailed(Exception ex)
        {

            //  CommonGlobalUtil.ShowError(ex);

            //  this.DialogResult = DialogResult.Abort;
            CommonGlobalUtil.WriteLog(ex);
            GlobalCache.ReInitialize();
        }

        private void GlobalCache_IniCompleted()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.GlobalCache_IniCompleted));
            }
            else
            {
                this.toolStripProgressBar1.Visible = false;
                toolStripLabelLoad.Visible = false;
                this.skinLabel_TaskName.Visible = false;
                CompleteLoad();
            }
        }

        public void ShowOperator() {

            //   this.toolStripLabelVersion.Text = ConfigurationManager.AppSettings["Version"];
            this.toolStripLabelOperator.Text = "操作员：" + GlobalCache.GetUserName(GlobalCache.CurrentUser?.ID) + "(" + GlobalCache.CurrentUser?.ID + ")";
        }


        private void CompleteLoad()
        {
            ShowOperator();

            //   this.toolStripLabelVersion.Text = ConfigurationManager.AppSettings["Version"];
           //this.toolStripLabelOperator.Text = "操作员：" + GlobalCache.GetUserName(GlobalCache.CurrentUser?.ID) + "(" + GlobalCache.CurrentUser?.ID + ")";
            //设置账套名称
          
            SetAnoucement();

            //加载菜单信息并设置绑定事件
            // this.skinToolStrip1.Items.Clear();
            //   this.FormClosing += MainForm_FormClosing;

            CheckFirstLogin();
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            //如果是ADMIN,并且密码是123456则需要修改密码
            //AdminUser defaultAdmin = GlobalCache.GetAdminUser(CommonGlobalCache.CurrentUserID);

            //if (CommonGlobalCache.CurrentUserID == SystemDefault.DefaultAdmin && defaultAdmin.Password == SecurityHelper.MD5String2(SystemDefault.DefaultAdminPassword))
            //{
            //    GlobalMessageBox.Show("请输入新密码！");
            //    this.skinButton1.Enabled = false;
            //}
            //else if (String.IsNullOrEmpty(GlobalCache.GeneralStoreShopID))
            //{
            //    GlobalMessageBox.Show("请先创建总仓/店铺，才能进行后续操作！");
            //    this.skinButton1.Enabled = false;
            //}
        }

        public void CheckFirstLogin()
        {
            AdminUser currentAdmin = GlobalCache.GetAdminUser(CommonGlobalCache.CurrentUserID);
            //如果是ADMIN,并且密码是123456则需要修改密码
            if (currentAdmin!=null && CommonGlobalCache.CurrentUserID == SystemDefault.DefaultAdmin && currentAdmin.Password == SecurityHelper.MD5String2(SystemDefault.DefaultAdminPassword))
            {
                GlobalMessageBox.Show("请输入新密码！");
               this.skinButton1.Enabled = false;
                ChangePasswordAdminUser(currentAdmin, null, true);
                SetStripEnable(false);
            }
            else if (String.IsNullOrEmpty(GlobalCache.GeneralStoreShopID))
            {   //如果没有总仓
               GlobalMessageBox.Show("请先创建总仓 / 店铺，才能进行后续操作！");
                this.skinButton1.Enabled = false;
                ShopManageCtrl_Save(null, null);
                SetStripEnable(false);
            }
            else
            {
                this.BuildWorkDeskTabPage();
                //建立了工作台之后才有权限设置

                BuildMenuToStrip();
                this.skinButton1.Enabled = true;
            }

        }

        private void BuildMenuToStrip()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.BuildMenuToStrip));
            }
            else
            {
                SkinToolStrip1Enabled(false);
                skinToolStrip1.Items.Clear();
                skinToolStrip1.Items.AddRange(BuildMenu());
                SetupExpiredTips();
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoMenuPermisson);
                cb.BeginInvoke(null, null); 
            }
        }
        private void DoMenuPermisson()
        {
            UpdatePermisson();
            SetUpMenuEnable();
            SkinToolStrip1Enabled(true);
        }

        private void SkinToolStrip1Enabled(bool value)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<bool>(this.SkinToolStrip1Enabled), value);
            }
            else
            {
                skinToolStrip1.Enabled = value;
            }
        }

        private void GlobalCache_IniProgress(int total, string task)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<int, string>(this.GlobalCache_IniProgress), total, task);
            }
            else
            {
                this.toolStripProgressBar1.Maximum = total;
                this.toolStripProgressBar1.Value = 0;
                this.toolStripProgressBar1.Step = 1;
                this.skinLabel_TaskName.Text = task;
            }
        }
        private void GlobalCache_UpdateProgress(string task)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<string>(this.GlobalCache_UpdateProgress), task);
            }
            else
            {
                this.toolStripProgressBar1.PerformStep();
                this.skinLabel_TaskName.Text = task;
            }
        }
         
        WorkDeskCtrl workDeskCtrl;


        ToolStripMenuItem earlyStageCostumeStoreMenu;
        ToolStripMenuItem earlyStageAccountRecordMenu;

        public MainForm(RapidPassiveEngine engine)
        {
            InitializeComponent();
            try
            {
                GlobalUtil.MainForm = this;
                //this.eMall.Click += new System.EventHandler(toolStripButton_MarketOnline_Click);
                this.Text += "(" + GlobalUtil.GetSystemVersion() + ")";
                toolStripLabelProfile.Text = "账套：" + CommonGlobalCache.BusinessAccount?.Name;
                skinToolStripAnounce.Visible = false;
                this.rapidPassiveEngine = engine;
                //this.rapidPassiveEngine.ConnectionInterrupted += RapidPassiveEngine_ConnectionInterrupted;
                //this.rapidPassiveEngine.RelogonCompleted += RapidPassiveEngine_RelogonCompleted;
                //this.rapidPassiveEngine.BasicOutter.BeingPushedOut += BasicOutter_BeingPushedOut;
                LoadCache();
               

            }
            catch (Exception ex)
            {

                ShowError(ex);
            }
        }
        public void UpdatePermisson()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.UpdatePermisson));
            }
            else
            {
                try
                {
                    UserInfo user = CommonGlobalCache.CurrentUser;
                    List<int> permissions = user.RolePermissions;
                    List<ToolStripItem> items = MenuItems.GetAllMenus(this.skinToolStrip1.Items);

                    foreach (var item in items)
                    {
                        item.Enabled = PermissonUtil.HasMenuPermisson(user, item.Text);
                    }

                    //1.账套打开，对应设置没开，隐藏
                    SetBusinessAccountSetting();
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }
        private void SetAnoucement()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.SetAnoucement));
            }
            else
            {
                try
                {
                    if (String.IsNullOrEmpty(CommonGlobalCache.SystemUpdateMessage))
                    {
                        skinToolStripAnounce.Visible = false;
                        toolStripLabelAnounce.Text = string.Empty;
                    }
                    else
                    {
                        skinToolStripAnounce.Visible = true;
                        toolStripLabelAnounce.Text = "系统公告：" + CommonGlobalCache.SystemUpdateMessage;
                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }
        private void RetailOrder_Search(RetailListPagePara para, BaseUserControl type)
        {
            try {
                RetailOrderSearchCtrl ctrl = new RetailOrderSearchCtrl();
                ctrl.RedoClick += RetailOrderListCtrl_RedoClick;
                ctrl.RefundDetailClick += SourceOrderDetailClick;
                ctrl.RetailDetailClick += SourceOrderDetailClick;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("销售清单", ref modifyCtrl, type);
                if (modifyCtrl != null)
                {
                    ctrl?.Search(para);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private bool IsExistTabPage(string tabName, BaseUserControl ctrl, out TabPage tabPage)
        {
            //检查权限759 管端设置权限功能。
            if (!PermissonUtil.HasMenuPermisson(CommonGlobalCache.CurrentUser, ctrl.MenuPermission))
            {
                throw new NoPermissonException(tabName);
            }

            foreach (TabPage page in this.skinTabControl1.TabPages)
            {
                if (page.Text == tabName)
                {
                    tabPage = page;
                    return true;
                }
            }
            tabPage = new SkinTabPage(tabName);
            return false;
        }
        private void skinTabControl1_TabePageClosing(object sender, CCWin.SkinControl.TabPageEventArgs e)
        {
            try {
                if (e.ColseTabPage.Tag != null && (RolePermissionMenuEnum)e.ColseTabPage.Tag == RolePermissionMenuEnum.工作台)
                {
                    e.Cancel = true;
                }
                else if (e.ColseTabPage.Text == "添加店铺")
                {
                    //如果没有总仓
                    if (String.IsNullOrEmpty(GlobalCache.GeneralStoreShopID))
                    {
                        GlobalMessageBox.Show("请先创建总仓/店铺，才能进行后续操作！");
                        this.skinButton1.Enabled = false;
                        e.Cancel = true;
                    }
                }
                else if (e.ColseTabPage.Text == "盘点录入")
                {

                    if (e.ColseTabPage.Controls[0] is CheckStore2019Ctrl)
                    {
                        CheckStore2019Ctrl ctrl = e.ColseTabPage.Controls[0] as CheckStore2019Ctrl;

                        if (!ctrl.IsEmptyList())
                        {
                            //如果没有总仓
                            if (GlobalMessageBox.Show("是否将盘点挂单？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                ctrl.Hang();
                            }
                        }
                    }
                }
                else if (e.ColseTabPage.Text == "修改密码")
                {
                    //如果没有总仓
                    //如果是ADMIN,并且密码是123456则需要修改密码
                    if (CommonGlobalCache.CurrentUserID == SystemDefault.DefaultAdmin)
                    {
                        AdminUser defaultAdmin = GlobalCache.GetAdminUser(CommonGlobalCache.CurrentUserID);
                        if (defaultAdmin.Password == SecurityHelper.MD5String2(SystemDefault.DefaultAdminPassword))
                        {
                            GlobalMessageBox.Show("请先修改密码！");
                            this.skinButton1.Enabled = false;
                            e.Cancel = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void skinTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {

                if (e.TabPage != null && e.TabPage.Text == "工作台")
                {
                    workDeskCtrl.RefreshPage();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void skinTabControl1_ControlRemoved(object sender, ControlEventArgs e)
        {
            try {
                SkinTabControl tabCtrl = (SkinTabControl)sender;
                TabPage page = (TabPage)e.Control;
                if (page.Controls[0] is BaseModifyUserControl)
                {
                    BaseModifyUserControl currentCtrl = ((BaseModifyUserControl)page.Controls[0]);
                    if (!currentCtrl.HasInvokeTabClose)
                    {
                        TabPage_Close(currentCtrl.CurrentTabPage, currentCtrl.SourceCtrlType);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void AddUserControlToTabPage(String tabName, ref BaseUserControl ctrl)
        {
            bool IsExistTabPage = false;
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this, false, true, false))
                {
                    return;
                }
                //解决界面还没显示就闪的问题hide以下
                PermissonUtil.CheckPermissons(ctrl);
                ctrl.Hide();
                TabPage tabPage;
                IsExistTabPage = this.IsExistTabPage(tabName, ctrl, out tabPage);

                ctrl.SourceCtrlType = ctrl;
                ctrl.CurrentTabPage = tabPage;
                ctrl.Dock = DockStyle.Fill;
                ctrl.AutoScroll = true;
                if (!IsExistTabPage)
                {
                    tabPage.Controls.Add(ctrl);
                    this.skinTabControl1.TabPages.Add(tabPage);
                }
                else
                {
                    tabPage.Controls.Clear();
                    tabPage.Controls.Add(ctrl);
                }
                this.skinTabControl1.SelectedTab = tabPage;
                CommonGlobalUtil.Debug(tabPage.Text);
                ctrl.Show();
            }
            catch (Exception ee)
            {
                ctrl = null;
                ShowError(ee);
            }
            finally
            {
                UnLockPage();
            }
        }
        private void AddUserControlToTabPage(String tabName, RolePermissionMenuEnum tag, ref BaseUserControl ctrl)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this, false, true, false))
                {
                    return;
                }
                //解决界面还没显示就闪的问题hide以下
                PermissonUtil.CheckPermissons(ctrl);
                ctrl.Hide();
                TabPage tabPage;
                bool IsExistTabPage = this.IsExistTabPage(tabName, ctrl, out tabPage);
                if (!IsExistTabPage)
                {
                    ctrl.SourceCtrlType = ctrl;
                    ctrl.CurrentTabPage = tabPage;
                    ctrl.Dock = DockStyle.Fill;
                    ctrl.AutoScroll = true;
                    tabPage.Controls.Add(ctrl);
                    tabPage.Tag = tag;
                    this.skinTabControl1.TabPages.Add(tabPage);
                }
                this.skinTabControl1.SelectedTab = tabPage;
                ctrl.Show();
            }
            catch (Exception ex)
            {
                ctrl = null;
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }
        private void AddModifyUserControlToTabPageNoClose(String tabName, ref BaseModifyUserControl ctrl, BaseUserControl type)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this, false, true, false))
                {
                    return;
                }
                //解决界面还没显示就闪的问题hide以下
                ctrl.MenuPermission = type.MenuPermission;
                PermissonUtil.CheckPermissons(ctrl);
                ctrl.Hide();

                TabPage tabPage = new SkinTabPage(tabName);
                ctrl.Dock = DockStyle.Fill;
                ctrl.AutoScroll = true;
                tabPage.Controls.Add(ctrl);
                this.skinTabControl1.TabPages.Add(tabPage);
                ctrl.SourceCtrlType = type;
                ctrl.CurrentTabPage = tabPage;
                this.skinTabControl1.SelectedTab = tabPage;
                //   CommonGlobalUtil.Debug(tabPage.Text);
                ctrl.Show();
            }
            catch (Exception ex)
            {
                ctrl = null;
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }
         
        private void AddModifyUserControlToTabPage(String tabName, ref BaseModifyUserControl ctrl, BaseUserControl type)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this, false, true, false))
                {
                    return;
                }
                //解决界面还没显示就闪的问题hide以下
                if (ctrl.MenuPermission == RolePermissionMenuEnum.不限 && type != null && type.MenuPermission != RolePermissionMenuEnum.工作台)
                {
                    ctrl.MenuPermission = type.MenuPermission;
                }
                PermissonUtil.CheckPermissons(ctrl);
                ctrl.Hide();
                TabPage tabPage;
                bool IsExistTabPage = this.IsExistTabPage(tabName, ctrl, out tabPage);

                if (!(IsExistTabPage && ctrl.IsShowOnePage))
                {
                    tabPage = new SkinTabPage(tabName);
                    ctrl.Dock = DockStyle.Fill;
                    ctrl.AutoScroll = true;
                    tabPage.Controls.Add(ctrl);
                    this.skinTabControl1.TabPages.Add(tabPage);
                    SetDetailPageTabClose(ctrl, tabPage, type);
                }


                this.skinTabControl1.SelectedTab = tabPage;
                ctrl.Show();
            }
            catch (Exception ex)
            {
                ctrl = null;
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }
        private void AddModifyUserControlToTabPage(RolePermissionMenuEnum menuEnum, ref BaseModifyUserControl ctrl, BaseUserControl type)
        {
            String tabName = JGNet.Core.Tools.EnumHelper.GetDescription(menuEnum);
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this, false, true, false))
                {
                    return;
                }

                //解决界面还没显示就闪的问题hide以下
                if (ctrl.MenuPermission == RolePermissionMenuEnum.不限 && type != null && type.MenuPermission != RolePermissionMenuEnum.工作台)
                {
                    ctrl.MenuPermission = type.MenuPermission;
                }
                PermissonUtil.CheckPermissons(ctrl);
                ctrl.Hide();
                TabPage tabPage;
                bool IsExistTabPage = this.IsExistTabPage(tabName, ctrl, out tabPage);

                if (!(IsExistTabPage && ctrl.IsShowOnePage))
                {
                    tabPage = new SkinTabPage(tabName);
                    ctrl.Dock = DockStyle.Fill;
                    ctrl.AutoScroll = true;
                    tabPage.Controls.Add(ctrl);
                    this.skinTabControl1.TabPages.Add(tabPage);
                    SetDetailPageTabClose(ctrl, tabPage, type);
                }


                this.skinTabControl1.SelectedTab = tabPage;
                ctrl.Show();
            }
            catch (Exception ex)
            {
                ctrl = null;
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }
        internal void SendAnnounce(AnnounceState state)
        {
            try
            {
                switch (state)
                {
                    case AnnounceState.Finished:
                        CommonGlobalCache.SystemUpdateMessage = "更新完毕！";
                        SetAnoucement();
                        //定时5秒后消失 
                        // TimerEnabled();
                        break;
                    case AnnounceState.Cancel:
                        CommonGlobalCache.SystemUpdateMessage = "更新已取消！";
                        SetAnoucement();
                        //定时5秒后消失 
                        // TimerEnabled();
                        break;
                    case AnnounceState.Releasing:
                        SetAnoucement();
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        internal void DoClose(bool showMessage = true)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<bool>(this.DoClose), showMessage);
            }
            else
            {
                try {
                    if (showMessage)
                    {
                        GlobalMessageBox.Show(GlobalUtil.MainForm, "系统正在升级，请稍后登录！");
                    }
                    forceClose = true;
                    toClose = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                CommonGlobalCache.SystemUpdateMessage = string.Empty;
                SetAnoucement();
                TimerDisabled();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        private void TimerDisabled()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.TimerDisabled));
            }
            else
            {
                try
                {
                    timer1.Enabled = false;
                }
                catch (Exception ex)
                {
                    GlobalUtil.ShowError(ex);
                }
            }
        }
        private void TimerEnabled()
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.TimerEnabled));
            }
            else
            {
                try
                {
                    timer1.Enabled = true;
                }
                catch (Exception ex)
                {
                    GlobalUtil.ShowError(ex);
                }
            }

        }
        private void SetDetailPageTabClose(BaseModifyUserControl ctrl, TabPage tabPage, BaseUserControl type)
        {
            try {
                ctrl.SourceCtrlType = type;
                ctrl.CurrentTabPage = tabPage;
                ctrl.TabPage_Close += TabPage_Close;
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        private CJPlus.Rapid.IRapidPassiveEngine rapidPassiveEngine;
        private void BasicOutter_BeingPushedOut()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.BasicOutter_BeingPushedOut));
            }
            else
            {
                try
                {
                    this.toolStripLabel_netState.Text = "网络：断开（被挤掉线）";
                    //  CommonGlobalUtil.WriteLog(toolStripLabel_netState.Text);
                    this.toolStripLabel_netState.ForeColor = Color.Red;
                    notifyIcon1.Icon = global::JGNet.Manage.Properties.Resources.logoGray;
                    notifyIcon1.ShowBalloonTip(5000, "提示", this.toolStripLabel_netState.Text, ToolTipIcon.Warning);
                    GlobalMessageBox.Show("当前帐号已在其他地方登录！");
                    this.toClose = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCache()
        {
            CommonGlobalCache.IniProgress += GlobalCache_IniProgress;
            CommonGlobalCache.UpdateProgress += GlobalCache_UpdateProgress;
            CommonGlobalCache.IniCompleted += GlobalCache_IniCompleted;
            CommonGlobalCache.IniFailed += GlobalCache_IniFailed;
            //ForManage.ServerProxy serverProxy = new ForManage.ServerProxy(rapidPassiveEngine);
            //ForManage.EMallServerProxy eMallServerProxy = new ForManage.EMallServerProxy(rapidPassiveEngine);
            // GlobalCache.Initialize(rapidPassiveEngine?.CurrentUserID, serverProxy, eMallServerProxy);
            GlobalCache.DemoCurrentUser = new UserInfo();
        }

        private void SetBusinessAccountSetting()
        {
            try
            {
                //如果权限设置了，这边就不用去判断了。
                //if (eMall.Visible)
                //{

                // eMall.Enabled =true;
                // }

                //if (wholesaleMall.Visible)
                //{
                //    wholesaleMall.Visible = CommonGlobalCache.BusinessAccount.OnlinePfEnabled;
                //}
                //if (wholesale.Visible)
                //{
                //    wholesale.Visible = CommonGlobalCache.BusinessAccount.PfEnabled;
                //}
                //
                //【总仓 / 管理端 / admin】不显示店铺补货申请菜单
                //if (CommonGlobalCache.CurrentShopID == CommonGlobalCache.GeneralStoreShopID
                //    || CommonGlobalCache.CurrentUser.Type == UserInfoType.Admin
                //    || CommonGlobalCache.CurrentUserID == SystemDefault.DefaultAdmin)
                //{
                //    AskForAddShop.Visible = false;
                //}

                if (CommonGlobalCache.BusinessAccount != null)
                {
                    if (CommonGlobalCache.BusinessAccount.ERPEnabled)
                    {
                        if (!CommonGlobalCache.BusinessAccount.OnlineEnabled)
                        {
                            eMall.Enabled = false;
                        }
                        else {
                            if (!CommonGlobalCache.BusinessAccount.IsOpenDistribution)
                            {
                                wholeSaleCenter.Enabled = false;
                            }
                        }
                    }
                    else if (CommonGlobalCache.BusinessAccount.OnlineEnabled)
                    {
                        try
                        {
                          
                            ruleSetting.Enabled = false;
                            systemSetting.Enabled = false;
                            printSetting.Enabled = false;
                            // roleSetting.Enabled = false;
                            // adminUserItem.Enabled = false;
                            saleGuidItem.Enabled = false;
                            guideItem.Enabled = false;
                            earlyStageAccountRecordMenu.Enabled = false;
                            // wholesale.Visible = false;

                             
                            PfSendShop.Enabled = false;
                            PfReturnShop.Enabled = false;
                            PfSendAndRetunBill.Enabled = false;
                            //PfCustomerStore.Enabled = false;
                            AddCustomerSale.Enabled = false;
                            CustomerSaleBillSearch.Enabled = false;
                            wholesaleBeginning.Enabled = false;
                            purcharge.Visible = false;
                            report.Visible = false;
                            // finances.Enabled = false;
                            member.Visible = false;
                            resettlement.Visible = false;
                            // exit.Enabled = false;
                            Cashier.Enabled = false;
                            ReturnShop.Enabled = false;
                            SaleShopOrReturn.Enabled = false;
                            SaleTarget.Enabled = false;
                            PriceManage.Enabled = false;
                            AskForAddShop.Enabled = false;
                            SearchAddShop.Enabled = false;
                            DayBalance.Enabled = false;
                            DayBalanceSearch.Enabled = false;
                            InTimeSheet.Enabled = false;
                            StoreChangeSearch.Enabled = false;
                            ShopDistributeMenu.Enabled = false;
                            allocateAndTransfer.Enabled = false;
                            allocateAndTransferSearch.Enabled = false;
                            diffentBillSeache.Enabled = false;
                            CheckEnter.Enabled = false;
                            ChildrenCheckEnter.Enabled = false;
                            CheckEnterSerach.Enabled = false;
                            CheckCollect.Enabled = false;
                            IMEIManage.Enabled = false;
                            IMEISearch.Enabled = false;
                            frmLoss.Enabled = false;
                            frmLossBillSearch.Enabled = false;
                            // finances 
                            ShopCashManage.Enabled = false;
                            CostTypeItem.Enabled = false;
                            MakeCollectionsItem.Enabled = false;
                            SupplierEveryCollectItem.Enabled = false;
                            SupplierEveryCheckItem.Enabled = false;
                            CollectionPayManage.Enabled = false;
                            CustomerEveryCollection.Enabled = false;
                            CustomerEveryCheckItem.Enabled = false;
                            if (!CommonGlobalCache.BusinessAccount.IsOpenDistribution)
                            {
                                wholeSaleCenter.Enabled = false;
                            }
                        } 
                        catch (Exception e)
                        {
                            ShowError(e);
                            WriteLog("Message=" + e.Message + "StackTrace=" + e.StackTrace);
                        }
                        // PfCustomerManager.Enabled = false;

                    }
                    else if (!CommonGlobalCache.BusinessAccount.IsOpenDistribution)
                    {
                        wholeSaleCenter.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
                WriteLog("Message=" + ex.Message + "StackTrace=" + ex.StackTrace);
            }
        }

        public void SetupExpiredTips()
        {
            try {
                if (CommonGlobalUtil.CheckExpiredDate())
                {
                    toolStripLabelExpired.Visible = true;
                    toolStripLabelExpired.Text = CommonGlobalUtil.GetExpiredRemainDaysStr();
                }
                else
                {
                    toolStripLabelExpired.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        public void SetUpMenuEnable()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.SetUpMenuEnable));
            }
            else
            {
                try
                {
                    //ShowMessage(CommonGlobalCache.BusinessAccount.OnlineEnabled.ToString()+" COME IN");ERPEnabled =0，OnlineEnabled=1

                    if (CommonGlobalCache.GetParameter(ParameterConfigKey.IsHideCreateStore).ParaValue == "1")
                    {
                        earlyStageCostumeStoreMenu.Enabled = false;
                    }
                    if (CommonGlobalCache.GetParameter(ParameterConfigKey.IsHidePayment).ParaValue == "1")
                    {
                        earlyStageAccountRecordMenu.Enabled = false;
                    }
                    if (CommonGlobalCache.GetParameter(ParameterConfigKey.IsHideCreatePfStore).ParaValue == "1")
                    {
                        wholesaleBeginningStoreCtrlMenuItem.Enabled = false;
                    }
                    if (CommonGlobalCache.GetParameter(ParameterConfigKey.IsHidePfPayment).ParaValue == "1")
                    {
                        wholesaleBeginningBillCtrlMenuItem.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }
        private void SetStripEnable(bool result)
        {
            try {
                foreach (ToolStripItem item in this.skinToolStrip1.Items)
                {
                    if (item.Text != "退出")
                    {
                        item.Enabled = result;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        public void OnNewCheckStoreTask(String message)
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<string>(this.OnNewInfomation), message);
            }
            else
            {
                try
                {
                    InformationForm informationForm = new InformationForm(message);
                    // informationForm.LinkClicked += NewCheckStoreTask;
                    informationForm.Show();
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }
        public List<InformationForm> infoDiffentList1 = new List<InformationForm>();
        public List<InformationForm> infoReplenishList = new List<InformationForm>();
        public List<InformationForm> infoAllocateList = new List<InformationForm>();
        public List<InformationForm> infoCheckStoreList = new List<InformationForm>();
        public List<InformationForm> infoReplenishCostumeList = new List<InformationForm>();
        public List<InformationForm> infoNewEmRefundList = new List<InformationForm>();
        public List<InformationForm> infoNewEmRetailList = new List<InformationForm>();
        public List<InformationForm> infoCheckStorePassList = new List<InformationForm>();
        public List<InformationForm> infoCancelCheckStoreList = new List<InformationForm>();
        public List<InformationForm> infoOverrideOrderList = new List<InformationForm>();
        public List<InformationForm> infoCancelReplenishList = new List<InformationForm>();
        public List<InformationForm> infoCancelCheckStoreTaskList = new List<InformationForm>();
        
        public void CloseInfoMationFormList(List<InformationForm> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (InformationForm itemForm in list)
                {
                    itemForm.Close();
                }
            }

        }
        public void OnNewInfomation(String message)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<string>(this.OnNewInfomation), message);
            }
            else
            {
                try
                {
                    if (message.Split('#').Length == 2)
                    {
                        switch (Convert.ToInt32(message.Split('#')[1]))
                        {
                            case NoticeInformationTypes.InsertDifferenceOrder:
                                CloseInfoMationFormList(infoDiffentList1);
                                break;
                            case NoticeInformationTypes.ReplenishOutbound:
                                CloseInfoMationFormList(infoReplenishList);
                                break;
                            case NoticeInformationTypes.AllocateOutbound:
                                CloseInfoMationFormList(infoAllocateList);
                                break; 
                            case NoticeInformationTypes.ReplenishCostume:
                                CloseInfoMationFormList(infoReplenishCostumeList);
                                break;
                            case NoticeInformationTypes.InsertCheckStore:
                                CloseInfoMationFormList(infoCheckStoreList);
                                break;
                            case NoticeInformationTypes.NewEmRefundOrder:
                                CloseInfoMationFormList(infoNewEmRefundList);
                                break;
                            case NoticeInformationTypes.NewEmRetailOrder:
                                CloseInfoMationFormList(infoNewEmRetailList);
                                break;
                            case NoticeInformationTypes.CheckStorePass:

                                CloseInfoMationFormList(infoCheckStorePassList);
                                break;
                            case NoticeInformationTypes.CancelCheckStore: 
                                CloseInfoMationFormList(infoCancelCheckStoreList);
                                break;
                            case NoticeInformationTypes.OverrideOrder:
                                CloseInfoMationFormList(infoOverrideOrderList);
                                break;
                            case NoticeInformationTypes.CancelReplenish:
                                CloseInfoMationFormList(infoCancelReplenishList);
                                break;
                            case NoticeInformationTypes.CancelCheckStoreTask:
                                CloseInfoMationFormList(infoCancelCheckStoreTaskList);
                                break;

                                
                            default:
                                break;

                        } 

                        InformationForm informationForm = new InformationForm(message.Split('#')[0]);
                        informationForm.LinkClicked += WorkDeskCtrl_RefreshPage;
                        informationForm.Show();
                        switch (Convert.ToInt32(message.Split('#')[1]))
                        {
                            case NoticeInformationTypes.InsertDifferenceOrder:
                                infoDiffentList1.Add(informationForm);
                                break;
                            case NoticeInformationTypes.ReplenishOutbound: 
                            infoReplenishList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.AllocateOutbound:
                                infoAllocateList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.InsertCheckStore:
                                infoCheckStoreList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.ReplenishCostume:
                                infoReplenishCostumeList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.NewEmRefundOrder:
                                infoNewEmRefundList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.NewEmRetailOrder:
                                infoNewEmRetailList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.CheckStorePass:
                                infoCheckStorePassList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.CancelCheckStore:
                                infoCancelCheckStoreList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.OverrideOrder:
                                infoOverrideOrderList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.CancelReplenish:
                                infoCancelReplenishList.Add(informationForm);
                                break;
                            case NoticeInformationTypes.CancelCheckStoreTask:
                                infoCancelCheckStoreTaskList.Add(informationForm);
                                break;
                                
                            default:
                                break;

                        }
                          

                    }
                    else
                    {
                        InformationForm informationForm = new InformationForm(message.Split('#')[0]);
                        informationForm.LinkClicked += WorkDeskCtrl_RefreshPage;
                        informationForm.Show();
                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }
        private void WorkDeskCtrl_RefreshPage(bool showTab, EventArgs args)
        {
            try {
                workDeskCtrl.RefreshPage();
                if (showTab)
                {
                    //切换到工作台
                    this.skinTabControl1.SelectTab(0);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void RapidPassiveEngine_RelogonCompleted(CJPlus.Application.Basic.LogonResponse logonResponse)
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<LogonResponse>(this.RapidPassiveEngine_RelogonCompleted), logonResponse);
            }
            else
            {
                try
                {
                    if (logonResponse.LogonResult == LogonResult.Succeed)
                    {
                        this.toolStripLabel_netState.Text = "网络：正常";
                        CommonGlobalUtil.WriteLog(toolStripLabel_netState.Text);
                        this.toolStripLabel_netState.ForeColor = Color.Black;
                        notifyIcon1.Icon = global::JGNet.Manage.Properties.Resources.favicon;
                        //notifyIcon1.ShowBalloonTip(5000, "提示", this.toolStripLabel_netState.Text, ToolTipIcon.Info);
                    }
                    else
                    {
                        this.toolStripLabel_netState.Text = "网络：断开（重登录失败）";
                        CommonGlobalUtil.WriteLog(toolStripLabel_netState.Text);
                        this.toolStripLabel_netState.ForeColor = Color.Red;
                      //  notifyIcon1.Icon = global::JGNet.Manage.Properties.Resources.logoGray;
                        notifyIcon1.ShowBalloonTip(5000, "提示", this.toolStripLabel_netState.Text, ToolTipIcon.Warning);
                        if (GlobalMessageBox.Show("登录失败，请重启后登录！") == DialogResult.OK)
                        {
                            this.Close();
                            string updateExePath = AppDomain.CurrentDomain.BaseDirectory + "JGNet.Manage.exe";
                            System.Diagnostics.Process myProcess = System.Diagnostics.Process.Start(updateExePath);
                            return;
                        }
                        //if () {
                        //}
                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }
        private void RapidPassiveEngine_ConnectionInterrupted()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.RapidPassiveEngine_ConnectionInterrupted));
            }
            else
            {
                try
                {
                    if (this.toolStripLabel_netState.Text != "网络：断开，正在重连...")
                    {
                        this.toolStripLabel_netState.Text = "网络：断开，正在重连...";
                        CommonGlobalUtil.WriteLog(toolStripLabel_netState.Text);
                        this.toolStripLabel_netState.ForeColor = Color.Red;
                      //  notifyIcon1.Icon = global::JGNet.Manage.Properties.Resources.logoGray;
                        notifyIcon1.ShowBalloonTip(5000, "提示", this.toolStripLabel_netState.Text, ToolTipIcon.Warning);
                    }
                }
                catch (Exception ex) {

                    ShowError(ex);
                }
            }
        }
        private void GuideCtrl_AddGuide_Click(Guide e, BaseUserControl type)
        {
            try
            {
                string tabName = (e == null ? "添加导购员" : "编辑导购员");
                GuideEditCtrl ctrl = new GuideEditCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void GuideCtrl_ChangePwdClick(Guide e, BaseUserControl type)
        {
            try {
                string tabName = "导购员密码";
                ChangePasswordGuideCtrl ctrl = new ChangePasswordGuideCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void Costume_Save(Costume e, BaseUserControl type)
        {
            try {
                string tabName = (e == null ? "添加商品" : "编辑商品");
                SaveCostumeManageCtrl ctrl = new SaveCostumeManageCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void CarriageCostTemplateCtrl_AddClick(EmCarriageCostTemplate e, BaseUserControl type)
        {
            try { string tabName = (e == null ? "新增运费模板" : "编辑运费模板");
                SaveCarriageCostTemplateCtrl ctrl = new SaveCarriageCostTemplateCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void SupplierManageCtrl_Save(Supplier e, BaseUserControl type)
        {
            try {
                string tabName = (e == null ? "添加供应商" : "编辑供应商");
                SaveSupplierCtrl ctrl = new SaveSupplierCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void WholesaleCustomerManageCtrl_Save(PfCustomer e, BaseUserControl type)
        {
            try {
                string tabName = (e == null ? "批发-添加客户" : "批发-编辑客户");
                WholesaleCustomerSaveCtrl ctrl = new WholesaleCustomerSaveCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        } private void WholesaleCustomerManageCtrl_balanceDetail(PfCustomer e, BaseUserControl type)
        {
            try {
                string tabName = "余额明细";
                WholesaleCustomerBalanceDetailCtrl ctrl = new WholesaleCustomerBalanceDetailCtrl();
                ctrl.DetailClick += wholesaleCustomerBalanceDetailCtrl_DetailClick;
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                if (modifyCtrl != null)
                {
                    ctrl?.Search(e);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void wholesaleCustomerBalanceDetailCtrl_DetailClick(PfCustomerBalanceRecord record, BaseUserControl sourceCtrl, Panel panel)
        {
            BaseModifyCostumeIDUserControl ctrl = null;
            string tabName = string.Empty;
            try
            {
                GetControlFromOrder(record.SourceOrderID, out ctrl, out tabName,false,sourceCtrl);
                AddModifyUserControl(tabName, ref sourceCtrl, ctrl, panel);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void SalesPromotion_Save(SalesPromotion e, BaseUserControl type)
        {
            try {
                String label = "促销规则";
                string tabName = (e == null ? "添加" : "编辑") + label;
                SaveSalesPromotionCtrl ctrl = new SaveSalesPromotionCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        } private void GiftTicket_Save(GiftTicketTemplate e, BaseUserControl type)
        {
            try {
                String label = "优惠券";
                string tabName = (e == null ? "添加" : "编辑") + label;
                SaveGiftTicketTemplateCtrl ctrl = new SaveGiftTicketTemplateCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        } private void RechargeRecordClick(Member t1, BaseUserControl t2)
        {
            try {
                RechargeRecordCtrl ctrl = new RechargeRecordCtrl(t1);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage("充值记录查询", ref modifyCtrl, t2);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void ReplenishManageCtrl_ReplenishDetailClick(ReplenishOrder order, Panel panel, bool print)
        {
            try {
                string tabName = "补货申请单明细";
                ReplenishDetailCtrl ctrl = new ReplenishDetailCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
                if (print)
                {
                    ctrl.Print();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void ReplenishManageCtrl_ReplenishDetailExcpt(ReplenishOrder order, Panel panel, string path)
        {
            try
            {
                string tabName = "补货申请单明细";
                ReplenishDetailCtrl ctrl = new ReplenishDetailCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
                if (modifyCtrl!=null)
                {
                    ctrl.DoExport(path);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        
        private void ReplenishManageCtrl_OutboundClick(ReplenishOrder order, BaseUserControl type)
        {
            try {
                string tabName = "调拨";

                //ReplenishOutboundCtrl ctrl = new ReplenishOutboundCtrl(order);
                //ctrl.WorkDesk_Refresh += WorkDeskCtrl_RefreshPage;
                AllocateOrder allocateOrder = new AllocateOrder()
                {
                    ID = order.ID,
                    AllocateType = (byte)AllocateType.Distribution,
                    CreateTime = order.CreateTime,
                    DestShopID = order.ShopID,
                    SourceShopID = CommonGlobalCache.GeneralStoreShopID,
                    DestUserID = order.RequestGuideID,
                    SourceUserID = CommonGlobalCache.CurrentUserID,
                    Remarks = order.Remarks
                };
                AllocateOrderApplyCtrl ctrl = new AllocateOrderApplyCtrl(allocateOrder, OperationEnum.Send);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void AddModifyUserControl(string title, ref BaseModifyUserControl ctrl, Panel panel)
        { try
            {
                //检查权限759 管端设置权限功能。
                if (!PermissonUtil.HasMenuPermisson(CommonGlobalCache.CurrentUser, ctrl.MenuPermission))
                {
                    throw new NoPermissonException(title);
                }

                foreach (Control item in panel.Controls)
                {
                    item.Dispose();
                }

                BaseUserControl control = GetBaseUserControl(panel);
                ctrl.MenuPermission = control.MenuPermission;
                PermissonUtil.CheckPermissons(ctrl);
                panel.Controls.Clear();
                ctrl.Dock = DockStyle.Fill;
                panel.Controls.Add(ctrl);
            }
            catch (Exception ex)
            {
                ctrl = null;
                ShowError(ex);
            }
        }
        private BaseUserControl GetBaseUserControl(Panel panel)
        {
            Control ctrl = panel.Parent;
            while (!(ctrl is BaseUserControl))
            {
                if (ctrl != null)
                {
                    ctrl = ctrl.Parent;
                }
            }
            return ctrl as BaseUserControl;
        }
        private void AddModifyUserControl(string title, ref BaseUserControl sourceCtrl, BaseModifyUserControl ctrl, Panel panel)
        {
            try
            {
                //检查权限759 管端设置权限功能。
                if (!PermissonUtil.HasMenuPermisson(CommonGlobalCache.CurrentUser, ctrl.MenuPermission))
                {
                    throw new NoPermissonException(title);
                }

                foreach (Control item in panel.Controls)
                {
                    item.Dispose();
                }
                panel.Controls.Clear();
                BaseUserControl baseCtrl = GetBaseUserControl(panel);
                ctrl.MenuPermission = baseCtrl.MenuPermission;
                ctrl.Dock = DockStyle.Fill;
                ctrl.SourceCtrlType = sourceCtrl;
                ctrl.CurrentTabPage = sourceCtrl.CurrentTabPage;
                ctrl.RefreshPageAction += RefreshPage;
                panel.Controls.Add(ctrl);
                PermissonUtil.CheckPermissons(ctrl);
            }
            catch (Exception ex)
            {
                ctrl = null;
                ShowError(ex);
            }
        }
        private void AddModifyUserControl(string title, ref BaseModifyUserControl ctrl, Panel panel, BaseUserControl type)
        {
            try
            {
                //检查权限759 管端设置权限功能。
                if (!PermissonUtil.HasMenuPermisson(CommonGlobalCache.CurrentUser, ctrl.MenuPermission))
                {
                    throw new NoPermissonException(title);
                }

                foreach (Control item in panel.Controls)
                {
                    item.Dispose();
                }
                panel.Controls.Clear();
                ctrl.Dock = DockStyle.Fill;
                ctrl.SourceCtrlType = type;
                panel.Controls.Add(ctrl);
                PermissonUtil.CheckPermissons(ctrl);
            }
            catch (Exception ex)
            {
                ctrl = null;
                ShowError(ex);
            }
        }

        private void InboundClick(string orderID, BaseUserControl baseUserControl, Panel panel)
        {
            try {
                InboundConfirmCtrl ctrl = new InboundConfirmCtrl(orderID);
                ctrl.MenuPermission = baseUserControl.MenuPermission;
                ctrl.CurrentTabPage = baseUserControl.CurrentTabPage;
                ctrl.SourceCtrlType = baseUserControl;
                ctrl.RefreshPageAction += RefreshPage;
                //ctrl.WorkDesk_Refresh += WorkDeskCtrl_RefreshPage;
                String tabName = "收货入库";
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void ReAllocateClick(AllocateOrder order, BaseUserControl type)
        {
            try {
                String tabName = "调拨";
                AllocateOrderApplyCtrl ctrl = new AllocateOrderApplyCtrl(order, OperationEnum.Redo);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void PickClick(AllocateOrder order, BaseUserControl type)
        {
            try {
                String tabName = "调拨";
                AllocateOrderApplyCtrl ctrl = new AllocateOrderApplyCtrl(order, OperationEnum.Pick);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void ScrapOrderManageCtrl_RedoClick(ScrapOrder order, BaseUserControl type)
        {
            try {
                String tabName = "报损";
                ScrapOrderCtrl ctrl = new ScrapOrderCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        } private void InboundDetailClick(InboundOrder order, Panel panel)
        {
            try {
                string tabName = "入库单明细";
                InboundDetailCtrl ctrl = new InboundDetailCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void OutboundDetailClick(OutboundOrder order, Panel panel)
        {
            try
            {
                string tabName = "出库单明细";
                OutboundDetailCtrl ctrl = new OutboundDetailCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        public void BuildWorkDeskTabPage()
        {
            try
            {
                workDeskCtrl = new WorkDeskCtrl();
                workDeskCtrl.UnconfirmedReplenishOrderCountClick += WorkDeskCtrl_UnconfirmedReplenishOrderCountClick;
                workDeskCtrl.UnconfirmedAllocateOrderCountClick += WorkDeskCtrl_UnconfirmedAllocateOrderCountClick;
                workDeskCtrl.UnconfirmedDifferenceOrderCountClick += WorkDeskCtrl_UnconfirmedDifferenceOrderCountClick;

                workDeskCtrl.OnlineOrderClick += WorkDeskCtrl_OnlineOrderClick;
                workDeskCtrl.OnlineOrderRefundClick += WorkDeskCtrl_OnlineOrderRefundClick;
                workDeskCtrl.CheckOrderCountClick += CheckOrderCountClick;
                workDeskCtrl.TodayAddMemberCountClick += TodayAddMemberCountClick;
                workDeskCtrl.IsCostumeStoreHaveNegativeClick += IsCostumeStoreHaveNegativeClick;
                WorkDeskMenuItemCtrl menuItemCtrl = new WorkDeskMenuItemCtrl();
                menuItemCtrl.MenuItemClick += MenuItemClick;
                workDeskCtrl.MenuItemCtrl = menuItemCtrl;
                BaseUserControl modifyCtrl = workDeskCtrl;
                AddUserControlToTabPage("工作台", RolePermissionMenuEnum.工作台, ref modifyCtrl);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void MenuItemClick(JGNet.Common.Components.WorkDeskMenuItem item, EventArgs args)
        {
            try
            {
                string tabName = item.Title;

                BaseUserControl ctrl = null;

                switch (item.Title)
                {
                    case "盘点录入":
                        {
                            ctrl = new CheckStore2019Ctrl();
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "库存查询":
                        {
                            ctrl = new CostumeStoreSearchCtrl();
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "调拨":
                        {
                            ctrl = new AllocateOrderApplyCtrl(AllocateType.Allocate);
                            BaseUserControl modifyCtrl = ctrl; AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "采购进货":
                        {
                            PurchaseOrderCtrl purchaseOrderCtrl = new PurchaseOrderCtrl();
                            purchaseOrderCtrl.AddCostumeClick += Costume_Save;
                            ctrl = purchaseOrderCtrl;
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "采购退货":
                        {
                            ReturnOrderCtrl returnOrderCtrl = new ReturnOrderCtrl();
                            ctrl = returnOrderCtrl;
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "收银":
                        {
                            BaseUserControl modifyCtrl = GetUserControl(typeof(ShouYinCtrl));
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "退货":
                        {
                            BaseUserControl modifyCtrl = GetUserControl(typeof(RefundTabControlCtrl));
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "报损":
                        {
                            ctrl = new ScrapOrderCtrl();
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "盘点汇总":
                        {
                            ctrl = new CheckStoreOrderSummaryCtrl();
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "串码调整":
                        {
                            ctrl = GetUserControl(typeof(NewConfusedStoreAdjustRecordCtrl), 0);
                            BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                            AddModifyUserControlToTabPage(tabName, ref modifyCtrl, workDeskCtrl);
                            break;
                        }
                    case "营业报表":
                        {
                            ctrl = GetUserControl(typeof(BenefitReportManageCtrl), 0);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "导购业绩":
                        {
                            ctrl = GetUserControl(typeof(GuideAchievementSummaryManageCtrl), 0);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "供应商往来账":
                        {
                            tabName = "供应商往来账汇总";
                            ctrl = GetUserControl(typeof(SupplierAccountSummaryCtrl), 0);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "畅滞排行榜":
                        {
                            ctrl = GetUserControl(typeof(SalesQuantityRankingSearchCtrl), 0);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "销售分析":
                        {
                            ctrl = GetUserControl(typeof(CostumeRetailAnalysisCtrl), 0);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "库存分析":
                        {
                            ctrl = GetUserControl(typeof(CostumeStoreAnalysisCtrl), 0);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "销售/退货单查询":
                        {
                            ctrl = GetUserControl(typeof(RetailOrderSearchCtrl), 0);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    case "调拨单查询":
                        {
                            ctrl = GetUserControl(typeof(AllocateManageCtrl), 0);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }

                    case "添加商品":
                        {
                            ctrl = new SaveCostumeManageCtrl(null);
                            BaseUserControl modifyCtrl = ctrl;
                            AddUserControlToTabPage(tabName, ref modifyCtrl);
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception ex) {
                ShowError(ex);
            }
        } private void CheckStoreOrderSearchCtrl_Search(string orderId, BaseUserControl type)
        {
            try {
                CheckStoreOrderSearchCtrl ctrl = GetUserControl(typeof(CheckStoreOrderSearchCtrl)) as CheckStoreOrderSearchCtrl;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("盘点单查询", ref modifyCtrl, type);
                if (modifyCtrl != null)
                {
                    ctrl?.Search(orderId);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void CheckOrderCountClick(Object sender, EventArgs args)
        {
            try {
                CheckStoreOrderSearchCtrl ctrl = GetUserControl(typeof(CheckStoreOrderSearchCtrl), 0) as CheckStoreOrderSearchCtrl;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("盘点单查询", ref modifyCtrl, workDeskCtrl);
                if (modifyCtrl != null)
                {
                    if (workDeskCtrl.isWorkDesk)
                    {
                        ctrl?.WorkDeskCtrlSearch(CheckStoreOrderState.PendingReview);
                    }
                    else
                    {
                        ctrl?.WorkDeskCtrlSearch(CheckStoreOrderState.PendingReview);
                    }
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void TodayAddMemberCountClick(Object sender, EventArgs args)
        {
            try {
                MemberManageCtrl ctrl = GetUserControl(typeof(MemberManageCtrl), 0) as MemberManageCtrl;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(RolePermissionMenuEnum.会员管理, ref modifyCtrl, workDeskCtrl);
                if (modifyCtrl != null)
                {
                    ctrl?.WorkDeskCtrlSearch(TimeRange.Today);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void IsCostumeStoreHaveNegativeClick(Object sender, EventArgs args)
        {
            try {
                CostumeStoreSearchCtrl ctrl = new CostumeStoreSearchCtrl();
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("库存查询", ref modifyCtrl, workDeskCtrl);
                if (modifyCtrl != null)
                {
                    ctrl?.WorkDeskCtrlSearch();
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WorkDeskCtrl_UnconfirmedDifferenceOrderCountClick(Object sender, EventArgs args)
        {
            try {
                DifferenceOrderSearchCtrl ctrl = new DifferenceOrderSearchCtrl();
                ctrl.DifferenceOrderDetailClick += SourceOrderDetailClick;
                ctrl.InboundOrderDetailClick += SourceOrderDetailClick;
                ctrl.OutboundOrderDetailClick += SourceOrderDetailClick;
                ctrl.SourceOrderDetailClick += SourceOrderDetailClick;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("差异单查询", ref modifyCtrl, workDeskCtrl);
                if (modifyCtrl != null)
                {
                    if (workDeskCtrl.isWorkDesk)
                    { 
                             ctrl?.WorkDifferenceOrderStateSearch(DifferenceOrderConfirmed.False);
                    }
                    else
                    {
                        ctrl?.DifferenceOrderStateSearch(DifferenceOrderConfirmed.False);
                    }
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WorkDeskCtrl_UnconfirmedAllocateOrderCountClick(Object sender, EventArgs args)
        {
            try {
                //511 管理端和POS端：去掉调拨入库，工作台跳转页面改动。待处理调拨单-总仓调拨单查询改为调拨单查询 20181222 Jason Hong
                //   CurrentShopAllocateManageCtrl ctrl = new CurrentShopAllocateManageCtrl(AllocateOrderState.Delivery); 
                AllocateManageCtrl ctrl = new AllocateManageCtrl();
                ctrl.InboundDetailClick += SourceOrderDetailClick;
                ctrl.OutboundDetailClick += SourceOrderDetailClick;
                ctrl.InboundClick += InboundClick;
                ctrl.ReAllocateClick += ReAllocateClick;
                ctrl.PickClick += PickClick;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("调拨单查询", ref modifyCtrl, workDeskCtrl);
                if (modifyCtrl != null)
                {
                    if (workDeskCtrl.isWorkDesk)
                    {
                        ctrl?.WorkSearch(AllocateOrderState.Normal);
                    }
                    else
                    {
                        ctrl?.AllocateOrderStateSearch(AllocateOrderState.Delivery);
                    }
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        } private void WorkDeskCtrl_OnlineOrderRefundClick(object t1, EventArgs t2)
        {
            try {
                String tabName = "订单管理";
                EmOrderManageCtrl ctrl = GetUserControl(typeof(EmOrderManageCtrl), 1) as EmOrderManageCtrl;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, workDeskCtrl);
                if (modifyCtrl != null)
                {
                    if (workDeskCtrl.isWorkDesk)
                    {

                        ctrl?.WorkDeskFilteCtrlSearch(EmRetailOrderState.All, RefundStatus.Refunding);
                    }
                    else
                    {
                        ctrl?.WorkDeskCtrlSearch(EmRetailOrderState.All, RefundStatus.Refunding);
                    }
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WorkDeskCtrl_OnlineOrderClick(object t1, EventArgs t2)
        {
            try {
                String tabName = "订单管理";
                EmOrderManageCtrl ctrl = GetUserControl(typeof(EmOrderManageCtrl), 1) as EmOrderManageCtrl;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, workDeskCtrl);
                if (modifyCtrl != null)
                {
                    ctrl?.WorkDeskCtrlSearch(EmRetailOrderState.WaitDelivery, RefundStatus.NotSelect);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WorkDeskCtrl_UnconfirmedReplenishOrderCountClick(ReplenishOrderState state, EventArgs args)
        {
            try {
                String tabName = "补货申请单查询";
                ReplenishManageCtrl ctrl = new ReplenishManageCtrl(state);
                ctrl.ReplenishDetailClick += ReplenishManageCtrl_ReplenishDetailClick;
                ctrl.OutboundClick += ReplenishManageCtrl_OutboundClick;
                ctrl.ReReplenishClick += ReReplenishClick;
                ctrl.InboundClick += ReplenishManageCtrl_InboundClick;
                ctrl.PickClick += ReplenishManageCtrl_PickClick;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, workDeskCtrl);
                if (modifyCtrl != null)
                {
                    ctrl?.WorkTableInfo_Search();
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void ReReplenishClick(ReplenishOrder order, BaseUserControl type)
        {
            try {
                String tabName = "发货";
                //重做补货申请单发货
                order.IsRedo = true;
                ReplenishOutboundCtrl ctrl = new ReplenishOutboundCtrl(order);
                ctrl.WorkDesk_Refresh += WorkDeskCtrl_RefreshPage;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void ShopManageCtrl_Save(Shop e, BaseUserControl type)
        {
            try {
                string tabName = (e == null ? "添加店铺" : "编辑店铺");
                SaveShopCtrl ctrl = new SaveShopCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void AdminUserManageCtrl_Save(AdminUser e, BaseUserControl type)
        {
            try {
                string tabName = (e == null ? "添加管理员" : "编辑管理员");
                SaveAdminUserCtrl ctrl = new SaveAdminUserCtrl(e);
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void ChangePasswordAdminUser(AdminUser e, BaseUserControl type, Boolean doClose = false)
        {
            try {
                string tabName = "修改密码";

                FirstChangePasswordAdminUserCtrl ctrl = new FirstChangePasswordAdminUserCtrl(e);
                ctrl.DoClose = doClose;
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void MemberManageCtrl_UpdateMemberClick(Member member, BaseUserControl type)
        {
            try
            {
                NewMemberCtrl ctrl = new NewMemberCtrl(member);
                ctrl.MenuPermission = type.MenuPermission;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(member == null ? "会员开卡" : "修改会员资料", ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void ReturnOrder_DetailClick(PurchaseOrder order, Panel panel, bool print)
        {
            try {
                string tabName = "采购单明细";
                ReturnOrderDetailCtrl ctrl = new ReturnOrderDetailCtrl(order); BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
                if (print)
                {
                    if (modifyCtrl != null)
                    {
                        ctrl?.Print();
                    }
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void ReturnOrder_DetailExcept(PurchaseOrder order, Panel panel, string path)
        {
            try
            {
                string tabName = "采购单明细";
                ReturnOrderDetailCtrl ctrl = new ReturnOrderDetailCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl; 
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
                
                    if (modifyCtrl != null)
                    {
                        ctrl?.DoExport(path);
                    }
                
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        
        private void CheckStoreOrderSearch_CheckStoreDetailClick(CheckStoreOrder order, BaseUserControl control, Panel panel)
        {
            try
            {
                string tabName = "盘点单明细";
                CheckStoreDetailCtrl ctrl = new CheckStoreDetailCtrl(order, false);
                ctrl.SourceCtrlType = control;
                ctrl.CurrentTabPage = control.CurrentTabPage;
                ctrl.RefreshPageAction += RefreshPage;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void RechargeRecord_List(RechargeRecordListPara para, BaseUserControl type)
        {
            try
            {
                string tabName = "充值记录";
                RechargeRecordListCtrl ctrl = new RechargeRecordListCtrl(para);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPageNoClose(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void RetailOrder_List(RetailListPagePara para, BaseUserControl type, bool flag = false)
        {
            try
            {
                string tabName = "销售清单";
                RetailOrderListCtrl ctrl = GetRetailOrderListCtrl(para, true, flag);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPageNoClose(tabName, ref modifyCtrl, type);
                // ctrl.Search();
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void RetailOrder_List(RetailListPagePara para, BaseUserControl type)
        {
            try {
                string tabName = "销售清单";
                RetailOrderListCtrl ctrl = GetRetailOrderListCtrl(para, true);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPageNoClose(tabName, ref modifyCtrl, type);
                // ctrl.Search();
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void RetailOrderListCtrl_RedoClick(RetailOrder order, BaseUserControl type)
        {
            try
            {
                if (order.IsRefundOrder)
                {
                    if (String.IsNullOrEmpty(order.OriginOrderID))
                    {
                        BaseModifyUserControl ctrl = new RefundDirectCtrl(order);
                        AddModifyUserControlToTabPage("退货", ref ctrl, type);
                    }
                    else
                    {
                        BaseModifyUserControl ctrl = new RefundCtrl(order);
                        AddModifyUserControlToTabPage("退货", ref ctrl, type);
                    }
                }
                else
                {
                    BaseModifyUserControl ctrl = new ShouYinCtrl(order);
                    AddModifyUserControlToTabPage("收银", ref ctrl, type);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        } 
        private RetailOrderListCtrl GetRetailOrderListCtrl(RetailListPagePara para, bool value, bool flag=false)
        {
            RetailOrderListCtrl ctrl = null; 
            try
            {
                ctrl = new RetailOrderListCtrl(para, value, flag);
                ctrl.RedoClick += RetailOrderListCtrl_RedoClick;
                ctrl.RefundDetailClick += SourceOrderDetailClick;
                ctrl.RetailDetailClick += SourceOrderDetailClick;
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
            return ctrl;
        }
        private void DayBenefitReport_DetailList(GetBenefitReportsPara para, Panel panel, BaseUserControl type)
        {
            try {
                string tabName = "营业明细列表";
                BenefitReportDetailListCtrl ctrl = new BenefitReportDetailListCtrl();
                //    ctrl.DetailClick += RetailOrder_Search;
                ctrl.SaleDetailClick += DayBenefitReport_SaleDetailList;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel, type);
                if (modifyCtrl != null)
                {
                    ctrl?.SearchDetailList(para);
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void RefundOrder_List(RefundListPagePara para, BaseUserControl type)
        {
            try {
                string tabName = "退货清单";
                RefundOrderListCtrl ctrl = new RefundOrderListCtrl();
                ctrl.DetailClick += RefundOrder_Detail;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                if (modifyCtrl != null)
                {
                    ctrl?.Search(para);
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void ScrapOrderManageCtrl_DetailClick(ScrapOrder order, Panel panel, bool print)
        {
            try {
                string tabName = "报损单明细";
                ScrapOrderDetailCtrl ctrl = new ScrapOrderDetailCtrl(order);
                ctrl.OutboundDetailClick += SourceOrderDetailClick; BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
                if (print)
                {
                    if (modifyCtrl != null)
                    {
                        ctrl?.Print();
                    }
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void CostumeRetailAnalysisSearchCtrl_RowSelected(CostumeRetailAnalysis rowItem, CostumeRetailAnalysisPagePara para, Panel panel)
        {
            try {
                string tabName = "销售分析明细";
                CostumeRetailAnalysisPagePara searchPara = new CostumeRetailAnalysisPagePara();
                ReflectionHelper.CopyProperty(para, searchPara);
                searchPara.CostumeID = rowItem.CostumeID;
                searchPara.ColorName = rowItem.ColorName;
                searchPara.ShopID = null;
                searchPara.PageSize = int.MaxValue;
                searchPara.PageIndex = 0;
                CostumeRetailAnalysisDetailCtrl ctrl = new CostumeRetailAnalysisDetailCtrl(searchPara);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void SalesQuantityRankingSearchCtrl_RowSelected(SalesQuantityRanking ranking, SalesQuantityRankingPagePara para, Panel panel)
        {
            try
            {
                string tabName = "畅滞明细";
                SalesQuantityRankingShopDetailCtrl ctrl = new SalesQuantityRankingShopDetailCtrl();
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
                SalesQuantityRankingsPara searchPara = new SalesQuantityRankingsPara();
                ReflectionHelper.CopyProperty(para, searchPara);
                searchPara.CostumeID = ranking.CostumeID;
                searchPara.ColorName = ranking.ColorName;
                searchPara.SizeName = ranking.DBSizeName;
                ctrl?.SearchDetailList(searchPara);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void PriceRangeReportManageCtrl_RowSelected(GetShopPriceRangeReportPara para, Panel panel)
        {
            try
            {
                string tabName = string.Empty;
                PriceRangeReportDetailCtrl ctrl = new PriceRangeReportDetailCtrl();
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
                if (modifyCtrl != null)
                {
                    ctrl?.SearchDetailList(para);
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void RefundOrder_Detail(RetailOrder order, BaseUserControl type)
        {
            try
            {
                string tabName = "退货单明细";
                RefundOrderDetailCtrl ctrl = new RefundOrderDetailCtrl(order);
                ctrl.RetailOrderDetail += SourceOrderDetailClick;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void DifferenceOrder_ConfirmClick(DifferenceOrder obj, BaseUserControl sourceCtrl, Panel panel)
        {
            try
            {
                string tabName = "差异单确认";
                DifferenceOrderConfirmCtrl ctrl = new DifferenceOrderConfirmCtrl(obj);
                ctrl.WorkDesk_Refresh += WorkDeskCtrl_RefreshPage;
                ctrl.SourceCtrlType = sourceCtrl;
                ctrl.CurrentTabPage = sourceCtrl.CurrentTabPage;
                ctrl.RefreshPageAction += RefreshPage;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void SourceOrderDetailClick(DifferenceOrder item, BaseUserControl sourceCtrl, Panel panel)
        {
            BaseModifyCostumeIDUserControl ctrl = null;
            string tabName = string.Empty;
            try
            {
                GetControlFromOrder(item.ID, out ctrl, out tabName);
                AddModifyUserControl(tabName, ref sourceCtrl, ctrl, panel);
                if (item.Print)
                {
                    ((DifferenceOrderConfirmCtrl)ctrl).Print();
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void SourceOrderDetailClick(AllocateOrder order, BaseUserControl sourceCtrl, Panel panel)
        {
            BaseModifyCostumeIDUserControl ctrl = null;
            string tabName = string.Empty;
            try
            {
                GetControlFromOrder(order, out ctrl, out tabName);
                AddModifyUserControl(tabName, ref sourceCtrl, ctrl, panel);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void SourceOrderDetailClick(string orderID, BaseUserControl sourceCtrl, Panel panel)
        {
            BaseModifyCostumeIDUserControl ctrl = null;
            string tabName = string.Empty;
            try
            {
                GetControlFromOrder(orderID, out ctrl, out tabName);
                ctrl.MenuPermission = sourceCtrl.MenuPermission;
                AddModifyUserControl(tabName, ref sourceCtrl, ctrl, panel);

            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void SourceOrderDetailClick(string orderID, BaseUserControl type)
        {
            BaseModifyCostumeIDUserControl ctrl = null;
            string tabName = string.Empty;
            try
            {
                GetControlFromOrder(orderID, out ctrl, out tabName, true);
                ctrl.MenuPermission = type.MenuPermission;
                BaseModifyUserControl modifyCtrl = ctrl; AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private String getOrderPreFix(String orderId)
        {
            String prefix = string.Empty;
            try
            {
                String first = orderId[0].ToString();
                String second = orderId.Substring(0, 2);
                List<object> objects = ReflectUtil.GetFields(typeof(OrderPrefix));
                foreach (var item in objects)
                {
                    if (item.Equals(first))
                    {
                        prefix = item.ToString();
                    }
                    if (item.Equals(second))
                    {
                        //完全匹配
                        prefix = item.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            return prefix;
        }
        public void GetControlFromOrder(AllocateOrder order, out BaseModifyCostumeIDUserControl ctrl, out string tabName, bool isNewTabPage = false, BaseUserControl sourceCtrl = null)
        {
            ctrl = null;
            tabName = string.Empty;
            try
            {
                if (String.IsNullOrEmpty(order.ID))
                {
                    return;
                }
                String orderPrefix = getOrderPreFix(order.ID);
                switch (orderPrefix)
                {
                    case OrderPrefix.AllocateOrder:
                        tabName = "调拨单明细";
                        ctrl = new AllocateOrderDetailCtrl(GlobalCache.ServerProxy.GetAllocateOrder(order.ID));
                        break;
                    case OrderPrefix.CheckStoreOrder:
                        tabName = "盘点单明细";
                        CheckStoreOrderPage page = GlobalCache.ServerProxy.GetCheckStoreOrderPage(new CheckStoreOrderPagePara()
                        {
                            CheckStoreOrderID = order.ID,
                            IsOpenDate = false,
                            StartDate = null,
                            EndDate = null,
                            PageIndex = 0,
                            PageSize = int.MaxValue,
                            ShopID = null
                        });
                        ctrl = new CheckStoreDetailCtrl(page.CheckStoreOrderList[0], false);
                        break;
                    case OrderPrefix.DifferenceOrder:
                        tabName = "差异单明细";
                        DifferenceOrderPage pageDifferenceOrder = GlobalCache.ServerProxy.GetDifferenceOrderPage(new DifferenceOrderPagePara()
                        {
                            OrderID = order.ID,
                            IsOpenDate = false,
                            StartDate = null,
                            EndDate = null,
                            PageIndex = 0,
                            CostumeID = null,
                            PageSize = int.MaxValue,
                            ShopID = null
                        });
                        ctrl = new DifferenceOrderConfirmCtrl(pageDifferenceOrder.DifferenceOrderList[0]);

                        break;
                    case OrderPrefix.InboundOrder:
                        tabName = "入库单明细";
                        ctrl = new InboundDetailCtrl(GlobalCache.ServerProxy.GetInboundOrder(order.ID), order);
                        break;
                    case OrderPrefix.OutboundOrder:
                        tabName = "出库单明细";
                        ctrl = new OutboundDetailCtrl(GlobalCache.ServerProxy.GetOutboundOrder(order.ID));
                        break;
                    case OrderPrefix.PurchaseOrder:
                    case OrderPrefix.ReturnOrder:
                        if (isNewTabPage)
                        {
                            tabName = "采购进货/退货单查询";
                            ctrl = new ReturnOrderManageCtrl(order.ID);
                            ReturnOrderManageCtrl returnOrderManageCtrl = ctrl as ReturnOrderManageCtrl;
                            returnOrderManageCtrl.DetailClick += ReturnOrder_DetailClick;
                            returnOrderManageCtrl.DetailExcept += ReturnOrder_DetailExcept;
                            returnOrderManageCtrl.RedoClick += ReturnOrder_ReDoClick;
                            returnOrderManageCtrl.PickClick += ReturnOrder_PickClick;
                        }
                        else
                        {
                            tabName = "采购单明细";
                            PurchaseOrder pageReturnOrder = GlobalCache.ServerProxy.GetOnePurchaseOrder(order.ID);
                            ctrl = new ReturnOrderDetailCtrl(pageReturnOrder);
                        }
                        break;
                    case OrderPrefix.RechargeRecordOrder:
                        //没有接口，也不需要实现
                        break;

                    case OrderPrefix.RefundOrder:

                        tabName = "退货单明细";
                        RefundListPage pageRetund = GlobalCache.ServerProxy.GetRefundListPage(new RefundListPagePara()
                        {
                            RefundOrderID = order.ID,
                            StartDate = null,
                            EndDate = null,
                            PageIndex = 0,
                            CostumeID = null,
                            PageSize = int.MaxValue,
                            ShopID = null
                        });
                        ctrl = new RefundOrderDetailCtrl(pageRetund.ResultList[0]);

                        break;
                    case OrderPrefix.ReplenishOrder:
                        tabName = "补货申请单明细";
                        ctrl = new ReplenishDetailCtrl(GlobalCache.ServerProxy.GetReplenishOrder(order.ID));
                        break;
                    case OrderPrefix.ConfusedStoreAdjustRecord:
                        tabName = "串码调整";
                        ConfusedStoreAdjustRecordPage confusedStoreAdjustRecordPage = GlobalCache.ServerProxy.GetConfusedStoreAdjustRecordPage(new GetConfusedStoreAdjustRecordPagePara()
                        {
                            OrderID = order.ID,
                            PageIndex = 0,
                            CostumeID = null,
                            PageSize = int.MaxValue,
                            ShopID = null
                        });
                        ctrl = new ConfusedStoreAdjustRecordDetailCtrl(confusedStoreAdjustRecordPage.ConfusedStoreAdjustRecords[0]);
                        break;
                    case OrderPrefix.ScrapOrder:
                        tabName = "报损单明细";
                        ScrapPage pageScrap = GlobalCache.ServerProxy.GetScrapPage(new ScrapPagePara()
                        {
                            ScrapOrderID = order.ID,
                            StartDate = null,
                            EndDate = null,
                            PageIndex = 0,
                            CostumeID = null,
                            PageSize = int.MaxValue,
                            ShopID = null
                        });
                        ctrl = new ScrapOrderDetailCtrl(pageScrap.ScrapOrderList[0]);
                        break;
                    case OrderPrefix.RetailOrder:
                        tabName = "销售单明细";
                        RetailListPage pageRetail = GlobalCache.ServerProxy.GetRetailListPage(new RetailListPagePara()
                        {
                            RetailOrderID = order.ID,
                            IsOpenDate = false,
                            StartDate = null,
                            EndDate = null,
                            PageIndex = 0,
                            CostumeID = null,
                            PageSize = int.MaxValue,
                            RetailOrderType = RetailOrderType.All,
                            ShopID = null
                        });
                        if (pageRetail.ResultList.Count > 0)
                        {
                            ctrl = new RetailOrderDetailCtrl(pageRetail.ResultList[0]);
                        }
                        else
                        {
                            ctrl = new RetailOrderDetailCtrl(null);
                        }
                        //  ((RetailOrderDetailCtrl)ctrl).RefundOrderDetail += SourceOrderDetailClick;
                        break;

                    case OrderPrefix.SalesPromotion:
                        // SalesPromotionCtrl
                        break;
                    case OrderPrefix.PfDelivery:
                    case OrderPrefix.PfReturn:
                        tabName = "批发发货退货明细";
                        ctrl = new WholesaleOrderDetailCtrl(order.ID);
                        break;
                    case OrderPrefix.PfCustomerOrder:
                        tabName = "批发订单明细";
                        ctrl = new WholesaleEmOrderDetailCtrl(order.ID, sourceCtrl);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) {
                ShowError(ex);
            }
        }
        public void GetControlFromOrder(string orderId, out BaseModifyCostumeIDUserControl ctrl, out string tabName, bool isNewTabPage = false, BaseUserControl sourceCtrl = null)
        {
            ctrl = null;
            tabName = string.Empty;
            if (String.IsNullOrEmpty(orderId))
            {
                return;
            }
            String orderPrefix = getOrderPreFix(orderId);
            switch (orderPrefix)
            {
                case OrderPrefix.AllocateOrder:
                    tabName = "调拨单明细";
                    ctrl = new AllocateOrderDetailCtrl(GlobalCache.ServerProxy.GetAllocateOrder(orderId));
                    break;
                case OrderPrefix.CheckStoreOrder:
                    tabName = "盘点单明细";
                    CheckStoreOrderPage page = GlobalCache.ServerProxy.GetCheckStoreOrderPage(new CheckStoreOrderPagePara()
                    {
                        CheckStoreOrderID = orderId,
                        IsOpenDate = false,
                        StartDate = null,
                        EndDate = null,
                        PageIndex = 0,
                        PageSize = int.MaxValue,
                        ShopID = null
                    });
                    ctrl = new CheckStoreDetailCtrl(page.CheckStoreOrderList[0], false);
                    break;
                case OrderPrefix.DifferenceOrder:
                    tabName = "差异单明细";
                    DifferenceOrderPage pageDifferenceOrder = GlobalCache.ServerProxy.GetDifferenceOrderPage(new DifferenceOrderPagePara()
                    {
                        OrderID = orderId,
                        IsOpenDate = false,
                        StartDate = null,
                        EndDate = null,
                        PageIndex = 0,
                        CostumeID = null,
                        PageSize = int.MaxValue,
                        ShopID = null
                    });
                    ctrl = new DifferenceOrderConfirmCtrl(pageDifferenceOrder.DifferenceOrderList[0]);

                    break;
                case OrderPrefix.InboundOrder:
                    tabName = "入库单明细";
                    ctrl = new InboundDetailCtrl(GlobalCache.ServerProxy.GetInboundOrder(orderId));
                    break;
                case OrderPrefix.OutboundOrder:
                    tabName = "出库单明细";
                    ctrl = new OutboundDetailCtrl(GlobalCache.ServerProxy.GetOutboundOrder(orderId));
                    break;
                case OrderPrefix.PurchaseOrder:
                case OrderPrefix.ReturnOrder:
                    if (isNewTabPage)
                    {
                        tabName = "采购进货/退货单查询";
                        ctrl = new ReturnOrderManageCtrl(orderId);
                        ReturnOrderManageCtrl returnOrderManageCtrl = ctrl as ReturnOrderManageCtrl;
                        returnOrderManageCtrl.DetailClick += ReturnOrder_DetailClick;

                        returnOrderManageCtrl.DetailExcept += ReturnOrder_DetailExcept;
                        returnOrderManageCtrl.RedoClick += ReturnOrder_ReDoClick;
                        returnOrderManageCtrl.PickClick += ReturnOrder_PickClick;
                    }
                    else
                    {
                        tabName = "采购单明细";
                        PurchaseOrder pageReturnOrder = GlobalCache.ServerProxy.GetOnePurchaseOrder(orderId);
                        ctrl = new ReturnOrderDetailCtrl(pageReturnOrder);
                    }
                    break;
                case OrderPrefix.RechargeRecordOrder:
                    //没有接口，也不需要实现
                    break;

                case OrderPrefix.RefundOrder:

                    tabName = "退货单明细";
                    RefundListPage pageRetund = GlobalCache.ServerProxy.GetRefundListPage(new RefundListPagePara()
                    {
                        RefundOrderID = orderId,
                        StartDate = null,
                        EndDate = null,
                        PageIndex = 0,
                        CostumeID = null,
                        PageSize = int.MaxValue,
                        ShopID = null
                    });
                    ctrl = new RefundOrderDetailCtrl(pageRetund.ResultList[0]);

                    break;
                case OrderPrefix.ReplenishOrder:
                    tabName = "补货申请单明细";
                    ctrl = new ReplenishDetailCtrl(GlobalCache.ServerProxy.GetReplenishOrder(orderId));
                    break;
                case OrderPrefix.ConfusedStoreAdjustRecord:
                    tabName = "串码调整";
                    ConfusedStoreAdjustRecordPage confusedStoreAdjustRecordPage = GlobalCache.ServerProxy.GetConfusedStoreAdjustRecordPage(new GetConfusedStoreAdjustRecordPagePara()
                    {
                        OrderID = orderId,
                        PageIndex = 0,
                        CostumeID = null,
                        PageSize = int.MaxValue,
                        ShopID = null
                    });
                    ctrl = new ConfusedStoreAdjustRecordDetailCtrl(confusedStoreAdjustRecordPage.ConfusedStoreAdjustRecords[0]);
                    break;
                case OrderPrefix.ScrapOrder:
                    tabName = "报损单明细";
                    ScrapPage pageScrap = GlobalCache.ServerProxy.GetScrapPage(new ScrapPagePara()
                    {
                        ScrapOrderID = orderId,
                        StartDate = null,
                        EndDate = null,
                        PageIndex = 0,
                        CostumeID = null,
                        PageSize = int.MaxValue,
                        ShopID = null
                    });
                    ctrl = new ScrapOrderDetailCtrl(pageScrap.ScrapOrderList[0]);
                    break;
                case OrderPrefix.RetailOrder:
                    tabName = "销售单明细";
                    RetailListPage pageRetail = GlobalCache.ServerProxy.GetRetailListPage(new RetailListPagePara()
                    {
                        RetailOrderID = orderId,
                        IsOpenDate = false,
                        StartDate = null,
                        EndDate = null,
                        PageIndex = 0,
                        CostumeID = null,
                        PageSize = int.MaxValue,
                        RetailOrderType = RetailOrderType.All,
                        ShopID = null
                    });
                    if (pageRetail.ResultList.Count > 0)
                    {
                        ctrl = new RetailOrderDetailCtrl(pageRetail.ResultList[0]);
                    }
                    else
                    {
                        ctrl = new RetailOrderDetailCtrl(null);
                    }
                    //  ((RetailOrderDetailCtrl)ctrl).RefundOrderDetail += SourceOrderDetailClick;
                    break;

                case OrderPrefix.SalesPromotion:
                    // SalesPromotionCtrl
                    break;
                case OrderPrefix.PfDelivery:
                case OrderPrefix.PfReturn:
                    tabName = "批发发货退货明细";
                    ctrl = new WholesaleOrderDetailCtrl(orderId);
                    break;
                case OrderPrefix.PfCustomerOrder:
                    tabName = "批发订单明细";
                    ctrl = new WholesaleEmOrderDetailCtrl(orderId, sourceCtrl);
                    break;
                default:

                    break;
            }
        }
        private void ReturnOrder_PickClick(PurchaseOrder order, BaseUserControl type)
        {
            if (order.Type == CostumeStoreTrackChangeType.ReturnOutbound)
            {
                ReturnOrderCtrl ctrl = new ReturnOrderCtrl(order, OperationEnum.Pick);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("采购退货", ref modifyCtrl, type);
            }
            else
            {
                PurchaseOrderCtrl ctrl = new PurchaseOrderCtrl(order, OperationEnum.Pick);
                ctrl.AddCostumeClick += Costume_Save;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("采购进货", ref modifyCtrl, type);
            }
        }
        private void ReturnOrder_ReDoClick(PurchaseOrder order, BaseUserControl type)
        {
            if (order.Type == CostumeStoreTrackChangeType.ReturnOutbound)
            {

                ReturnOrderCtrl ctrl = new ReturnOrderCtrl(order, OperationEnum.Redo);
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("采购退货", ref modifyCtrl, type);
            }
            else
            {
                PurchaseOrderCtrl ctrl = new PurchaseOrderCtrl(order, OperationEnum.Redo);
                ctrl.AddCostumeClick += Costume_Save;
                BaseModifyUserControl modifyCtrl = ctrl;
                AddModifyUserControlToTabPage("采购进货", ref modifyCtrl, type);
            }
        }
        private void RefreshPage(TabPage tabPage, UserControl type)
        {
            try
            {
                foreach (TabPage page in this.skinTabControl1.TabPages)
                {
                    Control c = page.Controls[0];
                    if (type == c)
                    {
                        ((BaseUserControl)c).RefreshPage();
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        private void TabPage_Close(TabPage tabPage, UserControl type)
        {
            try
            {
                foreach (TabPage page in this.skinTabControl1.TabPages)
                {
                    //不要干掉仔鸡啦

                    Control c = page.Controls[0];
                    //如果是我自己的page//准备被关闭的页面，不能被重新选中，后面将被删除
                    if (type == c && tabPage != page)
                    {

                        BaseUserControl bc = (BaseUserControl)c;
                        //这里并不一定要调用刷新功能？可以在控件里面做判断
                        if (!bc.RefreshPageDisable)
                        {
                            bc.RefreshPage();
                        }
                        //只触发一次，重置
                        bc.RefreshPageDisable = false;
                        //484 加一个按钮，可以关闭所有标签,他把自己关了，结果又是使用tabcontrol默认选择第一个。。。
                        this.skinTabControl1.SelectedTab = page;
                        //  CommonGlobalUtil.Debug(tabPage.Text);
                        break;
                    }
                }
                //这个删除会让索引自动跑到第一个PAGE去，所以先设置索引再删除关闭的窗口
                if (tabPage != null)
                {
                    if (this.skinTabControl1.TabPages.Contains(tabPage))
                    {
                        this.skinTabControl1.TabPages.Remove(tabPage);
                    }
                }
                if (this.skinTabControl1.TabPages == null || this.skinTabControl1.TabPages.Count == 0)
                {
                    CheckFirstLogin();
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }


        }
        private Boolean forceClose;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!toClose)
                {
                    if (forceClose)
                    {
                        // toolStripButton_Exit_Click(null,null);
                        if (MessageBox.Show("您确定要退出 " + this.Text + " 吗？", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            toClose = true;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("您确定要退出 " + this.Text + " 吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            toClose = true;
                        }
                    }
                }

                if (!this.toClose)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    e.Cancel = false;
                }

                {

                    LoginAgileConfiguration config = LoginAgileConfiguration.Load(LoginForm.CONFIG_PATH) as LoginAgileConfiguration;
                    if (config != null && config.LoginInfos.Count > 0)
                    {

                        LoginInfo info = config.LoginInfos.Find(t => t.LastLoginID == GlobalCache.CurrentUserID);
                        if (info != null)
                        {
                            info.ExitTime = DateTime.Now;
                            config.Save(LoginForm.CONFIG_PATH);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripItem item = (ToolStripItem)sender;
                if (item.Tag != null)
                {
                    int i = 0;
                    String[] splits = item.Name.Split('#');
                    if (splits != null && splits.Length > 1)
                    {
                        i = int.Parse(splits[1]);
                    }

                    if ((Type)item.Tag == typeof(SystemSettingForm) || (Type)item.Tag == typeof(BasicSettingForm))
                    {
                        BaseForm form = GetForm((Type)item.Tag, i);
                        form.ShowDialog(this);
                    }
                    else
                    {
                        BaseUserControl ctrl = GetUserControl((Type)item.Tag, i);
                        if (ctrl is BaseModifyUserControl)
                        {
                            BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                            AddModifyUserControlToTabPage(item.Text, ref modifyCtrl, null);
                        }
                        else
                        {
                            AddUserControlToTabPage(item.Text, ref ctrl);
                        }
                    }

                    //   ctrl.ReLoad();
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        private BaseForm GetForm(Type type, int i)
        {
            BaseForm ctrl = null;
            if (type == typeof(BasicSettingForm))
            {
                ctrl = new BasicSettingForm();
            }
            else if (type == typeof(SystemSettingForm))
            {
                ctrl = new SystemSettingForm();
            }
            else
            {
                ctrl = type.Assembly.CreateInstance(type.FullName) as BaseForm;
            }
            return ctrl;
        }
        private void DayBenefitReport_SaleDetailList(DayBenefitReportDetailPara para, BaseUserControl type)
        {
            BenefitReportSailDetailListCtrl ctrl = new BenefitReportSailDetailListCtrl();
            BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
            AddModifyUserControlToTabPage("营业明细", ref modifyCtrl, type);
            if (modifyCtrl != null)
            {
                ctrl?.SearchDetailList(para);
            }
        }
        private void ShouYinCtrl_ClickRechargeButton(Member member, BaseUserControl type)
        {
            try
            {
                string tabName = "充值";
                BaseModifyUserControl rechargeCtrl = new RechargeCtrl(member, true);
                AddModifyUserControlToTabPage(tabName, ref rechargeCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void MenuItemClick(String text, BaseUserControl baseUserControl)
        {
            try
            {
                string tabName = text;
                switch (text)
                {
                    case "考勤签到":
                        {
                            tabName = "签到";
                            BaseUserControl ctrl = new GuideSignRecordCtrl();
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "库存查询":
                        {
                            BaseUserControl ctrl = GetUserControl(typeof(CostumeStoreSearchCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "当日结存":
                        {
                            BaseUserControl ctrl = GetUserControl(typeof(DayReportDetailCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "调拨":
                        {
                            BaseUserControl ctrl = GetUserControl(typeof(AllocateOrderApplyCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "现金记录":
                        {
                            tabName = "现金记录查询";
                            BaseUserControl ctrl = GetUserControl(typeof(CashRecordSearchCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "补货申请":
                        {
                            BaseUserControl ctrl = GetUserControl(typeof(ReplenishApplyCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "会员管理":
                        {
                            BaseUserControl ctrl = GetUserControl(typeof(MemberManageCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "会员开卡":
                        {
                            tabName = "开卡";
                            BaseModifyUserControl ctrl = GetUserControl(typeof(NewMemberCtrl)) as BaseModifyUserControl;
                            AddModifyUserControlToTabPage(tabName, ref ctrl, baseUserControl);
                            break;
                        }
                    case "销售退货单查询":
                        {
                            tabName = "销售/退货单查询";
                            BaseUserControl ctrl = GetUserControl(typeof(RetailOrderSearchCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "营业报表":
                        {
                            BaseUserControl ctrl = GetUserControl(typeof(BenefitReportManageCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "串码调整":
                        {
                            BaseUserControl ctrl = GetUserControl(typeof(NewConfusedStoreAdjustRecordCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    case "导购业绩":
                        {
                            BaseUserControl ctrl = GetUserControl(typeof(GuideAchievementSummaryManageCtrl));
                            AddUserControlToTabPage(tabName, ref ctrl);
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void 新增现金记录ToolStripMenuItem_Click(BaseUserControl type)
        {
            try
            {
                string tabName = "新增现金记录";
                BaseModifyUserControl modifyCtrl = GetUserControl(typeof(CashRecordInsertCtrl)) as BaseModifyUserControl;
                // AddUserControlToTabPage(tabName, ref ctrl);
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void ReplenishManageCtrl_PickClick(ReplenishOrder order, BaseUserControl type)
        {
            try
            {
                BaseModifyUserControl ctrl = new ReplenishApplyCtrl(order, OperationEnum.Pick);
                AddModifyUserControlToTabPage("补货申请", ref ctrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void ReplenishManageCtrl_InboundClick(string orderID, BaseUserControl type)
        {
            try {
                string tabName = "收货";
                BaseModifyUserControl ctrl = new InboundConfirmCtrl(orderID);
                AddModifyUserControlToTabPage(tabName, ref ctrl, type);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        public BaseUserControl GetUserControl(Type type, int id = 0)
        {
            BaseUserControl ctrl = null;
            try
            {
                if (type == typeof(ReplenishApplyCtrl))
                {
                    ReplenishApplyCtrl replenishApplyCtrl = new ReplenishApplyCtrl();
                    ctrl = replenishApplyCtrl;
                }
                else if (type == typeof(GuideAchievementSummaryManageCtrl))
                {
                    GuideAchievementSummaryManageCtrl guideDayAchievementSummaryManageCtrl = new GuideAchievementSummaryManageCtrl();
                    guideDayAchievementSummaryManageCtrl.DetailClick += RetailOrder_Search;
                    ctrl = guideDayAchievementSummaryManageCtrl;
                }
                else if (type == typeof(BenefitReportManageCtrl))
                {
                    BenefitReportManageCtrl cashRecordSearchCtrl = new BenefitReportManageCtrl();
                    cashRecordSearchCtrl.DetailClick += DayBenefitReport_DetailList;
                    ctrl = cashRecordSearchCtrl;
                }
                else if (type == typeof(CashRecordSearchCtrl))
                {
                    CashRecordSearchCtrl cashRecordSearchCtrl = new CashRecordSearchCtrl();
                    cashRecordSearchCtrl.NewClick += 新增现金记录ToolStripMenuItem_Click;
                    ctrl = cashRecordSearchCtrl;
                }
                else if (type == typeof(AllocateOrderApplyCtrl))
                {
                    AllocateOrderApplyCtrl allocateApplyCtrl = new AllocateOrderApplyCtrl(AllocateType.Allocate);
                    ctrl = allocateApplyCtrl;
                }
                else if (type == typeof(DayReportDetailCtrl))
                {

                    DayReportDetailCtrl dayReportDetailCtrl = new DayReportDetailCtrl();
                    dayReportDetailCtrl.SalesCount_Click += RetailOrder_List;
                    dayReportDetailCtrl.RefundCount_Click += RefundOrder_List;
                    dayReportDetailCtrl.GuideDetail_Click += RetailOrder_List;
                    dayReportDetailCtrl.RechargeRecord_Click += RechargeRecord_list;
                    ctrl = dayReportDetailCtrl;
                }
                else if (type == typeof(ShouYinCtrl))
                {
                    ShouYinCtrl shouYinCtrl = new ShouYinCtrl();
                    shouYinCtrl.ClickRechargeButton += ShouYinCtrl_ClickRechargeButton;
                    shouYinCtrl.ToolStripButtonClick += MenuItemClick;
                    ctrl = shouYinCtrl;
                }
                else if (type == typeof(GuideAchievementSummaryManageCtrl))
                {
                    GuideAchievementSummaryManageCtrl guideMonthAchievementSummaryManageCtrl = new GuideAchievementSummaryManageCtrl();
                    guideMonthAchievementSummaryManageCtrl.DetailClick += RetailOrder_Search;
                    ctrl = guideMonthAchievementSummaryManageCtrl;
                }
                else if (type == typeof(DifferenceOrderSearchCtrl))
                {
                    DifferenceOrderSearchCtrl differenceOrderSearchCtrl = new DifferenceOrderSearchCtrl();
                    differenceOrderSearchCtrl.DifferenceOrderDetailClick += SourceOrderDetailClick;
                    differenceOrderSearchCtrl.InboundOrderDetailClick += SourceOrderDetailClick;
                    differenceOrderSearchCtrl.OutboundOrderDetailClick += SourceOrderDetailClick;
                    differenceOrderSearchCtrl.SourceOrderDetailClick += SourceOrderDetailClick;
                    differenceOrderSearchCtrl.RefreshPageAction += RefreshPage;
                    ctrl = differenceOrderSearchCtrl;
                }
                else if (type == typeof(CostumeManageCtrl))
                {
                    CostumeManageCtrl costumeManageCtrl = new CostumeManageCtrl();
                    costumeManageCtrl.OpenModifyDialog += Costume_Save;
                    ctrl = costumeManageCtrl;
                }
                else if (type == typeof(SupplierManageCtrl))
                {
                    SupplierManageCtrl supplierManageCtrl = new SupplierManageCtrl();
                    //  supplierManageCtrl.SaveClick += SupplierManageCtrl_Save;
                    ctrl = supplierManageCtrl;
                }
                else if (type == typeof(WholesaleCustomerManageCtrl))
                {
                    WholesaleCustomerManageCtrl wholesaleCustomerManageCtrl = new WholesaleCustomerManageCtrl();
                    wholesaleCustomerManageCtrl.SaveClick += WholesaleCustomerManageCtrl_Save;
                    wholesaleCustomerManageCtrl.BalanceDetailClick += WholesaleCustomerManageCtrl_balanceDetail;

                    // wholesaleCustomerManageCtrl.RechargeClick += WholesaleCustomerManageCtrl_RechargeClick;
                    ctrl = wholesaleCustomerManageCtrl;
                }
                else if (type == typeof(SalesPromotionCtrl))
                {
                    SalesPromotionCtrl salesPromotionCtrl = new SalesPromotionCtrl();
                    salesPromotionCtrl.SaveClick += SalesPromotion_Save;
                    ctrl = salesPromotionCtrl;
                }
                else if (type == typeof(GiftTicketCtrl))
                {
                    GiftTicketCtrl giftTicketCtrl = new GiftTicketCtrl();
                    giftTicketCtrl.SaveClick += GiftTicket_Save;
                    ctrl = giftTicketCtrl;
                }
                else if (type == typeof(AdminUserManageCtrl))
                {
                    AdminUserManageCtrl adminUserManageCtrl = new AdminUserManageCtrl();
                    adminUserManageCtrl.SaveClick += AdminUserManageCtrl_Save;
                    adminUserManageCtrl.AdminUserPermissionClick += AdminUserPermissionClick;

                    adminUserManageCtrl.EditPasswordClick += ChangePasswordAdminUser;
                    ctrl = adminUserManageCtrl;
                }
                else if (type == typeof(EmCostumeManageCtrl))
                {
                    EmCostumeManageCtrl emCostumeManageCtrl = new EmCostumeManageCtrl();
                    ctrl = emCostumeManageCtrl;
                }
                else if (type == typeof(EmLogisticManageCtrl))
                {
                    EmLogisticManageCtrl emLogisticManageCtrl = new EmLogisticManageCtrl();
                    //emLogisticManageCtrl.OpenModifyDialog += EmLogisticManageCtrl;
                    ctrl = emLogisticManageCtrl;
                }
                else if (type == typeof(RetailOrderSearchCtrl))
                {
                    RetailOrderSearchCtrl retailOrderSearchCtrl = new RetailOrderSearchCtrl();
                    retailOrderSearchCtrl.RedoClick += RetailOrderListCtrl_RedoClick;
                    retailOrderSearchCtrl.RefundDetailClick += SourceOrderDetailClick;
                    retailOrderSearchCtrl.RetailDetailClick += SourceOrderDetailClick;
                    ctrl = retailOrderSearchCtrl;
                }
                else if (type == typeof(WholesaleCustomeSaleManageCtrl))
                {
                    WholesaleCustomeSaleManageCtrl wholesaleCustomeSaleManageCtrl = new WholesaleCustomeSaleManageCtrl();
                    wholesaleCustomeSaleManageCtrl.EditClick += WholesaleCustomeSaleManageCtrl_EditClick;
                    ctrl = wholesaleCustomeSaleManageCtrl;
                }
                else if (type == typeof(MemberManageCtrl))
                {
                    MemberManageCtrl memberManageCtrl = new MemberManageCtrl();
                    memberManageCtrl.ConsumeHistoryClick += RetailOrder_List;
                    memberManageCtrl.RechargeRecordClick += RechargeRecordClick;
                    memberManageCtrl.RechargeClick += RechargeClick;
                    memberManageCtrl.SendGiftTicketClick += SendGiftTicketClick;
                    memberManageCtrl.MemberGiftTicketClick += MemberGiftTicketClick;
                    memberManageCtrl.UpdateMemberClick += MemberManageCtrl_UpdateMemberClick;
                    ctrl = memberManageCtrl;
                }
                else if (type == typeof(ShopManageCtrl))
                {
                    ShopManageCtrl shopManageCtrl = new ShopManageCtrl();
                    shopManageCtrl.SaveClick += ShopManageCtrl_Save;
                    ctrl = shopManageCtrl;
                }
                else if (type == typeof(GuideCtrl))
                {
                    GuideCtrl guideCtrl = new GuideCtrl();
                    guideCtrl.AddClick += GuideCtrl_AddGuide_Click;
                    guideCtrl.ChangePwdClick += GuideCtrl_ChangePwdClick;
                    ctrl = guideCtrl;
                }
                else if (type == typeof(PurchaseOrderCtrl))
                {
                    PurchaseOrderCtrl purchaseOrderCtrl = new PurchaseOrderCtrl();
                    purchaseOrderCtrl.AddCostumeClick += Costume_Save;
                    ctrl = purchaseOrderCtrl;
                }
                else if (type == typeof(AllocateManageCtrl))
                {
                    AllocateManageCtrl allocateManageCtrl = new AllocateManageCtrl();
                    allocateManageCtrl.InboundDetailClick += SourceOrderDetailClick;
                    allocateManageCtrl.OutboundDetailClick += SourceOrderDetailClick;
                    allocateManageCtrl.ReAllocateClick += ReAllocateClick;
                    allocateManageCtrl.PickClick += PickClick;
                    allocateManageCtrl.InboundClick += InboundClick;
                    ctrl = allocateManageCtrl;
                }
                else if (type == typeof(ReplenishManageCtrl))
                {
                    ReplenishManageCtrl replenishManageCtrl = new ReplenishManageCtrl();
                    replenishManageCtrl.ReplenishDetailClick += ReplenishManageCtrl_ReplenishDetailClick;
                    replenishManageCtrl.ReplenishDetailExcept += ReplenishManageCtrl_ReplenishDetailExcpt;
                    replenishManageCtrl.OutboundClick += ReplenishManageCtrl_OutboundClick;
                    replenishManageCtrl.ReReplenishClick += ReReplenishClick;
                    replenishManageCtrl.InboundClick += ReplenishManageCtrl_InboundClick;
                    replenishManageCtrl.PickClick += ReplenishManageCtrl_PickClick;
                    ctrl = replenishManageCtrl;
                }
                else if (type == typeof(CostumeStoreTrackSearchCtrl1))
                {
                    CostumeStoreTrackSearchCtrl1 costumeStoreTrackSearchCtrl = new CostumeStoreTrackSearchCtrl1();
                    ctrl = costumeStoreTrackSearchCtrl;
                }
                else if (type == typeof(CheckStoreOrderSearchCtrl))
                {

                    CheckStoreOrderSearchCtrl checkStoreOrderSearch = new CheckStoreOrderSearchCtrl();
                    checkStoreOrderSearch.CheckStoreDetailClick += CheckStoreOrderSearch_CheckStoreDetailClick;
                    checkStoreOrderSearch.UpdateCheckStoreOrderClick += CheckStoreClick;
                   
                    checkStoreOrderSearch.RedoClick += CheckStoreClick;
                    ctrl = checkStoreOrderSearch;
                }
                else if (type == typeof(InboundOrderSearchCtrl))
                {
                    InboundOrderSearchCtrl inboundOrderSearchCtrl = new InboundOrderSearchCtrl();
                    inboundOrderSearchCtrl.InboundDetailClick += InboundDetailClick;
                    inboundOrderSearchCtrl.SourceDetailClick += SourceOrderDetailClick;
                    ctrl = inboundOrderSearchCtrl;
                }
                else if (type == typeof(ReturnOrderManageCtrl))
                {
                    ReturnOrderManageCtrl returnOrderManageCtrl = new ReturnOrderManageCtrl();
                    returnOrderManageCtrl.DetailClick += ReturnOrder_DetailClick;
                    returnOrderManageCtrl.DetailExcept +=  ReturnOrder_DetailExcept;
                    returnOrderManageCtrl.RedoClick += ReturnOrder_ReDoClick;
                    returnOrderManageCtrl.PickClick += ReturnOrder_PickClick;
                    ctrl = returnOrderManageCtrl;
                }
                else if (type == typeof(ScrapOrderManageCtrl))
                {
                    ScrapOrderManageCtrl scrapOrderManageCtrl = new ScrapOrderManageCtrl();
                    scrapOrderManageCtrl.DetailClick += ScrapOrderManageCtrl_DetailClick;
                    scrapOrderManageCtrl.RedoClick += ScrapOrderManageCtrl_RedoClick;

                    ctrl = scrapOrderManageCtrl;
                }
                else if (type == typeof(BenefitReportManageCtrl))
                {
                    BenefitReportManageCtrl dayBenefitReportManageCtrl = new BenefitReportManageCtrl();
                    dayBenefitReportManageCtrl.DetailClick += DayBenefitReport_DetailList;
                    ctrl = dayBenefitReportManageCtrl;

                }
                else if (type == typeof(SalesQuantityRankingSearchCtrl))
                {
                    SalesQuantityRankingSearchCtrl salesQuantityRankingSearchCtrl = new SalesQuantityRankingSearchCtrl();
                    salesQuantityRankingSearchCtrl.RowSelected += SalesQuantityRankingSearchCtrl_RowSelected;
                    ctrl = salesQuantityRankingSearchCtrl;
                }
                else if (type == typeof(PriceRangeReportManageCtrl))
                {
                    PriceRangeReportManageCtrl priceRangeReportManageCtrl = new PriceRangeReportManageCtrl();
                    priceRangeReportManageCtrl.RowSelected += PriceRangeReportManageCtrl_RowSelected;
                    ctrl = priceRangeReportManageCtrl;
                }
                else if (type == typeof(CostumeRetailAnalysisCtrl))
                {
                    CostumeRetailAnalysisCtrl costumeRetailAnalysisSearchCtrl = new CostumeRetailAnalysisCtrl();
                    // costumeRetailAnalysisSearchCtrl.RowSelected += CostumeRetailAnalysisSearchCtrl_RowSelected;
                    ctrl = costumeRetailAnalysisSearchCtrl;
                }
                else if (type == typeof(SupplierAccountRecordSearchCtrl))
                {
                    SupplierAccountRecordSearchCtrl supplierAccountRecordSearchCtrl = new SupplierAccountRecordSearchCtrl();
                    supplierAccountRecordSearchCtrl.SourceOrderDetailClick += SourceOrderDetailClick;
                    ctrl = supplierAccountRecordSearchCtrl;
                }
                else if (type == typeof(SupplierAccountSearchCtrl))
                {
                    SupplierAccountSearchCtrl supplierAccountSearchCtrl = new SupplierAccountSearchCtrl();
                    ctrl = supplierAccountSearchCtrl;
                }
                else if (type == typeof(EmOrderManageCtrl))
                {
                    EmOrderManageCtrl emOrderManageCtrl = new EmOrderManageCtrl(id, EmOrderManageCtrl_DetailClick, EmOrderManageCtrl_LogisticsClick);
                    ctrl = emOrderManageCtrl;
                }
                else if (type == typeof(WholesaleEmOrderManageCtrl))
                {
                    WholesaleEmOrderManageCtrl wholesaleEmOrderManageCtrl = new WholesaleEmOrderManageCtrl(id, WholesaleEmOrderManageCtrl_DetailClick);
                    wholesaleEmOrderManageCtrl.DeliveryClick += WholesaleEmOrderManageCtrl_DeliveryClick;


                    ctrl = wholesaleEmOrderManageCtrl;
                }
                else if (type == typeof(ConfusedStoreAdjustRecordCtrl))
                {
                    ConfusedStoreAdjustRecordCtrl confusedStoreAdjustRecordCtrl = new ConfusedStoreAdjustRecordCtrl();
                    confusedStoreAdjustRecordCtrl.AddClick += ConfusedStoreAdjustRecordCtrl_AddClick;
                    ctrl = confusedStoreAdjustRecordCtrl;
                }
                else if (type == typeof(MemberGiftTicketCtrl))
                {
                    MemberGiftTicketCtrl memberGiftTicketCtrl = new MemberGiftTicketCtrl();
                    memberGiftTicketCtrl.SendGiftTicketClick += SendGiftTicketClick;
                    ctrl = memberGiftTicketCtrl;
                }
                else if (type == typeof(EarlyStageCostumeStoreRecordCtrl))
                {
                    EarlyStageCostumeStoreRecordCtrl earlyStageCostumeStoreRecordCtrl = new EarlyStageCostumeStoreRecordCtrl();
                    earlyStageCostumeStoreRecordCtrl.End += EarlyStageCostumeStoreRecordCtrl_End;
                    ctrl = earlyStageCostumeStoreRecordCtrl;
                }
                else if (type == typeof(EarlyStageAccountRecordCtrl))
                {
                    EarlyStageAccountRecordCtrl earlyStageAccountRecordCtrl = new EarlyStageAccountRecordCtrl();
                    earlyStageAccountRecordCtrl.End += EarlyStageAccountRecordCtrl_End;
                    ctrl = earlyStageAccountRecordCtrl;
                }
                else if (type == typeof(WholesaleBeginningStoreCtrl))
                {
                    WholesaleBeginningStoreCtrl wholesaleBeginningStoreCtrl = new WholesaleBeginningStoreCtrl();
                    wholesaleBeginningStoreCtrl.End += WholesaleBeginningStoreCtrl_End;
                    ctrl = wholesaleBeginningStoreCtrl;
                }
                else if (type == typeof(WholesaleBeginningBillCtrl))
                {
                    WholesaleBeginningBillCtrl wholesaleBeginningBillCtrl = new WholesaleBeginningBillCtrl();
                    wholesaleBeginningBillCtrl.End += WholesaleBeginningBillCtrl_End;
                    ctrl = wholesaleBeginningBillCtrl;
                }
                else if (type == typeof(EmCarriageCostTemplateCtrl))
                {
                    EmCarriageCostTemplateCtrl carriageCostTemplateCtrl = new EmCarriageCostTemplateCtrl();
                    carriageCostTemplateCtrl.OpenModifyDialog += CarriageCostTemplateCtrl_AddClick;
                    ctrl = carriageCostTemplateCtrl;
                }
                else if (type == typeof(DayReportManageCtrl))
                {
                    DayReportManageCtrl dayReportManageCtrl = new DayReportManageCtrl();
                    dayReportManageCtrl.DetailClick += DayReportDetailCtrl_Click;
                    ctrl = dayReportManageCtrl;
                }
                else if (type == typeof(WholesaleOrderManageCtrl))
                {
                    WholesaleOrderManageCtrl wholesaleOrderManageCtrl = new WholesaleOrderManageCtrl();
                    wholesaleOrderManageCtrl.DetailClick += WholesaleOrderManageCtrl_Click;
                    wholesaleOrderManageCtrl.DetailExcept += WholesaleOrderManageCtrl_Except;
                    wholesaleOrderManageCtrl.RedoClick += WholesaleOrderManageCtrl_RedoClick;
                    wholesaleOrderManageCtrl.PickClick += WholesaleOrderManageCtrl_PickClick;
                    ctrl = wholesaleOrderManageCtrl;
                }
                else
                {
                    //   Assembly assembly = Assembly.GetExecutingAssembly();
                    ctrl = type.Assembly.CreateInstance(type.FullName) as BaseUserControl;
                }

            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
            return ctrl;
        }
        private void CheckStoreOrderSearchCtrl_RedoClick(CheckStoreOrder order, BaseUserControl type)
        {
            try {
                String tabName = "盘点录入";
                CheckStore2019Ctrl ctrl = new CheckStore2019Ctrl(order);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                ctrl.isFlag = true;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WholesaleOrderManageCtrl_RedoClick(PfOrder order, BaseUserControl type)
        {
            try {
                if (order.IsRefundOrder)
                {
                    String tabName = "批发退货";
                    WholesaleReturnCtrl ctrl = new WholesaleReturnCtrl(order, OperationEnum.Redo);
                    BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                    AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                }
                else
                {
                    String tabName = "批发发货";
                    WholesaleDeliveryCtrl1 ctrl = new WholesaleDeliveryCtrl1(order, OperationEnum.Redo);
                    BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                    AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WholesaleOrderManageCtrl_PickClick(PfOrder order, BaseUserControl type)
        {
            try {
                if (order.IsRefundOrder)
                {
                    String tabName = "批发退货";
                    WholesaleReturnCtrl ctrl = new WholesaleReturnCtrl(order, OperationEnum.Pick);
                    BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                    AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                }
                else
                {
                    String tabName = "批发发货";
                    WholesaleDeliveryCtrl1 ctrl = new WholesaleDeliveryCtrl1(order, OperationEnum.Pick);
                    BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                    AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void AdminUserPermissionClick(BaseUserControl type)
        {
            try {
                String tabName = "权限设置";
                PermissonCtrl ctrl = new PermissonCtrl();
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WholesaleEmOrderManageCtrl_DeliveryClick(PfCustomerOrder order, BaseUserControl type)
        {
            try {
                String tabName = "批发商城-发货";
                WholesaleEmOrderDeliveryCtrl ctrl = new WholesaleEmOrderDeliveryCtrl();
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                if (modifyCtrl != null)
                {
                    ctrl?.Search(order);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WholesaleOrderManageCtrl_Click(PfOrder order, Panel panel, bool print)
        {
            try {
                String tabName = "批发销售退货明细";
                WholesaleOrderDetailCtrl ctrl = new WholesaleOrderDetailCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
                if (print)
                {
                    if (modifyCtrl != null)
                    {
                        ctrl?.Print();
                    }
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WholesaleOrderManageCtrl_Except(PfOrder order, Panel panel,string path)
        {
            try
            {
                String tabName = "批发销售退货明细";
                WholesaleOrderDetailCtrl ctrl = new WholesaleOrderDetailCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
               
                    if (modifyCtrl != null)
                    {
                        ctrl?.DoExport(path);
                    }
                
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void WholesaleCustomeSaleManageCtrl_EditClick(PfCustomerRetailOrder order, BaseUserControl type)
        {
            try {
                String tabName = "批发-修改客户销售单";
                WholesaleCustomeSaleEditCtrl ctrl = new WholesaleCustomeSaleEditCtrl();
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                if (modifyCtrl != null)
                {
                    ctrl?.Search(order);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void EarlyStageAccountRecordCtrl_End(BaseUserControl obj)
        {
            try
            {
                earlyStageAccountRecordMenu.Enabled = false;
            }
            catch (Exception ex) {
                ShowError(ex);
            }
        }
        private void EarlyStageCostumeStoreRecordCtrl_End(BaseUserControl obj)
        {
            try {
                earlyStageCostumeStoreMenu.Enabled = false;
            }
            catch (Exception ex) {
                ShowError(ex);
            }
        }
        private void WholesaleBeginningBillCtrl_End(BaseUserControl obj)
        {
            try {
                wholesaleBeginningBillCtrlMenuItem.Enabled = false;
            }
            catch (Exception ex) {
                ShowError(ex);
            }
        }
        private void WholesaleBeginningStoreCtrl_End(BaseUserControl obj)
        {
            try {
                wholesaleBeginningStoreCtrlMenuItem.Enabled = false;
            }
            catch (Exception ex) {
                ShowError(ex);
            }
        }
        private void RecordSearchClick(Supplier supplier, BaseUserControl type)
        {
            try {
                String tabName = "供应商往来账明细";
                SupplierAccountRecordSearchCtrl ctrl = new SupplierAccountRecordSearchCtrl();
                ctrl.SourceOrderDetailClick += SourceOrderDetailClick;
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
                if (modifyCtrl != null)
                {
                    ctrl?.Search();
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void DayReportDetailCtrl_Click(DayReport obj, BaseUserControl baseUserControl)
        {
            try {
                String tabName = "营业日结";
                if (obj.ShopID == SystemDefault.Report_Online)
                {

                    DayReportOnlineDetailCtrl ctrl = new DayReportOnlineDetailCtrl(obj);
                    ctrl.SalesCount_Click += RetailOrder_List;
                    ctrl.RefundCount_Click += RefundOrder_List;
                    ctrl.SourceTabPage = baseUserControl.CurrentTabPage;
                    //该界面没有关闭操作，
                    BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                    AddModifyUserControlToTabPage(tabName, ref modifyCtrl, baseUserControl);
                }
                else
                {
                    DayReportDetailCtrl ctrl = new DayReportDetailCtrl(obj, null);
                    ctrl.SalesCount_Click += RetailOrder_List;
                    ctrl.RefundCount_Click += RefundOrder_List;
                    ctrl.GuideDetail_Click += RetailOrder_List;
                    ctrl.RechargeRecord_Click += RechargeRecord_List;
                    ctrl.SourceTabPage = baseUserControl.CurrentTabPage;
                    //该界面没有关闭操作，
                    BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                    AddModifyUserControlToTabPage(tabName, ref modifyCtrl, baseUserControl);
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void RechargeRecord_list(RechargeRecordListPara para, BaseUserControl type)
        {
            try {
                String tabName = "充值记录";
                RechargeRecordListCtrl ctrl = new RechargeRecordListCtrl(para);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPageNoClose(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void SendGiftTicketClick(BaseUserControl type)
        {
            try {
                String tabName = "发放优惠券";
                SendGiftTicketCtrl ctrl = new SendGiftTicketCtrl();
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void MemberGiftTicketClick(Member member, BaseUserControl type)
        {
            try {
                String tabName = "会员优惠券";
                MemberGiftTicketCtrl ctrl = new MemberGiftTicketCtrl(member);
                ctrl.SendGiftTicketClick += SendGiftTicketClick;
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }
        private void ConfusedStoreAdjustRecordCtrl_AddClick(BaseUserControl type)
        {
            try
            {
                String tabName = "串码调整";
                NewConfusedStoreAdjustRecordCtrl ctrl = new NewConfusedStoreAdjustRecordCtrl();
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void RechargeClick(Member member, BaseUserControl type)
        {
            try
            {
                String tabName = "充值";
                RechargeCtrl ctrl = new RechargeCtrl(member, true);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void WholesaleEmOrderManageCtrl_DetailClick(PfCustomerOrder order, BaseUserControl control, Panel panel)
        {
            try
            {
                String tabName = String.Empty;
                WholesaleEmOrderDetailCtrl ctrl = new WholesaleEmOrderDetailCtrl(order);
                ctrl.SourceCtrlType = control;
                ctrl.CurrentTabPage = control.CurrentTabPage;
                ctrl.RefreshPageAction += RefreshPage;
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void EmOrderManageCtrl_DetailClick(EmRetailOrder order, BaseUserControl control, Panel panel)
        {
            try
            {
                String tabName = String.Empty;
                EmOrderDetailCtrl ctrl = new EmOrderDetailCtrl(order);
                ctrl.SourceCtrlType = control;
                ctrl.CurrentTabPage = control.CurrentTabPage;
                ctrl.RefreshPageAction += RefreshPage;
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void EmOrderManageCtrl_LogisticsClick(EmRetailOrder order, Panel panel)
        {
            try
            {
                String tabName = String.Empty;
                EmOrderLogisticsCtrl ctrl = new EmOrderLogisticsCtrl(order);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControl(tabName, ref modifyCtrl, panel);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        ToolStripDropDownButton wholesale;

        //
        ToolStripDropDownButton setting;
        ToolStripMenuItem ruleSetting;
        ToolStripMenuItem systemSetting;
        ToolStripMenuItem printSetting;
        ToolStripMenuItem roleSetting;
        ToolStripMenuItem adminUserItem;
        ToolStripMenuItem firstAccountRecord;
        ToolStripMenuItem guideItem;

        ToolStripMenuItem saleGuidItem;
        ToolStripDropDownButton purcharge;
        ToolStripDropDownButton retail;
        ToolStripDropDownButton report;
        ToolStripDropDownButton finances;
        ToolStripDropDownButton member;
        ToolStripButton resettlement;
        ToolStripButton exit;

        ToolStripMenuItem Cashier;
        ToolStripMenuItem ReturnShop;
        ToolStripMenuItem SaleShopOrReturn;
        ToolStripMenuItem SaleTarget;
        ToolStripMenuItem PriceManage;
        ToolStripMenuItem AskForAddShop;
        ToolStripMenuItem SearchAddShop;
        ToolStripMenuItem DayBalance;
        ToolStripMenuItem DayBalanceSearch;
        ToolStripMenuItem InTimeSheet;
        ToolStripMenuItem StoreChangeSearch;
        ToolStripMenuItem ShopDistributeMenu;
        ToolStripMenuItem allocateAndTransfer;
        ToolStripMenuItem allocateAndTransferSearch;
        ToolStripMenuItem diffentBillSeache;
        ToolStripMenuItem CheckEnter;
        ToolStripMenuItem CheckEnterSerach;
        ToolStripMenuItem CheckCollect;
        ToolStripMenuItem IMEIManage;
        ToolStripMenuItem IMEISearch;
        ToolStripMenuItem frmLoss;
        ToolStripMenuItem frmLossBillSearch;
        ToolStripMenuItem basicSettings;
        //  ToolStripMenuItem wholesaleAccountSearchCtrlItem;

        ToolStripMenuItem ShopCashManage;
        ToolStripMenuItem CostTypeItem;
        ToolStripMenuItem MakeCollectionsItem;
        ToolStripMenuItem SupplierEveryCollectItem;
        ToolStripMenuItem SupplierEveryCheckItem;
        ToolStripMenuItem CollectionPayManage;
        ToolStripMenuItem CustomerEveryCollection;
        ToolStripMenuItem CustomerEveryCheckItem;
        ToolStripMenuItem wholeSaleCenter;
        //wholeSaleCenter   
        ToolStripMenuItem ShopInfoItem;
        ToolStripMenuItem ShopManageItem;
        ToolStripMenuItem OrderManageItem;
        ToolStripMenuItem logisticsManageItem;
        ToolStripMenuItem carriageTemplateItem;
        ToolStripSeparator toolStripS1;
        ToolStripSeparator toolStripS2;
        ToolStripMenuItem ChildrenCheckEnter;

        ToolStripMenuItem PayMentItem;

        //
        ToolStripMenuItem PfSendShop;
        ToolStripMenuItem PfReturnShop;
        ToolStripMenuItem PfSendAndRetunBill;
        ToolStripMenuItem PfCustomerManager;

        ToolStripMenuItem  PfCustomerStore;
        ToolStripMenuItem AddCustomerSale;
        ToolStripMenuItem CustomerSaleBillSearch;
        ToolStripMenuItem wholesaleBeginning;

        /// <summary>
        /// 动态加载菜单
        /// </summary>
        /// <returns></returns>
        private ToolStripItem[] BuildMenu()
        {
            List<ToolStripItem> menuTree = new List<ToolStripItem>();
            try
            {
                #region 设置 
                setting = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.设置, Properties.Resources.设置);
                ruleSetting = MenuItems.NewMenuItem(RolePermissionMenuEnum.规则设置);
                ruleSetting.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.优惠券设置, typeof(GiftTicketCtrl), ToolStripMenuItem_Click));
                ruleSetting.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.促销规则, typeof(SalesPromotionCtrl), ToolStripMenuItem_Click));
                ruleSetting.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.充值规则, typeof(RechargeRuleCtrl), ToolStripMenuItem_Click));
                setting.DropDownItems.Add(ruleSetting);

                systemSetting = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.系统设置, typeof(SystemSettingForm), ToolStripMenuItem_Click);
                setting.DropDownItems.Add(systemSetting);
                 printSetting = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.打印设置, typeof(PrintSettingCtrl), ToolStripMenuItem_Click);
                setting.DropDownItems.Add(printSetting);

                roleSetting = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.角色管理, typeof(PermissonCtrl), ToolStripMenuItem_Click);
                setting.DropDownItems.Add(roleSetting);
                setting.DropDownItems.Add(new ToolStripSeparator());

                //如果不是ADMIN那么不显示
                //权限判断
                adminUserItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.管理员, typeof(AdminUserManageCtrl), ToolStripMenuItem_Click);
                if (GlobalCache.CurrentUserID != SystemDefault.DefaultAdmin) { adminUserItem.Visible = false; }
                setting.DropDownItems.Add(adminUserItem);
                saleGuidItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.导购员, typeof(GuideCtrl), ToolStripMenuItem_Click);
                setting.DropDownItems.Add(saleGuidItem);
                guideItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.导购签到记录, typeof(GuideSignRecordManCtrl), ToolStripMenuItem_Click);
                setting.DropDownItems.Add(guideItem);

                setting.DropDownItems.Add(new ToolStripSeparator());
                firstAccountRecord = MenuItems.NewMenuItem(RolePermissionMenuEnum.期初建账);
                earlyStageCostumeStoreMenu = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.期初库存录入, typeof(EarlyStageTabControlCtrl), ToolStripMenuItem_Click);
                earlyStageAccountRecordMenu = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.期初往来账录入, typeof(EarlyStageAccountRecordCtrl), ToolStripMenuItem_Click);
                firstAccountRecord.DropDownItems.Add(earlyStageCostumeStoreMenu);
                firstAccountRecord.DropDownItems.Add(earlyStageAccountRecordMenu);
                setting.DropDownItems.Add(firstAccountRecord);
                menuTree.Add(setting);

                #endregion

                purcharge = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.采购, Properties.Resources.采购进货);
                purcharge.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.采购进货, typeof(PurchaseOrderCtrl), ToolStripMenuItem_Click));
                purcharge.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.采购退货, typeof(ReturnOrderCtrl), ToolStripMenuItem_Click));
                purcharge.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.采购汇总, typeof(GetPurchaseSummaryCtrl), ToolStripMenuItem_Click));
                purcharge.DropDownItems.Add(new ToolStripSeparator());
                purcharge.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.采购进货退货单查询, typeof(ReturnOrderManageCtrl), ToolStripMenuItem_Click));
                purcharge.DropDownItems.Add(new ToolStripSeparator());
                purcharge.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.供应商, typeof(SupplierManageCtrl), ToolStripMenuItem_Click));
                menuTree.Add(purcharge);
                #region 零售
                retail = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.零售, Properties.Resources.收银);
                Cashier = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.收银, typeof(ShouYinCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(Cashier);
                ReturnShop = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.退货, typeof(RefundTabControlCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(ReturnShop);
                retail.DropDownItems.Add(new ToolStripSeparator());
                SaleShopOrReturn = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.销售退货单查询, typeof(RetailOrderSearchCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(SaleShopOrReturn);
                retail.DropDownItems.Add(new ToolStripSeparator());
                retail.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.店铺档案, typeof(ShopManageCtrl), ToolStripMenuItem_Click));
                SaleTarget = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.销售目标, typeof(MonthTaskSearchCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(SaleTarget);
                PriceManage = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.价格管理, typeof(UpdateShopCostumePriceCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(PriceManage);
                retail.DropDownItems.Add(new ToolStripSeparator());
                AskForAddShop = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.店铺补货申请, typeof(ReplenishApplyCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(AskForAddShop);
                SearchAddShop = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.店铺补货单查询, typeof(ReplenishManageCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(SearchAddShop);
                DayBalance = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.当日结存, typeof(DayReportDetailCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(DayBalance);
                DayBalanceSearch = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.日结存查询, typeof(DayReportManageCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(DayBalanceSearch);
                retail.DropDownItems.Add(new ToolStripSeparator());
                InTimeSheet = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.考勤签到, typeof(GuideSignRecordCtrl), ToolStripMenuItem_Click);
                retail.DropDownItems.Add(InTimeSheet);
                menuTree.Add(retail);
                #endregion
                #region 批发

                wholesale = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.批发, Properties.Resources.批发);
                PfSendShop = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.批发发货, typeof(WholesaleDeliveryCtrl1), ToolStripMenuItem_Click);
                wholesale.DropDownItems.Add(PfSendShop);
                PfReturnShop = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.批发退货, typeof(WholesaleReturnCtrl), ToolStripMenuItem_Click);
                wholesale.DropDownItems.Add(PfReturnShop);

                wholesale.DropDownItems.Add(new ToolStripSeparator());
                PfSendAndRetunBill = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.批发发货退货单查询, typeof(WholesaleOrderManageCtrl), ToolStripMenuItem_Click);
                wholesale.DropDownItems.Add(PfSendAndRetunBill);
                wholesale.DropDownItems.Add(new ToolStripSeparator());
                PfCustomerManager = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户管理, typeof(WholesaleCustomerManageCtrl), ToolStripMenuItem_Click);
                wholesale.DropDownItems.Add(PfCustomerManager);

              
               /* PfCustomerStore = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户库存, typeof(WholesaleCustomeStoreCtrl), ToolStripMenuItem_Click);
                wholesale.DropDownItems.Add(PfCustomerStore);*/
                AddCustomerSale = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.录入客户销售, typeof(WholesaleCustomeSaleCtrl), ToolStripMenuItem_Click);
                wholesale.DropDownItems.Add(AddCustomerSale);
                CustomerSaleBillSearch = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户销售单查询, typeof(WholesaleCustomeSaleManageCtrl), ToolStripMenuItem_Click);
                wholesale.DropDownItems.Add(CustomerSaleBillSearch);
                wholesale.DropDownItems.Add(new ToolStripSeparator());

                 wholesaleBeginning = MenuItems.NewMenuItem(RolePermissionMenuEnum.客户期初管理);
                wholesaleBeginningStoreCtrlMenuItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户期初库存录入, typeof(WholesaleBeginningControlCtrl), ToolStripMenuItem_Click);
                wholesaleBeginningBillCtrlMenuItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户期初往来账录入, typeof(WholesaleBeginningBillCtrl), ToolStripMenuItem_Click);
                wholesaleBeginning.DropDownItems.Add(wholesaleBeginningStoreCtrlMenuItem);
                wholesaleBeginning.DropDownItems.Add(wholesaleBeginningBillCtrlMenuItem);
                wholesale.DropDownItems.Add(wholesaleBeginning);
                menuTree.Add(wholesale);
                #endregion
                #region 库存

                ToolStripDropDownButton store = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.库存, Properties.Resources.库存);
                store.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.库存查询, typeof(CostumeStoreTabControlCtrl), ToolStripMenuItem_Click));

                ShopDistributeMenu = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.商品分布, typeof(CostumeDistributeSearchCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(ShopDistributeMenu);

                StoreChangeSearch = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.库存变化查询, typeof(CostumeStoreTrackSearchCtrl1), ToolStripMenuItem_Click);
                store.DropDownItems.Add(StoreChangeSearch);
                store.DropDownItems.Add(new ToolStripSeparator());
                allocateAndTransfer = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.调拨, typeof(AllocateOrderApplyCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(allocateAndTransfer);
                allocateAndTransferSearch = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.调拨单查询, typeof(AllocateManageCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(allocateAndTransferSearch);
                diffentBillSeache = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.差异单查询, typeof(DifferenceOrderSearchCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(diffentBillSeache);
                store.DropDownItems.Add(new ToolStripSeparator());
                CheckEnter = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.盘点录入, typeof(CheckStore2019Ctrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(CheckEnter);

         ChildrenCheckEnter= MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.添加子盘点单, typeof(CheckStoreChildrenCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(ChildrenCheckEnter);
                
                CheckEnterSerach = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.盘点单查询, typeof(CheckStoreOrderSearchCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(CheckEnterSerach);
                CheckCollect = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.盘点汇总, typeof(CheckStoreOrderSummaryCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(CheckCollect);
                store.DropDownItems.Add(new ToolStripSeparator());
                IMEIManage = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.串码调整, typeof(NewConfusedStoreAdjustRecordCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(IMEIManage);
                IMEISearch = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.串码调整查询, typeof(ConfusedStoreAdjustRecordCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(IMEISearch);
                store.DropDownItems.Add(new ToolStripSeparator());
                frmLoss = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.报损, typeof(ScrapOrderCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(frmLoss);
                frmLossBillSearch = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.报损单查询, typeof(ScrapOrderManageCtrl), ToolStripMenuItem_Click);
                store.DropDownItems.Add(frmLossBillSearch);
                menuTree.Add(store);
                #endregion
                #region 报表
                report = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.报表, Properties.Resources.报表);
                report.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.店铺营业报表, typeof(BenefitReportManageCtrl), ToolStripMenuItem_Click));
                report.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.畅滞排行榜, typeof(SalesQuantityRankingSearchCtrl), ToolStripMenuItem_Click));
                report.DropDownItems.Add(new ToolStripSeparator());
                report.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.销售分析, typeof(SaleAnalysisTabControlCtrl), ToolStripMenuItem_Click));
                report.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.库存分析, typeof(CostumeStoreAnalysisCtrl), ToolStripMenuItem_Click));
                report.DropDownItems.Add(new ToolStripSeparator());
                report.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.商品进销存, typeof(CostumeInventorySearchCtrl), ToolStripMenuItem_Click));
                report.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户进销存, typeof(CustomerInventorySearchCtrl), ToolStripMenuItem_Click));
                report.DropDownItems.Add(new ToolStripSeparator());
                report.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.商品价格区间简报, typeof(PriceRangeReportManageCtrl), ToolStripMenuItem_Click));
                report.DropDownItems.Add(new ToolStripSeparator());
                report.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.导购业绩, typeof(GuideAchievementSummaryManageCtrl), ToolStripMenuItem_Click));
                menuTree.Add(report);
                #endregion   
                finances = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.财务, Properties.Resources.财务);
                ShopCashManage = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.店铺现金管理, typeof(CashRecordSearchCtrl), ToolStripMenuItem_Click);
                finances.DropDownItems.Add(ShopCashManage);
                CostTypeItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.费用类型, typeof(CashFeeTypeCtrl), ToolStripMenuItem_Click);
                finances.DropDownItems.Add(CostTypeItem);
                finances.DropDownItems.Add(new ToolStripSeparator());
                MakeCollectionsItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.店铺收款汇总, typeof(GetRetailSummaryCtrl), ToolStripMenuItem_Click);
                finances.DropDownItems.Add(MakeCollectionsItem);
                finances.DropDownItems.Add(new ToolStripSeparator());
                SupplierEveryCollectItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.供应商往来账汇总, typeof(SupplierAccountSummaryCtrl), ToolStripMenuItem_Click);
                finances.DropDownItems.Add(SupplierEveryCollectItem);
                SupplierEveryCheckItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.供应商往来账对账表, typeof(SupplierAccountContrastCtrl), ToolStripMenuItem_Click);

                finances.DropDownItems.Add(SupplierEveryCheckItem);
                CollectionPayManage = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.采购付款管理, typeof(SupplierAccountCollectionManageCtrl), ToolStripMenuItem_Click);
                finances.DropDownItems.Add(CollectionPayManage);
                finances.DropDownItems.Add(new ToolStripSeparator());

                //if (CommonGlobalUtil.IsPfEnable())
                //{
                    CustomerEveryCollection = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户往来账汇总, typeof(WholesaleAccountSummaryCtrl), ToolStripMenuItem_Click);
                    finances.DropDownItems.Add(CustomerEveryCollection);
                    CustomerEveryCheckItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户往来账对账表, typeof(WholesaleAccountContrastCtrl), ToolStripMenuItem_Click);
                    finances.DropDownItems.Add(CustomerEveryCheckItem);
                    //finances.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户往来账明细, typeof(WholesaleAccountRecordSearchCtrl), ToolStripMenuItem_Click));
                    finances.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.销售收款管理, typeof(WholesaleCollectionManageCtrl), ToolStripMenuItem_Click));
                //}
                menuTree.Add(finances);

                #region 商品
                ToolStripDropDownButton costume = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.商品, Properties.Resources.商品);
                costume.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.商品档案, typeof(CostumeManageCtrl), ToolStripMenuItem_Click));

                basicSettings = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.基础资料, typeof(BasicSettingForm), ToolStripMenuItem_Click);
                costume.DropDownItems.Add(basicSettings);
                menuTree.Add(costume);
                #endregion

                #region 会员
                member = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.会员, Properties.Resources.会员);
                member.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.会员管理, typeof(MemberManageCtrl), ToolStripMenuItem_Click));
                member.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.会员消费汇总, typeof(MemberconsumptionSearch), ToolStripMenuItem_Click));
                member.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.会员余额变化, typeof(MemberRechargeRecord), ToolStripMenuItem_Click));
                member.DropDownItems.Add(new ToolStripSeparator());
                member.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.优惠券管理, typeof(MemberGiftTicketCtrl), ToolStripMenuItem_Click));
                menuTree.Add(member);
                #endregion
                //wholesaleAccountSearchCtrlItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.客户往来账, typeof(WholesaleAccountSearchCtrl), ToolStripMenuItem_Click);
                //finances.DropDownItems.Add(wholesaleAccountSearchCtrlItem);
                #region 线上商城
                eMall = MenuItems.ToolStripDropDownButton(RolePermissionMenuEnum.线上商城, Properties.Resources.线上商城, ToolStripMenuItem_Click);
                ShopInfoItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.店铺信息, typeof(EditEmallCtrl), ToolStripMenuItem_Click);
                eMall.DropDownItems.Add(ShopInfoItem);
                ShopManageItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.商品管理, typeof(EmCostumeManageCtrl), ToolStripMenuItem_Click);
                eMall.DropDownItems.Add(ShopManageItem);
                OrderManageItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.订单管理, typeof(EmOrderTabControlCtrl), ToolStripMenuItem_Click);
                eMall.DropDownItems.Add(OrderManageItem);
                toolStripS1 = new ToolStripSeparator();
                eMall.DropDownItems.Add(toolStripS1);

                wholeSaleCenter = MenuItems.NewMenuItem(RolePermissionMenuEnum.分销中心);
                  wholeSaleCenter.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.分销设置, typeof(DistributorSettingCtrl), ToolStripMenuItem_Click));
                wholeSaleCenter.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.层级收益, typeof(LevelSettingCtrl), ToolStripMenuItem_Click));
                wholeSaleCenter.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.分销人员管理, typeof(DistributorCtrl), ToolStripMenuItem_Click));
                //wholeSaleCenter.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.H, typeof(ReceivedPaymentsCtrl), ToolStripMenuItem_Click));
                wholeSaleCenter.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.提现管理, typeof(CashManagementCtrl), ToolStripMenuItem_Click));
                wholeSaleCenter.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.佣金查询, typeof(CommissionTabControlCtrl), ToolStripMenuItem_Click));
                wholeSaleCenter.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.打款管理, typeof(PaymentManageCtrl), ToolStripMenuItem_Click));
                eMall.DropDownItems.Add(wholeSaleCenter);


                toolStripS2 = new ToolStripSeparator();
                eMall.DropDownItems.Add(toolStripS2);
                logisticsManageItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.物流管理, typeof(EmLogisticManageCtrl), ToolStripMenuItem_Click);
                eMall.DropDownItems.Add(logisticsManageItem);
                carriageTemplateItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.运费模板, typeof(EmCarriageCostTemplateCtrl), ToolStripMenuItem_Click);
                eMall.DropDownItems.Add(carriageTemplateItem);

                 //PayMentItem = MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.打款管理, typeof(PaymentManageCtrl), ToolStripMenuItem_Click);
                 //eMall.DropDownItems.Add(PayMentItem);
                menuTree.Add(eMall);
                #endregion 
                //wholesaleMall = MenuItems.ToolStripDropDownButton("批发商城", Properties.Resources.批发商城);
                //wholesaleMall.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.批发商城信息, typeof(WholesaleEmEditEmallCtrl), ToolStripMenuItem_Click));
                //wholesaleMall.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.批发商品管理, typeof(WholesaleEmCostumeManageCtrl), ToolStripMenuItem_Click));
                //wholesaleMall.DropDownItems.Add(MenuItems.NewUserControlMenuItem(RolePermissionMenuEnum.批发订单管理, typeof(WholesaleEmOrderManageCtrl), ToolStripMenuItem_Click));
                //menuTree.Add(wholesaleMall);
                resettlement = MenuItems.ToolStripButton(RolePermissionMenuEnum.重结, Properties.Resources.重结, toolStripButton_resettlement_Click);
                menuTree.Add(resettlement);
                exit = MenuItems.ToolStripButton(RolePermissionMenuEnum.退出, Properties.Resources.退出, toolStripButton_Exit_Click);
                menuTree.Add(exit);
                toolStripLabelExpired = new ToolStripLabel();
                toolStripLabelExpired.BackColor = System.Drawing.Color.White;
                toolStripLabelExpired.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                toolStripLabelExpired.ForeColor = System.Drawing.Color.Red;
                menuTree.Add(toolStripLabelExpired);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            return menuTree.ToArray();
        }

        ToolStripMenuItem wholesaleBeginningStoreCtrlMenuItem;
        ToolStripMenuItem wholesaleBeginningBillCtrlMenuItem;
        ToolStripLabel toolStripLabelExpired;
        ToolStripDropDownButton eMall;
        // ToolStripDropDownButton wholesaleMall;
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal; //this.TopMost = true;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }


        #region 退出
        //点击退出按钮
        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("您确定要退出 " + this.Text + " 吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    toClose = true;
                    this.Close();
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void toolStripButton_resettlement_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                CreateAllReportSelectForm form = new CreateAllReportSelectForm("重结报表", "开始日期：", DateTime.Now, "正在重新结算中……");
                form.ConfirmClick += form_ConfirmClick;
                form.ShowDialog();

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

        String createAllReportParaShopId;
        private DateTime dateTime;
        private void form_ConfirmClick(DateTime dateTime, String shopId, CreateAllReportSelectForm form)
        {

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                this.dateTime = dateTime;
                createAllReportParaShopId = shopId;
                this.createAllReportSelectForm = form;
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoUpdate);
                cb.BeginInvoke(null, null);
                ShowProgressForm();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }

        }


        private void DoUpdate()
        {
            try
            {

                int days = JGNet.Core.Tools.TimeHelper.GetSpanDays(dateTime, DateTime.Now);
                days = days + 1;
                int i = 0;
                InitProgress(days);
                for (i = 0; i < days; i++)
                {
                    if (progressStop)
                    {
                        break;
                    }

                    DateTime oneDate = dateTime.AddDays(i * 1.0);
                    CreateAllReportPara para = new CreateAllReportPara()
                    {
                        Date = new Date(oneDate),
                        ShopId = createAllReportParaShopId
                    };

                    UpdateProgress();
                    InteractResult result = CommonGlobalCache.ServerProxy.CreateAllReport(para);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            break;
                        case ExeResult.Error:
                            FailedProgress(new Exception(result.Msg));
                            CompleteEdit(true);
                            return;
                        // break;
                        default:
                            break;
                    }
                }
                CompleteEdit();
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


        CreateAllReportSelectForm createAllReportSelectForm = null;
        private void CompleteEdit(bool stop = false)
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<bool>(this.CompleteEdit), stop);
            }
            else
            {
                try
                {
                    CompleteProgressForm();
                    if (stop)
                    {
                        createAllReportSelectForm.Cancel();
                    }
                    else
                    {
                        createAllReportSelectForm.SetDialogResult(DialogResult.OK);
                        GlobalMessageBox.Show("重结成功！");
                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        private bool toClose = false;
        #endregion

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(Control.MousePosition.X, Control.MousePosition.Y);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TabPage seletedTab = skinTabControl1.SelectedTab;
            foreach (TabPage item in skinTabControl1.TabPages)
            {
                if (seletedTab != item)
                {
                    if (!(item.Tag != null && (RolePermissionMenuEnum)item.Tag == RolePermissionMenuEnum.工作台))
                    {
                        skinTabControl1.TabPages.Remove(item);
                    }
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (TabPage item in skinTabControl1.TabPages)
            {
                if (!(item.Tag != null && (RolePermissionMenuEnum)item.Tag == RolePermissionMenuEnum.工作台))
                {
                    skinTabControl1.TabPages.Remove(item);
                }
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            TabPage tab = skinTabControl1.SelectedTab;
            if (tab != null)
            {
                if ((tab.Text == "退货" && keyData==Keys.F3)|| (tab.Text == "退货" && keyData == Keys.F4)) {
                    ((RefundTabControlCtrl)tab.Controls[0]).HandleShortKey(ref msg, keyData);
                }
                else
                {
                    ((BaseUserControl)tab.Controls[0]).HandleShortKey(ref msg, keyData);
                }
                //
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            skinToolStripAnounce.Visible = false;
        }

        private void 切换账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoClose(false);
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void CheckStoreClick(CheckStoreOrder checkStoreOrder, BaseUserControl type)
        {
            String tabName = "盘点录入";
            if (checkStoreOrder.State == (int)CheckStoreOrderState.ChildOrder)
            {
                tabName = "编辑子盘点单";
                CheckStoreChildrenCtrl ctrl = new CheckStoreChildrenCtrl(checkStoreOrder);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);

            }
            else
            {
                  CheckStore2019Ctrl ctrl = new CheckStore2019Ctrl(checkStoreOrder);
                BaseModifyUserControl modifyCtrl = ctrl as BaseModifyUserControl;
                ctrl.isFlag = true;
             AddModifyUserControlToTabPage(tabName, ref modifyCtrl, type);
            }
          
        
            // ctrl.LoadEdit();
        }
       
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}