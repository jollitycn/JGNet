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
using JGNet.Common;
using System.Threading;
using JGNet.Common.Core.Util.IO.Print;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Common.Core;
using CCWin.SkinControl;
using JGNet.Manage;
using JGNet.Core.InteractEntity;
using System.IO;

namespace JGNet.Manage
{
    public partial class ShouYinCtrl : BaseModifyUserControl
    {
        public override void HandleShortKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F3:
                    BaseButton_AddCostume.PerformClick();
                    break;
                case Keys.F4:
                    BaseButtonRecharge.PerformClick();
                    break;
                //case Keys.Add:
                //    BaseButton2.PerformClick();
                //    break;
                default:
                    break;
            }
        }
        private CostumeStore currentSelectedStore;//当前选中的CostumeStore
        private SalesPromotion currentSalesPromotion;//当前选中的SalesPromotion
        private string promotionText = "";//当前满足的促销说明
        private List<IPromotionRule> currentPromotionRuleList = new List<IPromotionRule>();
        private CostumeItem currentSelectedItem;//当前选中的CostumeItem 
        private List<RetailDetail> retailDetailList = new List<RetailDetail>();//当前dataGridView绑定的源

        private MJPromotionRule currentMJPromotionRule = null;
        private DiscountPromotionRule discountPromotionRule = null;
        private bool isAddDetail = false;//是否为添加服装到销售列表
        private bool isDeleteDetail = false;//是否从销售列表中移除服装
        private bool currentIsPromotionDiscount = false;//当前是不是活动打折了
        private bool currentIsInSingleDiscount = false;//当前是否参加了整单打折
        private bool currentIsPromotionMJ = false;//当前是否参加了满减金额         
        private Member currentMember;
        public Member Member { set { currentMember = value; } }
        private HangedOrderBag orderAggregate = new HangedOrderBag();//挂单集合
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public event CJBasic.Action<String, BaseUserControl> ToolStripButtonClick;
        public event CJBasic.Action<Member, BaseUserControl> ClickRechargeButton;
        public const String Action_RECHARGE = "ACTION_RECHARGE";
        public const String Action_MEMBER_NEW = "ACTION_MEMBER_NEW";
        private RetailOrder curOrder;

        public ShouYinCtrl()
        {
            InitializeComponent();
            Init();
            this.isFlag = false;
        }

        public ShouYinCtrl(RetailOrder order)
        {
            InitializeComponent();
            Init();
            curOrder = order;
            // this.order = order;
            RedoOrder(order);
            if (!HasPermission(RolePermissionMenuEnum.销售退货单查询, RolePermissionEnum.重做_单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
            this.isFlag = true;
            this.skinComboBoxShopID.SelectedValue = order.ShopID;
        }

        bool lockSalePriceForSale;
        private void Init()
        {
            try
            {
                skinComboBoxShopID.Initialize(true);
                   dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1);
                dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(remarksDataGridViewTextBoxColumn);
             //   dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(giftTicketImageColumn);
                dataGridViewPagingSumCtrl.Initialize();
                DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(dataGridView2) { ShowRowCounts = false };
                dataGridViewPagingSumCtrl2.Initialize();
                this.Initialize();

                lockSalePriceForSale = CommonGlobalCache.GetParameter(ParameterConfigKey.LockSalePriceForSale).ParaValue == "1";
                if (lockSalePriceForSale)
                {
                    BaseButtonSingleDiscount.Enabled = false;
                    // BaseButtonSingleDiscount.Text = "售价已锁定不";
                }
                MenuPermission = RolePermissionMenuEnum.收银;

                if (!HasPermission(RolePermissionMenuEnum.收银, RolePermissionEnum.单据时间))
                {
                    dateTimePicker_Start.Enabled = false;
                }
                skinTextBox_bugCount.SkinTxt.KeyPress += SkinTxt_bugCount_KeyPress; 
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void SkinTxt_bugCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))                          
            {
                e.Handled = true;
                GlobalMessageBox.Show("输入格式错误！");
                return;
            }
        }

        #region Initialize
        private void Initialize()
        {
            skinLabelSingleDiscount.Text = string.Empty;
            this.guideComboBox1.Initialize(GuideComboBoxInitializeType.Null, shopID);
            this.guideComboBox1.SelectedIndex = 0;
            if (CommonGlobalCache.CurrentUser.Type == UserInfoType.Guide)
            { 
                this.guideComboBox1.SelectedValue = GlobalCache.CurrentUserID;
            }
            this.CostumeCurrentShopTextBox1.CostumeSelected += CostumeCurrentShopTextBox1_CostumeSelected;
            this.memberIDTextBox2.MemberSelected += MemberIDTextBox1_MemberSelected;
            skinLabelTickets.Text = string.Empty;
            this.skinLabel_CostumeName.Text = string.Empty;
            CommonGlobalUtil.SetCostumeSize(skinComboBox_Size, null, CommonGlobalCache.DefaultSizeGroup, false);

             
            ChangeSalesPromotion();

           

            try
            {
                this.orderAggregate = HangedOrderBag.Load(GlobalUtil.HangedOrderBagPath) as HangedOrderBag;
            }
            catch (Exception ex)
            {
                WriteLog(ex);
                try
                {
                    String contents = File.ReadAllText(GlobalUtil.HangedOrderBagPath);
                    contents = contents.Replace("JGNet.POS", "JGNet.Manage");
                    File.WriteAllText(GlobalUtil.HangedOrderBagPath, contents);
                    this.orderAggregate = HangedOrderBag.Load(GlobalUtil.HangedOrderBagPath) as HangedOrderBag;
                }
                catch
                {
                    try
                    {
                        File.Delete(GlobalUtil.HangedOrderBagPath);
                    }
                    catch { }
                }
            }

            if (this.orderAggregate == null)
            {
                this.orderAggregate = new HangedOrderBag() { HangedOrderList = new List<HangedOrder>() };
            }

            skinTextBox_bugCount.SkinTxt.PreviewKeyDown += SkinTxt_PreviewKeyDown;
            balanceRound = GlobalCache.GetParameter(ParameterConfigKey.RetailBalanceRound).ParaValue == "1";
            //CommonGlobalUtil.GetOptionValueBoolean(OptionConfiguration.OPTION_CONFIGURATION_KEY_BALANCE_ROUND);
        }

        private void ChangeSalesPromotion()
        {
            List<SalesPromotion> list = GlobalCache.SalesPromotionEnableList(ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue));
            if (list?.Count > 0)
            {
                //  list.AddRange(GlobalCache.SalesPromotionEnableList);
            }
            else
            {
                list.Add(new SalesPromotion() { ID = "", Name = GlobalUtil.COMBOBOX_NULL, ShopIDStr = shopID, PromotionType = (byte)PromotionTypeEnum.Null });
            }
            this.skinComboBox_Promotion.DataSource = list;
            this.skinComboBox_Promotion.DisplayMember = "Name";
        }

        private bool balanceRound = true;

        private void SkinTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            //添加 
            BaseButton_AddCostume_Click(null, null);
        }
        #endregion

        #region 输入款号

        //在输入款号按下回车键开始查询 款号被选中时触发
        private void CostumeCurrentShopTextBox1_CostumeSelected(CostumeItem costumeItem,bool isEnter)
        {
            if (isEnter)
            {
                this.SetCostumeDetails(costumeItem);
            }
        }


        private void SetCostumeDetails(CostumeItem costumeItem)
        {
            if (costumeItem == null)
            {
                this.CleanCostumeDetails();
                return;
            }
            this.currentSelectedItem = costumeItem;
            if (HasPermission(RolePermissionEnum.查看_品牌))
            {
                this.skinLabel_CostumeName.Text = costumeItem.Costume.BrandName + "-" + costumeItem.Costume.Name;
            }
            else
            {
                this.skinLabel_CostumeName.Text = costumeItem.Costume.Name;
            }

            this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
            String[] colors = costumeItem.Costume.Colors.Split(',');
            List<String> colorList = new List<string>(colors);
            if (costumeItem.CostumeStoreList != null && costumeItem.CostumeStoreList.Count > 0)
            {
                foreach (var item in costumeItem.CostumeStoreList)
                {
                    if (colorList.Find(t => t == item.ColorName) == null)
                    {
                        colorList.Add(item.ColorName);
                    }
                  
                    
                }
            }
            this.skinComboBox_Color.DataSource = colorList;
            this.skinComboBox_Color.SelectedIndex = 0;
            this.skinTextBox_bugCount.SkinTxt.Text = "1";
            dataGridView2.DataSource = null;
            SizeGroup sizeGroup = CommonGlobalCache.GetSizeGroup(costumeItem.Costume.SizeGroupName);
            //设置对应的尺码组
            CommonGlobalUtil.ChangeSizeGroup(dataGridView2, sizeGroup, false);

            //隐藏没有的列 
            CommonGlobalUtil.SetCostumeSize(skinComboBox_Size, costumeItem.Costume);
            dataGridView2.DataSource = DataGridViewUtil.ListToBindingList(costumeItem.CostumeStoreList);
            SetStoreCountText();
        }


        /// <summary>
        /// 清除服装明细
        /// </summary>
        private void CleanCostumeDetails()
        {
            dataGridView2.DataSource = null;
            this.skinComboBox_Color.DataSource = null;
            this.CostumeCurrentShopTextBox1.SkinTxt.Text = "";
            this.skinLabel_CostumeName.Text = "";
            // this.skinLabel_StoreCount.Text = "";
            this.skinTextBox_bugCount.SkinTxt.Text = "";
            this.skinComboBox_Promotion.SelectedIndex = 0;
            this.guideComboBox1.SelectedIndex = 0;
        }

        /// <summary>
        /// 设置界面上库存标签值
        /// </summary>
        /// <param name="colorName"></param>
        /// <param name="sizeName"></param>
        private void SetStoreCountText()
        {
            if (this.currentSelectedItem == null)
            {
                return;
            }

            if (this.currentSelectedItem.CostumeStoreList == null)
            {

                // this.skinLabel_StoreCount.Text = "0";
            }
            else
            {
                int count = 0;
                foreach (CostumeStore item in this.currentSelectedItem.CostumeStoreList)
                {
                    count += item.SumCount;

                }
                //   this.skinLabel_StoreCount.Text = "" + count;
            }
        }


        List<ListItem<String>> sizes = null;
        private void skinComboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据颜色获取对应尺码库存信息
            this.currentSelectedStore = this.currentSelectedItem.CostumeStoreList.Find(c => { return c.ColorName == ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedValue); });
            sizes = skinComboBox_Size.DataSource as List<ListItem<String>>;
            skinComboBox_Size.DataSource = null;
            skinComboBox_Size.DataSource = sizes;
        }
        #endregion

        #region 输入会员卡号
        //在输入会员卡号时按下回车键开始查询
        private void MemberIDTextBox1_MemberSelected(Member member)
        {
            //会员回车会同时触发添加按钮事件。 
            this.currentMember = member;
            this.ShowMemberDetails();
            //   isMemberSelected = false;
        }

        private void ShowMemberDetails()
        {
            try
            {
                if (this.currentMember == null)
                {
                    //GlobalMessageBox.Show("该会员卡号不存在！");
                    ImageColumn(false);
                    this.CleanMemberDetails();
                    return;
                }
                ImageColumn(true);
                this.memberIDTextBox2.Text = this.currentMember.PhoneNumber;
                this.skinLabel_CurrentIntegration.Text = this.currentMember.CurrentIntegration.ToString();
                this.skinLabel_MemberName.Text = this.currentMember.Name;
                //   this.skinLabel_AccruedIntegration.Text = this.currentMember.AccruedIntegration.ToString();
                //店铺id 微信账号店铺id为空
                //报错 
                this.skinLabel_ShopID.Text = String.IsNullOrEmpty(this.currentMember.ShopID) ? SystemDefault.onlineName : GlobalCache.GetShopName(this.currentMember.ShopID);
                this.skinLabel_Balance.Text = this.currentMember.Balance.ToString();
                //this.skinLabel_AccruedSpend.Text = this.currentMember.AccruedIntegration.ToString();
                this.skinLabel_AccruedSpend.Text = this.currentMember.AccruedSpend.ToString();
                CheckGiftTicket();
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
        private void ImageColumn(bool visible)
        {
           // giftTicketImageColumn.Visible = visible;
            dataGridViewPagingSumCtrl.EnableStyle();
        }
        List<GiftTicket> tickets = null;

        private void CheckGiftTicket()
        {
            if (this.currentMember != null)
            {
                try
                {
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    //检查该会员所有的优惠券信息 
                    tickets = GlobalCache.ServerProxy.GetValidGiftTickets(currentMember.PhoneNumber);
                    skinLabelTickets.Text = tickets.Count.ToString();
                    CheckTicketsForCostumes(tickets);
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
            else
            {
                tickets = null;
                skinLabelTickets.Text = string.Empty;

            }
        }

        /// <summary>
        /// 简单判断是否可以使用优惠券
        /// </summary>
        /// <param name="tickets"></param>
        private void CheckTicketsForCostumes(List<GiftTicket> tickets)
        {
            //判断款号是否在优惠券使用范围中
            if (CommonGlobalCache.CostumeGiftTicketInfo != null)
            {
                if (CommonGlobalCache.CostumeGiftTicketInfo.IsUse)
                {
                    foreach (var item in retailDetailList)
                    {
                        if (CommonGlobalCache.CostumeGiftTicketInfo.CostumeIDs.Exists(t => t == item.CostumeID))
                        {

                            item.CanUseTickets = true;
                            //获取可选优惠券
                            foreach (var ticket in tickets)
                            {
                                if (DateTime.Now >= ticket.EffectDate && ticket.ExpiredDate >= DateTime.Now )
                                {
                                    //满足条件
                                    if (ticket.IsAnd)
                                    {
                                        if (item.Discount >= ticket.MinDiscount && ticket.MinDiscount != 0 && (item.SumMoney / item.BuyCount) >= ticket.MinMoney && ticket.MinMoney != 0)
                                        {
                                            //满足折扣
                                            item.MatchGiftTickets = ticket.ID;
                                            break;
                                        }
                                    }
                                    else
                                    {

                                        if (item.Discount >= ticket.MinDiscount && ticket.MinDiscount != 0)
                                        {
                                            //满足折扣
                                            item.MatchGiftTickets = ticket.ID;
                                            break;
                                        }
                                        if ((item.SumMoney / item.BuyCount) >= ticket.MinMoney && ticket.MinMoney != 0)
                                        {
                                            item.MatchGiftTickets = ticket.ID;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (!String.IsNullOrEmpty(item.MatchGiftTickets))
                            {
                                //找到优惠券了
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    //不参与的
                    foreach (var item in retailDetailList)
                    {
                        String cId = CommonGlobalCache.CostumeGiftTicketInfo.CostumeIDs.Find(t => t == item.CostumeID);
                        //不在黑名单中
                        if (String.IsNullOrEmpty(cId))
                        {

                            item.CanUseTickets = true;

                            //获取可选优惠券
                            foreach (var ticket in tickets)
                            {
                                if (DateTime.Now > ticket.EffectDate && ticket.ExpiredDate > DateTime.Now)
                                {

                                    if (ticket.IsAnd)
                                    {
                                        if (item.Discount >= ticket.MinDiscount && ticket.MinDiscount != 0 && ticket.MinMoney != 0 && item.SumMoney / item.BuyCount >= ticket.MinMoney)
                                        {// 满足折扣
                                            item.MatchGiftTickets = ticket.ID;
                                            break;
                                        }
                                    }
                                    else
                                    {

                                        //满足条件
                                        if (item.Discount >= ticket.MinDiscount && ticket.MinDiscount != 0)
                                        {
                                            //满足折扣
                                            item.MatchGiftTickets = ticket.ID;
                                            break;
                                        }
                                        if (item.SinglePrice >= ticket.MinMoney && ticket.MinMoney != 0)
                                        {
                                            item.MatchGiftTickets = ticket.ID;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (!String.IsNullOrEmpty(item.MatchGiftTickets))
                            {
                                //找到优惠券了
                                continue;
                            }
                        }
                    }
                }
            }

            //获取到对应是否有可用的优惠券
            //设置图标
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                RetailDetail detail = row.DataBoundItem as RetailDetail;

                //如果存在
                // if (String.IsNullOrEmpty(detail.GiftTickets))
                //if (detail.CanUseTickets)
                //{
                //    row.Cells[giftTicketImageColumn.Index].Value = global::JGNet.Manage.Properties.Resources.优惠券;
                //    row.Cells[giftTicketImageColumn.Index].ToolTipText = "可使用优惠券";

                //}
                //else
                //{
                //    row.Cells[giftTicketImageColumn.Index].Value = global::JGNet.Manage.Properties.Resources.empty;
                //}
            }
            dataGridView1.Refresh();
        }

        /// <summary>
        /// 清理Vip会员信息
        /// </summary>
        private void CleanMemberDetails()
        {
            this.currentMember = null;
            this.skinLabel_CurrentIntegration.Text = String.Empty;
            this.skinLabel_MemberName.Text = String.Empty;
            //   this.skinLabel_AccruedIntegration.Text = "";
            this.skinLabel_ShopID.Text = String.Empty;
            this.skinLabel_Balance.Text = String.Empty;
            this.skinLabel_AccruedSpend.Text = String.Empty; //giftTicketImageColumn.Visible = false;
        }

        #endregion

        #region 添加销售产品
        //添加销售产品 入列表中
        private void BaseButton_AddCostume_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.currentSelectedStore == null)
                {
                    GlobalMessageBox.Show("该款号颜色尚未入库，不能添加！");
                    return;
                }
                int buyCount = int.Parse(this.skinTextBox_bugCount.SkinTxt.Text);
                if (buyCount <= 0)
                {
                    GlobalMessageBox.Show("购买数量必须大于0！");
                    return;
                }
                int storeCount = 0;
                if (this.currentSelectedStore != null)
                {
                    storeCount = CostumeStoreHelper.GetStoreCountBySize(this.currentSelectedStore, CostumeStoreHelper.GetCostumeSize(ValidateUtil.CheckEmptyValue(this.skinComboBox_Size.SelectedValue), CommonGlobalCache.GetSizeGroup(this.currentSelectedItem.Costume.SizeGroupName)));
                }
                if (storeCount == 0)
                {
                    ParameterConfig config = CommonGlobalCache.GetParameter(ParameterConfigKey.LimitCostumeStore);

                    if (config.ParaValue == "0")
                    {
                        GlobalMessageBox.Show("库存不足,不能添加！", "提示");
                        return;
                    }
                    else
                    {
                        if (GlobalMessageBox.Show("库存不足,是否确认添加？", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                else if (storeCount < 0)
                {
                    ParameterConfig config = CommonGlobalCache.GetParameter(ParameterConfigKey.LimitCostumeStore);
                    if (config.ParaValue == "0")
                    {
                        GlobalMessageBox.Show("库存不足,不能添加！", "提示");
                        return;
                    }
                    else
                    {
                        if (GlobalMessageBox.Show("库存不足，是否确认添加？", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                else if (buyCount > storeCount)
                {
                    if (GlobalMessageBox.Show("库存不足，是否确认添加？", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    {
                        return;
                    }
                }

                string selectShopid = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);  
                List<Guide> guideList = CommonGlobalCache.GuideList.FindAll(t => t.State == 0 && t.ShopID == selectShopid);


                this.GuideName.DataSource = guideList;
                this.GuideName.DisplayMember = "Name";
                this.GuideName.ValueMember = "ID";

                // GlobalCache.GetCostumeStorePrice(shopid,this.currentSelectedItem.Costume.ID);
                //detail.GuideID = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                string defaultGuid = string.Empty;
                if (this.guideComboBox1.SelectedIndex > 0)
                {
                    defaultGuid = ValidateUtil.CheckEmptyValue(this.guideComboBox1.SelectedValue);
                }


                RetailDetail detail = new RetailDetail()
                {
                    Costume = this.currentSelectedItem.Costume,
                    CostumeID = this.currentSelectedItem.Costume.ID,
                    CostumeName = this.currentSelectedItem.Costume.Name,
                    ColorName = this.skinComboBox_Color.Text,
                    SizeName = ValidateUtil.CheckEmptyValue(this.skinComboBox_Size.SelectedValue),
                     GuideID= defaultGuid,
                    // 显示自己设置的尺码组和对应的尺码列表
                    SizeDisplayName = CostumeStoreHelper.GetCostumeSizeName(ValidateUtil.CheckEmptyValue(this.skinComboBox_Size.SelectedValue), CommonGlobalCache.GetSizeGroup(this.currentSelectedItem.Costume.SizeGroupName)),
                    BuyCount = buyCount,
                    Price = this.currentSelectedItem.Costume.Price,
                    SinglePrice = this.currentSelectedItem.Costume.Price,
                    SalePrice = this.currentSelectedItem.Costume.Price,
                    SumMoney = this.currentSelectedItem.Costume.Price * buyCount,
                    SumMoneyActual = this.currentSelectedItem.Costume.Price * buyCount,
                    BrandName = ValidateUtil.CheckNotNullValue(currentSelectedItem.Costume.BrandName),
                    IsUseTickets = false,
                    ///288 收银时，商品的备注显示的是商品的备注 
                   // GuideID=    DataGridViewRow.Cells[this.GuideName.Name].Value,
                    Discount = 100,
                    DiscountOrigin = 100,
                    AllowReviseDiscount = true,//this.currentSelectedStore.AllowReviseDiscount,
                    CostPrice = this.currentSelectedItem.Costume.CostPrice,
                    SumCost = this.currentSelectedItem.Costume.CostPrice * buyCount
                };
                //detail.IsBuyout = CheckBuyout(detail,this.currentSelectedItem.Costume.ID);
                if (!this.AddSelectedCostumeToList(detail))
                {
                    return;
                }
                detail.IsBuyout = CheckBuyout(detail, this.currentSelectedItem.Costume.ID);
                this.UpdateValueByPromotion(true);
                this.skinTextBox_bugCount.SkinTxt.Text = "1";
                //912 售价功能整改。直接获取售价 
                if (!detail.IsBuyout)
                {
                    decimal salePrice = 0;
                    CostumeStore store = this.currentSelectedItem.CostumeStoreList.Find(t => t.ColorName == detail.ColorName || t.CostumeID == detail.CostumeID);
                    if (store != null)
                    {
                        salePrice = store.SalePrice;
                    }

                    //售价设置后可以改，整单打折不可修改售价，促销活动可以修改售价，如果是一口价，那么就不变按一口价来。
                    //直接获取售价
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[SinglePrice.Index].Value = CheckSinglePrice(detail, salePrice);
                }
                dataGridView1.Refresh();
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        /// <summary>
        /// 判断是否低于本店折扣
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        private decimal CheckSinglePrice(RetailDetail detail, decimal price)
        {
            decimal singlePrice = price;
            decimal discount = 0;
            if (detail.Price == 0)
            {
                discount = 0;
            }
            else
            {
                discount = Math.Round(singlePrice * 100 / detail.Price, 1, MidpointRounding.AwayFromZero);
            }

            if (discount < shop.MinDiscount && !detail.IsBuyout)
            {
                singlePrice = detail.SinglePrice;
            }
          //  detail.SalePrice = singlePrice;
            return singlePrice;
        }

        private bool CheckBuyout(RetailDetail detail, string ID)
        {
            //根据店铺,款号判断该款是否一口价
            Boolean isBuyout = false;

            List<SalesPromotion> buyouts = GlobalCache.SalesBuyoutPromotionEnableListByShop(ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue));
            if (buyouts != null)
            {
                foreach (var item in buyouts)
                {
                    String[] rules = item.RuleExpression.Split(';');
                    String[] ruleRange = item.CostumeIDStr.Split(';');

                    for (int i = 0; i < rules.Length; i++)
                    {
                        var rule = rules[i];
                        var range = ruleRange[i];
                        String[] coss = range.Split(',');
                        foreach (var cos in coss)
                        {
                            if (ID == cos)
                            {
                                isBuyout = true;
                                detail.SinglePrice = Convert.ToDecimal(rule);
                              //  detail.SalePrice = detail.SinglePrice;
                                SetDiscount(detail);

                                detail.SumMoney = detail.SinglePrice * detail.BuyCount;
                                detail.SumMoneyActual = detail.SumMoney;
                                break;
                            }
                        }

                    }
                }
            }
            return isBuyout;
        }

        private void SetDiscount(RetailDetail detail)
        {
            if (detail.Price == 0)
            {
                detail.Discount = 0;
            }
            else
            {
                detail.Discount = Math.Round(detail.SinglePrice * 100 / detail.Price, 1, MidpointRounding.AwayFromZero);
            }
        }

        private decimal GetDiscount(RetailDetail detail)
        {
            decimal discount = 0;
            if (detail.Price == 0)
            {
                discount = 0;
            }
            else
            {
                discount = Math.Round(detail.SinglePrice * 100 / detail.Price, 1, MidpointRounding.AwayFromZero);
            }
            return discount;
        }

        private bool AddSelectedCostumeToList(RetailDetail detail)
        {
            foreach (RetailDetail retailDetail in this.retailDetailList)
            {
                if (retailDetail.CostumeID == detail.CostumeID && retailDetail.ColorName == detail.ColorName && retailDetail.SizeName == detail.SizeName)
                {
                    if (GlobalMessageBox.Show("列表中已存在该款商品！是否添加新的一行？", "友情提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                    }
                    else
                    {
                        int rowIndex = this.retailDetailList.IndexOf(retailDetail);
                        this.dataGridView1.ClearSelection();
                        this.dataGridView1.Rows[rowIndex].Selected = true;
                        return false;
                    }
                }
            }

            this.retailDetailList.Add(detail);
            this.isAddDetail = true;
            return true;
        }

        /// <summary>
        /// 获取当前销售列表中符合活动条件的 衣服集合
        /// </summary>
        /// <param name="containsSpecify"></param>
        /// <returns></returns>
        private List<RetailDetail> GetPromotionRetailDetail(bool containsSpecify)
        {
            List<RetailDetail> retailDetails = new List<RetailDetail>();
            List<String> costumeIds = new List<string>(this.currentSalesPromotion.CostumeIDStr.Split(','));
            foreach (RetailDetail item in this.retailDetailList)
            {
                if (!costumeIds.Contains(item.CostumeID) ^ containsSpecify)
                {
                    //排除一口价商品
                    if (!item.IsBuyout)
                    {
                        retailDetails.Add(item);
                    }
                }
            }
            return retailDetails;
        }

        //根据活动更新对应的值
        private void UpdateValueByPromotion(bool rebind)
        {
            this.ResetPromotionValue();

            if (currentIsInSingleDiscount)
            {
                foreach (RetailDetail detail in this.retailDetailList)
                {
                    detail.Discount = (byte)singleDiscount;

                    SetSinglePriceByPriceDiscount(detail);
                    detail.SumMoney = detail.SinglePrice * detail.BuyCount;
                    detail.SumMoneyActual = detail.SumMoney;
                    detail.InSalesPromotion = false;
                }

            }
            else
            {
                List<RetailDetail> promotionRetailDetail = this.GetPromotionRetailDetail(this.currentSalesPromotion.ContainsSpecify);//销售衣服列表中参与活动的集合
                if (this.currentSalesPromotion.PromotionType == (int)PromotionTypeEnum.MJ)
                {
                    this.currentIsPromotionMJ = true; this.currentIsPromotionDiscount = false;
                    List<MJPromotionRule> list = new List<MJPromotionRule>();
                    foreach (IPromotionRule rule in this.currentPromotionRuleList)
                    {
                        list.Add((MJPromotionRule)rule);
                    }
                    decimal totalBuyMoney = 0;
                    foreach (RetailDetail item in promotionRetailDetail)
                    {
                        totalBuyMoney += item.SumMoney;
                    }
                    MJPromotionRule tempRule = null;
                    list.Sort((x, y) => { return x.HitMoney.CompareTo(y.HitMoney); });
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (totalBuyMoney < list[i].HitMoney)
                        {
                            break;
                        }
                        else
                        {
                            tempRule = list[i];
                        }
                    }
                    if (tempRule != null)
                    {
                        this.currentMJPromotionRule = tempRule;
                        this.promotionText = tempRule.ToString();
                        foreach (RetailDetail item in this.retailDetailList)
                        {
                            if (promotionRetailDetail.Contains(item))
                            {
                                item.InSalesPromotion = true;
                            }
                        }
                    }

                }
                else if (this.currentSalesPromotion.PromotionType == (int)PromotionTypeEnum.Discount)
                {
                    List<DiscountPromotionRule> list = new List<DiscountPromotionRule>();
                    foreach (IPromotionRule rule in this.currentPromotionRuleList)
                    {
                        list.Add((DiscountPromotionRule)rule);
                    }
                    int totalBuyCount = 0;
                    // List<string> promotion
                    foreach (RetailDetail item in promotionRetailDetail)
                    {
                        totalBuyCount += item.BuyCount;
                    }
                    discountPromotionRule = null;
                    list.Sort((x, y) => { return x.HitBuyCout.CompareTo(y.HitBuyCout); });
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (totalBuyCount < list[i].HitBuyCout)
                        {
                            break;
                        }
                        else
                        {
                            discountPromotionRule = list[i];
                        }
                    }
                    if (discountPromotionRule != null)
                    {
                        this.promotionText = discountPromotionRule.ToString();
                        this.currentIsPromotionDiscount = true;
                        currentIsPromotionMJ = false;
                        foreach (RetailDetail item in this.retailDetailList)
                        {
                            if (promotionRetailDetail.Contains(item))
                            {

                                item.Discount = (byte)discountPromotionRule.Discount;
                                if (balanceRound)
                                {
                                    item.SinglePrice = Math.Round(item.Price * discountPromotionRule.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                                  //  item.SalePrice = item.SinglePrice;
                                    item.SumMoney = item.SinglePrice * item.BuyCount;
                                    item.SumMoneyActual = item.SumMoney;
                                }
                                else
                                {
                                    item.SinglePrice = Math.Round(item.Price * discountPromotionRule.Discount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                                   // item.SalePrice = item.SinglePrice;
                                    item.SumMoney = item.SinglePrice * item.BuyCount;
                                    item.SumMoneyActual = item.SumMoney;
                                }

                                item.InSalesPromotion = true;
                            }
                        }
                    }
                } 
            }

            if (rebind)
            {
                BindingDatasource();
            }
            else
            {
                CheckColumnReadOnly();
            }

            this.dataGridView1.Refresh();
            this.SetTotalLabel_MoneyAndCount();
        }

        private void SetSinglePriceByPriceDiscount(RetailDetail detail)
        {
            if (balanceRound)
            {
                detail.SinglePrice = Math.Round(detail.Price * detail.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                detail.SalePrice = detail.SinglePrice;//必须设置
            }
            else
            {
                detail.SinglePrice = Math.Round(detail.Price * detail.Discount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                detail.SalePrice = detail.SinglePrice;//必须设置
            }
        }

        private void BindingDatasource()
        {
            this.dataGridView1.DataSource = null;
            if (this.retailDetailList != null && this.retailDetailList.Count > 0)
            {
                this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(this.retailDetailList);
            }
            CheckGiftTicket();
            CheckColumnReadOnly();
        }

        private void CheckColumnReadOnly()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (lockSalePriceForSale)
                {
                    row.Cells[SinglePrice.Name].ReadOnly = true;
                    row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = true;
                    row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = true;
                    row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.empty;
                    row.Cells[SinglePrice.Name].ToolTipText = "售价锁定";
                    row.Cells[Column3.Name].ToolTipText = "";

                }
                else
                {
                    row.Cells[SinglePrice.Name].ReadOnly = false;
                    row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = false;
                    row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = false;
                    row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.empty;
                    row.Cells[Column3.Name].ToolTipText = "";
                }
            }


            if (currentIsPromotionDiscount || currentIsInSingleDiscount || currentIsPromotionMJ)
            {
                //整单打折或者促销活动打折
                //则不能修改单价或者金额，系统自动计算
                //找到对应款号还有对应列

                if (currentIsPromotionDiscount)
                {
                    List<RetailDetail> promotionRetailDetail = this.GetPromotionRetailDetail(this.currentSalesPromotion.ContainsSpecify);
                    // 促销活动折扣
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        RetailDetail retailDetail = row.DataBoundItem as RetailDetail;
                        if (retailDetail.IsBuyout)
                        {
                            row.Cells[SinglePrice.Name].ReadOnly = true;
                            row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.一口价;
                            row.Cells[Column3.Name].ToolTipText = "一口价";
                        }
                        else if (promotionRetailDetail.Contains(retailDetail))
                        {
                            row.Cells[SinglePrice.Name].ReadOnly = true;
                            row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = true;

                            row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.折扣;
                            row.Cells[Column3.Name].ToolTipText = "促销折扣";

                        }
                        else
                        {
                            row.Cells[SinglePrice.Name].ReadOnly = false;
                            row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = false;
                            row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = false;
                        }
                    }

                }
                else if (currentIsPromotionMJ)
                {
                    List<RetailDetail> promotionRetailDetail = this.GetPromotionRetailDetail(this.currentSalesPromotion.ContainsSpecify);
                    // 促销活动折扣
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        RetailDetail retailDetail = row.DataBoundItem as RetailDetail;

                        if (retailDetail.IsBuyout)
                        {
                            row.Cells[SinglePrice.Name].ReadOnly = true;
                            row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.一口价;
                            row.Cells[Column3.Name].ToolTipText = "一口价";
                        }
                        else
                        if (promotionRetailDetail.Contains(retailDetail) && retailDetail.InSalesPromotion)
                        {
                            row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.满减;
                            row.Cells[Column3.Name].ToolTipText = "满减";
                        }
                    }
                }
                else if (currentIsInSingleDiscount)
                {
                    ///整单打折
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        RetailDetail retailDetail = row.DataBoundItem as RetailDetail;

                        if (retailDetail.IsBuyout)
                        {
                            row.Cells[SinglePrice.Name].ReadOnly = true;
                            row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.一口价;
                            row.Cells[Column3.Name].ToolTipText = "一口价";
                        }
                        else
                        {
                            row.Cells[SinglePrice.Name].ReadOnly = true;
                            row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = true;
                            row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.empty;
                            row.Cells[Column3.Name].ToolTipText = "";
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    RetailDetail retailDetail = row.DataBoundItem as RetailDetail;

                    if (retailDetail.IsBuyout)
                    {
                        row.Cells[SinglePrice.Name].ReadOnly = true;
                        row.Cells[discountDataGridViewTextBoxColumn.Name].ReadOnly = true;
                        row.Cells[sumMoneyDataGridViewTextBoxColumn.Name].ReadOnly = true;
                        row.Cells[Column3.Name].Value = global::JGNet.Manage.Properties.Resources.一口价;
                        row.Cells[Column3.Name].ToolTipText = "一口价";
                    } 
                }

            }
        }

        /// <summary>
        /// 重置为参加活动前的状态
        /// </summary>
        private void ResetPromotionValue()
        {
            if (this.isDeleteDetail && this.currentIsInSingleDiscount)
            {
                this.isDeleteDetail = false;
                return;
            }

            if (this.isAddDetail && this.currentIsInSingleDiscount)
            {
                this.isAddDetail = false;
                return;
            }
            this.promotionText = "";
            //如果变动前是折扣活动，须将参加活动的衣服折扣还原，并将标识改为false（未参加活动状态）
            if (this.currentIsPromotionDiscount)
            {
                List<RetailDetail> promotionRetailDetail = this.GetPromotionRetailDetail(this.currentSalesPromotion.ContainsSpecify);
                foreach (RetailDetail item in this.retailDetailList)
                {
                    if (promotionRetailDetail.Contains(item))
                    {
                        item.Discount = item.DiscountOrigin;
                        if (balanceRound)
                        {
                            item.SinglePrice = Math.Round(item.Price * item.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                          //  item.SalePrice = item.SinglePrice;
                            item.SumMoney = item.BuyCount * item.SinglePrice;
                            item.SumMoneyActual = item.SumMoney;
                        }
                        else
                        {
                            item.SinglePrice = Math.Round(item.Price * item.Discount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                            //item.SalePrice = item.SinglePrice;
                            item.SumMoney = item.BuyCount * item.SinglePrice;
                            item.SumMoneyActual = item.SumMoney;
                        }
                        item.InSalesPromotion = false;
                    }
                }

                this.currentIsPromotionMJ = false;
                this.currentIsPromotionDiscount = false;
                this.discountPromotionRule = null;
            }
            else
            {
                //如果变动前是减满活动，须将参加的衣服标识改为false（未参加活动状态）
                if (this.currentMJPromotionRule != null)
                {
                    foreach (RetailDetail item in this.retailDetailList)
                    {
                        item.InSalesPromotion = false;
                    }
                    this.currentMJPromotionRule = null;
                }
                this.currentIsPromotionMJ = false;
                this.currentIsPromotionDiscount = false;
            }
        }

        //设置要结算的总数量和总金额 Label的值
        private void SetTotalLabel_MoneyAndCount()
        {
            int totalCount = 0;
            decimal totalMoney = 0;
            this.skinLabel_PromotionMoney.Visible = false;
            this.skinLabel_TotalMoneyBeforePromotion.Visible = false;
            foreach (RetailDetail item in this.retailDetailList)
            {
                totalCount += item.BuyCount;
                totalMoney += item.SumMoney;
            }
            if (this.currentMJPromotionRule != null)
            {
                //整单打折满减也无效
                if (!currentIsInSingleDiscount)
                {
                    this.skinLabel_TotalMoneyBeforePromotion.Text = "优惠前金额： " + totalMoney.ToString();
                    this.skinLabel_PromotionMoney.Text = "优惠金额： " + this.currentMJPromotionRule.MinusMoney.ToString();
                    this.skinLabel_PromotionMoney.Visible = true;
                    this.skinLabel_TotalMoneyBeforePromotion.Visible = true;
                    totalMoney -= this.currentMJPromotionRule.MinusMoney;
                }
            }
            this.skinLabel_TotalCount.Text = totalCount.ToString();
            this.skinLabel_TotalMoney.Text = totalMoney.ToString();
        }

        #endregion

        #region 删除销售产品

        //点击单元格中的删除按钮   第9列为 删除按钮
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (CommonGlobalUtil.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == "删除")
                    {
                        DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
                        if (dialogResult != DialogResult.OK)
                        {
                            return;
                        }
                        RetailDetail detail = this.retailDetailList[e.RowIndex];
                        this.retailDetailList.RemoveAt(e.RowIndex);
                        this.isDeleteDetail = true;
                        this.UpdateValueByPromotion(true);
                        this.SetTotalLabel_MoneyAndCount();
                        CheckGiftTicket();
                    }
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }


        }
        #endregion

        #region 结算
        //点击结算按钮
        private void BaseButton_Balance_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.retailDetailList == null || this.retailDetailList.Count == 0)
                {
                    GlobalMessageBox.Show("请添加商品信息!");
                    return;
                }

                if (this.guideComboBox1.SelectedIndex == 0)
                {
                    GlobalMessageBox.Show("导购员不能为空");
                    return;
                }


                string guideID = (string)this.guideComboBox1.SelectedValue;

                bool isFlag = false;
                bool isSuperLen = false;
                foreach (RetailDetail retailItem in this.retailDetailList)
                {
                    if (retailItem.GuideID == null || retailItem.GuideID == "")
                    {
                        isFlag = true;
                        break;
                      //  retailItem.GuideID = guideID;
                    }
                    if (retailItem.SinglePrice > Convert.ToDecimal(99999999.99) || retailItem.SumMoney > Convert.ToDecimal(99999999.99))
                    {
                        isSuperLen = true;
                        break;
                    }
                }

                if (isFlag)
                {
                    GlobalMessageBox.Show("导购员不能为空，请确认列表所有款号都选择了导购员！");
                    return;
                }
                if (isSuperLen)
                {
                    GlobalMessageBox.Show("列表中单价或单款金额不能大于99999999.99！");
                    return;
                }




                BalanceForm balanceForm = new BalanceForm(this.currentMember,
                    this.retailDetailList, shopID, currentIsInSingleDiscount,
                    this.currentMJPromotionRule == null ? 0 : this.currentMJPromotionRule.MinusMoney,
                    this.currentSalesPromotion, 
                      guideID,
                    this.promotionText,
                    this.dateTimePicker_Start.Value
                    ,this.dataGridView1);
                if (DialogResult.Cancel == balanceForm.ShowDialog())
                {
                    return;
                }

                this.CleanForm();

            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }



        /// <summary>
        /// 清理Form上的值   （将界面上的信息清空）
        /// </summary>
        private void CleanForm()
        {
            this.retailDetailList.Clear();
            this.dataGridView1.DataSource = null;
            skinLabelTickets.Text = string.Empty;
            this.tickets = null;
            this.dataGridView1.Refresh();
            this.CleanCostumeDetails();
            this.CleanMemberDetails();
            this.memberIDTextBox2.SkinTxt.Text = "";
            this.UpdateValueByPromotion(true);
            this.BaseButtonSingleDiscount.Text = "整单打折";
            this.skinLabelSingleDiscount.Text = String.Empty;
            singleDiscount = 100;
            currentIsInSingleDiscount = false;
            currentIsPromotionDiscount = false;
            currentIsPromotionMJ = false;
            skinComboBox_Promotion.Enabled = true;
        }
        #endregion

        #region 验证单元格中的值
        //单元格值变化前 验证变化值的有效性
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {

                    Decimal singlePrice = 0; Decimal discount = 0; Decimal newDiscount = 0;
                    switch (this.dataGridView1.Columns[e.ColumnIndex].HeaderText)
                    {
                        case "折扣":
                            discount = Convert.ToDecimal(e.FormattedValue);
                            discount = Math.Round(discount, 1, MidpointRounding.AwayFromZero);
                          /*  if (this.retailDetailList[e.RowIndex].Discount != discount)
                            {
                                if (!this.retailDetailList[e.RowIndex].AllowReviseDiscount)
                                {
                                    GlobalMessageBox.Show("该商品折扣不能被修改");
                                    this.dataGridView1.CancelEdit();
                                    return;
                                }
                            }*/
                            if (discount < 0)
                            {
                                GlobalMessageBox.Show("输入数值必须大于或等于0");
                                this.dataGridView1.CancelEdit();
                            }
                            ValidateDiscount(this.retailDetailList[e.RowIndex], discount);
                            break;
                        case "单价":
                            RetailDetail detail = this.retailDetailList[e.RowIndex];
                            singlePrice = Convert.ToDecimal(e.FormattedValue);
                            if (balanceRound)
                            {
                                singlePrice = Math.Round(singlePrice, MidpointRounding.AwayFromZero);
                               // detail.SalePrice = singlePrice;
                            }
                            else
                            {

                                singlePrice = Math.Round(singlePrice, 2, MidpointRounding.AwayFromZero);
                               // detail.SalePrice = singlePrice;
                            }
                            if (detail.Price == 0)
                            {
                                discount = 0;
                            }
                            else
                            {
                                discount = Math.Round(singlePrice * 100 / detail.Price, 1, MidpointRounding.AwayFromZero);
                            }

                            this.ValidateDiscount(detail, discount);
                            break;
                        case "金额":
                            RetailDetail detail1 = this.retailDetailList[e.RowIndex];
                            decimal sumMoney = Convert.ToDecimal(e.FormattedValue);
                            if (balanceRound)
                            {
                                sumMoney = Math.Round(sumMoney, MidpointRounding.AwayFromZero);
                            }
                            else
                            {
                                sumMoney = Math.Round(sumMoney, 2, MidpointRounding.AwayFromZero);
                            }
                          /*  if (this.retailDetailList[e.RowIndex].SumMoney != sumMoney)
                            {
                                if (!this.retailDetailList[e.RowIndex].AllowReviseDiscount && curOrder.IsNotPay==false)
                                {
                                    GlobalMessageBox.Show("该商品金额不能被修改");
                                    this.dataGridView1.CancelEdit();
                                    return;
                                }
                            }*/
                            if (sumMoney < 0)
                            {
                                GlobalMessageBox.Show("输入数值必须大于或等于0");
                                this.dataGridView1.CancelEdit();
                            }

                            //detail1.SinglePrice= sumMoney/detail1.BuyCount;
                            SetSinglePrice(detail1, sumMoney * (decimal)1.0 / detail1.BuyCount);
                            //SetSinglePrice(detail1);
                            //singlePrice = sumMoney / BuyCount;
                            newDiscount = Math.Round(detail1.SinglePrice * 100 / detail1.Price, 1, MidpointRounding.AwayFromZero);
                            this.ValidateDiscount(detail1, newDiscount);
                            break;
                        case "数量":
                            int buyCount = Convert.ToInt32(e.FormattedValue);
                            if (buyCount <= 0)
                            {
                                GlobalMessageBox.Show("输入数值必须大于0");
                                this.dataGridView1.CancelEdit();
                            }
                            break;
                        case "备注":
                            CommonGlobalUtil.ConvertToString(e.FormattedValue);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    CommonGlobalUtil.ShowError(ex, "输入格式错误！");
                    this.dataGridView1.CancelEdit();
                }
            }
        }

        //当单元格中的金额或折扣值发生变化时，对应修改另一项的值
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    RetailDetail detail = this.retailDetailList[e.RowIndex];
                    if (e.ColumnIndex == GuideName.Index)
                    {
                        // detail.GuideID = this.retailDetailList[e.ColumnIndex];
                        detail.GuideID=this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        //detail.GuideName = CommonGlobalCache.GetUserName(detail.GuideID);
                    }
                    else
                    {
                        switch (this.dataGridView1.Columns[e.ColumnIndex].HeaderText)
                        {
                            case "折扣":
                                detail.Discount = Math.Round(detail.Discount, 1, MidpointRounding.AwayFromZero);
                                if (balanceRound)
                                {
                                    detail.SinglePrice = Math.Round(detail.Price * detail.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                                    // detail.SalePrice = detail.SinglePrice;
                                    detail.SumMoney = detail.BuyCount * detail.SinglePrice;
                                    detail.SumMoneyActual = detail.SumMoney;
                                }
                                else
                                {
                                    detail.SinglePrice = Math.Round(detail.Price * detail.Discount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                                    //  detail.SalePrice = detail.SinglePrice;
                                    detail.SumMoney = detail.BuyCount * detail.SinglePrice;
                                    detail.SumMoneyActual = detail.SumMoney;
                                }

                                this.UpdateValueByPromotion(false);
                                break;
                            case "金额":

                                SetSumMoney(detail);
                                SetSinglePrice(detail);
                                SetDiscount(detail);


                                this.UpdateValueByPromotion(false);
                                break;
                            case "数量":
                                detail.SumMoney = detail.BuyCount * detail.SinglePrice;
                                detail.SumMoneyActual = detail.SumMoney;
                                //268 畅滞排行榜：商品退货后，零售金额变成0
                                detail.SumCost = detail.CostPrice * detail.BuyCount;

                                this.UpdateValueByPromotion(false);
                                break;
                            case "单价":
                                SetSinglePrice(detail);
                                detail.SumMoney = detail.BuyCount * detail.SinglePrice;
                                detail.SumMoneyActual = detail.SumMoney;
                                SetDiscount(detail);
                                //268 畅滞排行榜：商品退货后，零售金额变成0
                                detail.SumCost = detail.CostPrice * detail.BuyCount;
                                this.UpdateValueByPromotion(false);
                                break;
                            case "使用优惠券":
                                detail.IsUseTickets = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                                this.UpdateValueByPromotion(false);
                                break;
                        }
                    }

                    //Thread thread = new Thread(DoUpdateValueByPromotion);
                    //thread.Start();
                    //   DoUpdateValueByPromotion();
                    //     CheckGiftTicket();
                }
                catch (Exception ex)
                {
                    GlobalUtil.WriteLog(ex);
                    GlobalMessageBox.Show("内部错误，金额与折扣转化出错！");
                }
            }
        }

        private void SetSinglePrice(RetailDetail detail)
        {
            if (balanceRound)
            {
                detail.SinglePrice = Math.Round(detail.SinglePrice, MidpointRounding.AwayFromZero);
               // detail.SalePrice = detail.SinglePrice;
            }
            else
            {
                detail.SinglePrice = Math.Round(detail.SinglePrice, 2, MidpointRounding.AwayFromZero);
              //  detail.SalePrice = detail.SinglePrice;
            }
        }

        private void SetSinglePrice(RetailDetail detail, decimal price)
        {
            if (balanceRound)
            {
                detail.SinglePrice = Math.Round(price, MidpointRounding.AwayFromZero);
                //detail.SalePrice = detail.SinglePrice;
            }
            else
            {
                detail.SinglePrice = Math.Round(price, 2, MidpointRounding.AwayFromZero);
              //  detail.SalePrice = detail.SinglePrice;
            }
        }

        private void SetSumMoney(RetailDetail detail)
        {
            if (balanceRound)
            {
                detail.SumMoney = Math.Round(detail.SumMoney, MidpointRounding.AwayFromZero);
                //detail.SalePrice = detail.SinglePrice;
            }
            else
            {
                detail.SumMoney = Math.Round(detail.SumMoney, 2, MidpointRounding.AwayFromZero);
                //detail.SalePrice = detail.SinglePrice;
            }

        }


        private void ValidateDiscount(RetailDetail detail, Decimal discount)
        {
            //20190312 一口价不用提示折扣!detail.IsBuyout
            if (discountPromotionRule == null && discount < shop.MinDiscount && !detail.IsBuyout && detail.SinglePrice>0)
            {
                GlobalMessageBox.Show(string.Format("本店最低折扣值{0},输入值不能低于它", shop.MinDiscount));
                this.dataGridView1.CancelEdit();
            }
            else
            {
                if (discountPromotionRule != null && discount < discountPromotionRule.Discount)
                {
                    if (detail.InSalesPromotion)
                    {
                        //有促销活动,用户输入折扣低于促销活动折扣
                        GlobalMessageBox.Show(string.Format("不能低于促销折扣{0}", discountPromotionRule.Discount));
                        this.dataGridView1.CancelEdit();
                    }
                }
            }
        }
        #endregion

        #region 更换促销方案
        //促销方案更换时触发
        private void skinComboBox_Promotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  this.BaseButtonSingleDiscount.Visible = false;

            bool isPromotion = this.skinComboBox_Promotion.SelectedItem is SalesPromotion;
            if (!isPromotion)
            {
                return;
            } 

            this.currentSalesPromotion = (SalesPromotion)this.skinComboBox_Promotion.SelectedItem;
            this.currentPromotionRuleList = new List<IPromotionRule>();
            switch (this.currentSalesPromotion.PromotionType)
            {
                case (byte)PromotionTypeEnum.Null:
                    this.skinLabel_PromotionIllustration.Text = "";
                    this.BaseButtonSingleDiscount.Visible = true;
                    break;
                case (byte)PromotionTypeEnum.MJ://满减
                    foreach (IPromotionRule rule in this.currentSalesPromotion.Rules)
                    {
                        this.currentPromotionRuleList.Add((MJPromotionRule)rule);
                    }
                    this.currentIsInSingleDiscount = false;
                    break;
                case (byte)PromotionTypeEnum.Discount://折扣
                    foreach (IPromotionRule rule in this.currentSalesPromotion.Rules)
                    {
                        this.currentPromotionRuleList.Add((DiscountPromotionRule)rule);
                    }
                    this.currentIsInSingleDiscount = false;

                    break;
            }
            string promotionIllustration = "";
            foreach (IPromotionRule rule in this.currentPromotionRuleList)
            {
                promotionIllustration += rule.ToString() + "\r\n";
            }
            this.skinLabel_PromotionIllustration.Text = promotionIllustration;

            if (this.retailDetailList != null)
            {
                this.UpdateValueByPromotion(true);
            }

        }
        #endregion

        #region 挂单
        private void BaseButton_GuaDan_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.retailDetailList == null || this.retailDetailList.Count == 0)
                {
                    GlobalMessageBox.Show("挂单商品不能为空！");
                    return;
                }

                HangedOrder hangedOrder = new HangedOrder();
                hangedOrder.DetailList = new List<RetailDetail>();
                hangedOrder.MemberID = this.currentMember == null ? "" : this.currentMember.PhoneNumber;
                hangedOrder.MemberName = this.currentMember == null ? "" : this.currentMember.Name;
                hangedOrder.CreateTime = DateTime.Now;
               hangedOrder.GuideID = (string)this.guideComboBox1.SelectedValue;

                //  WriteLog("MemberID="+hangedOrder.MemberID + "  MemberName=" + hangedOrder.MemberName + "  " + "  CreateTime=" + hangedOrder.CreateTime + "  " + "  GuideID="+hangedOrder.GuideID+"  ");
                if (this.retailDetailList != null)
                {
                    int i = 0;
                    foreach (RetailDetail item in this.retailDetailList)
                    {
                        item.Discount = item.DiscountOrigin;
                        if (balanceRound)
                        {
                            item.SinglePrice = Math.Round(item.Price * item.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                             
                        }
                        else
                        {

                            item.SinglePrice = Math.Round(item.Price * item.Discount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                            
                        }
                    //    item.SalePrice = item.SinglePrice;
                        decimal sumMoney = item.SinglePrice * (int)item.BuyCount;
                        hangedOrder.TotalCount += (int)item.BuyCount;
                        hangedOrder.TotalMoney += sumMoney;
                        item.SumMoney = sumMoney;
                        item.SumMoneyActual = sumMoney;
                        i++;
                        //  WriteLog("记录第"+i+"条："+"折扣价="+ item.Discount+" 商品单价=" + item.SinglePrice+" 商品件数="+item.BuyCount+" 小计金额="+ sumMoney+" 实收金额="+ sumMoney);
                        hangedOrder.DetailList.Add(item);
                    }
                }
                if (this.orderAggregate != null)
                {
                    if (this.orderAggregate.HangedOrderList.Count >= this.orderAggregate.MaxHangedCount)
                    {
                        this.orderAggregate.HangedOrderList.RemoveAt(0);
                    }
                    this.orderAggregate.HangedOrderList.Add(hangedOrder);
                    this.orderAggregate.Save(GlobalUtil.HangedOrderBagPath);
                    GlobalMessageBox.Show("挂单成功!");
                    this.CleanForm();
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }

        }
        #endregion

        #region 提单
        private void BaseButton_TiDan_Click(object sender, EventArgs e)
        {
            try
            {
                TiDanForm tiDanForm = new TiDanForm(this.orderAggregate);
                tiDanForm.HangedOrderSelected += TiDanForm_HangedOrderSelected;//提单被选择后触发
                tiDanForm.ShowDialog();
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }

        private void TiDanForm_HangedOrderSelected(HangedOrder hangedOrder)
        {
            this.CleanForm();
            this.currentMember = GlobalCache.ServerProxy.GetOneMember(hangedOrder.MemberID);
            if (this.currentMember != null)
            {
                this.ShowMemberDetails();
            }

            this.retailDetailList = hangedOrder.DetailList;
            BindingDatasource();
            //默认促发促销打折
            skinComboBox_Promotion_SelectedIndexChanged(null, null);
            this.SetTotalLabel_MoneyAndCount();
        }

        private void RedoOrder(RetailOrder retailOrder)
        {
            this.CleanForm();
            dateTimePicker_Start.Value = retailOrder.CreateTime;
            this.currentMember = GlobalCache.ServerProxy.GetOneMember(retailOrder.MemeberID);
            if (this.currentMember != null)
            {
                this.ShowMemberDetails();
            }

            this.retailDetailList = GlobalCache.ServerProxy.GetRetailDetailList(retailOrder.ID);
            string selectShopid = ValidateUtil.CheckEmptyValue(retailOrder.ShopID);
            List<Guide> guideList = CommonGlobalCache.GuideList.FindAll(t => t.State == 0 && t.ShopID == selectShopid);


            if (retailDetailList != null)
            {
                foreach (var item in retailDetailList)
                {

                    this.GuideName.DataSource = guideList;
                    this.GuideName.DisplayMember = "Name";
                    this.GuideName.ValueMember = "ID";
                    Costume costume = CommonGlobalCache.GetCostume(item.CostumeID);
                    item.CostumeName = costume.Name;

                   // item.SinglePrice = item.SumMoney/item.BuyCount;
                    item.SizeDisplayName = CostumeStoreHelper.GetCostumeSizeName(item.SizeName,
                        CommonGlobalCache.GetSizeGroup(costume.SizeGroupName));
                }
            }
            UpdateValueByPromotion(true);

            //默认促发促销打折
            //  skinComboBox_Promotion_SelectedIndexChanged(null, null);
            // this.SetTotalLabel_MoneyAndCount();
        }
        #endregion

        #region 点击充值
        //点击充值

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.currentMember == null)
                {
                    return;
                }
                if (this.ClickRechargeButton != null)
                {
                    this.ClickRechargeButton(this.currentMember, this);
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }
        #endregion

        #region 充值回调
        //充值成功后刷新会员余额
        public override void RefreshPage()
        {
            switch (Action)
            {
                case Action_RECHARGE:
                case Action_MEMBER_NEW:
                default:
                    if (this.currentMember == null)
                    {
                        return;
                    }
                    this.currentMember = GlobalCache.ServerProxy.GetOneMember(this.currentMember.PhoneNumber);
                    this.ShowMemberDetails();
                    break;
            }
        }
        #endregion

        #region 整单打折


        private void BaseButton2_Click(object sender, EventArgs e)
        {
            if (BaseButtonSingleDiscount.Text == "整单打折")
            {
                SingleDiscount(ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue));
            }
            else
            {
                //取消整单打折
                SingleDiscountForm_DiscountConfirm(100, string.Empty);
                skinLabelSingleDiscount.Text = string.Empty;
                BaseButtonSingleDiscount.Text = "整单打折";
                skinComboBox_Promotion.Enabled = true;
                //尝试还原促销活动的规则
                skinComboBox_Promotion_SelectedIndexChanged(null, null);
                currentIsInSingleDiscount = false;
            }

            CheckColumnReadOnly();
        }

        private void SingleDiscount(string ShopId)
        {
            try
            {
                if (this.retailDetailList == null || this.retailDetailList.Count == 0)
                {
                    GlobalMessageBox.Show("销售列表为空，不能整单打折！");
                    return;
                }
                SingleDiscountForm singleDiscountForm = new SingleDiscountForm(ShopId);
                singleDiscountForm.DiscountConfirm += SingleDiscountForm_DiscountConfirm;
                singleDiscountForm.ShowDialog();

            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }

        private int singleDiscount;

        private void SingleDiscountForm_DiscountConfirm(int discount, string remarks)
        {

            if (this.retailDetailList == null || this.retailDetailList.Count == 0)
            {
                return;
            }
            BaseButtonSingleDiscount.Text = "取消整单打折";
            skinComboBox_Promotion.Enabled = false;
            // 放在这里整单打折OK
            CheckGiftTicket();
            singleDiscount = discount;
            skinLabelSingleDiscount.Text = (discount / 10.0).ToString() + "折";
            //if (String.IsNullOrEmpty(remarks))
            //{
            //    remarks = String.Empty;
            //}

            foreach (RetailDetail detail in this.retailDetailList)
            {
                detail.Discount = discount;
                if (balanceRound)
                {
                    detail.SinglePrice = Math.Round(detail.Price * detail.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                   // detail.SalePrice = detail.SinglePrice;
                }
                else
                {
                    detail.SinglePrice = Math.Round(detail.Price * detail.Discount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                  //  detail.SalePrice = detail.SinglePrice;
                }

                detail.SumMoney = detail.BuyCount * detail.SinglePrice;
                detail.SumMoneyActual = detail.SumMoney;
               // detail.Remarks = remarks;
            }

            this.currentIsInSingleDiscount = true;
            currentIsPromotionMJ = false;
            this.currentIsPromotionDiscount = false;
            this.dataGridView1.Refresh();
            this.SetTotalLabel_MoneyAndCount();
        }
        #endregion

        private void ShouYinCtrl_Load(object sender, EventArgs e)
        {
            toolStripButton3.Visible = !shop.IsGeneralStore;
            //重新加载系统配置信息
            CommonGlobalCache.ReInitConfig();
            skinComboBox_Promotion_SelectedIndexChanged(null, null);
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButtonClick?.Invoke((sender as ToolStripButton).Text, this);
        }

        private void skinLabelAddSupplier_Click(object sender, EventArgs e)
        {
            ToolStripButtonClick?.Invoke("会员开卡", this);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];

                CostumeStore store = (CostumeStore)cell.OwningRow.DataBoundItem;
                //获取颜色
                //获取尺码
                this.skinComboBox_Color.SelectedItem = store.ColorName;
                if (cell.ColumnIndex != colorNameDataGridViewTextBoxColumn1.Index)
                {
                    this.skinComboBox_Size.SelectedValue = cell.OwningColumn.DataPropertyName;
                }
                this.skinTextBox_bugCount.Text = "1";
                this.skinTextBox_bugCount.Focus();
            }
        }

        //open
        MemberDetailForm form = null;
        //private RetailOrder order;

        private void ShowForm(Member member)
        {
            if (form == null)
            {
                form = new MemberDetailForm();
            }
            form.ShowDialog(member);
        }

        private void skinLabel_MemberName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(this.currentMember);

        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListGiftTicketForm form = new ListGiftTicketForm(tickets);
            form.ShowDialog();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SizeGroup sizeGroup = CommonGlobalCache.GetSizeGroup(currentSelectedItem?.Costume.SizeGroupName);
            CommonGlobalUtil.ChangeSizeGroup(dataGridView2, sizeGroup, true);
        }

        String shopID = CommonGlobalCache.CurrentShopID;
        private Shop shop;
        string ISCancelShopId=null;
        bool isFlag = false;
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

                this.retailDetailList.Clear();
                SetCostumeDetails(null);
            }
            else
            {
                isFlag = false;
            }
            shopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);
            shop = skinComboBoxShopID.SelectedItem as Shop;
            ISCancelShopId = shopID;
            guideComboBox1.Initialize(Common.GuideComboBoxInitializeType.Null, shopID);
           
            if (guideComboBox1.SelectedValue == null || guideComboBox1.SelectedValue.ToString() == "" || guideComboBox1.SelectedValue.ToString() == "-1")
            {

                if (CommonGlobalCache.CurrentUser.Type == UserInfoType.Guide)
                {
                    this.guideComboBox1.SelectedValue = GlobalCache.CurrentUserID;
                }
            }
            CostumeCurrentShopTextBox1.ShopID = shopID;
            ChangeSalesPromotion();
        }

        private void guideComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              string guideID = (string)this.guideComboBox1.SelectedValue;
            if (guideID != null && guideID != "")
            {
                foreach (RetailDetail retailItem in this.retailDetailList)
                {
                    /*if (retailItem.GuideID == null || retailItem.GuideID == "")
                    {
                        retailItem.GuideID = guideID;
                         
                    }*/
                    retailItem.GuideID = guideID;
                }
                dataGridView1.Refresh();
            } 
        }
    }
}
