using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class SupplierDiscountForm : 
        BaseForm
    {
        private decimal result;
        public decimal Result { get { return result; } } 

        public SupplierDiscountForm()
        {
            InitializeComponent();
            Initialize();

        }
        private void Initialize() {

            List<ListItem<string>>  config = GlobalCache.GetParameterConfig(ParameterConfigKey.SupplierDiscount);
            if (config != null && config.Count > 0)
            {
                this.numericUpDownSupplierDiscount.Value = Convert.ToDecimal(config[0].Value);
                skinLabelDefault.Text = config[0].Value;
            }
            else
            {
                this.numericUpDownSupplierDiscount.Value = 1;
                skinLabelDefault.Text = "1";
            }
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {


            try
            {//调用服务修改积分信息 
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

               // GlobalUtil.SaveParameters(ParameterConfigKey.IntegrationExchange, this.numericUpDownIntegral.Value.ToString());
               // GlobalUtil.SaveParameters(ParameterConfigKey.MoneyExchange, this.numericUpDownMoneyExchange.Value.ToString());
                GlobalUtil.SaveParameters(ParameterConfigKey.SupplierDiscount, this.numericUpDownSupplierDiscount.Value.ToString());
              //  GlobalMessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
            this.result = this.numericUpDownSupplierDiscount.Value;
            this.DialogResult = DialogResult.OK;

        }
         
          
 
    }
}
