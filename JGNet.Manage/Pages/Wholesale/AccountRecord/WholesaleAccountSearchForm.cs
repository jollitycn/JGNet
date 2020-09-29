using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
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
    public partial class WholesaleAccountSearchForm : BaseForm
    {
        private PfAccountRecord CurItem { get; set; }
        public WholesaleAccountSearchForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Display()
        {
            try
            {
                if (CurItem != null)
                {
                    Initialize();
                    if (readOnly)
                    {
                        this.BaseButtonSave.Visible = false;
                        baseButtonCancel.Visible = false;
                    }

                    this.Text = "收款记录明细";
                    
                    this.skinComboBox_PfCustomer.SelectedValue = CurItem.PfCustomerID;
                    this.skinComboBoxSaveType.SelectedValue = (PfAccountType)CurItem.AccountType;
                    this.numericTextBox1.Value = CurItem.AccountMoney;
                    this.skinTextBoxRemark.Text = CurItem.Remarks;
                    // PayType = (byte)(PfAccountRecordType)
                    this.skinComboBox1.SelectedValue =(PfAccountRecordType) CurItem.PayType;
                    dateTimePicker_Start.Value = CurItem.CreateTime;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void Initialize()
        {  skinComboBox_PfCustomer.Initialize(true, true); 
            SetFeeType(this.skinComboBoxSaveType, readOnly);
            this.numericTextBox1.Value = 0;
            this.skinTextBoxRemark.Text = String.Empty;
            SetPayType();
        }
        //skinComboBox1

        private void SetPayType()
        {
            List<ListItem<PfAccountRecordType>> list = new List<ListItem<PfAccountRecordType>>();
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.WeiXin), PfAccountRecordType.WeiXin));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.Balance), PfAccountRecordType.Balance));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.Alipay), PfAccountRecordType.Alipay));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.BankCard), PfAccountRecordType.BankCard));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.Cash), PfAccountRecordType.Cash));
            list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.Other), PfAccountRecordType.Other));
            this.skinComboBox1.DisplayMember = "Key";
            this.skinComboBox1.ValueMember = "Value";
            this.skinComboBox1.DataSource = list;
        }
        private void SetFeeType(SkinComboBox skinComboBox_FeeType, Boolean readOnly = false)
        {

            List<TKeyValue<String, PfAccountType>> accountTypeList = new List<TKeyValue<string, PfAccountType>>();
            if (readOnly)
            {
                accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.Delivery), PfAccountType.Delivery));
                accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.Return), PfAccountType.Return));
            }
            accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.Collection), PfAccountType.Collection));
            accountTypeList.Add(new TKeyValue<string, PfAccountType>(EnumHelper.GetDescription(PfAccountType.Other), PfAccountType.Other));

            skinComboBox_FeeType.DisplayMember = "Key";
            skinComboBox_FeeType.ValueMember = "Value";
            skinComboBox_FeeType.DataSource = accountTypeList;
        }


        private List<ListItem<String>> ParameterConfigList(List<ListItem<String>> listItems)
        {
            List<ListItem<String>> list = new List<ListItem<String>>();
            //  list.Add(new ListItem<String>(GlobalCache.COMBOX_FIRST_LINE, null));
            list.AddRange(listItems);
            return list;
        }

        Costume item = null;



        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                String supllier = ValidateUtil.CheckEmptyValue(this.skinComboBox_PfCustomer.SelectedValue);
                if (String.IsNullOrEmpty(supllier))
                {
                    skinComboBox_PfCustomer.Focus();
                    GlobalMessageBox.Show("请先选择客户！");
                    return;
                }
                if (numericTextBox1.Value == 0)
                {
                    numericTextBox1.Focus();
                    return;
                }
                if (numericTextBox1.Value >Convert.ToDecimal(99999999.99) )
                {

                    numericTextBox1.Focus();
                    GlobalMessageBox.Show("金额不能大于99999999.99！");
                    return;
                }

                    //if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    //{
                    //    return;

                    //}




                    if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                decimal money = this.numericTextBox1.Value;

                PfAccountRecord record = new PfAccountRecord()
                {
                    AccountMoney = money,
                    AccountType = (byte)(PfAccountType)this.skinComboBoxSaveType.SelectedValue,
                    PfCustomerID = supllier,
                    AdminUserID = GlobalCache.CurrentUserID,
                    Remarks = this.skinTextBoxRemark.SkinTxt.Text,
                    PayType = (byte)(PfAccountRecordType)this.skinComboBox1.SelectedValue, // skinRadioButtonOther.Checked? (byte)PfAccountRecordType.Other: (byte)PfAccountRecordType.Balance,
                    CreateTime = dateTimePicker_Start.Value
                };
                if (CurItem != null)
                {
                    UpdatePfAccountRecordPara para = new UpdatePfAccountRecordPara()
                    {
                        ID = CurItem.AutoID,
                        AccountMoney = record.AccountMoney, 
                        PfCustomerID = record.PfCustomerID, 
                        PfAccountType = (PfAccountType)record.AccountType,
                        CreateTime = record.CreateTime,
                        Remarks = record.Remarks,
                         PayType=(PfAccountRecordType) this.skinComboBox1.SelectedValue,

                    };
                    InteractResult result = GlobalCache.ServerProxy.UpdatePfAccountRecord(para);

                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("修改成功！");
                            // this.ReLoad(); 
                            this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                    InteractResult result = GlobalCache.ServerProxy.InsertPfAccountRecord(record);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("登记成功！");
                            //PfCustomerCache.Load();
                            //skinComboBox_PfCustomer.Initialize(true, true);
                            //this.ReLoad();
                            this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
            finally
            {
                numericTextBox1.SkinTxt.Text = string.Empty;
                this.skinTextBoxRemark.SkinTxt.Text = string.Empty;
                GlobalUtil.UnLockPage(this);
            }
        }



        private bool Validate(Costume item)
        {
            bool success = true;
            if (String.IsNullOrEmpty(this.skinComboBox_PfCustomer.SelectedValue?.ToString()))
            {
                skinComboBox_PfCustomer.Focus();
                success = false;
                GlobalMessageBox.Show("请选择客户！");
            }

            return success;
        }

        bool readOnly = false;
        internal DialogResult ShowDialog(PfAccountRecord item,bool readOnly)
        {
            this.readOnly = readOnly;
            this.CurItem = item;
            Display();
           return this.ShowDialog();
        }

        public void ShowNew(Control parent)
        {
            try
            {
                this.TopMost = true;
                this.ShowDialog(parent);
                //ctrl.Search(para);
                this.TopMost = false;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }


        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierAccountSearchForm_Shown(object sender, EventArgs e)
        {
            if (CurItem != null)
            {
                if (readOnly)
                {
                    skinPanel1.Enabled = false;
                }
                //this. = false;
            }
        }

        PfCustomer pfCustomer;
        private void skinComboBox_PfCustomer_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;
          //  skinLabel4.Text = obj?.Balance.ToString();
        }
         
    }
}
