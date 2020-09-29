using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms; 
using JGNet.Core.Const;
using CCWin;
using JGNet.Core;

using CJBasic.Loggers;
using CJPlus;
using JGNet.ForManage;
using JGNet.Manage.Pages.RuleSettings;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core.Util;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;

namespace JGNet.Manage
{
    public partial class RechargeRuleCtrl : BaseUserControl
    {
        BindingList<RechargeDonateRule> rules;

        private List<IPromotionRule> currentPromotionRuleList = new List<IPromotionRule>();

        private List<RetailDetail> retailDetailList = new List<RetailDetail>();//当前dataGridView绑定的源



        public RechargeRuleCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.充值规则;
            new DataGridViewPagingSumCtrl(this.dataGridViewRuleExpression) { AutoIndexMode = DataGridViewAutoIndexMode.RowHeader }.Initialize();
        }


        private void BaseButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<Rule> itemList=null;
                if (dataGridViewRuleExpression.DataSource != null)
                {
                    itemList = DataGridViewUtil.BindingListToList<Rule>(dataGridViewRuleExpression.DataSource);
                }
                if (itemList == null)
                {
                    itemList = new List<Rule>();
                }

                if (this.numericUpDownRecharge.Value == 0)
                {
                    //金额不能为0

                    numericUpDownRecharge.Focus();
                    GlobalMessageBox.Show("金额不能为0！");
                    return;
                }
                else
                if (this.numericUpDownDonate.Value == 0)
                {
                    //金额不能为0

                    numericUpDownDonate.Focus();
                    GlobalMessageBox.Show("金额不能为0！");
                    return;
                }
                else
                if (itemList.Exists(i => i.RechargeMoney ==Convert.ToInt32(this.numericUpDownRecharge.Text)))
                {
                    //充值金额重复

                    numericUpDownRecharge.Focus();
                    GlobalMessageBox.Show("充值金额重复！");
                    return;
                }
                else
                if (itemList.Exists(i => i.DonateMoney ==Convert.ToInt32(this.numericUpDownDonate.Text)))
                {
                    //充值金额重复

                    numericUpDownDonate.Focus();
                    GlobalMessageBox.Show("赠送金额重复！");
                    return;
                }


                dataGridViewRuleExpression.DataSource = null;
                Rule curRule = new Rule();
                curRule.RechargeMoney = Convert.ToInt32(this.numericUpDownRecharge.Text);
                curRule.DonateMoney = Convert.ToInt32(this.numericUpDownDonate.Text);
                itemList.Add(curRule);
                dataGridViewRuleExpression.DataSource = DataGridViewUtil.ListToBindingList(itemList);
                //if (dataGridViewRuleExpression != null)
                //{
                    UpdateRule(dataGridViewRuleExpression);
                //}
                numericUpDownRecharge.Text = string.Empty;
                numericUpDownDonate.Text = string.Empty;
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

        private RechargeDonateRule rule;

        private void RechargeRuleCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<RechargeDonateRule> tempRules = GlobalCache.ServerProxy.GetRechargeDonateRuleList();
                if (tempRules != null)
                {
                    rule = tempRules[0];
                }
                numericUpDownDonate.Text = string.Empty;
                numericUpDownRecharge.Text = string.Empty;
                this.dataGridViewRuleExpression.AutoGenerateColumns = false; 
                String expr = rule.RuleExpression;

                this.dataGridViewRuleExpression.DataSource = null;
                if (!String.IsNullOrEmpty(expr))
                {
                    List<Rule> listItems = new List<Rule>();
                    String[] exprArr = expr.Split(',');
                    foreach (var item in exprArr)
                    {
                        Rule iRule = new Rule();
                        String[] keyValue = item.Split('-');
                        if (keyValue.Length > 1)
                        {
                            iRule.RechargeMoney=Convert.ToInt32(keyValue[0]);
                            iRule.DonateMoney = Convert.ToInt32(keyValue[1]);
                            //listItems.Add(new ListItem<string>(keyValue[0], keyValue[1]));
                            listItems.Add(iRule);
                        }
                    }
                 
                    this.dataGridViewRuleExpression.DataSource = DataGridViewUtil.ListToBindingList(listItems); 
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
        private void dataGridViewRuleExpression_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                DataGridView view = (DataGridView)sender;
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    List<Rule> list = DataGridViewUtil.BindingListToList<Rule>(view.DataSource);//(List<ListItem<String>>)view.DataSource;
                    switch (view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {
                        case "删除":
                            Rule selectedItem = (Rule)view.Rows[e.RowIndex].DataBoundItem;
                            view.DataSource = null;
                            list.Remove(selectedItem);
                            view.DataSource = DataGridViewUtil.ListToBindingList<Rule>(list);
                            UpdateRule(view);
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


        private void UpdateRule(DataGridView view)
        {
            numericUpDownRecharge.Text = String.Empty;
            numericUpDownDonate.Text = String.Empty;

            if (rule != null)
            {

                List<Rule> listItems = DataGridViewUtil.BindingListToList<Rule>(view.DataSource);
                String ruleExpression = "";
                foreach (var item in listItems)
                {
                    String keyValue = item.RechargeMoney + "-" + item.DonateMoney;
                    ruleExpression += keyValue + ",";

                }
                int idx = ruleExpression.LastIndexOf(",");
                if (idx > 0)
                {
                    ruleExpression = ruleExpression.Remove(idx);
                }

                rule.RuleExpression = ruleExpression; 
                //udpate db
                UpdateRechargeDonateRuleResult result = GlobalCache.ServerProxy.UpdateRechargeDonateRule(rule);
                switch (result)
                {
                    case UpdateRechargeDonateRuleResult.Success:
                        GlobalCache.UpdateRechargeDonateRule(rule);
                        break;
                    case UpdateRechargeDonateRuleResult.Error:
                        GlobalMessageBox.Show("内部错误!");
                        break;
                    case UpdateRechargeDonateRuleResult.RechargeMoneyOpenIsExist:
                        GlobalMessageBox.Show("充值金额已经存在开启!");
                        break;
                    default:
                        break;
                }
            }

        }



        /// <summary>
        /// 根据修改的行信息，更新规则表对应的规则信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dataGridViewRuleExpression_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                DataGridView view = (DataGridView)sender;
               // UpdateRule(view);
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

        private void numericUpDownDonate_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                int tmp = int.Parse(numericUpDownDonate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请正确输入赠送金额！");
                e.Cancel = true;
                numericUpDownDonate.Text = "0";
                return;
            }
        }

        private void numericUpDownRecharge_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int tmp = int.Parse(numericUpDownRecharge.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请正确输入充值金额！");
                e.Cancel = true;
                numericUpDownRecharge.Text = "0";
                return;
            }
            
        }
    }
}
