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
    public partial class EmOrderTabControlCtrl : Common.Core.BaseModifyUserControl
    {


        public EmOrderTabControlCtrl()
        {
            this.refundCtrl1 = (GlobalUtil.MainForm as MainForm).GetUserControl(typeof(EmOrderManageCtrl), 0) as EmOrderManageCtrl;
            this.refundDirectCtrl1 = (GlobalUtil.MainForm as MainForm).GetUserControl(typeof(WholesaleEmOrderManageCtrl), 0) as WholesaleEmOrderManageCtrl;
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.订单管理;
        } 

    }
}
