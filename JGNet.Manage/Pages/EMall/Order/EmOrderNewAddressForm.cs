using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Common.Models;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using CJBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class EmOrderNewAddressForm :
        BaseForm
    { 
        public EmRefundAddress result { get; internal set; }
        private EmRefundAddress editAddress;
        private void SetLogisticCompany(SkinComboBox skinTextBoxLogisticCompany)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<EmExpressCompany> list = new List<EmExpressCompany>();

                list = GlobalCache.EMallServerProxy.GetEnabledEmExpressCompanys(); 
                if (list != null)
                {
                    skinTextBoxLogisticCompany.DisplayMember = "ExpressCompanyName";
                    skinTextBoxLogisticCompany.ValueMember = "ExpressCompanyName";
                    skinTextBoxLogisticCompany.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        } 

        public EmOrderNewAddressForm(EmRefundAddress address )
        {
            InitializeComponent();

            string jsonText = File.ReadAllText(@"CitySelectForm.dat");
            resultList = (List<Zone>)JavaScriptConvert.DeserializeObject(jsonText, typeof(List<Zone>));
            List<Province> provinces = new List<Province>();
            foreach (var zone in resultList)
            {
                provinces.AddRange(zone.Province);
            }
            skinComboBoxProvince.DisplayMember = "Name";
            skinComboBoxProvince.ValueMember = "Name";
            skinComboBoxProvince.DataSource = provinces;


            Display(address);

        }

        private void Display(EmRefundAddress address)
        {
            if (address != null)
            {
                this.editAddress = address;
                textBox1.Text = address.Name;
                skinCheckBox1.Checked = address.IsDefault;
                textBoxDetailAddr.Text = address.DetailAddress;
                skinTextBoxHotline.Text = address.Telphone;
                if (address.CityZone != null)
                {
                    String[] addresses = address.CityZone.Split('-');
                    if (addresses.Length >= 3)
                    {
                        skinComboBoxProvince.SelectedValue = addresses[0];
                        skinComboBoxCity.SelectedValue = addresses[1];
                        skinComboBoxCityArea.SelectedValue = addresses[2];
                    }
                }
            }
        }

        private void BaseButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text)) {
                    GlobalMessageBox.Show("收货人不能为空！");
                    textBox1.Focus();
                    return;
                } else if (String.IsNullOrEmpty(skinTextBoxHotline.Text))
                {
                    GlobalMessageBox.Show("电话号码不能为空！");
                    skinTextBoxHotline.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(skinTextBoxHotline.Text))
                {
                    GlobalMessageBox.Show("详细地址不能为空！");
                    skinTextBoxHotline.Focus();
                    return;
                }
                result = new EmRefundAddress()
                {
                    CityZone = skinComboBoxProvince.SelectedValue + "-" + skinComboBoxCity.SelectedValue + "-" + skinComboBoxCityArea.SelectedValue,
                    Name = textBox1.Text,
                    IsDefault = skinCheckBox1.Checked,
                    DetailAddress = textBoxDetailAddr.Text,
                    Telphone = skinTextBoxHotline.Text,
                };

                if (editAddress != null) {
                    result.AutoID = editAddress.AutoID;
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

         

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private List<Zone> resultList;//当前被绑定的源 
        private void EmOrderNewAddressForm_Load(object sender, EventArgs e)
        {
         
        }

        private void skinComboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            Province p = skinComboBoxProvince.SelectedItem as Province;
            skinComboBoxCity.DisplayMember = "Name";
            skinComboBoxCity.ValueMember = "Name";
            skinComboBoxCity.DataSource = p.Sub;
            skinComboBoxCity_SelectedIndexChanged(null, null);
        }

        private void skinComboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            City p = skinComboBoxCity.SelectedItem as City;
            skinComboBoxCityArea.DisplayMember = "Name";
            skinComboBoxCityArea.ValueMember = "Name";
            skinComboBoxCityArea.DataSource = p.Sub;

        }
         
    }
}
