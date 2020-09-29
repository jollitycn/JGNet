using CCWin.SkinControl;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common.Components
{
    public partial class EmOrderDeliverForm2 : BaseForm
    { 
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
        private void skinRadioButtonOffline_CheckedChanged(object sender, EventArgs e)
        {
            skinLabelLogisticCompany.Visible = skinRadioButtonOnline.Checked;
            skinTextBoxLogisticCompany.Visible = skinRadioButtonOnline.Checked;
            skinTextBoxLogisticId.Visible = skinRadioButtonOnline.Checked;
            skinLabelLogisticId.Visible = skinRadioButtonOnline.Checked;
        }

        private void skinRadioButtonOnline_CheckedChanged(object sender, EventArgs e)
        {
            skinLabelLogisticCompany.Visible = skinRadioButtonOnline.Checked;
            skinTextBoxLogisticCompany.Visible = skinRadioButtonOnline.Checked;
            skinTextBoxLogisticId.Visible = skinRadioButtonOnline.Checked;
            skinLabelLogisticId.Visible = skinRadioButtonOnline.Checked;
        }
        private EmOutboundPara result;
        public EmOutboundPara Result { get { return result; } }
        private EmRetailOrder Order { get; set; }
        public EmOrderDeliverForm2(EmRetailOrder order)
        {
            InitializeComponent();
            this.Order = order;
            GlobalUtil.SetShop(skinComboBoxShopID, true);
            SetLogisticCompany(skinTextBoxLogisticCompany);
            //加载设置默认物流公司

            LoadConfig();
        }
        private void LoadConfig()
        {
            try {  
            config = EmCarriageCostTemplateAgileConfiguration.Load(CONFIG_PATH) as EmExpressCompanyAgileConfiguration;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.WriteLog(ex);
            }
            if (config == null) {
                config = new EmExpressCompanyAgileConfiguration()
                {
                    EmExpressCompany = (EmExpressCompany)skinTextBoxLogisticCompany.SelectedItem
                };
            }
            else
            {
                skinTextBoxLogisticCompany.SelectedValue = config.EmExpressCompany.ExpressCompanyName;
            }
        }

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButton1_Click(null, null);
            }
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
         
            if (skinRadioButtonOnline.Checked)
            {

                if (String.IsNullOrEmpty(ValidateUtil.CheckEmptyValue(this.skinTextBoxLogisticCompany.SelectedValue)))
                {
                GlobalMessageBox.Show("物流公司不能为空");
                    skinTextBoxLogisticCompany.Focus();
                    return;

                }
                if (String.IsNullOrEmpty(this.skinTextBoxLogisticId.Text))
                {
                     GlobalMessageBox.Show("单号不能为空");
                    skinTextBoxLogisticId.Focus();
                    return;
                }
            }
            result = new EmOutboundPara()
            {
                ShopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue),
                EmRetailOrderID = Order.ID,
                ExpressCompany = skinRadioButtonOnline.Checked ? ValidateUtil.CheckEmptyValue(skinTextBoxLogisticCompany.SelectedValue) : null,
                ExpressOrderID = skinRadioButtonOnline.Checked ? skinTextBoxLogisticId.Text : null,
            };
            if (skinRadioButtonOnline.Checked)
            {
                EmExpressCompany company = skinTextBoxLogisticCompany.SelectedItem as EmExpressCompany;
                config.EmExpressCompany = company;
                config.Save(CONFIG_PATH);
            }
            this.DialogResult = DialogResult.OK;

        }

        public static String CONFIG_PATH = CommonGlobalUtil.AgileConfiguration("Manage.LatestEmExpressCompany");
        EmExpressCompanyAgileConfiguration config = null;

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
