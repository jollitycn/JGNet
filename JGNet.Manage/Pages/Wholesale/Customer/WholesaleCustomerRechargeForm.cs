using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
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
    public partial class WholesaleCustomerRechargeForm :
        BaseForm
    {

        public WholesaleCustomerRechargeForm()
        {
            InitializeComponent();
            skinLabelName.Text = string.Empty;
            skinLabelBalance.Text = string.Empty;
            textBoxCustomer.Initialize(true, true);
        }

        public Action<PfCustomerRechargeRecord> PfCustomerRechargeRecordSuccess;

        private void BaseButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.bean == null) {
                    GlobalMessageBox.Show(this,"找不到客户信息");
                    this.textBoxCustomer.Focus();
                    return; 
                }

                if (this.textBoxAmount.Value == 0)
                {
                    GlobalMessageBox.Show(this, "请输入金额");
                    this.textBoxAmount.Focus();
                    return;
                }

                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }


                PfCustomerRechargeRecord pfCustomerRechargeRecord = new PfCustomerRechargeRecord()
                {
                    BalanceOld = this.bean.Balance,
                    BalanceNew = this.bean.Balance + decimal.ToInt32(textBoxAmount.Value),
                    ID = IDHelper.GetID(OrderPrefix.PfCustomerRechargeRecord, CommonGlobalCache.CurrentShop.AutoCode),
                    //  BalanceOld = 
                    Remarks = richTextBoxRemark.Text,
                    PfCustomerID = bean.ID,
                    CreateTime = DateTime.Now,
                    RechargeMoney = decimal.ToInt32(textBoxAmount.Value)
                };

                InteractResult result = GlobalCache.ServerProxy.InsertPfCustomerRechargeRecord(pfCustomerRechargeRecord);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show(this.FindForm(), "添加成功！");
                        this.bean.Balance = pfCustomerRechargeRecord.BalanceNew;
                        //TabPageClose(this.CurrentTabPage, this.SourceCtrlType);
                        PfCustomerRechargeRecordSuccess?.Invoke(pfCustomerRechargeRecord);
                        this.Close();
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(this.FindForm(), result.Msg);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }


        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private PfCustomer bean;
        private void textBoxCustomer_ItemSelected(PfCustomer bean)
        {
            this.bean = bean;
            if (bean != null)
            {
                if (bean.ID == "" || bean.ID==null)
                {
                    ShowMessage("该客户不存在，请重新选择！");
                }
                else
                {
                    skinLabelBalance.Text = bean?.Balance.ToString();
                    skinLabelName.Text = bean?.Name.ToString();
                }
            }
        }

        private void textBoxCustomer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
