using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Core;

namespace JGNet.Manage.Components
{
    public partial class ClassComboBox : ParameterConfigComboBoxCtrl
    {
        String title = "类别";
        public ClassComboBox()
        {
            InitializeComponent();
            Initialize();
        } 

        public new void Initialize()
        {
          //  Initialize(ParameterConfigKey.Season, title, ParameterConfigList(GlobalCache.GetParameterConfig(ParameterConfigKey.Season)),title);
        }
    }
}
