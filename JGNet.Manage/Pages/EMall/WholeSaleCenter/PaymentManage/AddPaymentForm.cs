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
using CJBasic;
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

namespace JGNet.Manage
{
    public partial class AddPaymentForm : BaseForm
    {
       // private SupplierAccountRecord CurItem { get; set; }
        DistributorWithdrawRecord CurDistributorInfo = null;
        public AddPaymentForm(DistributorWithdrawRecord disRecord=null)
        {
            InitializeComponent();
            CurDistributorInfo = disRecord;
            this.Initialize();
        }
         
        


        private void Initialize()
        {
            //  GlobalUtil.SetSupplier(this.skinComboBoxSaveSupplier, true);
            //    SetFeeType(this.skinComboBoxSaveType, true);
            //  SetPayType();
            if (CurDistributorInfo != null)
            {
                this.Text = "编辑付款记录";
                baseButton1.Visible = true;
                BaseButtonSave.Visible = false;

            }
            else {

                baseButton1.Visible = false ;
                BaseButtonSave.Visible = true; 

            }
            this.numericTextBox1.Value = 0;
            numericTextBox1.MinNum = Int32.MinValue;
            if (CurDistributorInfo != null)
            {
                pfCustomerIDTextBox1.Enabled = false;
                pfCustomerIDTextBox1.Text = CurDistributorInfo.DistributorID;
               
                if (pfcustomer == null) { pfcustomer = new PfCustomer(); }
                    pfcustomer.Name = CurDistributorInfo.DistributorName;
                    pfcustomer.ID = CurDistributorInfo.DistributorID;
                    numericTextBox2.Text = CurDistributorInfo.NewMoney.ToString();
                this.textBoxRemark.Text = CurDistributorInfo.Remarks;
                    numericTextBox1.Text = CurDistributorInfo.Money.ToString();
                dateTimePicker_Start.Value = CurDistributorInfo.CreateTime;
              

            }
            this.pfCustomerIDTextBox1.MemberSelected += PfCustomerTextBox1_MemberSelected;
            
        }

        
        
        Costume item = null;

        

        PfCustomer pfcustomer;

        private void PfCustomerTextBox1_MemberSelected(PfCustomer pfCustomer)
        {
            try
            {
                if (pfCustomer != null)
                {
                    this.pfcustomer = pfCustomer;
                    skinTextBoxName.Text = pfCustomer.Name;
                    numericTextBox2.Text = pfcustomer.RemainingCommission.ToString();
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            try
            {

                if (pfCustomerIDTextBox1.SkinTxt.Text == "")
                {
                    GlobalMessageBox.Show("请先选择分销人员！");
                    return;
                }
                else
                {
                    //判断分销人员存不存在
                    string pfCustomerID = pfCustomerIDTextBox1.SkinTxt.Text;
                  InteractResult<PfCustomer> pfItemInfo=  CommonGlobalCache.ServerProxy.GetPfCustomer(pfCustomerID);
                    decimal pfMoney = numericTextBox1.Value;
                    if (pfItemInfo.ExeResult == ExeResult.Success)
                    {
                        if (pfItemInfo.Data == null)
                        {
                            GlobalMessageBox.Show("请选择正确的分销人员！");
                            
                            return;
                        }
                        else {
                            if (numericTextBox2.Value == 0)
                            {
                                numericTextBox2.Value = pfItemInfo.Data.RemainingCommission;
                            }
                        }
                    }
                }
                if (numericTextBox1.Value <= 0)
                {
                    numericTextBox1.Focus();
                    GlobalMessageBox.Show("打款金额必须大于0！");
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

              
                DistributorWithdrawRecord para = new DistributorWithdrawRecord() {
                    DistributorID = pfCustomerIDTextBox1.SkinTxt.Text,
                    Money = money,
                    Remarks = textBoxRemark.SkinTxt.Text,
                     //DistributorName
                    CreateTime = dateTimePicker_Start.Value,
                };
                    InteractResult result = GlobalCache.ServerProxy.PayCommission(para);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("新增成功！");
                        // this.ReLoad(); 
                        numericTextBox1.SkinTxt.Text = string.Empty;
                        this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
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


        

        bool readOnly = false;
        internal DialogResult ShowDialog(SupplierAccountRecord item,bool readOnly)
        {
            this.readOnly = readOnly;
        
            return  this.ShowDialog();
        }

        public void ShowNew(Control parent)
        {
            try
            {
                this.TopMost = true;
                this.ShowDialog(parent);
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
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            try {  
            if (numericTextBox1.Value <= 0)
            {
                numericTextBox1.Focus();
                GlobalMessageBox.Show("打款金额必须大于0！");
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
                string remark = this.textBoxRemark.SkinTxt.Text;
                DistributorWithdrawRecord para = new DistributorWithdrawRecord()
                {
                    DistributorID = pfCustomerIDTextBox1.SkinTxt.Text,
                    Money = money,
                     
                    //DistributorName
                    CreateTime = dateTimePicker_Start.Value,
                };

                InteractResult result = GlobalCache.ServerProxy.UpdateDistributorWithdrawRecord(CurDistributorInfo.AutoID, money,  dateTimePicker_Start.Value, remark);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("保存成功！");
                        // this.ReLoad(); 
                        this.DialogResult = DialogResult.OK;
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
                // }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
            finally
            {
                numericTextBox1.SkinTxt.Text = string.Empty;
                //  this.skinTextBoxRemark.SkinTxt.Text = string.Empty;
                GlobalUtil.UnLockPage(this);
            }
        }
    }
}
