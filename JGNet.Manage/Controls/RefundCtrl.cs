using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core.InteractEntity;
using CCWin;
using JGNet.Core;
using CJBasic.Loggers;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Server.Tools;
using JGNet.Common.Core;

namespace JGNet.Manage
{
    public partial class RefundCtrl : Common.Core.BaseModifyUserControl
    {

        private RetailCostume currentRetailCostume;
        private RetailCostume originalRetailCostume;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public RefundCtrl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {

            if (!HasPermission(RolePermissionMenuEnum.退货, RolePermissionEnum.单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
            skinComboBoxShopID.Initialize(true);
            skinComboBoxShopID.SelectedValue = GlobalCache.CurrentShopID;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] { remarksDataGridViewTextBoxColumn });
            dataGridViewPagingSumCtrl.Initialize();
             this.guideComboBox1.Initialize(GuideComboBoxInitializeType.Null, shopID);
             if (CommonGlobalCache.CurrentUser.Type == UserInfoType.Guide)
             {
                 this.guideComboBox1.SelectedValue = GlobalCache.CurrentUserID;
             }
            this.retailOrderIDTextBox1.OrderSelected += RetailOrderIDTextBox1_OrderSelected;
            balanceRound = GlobalCache.GetParameter(ParameterConfigKey.RetailBalanceRound)?.ParaValue == "1";// CommonGlobalUtil.GetOptionValueBoolean(OptionConfiguration.OPTION_CONFIGURATION_KEY_BALANCE_ROUND);
        }

        public RefundCtrl(RetailOrder order)
        {
            InitializeComponent();

            Init();
            if (!HasPermission(RolePermissionMenuEnum.销售退货单查询, RolePermissionEnum.重做_单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
            this.redoOrder = order;
        }

        private void Redo(RetailOrder order)
        {
            //  List<RetailDetail> details = CommonGlobalCache.ServerProxy.GetRetailDetailList(order.OriginOrderID);
            retailOrderIDTextBox1.Text = order.OriginOrderID;
            skinComboBoxShopID.SelectedValue = order.ShopID;
            guideComboBox1.SelectedValue = order.GuideID;
            dateTimePicker_Start.Value = order.CreateTime;
            retailOrderIDTextBox1.PerformClick();
        }

        private bool balanceRound = true;
        private RetailOrder redoOrder;

        private void RetailOrderIDTextBox1_OrderSelected(RetailOrder retailOrder)
        {
            try
            {
                if (retailOrder == null)
                {
                    return;
                }
                this.retailOrderIDTextBox1.SkinTxt.Text = retailOrder.ID;
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                this.originalRetailCostume = GlobalCache.ServerProxy.GetOneRetailCostume(retailOrder.ID);
                if (this.originalRetailCostume == null)
                {
                    return;
                }
                this.currentRetailCostume = this.originalRetailCostume;
                RetailOrder order = this.currentRetailCostume.RetailOrder;
                foreach (RetailDetail detail in this.currentRetailCostume.RetailDetailList)
                {
                    detail.IsRefund = true;
                    detail.RefundCount = detail.BuyCount;

                }
                #region 设置标签信息
                Member member = GlobalCache.ServerProxy.GetOneMember(order.MemeberID);
                if (member != null)
                {
                    this.skinLabel_MemberName.Text = member.Name;
                }
                else
                {
                    this.skinLabel_MemberName.Text = "";
                }
                this.skinLabel_MemberID.Text = order.MemeberID;
                this.skinLabel_GuideID.Text = GlobalCache.GetUserName(order.GuideID);
                // SalesPromotion salesPromotion = GlobalCache.ServerProxy.GetOneSalesPromotion(order.SalesPromotionID);
                //  if (salesPromotion != null)
                // {
                //  this.skinLabel_SalesPromotion.Text = salesPromotion.Name;
                // }
                // else
                //  {
                //   this.skinLabel_SalesPromotion.Text = "";
                // }
                this.skinLabel_SalesPromotion.Text = order.PromotionText;

                this.skinLabel_MoneyIntegration.Text = order.MoneyIntegration.ToString();
                this.skinLabel_MoneyStoredCard.Text = order.MoneyVipCard.ToString();
                this.skinLabel_TotalMoneyReceived.Text = order.TotalMoneyReceived.ToString();
                skinLabel_SmallMoneyRemoved.Text = retailOrder.SmallMoneyRemoved.ToString();
                this.skinLabel_MoneyCash.Text = retailOrder.MoneyCash.ToString();
                this.skinLabel_MoneyStoredCard.Text = retailOrder.MoneyVipCard.ToString();
                this.skinLabel_MoneyBankCard.Text = retailOrder.MoneyBankCard.ToString();
                this.skinLabel_MoneyWeiXin.Text = retailOrder.MoneyWeiXin.ToString();
                this.skinLabel_MoneyAlipay.Text = retailOrder.MoneyAlipay.ToString();
                this.skinLabelOther.Text = retailOrder.MoneyOther.ToString();
                this.skinLabel_MoneyChange.Text = retailOrder.MoneyChange.ToString();
                this.skinLabelGiftTicket.Text = retailOrder.MoneyDeductedByTicket.ToString();
                skinLabel_remark.Text = retailOrder.Remarks;

                #endregion

                #region 绑定数据源
                this.BindingRetailCostumeSource();
                #endregion
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
                GlobalMessageBox.Show("查询失败！");
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }


        private void BindingRetailCostumeSource()
        {

            string selectShopid = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);

            List<Guide> guideList = CommonGlobalCache.GuideList.FindAll(t => t.State == 0 && t.ShopID== selectShopid);

                this.GuideName.DataSource = guideList;
                this.GuideName.DisplayMember = "Name";
                this.GuideName.ValueMember = "ID";

            if (this.currentRetailCostume.RetailDetailList != null && this.currentRetailCostume.RetailDetailList.Count > 0)
            {
                foreach (RetailDetail detail in this.currentRetailCostume.RetailDetailList)
                {
                    detail.CostumeName = GlobalCache.GetCostumeName(detail.CostumeID);
                    detail.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(detail.CostumeID, detail.SizeName);
                }
            }

            this.dataGridViewPagingSumCtrl.SetDataSource<RetailDetail>(DataGridViewUtil.ListToBindingList(this.currentRetailCostume?.RetailDetailList));
        }

        private void BaseButton_ConfirmRefund_Click(object sender, EventArgs e)
        {
            try
            {

                if (originalRetailCostume == null)
                {

                    GlobalMessageBox.Show("请选择销售单！");
                    return;
                }
                if (!string.IsNullOrEmpty(this.originalRetailCostume.RetailOrder.RefundOrderID))
                {
                    GlobalMessageBox.Show("该销售单号已经退过货，不能再次退货！");
                    return;
                }
                if (this.originalRetailCostume.RetailOrder.IsCancel)
                {
                    GlobalMessageBox.Show("该销售单号已被冲单！");
                    return;
                }

                if (this.guideComboBox1.SelectedIndex == 0)
                {
                    GlobalMessageBox.Show("该笔单的导购员不能为空！");
                    return;
                }
                string id = IDHelper.GetID(OrderPrefix.RefundOrder, GlobalCache.GetShop(shopID).AutoCode);

                //if (this.currentRetailCostume.RetailOrder.ShopID != shopID || this.currentRetailCostume.RetailOrder.EmOnline)
                //{
                //    GlobalMessageBox.Show("该商品不是在本店销售的，不能退货！");
                //    return;
                //}
                bool isNoHasGuidFlag = false;
                if (this.currentRetailCostume.RetailDetailList != null && this.currentRetailCostume.RetailDetailList.Count > 0)
                {
                    foreach (RetailDetail detail in this.currentRetailCostume.RetailDetailList)
                    {
                        if (detail.GuideID == null || detail.GuideID == "")
                        {
                            isNoHasGuidFlag = true;
                            break;
                        }
                    }
                }
                if (isNoHasGuidFlag)
                {
                    GlobalMessageBox.Show("导购员不能为空，请检查列表里所有款号的导购员！");
                    return;
                }

                #region 创建RefundCostume对象


                string selectShopid = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);

                List<Guide> guideList = CommonGlobalCache.GuideList.FindAll(t => t.State == 0 && t.ShopID == selectShopid);

                this.GuideName.DataSource = guideList;
                this.GuideName.DisplayMember = "Name";
                this.GuideName.ValueMember = "ID";

                RefundCostume costume = new RefundCostume()
                {
                    RefundOrder = null,
                    RefundDetailList = new List<RetailDetail>()
                };
                int totalCount = 0;
                decimal totalPrice = 0;
                decimal totalCost = 0;
                foreach (RetailDetail detail in this.currentRetailCostume.RetailDetailList)
                {
                    if (detail.IsRefund && detail.RefundCount > 0)
                    {
                        totalCount += detail.RefundCount;
                        totalPrice += detail.RefundCount * detail.Price;
                        totalCost += detail.RefundCount * detail.CostPrice;

                        costume.RefundDetailList.Add(this.RetailDetailToRefundDetail(detail, id));
                    }
                }
                List<String> costumeIds = new List<string>();
                foreach (var item in costume.RefundDetailList)
                {
                    if (!costumeIds.Contains(item.CostumeID))
                    {
                        costumeIds.Add(item.CostumeID);
                    }
                }

                if (costumeIds != null && costumeIds.Count > 0)
                {
                    //判断是否又禁用的商品，并提示返回
                    InteractResult interactResult = GlobalCache.ServerProxy.IsCostumeValid(costumeIds);
                    if (interactResult.ExeResult == ExeResult.Error)
                    {
                        GlobalMessageBox.Show(interactResult.Msg);
                        return;
                    }
                }

                RetailOrder refundOrder = new RetailOrder()
                {
                    ID = id,
                    IsRefundOrder = true,
                    OriginOrderID = this.currentRetailCostume.RetailOrder.ID,
                   // GuideID = this.currentRetailCostume.RetailOrder.GuideID,
                  //  OperateGuideID = this.currentRetailCostume.RetailOrder.GuideID,
                    GuideID = (string)this.guideComboBox1.SelectedValue,
                    ShopID = shopID,
                    MemeberID = this.currentRetailCostume.RetailOrder.MemeberID,
                    SalesPromotionID = this.currentRetailCostume.RetailOrder.SalesPromotionID,
                    PromotionText = this.currentRetailCostume.RetailOrder.PromotionText,
                    EntryUserID = CommonGlobalCache.CurrentUserID,
                    //   TotalMoneyReceived = this.currentRetailCostume.RetailOrder.TotalMoneyReceived,
                    // TotalMoneyReceivedActual = this.currentRetailCostume.RetailOrder.TotalMoneyReceivedActual,
                    MoneyBankCard = 0,
                    MoneyWeiXin = 0,
                    MoneyAlipay = 0,
                    MoneyOther = 0,
                    SmallMoneyRemoved = 0,
                    MoneyChange = 0,
                    TotalCount = totalCount * -1,
                    TotalCost = totalCost * -1,
                    TotalPrice = totalPrice * -1,
                    MoneyDiscounted = -totalCount == this.originalRetailCostume.RetailOrder.TotalCount ? this.originalRetailCostume.RetailOrder.MoneyDiscounted * -1 : 0,//若是全部退款，折扣金额为原始折扣金额，否则为0
                    Remarks = this.skinTextBox_RefundReason.SkinTxt.Text.Trim(),
                    CreateTime = dateTimePicker_Start.Value,
                    EntryTime = DateTime.Now, 
                    IsNotPay = this.currentRetailCostume.RetailOrder.IsNotPay,
                };
                costume.RefundOrder = refundOrder;
                #endregion
                decimal sourceTotalMoneyReceived = this.currentRetailCostume.RetailOrder.TotalMoneyReceived;

                #region 根据活动获取退款的金额，并赋值给RefundCostume
                decimal originalDonate = 0;
                if (this.originalRetailCostume.RetailOrder.MoneyVipCard != 0)
                {
                    originalDonate = this.originalRetailCostume.RetailOrder.MoneyVipCardDonate / this.originalRetailCostume.RetailOrder.MoneyVipCard;
                }
                //应该退还的金额

                decimal moneyBuyByTicket = CalGiftTicket(costume);

                SettlementMoney settlementMoney = new SettlementMoney(balanceRound);

                RefundMoney refundMoney = settlementMoney.GetRefundMoney(this.originalRetailCostume, costume, moneyBuyByTicket, GlobalCache.GetSalesPromotionFromAll(this.originalRetailCostume.RetailOrder.SalesPromotionID), GlobalCache.CurrentShop.MinDiscount);
                costume.RefundOrder.MoneyCash = refundMoney.RefundCash * -1;
                costume.RefundOrder.MoneyCash2 = costume.RefundOrder.MoneyCash;
                costume.RefundOrder.MoneyIntegration = refundMoney.RefundIntegration * -1;
                costume.RefundOrder.MoneyVipCard = refundMoney.RefundStoredCard * -1;
                costume.RefundOrder.MoneyVipCardMain = refundMoney.RefundStoredCard * (1 - originalDonate) * -1;
                costume.RefundOrder.MoneyVipCardDonate = refundMoney.RefundStoredCard * originalDonate * -1;
                //costume.RefundOrder.MoneyBuyByTicket = moneyBuyByTicket;
                costume.RefundOrder.RetailMoneyDeductedByTicket = originalRetailCostume.RetailOrder.MoneyDeductedByTicket;
                costume.RefundOrder.MoneyDeductedByTicket = moneyBuyByTicket;

                //总计=现金+积分+VIP卡+优惠券
                //这笔单的应收金额 - （不退的那几件以原价* 数量 -满减金额） - （退的那几件）优惠券
                costume.RefundOrder.TotalMoneyReceived = costume.RefundOrder.MoneyCash + costume.RefundOrder.MoneyIntegration + costume.RefundOrder.MoneyVipCard;
                costume.RefundOrder.TotalMoneyReceivedActual = costume.RefundOrder.MoneyCash + costume.RefundOrder.MoneyVipCardMain;
                costume.RefundOrder.Benefit = costume.RefundOrder.TotalMoneyReceivedActual - costume.RefundOrder.TotalCost;
                ////平摊

                #endregion
                if (Math.Abs(costume.RefundOrder.TotalCount) < 1)
                {
                    GlobalMessageBox.Show("退货数量不能小于1");
                    return;
                }


                //foreach (RetailDetail detail in costume.RefundDetailList)
                //{
                //    if (detail.IsRefund && detail.RefundCount > 0)
                //    {
                //        detail.SinglePrice = detail.SumMoney / detail.BuyCount * -1;
                //    }
                //}

                ConfirmRefundForm confirmRefundForm = new ConfirmRefundForm(costume, shopID,this.dataGridView1, sourceTotalMoneyReceived,1);
                DialogResult result = confirmRefundForm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                this.ResetForm();
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        private decimal CalGiftTicket(RefundCostume costume)
        {
            decimal moneyBuyByTicket = 0;
            if (costume.RefundDetailList != null)
            {  //只有退货部分
                foreach (var item in originalRetailCostume.RetailDetailList)
                {
                    /* RetailDetail retailDetail = null;
                     foreach (var retail in this.originalRetailCostume.RetailDetailList)
                     {

                         if (retail.CostumeID.ToUpper() == item.CostumeID.ToUpper() && retail.ColorName == item.ColorName && retail.SizeName == item.SizeName)
                         {
                             //找到对应的订购明细
                             retailDetail = retail;
                             break;
                         }
                     }*/

                    if (item.GiftTicketMoney > 0)
                    {
                        int returnCount = 0;
                        if (!item.IsRefund)
                        {
                            returnCount = 0;
                        }
                        else
                        {
                            returnCount = item.RefundCount;
                        }
                        moneyBuyByTicket += decimal.Round(item.GiftTicketMoney / item.BuyCount * (item.BuyCount - returnCount), 2);
                    }
                    else
                    {
                        moneyBuyByTicket += item.GiftTicketMoney;
                    }

                    /* if (!String.IsNullOrEmpty(item.GiftTickets))
                     {

                         List<GiftTicket> list = GlobalCache.ServerProxy.GetGiftTicket4RetailDetail(item.GiftTickets);
                         //计算最少的优惠券金额
                         List<GiftTicket> minList = new List<GiftTicket>();
                         if (list != null)
                         {


                             RetailDetail retailDetail = null;
                             foreach (var retail in this.originalRetailCostume.RetailDetailList)
                             {

                                 if (retail.CostumeID.ToUpper() == item.CostumeID.ToUpper() && retail.ColorName == item.ColorName && retail.SizeName == item.SizeName)
                                 {
                                     //找到对应的订购明细
                                     retailDetail = retail;
                                     break;
                                 }
                             }
                             //只拿买入的
                             for (int i = 0; i < retailDetail.BuyCount - item.RefundCount; i++)
                             {
                                 //if (item.RefundCount)
                                 GiftTicket minTicket = null;
                                 foreach (var ticket in list)
                                 {
                                     if (minTicket != null)
                                     {
                                         if (ticket.Denomination < minTicket.Denomination)
                                         {
                                             minTicket = ticket;
                                         }
                                     }
                                     else
                                     {
                                         minTicket = ticket;
                                     }
                                 }
                                 minList.Add(minTicket);
                                 list.Remove(minTicket);
                             }
                         }

                         if (minList != null)
                         {
                             foreach (var minItem in minList)
                             {
                                 //买入的优惠券
                                 moneyBuyByTicket += minItem.Denomination;
                             }
                         }
                     }*/
                }

            }


            /*if (originalRetailCostume.RetailDetailList.Count > costume.RefundDetailList.Count)
            {
                //有未打钩的，加上
                List<RetailDetail> notRefundList = new List<RetailDetail>();
                //原始单，要过滤有退货的款
                notRefundList.AddRange(originalRetailCostume.RetailDetailList);
                foreach (var refund in costume.RefundDetailList)
                {
                    RetailDetail retailDetail = notRefundList.Find(item => refund.CostumeID.ToUpper() == item.CostumeID.ToUpper() && refund.ColorName == item.ColorName && refund.SizeName == item.SizeName);
                    notRefundList.Remove(retailDetail);
                }

                //过滤后剩下没有勾选的款，notRefundList


                //添加所有的优惠券

                //不退的优惠券，就是买的那几件的优惠券
                if (notRefundList != null)
                {
                    foreach (var item in notRefundList)
                    {
                        if (!String.IsNullOrEmpty(item.GiftTickets))
                        {
                            List<GiftTicket> list = GlobalCache.ServerProxy.GetGiftTicket4RetailDetail(item.GiftTickets);
                            foreach (var ticket in list)
                            {
                                moneyBuyByTicket += ticket.Denomination;
                            }
                        }
                    }
                }
            }
            */
            return moneyBuyByTicket;

        }

        private void ResetForm()
        {
            this.originalRetailCostume = null;
            this.currentRetailCostume = null;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();

            this.skinLabel_MemberName.Text = "";
            this.skinLabel_MemberID.Text = "";
            this.skinLabel_GuideID.Text = "";
            this.skinLabel_SalesPromotion.Text = "";
            this.retailOrderIDTextBox1.SkinTxt.Text = "";
            this.skinTextBox_RefundReason.SkinTxt.Text = "";

            this.skinLabel_MoneyIntegration.Text = string.Empty;
            this.skinLabel_MoneyStoredCard.Text = string.Empty;
            this.skinLabel_TotalMoneyReceived.Text = string.Empty;
            this.skinLabel_SmallMoneyRemoved.Text = string.Empty;
            this.skinLabel_MoneyCash.Text = string.Empty;
            this.skinLabel_MoneyStoredCard.Text = string.Empty;
            this.skinLabel_MoneyBankCard.Text = string.Empty;
            this.skinLabel_MoneyWeiXin.Text = string.Empty;
            this.skinLabel_MoneyAlipay.Text = string.Empty;
            this.skinLabelOther.Text = string.Empty;
            this.skinLabel_MoneyChange.Text = string.Empty;
            skinLabelGiftTicket.Text = string.Empty;
            skinLabel_remark.Text = string.Empty;
        }

        //将绑定的RetailDetail源转换成RefundDetail
        private RetailDetail RetailDetailToRefundDetail(RetailDetail retailDetail, string orderID)
        {
            return new RetailDetail()
            {
                RetailOrderID = orderID,
                CostumeID = retailDetail.CostumeID,
                CostumeName = GlobalCache.GetCostumeName(retailDetail.CostumeID),
                ColorName = retailDetail.ColorName,
                SizeName = retailDetail.SizeName,
                Discount = retailDetail.Discount,
                DiscountOrigin = retailDetail.DiscountOrigin,
                IsRefund = true,
                Price = retailDetail.Price,
                BuyCount = retailDetail.RefundCount * -1,
                IsBuyout = retailDetail.IsBuyout,
                BrandName = ValidateUtil.CheckNotNullValue(retailDetail.BrandName),
                GiftTicketMoney = retailDetail.GiftTicketMoney,
                //268 畅滞排行榜：商品退货后，零售金额变成0
                //20180820 summoney 修改为除以购买数量再乘以退货数量
                SalePrice = Math.Round((retailDetail.SumMoney / retailDetail.BuyCount) * -1, 1, MidpointRounding.AwayFromZero),//每件商品退货单价
                SumMoney = Math.Round(retailDetail.RefundCount * (retailDetail.SumMoney / retailDetail.BuyCount) * -1, 1, MidpointRounding.AwayFromZero),
                SumMoneyActual = Math.Round(retailDetail.RefundCount * retailDetail.Price * -1, 1, MidpointRounding.AwayFromZero),
                SizeDisplayName = retailDetail.SizeDisplayName,
                //retailDetail.RefundCount * retailDetail.Price * -1,
                CostPrice = retailDetail.CostPrice * -1,
                SumCost = retailDetail.RefundCount * retailDetail.CostPrice * -1,
                Remarks = retailDetail.Remarks,
                InSalesPromotion = retailDetail.InSalesPromotion,
                GiftTickets = retailDetail.GiftTickets,
                RefundCount = retailDetail.RefundCount,
                OccureTime = dateTimePicker_Start.Value,
                 GuideID=retailDetail.GuideID,

            };
        }


        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    switch (this.dataGridView1.Columns[e.ColumnIndex].HeaderText)
                    {
                        case "退货数量":
                            if (this.currentRetailCostume == null)
                            {
                                return;
                            }
                            int count = Convert.ToInt32(e.FormattedValue);
                            if (count < 0 || count > this.currentRetailCostume.RetailDetailList[e.RowIndex].BuyCount)
                            {
                                //e.Cancel = true;
                                GlobalMessageBox.Show("输入退款数量有误！");
                                this.dataGridView1.CancelEdit();
                            }
                            break;
                        case "退货":
                            break;

                    }
                }
                catch
                {
                    //e.Cancel = true;
                    GlobalMessageBox.Show("输入格式错误！");
                    this.dataGridView1.CancelEdit();
                }
            }
        }

        //点击查询销售单
        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }

                String orderID = retailOrderIDTextBox1.SkinTxt.Text;
                string costumeID = this.CostumeCurrentShopTextBox1.SkinTxt.Text;
                if (!string.IsNullOrEmpty(orderID))
                {
                    retailOrderIDTextBox1.Focus();
                    SendKeys.SendWait("{Enter}");
                }
                else if (!string.IsNullOrEmpty(costumeID))
                {
                    RetailOrderSelectForm orderSelectForm = new RetailOrderSelectForm(costumeID, shopID, false);
                    orderSelectForm.RetailOrderSelected += OrderSelectForm_RetailOrderSelected;
                    orderSelectForm.ShowDialog();
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

        private void OrderSelectForm_RetailOrderSelected(RetailOrder retailOrder)
        {
            this.RetailOrderIDTextBox1_OrderSelected(retailOrder);
        }

        private void RefundCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
            if (redoOrder != null)
            {
                Redo(redoOrder);
            }
        }

        private void Initialize()
        {
            ResetForm();
        }

        private void CostumeCurrentShopTextBox1_CostumeSelected(CostumeItem obj, bool isEnter)
        {
            if (isEnter)
            {
                if (obj != null)
                {
                    BaseButton1_Click(null, null);
                }
            }
        }

        String shopID;

        bool isFlag = false;
        String ISCancelShopId = null;
        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && isFlag == false)
            {
                DialogResult dialogResult = GlobalMessageBox.Show("切换店铺将会清空列表，是否确定切换？", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult != DialogResult.OK)
                {
                    isFlag = true;
                    this.skinComboBoxShopID.SelectedValue = ISCancelShopId;
                    return;
                }

                currentRetailCostume.RetailDetailList.Clear();

                dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(currentRetailCostume.RetailDetailList));
                // SetCostumeDetails(null);
            }
            else
            {
                isFlag = false;
            }
            //skinComboBoxShopID
            shopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);

            ISCancelShopId = shopID;
            guideComboBox1.Initialize(Common.GuideComboBoxInitializeType.Null, shopID);
            retailOrderIDTextBox1.ShopID = shopID;
            CostumeCurrentShopTextBox1.ShopID = shopID;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {

                RetailDetail detail = this.currentRetailCostume.RetailDetailList[e.RowIndex];
                if (e.ColumnIndex == GuideName.Index)
                {
                    // detail.GuideID = this.retailDetailList[e.ColumnIndex];
                    detail.GuideID = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    //detail.GuideName = CommonGlobalCache.GetUserName(detail.GuideID);
                }
            }
        }

        private void guideComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string guideID = (string)this.guideComboBox1.SelectedValue;
          /*  if (this.currentRetailCostume!=null && this.currentRetailCostume.RetailDetailList != null && this.currentRetailCostume.RetailDetailList.Count > 0)
            {
                foreach (RetailDetail detail in this.currentRetailCostume.RetailDetailList)
                {
                    //if (detail.GuideID == null || detail.GuideID == "")
                    // {
                    //     //   isNoHasGuidFlag = true;
                    //     // break;
                    //     detail.GuideID = guideID;
                    // }
                    detail.GuideID = guideID;

                }
            }

            dataGridView1.Refresh();*/
        }
    }
}
