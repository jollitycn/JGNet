using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using CJBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class EmOrderReturnSuccessForm :
        BaseForm
    { 
        private EmRetailOrder Order { get; set; }

        public EmOrderReturnSuccessForm(EmRetailOrder order)
        {
            InitializeComponent();
            this.Order = order;
            GlobalUtil.SetShop(skinComboBoxShopID, true);
            GlobalUtil.SetLogisticCompany(skinTextBoxLogisticCompany);
            //加载设置默认物流公司

            LoadConfig();

        }

        private void LoadConfig()
        {
            try
            {
                config = EmExpressCompanyAgileConfiguration.Load(CONFIG_PATH) as EmExpressCompanyAgileConfiguration;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.WriteLog(ex);
            }
            if (config == null) { config = new EmExpressCompanyAgileConfiguration(); }
            else
            {
                skinTextBoxLogisticCompany.SelectedValue = config.EmExpressCompany;
            }
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void BaseButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (skinRadioButtonOnline.Checked)
                {

                    if (String.IsNullOrEmpty(ValidateUtil.CheckEmptyValue(this.skinTextBoxLogisticCompany.SelectedValue)))
                    {
                        //  GlobalMessageBox.Show("物流公司不能为空");
                        skinTextBoxLogisticCompany.Focus();
                        return;

                    }
                    if (String.IsNullOrEmpty(this.skinTextBoxLogisticId.Text))
                    {
                        //   GlobalMessageBox.Show("单号不能为空");
                        skinTextBoxLogisticId.Focus();
                        return;

                    }

                    if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!GlobalUtil.EngineUnconnectioned(this))
                        {

                            CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.GetInfo);
                            cb.BeginInvoke(null, null);
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

         
        private void GetInfo()
        {
            try
            {
                 
                EmOutboundPara para = new EmOutboundPara()
                {
                    ShopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue),
                    EmRetailOrderID = Order.ID,
                    ExpressCompany = skinRadioButtonOnline.Checked ? ValidateUtil.CheckEmptyValue(skinTextBoxLogisticCompany.SelectedValue) : null,
                    ExpressOrderID = skinRadioButtonOnline.Checked ? skinTextBoxLogisticId.Text:null,
                };
                if (skinRadioButtonOnline.Checked)
                {
                    bool rightExpress = KuaiDi100Helper.CheckKuaiDi(GlobalUtil.GetExpressCode(this, para.ExpressCompany), para.ExpressOrderID);

                    if (!rightExpress)
                    {
                        ShowMessage("单号不存在或者已过期！");
                        return;
                    }
                }

                InteractResult result = GlobalCache.EMallServerProxy.EmOutbound(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        ShowMessage("发货成功！");
                        if (skinRadioButtonOnline.Checked)
                        {
                            EmExpressCompany company = skinTextBoxLogisticCompany.SelectedItem as EmExpressCompany;
                            config.EmExpressCompany = company;
                            config.Save(CONFIG_PATH);
                        }
                        CloseFormAndRefresh(para);
                        SetDialogResult(DialogResult.OK);
                        break;
                    case ExeResult.Error:
                        ShowMessage(result.Msg);
                        break;
                    default:
                        break;
                }

            }
            catch (KuaiDiException ex)
            {
                ShowErrorMessage(ex.Message);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void SetDialogResult(DialogResult result)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<DialogResult>(this.SetDialogResult), result);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CloseFormAndRefresh(EmOutboundPara para)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<EmOutboundPara>(this.CloseFormAndRefresh),para);
            }
            else
            {
                RefreshPageAction?.Invoke(para);
                this.Close();
            }
        }
        public Action<EmOutboundPara> RefreshPageAction;

        public static String CONFIG_PATH = CommonGlobalUtil.AgileConfiguration("Manage.LatestEmExpressCompany");
        EmExpressCompanyAgileConfiguration config = null;
    }
}
