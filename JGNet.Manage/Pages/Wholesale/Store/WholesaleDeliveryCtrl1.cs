using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Manage;
using JGNet.Core.InteractEntity;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Common.Core;  
using JGNet.Common;
using JGNet.Manage.Components;
using JieXi.Common;
using CJBasic; 
using JGNet.Core.Dev.InteractEntity;
using JGNet.Common.cache.Wholesale;
using CJBasic.Helpers;

//405 采购进货整改。  添加成本价，总成本
//每次添加新的商品到下面的表格中时，新增的商品会列在最下面，此时需要自动定位到新增的商品（我们现在是自动定位在最上面）。


namespace JGNet.Manage
{
    public partial class WholesaleDeliveryCtrl1 : BaseModifyUserControl
    {
        private List<CostumeStore> curSelectedCostumeStoreList;//当前被选中的CostumeStore集合
        private List<PfOrderDetail> curInboundDetailList = new List<PfOrderDetail>();//当前要入库的CostumeStore
        public CJBasic.Action<Costume, BaseUserControl> AddCostumeClick;
        public String GeneralStoreShopID { get; set; }
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2; 
        private SizeGroup sizeGroup;
        private PfCustomer pfCustomer;
        private PfOrder order;
        private OperationEnum action;
        public WholesaleDeliveryCtrl1()
        {
            InitializeComponent();
            Init();
            IsShowOnePage = true;
        }

        public WholesaleDeliveryCtrl1(PfOrder order, OperationEnum action= OperationEnum.Add)
        {
            InitializeComponent();
            Init();
         //   IsShowOnePage = true;
            this.order = order;
            this.action = action;
            if (action == OperationEnum.Redo)
            {
                if (!HasPermission(RolePermissionMenuEnum.批发发货退货单查询, RolePermissionEnum.重做_单据时间))
                {
                    dateTimePicker_Start.Enabled = false;
                }
            }

           
            // this.skinTextBox_Remarks.Text = order.Remarks;
        }

        private void Init()
        {
            MenuPermission =RolePermissionMenuEnum.批发发货;
            skinLabelPrice.Text = string.Empty;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.ShowRowCounts = false;
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2, new string[] {
                  xSDataGridViewTextBoxColumn.DataPropertyName,
       sDataGridViewTextBoxColumn.DataPropertyName,
       mDataGridViewTextBoxColumn.DataPropertyName,
       lDataGridViewTextBoxColumn.DataPropertyName,
       xLDataGridViewTextBoxColumn.DataPropertyName,
       xL2DataGridViewTextBoxColumn.DataPropertyName,
       xL3DataGridViewTextBoxColumn.DataPropertyName,
       xL4DataGridViewTextBoxColumn.DataPropertyName,
       xL5DataGridViewTextBoxColumn.DataPropertyName,
       xL6DataGridViewTextBoxColumn.DataPropertyName,
       fDataGridViewTextBoxColumn.DataPropertyName,
            SumCount.DataPropertyName,
          //  SumMoney.DataPropertyName,
            dataGridViewTextBoxColumn14.DataPropertyName
            });
            dataGridViewPagingSumCtrl2.ShowRowCounts = false;
            dataGridViewPagingSumCtrl2.Initialize();
            
            costumeFromSupplierTextBox1.ShopID = CommonGlobalCache.GeneralStoreShopID;
            if (!HasPermission(RolePermissionMenuEnum.批发发货, RolePermissionEnum.单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
        }
        private bool balanceRound = false;
        private void Initialize()
        {
            try
            {
                ResetAll(false);
                skinComboBox_PfCustomer.Initialize(true, true);
                //默认选择总仓
                skinComboBoxShopID.Initialize(true);  
                 GeneralStoreShopID = GlobalCache.GeneralStoreShopID;
                this.skinComboBoxShopID.SelectedValue = GeneralStoreShopID;
                LoadOrder(order);
                DataGridViewUtil.SetAlternatingColor(dataGridView1, Color.Gainsboro, Color.White);

                balanceRound = GlobalCache.GetParameter(ParameterConfigKey.PfPriceRound).ParaValue == "1";
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void LoadOrder(PfOrder order)
        {
            if (order != null)
            { //冲单重做
                skinComboBox_PfCustomer.SelectedValue = order.PfCustomerID;
                dateTimePicker_Start.Value = order.CreateTime;
                numericTextBoxMoney.Value = order.PayMoney;
                SetPayType(order.PayType);
                skinComboBoxShopID.SelectedValue = order.ShopID;
                curInboundDetailList = GlobalCache.ServerProxy.GetPfOrderDetails(order.ID);
                if (curInboundDetailList != null)
                {
                    foreach (var item in curInboundDetailList)
                    {
                        Costume costume = CommonGlobalCache.GetCostume(item.CostumeID);
                        item.CostumeName = costume.Name;
                        item.CustomerID = order.PfCustomerID;
                        item.BrandName = CommonGlobalCache.GetBrandName(costume.BrandID);
                        item.CustomerName = PfCustomerCache.GetPfCustomerName(item.CustomerID);
                    }
                }
                skinTextBox_Remarks.Text = order.Remarks;
            }

            this.BindingInboundDetailSource();
        }

        //点击出库按钮
        private void Save(bool isHang)
        {
            try
            {
                bool pfPriceEmpty = false;
                bool pfPriceSuperLen = false;
                bool pfMoneySuperLen = false;
                foreach (var detail in curInboundDetailList)
                {
                    if (detail.PfPrice == 0)
                    {
                        pfPriceEmpty = true;
                        break;
                    }
                    if (detail.PfPrice > 0 && detail.PfPrice > Convert.ToDecimal(99999999.99))
                    {
                        // SumPfMoney
                        pfPriceSuperLen = true;
                        break;
                    }
                    if (detail.SumPfMoney > 0 && detail.SumPfMoney > Convert.ToDecimal(99999999.99))
                    {
                        // SumPfMoney
                        pfMoneySuperLen = true;
                        break;
                    }

                }

                if (pfPriceSuperLen)
                {
                    GlobalMessageBox.Show("批发价不能大于99999999.99！");
                    return;
                }
                if (pfMoneySuperLen)
                {
                    GlobalMessageBox.Show("列表中批发每款商品总额不能大于99999999.99！");
                    return;
                }
                /*  if (pfPriceEmpty) {
                      GlobalMessageBox.Show("批发价不能为0,请重新输入！");
                      return;
                  }*/

                PfInfo item = this.Build();
                if (item == null || item.PfOrder.TotalCount == 0 || item.PfOrderDetails.Count == 0)
                {
                    GlobalMessageBox.Show("发货单为空,不能发货！");
                    return;
                }
                //if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                //{
                //    return;
                //}

                //弹窗录入付款方式
                //int payType= ShowPayTypeForm(item);
                //if (payType == -1)
                //{
                //    return;
                //}
               
                item.PfOrder.PayMoney = numericTextBoxMoney.Value;
                item.PfOrder.PayType = (byte)GetPayType();
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                InteractResult result ;
                if (isHang)
                {
                    result = GlobalCache.ServerProxy.HangUpPfDelivery(item);
                }
                else
                {
                    result = GlobalCache.ServerProxy.PfDelivery(item);
                     
                } 
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        if (isHang)
                        {
                            GlobalMessageBox.Show("挂单成功！");
                        }
                        else
                        {
                            GlobalMessageBox.Show("发货成功！");
                             
                            if (skinCheckBoxPrint.Checked)
                            {
                                //Column3.Visible = false;
                                //Column3.Tag = WholesaleDeliveryPrinter.PrinterNoCount;
                                //Column2.Visible = false;
                                //Column2.Tag = WholesaleDeliveryPrinter.PrinterNoCount;
                                //priceDataGridViewTextBoxColumn.Visible = false;
                                //priceDataGridViewTextBoxColumn.Tag = WholesaleDeliveryPrinter.PrinterNoCount;
                                //BoundDetailBrandIDDataGridViewTextBoxColumn.Visible = false;
                                //BoundDetailBrandIDDataGridViewTextBoxColumn.Tag = WholesaleDeliveryPrinter.PrinterNoCount;
                                DataGridView dgv=deepCopyDataGridView();
                                InteractResult<PfOrder> pfResult=GlobalCache.ServerProxy.GetOnePfOrder(item.PfOrder.ID);
                                decimal BalanceAllOld = 0;
                                decimal BalanceAll = 0;
                                decimal totalPrice = 0;
                                if (pfResult.Data!=null)
                                {
                                    BalanceAllOld = pfResult.Data.PaymentBalanceOld;
                                    BalanceAll = pfResult.Data.PaymentBalance;
                                    totalPrice= pfResult.Data.TotalPfPrice;
                                }
                                item.PfOrder.PaymentBalanceOld = BalanceAllOld;
                                item.PfOrder.PaymentBalance = BalanceAll;
                                item.PfOrder.TotalPfPrice = totalPrice;
                                WholesaleDeliveryPrinter.Print(item.PfOrder, dgv, 2);
                                //Column3.Visible = true;
                                //Column2.Visible = true;
                                //priceDataGridViewTextBoxColumn.Visible = true;
                                //BoundDetailBrandIDDataGridViewTextBoxColumn.Visible = true;
                            }
                        }
                        //  UpdatePayType(payType,item);

                        
                        ResetAll(true);
                        if (!IsShowOnePage)
                        {
                            TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
                GlobalMessageBox.Show("发货失败！");
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
            dgvTmp.AutoGenerateColumns = false;
            //  dgvTmp.AllowUserToAddRows = false; //不允许用户生成行，否则导出后会多出最后一行
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                dgvTmp.Columns.Add(dataGridView2.Columns[i].Name, dataGridView2.Columns[i].HeaderText);
                if (dataGridView2.Columns[i].DefaultCellStyle.Format.Contains("N")) //使导出Excel文档金额列可做SUM运算
                {
                    dgvTmp.Columns[i].DefaultCellStyle.Format = dataGridView2.Columns[i].DefaultCellStyle.Format;

                }
                if (!dataGridView2.Columns[i].Visible)
                {
                    dgvTmp.Columns[i].Visible = false;
                }
                dgvTmp.Columns[i].DataPropertyName = dataGridView2.Columns[i].DataPropertyName;
                dgvTmp.Columns[i].HeaderText = dataGridView2.Columns[i].HeaderText;
                dgvTmp.Columns[i].Tag = dataGridView2.Columns[i].Tag;
                dgvTmp.Columns[i].Name = dataGridView2.Columns[i].Name;
            }



            List<PfOrderDetail> listtb1 = DataGridViewUtil.BindingListToList<PfOrderDetail>(dataGridView2.DataSource);

            List<PfOrderDetail> tb2 = new List<PfOrderDetail>();
            foreach (PfOrderDetail idetail in listtb1)
            {
                PfOrderDetail tDetail = new PfOrderDetail();
                ReflectionHelper.CopyProperty(idetail, tDetail);
              //  tDetail.Price= CommonGlobalCache.GetCostume(tDetail.CustomerID).Price;
                tb2.Add(tDetail);

            }

         /*   foreach (DataRow dr in tb2.Rows)
            {
                // dr["CostumeID"]
                dr["Price"] = CommonGlobalCache.GetCostume(dr["CostumeID"].ToString()).Price;
            }*/
            dgvTmp.DataSource = tb2;



            return dgvTmp;
        }

        private void SetPayType(byte payType)
        {
            switch (payType)
            {
                case 0:
                    skinRadioButtonRecord.Checked = true;
                    break;
                case 1:
                    skinRadioButtonBalance.Checked = true;
                    break;
                case 2:
                    skinRadioButtonCash.Checked = true;
                    break;
                default:
                    break;
            }
        }


        private int GetPayType()
        {

            if (skinRadioButtonRecord.Checked)
            {
                return 0;
            }
            if (skinRadioButtonBalance.Checked)
            {
                return 1;
            }
            if (skinRadioButtonCash.Checked)
            {
                return 2;
            }
            return 0;
        }

        private void UpdatePayType(int selectType,PfInfo item)
        {
            switch (selectType)
            {
                case 0:
                    //记录一条欠条
                    GlobalCache.ServerProxy.PfDelivery(item);
                    break;

                case 1:
                    //减去余额
                    pfCustomer.Balance -= item.PfOrder.TotalPfPrice;
                    InteractResult interactResult = PfCustomerCache.PfCustomer_OnUpdate(pfCustomer);
                    switch (interactResult.ExeResult)
                    {
                        case ExeResult.Success:
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(interactResult.Msg);
                            break;
                        default:
                            break;
                    }
                    break;

                case 2:
                    break;
                default:
                    break;
            }
        }

        private int ShowPayTypeForm(PfInfo item)
        {
            int selectType = -1;
            WholesaleDeliveryPayForm form = new WholesaleDeliveryPayForm(pfCustomer,item.PfOrder.TotalPfPrice);
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectType = form.Result;
            }

            return selectType;
        }

        private void ResetAll(Boolean resetAction)
        {
            skinLabel1Account.Text = string.Empty;
            curSelectedCostumeStoreList = null;
            costumeFromSupplierTextBox1.SkinTxt.Text = string.Empty;
            curInboundDetailList = new List<PfOrderDetail>();
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;
            if (this.order != null)
            {
                this.skinTextBox_Remarks.SkinTxt.Text = order.Remarks;
            }
            else
            {
                this.skinTextBox_Remarks.SkinTxt.Text = string.Empty;
            }
            numericTextBoxMoney.Value = 0;
            skinRadioButtonRecord.Checked = true;
            if (resetAction)
            {
                action = OperationEnum.Add;
            }
        }

        private PfInfo Build()
        {
            if (
                this.curInboundDetailList == null || this.curInboundDetailList.Count == 0)
            {
                return null;
            }
            int totalCount = 0;
            decimal totalPrice = 0;
            decimal totalCost = 0;
            List<PfOrderDetail> details = new List<PfOrderDetail>();

            //使用补货申请单的店铺ID信息

            // Shop shop = GlobalCache.ShopList.Find(t => t.ID == this.curReplenishOrder.ShopID);
            Shop shop = (Shop)this.skinComboBoxShopID.SelectedItem;
            string id = IDHelper.GetID(OrderPrefix.PfDelivery, shop.AutoCode);

            if (action == OperationEnum.Pick)
            {
                id = order?.ID;
            }
         //   string pOrderID = IDHelper.GetID(OrderPrefix.PurchaseOrder, shop.AutoCode);
            foreach (PfOrderDetail detail in this.curInboundDetailList)
            {
                if (detail.SumCount <= 0)
                {
                    continue;
                }
                
                totalCount += detail.SumCount;
                totalPrice += detail.SumMoney;
                totalCost += detail.SumCost;
                detail.PfOrderID = id;  
                details.Add(detail);
            }
             


            PfOrder pOrder = new PfOrder()
            {   ShopID = shop.ID, 
                PfCustomerID = selectedSupplierID,// ValidateUtil.CheckEmptyValue(this.skinComboBox_SupplierID.SelectedValue),
                ID = id,
                AdminUserID = GlobalCache.CurrentUserID,
                CreateTime=      dateTimePicker_Start.Value,

                EntryTime = DateTime.Now,
                TotalCount = totalCount,
                TotalPrice = totalPrice,
                TotalPfPrice = totalCost,
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text

                // InboundOrderID=  
            };

            return new PfInfo()
            { 
                PfOrder = pOrder, 
                PfOrderDetails = details
            };


        }


        private CostumeItem costumeItem;
        private void costumeFromSupplierTextBox1_CostumeSelected(CostumeItem costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                this.costumeItem = costumeItem;
                if (costumeItem == null)
                {
                    this.curSelectedCostumeStoreList = null;
                    this.textBoxAmount.Text = string.Empty;
                    skinLabelPrice.Text = string.Empty;
                }
                else
                {
                    this.curSelectedCostumeStoreList = costumeItem.CostumeStoreList;
                    //  this.costumeFromSupplierTextBox1.SkinTxt.Text = costumeItem.ID;
                    //this.curSelectedCostumeStoreList = CostumeFromSupplierTextBox.GetCostumeStores(costumeItem.Costume);
                    //计算客户折扣 批发价

                    CheckStorePrice(pfCustomer.ID, costumeItem.Costume.ID);
                    /*if (this.textBoxAmount.Value == 0)
                    {
                        if (balanceRound)
                        {
                            //detail.SumMoney = detail.RefundCount * Math.Round(detail.Price * detail.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                            this.textBoxAmount.Value = costumeItem.Costume.Price == 0 ? 0 : Math.Round(costumeItem.Costume.Price * pfCustomer.PfDiscount * (decimal)0.01, MidpointRounding.AwayFromZero);
                        }
                        else
                        {
                            this.textBoxAmount.Value = costumeItem.Costume.Price == 0 ? 0 : Math.Round(costumeItem.Costume.Price * pfCustomer.PfDiscount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                        }
                    }*/
                    skinLabelPrice.Text = costumeItem.Costume.Price.ToString();
                  
                }

                this.BindingSelectedCostumeStoreSource();
            }
        }


        /// <summary>
        /// 绑定要补货的集合源
        /// </summary>
        private void BindingInboundDetailSource()
        {
            dataGridViewPagingSumCtrl2.BindingDataSource<PfOrderDetail>(DataGridViewUtil.ListToBindingList(this.curInboundDetailList));
           // dataGridViewPagingSumCtrl3.BindingDataSource<PfOrderDetail>(DataGridViewUtil.ListToBindingList(this.curInboundDetailList));
            dataGridViewPagingSumCtrl2.ScrollToEnd();
        }

        /// <summary>
        /// 绑定选定款号对应的CostumeStore集合
        /// </summary>
        private void BindingSelectedCostumeStoreSource()
        {

             
            if (this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > 0)
            {
                List<CostumeStore> tempList = new List<CostumeStore>();
                foreach (CostumeStore store in this.curSelectedCostumeStoreList)
                {
                    store.Title = "店铺库存";
                    CostumeStore tempStore = this.BuildCostumeStore4NeedReplenish(store);
                    tempList.Add(store);
                    tempList.Add(tempStore);
                }
                this.curSelectedCostumeStoreList = tempList;
              
            }
            this.dataGridViewPagingSumCtrl.SetDataSource<CostumeStore>(DataGridViewUtil.ListToBindingList(this.curSelectedCostumeStoreList));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.ReadOnly = true;
                    row.HeaderCell.Value = "店铺库存";

                }
                else
                {
                    row.ReadOnly = false;
                    row.HeaderCell.Value = "发货";
                }
            }  

                // cell获取焦点
                dataGridViewPagingSumCtrl.AutoFocusToWritableCell();
 
        }

        /// <summary>
        /// 根据现在库存对象生成需补货的库存对象
        /// </summary>
        /// <param name="oldCostumeStore"></param>
        /// <returns></returns>
        private CostumeStore BuildCostumeStore4NeedReplenish(CostumeStore oldCostumeStore)
        {
            CostumeStore store = null;
            if (oldCostumeStore != null)
            {
                store = new CostumeStore()
                {
                    CostumeID = oldCostumeStore.CostumeID,
                    CostumeName = oldCostumeStore.CostumeName,
                    ColorName = oldCostumeStore.ColorName,
                    BrandID = oldCostumeStore.BrandID,
                    BrandName = oldCostumeStore.BrandName,
                    AllowReviseDiscount = oldCostumeStore.AllowReviseDiscount,
                    ShopID = oldCostumeStore.ShopID,
                    Price = oldCostumeStore.Price,
                    CostPrice = oldCostumeStore.CostPrice,
                    Title = "发货",
                    F = 0,
                    L = 0,
                    XS = 0,
                    M = 0,
                    S = 0,
                    XL = 0,
                    XL2 = 0,
                    XL3 = 0,
                    XL4 = 0,
                    XL5 = 0,
                    XL6 = 0,
                    
                };

          
            }
            return store;
        }

        private void BaseButton_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.curSelectedCostumeStoreList == null || this.curSelectedCostumeStoreList.Count == 0)
                {
                    return;
                }
                if (pfCustomer == null)
                {
                    GlobalMessageBox.Show("客户不存在，请重新选择！");
                    skinComboBox_PfCustomer.Focus();
                    return;
                }
               /* if (this.textBoxAmount.Value <= 0)
                {
                    GlobalMessageBox.Show("批发价不能为零！");
                    textBoxAmount.Focus();
                    return;
                }*/
              /*  if (textBoxAmount.Value == 0)
                {
                    GlobalMessageBox.Show("请输入批发价！");
                    textBoxAmount.Focus();
                    return;
                }*/
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
              //  List<CostumeStore> costumeStoreList = this.curSelectedCostumeStoreList;
                List<CostumeStore> costumeStoreList = this.curSelectedCostumeStoreList.FindAll((x) => x.Title == "发货");
                foreach (CostumeStore store in costumeStoreList)
                {
                    if (store.SumCount == 0)
                    {
                        continue;
                    }
                    if (store.Remarks == null)
                    {
                        store.Remarks = "";
                    }
                    PfOrderDetail detail = this.CostumeStoreConvertToInboundDetail(store);
                    detail.CustomerName = pfCustomer.Name;
                   // ShowMessage(CommonGlobalCache.GetCostume(detail.CostumeID).Price.ToString());
                     detail.Price = CommonGlobalCache.GetCostume(detail.CostumeID).Price;

                    detail.PfPrice =
                         this.textBoxAmount.Value;
                    this.InboundDetailListAddItem(detail);
                    // }
                }
                textBoxAmount.Text = string.Empty;
                skinLabelPrice.Text = string.Empty;
                //清空dataGirdView1的绑定源 
                this.dataGridView1.DataSource = null;
                this.costumeFromSupplierTextBox1.Text = string.Empty;
                this.curSelectedCostumeStoreList = null;
                this.BindingInboundDetailSource();
                this.costumeFromSupplierTextBox1.Focus();
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


        /// <summary>
        /// 将CostumeStore转化为InboundDetail  
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        private PfOrderDetail CostumeStoreConvertToInboundDetail(CostumeStore store)
        {
            if (store == null)
            {
                return null;
            }
            return new PfOrderDetail()
            {
                //ReplenishOrderID = replenishOrderID,
                CostumeID = store.CostumeID,
                CostumeName = store.CostumeName,
                BrandName = store.BrandName,
                ColorName = store.ColorName,
                CustomerID = ValidateUtil.CheckEmptyValue(this.skinComboBox_PfCustomer.SelectedValue),


                //   Discount = store.Discount,
                BrandID = store.BrandID,
                XS = store.XS,
                S = store.S,
                M = store.M,
                L = store.L,
                F = store.F,
                XL = store.XL,
                XL2 = store.XL2,
                XL3 = store.XL3,
                XL4 = store.XL4,
                XL5 = store.XL5,
                XL6 = store.XL6,
                Price = store.Price,
                PfPrice = store.CostPrice,
                Comment = store.Remarks,
            };
        }

        private void InboundDetailListAddItem(PfOrderDetail detail)
        {


            bool existed = false;
            DialogResult result = DialogResult.No;
            PfOrderDetail repeatItem = null;
            foreach (PfOrderDetail item in this.curInboundDetailList)
            {
                if (item.CostumeID.ToUpper() == detail.CostumeID.ToUpper() && item.ColorName == detail.ColorName)
                {
                    repeatItem = item;
                    existed = true;
                    result = GlobalMessageBox.Show(string.Format("款号：{0}  颜色：{1} 的服装已经存在列表中，是否覆盖", item.CostumeID, item.ColorName), "", MessageBoxButtons.YesNo);

                    break;
                }
            }
            if (!existed || result == DialogResult.Yes)
            {
                //不存在或者重复时直接覆盖
                if (repeatItem != null)
                {
                    this.curInboundDetailList.Remove(repeatItem);
                }
                // this.curInboundDetailList.Insert(0, detail);
                this.curInboundDetailList.Add(detail);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                switch (this.dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    case "删除":
                        this.curInboundDetailList.RemoveAt(e.RowIndex);
                        this.BindingInboundDetailSource();
                        break;
                }
            }
            catch (Exception ee)
            {

                GlobalUtil.ShowError(ee);
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            try
            {
                if (CommonGlobalUtil.NotStoreColumnIndex(e.ColumnIndex, dataGridViewTextBoxColumn15.Index, dataGridViewTextBoxColumn13.Index)
              )
                {
                    return;
                }
                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Decimal.Parse(e.FormattedValue.ToString());
                }
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > e.RowIndex  && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
                {
                    decimal oldCount = 0;
                    if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                    {
                        oldCount = Decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
                    }
                    if (newCount == oldCount)
                    {
                        return;
                    }
                    GlobalMessageBox.Show("原始库存不能修改！");
                    dataGridView.CancelEdit();
                    return;
                }
               /* if (newCount < 0)
                {
                    GlobalMessageBox.Show("发货数不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }*/
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            try
            {
                if (CommonGlobalUtil.NotStoreColumnIndex(e.ColumnIndex, fDataGridViewTextBoxColumn.Index, xL6DataGridViewTextBoxColumn.Index)
                 )
                {
                    return;
                }
                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Decimal.Parse(e.FormattedValue.ToString());
                }
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > e.RowIndex  && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
                {
                    Decimal oldCount = 0;
                    if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                    {
                        oldCount = Decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
                    }
                    if (newCount == oldCount)
                    {
                        return;
                    }
                    GlobalMessageBox.Show("原始库存不能修改！");
                    dataGridView.CancelEdit();
                    return;
                }
                if (newCount < 0)
                {
                    GlobalMessageBox.Show("发货数不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            if (isCostumeStoreList)
            {
                this.dataGridView1.Refresh();
                return;
            }
            this.dataGridView2.Refresh();
        }



        private void PurchaseOrderCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

       
        String selectedSupplierID = String.Empty;
        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string supplierId = ValidateUtil.CheckEmptyValue(skinComboBox_PfCustomer.SelectedValue);

            if (!String.IsNullOrEmpty(selectedSupplierID) && selectedSupplierID != supplierId && curInboundDetailList != null && curInboundDetailList.Count > 0)
            {
                List<PfOrderDetail> pfDetails = new List<PfOrderDetail>();
                foreach (var item in curInboundDetailList)
                {
                    item.CustomerID = supplierId;
                    //item.CustomerName = GlobalCache(item.CustomerID);
                    Costume citem = GlobalCache.GetCostume(item.CostumeID);
                    if (pfCustomer != null)
                    {
                        item.CustomerName = pfCustomer.Name;
                        item.PfPrice = citem.Price == 0 ? 0 : Math.Round(citem.Price * pfCustomer.PfDiscount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                    }
                    pfDetails.Add(item);
                }
                this.curInboundDetailList.Clear();
                this.curInboundDetailList = pfDetails;
               // dataGridViewPagingSumCtrl3.BindingDataSource<PfOrderDetail>(this.curInboundDetailList);
                dataGridViewPagingSumCtrl2.BindingDataSource<PfOrderDetail>(this.curInboundDetailList);
                dataGridViewPagingSumCtrl2.ScrollToEnd();
            }
            if (skinComboBox_PfCustomer.SelectedItem != null)
            {
                skinLabel1Account.Text = "账套：" + (skinComboBox_PfCustomer.SelectedItem as PfCustomer)?.BusinessAccountID;
            }
            selectedSupplierID = supplierId;
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            dataGridView2.Refresh();
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //库存 也不用变色
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dataGridView1.Rows.Count <= 0) { return; }

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewUtil.CellPainting_SetCellFont(dataGridView1, cell, 4, 15, Color.Green, FontStyle.Bold);
        }

        private void dataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dataGridView2.Rows.Count <= 0) { return; }
            DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewUtil.CellPainting_SetCellFont(dataGridView2, cell, 6, 18, Color.Green, FontStyle.Bold);
        }

         

        private void skinLabelCostume_Click(object sender, EventArgs e)
        {
            SaveCostumeForm form = new SaveCostumeForm();
            form.Costume_Newed += SaveCostumeForm_Costume_Newed;
            form.ShowDialog(this);
        }

        private void SaveCostumeForm_Costume_Newed(Costume costume)
        {
            //添加到列表中
            costumeFromSupplierTextBox1.Text = costume.ID;
            costumeFromSupplierTextBox1.Search();
        }

        private void skinLabelAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                List<PfCustomer> list = (List<PfCustomer>)this.skinComboBox_PfCustomer.DataSource;
                NewWholesaleCustomerSimpleForm addForm = new NewWholesaleCustomerSimpleForm();
                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    if (list == null) { list = new List<PfCustomer>(); }
                    PfCustomer item = addForm.Result;
                    PfCustomer listItem = list.Find(t => t.Name == item.Name || t.ID == item.ID);
                    if (listItem == null)
                    {
                        item.Enabled = true;
                        item.CreateTime = DateTime.Now;
                        InteractResult result = PfCustomerCache.PfCustomer_OnInsert(item);
                        switch (result.ExeResult)
                        {
                            case ExeResult.Success:
                                this.skinComboBox_PfCustomer.DataSource = null;
                                list.Add(item);
                                this.skinComboBox_PfCustomer.DisplayMember = "Name";
                                this.skinComboBox_PfCustomer.ValueMember = "ID";
                                this.skinComboBox_PfCustomer.DataSource = list;
                                break; 
                            case ExeResult.Error:
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                    }

                }
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        public override void HandleShortKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F3:
                    BaseButton2.PerformClick();
                    break;
                case Keys.F4:
                    BaseButtonConfirm.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void skinComboBox_PfCustomer_ItemSelected(PfCustomer obj)
        {
            this.pfCustomer = obj;
            if (costumeItem != null && pfCustomer!=null)
            {
                CheckStorePrice(pfCustomer.ID, costumeItem.Costume.ID);
               /* if (this.textBoxAmount.Value == 0)
                {
                    if (balanceRound)
                    {
                        this.textBoxAmount.Value = costumeItem.Costume.Price == 0 ? 0 : Math.Round(costumeItem.Costume.Price * pfCustomer.PfDiscount * (decimal)0.01, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        this.textBoxAmount.Value = costumeItem.Costume.Price == 0 ? 0 : Math.Round(costumeItem.Costume.Price * pfCustomer.PfDiscount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                    }
                    
                }*/
            }
        } 
        private void CheckStorePrice(String pfCustomerID, String costumeID)
        {
                                                                          
            WebResponseObj<decimal> responseObj = GlobalCache.ServerProxy.GetCostumePfPrice(pfCustomerID, costumeID);
            decimal storePrice = responseObj.Data;
            if (storePrice != 0)
            {
                if (balanceRound)
                {
                    textBoxAmount.Value = Math.Round(storePrice);
                }
                else
                {
                    textBoxAmount.Value = storePrice;
                }
            }
            else
            {

                if (responseObj.ResponseCode == ResponseCode.Success)
                {
                    textBoxAmount.Value = 0;

                }
                /*GlobalMessageBox.Show("请确认批发价是否为零！");
                textBoxAmount.Focus();
                return;*/
            }
        }

        private void baseButton3_Click(object sender, EventArgs e)
        {
            if (GlobalMessageBox.Show("确定清空下表数据吗？", "友情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView2.DataSource = null;
                curInboundDetailList?.Clear();
                dataGridView2.Refresh();
                if (action == OperationEnum.Pick)
                {
                    order = null;
                    action = OperationEnum.Add;
                }
            }
        }
        private void baseButtonPick_Click(object sender, EventArgs e)
        {
            try
            {
                WholesaleDeliveryPickForm tiDanForm = new WholesaleDeliveryPickForm(true);
                tiDanForm.HangedOrderSelected += TiDanForm_HangedOrderSelected;//提单被选择后触发
                tiDanForm.ShowDialog();
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }
         
        private void TiDanForm_HangedOrderSelected(PfOrder hangedOrder)
        {
            action = OperationEnum.Pick;
            order = hangedOrder;
            LoadOrder(hangedOrder);
        }

        private void baseButtonHang_Click(object sender, EventArgs e)
        {
            Save(true);
        }
         
        private void BaseButton_Inbound_Click(object sender, EventArgs e)
        {
              Save(false);
        }
         
    }
}
