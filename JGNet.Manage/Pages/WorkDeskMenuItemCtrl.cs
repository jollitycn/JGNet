using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core.InteractEntity;

using CCWin;
using JGNet.Common.Core;  
using JGNet.Manage.Components;
using JGNet.Common;
using JGNet.Common.Components;

namespace JGNet.Manage
{
    public partial class WorkDeskMenuItemCtrl : BaseUserControl
    {
        public event CJBasic.Action<JGNet.Common.Components.WorkDeskMenuItem, EventArgs> MenuItemClick;
        public WorkDeskMenuItemCtrl()
        {
            InitializeComponent();
            menuItem8.Tag = RolePermissionMenuEnum.收银;
            workDeskMenuItem2.Tag = RolePermissionMenuEnum.退货;
            workDeskMenuItem1.Tag = RolePermissionMenuEnum.采购进货;
            menuItem14.Tag= RolePermissionMenuEnum.采购退货;
            menuItem1.Tag = RolePermissionMenuEnum.调拨;
            workDeskMenuItem3.Tag= RolePermissionMenuEnum.盘点录入;
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                MenuItemClick?.Invoke(sender as WorkDeskMenuItem, null);
            }
            catch (Exception ex) { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }


        OperationInfoForm form = null;
        /// <summary>
        /// 实时运营信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem11_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (form == null)
                {
                    form = new OperationInfoForm();
                }
                form.Search();

            }
            catch (Exception ex) { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }


        public void UpdatePermisson()
        {
            UserInfo user = CommonGlobalCache.CurrentUser;
            List<int> permissons = user.RolePermissions;
            foreach (var item in skinFlowLayoutPanel1.Controls)
            {
                if (item is WorkDeskMenuItem)
                {
                    WorkDeskMenuItem mi = item as WorkDeskMenuItem;
                    mi.Enabled = PermissonUtil.HasMenuPermisson(CommonGlobalCache.CurrentUser, mi.Tag);
                }
            }
        }

        private void WorkDeskMenuItemCtrl_Load(object sender, EventArgs e)
        {
            if (CommonGlobalCache.BusinessAccount.OnlineEnabled && !CommonGlobalCache.BusinessAccount.ERPEnabled)
            {
                this.skinFlowLayoutPanel1.Visible = false;
            }
                UpdatePermisson();
           
        } 
    }
}
