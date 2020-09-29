using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Common.Components;
using JGNet.Common;
using CCWin.SkinControl;

namespace JGNet.Manage.Components
{
    public partial class YearComboBox : SkinComboBox
    {
        private Boolean hideAll;
        public Boolean HideAll
        {
            get { return this.hideAll; }
            set
            {
                this.hideAll = value;
                // Initialize();
            }
        }

        public void Initialize()
        {
            CommonGlobalUtil.SetYear(this, hideAll);
        }

        public void Initialize(Boolean hideAll)
        {
            this.hideAll = hideAll;
            CommonGlobalUtil.SetYear(this, hideAll);
        }

        public YearComboBox()
        {
            InitializeComponent();
            // Initialize();
        }
    }
}
