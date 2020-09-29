using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common.Components
{
    public partial class SizeGroupSelector : UserControl
    {
        List<TitleImage> images = new List<TitleImage>(); 

        public SizeGroupSelector() {
            InitializeComponent(); 
        }

        private void SizeGroupSelector_Load(object sender, EventArgs e)
        {

        }
    }
}
