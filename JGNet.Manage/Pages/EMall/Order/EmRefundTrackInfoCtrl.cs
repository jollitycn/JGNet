using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JGNet.Common.Core;
using JGNet.Core.Dev.InteractEntity;
using JGNet.Core.Tools;
using CJBasic.Helpers;
using JGNet.Common;

namespace JGNet.Manage.Pages
{
    public partial class EmRefundTrackInfoCtrl : BaseUserControl
    {
        private EmRefundTrackInfo EmRefundTrackInfo { get; set; }
        public EmRefundTrackInfoCtrl(EmRefundTrackInfo info)
        {
            InitializeComponent();
            this.EmRefundTrackInfo = info;
            skinLabel5.Text = info.Title;
            skinLabelMsg.Text = info.Msg;
            this.skinLabel6.Text = info.DateTime.ToString(DateTimeUtil.FULL_DATETIME_FORMAT);
        }
    }
}
