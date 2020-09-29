using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using JGNet.Core.InteractEntity; 
using System.Collections;
using CCWin.SkinControl;

using JGNet.Core; 
using System.Reflection; 
using JGNet.Common.Core;  
using JGNet.Common.Components;
using CJBasic.Helpers;
using JGNet.Core.Tools;
using JGNet.Common.Core.Util;
using JGNet.Common;

namespace JGNet.Manage.Pages
{
    /// <summary>
    /// 编辑促销规则
    /// </summary>
    public partial class SaveGiftTicketTemplateCtrl : BaseModifyUserControl
    {

        private TKeyValue<bool, List<Costume>> costumeResult;
        private UserControl ruleCtrl;

        private GiftTicketTemplate tempItem = null;
        private GiftTicketTemplate curItem = null;

        public SaveGiftTicketTemplateCtrl(GiftTicketTemplate item)
        {
            InitializeComponent();
            try
            {
                skinTextBox_minMoney.SkinTxt.Validated += SkinTxt_Validated; ;
                skinTextBox_minDiscount.SkinTxt.Validated += SkinTxt_Validated;
                this.curItem = item;
                Display();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void SkinTxt_Validated(object sender, EventArgs e)
        {
            UpdateDesc();
        }

        private void SaveGiftTicketTemplateCtrl_Load(object sender, EventArgs e)
        {
        }

        private bool Validate(GiftTicketTemplate item)
        {
            bool success = true;
            if (item.Denomination <= 0)
            {
                GlobalMessageBox.Show("面额必须大于0");
                this.numericTextBox_denomination.Focus();
                success = false;
            }
            else
             if (skinRadioButton1.Checked)
            {
                //单选项
                if (item.MinMoney <= 0)
                {
                    if (item.MinDiscount <= 0)
                    {

                        GlobalMessageBox.Show("最低折扣必须大于0");
                        this.skinTextBox_minDiscount.Focus();
                        success = false;
                    }
                }
                else
                if (item.MinDiscount <= 0)
                {
                    if (item.MinMoney <= 0)
                    {
                        GlobalMessageBox.Show("最低金额必须大于0");
                        this.skinTextBox_minMoney.Focus();
                        success = false;
                    }
                }
            }
            else if (skinRadioButton2.Checked)
            { //并且
                if (item.MinMoney <= 0)
                {
                    GlobalMessageBox.Show("最低金额必须大于0");
                    this.skinTextBox_minMoney.Focus();
                    success = false;
                }
                else 
                if (item.MinDiscount <= 0)
                {
                    GlobalMessageBox.Show("最低折扣必须大于0");
                    this.skinTextBox_minDiscount.Focus();
                    success = false;
                }
            }
            return success;
        }

        private void UpdateDesc()
        {
            int Denomination = Decimal.ToInt32(numericTextBox_denomination.Value);
            int MinMoney = 0;
            try
            {
                MinMoney = String.IsNullOrEmpty(skinTextBox_minMoney.Text) ? 0 : Convert.ToInt32(skinTextBox_minMoney.Text);
            }
            catch (Exception ex) {
                MinMoney = 0;
                return;
            }
            Decimal MinDiscount = String.IsNullOrEmpty(skinTextBox_minDiscount.Text) ? 0 : Convert.ToDecimal(skinTextBox_minDiscount.Text);
            skinLabelTicketDesc.Text = GiftTicketHelper.GetTicketDescription(Denomination, MinMoney, MinDiscount, this.skinRadioButton2.Checked);
        }

        private void SetItem(GiftTicketTemplate item)
        {
            item.Denomination = Decimal.ToInt32(numericTextBox_denomination.Value);
            item.MinMoney = String.IsNullOrEmpty(skinTextBox_minMoney.Text) ? 0 : Convert.ToInt32(skinTextBox_minMoney.Text);
            item.MinDiscount = String.IsNullOrEmpty(skinTextBox_minDiscount.Text) ? 0 : Convert.ToDecimal(skinTextBox_minDiscount.Text);
            item.TicketDescription = skinLabelTicketDesc.Text;
            item.OperatorUserID = GlobalCache.CurrentUserID;
            item.IsAnd = skinRadioButton2.Checked;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                if (curItem == null)
                {
                    GiftTicketTemplate item = new GiftTicketTemplate() { };

                    SetItem(item);
                    if (!Validate(item)) { return; }
                    item.CreateTime = DateTime.Now;
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    InsertResult result = GlobalCache.ServerProxy.InsertGiftTicketTemplate(item);
                    switch (result)
                    {
                        case InsertResult.Error:
                            GlobalMessageBox.Show("内部错误！");
                            break;
                        default:
                            GlobalMessageBox.Show("添加成功！");

                            TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                    }
                }
                else
                {
                    SetItem(curItem);
                    if (!Validate(curItem)) { return; }
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    UpdateResult result = GlobalCache.ServerProxy.UpdateGiftTicketTemplate(curItem);
                    switch (result)
                    {
                        case UpdateResult.Error:
                            GlobalMessageBox.Show("内部错误！");
                            break;
                        default:
                            GlobalMessageBox.Show("保存成功！");
                            TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                    }
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

        public void Refresh(GiftTicketTemplate e)
        {
            curItem = e;
            Display();

        }

        private void Display()
        {
            if (curItem != null)
            {
                this.numericTextBox_denomination.Value = this.curItem.Denomination;
                this.skinTextBox_minMoney.Text = this.curItem.MinMoney.ToString();
                this.skinTextBox_minDiscount.Text = this.curItem.MinDiscount.ToString();

                skinRadioButton2.Checked = this.curItem.IsAnd;
                skinRadioButton1.Checked = !this.curItem.IsAnd;


            }
            else
            {
                ResetAll();
            }
        }



        private void ResetAll()
        {
            this.numericTextBox_denomination.Value = 0;
            this.skinTextBox_minMoney.Text = string.Empty;
            this.skinTextBox_minDiscount.Text = string.Empty;
        }


        private void numericTextBox_denomination_ValueChanged(object obj)
        {
            try {
            UpdateDesc();
            } catch (Exception ex) {
                MessageBox.Show("请正确输入优惠劵面额！");

                numericTextBox_denomination.Text = "0";
                return;
            }

        } 

        private void skinRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateDesc();
            }
            catch (Exception ex)
            {

            }
        }

        private void skinRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateDesc();
            }
            catch (Exception ex)
            {

            }
        }

        private void skinTextBox_minMoney_Validating(object sender, CancelEventArgs e)
        {

            if (!String.IsNullOrEmpty(skinTextBox_minMoney.SkinTxt.Text))
            {
                if (!ValidateUtil.CheckMoney(skinTextBox_minMoney.SkinTxt.Text))
                {
                    e.Cancel = true;
                    skinTextBox_minMoney.Text = String.Empty;
                } 
            } 
        }

        private void skinTextBox_minDiscount_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(skinTextBox_minDiscount.SkinTxt.Text))
            {
                if (!ValidateUtil.CheckMoney(skinTextBox_minDiscount.SkinTxt.Text))
                {
                    e.Cancel = true;
                    skinTextBox_minDiscount.Text = String.Empty;
                }
            }
        }

        private void numericTextBox_denomination_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int tmp = int.Parse(numericTextBox_denomination.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请正确输入优惠劵面额！");
                e.Cancel = true;
                numericTextBox_denomination.Text = "0";
                return;
            }
        }

        private void skinTextBox_minMoney_Validating_1(object sender, CancelEventArgs e)
        {
            try
            {
                int tmp = int.Parse(skinTextBox_minMoney.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请正确输入最低金额！");
                e.Cancel = true;
                skinTextBox_minMoney.Text = "0";
                return;
            }
        }
    }


}
