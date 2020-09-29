
using CCWin;
using CCWin.SkinControl;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.InteractEntity;
using JGNet.Manage;
using JGNet.Manage;
using JGNet.Server.Tools;
using CJBasic.Loggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common
{
    public partial class RefundDirectCtrl : BaseModifyUserControl
    {
        public override void HandleShortKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F3:
                    BaseButton_AddCostume.PerformClick();
                    break;

                case Keys.F4:
                    baseButton1.PerformClick();
                    break;
                //case Keys.Add:
                //    BaseButton2.PerformClick();
                //    break;
                default:
                    break;
            }
        }

        private List<Member> memberList;//当前被绑定的源

        /// <summary>
        /// 会员被选择时触发
        /// </summary>
        /// 
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;
        public event CJBasic.Action<Member, EventArgs> MemberSelected;

        public RefundDirectCtrl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {

           
            skinComboBoxShopID.Initialize(true);
            skinComboBoxShopID.SelectedValue = GlobalCache.CurrentShopID;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(dataGridView2);
            dataGridViewPagingSumCtrl1.Initialize();
            dataGridViewPagingSumCtrl1.ShowRowCounts = false;

            this.guideComboBox1.Initialize(GuideComboBoxInitializeType.Null, shopID);
            // this.guideComboBox2.Initialize(GuideComboBoxInitializeType.Null, shopID);
            if (CommonGlobalCache.CurrentUser.Type == UserInfoType.Guide)
            {
                this.guideComboBox1.SelectedValue = GlobalCache.CurrentUserID;
            }
            balanceRound = GlobalCache.GetParameter(ParameterConfigKey.RetailBalanceRound)?.ParaValue == "1"; //CommonGlobalUtil.GetOptionValueBoolean(OptionConfiguration.OPTION_CONFIGURATION_KEY_BALANCE_ROUND);

            if (!HasPermission(RolePermissionMenuEnum.退货, RolePermissionEnum.单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
            skinTextBox_bugCount.SkinTxt.KeyPress += skinTextBox_SkinTxt_KeyPress;
        }

        private void skinTextBox_SkinTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                GlobalMessageBox.Show("输入格式错误！");
                return;
            }
        }

        public RefundDirectCtrl(RetailOrder order)
        {
            InitializeComponent();
            Init();
            this.order = order;
            
            if (!HasPermission(RolePermissionMenuEnum.销售退货单查询, RolePermissionEnum.重做_单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }

            List<RetailDetail> details = CommonGlobalCache.ServerProxy.GetRetailDetailList(order.ID);
            if (!String.IsNullOrEmpty(order.MemeberID))
            {
                memberIDTextBox2.Text = order.MemeberID;
                memberIDTextBox2.Search();
            }
            //guideComboBox2.SelectedValue = order.GuideID;
            guideComboBox1.SelectedValue = order.OperateGuideID;
            dateTimePicker_Start.Value = order.CreateTime;
            string selectShopid = ValidateUtil.CheckEmptyValue(order.ShopID);
                    List<Guide> guideList = CommonGlobalCache.GuideList.FindAll(t => t.State == 0 && t.ShopID == selectShopid);

                 

             
            if (details != null)
            {
                foreach (var item in details)
                {
                    this.GuideName.DataSource = guideList;
                    this.GuideName.DisplayMember = "Name";
                    this.GuideName.ValueMember = "ID";
                    item.CostumeName = CommonGlobalCache.GetCostumeName(item.CostumeID);
                    item.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(item.CostumeID, item.SizeName);
                    item.BuyCount = -item.BuyCount;
                    item.SumMoney = -item.SumMoney;
                    item.IsRefund = true;
                    item.RefundCount = item.BuyCount;
                    item.SumMoneyActual = -item.SumMoneyActual;
                    item.IsUseTickets = false;
                    item.Discount = 100;
                    item.DiscountOrigin = 100;
                    item.AllowReviseDiscount = true;
                    item.CostPrice = -item.CostPrice;
                    item.SumCost = -item.SumCost;
                    item.GuideID = item.GuideID;
                }
            }
            retailDetailList = details;
            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(retailDetailList));
        }

        private bool balanceRound = true;
  

        //提交选择的会员
        private void ConfirmSelectCell(Member member)
        {
            if (this.MemberSelected != null)
            {
                this.MemberSelected(member, null);
            }
            //   this.DialogResult = DialogResult.OK;
        }

        //点击确认按钮
        private void BaseButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.DataSource == null)
                {
                    return;
                }
                int index = this.dataGridView1.SelectedCells[0].RowIndex;
                this.ConfirmSelectCell(this.memberList[index]);
            }
            catch (Exception ee)
            {
                CommonGlobalUtil.WriteLog(ee);
                GlobalMessageBox.Show("确认失败！");
            }
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
        private CostumeItem currentSelectedItem;//当前选中的CostumeItem 
        List<ListItem<String>> sizes = null;
        private CostumeStore currentSelectedStore;//当前选中的CostumeStore
        private void skinComboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据颜色获取对应尺码库存信息
            this.currentSelectedStore = this.currentSelectedItem.CostumeStoreList.Find(c => { return c.ColorName == ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedValue); });
            CommonGlobalUtil.SetCostumeSize(skinComboBox_Size, currentSelectedItem.Costume);
            //sizes = skinComboBox_Size.DataSource as List<ListItem<String>>; 
            //skinComboBox_Size.DataSource = null;
            //skinComboBox_Size.DataSource = sizes;

        }

        //在输入款号按下回车键开始查询 款号被选中时触发
        private void CostumeCurrentShopTextBox1_CostumeSelected(CostumeItem costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                this.SetCostumeDetails(costumeItem);
            }
        }

        private void CleanCostumeDetails()
        {
            dataGridView2.DataSource = null;
            this.skinComboBox_Color.DataSource = null;
            this.CostumeCurrentShopTextBox1.SkinTxt.Text = "";
            this.skinTextBox_bugCount.SkinTxt.Text = "";
        } 

        private void SetCostumeDetails(CostumeItem costumeItem)
        {
            if (costumeItem == null)
            {
                this.CleanCostumeDetails();
                return;
            }
            this.currentSelectedItem = costumeItem;
            //  this.skinLabel_CostumeName.Text = costumeItem.Costume.BrandName + "-" + costumeItem.Costume.Name;
            this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
            this.skinComboBox_Color.DataSource = costumeItem.Costume.Colors.Split(',');
            this.skinComboBox_Color.SelectedIndex = 0;
            this.skinTextBox_bugCount.SkinTxt.Text = "1";
            dataGridView2.DataSource = null;

            //隐藏没有的列
            //  HideUnUsedColumns();
            CommonGlobalUtil.SetCostumeSize(skinComboBox_Size, currentSelectedItem.Costume);
            dataGridView2.DataSource = DataGridViewUtil.ListToBindingList(costumeItem.CostumeStoreList)    ;
        }

        SizeGroup sizeGroup = null;
        private void BaseButton_AddCostume_Click(object sender, EventArgs e)
        {
            try
            { 
                int buyCount = int.Parse(this.skinTextBox_bugCount.SkinTxt.Text);
                if (buyCount <= 0)
                {
                    GlobalMessageBox.Show("退货数量必须大于0！");
                    return;
                }
                string selectShopid = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue); 
                List<Guide> guideList = CommonGlobalCache.GuideList.FindAll(t => t.State == 0 && t.ShopID == selectShopid);

                this.GuideName.DataSource = guideList;
                this.GuideName.DisplayMember = "Name";
                this.GuideName.ValueMember = "ID";
                string defaultGuid = string.Empty;
                if (this.guideComboBox1.SelectedIndex >0)
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
                    IsRefund = true,
                    RefundCount = buyCount,
                    BuyCount = buyCount,
                    Price = this.currentSelectedItem.Costume.Price,
                    SumMoney = this.currentSelectedItem.Costume.Price * buyCount,
                    SumMoneyActual = this.currentSelectedItem.Costume.Price * buyCount,
                    BrandName = ValidateUtil.CheckNotNullValue(currentSelectedItem.Costume.BrandName),
                  //  SinglePrice = this.currentSelectedItem.Costume.Price,
                    IsUseTickets = false,
                    ///288 收银时，商品的备注显示的是商品的备注
                    //Remarks = this.currentSelectedItem.Costume.Remarks,
                    Discount = 100,
                    DiscountOrigin = 100,
                    AllowReviseDiscount = true,//this.currentSelectedStore.AllowReviseDiscount,
                    CostPrice = this.currentSelectedItem.Costume.CostPrice,
                    SumCost = this.currentSelectedItem.Costume.CostPrice * buyCount,
                      
                      
                };

                if (!this.AddSelectedCostumeToList(detail))
                {
                    return;
                }
                dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(this.retailDetailList));
                this.skinTextBox_bugCount.SkinTxt.Text = "1";

            }
            catch (Exception ee)
            {
                CommonGlobalUtil.WriteLog(ee);
                GlobalMessageBox.Show("添加失败！");
            }
        }

        List<RetailDetail> retailDetailList = new List<RetailDetail>();
        private RetailOrder order;

        private bool AddSelectedCostumeToList(RetailDetail detail)
        {

            foreach (RetailDetail retailDetail in this.retailDetailList)
            {
                if (retailDetail.CostumeID == detail.CostumeID && retailDetail.ColorName == detail.ColorName && retailDetail.SizeName == detail.SizeName)
                {
                    GlobalMessageBox.Show("列表中已存在该款商品！");
                    int rowIndex = this.retailDetailList.IndexOf(retailDetail);
                    this.dataGridView1.ClearSelection();
                    this.dataGridView1.Rows[rowIndex].Selected = true;
                    return false;
                }
            }
            this.retailDetailList.Add(detail);
            // this.isAddDetail = true;
            return true;
        }

        private void baseButton3_Click(object sender, EventArgs e)
        {
            try
            { 
                if (this.guideComboBox1.SelectedIndex == 0)
                {
                    GlobalMessageBox.Show("该笔单的导购员不能为空！");
                    return;
                }

                string id = IDHelper.GetID(OrderPrefix.RefundOrder, CommonGlobalCache.GetShop(shopID).AutoCode);

                bool isNoHasGuidFlag = false;
                bool isSuperlen = false;
                if (this.retailDetailList != null && this.retailDetailList.Count > 0)
                {
                    foreach (RetailDetail detail in this.retailDetailList)
                    {
                        if (detail.GuideID == null || detail.GuideID == "")
                        {
                            isNoHasGuidFlag = true;
                            break;
                        }
                        if (Math.Abs(detail.SumMoney) > 0 && Math.Abs(detail.SumMoney) >Convert.ToDecimal(99999999.99))
                        {
                            isSuperlen = true;
                            break;
                        }

                    }
                }

                if (isNoHasGuidFlag)
                {
                    GlobalMessageBox.Show("导购员不能为空，请检查列表里所有款号的导购员！");
                    return;
                }
                if (isSuperlen)
                {
                    GlobalMessageBox.Show("请检查列表里所有款号的金额是否大于99999999.99！");
                    return;
                }


                #region 创建RefundCostume对象


                RefundCostume costume = new RefundCostume()
                {
                    RefundOrder = null,
                    RefundDetailList = new List<RetailDetail>()
                };
                int totalCount = 0;
                decimal totalPrice = 0;
                decimal totalCost = 0;
                decimal moneyCash = 0;
                foreach (RetailDetail detail in this.
                    retailDetailList)
                {
                    if (detail.IsRefund && detail.RefundCount > 0)
                    {
                        detail.Refunded = true;
                        totalCount += detail.RefundCount;
                        totalPrice += detail.RefundCount * detail.Price;
                        totalCost += detail.RefundCount * detail.CostPrice;
                        moneyCash += detail.SumMoney;
                        detail.SalePrice = detail.Price;
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
                    OriginOrderID = string.Empty,
                    //GuideID = (string)("-1".Equals(this.guideComboBox2.SelectedValue) ? string.Empty : this.guideComboBox2.SelectedValue),
                   //  OperateGuideID = (string)this.guideComboBox1.SelectedValue,
                    GuideID = (string)this.guideComboBox1.SelectedValue,
                    ShopID = shopID,
                    MemeberID = this.memberIDTextBox2.Text,
                    SalesPromotionID = string.Empty,
                    PromotionText = string.Empty,
                    //   TotalMoneyReceived = this.currentRetailCostume.RetailOrder.TotalMoneyReceived,
                    // TotalMoneyReceivedActual = this.currentRetailCostume.RetailOrder.TotalMoneyReceivedActual,
                    MoneyBankCard = 0,
                    MoneyWeiXin = 0,
                    MoneyOther = 0,
                    MoneyAlipay = 0,
                    SmallMoneyRemoved = 0,
                    MoneyChange = 0,
                    TotalCount = totalCount * -1,
                    TotalCost = totalCost * -1,
                    TotalPrice = totalPrice * -1,
                    EntryUserID = CommonGlobalCache.CurrentUserID,
                    MoneyDiscounted = 0,//若是全部退款，折扣金额为原始折扣金额，否则为0
                    Remarks = this.skinTextBox_RefundReason.SkinTxt.Text.Trim(),
                    CreateTime = DateTime.Now,
                };
                costume.RefundOrder = refundOrder;


                #endregion
                costume.RefundOrder.MoneyCash = moneyCash * -1;
                costume.RefundOrder.MoneyCash2 = costume.RefundOrder.MoneyCash;
                costume.RefundOrder.MoneyIntegration = 0;
                costume.RefundOrder.MoneyVipCard = 0;
                costume.RefundOrder.MoneyVipCardMain = 0;
                costume.RefundOrder.MoneyVipCardDonate = 0;
                costume.RefundOrder.CreateTime = dateTimePicker_Start.Value;
                costume.RefundOrder.EntryTime = DateTime.Now;
                //总计=现金+积分+VIP卡+优惠券
                //这笔单的应收金额 - （不退的那几件以原价* 数量 -满减金额） - （退的那几件）优惠券
                costume.RefundOrder.TotalMoneyReceived = costume.RefundOrder.MoneyCash + costume.RefundOrder.MoneyIntegration + costume.RefundOrder.MoneyVipCard;
                costume.RefundOrder.TotalMoneyReceivedActual = costume.RefundOrder.MoneyCash + costume.RefundOrder.MoneyVipCardMain;
                costume.RefundOrder.Benefit = costume.RefundOrder.TotalMoneyReceivedActual - costume.RefundOrder.TotalCost;

                //     this.moneyDiscounted = costume.RefundOrder.to- costume.RefundOrder ;
                costume.IsNotHaveRetailOrder = true;
                if (Math.Abs(costume.RefundOrder.TotalCount) < 1)
                {
                    GlobalMessageBox.Show("退货数量不能小于1");
                    return;
                }
                ConfirmRefundForm confirmRefundForm = new ConfirmRefundForm(costume,shopID, dataGridView1);
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

        private void ResetForm()
        {
            memberIDTextBox2.Text = string.Empty;
            this.retailDetailList.Clear();
            this.dataGridView2.DataSource = null;
            CostumeCurrentShopTextBox1.Text = null;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();
            this.skinTextBox_RefundReason.SkinTxt.Text = "";
            skinComboBox_Size.DataSource = null;
            skinComboBox_Color.DataSource = null;
            skinTextBox_bugCount.Text = "";
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
                BrandName = ValidateUtil.CheckNotNullValue(retailDetail.BrandName),
                OccureTime = dateTimePicker_Start.Value,
                //268 畅滞排行榜：商品退货后，零售金额变成0
                //20180820 summoney 修改为除以购买数量再乘以退货数量
                SumMoney = Math.Round(retailDetail.SumMoney * -1, 1, MidpointRounding.AwayFromZero),
                SumMoneyActual = Math.Round(retailDetail.SumMoneyActual * -1, 1, MidpointRounding.AwayFromZero),
                SizeDisplayName = retailDetail.SizeDisplayName,
                //retailDetail.RefundCount * retailDetail.Price * -1,
                CostPrice = retailDetail.CostPrice * -1,
                SumCost = retailDetail.RefundCount * retailDetail.CostPrice * -1,
                Remarks = retailDetail.Remarks,
                InSalesPromotion = retailDetail.InSalesPromotion,
                GiftTickets = retailDetail.GiftTickets,
                SalePrice = retailDetail.Price,
                RefundCount = retailDetail.RefundCount,
                 GuideID=retailDetail.GuideID,

            };
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
                            detail.GuideID = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); 
                        }
                   

                    switch (this.dataGridView1.Columns[e.ColumnIndex].HeaderText)
                    {
                        case "折扣":
                            if (balanceRound)
                            {
                                detail.SumMoney = detail.RefundCount * Math.Round(detail.Price * detail.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                                detail.SumMoneyActual = detail.SumMoney;
                            }
                            else
                            {
                                detail.SumMoney = detail.Price * detail.Discount * detail.RefundCount * (decimal)0.01;
                                detail.SumMoneyActual = detail.SumMoney;
                            }


                            break;
                        case "金额":

                            detail.Discount = (Math.Round((detail.SumMoney * 100) / (detail.Price * detail.RefundCount), 1, MidpointRounding.AwayFromZero));
                            break;
                        case "数量":
                            if (balanceRound)
                            {
                                detail.SumMoney = detail.RefundCount * Math.Round(detail.Price * detail.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                                detail.SumMoneyActual = detail.SumMoney;
                            }
                            else
                            {
                                detail.SumMoney = detail.Price * detail.Discount * detail.RefundCount * (decimal)0.01;
                                detail.SumMoneyActual = detail.SumMoney;
                            }
                            //268 畅滞排行榜：商品退货后，零售金额变成0
                            detail.SumCost = detail.CostPrice * detail.RefundCount;
                            break;
                        case "使用优惠券":
                            detail.IsUseTickets = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;

                            break;
                    }
                     
                    this.dataGridView1.Refresh(); 
                }
                catch (Exception ex)
                {
                    GlobalUtil.WriteLog(ex);
                    GlobalMessageBox.Show("内部错误，金额与折扣转化出错！");
                }
            }
        }

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
                        dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(this.retailDetailList));
                    }
                    if (e.ColumnIndex == GuideName.Index)
                    {
                        RetailDetail detail = this.retailDetailList[e.RowIndex];
                        // detail.GuideID = this.retailDetailList[e.ColumnIndex];
                        detail.GuideID = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        //detail.GuideName = CommonGlobalCache.GetUserName(detail.GuideID);
                    }

                }
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommonGlobalUtil.ChangeSizeGroup(dataGridView2, sizeGroup, true);
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

                 retailDetailList.Clear();
                
                dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(retailDetailList));
                // dataGridView2.DataSource = null;
                SetCostumeDetails(null);
            }
            else
            {
                isFlag = false;
            }
            shopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);
            ISCancelShopId = shopID;
            guideComboBox1.Initialize(Common.GuideComboBoxInitializeType.Null, shopID);
           // guideComboBox2.Initialize(Common.GuideComboBoxInitializeType.Null, shopID);
            CostumeCurrentShopTextBox1.ShopID = shopID;
        }

        private void guideComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string guideID = (string)this.guideComboBox1.SelectedValue;
            if (this.retailDetailList != null && this.retailDetailList.Count > 0)
            {
                foreach (RetailDetail detail in this.retailDetailList)
                {
                    /*   if (detail.GuideID == null || detail.GuideID == "")
                       {
                           //   isNoHasGuidFlag = true;
                           // break;
                           detail.GuideID = guideID;
                       }*/
                    detail.GuideID = guideID;
                }
            }

            dataGridView1.Refresh();
        }
    }
}
