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
    public partial class WholesaleBeginningControlCtrl : Common.Core.BaseModifyUserControl
    {
        public WholesaleBeginningControlCtrl()
        {
            InitializeComponent();
            if (!HasPermission(RolePermissionEnum.导入))
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
            MenuPermission = RolePermissionMenuEnum.客户期初库存录入;
        }
    }
}
