using CCWin;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.InteractEntity;
using JGNet.Manage;
using JGNet.Server.Tools;
using CJBasic.Helpers;
using CJBasic.Loggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class ConfirmRefundForm : Common.BaseForm
    {

        private RefundCostume refundCostume;
        private SizeGroup sizeGroup;
        private String ShopID;
        private decimal STotalMoneyReceived=0;
        private RefundCostume keepCostume;
        private DataGridView deepSourceDgv;
        private int ReturnType = 0;
        public ConfirmRefundForm(RefundCostume costume, string shopId,DataGridView dgv, decimal sourceTotalMoneyReceived = 0,int returntype=0)
        {
            InitializeComponent();
            this.refundCostume = costume;
            keepCostume = costume;
            deepSourceDgv = dgv;
            STotalMoneyReceived = sourceTotalMoneyReceived;
            this.Initialize();
            LoadConfig();
            this.ShopID = shopId;
            ReturnType = returntype;
            MenuPermission = Common.Core.RolePermissionMenuEnum.退货;
        }

        private void Initialize()
        {
            ///总计=现金+积分+VIP卡+优惠券
            this.skinLabel_RefundIntegration.Value = Math.Abs(this.refundCostume.RefundOrder.MoneyIntegration);
            this.skinLabel_RefundStoredCard.Value = Math.Abs(this.refundCostume.RefundOrder.MoneyVipCard);
            this.skinLabel_RefundCash.Value = Math.Abs(this.refundCostume.RefundOrder.MoneyCash);
            this.numericTextBoxBankCard.Value = Math.Abs(this.refundCostume.RefundOrder.MoneyBankCard);
            this.numericTextBoxWeixin.Value = Math.Abs(this.refundCostume.RefundOrder.MoneyWeiXin);
            this.numericTextBoxAlipay.Value = Math.Abs(this.refundCostume.RefundOrder.MoneyAlipay);
            this.numericTextBoxElse.Value = Math.Abs(this.refundCostume.RefundOrder.MoneyOther);
            this.skinLabel_TotalMoney.Value = Math.Abs(this.refundCostume.RefundOrder.TotalMoneyReceived);
            if (!this.refundCostume.IsNotHaveRetailOrder)
            {
                if (skinLabel_RefundIntegration.Text == "0"  )
                {
                    skinLabel_RefundIntegration.Enabled = false;
                }
                if (skinLabel_RefundStoredCard.Text == "0"   )
                {
                    skinLabel_RefundStoredCard.Enabled = false;
                }
                if (skinLabel_RefundCash.Text == "0")
                {
                    skinLabel_RefundCash.Enabled = false;
                }
                if (numericTextBoxBankCard.Text == "0")
                {
                    numericTextBoxBankCard.Enabled = false;
                }
                if (numericTextBoxWeixin.Text == "0")
                {
                    numericTextBoxWeixin.Enabled = false;
                }
                if (numericTextBoxAlipay.Text == "0")
                {
                    numericTextBoxAlipay.Enabled = false;
                }
                if (numericTextBoxElse.Text == "0")
                {
                    numericTextBoxElse.Enabled = false;
                }
            }

            if (String.IsNullOrEmpty(refundCostume.RefundOrder.MemeberID))
            {
                skinLabel_RefundStoredCard.Enabled = false;
                skinLabel_RefundIntegration.Enabled = false;
            }

            // this.panel1.Visible = !this.refundCostume.IsNotHaveRetailOrder;
        }

        private void BaseButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
               
                if (this.refundCostume.RefundOrder.TotalCount == 0)
                {
                    GlobalMessageBox.Show("退货数量为0，不能退货");
                    return;
                }

                if (Math.Abs(skinLabel_TotalMoney.Value) != (skinLabel_RefundIntegration.Value + skinLabel_RefundStoredCard.Value + skinLabel_RefundCash.Value +
                      this.numericTextBoxBankCard.Value  +
                this.numericTextBoxWeixin.Value  +
                this.numericTextBoxAlipay.Value +
                this.numericTextBoxElse.Value
                ))
                {
                    GlobalMessageBox.Show("退款总额必须与总计相等！");
                    return;
                }
                

                this.refundCostume.RefundOrder.MoneyIntegration = skinLabel_RefundIntegration.Value * -1;
                this.refundCostume.RefundOrder.MoneyVipCard = skinLabel_RefundStoredCard.Value * -1;
                this.refundCostume.RefundOrder.MoneyCash = skinLabel_RefundCash.Value * -1;
                this.refundCostume.RefundOrder.MoneyAlipay = numericTextBoxAlipay.Value * -1;
                this.refundCostume.RefundOrder.MoneyOther = numericTextBoxElse.Value * -1;
                this.refundCostume.RefundOrder.MoneyWeiXin = numericTextBoxWeixin.Value * -1;
                this.refundCostume.RefundOrder.MoneyBankCard = numericTextBoxBankCard.Value * -1;
                //  decimal moneyVipCardDonate = this.refundCostume.RefundOrder.MoneyVipCard * (decimal)member.DonateCoef;
                //  decimal moneyVipCardMain = this.refundCostume.RefundOrder.MoneyVipCard * (1 - (decimal)member.DonateCoef);
                if (!String.IsNullOrEmpty(refundCostume.RefundOrder.MemeberID))
                {
                    Member member = CommonGlobalCache.ServerProxy.GetOneMember(refundCostume.RefundOrder.MemeberID);
                    if (member != null)
                    {
                        decimal moneyVipCardMain = refundCostume.RefundOrder.MoneyVipCard * (decimal)(1.0 - member.DonateCoef);
                        refundCostume.RefundOrder.MoneyCash2 = refundCostume.RefundOrder.MoneyCash;
                        refundCostume.RefundOrder.MoneyVipCardMain = moneyVipCardMain;
                        refundCostume.RefundOrder.MoneyVipCardDonate = refundCostume.RefundOrder.MoneyVipCard * (decimal)(member.DonateCoef);

                     
                    }
                }
                else
                {
                    refundCostume.RefundOrder.MoneyCash2 = refundCostume.RefundOrder.MoneyCash;
                    refundCostume.RefundOrder.MoneyVipCardMain = 0;
                    refundCostume.RefundOrder.MoneyVipCardDonate = 0;
                }
                if (refundCostume.RefundOrder.IsNotPay)
                {
                    decimal total = 0;
                    foreach (RetailDetail curDetail in this.refundCostume.RefundDetailList)
                    {
                        foreach (RetailDetail keepDetail in keepCostume.RefundDetailList)
                        {
                            if (curDetail.RetailOrderID == keepDetail.RetailOrderID && curDetail.CostumeID == keepDetail.CostumeID && curDetail.ColorName == keepDetail.ColorName && curDetail.SizeName == keepDetail.SizeName)
                            {
                                curDetail.SumMoney = keepDetail.SumMoney;
                                total += keepDetail.SumMoney;
                            }
                        }
                    }

                    refundCostume.RefundOrder.TotalMoneyReceived = total*-1;


                }
                else
                {
                    //总计=现金+积分+VIP卡+优惠券
                    //这笔单的应收金额 - （不退的那几件以原价* 数量 -满减金额） - （退的那几件）优惠券
                    refundCostume.RefundOrder.TotalMoneyReceived = refundCostume.RefundOrder.MoneyCash + refundCostume.RefundOrder.MoneyIntegration + refundCostume.RefundOrder.MoneyVipCard
                        + this.refundCostume.RefundOrder.MoneyAlipay + this.refundCostume.RefundOrder.MoneyOther +
                    this.refundCostume.RefundOrder.MoneyWeiXin +
                    this.refundCostume.RefundOrder.MoneyBankCard;
                    refundCostume.RefundOrder.TotalMoneyReceivedActual = refundCostume.RefundOrder.MoneyCash
                           + this.refundCostume.RefundOrder.MoneyAlipay + this.refundCostume.RefundOrder.MoneyOther +
                    this.refundCostume.RefundOrder.MoneyWeiXin +
                    this.refundCostume.RefundOrder.MoneyBankCard
                        + refundCostume.RefundOrder.MoneyVipCardMain + (refundCostume.RefundOrder.RetailMoneyDeductedByTicket - refundCostume.RefundOrder.MoneyDeductedByTicket);
                    refundCostume.RefundOrder.Benefit = refundCostume.RefundOrder.TotalMoneyReceivedActual - refundCostume.RefundOrder.TotalCost;



                    //平摊
                    if (refundCostume.RefundDetailList != null)
                    {
                        CalcDirectly();
                    }

                    //总计=现金+积分+VIP卡+优惠券
                    //这笔单的应收金额 - （不退的那几件以原价* 数量 -满减金额） - （退的那几件）优惠券
                    //  refundCostume.RefundOrder.TotalMoneyReceived = refundCostume.RefundOrder.MoneyCash + refundCostume.RefundOrder.MoneyIntegration + refundCostume.RefundOrder.MoneyVipCard;
                }

                refundCostume.RefundOrder.ShopID = this.ShopID;
                InteractResult result = GlobalCache.ServerProxy.RefundCostume(this.refundCostume);

                if (result.ExeResult == ExeResult.Success)
                {
                    GlobalMessageBox.Show("退货成功！");
                    this.DialogResult = DialogResult.OK;
                    if (skinCheckBoxPrint.Checked)
                    {
                        RefundOrderPrintUtil printHelper = new RefundOrderPrintUtil();
                        int times = CommonGlobalUtil.ConvertToInt32(CommonGlobalCache.GetParameter(ParameterConfigKey.PrintCount).ParaValue);
                        DataGridView dgv = deepCopyDataGridView();
                        printHelper.Print(refundCostume, times, dgv);
                    }
                }
                else if (result.ExeResult == ExeResult.Error)
                {
                    GlobalMessageBox.Show(result.Msg);
                }
            }
            catch(Exception ee)
            {
                GlobalUtil.WriteLog(ee);
                GlobalMessageBox.Show("内部错误，退货失败！");
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private DataGridView deepCopyDataGridView()
        {
            DataGridView dgvTmp = new DataGridView();

            dgvTmp.Name = "dgvTmp";
            this.Controls.Add(dgvTmp);
            //  dgvTmp.AllowUserToAddRows = false; //不允许用户生成行，否则导出后会多出最后一行

            dgvTmp.AutoGenerateColumns = false;



            List<RetailDetail> listtb1 = refundCostume.RefundDetailList;
            int autoID = 0;
            List<RetailDetail> tb2 = new List<RetailDetail>();
            foreach (RetailDetail idetail in listtb1)
            {
                RetailDetail tDetail = new RetailDetail();
                ReflectionHelper.CopyProperty(idetail, tDetail);
                autoID++;
                tDetail.PrintAutoID = autoID;
                tb2.Add(tDetail);

            }


            DataGridViewTextBoxColumn dgvColumnAuto = new DataGridViewTextBoxColumn();
            dgvColumnAuto.Name = "序列号";
            dgvColumnAuto.HeaderText = "序列号";
            dgvColumnAuto.Visible = true;
            dgvColumnAuto.DataPropertyName = "PrintAutoID";
            dgvTmp.Columns.Add(dgvColumnAuto);

            List<DataGridViewTextBoxColumn> listColumns = new List<DataGridViewTextBoxColumn>();

            //dgvTmp.Columns.Add("ColumnCoustomerId","款号");


            for (int i = 0; i < deepSourceDgv.Columns.Count; i++)
            {
                dgvTmp.Columns.Add(deepSourceDgv.Columns[i].Name, deepSourceDgv.Columns[i].HeaderText);
                if (deepSourceDgv.Columns[i].DefaultCellStyle.Format.Contains("N")) //使导出Excel文档金额列可做SUM运算
                {
                    dgvTmp.Columns[i + 1].DefaultCellStyle.Format = deepSourceDgv.Columns[i].DefaultCellStyle.Format;

                }
                if (!deepSourceDgv.Columns[i].Visible)
                {
                    dgvTmp.Columns[i + 1].Visible = false;
                }
                dgvTmp.Columns[i + 1].DataPropertyName = deepSourceDgv.Columns[i].DataPropertyName;
                if (deepSourceDgv.Columns[i].HeaderText == "单价") { dgvTmp.Columns[i + 1].HeaderText = "吊牌价"; }
                else if (deepSourceDgv.Columns[i].HeaderText == "销售额") { dgvTmp.Columns[i + 1].HeaderText = "金额"; }
                else
                {
                    dgvTmp.Columns[i + 1].HeaderText = deepSourceDgv.Columns[i].HeaderText;
                }
                dgvTmp.Columns[i + 1].Tag = deepSourceDgv.Columns[i].Tag;
                dgvTmp.Columns[i + 1].Name = deepSourceDgv.Columns[i].Name;

            }
            if (ReturnType != 1)
            {
                DataGridViewTextBoxColumn dgvColumnReamrk = new DataGridViewTextBoxColumn();
                dgvColumnReamrk.Name = "备注";
                dgvColumnReamrk.HeaderText = "备注";
                dgvColumnReamrk.Visible = true;
                dgvColumnReamrk.DataPropertyName = "Reamrk";
                dgvTmp.Columns.Add(dgvColumnReamrk);

            }
            dgvTmp.DataSource = tb2;


            return dgvTmp;
        }
        private void CalcNormal()
        {
           

            decimal sum = 0;
            foreach (RetailDetail detail in refundCostume.RefundDetailList)
            {
                sum += detail.SumMoney;
            }
            decimal totalMoneyReceivedWithoutBuyout = refundCostume.RefundOrder.TotalMoneyReceived;
            decimal mjMoneyRemain = refundCostume.RefundOrder.TotalMoneyReceived;
            //按实收的摊
            for (int i = 0; i < refundCostume.RefundDetailList.Count; i++)
            {
                RetailDetail detail = (RetailDetail)refundCostume.RefundDetailList[i];
                //如果是最后一个就把剩余的给他
                if (i + 1 == refundCostume.RefundDetailList.Count)
                {

                    detail.SumMoney = mjMoneyRemain;
                    detail.SinglePrice = detail.SumMoney / detail.BuyCount;
                }
                else
                {
                    decimal rate = detail.SumMoney / sum;
                    decimal rateMoney = Math.Round(totalMoneyReceivedWithoutBuyout * rate, 2, MidpointRounding.AwayFromZero);
                    mjMoneyRemain = Math.Round(mjMoneyRemain - rateMoney, 2, MidpointRounding.AwayFromZero);
                    detail.SumMoney = rateMoney;
                    detail.SinglePrice = detail.SumMoney / detail.BuyCount;
                }
            }

            sum = 0;
            foreach (RetailDetail detail in refundCostume.RefundDetailList)
            {
              //  CommonGlobalUtil.WriteLog("单款吊牌总额:" + detail.SumMoneyActual);
              //20181207 按summary来作为比例摊
                sum += detail.SumMoney;
            }
          //  CommonGlobalUtil.WriteLog("总吊牌价:" + sum);
             mjMoneyRemain = refundCostume.RefundOrder.TotalMoneyReceivedActual;
            //按实收的摊
            for (int i = 0; i < refundCostume.RefundDetailList.Count; i++)
            {
                RetailDetail detail = (RetailDetail)refundCostume.RefundDetailList[i];
                //如果是最后一个就把剩余的给他
                if (i + 1 == refundCostume.RefundDetailList.Count)
                {

                    detail.SumMoneyActual = mjMoneyRemain;
                   // detail.SinglePrice = detail.SumMoneyActual / detail.BuyCount;
                }
                else
                {
                    decimal rate = detail.SumMoney / sum;
                    decimal rateMoney = MathHelper.Rounded(totalMoneyReceivedWithoutBuyout * rate, 2);
                    mjMoneyRemain = MathHelper.Rounded(mjMoneyRemain - rateMoney, 2);
                    detail.SumMoneyActual = rateMoney;

                   // detail.SinglePrice = detail.SumMoneyActual / detail.BuyCount;
                }
            }

            if (refundCostume.RefundOrder.TotalMoneyReceived == refundCostume.RefundOrder.TotalMoneyReceivedActual)
            {
                for (int i = 0; i < refundCostume.RefundDetailList.Count; i++)
                {
                    RetailDetail detail = (RetailDetail)refundCostume.RefundDetailList[i];
                    detail.SumMoneyActual = detail.SumMoney;
                   //detail.SinglePrice = detail.SumMoneyActual / detail.BuyCount;
                }
            }
        }

        private void CalcDirectly()
        {

            if (refundCostume.RefundOrder.TotalMoneyReceived == refundCostume.RefundOrder.TotalMoneyReceivedActual)
            {
                //如果总计和所有款总额不一致则重新摊
                decimal sum = 0;
                decimal buyout = 0;
                List<RetailDetail> refundDetailListBuyout = refundCostume.RefundDetailList.FindAll(t => t.IsBuyout);
                List<RetailDetail> refundDetailListNotBuyout = refundCostume.RefundDetailList.FindAll(t => !t.IsBuyout);
                if (refundDetailListBuyout != null)
                {
                    foreach (RetailDetail detail in refundDetailListBuyout)
                    {
                        buyout += detail.SumMoney;
                    }
                }
                foreach (RetailDetail detail in refundCostume.RefundDetailList)
                {
                    sum += detail.SumMoney;
                    detail.SinglePrice = detail.SumMoney / detail.BuyCount;
                } 
                if (refundCostume.RefundOrder.TotalMoneyReceived == sum)
                {
                    for (int i = 0; i < refundCostume.RefundDetailList.Count; i++)
                    {
                        RetailDetail detail = (RetailDetail)refundCostume.RefundDetailList[i];
                        detail.SumMoneyActual = detail.SumMoney;
                    }
                }
                else
                {
                    BuildSumMoney();
                    for (int i = 0; i < refundCostume.RefundDetailList.Count; i++)
                    {
                        RetailDetail detail = (RetailDetail)refundCostume.RefundDetailList[i];
                        detail.SumMoneyActual = detail.SumMoney;
                    }
                }
            }
            else
            {
                BuildSumMoneyActual();
                BuildSumMoney();
            }
        }

        private void BuildSumMoneyActual()
        {
            decimal sum = 0;
            decimal buyout = 0;
            List<RetailDetail> refundDetailListBuyout = refundCostume.RefundDetailList.FindAll(t => t.IsBuyout);
            List<RetailDetail> refundDetailListNotBuyout = refundCostume.RefundDetailList.FindAll(t => !t.IsBuyout);
            if (refundDetailListBuyout != null)
            {
                foreach (RetailDetail detail in refundDetailListBuyout)
                {
                    buyout += detail.SumMoney;
                }
            }
            foreach (RetailDetail detail in refundCostume.RefundDetailList)
            {
                sum += detail.SumMoney;
                 
            }


            //按实收的摊
            if (refundDetailListNotBuyout != null)
            {
                foreach (RetailDetail detail in refundDetailListNotBuyout)
                {
                    CommonGlobalUtil.WriteLog("单款吊牌总额:" + detail.SumMoneyActual);
                    sum += detail.SumMoneyActual;
                }
                CommonGlobalUtil.WriteLog("总吊牌价:" + sum);
                decimal totalMoneyReceivedWithoutBuyout = refundCostume.RefundOrder.TotalMoneyReceived - buyout;
                decimal mjMoneyRemain = refundCostume.RefundOrder.TotalMoneyReceivedActual - buyout;
                //按实收的摊
                for (int i = 0; i < refundDetailListNotBuyout.Count; i++)
                {
                    RetailDetail detail = (RetailDetail)refundDetailListNotBuyout[i];
                    //如果是最后一个就把剩余的给他
                    if (i + 1 == refundDetailListNotBuyout.Count)
                    {
                        detail.SumMoneyActual = mjMoneyRemain;
                    }
                    else
                    {
                        decimal rate = detail.SumMoneyActual / sum;
                        decimal rateMoney = MathHelper.Rounded(totalMoneyReceivedWithoutBuyout * rate, 2);
                        mjMoneyRemain = MathHelper.Rounded(mjMoneyRemain - rateMoney, 2);
                        detail.SumMoneyActual = rateMoney;
                    }
                }
            }
        }

        private void BuildSumMoney()
        {
            decimal sum = 0;
            decimal buyout = 0;
            decimal mjMoneyRemain = 0;
            List<RetailDetail> refundDetailListBuyout = refundCostume.RefundDetailList.FindAll(t => t.IsBuyout);
            List<RetailDetail> refundDetailListNotBuyout = refundCostume.RefundDetailList.FindAll(t => !t.IsBuyout);
            if (refundDetailListBuyout != null)
            {
                foreach (RetailDetail detail in refundDetailListBuyout)
                {
                    buyout += detail.SumMoney;
                   
                }
            }
            foreach (RetailDetail detail in refundCostume.RefundDetailList)
            {
                sum += detail.SumMoney;
               // detail.SinglePrice = detail.SumMoney / detail.BuyCount;
            }
           

            decimal totalMoneyReceivedWithoutBuyout = refundCostume.RefundOrder.TotalMoneyReceived - buyout;
            mjMoneyRemain = refundCostume.RefundOrder.TotalMoneyReceived- buyout;
            //按实收的摊
            if (refundDetailListNotBuyout != null)
            {
                for (int i = 0; i < refundDetailListNotBuyout.Count; i++)
                {
                    RetailDetail detail = (RetailDetail)refundDetailListNotBuyout[i];
                    //如果是最后一个就把剩余的给他
                    if (i + 1 == refundDetailListNotBuyout.Count)
                    {
                        detail.SumMoney = mjMoneyRemain;
                        detail.SinglePrice = detail.SumMoney / detail.BuyCount;
                    }
                    else
                    {
                        decimal rate = detail.SumMoney / sum;
                        decimal rateMoney = Math.Round(totalMoneyReceivedWithoutBuyout * rate, 2, MidpointRounding.AwayFromZero);
                        mjMoneyRemain = Math.Round(mjMoneyRemain - rateMoney, 2, MidpointRounding.AwayFromZero);
                        detail.SumMoney = rateMoney;
                        detail.SinglePrice = detail.SumMoney / detail.BuyCount;
                    }
                }
            }
        }

        private void BaseButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void skinCheckBoxPrint_CheckedChanged(object sender, EventArgs e)
        {
            config.PrintTicket = skinCheckBoxPrint.Checked;
            config.Save(CONFIG_PATH);
        }

        BalanceFormConfiguration config;
        public static String CONFIG_PATH = CommonGlobalUtil.AgileConfiguration("POS.ConfirmRefundFormConfiguration");
        private void LoadConfig()
        {
            try
            {
                config = BalanceFormConfiguration.Load(CONFIG_PATH) as BalanceFormConfiguration;
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
            if (config != null)
            {
                this.skinCheckBoxPrint.Checked = config.PrintTicket;
            }
            else
            {
                config = new BalanceFormConfiguration() { };
            }
        }

        private void ConfirmRefundForm_Load(object sender, EventArgs e)
        {

        }
    }
}
