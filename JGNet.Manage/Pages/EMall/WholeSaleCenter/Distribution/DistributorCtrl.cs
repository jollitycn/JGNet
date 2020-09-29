using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms; 
using JGNet.Core.InteractEntity;
using CCWin;
using JGNet.Core;
using CJBasic.Loggers;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Server.Tools;
using JGNet.Common.Core;

namespace JGNet.Manage
{
    public partial class DistributorCtrl : Common.Core.BaseModifyUserControl
    {
        
        public DistributorCtrl()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.分销人员管理;
            // CommonGlobalCache.IsGeneralStoreRetail;
            // CommonGlobalCache.GetParameterConfig("")
            if (CommonGlobalCache.BusinessAccount.OnlineType == 1)
            {
                tabPage1.Visible = true;
                tabPage2.Visible = false;
                this.tabControl1.Controls.Remove(tabPage2);
               // this.tabControl1.Controls.Add(this.tabPage1);
                //this.tabControl1.Controls.Add(this.tabPage2);
            }
            else if (CommonGlobalCache.BusinessAccount.OnlineType == 2)
            {
                this.tabControl1.Controls.Remove(tabPage1);
                tabPage1.Visible = false;
                tabPage2.Visible = true;

            }
            //else
            //{
            //    tabPage2.Visible = true;
            //    tabPage1.Visible = true;
            //}
        } 

    }
}
