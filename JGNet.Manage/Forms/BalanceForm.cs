using CCWin;
using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Common.Core.Util.IO.Print;
using JGNet.Core;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Manage;
using JGNet.Manage.Models;
using JGNet.Manage.Models.GA;
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
    public partial class BalanceForm : Common.BaseForm
    {
        private string guideID;
        private Member member;

        public DateTime createTime { get; }

        private List<RetailDetail> retailDetailList;
        private SalesPromotion salesPromotion;
        private decimal discountMoney;//优惠金额
        private decimal mjMoney;//满减金额
        private decimal totalOriginalAmount = 0;//货品原有总金额
        private decimal totalMoneyReceived = 0;//吊牌总价不扣除任何
        private decimal totalMoneyReceivedActual = 0;//实际扣除收到的现金总额
        private decimal moneyDiscounted = 0;//折扣、满减优惠金额
        private decimal moneyChange = 0;//找零金额
        private int totalCount = 0;//总数量
        private decimal totalCost = 0;//总进货成本
        private string promotionText = "";//当前满足的促销说明
        private decimal m_SmallMoneyRemoved = 0;//抹零（输入框中的值）
        private decimal m_MoneyCash = 0;//现金（输入框中的值）
        private decimal m_MoneyBankCard = 0;//银联卡（输入框中的值）
        private decimal m_MoneyStoredCard = 0;//VIP余额（输入框中的值）
        private decimal m_MoneyWeiXin = 0;//微信（输入框中的值）
        private decimal m_MoneyAlipay = 0;//支付宝（输入框中的值）
        private decimal m_MoneyElse = 0;//其他（输入框中的值）
        private decimal m_MoneyIntegration = 0;//积分返现（输入框中的值）
        BalanceFormConfiguration config = null;
        private DataGridView deepSourceDataGridView;
        public static String CONFIG_PATH = CommonGlobalUtil.AgileConfiguration("POS.BalanceFormConfiguration");
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
        private List<RetailDetail> sorceList=null;
        public BalanceForm(Member _member, List<RetailDetail> list, string shopID, bool currentIsInSingleDiscount, decimal _mjMoney,  SalesPromotion promotion, string guideID, string promotionText, DateTime createTime,DataGridView dgvRetail)
        {
            InitializeComponent();
            this.shopID = shopID;
            LoadConfig();
            sorceList = list;
            deepSourceDataGridView = dgvRetail;
            List<RetailDetail> tempList = new List<RetailDetail>();
            if (list != null)
            {
                foreach (var item in list)
                {
                    RetailDetail temp = new RetailDetail();
                    ReflectionHelper.CopyProperty(item, temp);
                    tempList.Add(temp);
                }
            }

            if (!currentIsInSingleDiscount)
            {
                this.salesPromotion = promotion;
                this.promotionText = promotionText;
                this.mjMoney = _mjMoney;
            }
            else {
                foreach (var item in tempList)
                {
                    item.InSalesPromotion = false; 
                }
            }
            //if (this.retailDetailList != null)
            //{
            //    foreach (RetailDetail detail in this.retailDetailList)
            //    {
                   
            //        this.totalMoneyReceived += detail.SumMoney;

            //    }
            //}

            this.guideID = guideID;
            this.member = _member;
            this.createTime = createTime;
           // this.sizeGroup = sizeGroup;
            this.retailDetailList = tempList;
            //计算最优惠的折扣
          

            textBox1.ValueChanged += TextBox1_ValueChanged; 
            skinTextBox_MoneyCash.ValueChanged += TextBox1_ValueChanged; 
            skinTextBox_MoneyBankCard.ValueChanged += TextBox1_ValueChanged; 
            skinTextBox_MoneyStoredCard.ValueChanged += TextBox1_ValueChanged; 
            skinTextBox_MoneyWeiXin.ValueChanged += TextBox1_ValueChanged;
            skinTextBox_MoneyAlipay.ValueChanged += TextBox1_ValueChanged;
            numericTextBoxElse.ValueChanged += TextBox1_ValueChanged;
            skinTextBox_MoneyIntegration.ValueChanged += TextBox1_ValueChanged;
            this.Initialize();
            CalcGiftTickets();
            MenuPermission = Common.Core.RolePermissionMenuEnum.收银;
        }

        private void TextBox1_ValueChanged(object obj)
        {
            this.UpdateMoneyValue();
        } 

        GiftTicketMatch[] matches = null;
        private List<GiftTicket> ticketsOrg = null;
        private List<RetailDetail> allRetailDetailListOrg = null;
        private void CalcGiftTickets()
        {

            try
            { 
                List<List<GiftTicketMatch>> matchePopulation = new List<List<GiftTicketMatch>>();

                //非会员不计算
                if (member != null)
                {   //找出所有订单中匹配优惠活动的款号信息 
                    //算出最划算的匹配信息
                    //获取所有优惠券信息 
                    ticketsOrg = GlobalCache.ServerProxy.GetValidGiftTickets(member.PhoneNumber);
                    SortTicket(ticketsOrg);

                    List<GiftTicket> temp = new List<GiftTicket>();
                    int tempDenomination = 0;
                    if (ticketsOrg != null && ticketsOrg.Count != 0)
                    {
                        //根据面额大小择优排序
                        for (int i = 0; i < ticketsOrg.Count - 1; ++i)
                        {
                            tempDenomination = i;
                            for (int j = i + 1; j < ticketsOrg.Count; ++j)
                            {
                                if (ticketsOrg[j].Denomination > ticketsOrg[tempDenomination].Denomination)
                                    tempDenomination = j;
                            }
                            GiftTicket t = ticketsOrg[tempDenomination];
                            ticketsOrg[tempDenomination] = ticketsOrg[i];
                            ticketsOrg[i] = t;
                            // Console.WriteLine("{0}",list[i]);
                        }

                        temp.AddRange(ticketsOrg);
                    }
                    ticketsOrg = temp;
                    //重新获取匹配的优惠信息
                    CheckTicketsForCostumes(ticketsOrg);
                    allRetailDetailListOrg = GetAllRetailDetails();
                   /* SortRetailDetail(allRetailDetailListOrg);
                    allRetailDetailListOrg.Reverse(); 

                    GiftTicketAlgorithm.RetailDetails = allRetailDetailListOrg;
                    GiftTicketAlgorithm.Tickets = ticketsOrg;
                    GiftTicketIndividual.SetDefaultGeneLength(allRetailDetailListOrg.Count);
                    GiftTicketPopulation pop = new GiftTicketPopulation(500, true);
                    Console.WriteLine("初始化种群");
                    Console.WriteLine(pop.ToString());
                    int bestScore = 0;

                    GiftTicketIndividual best = null;
                    for (int i = 0; i <50; i++)
                    {
                        GiftTicketPopulation newPop = GiftTicketAlgorithm.EvolvePopulation(pop);
                        Console.WriteLine("获取新种群" + i);
                        Console.WriteLine(newPop.ToString());
                        pop = newPop;
                        GiftTicketIndividual ind = pop.GetFittest();
                        Console.WriteLine("最优解" + ind);
                        int score = ind.GetFitness();
                        Console.WriteLine("分数" + score);


                        //如果分数相同,则判断是否是相同的解？
                        if (score == bestScore)
                        {
                            best = ind;
                            if (ind?.ToString() == best?.ToString()) {
                                //得到最优解
                                break;
                            }
                        }else
                        if (score > bestScore) {
                            bestScore = score;
                            best = ind;
                        }
                    }


                    //计算没有个体的集中性，取出最高概率的那个记录

                     
                    matches = best.GiftTicketMatches;
                    //
                    Console.WriteLine("得到最优的");
                    foreach (var item in matches)
                    {
                        if (item.Ticket != null)
                        {
                            //得到了就设置下关系
                            item.Ticket.CostumeID = item.Retail.CostumeID;
                            item.Retail.GiftTickets = item.Ticket.ID;
                            item.Retail.GiftTicketDenomination = item.Ticket.Denomination;
                         Console.WriteLine(item.Ticket.ToString());
                        }
                    }*/

                    //int discountMoney = 0; 
                    //foreach (GiftTicketMatch item in matches)
                    //{
                    //    if (item.Ticket != null)
                    //    {
                            
                    //           discountMoney += item.DiscountMoney(); 
                    //    }
                    //}
                   
                  //  UpdateRetailDetailGiftTickets();
                }
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }

        }

        private void UpdateRetailDetailGiftTickets( )
        {
          /*  List<GiftTicketMatch> matches = new List<GiftTicketMatch>();
            if (!skinCheckBoxNew.Checked)
            {
                //更新
                foreach (var item in retailDetailList)
                {
                    //切换了优惠券，这个值要重新拿吊牌总额
                    item.SumMoneyActual = item.SumMoney;
                    if (item.IsUseTickets)
                    {
                        item.GiftTickets = String.Empty;
                        if (item.SingleRetailDetails != null)
                        {
                            foreach (var single in item.SingleRetailDetails)
                            {
                                matches.Add(new GiftTicketMatch() { Retail = single, Ticket = ticketsOrg.Find(t => t.ID == single.GiftTickets) });
                                if (!String.IsNullOrEmpty(single.GiftTickets))
                                {
                                    item.GiftTickets += single.GiftTickets + ",";
                                    GiftTicket singleTicket = ticketsOrg.Find(t => t.ID == single.GiftTickets);
                                    single.GiftTicketDenomination = singleTicket.Denomination;
                                    //总实收-对应
                                    item.SumMoneyActual -= single.GiftTicketDenomination;


                                    CommonGlobalUtil.WriteLog(item.CostumeID + "扣除优惠券：" + single.GiftTicketDenomination + "后：" + item.SumMoneyActual);

                                    //   item.GiftTicketDenomination += single.GiftTicketDenomination;

                                }
                            }
                            if (!String.IsNullOrEmpty(item.GiftTickets))
                            {
                                item.GiftTickets = item.GiftTickets.Substring(0, item.GiftTickets.LastIndexOf(','));
                                //item.SumMoneyActual -= item.GiftTicketDenomination;

                            }
                        }
                    }
                }
            }
            int discountMoney = 0;
            if (!skinCheckBoxNew.Checked)
            {
                foreach (GiftTicketMatch item in matches)
                {
                    discountMoney += item.DiscountMoney();
                }
            }

            this.discountMoney = discountMoney;
            textBox1.Text = discountMoney.ToString();
            this.UpdateMoneyValue();*/
        }

        private void SortTicket(List<GiftTicket> ticketsOrg)
        {
            ticketsOrg.Sort((x, y) => {
                //优惠金额高的排前，有效时间小的排前
                if (x.Denomination > y.Denomination)
                {
                    if (x.ExpiredDate >= y.ExpiredDate)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (x.Denomination == y.Denomination)
                {
                    if (x.ExpiredDate >= y.ExpiredDate)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (x.ExpiredDate >= y.ExpiredDate)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            });
        }
        private void SortRetailDetail(List<RetailDetail> ticketsOrg)
        {
            ticketsOrg.Sort((x, y) => {
                //优惠金额高的排前，有效时间小的排前
                if (x.SumMoney > y.SumMoney)
                {
                    if (x.Discount >= y.Discount)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (x.SumMoney == y.SumMoney)
                {
                    if (x.Discount >= y.Discount)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (x.Price >= y.Price)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            });
        }

        private List<RetailDetail> GetAllRetailDetails()
        {
            List<RetailDetail> allRetailDetailList = new List<RetailDetail>();
            int j = 0;
            foreach (var item in retailDetailList)
            {
                //if (item.IsUseTickets)
                //{
                    item.AutoID = j++;
                    item.SingleRetailDetails = new List<RetailDetail>();
                    if (item.BuyCount > 1)
                    {

                        //all
                        for (int i = 0; i < item.BuyCount; i++)
                        {
                            RetailDetail detail = new RetailDetail();
                            CJBasic.Helpers.ReflectionHelper.CopyProperty(item, detail);
                            detail.BuyCount = 1;
                          //detail.GiftTickets = string.Empty;

                            //  detail.MatchGiftTickets = string.Empty;

                            detail.SumMoney = item.SumMoney / item.BuyCount;
                           // detail.SumMoneyActual = item.SumMoneyActual / item.BuyCount;
                            item.SingleRetailDetails.Add(detail);
                            allRetailDetailList.Add(detail);
                        }
                    }
                    else
                    {
                        RetailDetail detail = new RetailDetail();
                        CJBasic.Helpers.ReflectionHelper.CopyProperty(item, detail);
                        detail.SumMoney = item.SumMoney / item.BuyCount;
                       // detail.SumMoneyActual = item.SumMoneyActual / item.BuyCount;
                        detail.GiftTickets = string.Empty;
                        //if (!item.IsUseTickets)
                        //{
                        //    detail.MatchGiftTickets = string.Empty;
                        //}
                        item.SingleRetailDetails.Add(detail);
                        allRetailDetailList.Add(detail);
                    }
                //}

            }
            return allRetailDetailList;
        }

        private void Form_ItemSelected(GiftTicket ticket, EventArgs t2)
        {
            try
            {
                if (ticket != null)
                {
                    //重新设置匹配
                    this.giftTicketList = ticket.ID;
                    this.discountMoney = ticket.Denomination;
                    this.textBox1.Text = ticket.Denomination.ToString();
                    /*  ticket = match.Retail.CostumeID;
                      match.Retail.GiftTickets = ticket.ID;
                      match.Ticket = ticket;
                      // List<GiftTicket> memberList = (List<GiftTicket>)this.dataGridView1.DataSource;

                      //match
                      //重新设置match




                      GiftTicketList[index] = ticket;
                      BindingDataSource();*/
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        /// <summary>
        /// 判断是否可以使用优惠券
        /// </summary>
        /// <param name="tickets"></param>
        private void CheckTicketsForCostumes(List<GiftTicket> tickets)
        {


            //判断款号是否在优惠券使用范围中
            if (CommonGlobalCache.CostumeGiftTicketInfo != null)
            {
                if (CommonGlobalCache.CostumeGiftTicketInfo.IsUse)
                {

                    bool isflag = false;
                    foreach (var ticket in tickets)
                    {
                        foreach (var item in retailDetailList)
                        {
                            //if (CommonGlobalCache.CostumeGiftTicketInfo.CostumeIDs.Exists(t => t.ToUpper() == item.CostumeID.ToUpper()))
                            //{

                            bool iscanUserFlag = item.CanUseTickets;

                            item.MatchGiftTickets = string.Empty;
                            if (DateTime.Now >= ticket.EffectDate && ticket.ExpiredDate >= DateTime.Now)
                            { //满足条件

                                if (ticket.IsAnd)
                                {
                                    if (item.Discount >= ticket.MinDiscount
                                        && ticket.MinMoney != 0 && !item.IsBuyout
                                       // && this.totalMoneyReceived >= ticket.MinMoney
                                       && Convert.ToDecimal(this.skinLabel_TotalMoneySupposed.Text) >= ticket.MinMoney
                                        )

                                    {
                                        //满足折扣
                                        this.giftTicketList = ticket.ID;
                                        this.discountMoney = ticket.Denomination;
                                        textBox1.Text = ticket.Denomination.ToString();
                                        isflag = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    //满足其中一个即可
                                    if ((item.Discount >= ticket.MinDiscount && !item.IsBuyout) ||
                                       // this.totalMoneyReceived >= ticket.MinMoney
                                       (Convert.ToDecimal(this.skinLabel_TotalMoneySupposed.Text) >= ticket.MinMoney && !item.IsBuyout)
                                        )
                                    {
                                        //满足折扣
                                        this.giftTicketList = ticket.ID;

                                        this.discountMoney = ticket.Denomination;
                                        textBox1.Text = ticket.Denomination.ToString();
                                        isflag = true;
                                        break;
                                    }
                                }
                                //}
                                //} 
                                //    }
                                //}
                            }
                        }
                        if (isflag)
                        {
                            break;
                        }

                    }
                }
                else
                {

                //优惠劵设置了不参与商品

                bool isflag = false;

                    foreach (var ticket in tickets)
                {
                    decimal totalMoney = Convert.ToDecimal(this.skinLabel_TotalMoneySupposed.Text);
                    foreach (var item in retailDetailList)
                    {
                            String cId = CommonGlobalCache.CostumeGiftTicketInfo.CostumeIDs.Find(t => t == item.CostumeID);
                            if (String.IsNullOrEmpty(cId))
                            {

                                //bool iscanUserFlag = item.CanUseTickets;

                                item.MatchGiftTickets = string.Empty;
                                if (DateTime.Now >= ticket.EffectDate && ticket.ExpiredDate >= DateTime.Now)
                                { //满足条件

                                    if (ticket.IsAnd)
                                    {
                                        if (item.Discount >= ticket.MinDiscount
                                            && ticket.MinMoney != 0 && !item.IsBuyout
                                           // && this.totalMoneyReceived >= ticket.MinMoney
                                           && Convert.ToDecimal(totalMoney) >= ticket.MinMoney
                                            )

                                        {
                                            //满足折扣
                                            this.giftTicketList = ticket.ID;
                                            this.discountMoney = ticket.Denomination;
                                            textBox1.Text = ticket.Denomination.ToString();
                                            isflag = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        //满足其中一个即可
                                        if ((item.Discount >= ticket.MinDiscount && !item.IsBuyout) ||
                                           // this.totalMoneyReceived >= ticket.MinMoney
                                           (Convert.ToDecimal(totalMoney) >= ticket.MinMoney && !item.IsBuyout)
                                            )
                                        {
                                            //满足折扣
                                            this.giftTicketList = ticket.ID;

                                            this.discountMoney = ticket.Denomination;
                                            textBox1.Text = ticket.Denomination.ToString();
                                            isflag = true;
                                            break;
                                        }
                                    }
                                }
                                //}
                                //} 
                                //    }
                                //}
                            }
                            else {
                                totalMoney = totalMoney - item.SumMoney;
                            }
                    }
                    if (isflag)
                    {
                        break;
                    }

                }
            }
            }
          
        }

        private void Initialize()
        {
            
            if (this.member != null)
            {
                this.skinLabel_Money.Text = this.member.Balance.ToString();
                this.skinLabel_JFToMoeny.Text = Math.Round(this.member.CurrentIntegration * (decimal)1.0 / GlobalCache.IntegralConversionBalanceRatio, 2, MidpointRounding.ToEven).ToString();
            }
            else
            {
                this.skinTextBox_MoneyStoredCard.SkinTxt.Enabled = false;
                this.skinTextBox_MoneyIntegration.SkinTxt.Enabled = false;
            }
            if (this.retailDetailList != null)
            {
                foreach (RetailDetail detail in this.retailDetailList)
                {
                    this.totalOriginalAmount += detail.Price * detail.BuyCount;
                    //应收总吊牌金额
                   this.totalMoneyReceived += detail.SumMoney;
                    this.totalCount += detail.BuyCount;
                    this.totalCost += detail.CostPrice * detail.BuyCount;

                }
            }
            //应收金额扣除满减金额
            this.totalMoneyReceived -= this.mjMoney;
          
         // this.totalMoneyReceived -= this.discountMoney;
            this.moneyChange = -totalMoneyReceived+this.discountMoney;
            this.skinLabel_TotalOriginalAmount.Text = this.totalOriginalAmount.ToString();
            this.skinLabel_TotalMoneySupposed.Text =  this.totalMoneyReceived.ToString();
            this.skinLabel_MoneyChange.Text =  this.moneyChange.ToString();
            this.moneyDiscounted = this.totalOriginalAmount - this.totalMoneyReceived  ;
            this.skinLabel_DiscountMoney.Text = this.moneyDiscounted.ToString();
        }

        private String shopID;
        private RetailOrder retailOrder;
        private string giftTicketList;
        private void BaseButton_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                BaseButton_Submit.Enabled = false;
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
               
                if (this.member != null && this.m_MoneyStoredCard > this.member.Balance)
                {
                    GlobalMessageBox.Show("卡余额不足！");
                    return;
                }
                decimal moneyIntegration = string.IsNullOrEmpty(this.skinLabel_JFToMoeny.Text) ? 0 : decimal.Parse(this.skinLabel_JFToMoeny.Text);

                if (m_MoneyIntegration != 0)
                {
                    if ( moneyIntegration < this.m_MoneyIntegration)
                    {
                        GlobalMessageBox.Show("积分不足！");
                        return;
                    }
                }

                if (this.m_MoneyStoredCard + this.m_MoneyIntegration > this.totalMoneyReceived)
                {
                    GlobalMessageBox.Show("输入的积分返现金额与卡余额之和不能大于应收金额！");
                    return;
                }
                decimal refundAmount = decimal.Parse(this.skinLabel_MoneyChange.Text);
                if (!skinCheckBoxNew.Checked)
                {
                    if (refundAmount < 0)
                    {
                        GlobalMessageBox.Show("付款金额不足!");
                        return;
                    }
                }
                string id = GlobalCache.ServerProxy.GetRetailOrderID(); //IDHelper.GetID(OrderPrefix.RetailOrder, GlobalCache.GetShop(GlobalCache.CurrentShopID).AutoCode);
                decimal moneyVipCardMain = this.member == null ? this.m_MoneyStoredCard : this.m_MoneyStoredCard * (1 - (decimal)this.member.DonateCoef);
                decimal moneyVipCardDonate = this.member == null ? 0 : this.m_MoneyStoredCard * (decimal)this.member.DonateCoef;
                this.totalMoneyReceivedActual = this.totalMoneyReceived - this.m_MoneyIntegration - moneyVipCardDonate - this.discountMoney;

                CommonGlobalUtil.WriteLog("应收总金额：" + totalMoneyReceived);
                CommonGlobalUtil.WriteLog("积分：" + m_MoneyIntegration);
                CommonGlobalUtil.WriteLog("vip赠送金额：" + moneyVipCardDonate);
                CommonGlobalUtil.WriteLog("优惠券：" + discountMoney);
                CommonGlobalUtil.WriteLog("满减金额：" + this.mjMoney);
                CommonGlobalUtil.WriteLog("实收总金额：" + totalMoneyReceivedActual);
                if (this.skinCheckBoxNew.Checked)
                {
                    if (this.salesPromotion != null)
                    {
                        this.salesPromotion.ID = String.Empty;
                    }
                    this.discountMoney = 0;
                    this.totalMoneyReceivedActual = 0;
                    this.totalMoneyReceived =Convert.ToDecimal(this.skinLabel_TotalMoneySupposed.Text);
                    this.promotionText = "未付款，不参与任何促销优惠";
                }
                //  String orderId =
                //重新获取订单编号 
                //  bool isNotPay = this.skinCheckBoxNew.Checked;

                retailOrder = new RetailOrder()
                {
                    ID = id,
                    MemeberID = this.member == null ? string.Empty : this.member.PhoneNumber,
                    MoneyCash = this.m_MoneyCash,
                    MoneyCash2 = this.m_MoneyCash - this.moneyChange,
                    MoneyVipCard = this.m_MoneyStoredCard,
                    MoneyVipCardMain = moneyVipCardMain,
                    MoneyVipCardDonate = moneyVipCardDonate,
                    MoneyBankCard = this.m_MoneyBankCard,
                    MoneyWeiXin = this.m_MoneyWeiXin,
                    MoneyAlipay = this.m_MoneyAlipay,
                    MoneyOther = this.m_MoneyElse,
                    MoneyIntegration = this.m_MoneyIntegration,
                    SmallMoneyRemoved = this.m_SmallMoneyRemoved,
                    TotalPrice = this.totalOriginalAmount,
                    MoneyDiscounted = this.moneyDiscounted,
                    TotalMoneyReceived = this.totalMoneyReceived,
                    TotalMoneyReceivedActual = this.totalMoneyReceivedActual,
                    ShopID = shopID,
                    Remarks = this.rtfRichTextBox_Remarks.Text,
                    TotalCount = this.totalCount,
                    CreateTime = createTime,
                       
                    EntryTime = DateTime.Now,
                    EntryUserID = CommonGlobalCache.CurrentUserID,
                    MoneyChange = this.moneyChange,
                    SalesPromotionID = this.salesPromotion == null ? String.Empty : this.salesPromotion.ID,
                    GuideID = this.guideID,
                    TotalCost = this.totalCost,
                    //已经满减了
                    Benefit = this.totalMoneyReceivedActual - this.totalCost,
                    PromotionText = this.promotionText,
                    IsRefundOrder = false,
                    OperateGuideID = this.guideID,
                    MoneyDeductedByTicket = this.discountMoney,
                    IsNotPay = this.skinCheckBoxNew.Checked,
                    GiftTicket = this.giftTicketList,
                };
                 

                List<RetailDetail> retailDetailListWithoutBuyout = retailDetailList.FindAll(t => !t.IsBuyout);
                List<RetailDetail> retailDetailListBuyout = retailDetailList.FindAll(t => t.IsBuyout);

                if (skinCheckBoxNew.Checked)
                 
                {
                     foreach (RetailDetail detail in retailDetailListWithoutBuyout)
                     {
                             List<CostumeItem> resultList = CommonGlobalCache.ServerProxy.GetCostumeStoreList(
                                               new CostumeStoreListPara()
                                               {
                                                   CostumeID = detail.CostumeID,
                                                   ShopID = shopID,
                                                   IsOnlyShowValid = true,
                                                   IsAccurateQuery = true,
                                               });
                             decimal saleprice = 0;
                             CostumeStore reslutList=new CostumeStore() ;
                             if (resultList != null && resultList.Count > 0)
                             {
                                 List<CostumeStore> lStore = resultList[0].CostumeStoreList;
                                 reslutList = lStore.Find(t => t.ColorName == detail.ColorName);
                                 if (reslutList.SalePrice < reslutList.Price)
                                 {
                                     saleprice = reslutList.Price;

                                 }
                                 else
                                 {
                                     saleprice = reslutList.SalePrice;
                                 }
                                 //saleprice = resultList[0].CostumeStoreList[].Price;
                             }
                             detail.Price = saleprice;
                             detail.Discount = saleprice / reslutList.Price * 100;
                             
                             detail.SumMoney = detail.Price*detail.BuyCount;
                            
                 }
                }
                RetailCostume retailCostume = new RetailCostume()
                {
                    RetailDetailList = this.retailDetailList,
                    RetailOrder = retailOrder
                };

                foreach (var item in retailDetailList)
                {
                    item.RetailOrderID = id;
                    CostumeSalePriceConfiguration costumeSalePrice = new CostumeSalePriceConfiguration();
                    costumeSalePrice.price = item.SinglePrice;
                 //  item.SalePrice = item.SinglePrice;
                    costumeSalePrice.Save(CommonGlobalUtil.AgileConfiguration("Pos//SalePrice//"+GlobalCache.CurrentShopID+"//" + item.CostumeID));
                }
                


                InteractResult result = GlobalCache.ServerProxy.RetailCostume(retailCostume);
             
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("结算成功！");
                        this.DialogResult = DialogResult.OK;
                        if (skinCheckBoxPrint.Checked)
                        {
                            OrderPrintUtil printHelper = new OrderPrintUtil();
                            int times = CommonGlobalUtil.ConvertToInt32(GlobalCache.GetParameter(ParameterConfigKey.PrintCount).ParaValue);
                            DataGridView dgv = deepCopyDataGridView();
                            printHelper.Print(retailCostume, times, dgv);
                        }

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
                BaseButton_Submit.Enabled = true;
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



            List<RetailDetail> listtb1 = retailDetailList;

            List<RetailDetail> tb2 = new List<RetailDetail>();
            int autoID = 0;
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

            //deepSourceDataGridView.Columns.RemoveAt(deepSourceDataGridView.Columns.Count - 1);
           // deepSourceDataGridView.Columns.RemoveAt(deepSourceDataGridView.Columns.Count -1);
            for (int i = 0; i < deepSourceDataGridView.Columns.Count; i++)
             {
                if (deepSourceDataGridView.Columns[i].Name != "Column3" && deepSourceDataGridView.Columns[i].Name != "Delete")
                {
                    dgvTmp.Columns.Add(deepSourceDataGridView.Columns[i].Name, deepSourceDataGridView.Columns[i].HeaderText);
                    if (deepSourceDataGridView.Columns[i].DefaultCellStyle.Format.Contains("N")) //使导出Excel文档金额列可做SUM运算
                    {
                        dgvTmp.Columns[i + 1].DefaultCellStyle.Format = deepSourceDataGridView.Columns[i].DefaultCellStyle.Format;

                    }
                    if (!deepSourceDataGridView.Columns[i].Visible)
                    {
                        dgvTmp.Columns[i + 1].Visible = false;
                    }
                    dgvTmp.Columns[i + 1].DataPropertyName = deepSourceDataGridView.Columns[i].DataPropertyName;
                    if (deepSourceDataGridView.Columns[i].HeaderText == "单价") { dgvTmp.Columns[i + 1].HeaderText = "吊牌价"; }
                    else if (deepSourceDataGridView.Columns[i].HeaderText == "销售额") { dgvTmp.Columns[i + 1].HeaderText = "金额"; }
                    else
                    {
                        dgvTmp.Columns[i + 1].HeaderText = deepSourceDataGridView.Columns[i].HeaderText;
                    }
                    dgvTmp.Columns[i + 1].Tag = deepSourceDataGridView.Columns[i].Tag;
                    dgvTmp.Columns[i + 1].Name = deepSourceDataGridView.Columns[i].Name;
                }
             }
            //DataGridViewTextBoxColumn dgvColumnRemark = new DataGridViewTextBoxColumn();
            //dgvColumnRemark.Name = "备注";
            //dgvColumnRemark.HeaderText = "备注";
            //dgvColumnRemark.Visible = true;
            //dgvColumnRemark.DataPropertyName = "Remarks";
            //dgvTmp.Columns.Add(dgvColumnRemark);


            dgvTmp.DataSource = tb2;


            return dgvTmp;
        }

        private void skinTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.UpdateMoneyValue();
            }
        }

        /// <summary>
        /// 当输入付款金额后，更新界面上的总计和应付款金额值
        /// </summary>
        private void UpdateMoneyValue()
        {
            try
            {
                this.m_MoneyCash = String.IsNullOrEmpty(this.skinTextBox_MoneyCash.SkinTxt.Text) ? 0 : decimal.Parse(this.skinTextBox_MoneyCash.SkinTxt.Text);
                this.m_MoneyBankCard = String.IsNullOrEmpty(this.skinTextBox_MoneyBankCard.SkinTxt.Text) ? 0 : decimal.Parse(this.skinTextBox_MoneyBankCard.SkinTxt.Text);
                this.m_MoneyStoredCard = String.IsNullOrEmpty(this.skinTextBox_MoneyStoredCard.SkinTxt.Text) ? 0 : decimal.Parse(this.skinTextBox_MoneyStoredCard.SkinTxt.Text);
                this.m_MoneyWeiXin = String.IsNullOrEmpty(this.skinTextBox_MoneyWeiXin.SkinTxt.Text) ? 0 : decimal.Parse(this.skinTextBox_MoneyWeiXin.SkinTxt.Text);
                this.m_MoneyAlipay = String.IsNullOrEmpty(this.skinTextBox_MoneyAlipay.SkinTxt.Text) ? 0 : decimal.Parse(this.skinTextBox_MoneyAlipay.SkinTxt.Text);
                this.m_MoneyElse = String.IsNullOrEmpty(this.numericTextBoxElse.SkinTxt.Text) ? 0 : decimal.Parse(this.numericTextBoxElse.SkinTxt.Text);

                this.m_MoneyIntegration = String.IsNullOrEmpty(this.skinTextBox_MoneyIntegration.SkinTxt.Text) ? 0 : decimal.Parse(this.skinTextBox_MoneyIntegration.SkinTxt.Text);
                decimal zongji = this.m_MoneyCash + this.m_MoneyBankCard + this.m_MoneyStoredCard + this.m_MoneyWeiXin + this.m_MoneyAlipay + m_MoneyElse + this.m_MoneyIntegration
                    + this.discountMoney;
                this.skinLabel_TotalMoney.Text = zongji.ToString();
                this.moneyChange = zongji - this.totalMoneyReceived;
                this.skinLabel_MoneyChange.Text = this.moneyChange.ToString();
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
               // GlobalMessageBox.Show("输入金额格式不正确");
            }
        }
         

        private void BaseButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    

        private void BaseButton_TakeInteger_Click(object sender, EventArgs e)
        {
            try
            {
                decimal newSmallMoneyRemoved = decimal.Parse(this.skinTextBox_TakeInteger.SkinTxt.Text);
                if (newSmallMoneyRemoved > GlobalCache.GetShop(this.shopID).MaxChangeRemoved)
                {
                    GlobalMessageBox.Show(string.Format("抹零金额不能大于店铺的最大抹零金额：{0}元", GlobalCache.GetShop(this.shopID).MaxChangeRemoved));
                    return;
                }

                decimal oldSmallMoneyRemoved = 0;
                if (this.m_SmallMoneyRemoved != 0)
                {
                    oldSmallMoneyRemoved = this.m_SmallMoneyRemoved;
                }
                this.m_SmallMoneyRemoved = newSmallMoneyRemoved;

                this.skinLabel_TakeIntegerMoney.Text = this.m_SmallMoneyRemoved.ToString();
                this.totalMoneyReceived = this.totalMoneyReceived + oldSmallMoneyRemoved - this.m_SmallMoneyRemoved;
                this.skinLabel_TotalMoneySupposed.Text = this.totalMoneyReceived.ToString();
                this.skinLabel_MoneyChange.Text = this.moneyChange.ToString();
                this.moneyChange = this.moneyChange - oldSmallMoneyRemoved + this.m_SmallMoneyRemoved;
                this.skinTextBox_TakeInteger.SkinTxt.Text = "";
                UpdateMoneyValue();
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
                GlobalMessageBox.Show("抹零金额格式不正确");
            }
        }
         

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (member != null)
            {
                GiftTicketRichForm form = new GiftTicketRichForm(ticketsOrg, allRetailDetailListOrg, matches, this.totalMoneyReceived);
                form.ItemSelected += Form_ItemSelected;
                form.ShowDialog();
            }
        }

      /*  private void Form_TicketChanged(string ticketId, EventArgs t2)
        {
            // this.matches = matches?.ToArray();
            giftTicketList = ticketId;
           // matchTickets = giftTickets;
          //  UpdateRetailDetailGiftTickets();
        }*/
        

        private void skinCheckBoxPrint_CheckedChanged(object sender, EventArgs e)
        {
            config.PrintTicket = skinCheckBoxPrint.Checked;
            config.Save(CONFIG_PATH);
        }

        private void skinCheckBoxNew_CheckedChanged(object sender, EventArgs e)
        {
            if (skinCheckBoxNew.Checked)
            {
                pictureBox1.Enabled = false;
                textBox1.Text = "0";
                GiftTicketMatch[] tempT = null;
                this.skinLabel_TotalMoney.Text = "0";
                this.matches = tempT;
                
                decimal sum = 0;
                skinTextBox_MoneyCash.Enabled = false;
                skinTextBox_MoneyBankCard.Enabled = false;
                skinTextBox_MoneyStoredCard.Enabled = false;
                skinTextBox_MoneyWeiXin.Enabled = false;
                skinTextBox_MoneyAlipay.Enabled = false;
                numericTextBoxElse.Enabled = false;
                skinTextBox_MoneyIntegration.Enabled = false;
                skinTextBox_TakeInteger.Enabled = false;
                BaseButton_TakeInteger.Enabled = false;
                skinTextBox_MoneyCash.Text = "";
                skinTextBox_MoneyBankCard.Text = "";
                skinTextBox_MoneyStoredCard.Text = "";
                skinTextBox_MoneyWeiXin.Text = "";
                skinTextBox_MoneyAlipay.Text = "";
                numericTextBoxElse.Text = "";
                skinTextBox_MoneyIntegration.Text = "";
                skinTextBox_TakeInteger.Text = "";
                BaseButton_TakeInteger.Text = "";
                this.giftTicketList = "";
                 this.discountMoney = 0;
                decimal zongji = 0;
              
                foreach (RetailDetail curItem in sorceList)
                {
                    List<CostumeItem> resultList = CommonGlobalCache.ServerProxy.GetCostumeStoreList(
                   new CostumeStoreListPara()
                   {
                       CostumeID = curItem.CostumeID,
                       ShopID = shopID,
                       IsOnlyShowValid = true,
                       IsAccurateQuery = true,
                   });
                    decimal saleprice=0;
                    if (resultList != null && resultList.Count > 0)
                    {
                        List<CostumeStore> lStore = resultList[0].CostumeStoreList;
                        CostumeStore reslutList = lStore.Find(t => t.ColorName == curItem.ColorName);
                        if (reslutList.SalePrice < reslutList.Price)
                        {
                            saleprice = reslutList.Price;

                        }
                        else
                        {
                            saleprice = reslutList.SalePrice;
                        }
                        //saleprice = resultList[0].CostumeStoreList[].Price;
                    }
                    //if (!curItem.IsBuyout)
                    //{
                    //    CostumeStore store = resultList[0].CostumeStoreList.Find(t => t.ColorName == curItem.ColorName || t.CostumeID == curItem.CostumeID);
                    //    if (store != null)
                    //    {
                    //        saleprice = store.SalePrice;
                    //    }
                    //}

                    sum += saleprice * curItem.BuyCount;
                }
                skinLabel_TotalMoneySupposed.Text = sum.ToString();
                decimal payfor = Convert.ToDecimal(skinLabel_TotalMoneySupposed.Text);
                this.moneyChange = zongji - sum;
                decimal returnPay = zongji - payfor;
                this.skinLabel_MoneyChange.Text = returnPay.ToString();
                textBox1.Text = "0";


                this.skinLabel_DiscountMoney.Text = (this.totalOriginalAmount - sum).ToString();

            }
            else
            {
                pictureBox1.Enabled = true;
                skinTextBox_MoneyCash.Enabled = true;
                skinTextBox_MoneyBankCard.Enabled = true;
                skinTextBox_MoneyStoredCard.Enabled = true;
                skinTextBox_MoneyWeiXin.Enabled = true;
                skinTextBox_MoneyAlipay.Enabled = true;
                numericTextBoxElse.Enabled = true;
                skinTextBox_MoneyIntegration.Enabled = true;
                skinTextBox_TakeInteger.Enabled = true;
                BaseButton_TakeInteger.Enabled = true;
                this.skinLabel_DiscountMoney.Text = this.moneyDiscounted.ToString();
                if (ticketsOrg != null && ticketsOrg.Count > 0)
                {
                    CheckTicketsForCostumes(ticketsOrg);
                }
                 
                //UpdateRetailDetailGiftTickets();
                UpdateMoneyValue();

            }
        }
    }
}
