using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.InteractEntity;
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
    public partial class WholesaleAccountRecordRefundForm :
        BaseForm
    {
        private int result = (int)PfAccountRecordType.Other;
        public int Result { get { return result; } }
        private PfCustomer customer;
        private decimal sumPfMoney;
        public WholesaleAccountRecordRefundForm(PfCustomer customer,decimal sumPfMoney)
        {
            InitializeComponent(); 
            this.customer = customer;
            this.sumPfMoney = sumPfMoney;
            Initialize();

        }
        private void Initialize()
        {


        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {


            try
            {//调用服务修改积分信息 
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }



                int selectType = Result;

                switch (selectType)
                {
                    case 0:
                        //记账 
                        break;

                    case 1: 
                        break;

                    case 2:
                      //  result = true;
                        break;
                    default:
                        break;
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

            this.DialogResult = DialogResult.OK;

        }

        private bool CheckBalance()
        {
            return PfCustomerCache.GetPfCustomer(customer.ID).Balance >= sumPfMoney;
        }

        private void skinRadioButtonBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (skinRadioButtonBalance.Checked)
            {
                this.result = (int)PfAccountRecordType.Balance;
            }
        }

        private void skinRadioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            if (skinRadioButtonCash.Checked)
            {
                this.result = (int)PfAccountRecordType.Other;
            }
        }
    }
}
