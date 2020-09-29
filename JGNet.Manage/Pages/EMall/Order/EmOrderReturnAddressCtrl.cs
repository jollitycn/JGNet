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
using JGNet.Manage.Components;

namespace JGNet.Manage.Pages
{
    public partial class EmOrderReturnAddressCtrl : BaseUserControl
    {
        public EmRefundAddress Address { get; set; }
        public Action<EmOrderReturnAddressCtrl> Selected;
        public Action<EmOrderReturnAddressCtrl> Removed;
        public Action<EmOrderReturnAddressCtrl> Updated;
        public EmOrderReturnAddressCtrl(EmRefundAddress addr)
        {
            InitializeComponent();
            this.Address = addr;

            Display();
            if (addr.IsDefault)
            {
                skinRadioButton1.Checked = true;
            }
        }

        private void Display()
        {
            skinRadioButton1.Text = Address.Name + " " + Address.Telphone + " " + Address.CityZone + " " + Address.DetailAddress;
        }

        public void SetRadio(bool selected) {
            skinRadioButton1.Checked = selected;
        } 
        




        private void skinRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (skinRadioButton1.Checked) {
                Selected?.Invoke(this);
                linkLabel2.Visible = false;
            }
            else
            {
                linkLabel2.Visible = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                Removed?.Invoke(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            EmOrderNewAddressForm form
                = new EmOrderNewAddressForm(this.Address);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Address = form.result;
                if (Address != null)
                {
                    Display();
                    Updated?.Invoke(this);
                }
            }
        }
    }
}
