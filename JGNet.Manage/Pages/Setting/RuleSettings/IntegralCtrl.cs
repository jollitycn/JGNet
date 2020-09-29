using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common;

namespace JGNet.Manage.Pages.RuleSettings
{
    public partial class IntegralCtrl : BaseUserControl
    {

        public IntegralCtrl()
        {
            InitializeComponent();

        }

        public void BaseButtonSave_Click(object sender, EventArgs e)
        {
            //try
            //{//调用服务修改积分信息 
            //    if (GlobalUtil.EngineUnconnectioned(this))
            //    {
            //        return;
            //    } 

                GlobalUtil.SaveParameters(ParameterConfigKey.IntegrationExchange, this.numericUpDownIntegral.Value.ToString());
                GlobalUtil.SaveParameters(ParameterConfigKey.MoneyExchange, this.numericUpDownMoneyExchange.Value.ToString());
                GlobalUtil.SaveParameters(ParameterConfigKey.SupplierDiscount, this.numericUpDownSupplierDiscount.Value.ToString());
                //GlobalMessageBox.Show("保存成功！");
            //}
            //catch (Exception ex)
            //{
            //    GlobalUtil.ShowError(ex);
            //}
            //finally
            //{
            //    GlobalUtil.UnLockPage(this);
            //}
        }

        private void integralCtrl_Load(object sender, EventArgs e)
        {
            //获取积分参数信息并绑定文本

            List<ListItem<string>> config = GlobalCache.GetParameterConfig(ParameterConfigKey.IntegrationExchange);
            if (config != null && config.Count > 0)
            {
                this.numericUpDownIntegral.Value = Convert.ToDecimal(config[0].Value);
            }
            else
            {
                this.numericUpDownIntegral.Value = 0;
            }
            config = GlobalCache.GetParameterConfig(ParameterConfigKey.MoneyExchange);
            if (config != null && config.Count > 0)
            {
                this.numericUpDownMoneyExchange.Value = Convert.ToDecimal(config[0].Value);
            }
            else
            {
                this.numericUpDownMoneyExchange.Value = 100;
            }
            config = GlobalCache.GetParameterConfig(ParameterConfigKey.SupplierDiscount);
            if (config != null && config.Count > 0)
            {
                this.numericUpDownSupplierDiscount.Value = Convert.ToDecimal(config[0].Value);
            }
            else
            {
                this.numericUpDownSupplierDiscount.Value = 1;
            }
        }
    }
}
