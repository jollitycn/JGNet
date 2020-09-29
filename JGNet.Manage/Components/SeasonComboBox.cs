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
    public partial class SeasonComboBox : ParameterConfigComboBoxCtrl 
    {


        private Boolean showAll;
        public Boolean ShowAll
        {
            get { return this.showAll; }
            set
            {
                showAll = value;
            }
        } 

        public SeasonComboBox()
        {
            InitializeComponent();
            this.Title = "季节";
            this.Load += SeasonComboBox_Load;
        }

        private void SeasonComboBox_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        public object SelectedValue
        {
            get
            {
                return this.skinComboBox.SelectedValue;
            }
            set { this.skinComboBox.SelectedValue = value; }
        }

        public void Initialize()
        {

            //显示， 不显示 ，第一次加载的时候不加载，切换成
            //if (showAll)
            //{
            Initialize(ParameterConfigKey.Season, showAll, ParameterConfigList(GlobalCache.GetParameterConfig(ParameterConfigKey.Season)));
            // }
        }

        private void SeasonComboBox_SizeChanged(object sender, EventArgs e)
        {
            if (this.skinLabelAdd.Visible)
            {
                this.skinComboBox.Width = this.Width - this.skinLabelAdd.Width;
            }
            else
            {
                this.skinComboBox.Width = this.Width - 5;
            }
        }
    }
}
