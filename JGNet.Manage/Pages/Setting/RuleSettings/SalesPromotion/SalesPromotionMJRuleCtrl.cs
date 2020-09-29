﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Common.Components;
using CCWin;
using JGNet.Common;
using JGNet.Common.Core.Util;

namespace JGNet.Manage.Pages.RuleSettings.SalesPromotion
{
    public partial class MJRuleCtrl : UserControl
    {
        public List<TKeyValue<decimal, decimal>> Result { get; set; }
        public MJRuleCtrl()
        {
            InitializeComponent();
            new DataGridViewPagingSumCtrl(this.dataGridViewCostume).Initialize();
            this.dataGridViewCostume.AutoGenerateColumns = false;
        }


        private void BaseButton2_Click(object sender, EventArgs e)
        {
            if (Result == null)
            {
                Result = new List<TKeyValue<decimal, decimal>>();
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
            if (Result.Exists(i => i.Key == this.numericUpDownRecharge.Value))
            {
                //充值金额重复

                numericUpDownRecharge.Focus();
                GlobalMessageBox.Show("购满金额重复！");
                return;
            }
            else
            if (Result.Exists(i => i.Key == this.numericUpDownDonate.Value))
            {
                //充值金额重复

                numericUpDownDonate.Focus();
                GlobalMessageBox.Show("减掉金额重复！");
                return;
            }

            this.dataGridViewCostume.DataSource = null;
            Result.Add(new TKeyValue<decimal, decimal>(this.numericUpDownRecharge.Value, this.numericUpDownDonate.Value));
            this.dataGridViewCostume.DataSource = Result;
            this.numericUpDownRecharge.Text = string.Empty;
            this.numericUpDownDonate.Text = string.Empty;
        }

        private void dataGridViewCostume_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridView view = (DataGridView)sender;
                List<TKeyValue<decimal, decimal>> list = (List<TKeyValue<decimal, decimal>>)view.DataSource;
                TKeyValue<decimal, decimal> item = (TKeyValue<decimal, decimal>)list[e.RowIndex];
                switch (view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    case "删除":
                        view.DataSource = null;
                        list.Remove(item);
                        view.DataSource = list;
                        break;
                    default: break;
                }
            }
        }

        internal void FillResult(List<IPromotionRule> rules)
        {
            this.dataGridViewCostume.DataSource = null;
            if (this.Result == null)
            {
                this.Result = new List<TKeyValue<decimal, decimal>>();
            }
            foreach (var item in rules)
            {
                MJPromotionRule rule = (MJPromotionRule)item;
                this.Result.Add(new TKeyValue<decimal, decimal>(rule.HitMoney, rule.MinusMoney));
            }

            this.dataGridViewCostume.DataSource = Result;
        }
    }
}
