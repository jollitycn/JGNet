using System;
using System.Collections.Generic; 
using System.Windows.Forms;  
using JGNet.Common.Core;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;

namespace JGNet.Manage

{
    public partial class ReceivedPaymentsCtrl : BaseUserControl
    {
        public ReceivedPaymentsCtrl()
        {
            InitializeComponent();
            skinComboBox_PfCustomer.Initialize(true, true);
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            // this.AddClick(null, this);
            SaveDistributorForm form = new SaveDistributorForm(null);
            // form.
            form.ShowDialog();
        }

        private void NewOffline(Distributor item)
        {
           /* SaveOffLineCustomerForm form = new SaveOffLineCustomerForm(item);
            form.ShowDialog();*/
        }

        private void Edit(Distributor item)
        {
            throw new NotImplementedException();
        }

        private void OfflineCustomers(Distributor item)
        {
            OffLineCustomerListForm form = new OffLineCustomerListForm(item);
            form.ShowDialog();
        }

        PfCustomer pfCustomer;
        private void textBoxCustomer_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;
        }

        private void BaseButton3_Click(object sender, EventArgs e)
        {

            try
            {

                if (pfCustomer == null)
                {
                    GlobalMessageBox.Show("客户不存在，请重新选择！");
                    skinComboBox_PfCustomer.Focus();
                    return;
                }
                if (textBoxAmount.Value == 0)
                {
                    GlobalMessageBox.Show("请输入回款金额！");
                    textBoxAmount.Focus();
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }

                PfAccountRecord record = new PfAccountRecord()
                {
                    PfCustomerID = pfCustomer.ID,
                    CreateTime = dateTimePicker_End.Value,
                    AccountMoney = -textBoxAmount.Value
                };
                InsertResult result = GlobalCache.ServerProxy.InsertPfAccountRecord4Fx(record);

                switch (result)
                {
                    case InsertResult.Success:
                        GlobalMessageBox.Show("录入成功！");
                        //清空dataGirdView1的绑定源 
                        textBoxAmount.Text = string.Empty;
                        skinComboBox_PfCustomer.Text = null;
                        break;
                    case InsertResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }
    }
}
