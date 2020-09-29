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
using CJBasic.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;

using System.Windows.Forms;
using EnumHelper = JGNet.Core.Tools.EnumHelper;

namespace JGNet.Manage.Components
{
    public partial class SupplierAccountSearchForm : BaseForm
    {
        private SupplierAccountRecord CurItem { get; set; }
        public SupplierAccountSearchForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        public void Display()
        {
            try
            {
                if (CurItem != null)
                {
                    if (readOnly)
                    {
                        this.BaseButtonSave.Visible = false;
                        baseButtonCancel.Visible = false;
                    }

                    this.Text = "付款记录明细";
                    this.skinComboBoxSaveSupplier.SelectedValue = CurItem.SupplierID;
                    this.skinComboBoxSaveType.SelectedValue = (AccountType)CurItem.AccountType;
                    this.numericTextBox1.Value = CurItem.AccountMoney;
                    this.skinTextBoxRemark.Text = CurItem.Remarks;
                    this.skinComboBox1.SelectedValue =(SupplierAccountRecordPayType) CurItem.PayType;
                    dateTimePicker_Start.Value = CurItem.CreateTime;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }


        private void Initialize()
        {
          //  GlobalUtil.SetSupplier(this.skinComboBoxSaveSupplier, true);
            SetFeeType(this.skinComboBoxSaveType, true);
            SetPayType();
            this.numericTextBox1.Value = 0;
            numericTextBox1.MinNum = Int32.MinValue;
            this.skinTextBoxRemark.Text = String.Empty;
        }


        private void SetPayType()
        {
            List<ListItem<SupplierAccountRecordPayType>> list = new List<ListItem<SupplierAccountRecordPayType>>();
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.WeiXin), SupplierAccountRecordPayType.WeiXin));
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.Alipay), SupplierAccountRecordPayType.Alipay));
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.BankCard), SupplierAccountRecordPayType.BankCard));
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.Cash), SupplierAccountRecordPayType.Cash)); 
            list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.Other), SupplierAccountRecordPayType.Other));
            this.skinComboBox1.DisplayMember = "Key";
            this.skinComboBox1.ValueMember = "Value";
            this.skinComboBox1.DataSource = list;
        }
        
        private void SetFeeType(SkinComboBox skinComboBox_FeeType, Boolean isSave = false)
        {

            List<TKeyValue<String, AccountType>> accountTypeList = new List<TKeyValue<string, AccountType>>();
            if (!isSave)
            {
                accountTypeList.Add(new TKeyValue<string, AccountType>(GlobalUtil.COMBOBOX_ALL, AccountType.All));
                accountTypeList.Add(new TKeyValue<string, AccountType>("进货", AccountType.Purchase));
                accountTypeList.Add(new TKeyValue<string, AccountType>("退货", AccountType.Return));
            }
            accountTypeList.Add(new TKeyValue<string, AccountType>("采购付款", AccountType.PurchaseCollection));
            accountTypeList.Add(new TKeyValue<string, AccountType>("其他", AccountType.Other));

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


        private bool isChangeSupplierOrType(SupplierAccountRecord SupplierARecord)
        {
            byte tempAccountType = (byte)(AccountType)this.skinComboBoxSaveType.SelectedValue;
            if (SupplierARecord.SupplierID !=  this.skinComboBoxSaveSupplier.SelectedValue.ToString() || tempAccountType != CurItem.AccountType)
            {
                return true;
            }
            return false;
        }
        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            try
            {


                String supllier = ValidateUtil.CheckEmptyValue(this.skinComboBoxSaveSupplier.SelectedValue);
                if (String.IsNullOrEmpty(supllier))
                {
                    skinComboBoxSaveSupplier.Focus();
                    GlobalMessageBox.Show("请先选择供应商！");
                    return;
                }
                if (numericTextBox1.Value == 0)
                {
                    numericTextBox1.Focus();
                    return;
                }
                else
                {
                    if (numericTextBox1.Value > Convert.ToDecimal(99999999.99))
                    {
                        numericTextBox1.Focus();
                        GlobalMessageBox.Show("金额不能大于99999999.99！");
                        return;
                    }
                }

                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;

                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                decimal money = this.numericTextBox1.Value;

                SupplierAccountRecord record = new SupplierAccountRecord()
                {
                    CreateTime = dateTimePicker_Start.Value,
                    EntryTime = DateTime.Now,
                    AccountMoney = money,
                    AccountType = (byte)(AccountType)this.skinComboBoxSaveType.SelectedValue,
                    //SupplierID = supllier,
                    SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBoxSaveSupplier.SelectedValue),
                    AdminUserID = GlobalCache.CurrentUserID,
                    Remarks = this.skinTextBoxRemark.Text,
                    PayType= (byte)(SupplierAccountRecordPayType)this.skinComboBox1.SelectedValue
                };

                if (CurItem != null)
                {
                    string orderPrefix = CurItem.SourceOrderID.Substring(0, 2);
                    if (orderPrefix != OrderPrefix.SupplierAccountRecordSource && isChangeSupplierOrType(CurItem))
                    {
                        GlobalMessageBox.Show("该记录为采购单相关的付款记录单，不允许修改！");
                        this.CloseForm();
                        return;

                    }
                    UpdateSupplierAccountRecordPara para = new UpdateSupplierAccountRecordPara()
                    {
                        ID = CurItem.AutoID,
                        AccountMoney = record.AccountMoney,
                        SupplierID = record.SupplierID,
                        AccountType = (AccountType)record.AccountType,
                        CreateTime = record.CreateTime,
                        Remarks = record.Remarks,
                       
                        PayType= (SupplierAccountRecordPayType)this.skinComboBox1.SelectedValue
                    };
                    InteractResult result = GlobalCache.ServerProxy.UpdateSupplierAccountRecord(para);

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
                    InteractResult result = GlobalCache.ServerProxy.InsertSupplierAccountRecord(record);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("登记成功！");
                            // this.ReLoad(); 
                            this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show("内部错误！");
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
            if (String.IsNullOrEmpty(this.skinComboBoxSaveSupplier.SelectedValue?.ToString()))
            {
                skinComboBoxSaveSupplier.Focus();
                success = false;
                GlobalMessageBox.Show("请选择供应商！");
            }

            return success;
        }

        bool readOnly = false;
        internal DialogResult ShowDialog(SupplierAccountRecord item,bool readOnly)
        {
            this.readOnly = readOnly;
            this.CurItem = item;
            Display();
        
            return  this.ShowDialog();
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
                if (
                readOnly) { 
                skinPanel1.Enabled = false;
                }
                //this. = false;
            }
        }
    }
}
