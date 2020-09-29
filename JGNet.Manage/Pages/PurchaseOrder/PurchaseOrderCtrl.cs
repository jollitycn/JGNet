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
using JGNet.Common.Printers;
using JGNet.Manage;
using System.IO;
using JGNet.Core.Tools;
using JGNet.Core.Dev.InteractEntity;
using CJBasic.Helpers;
using JGNet.Core.Const;

//405 采购进货整改。  添加成本价，总成本
//每次添加新的商品到下面的表格中时，新增的商品会列在最下面，此时需要自动定位到新增的商品（我们现在是自动定位在最上面）。


namespace JGNet.Manage
{
    /// <summary>
    ///  该功能没有售价,只能修改成本价,需要售价需要进行调拨
    /// </summary>
    public partial class PurchaseOrderCtrl : BaseModifyUserControl
    {

        private List<CostumeStore> curSelectedCostumeStoreList;//当前被选中的CostumeStore集合
        private List<BoundDetail> curInboundDetailList = new List<BoundDetail>();//当前要入库的CostumeStore
        public CJBasic.Action<Costume, BaseUserControl> AddCostumeClick;
        public String GeneralStoreShopID { get; set; }
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;
        private SizeGroup sizeGroup;
        private PurchaseOrder order;
        private OperationEnum action;
        public PurchaseOrderCtrl()
        {
            InitializeComponent();
            Init();
            IsShowOnePage = true;
        }

        public PurchaseOrderCtrl(PurchaseOrder order, OperationEnum action = OperationEnum.Add)
        {
            InitializeComponent();
            Init();
            //IsShowOnePage = true;
            this.action = action;
            if (action == OperationEnum.Redo) {
                if (!HasPermission(RolePermissionMenuEnum.采购进货退货单查询, RolePermissionEnum.重做_单据时间)) {
                    dateTimePicker_Start.Enabled = false;
                }
            }
            this.order = order;
        }

        private void Init()
        {
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
                 SumMoney.DataPropertyName,
            dataGridViewTextBoxColumn14.DataPropertyName
            });
            dataGridViewPagingSumCtrl2.ShowRowCounts = false;
            dataGridViewPagingSumCtrl2.Initialize();
             MenuPermission = RolePermissionMenuEnum.采购进货;
            if (!HasPermission(RolePermissionMenuEnum.采购进货, RolePermissionEnum.单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
        }

        private void Initialize()
        {
            try
            {
                ResetAll(false);
                // CommonGlobalUtil.SetSupplier(skinComboBox_SupplierID, true, true);
                //默认选择总仓
                skinComboBoxShopID.Initialize();
                // GeneralStoreShopID = GlobalCache.GeneralStoreShopID;
                // this.skinComboBoxShopID.SelectedValue = GeneralStoreShopID;
                CommonGlobalUtil.SetShop(skinComboBoxShopID, true);
                LoadOrder(order);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void LoadOrder(PurchaseOrder order)
        {
            this.order = order;
            if (order != null)
            { 
                //冲单重做
                skinTextBox_Remarks.Text = order.Remarks;
                skinComboBoxShopID.SelectedValue = order.DestShopID;
                if (shop == null)
                {
                    GlobalMessageBox.Show("店铺无效！");
                }

                curInboundDetailList.Clear();
                this.BindingInboundDetailSource();
                dateTimePicker_Start.Value = order.CreateTime;
                numericTextBoxMoney.Value = order.PayMoney;
                skinComboBox_SupplierID.SelectedValue = order.SupplierID;
                curInboundDetailList = GlobalCache.ServerProxy.GetPurchaseDetails(order.ID);

                foreach (var detail in curInboundDetailList)
                {
                    detail.Discount = detail.Price == 0 ? 0 : Math.Round(detail.CostPrice * 100 / detail.Price, MidpointRounding.AwayFromZero);
                    
                }
            }
            else {

                skinComboBoxShopID.SelectedValue = GlobalCache.GeneralStoreShopID;
            }
            BindingInboundDetailSource();
        }

        public static object DeepCopyObject(object obj)
        {
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter Formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter(null,
             new System.Runtime.Serialization.StreamingContext(System.Runtime.Serialization.StreamingContextStates.Clone));
            MemoryStream stream = new MemoryStream();
            Formatter.Serialize(stream, obj);
            stream.Position = 0;
            object clonedObj = Formatter.Deserialize(stream);
            stream.Close();
            return clonedObj;
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
            // List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
            //foreach (DataGridViewColumn item in dataGridView2.Columns)
            //{

            //    if (item is DataGridViewTextBoxColumn && item.Visible)
            //    {
            //        if (!dgvTmp.Columns.Contains(item))
            //        {
            //            dgvTmp.Columns.Add(item);
            //        }
            //    }
            //}

           /* List<BoundDetail> listDetail = new List<BoundDetail>();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                // object[] objList = new object[dataGridView2.Rows[i].Cells.Count];
                // for (int j = 0; j < objList.Length; j++)
                // {
                //     if (dataGridView2.Columns[j].DefaultCellStyle.Format.Contains("N"))
                //     {
                //         objList[j] = dataGridView2.Rows[i].Cells[j].Value; //使导出Excel文档金额列可做SUM运算
                //     }
                //     else
                //     {
                //         objList[j] = dataGridView2.Rows[i].Cells[j].EditedFormattedValue; //数据字典按显示文字导出
                //     }
                // }
                //dgvTmp.Rows.Add(objList);
                BoundDetail bdetail = new BoundDetail();
                bdetail.CostumeID = dataGridView2.Rows[i].Cells[0].EditedFormattedValue.ToString();
                bdetail.CostumeName= dataGridView2.Rows[i].Cells[1].EditedFormattedValue.ToString();
                bdetail.BrandName= dataGridView2.Rows[i].Cells[2].EditedFormattedValue.ToString();


                bdetail.Year =Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value );
                bdetail.Season = dataGridView2.Rows[i].Cells[4].EditedFormattedValue.ToString();
                bdetail.ColorName = dataGridView2.Rows[i].Cells[5].EditedFormattedValue.ToString();

                bdetail.Price =Convert.ToDecimal(dataGridView2.Rows[i].Cells[6].Value) ;
                bdetail.SalePrice = Convert.ToDecimal(dataGridView2.Rows[i].Cells[7].Value);
                bdetail.Discount = Convert.ToDecimal(dataGridView2.Rows[i].Cells[8].Value);

                bdetail.CostPrice = Convert.ToDecimal(dataGridView2.Rows[i].Cells[9].Value);
                bdetail.F =  short.Parse(dataGridView2.Rows[i].Cells[10].Value.ToString());
                bdetail.XS = short.Parse(dataGridView2.Rows[i].Cells[11].Value.ToString());

                bdetail.S = short.Parse(dataGridView2.Rows[i].Cells[12].Value.ToString());
                bdetail.M = short.Parse(dataGridView2.Rows[i].Cells[13].Value.ToString());
                bdetail.L = short.Parse(dataGridView2.Rows[i].Cells[14].Value.ToString());

                bdetail.XL = short.Parse(dataGridView2.Rows[i].Cells[15].Value.ToString());
                bdetail.XL2 = short.Parse(dataGridView2.Rows[i].Cells[16].Value.ToString());
                bdetail.XL3 = short.Parse(dataGridView2.Rows[i].Cells[17].Value.ToString());
                bdetail.XL4 = short.Parse(dataGridView2.Rows[i].Cells[18].Value.ToString());
                bdetail.XL5 = short.Parse(dataGridView2.Rows[i].Cells[19].Value.ToString());
                bdetail.XL6 = short.Parse(dataGridView2.Rows[i].Cells[20].Value.ToString());


                bdetail.SumCount = Convert.ToInt32(dataGridView2.Rows[i].Cells[21].Value.ToString());
                bdetail.SumCost = Convert.ToDecimal(dataGridView2.Rows[i].Cells[22].Value.ToString());
                bdetail.SumMoney = Convert.ToDecimal(dataGridView2.Rows[i].Cells[23].Value.ToString());
                bdetail.Comment =  dataGridView2.Rows[i].Cells[24].EditedFormattedValue.ToString();

                
              listDetail.Add(bdetail);
                 

            }*/


           List<BoundDetail> listtb1 = DataGridViewUtil.BindingListToList<BoundDetail>(dataGridView2.DataSource);

            List<BoundDetail> tb2 = new List<BoundDetail>();
            foreach (BoundDetail idetail in listtb1)
            {
                BoundDetail tDetail = new BoundDetail();
                ReflectionHelper.CopyProperty(idetail, tDetail);
                tb2.Add(tDetail);

            }

            dgvTmp.DataSource = tb2;
             

          //  dgvTmp.DataSource = newdt;




            //  dgvTmp.DataSource = listDetail;

            //for (int i = 0; i < dataGridView2.Rows.Count; i++)
            //{
            //    object[] objList = new object[dataGridView2.Rows[i].Cells.Count];
            //    for (int j = 0; j < objList.Length; j++)
            //    {
            //        if (dataGridView2.Columns[j].DefaultCellStyle.Format.Contains("N"))
            //        {
            //            objList[j] = dataGridView2.Rows[i].Cells[j].Value; //使导出Excel文档金额列可做SUM运算
            //        }
            //        else
            //        {
            //            objList[j] = dataGridView2.Rows[i].Cells[j].EditedFormattedValue; //数据字典按显示文字导出
            //        }
            //    }
            //    dgvTmp.Rows.Add(objList);
            //}


            return dgvTmp;
        }

        private void Save(bool isHang)
        {
            try
            {
               

                if (!CheckValidate()) { return; }
                PurchaseCostume item = this.Build();

                if (item == null || item.InboundOrder.TotalCount == 0 || item.InboundDetailList.Count == 0)
                {
                    GlobalMessageBox.Show("采购单为空,不能进货！");
                    return;
                }
                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;

                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                item.IsAutoAllocateIn = GlobalCache.GetParameter(ParameterConfigKey.AllocateInDirectly).ParaValue == "1";
                InteractResult result;
                if (isHang)
                {
                    result = GlobalCache.ServerProxy.HangUpPurchase(item);
                }
                else
                {
                    //输入金额
                    //SelectMoneyForm form = new SelectMoneyForm();
                    //if (form.ShowDialog(this.FindForm()) == DialogResult.OK)
                    //{
                    item.PurchaseOrder.PayMoney = numericTextBoxMoney.Value;//form.result;
                    //}
                    //else
                    //{
                    //    return;
                    //}
                    result = GlobalCache.ServerProxy.PurchaseCostume(item);
                }

              /*  List<BoundDetail> listtb1 = DataGridViewUtil.BindingListToList<BoundDetail>(dataGridView2.DataSource);

                List<BoundDetail> tb2 = new List<BoundDetail>();
                */

                //   dtv = (DataGridView)DeepCopyObject(dataGridView2);

                //  MemberwiseClone()

                /*   foreach (DataGridViewColumn dCol in dataGridView2.Columns)
                   {
                       DataGridViewColumn tcolumns = new DataGridViewColumn();
                       ReflectionHelper.CopyProperty(dCol, tcolumns);
                       dtv.Columns.Add(tcolumns);
                   }

                   foreach (BoundDetail idetail in listtb1)
                   {
                       BoundDetail tDetail = new BoundDetail();
                       ReflectionHelper.CopyProperty(idetail, tDetail);
                       tb2.Add(tDetail);

                   }


                   dtv.DataSource = tb2;
                   */

                // dtv = dataGridView2.MemberwiseClone();

                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        if (isHang)
                        {
                            GlobalMessageBox.Show("挂单成功！");
                        }
                        else
                        {
                            GlobalMessageBox.Show("采购成功！");
                            numericTextBoxMoney.Text = string.Empty;
                            if (skinCheckBoxPrint.Checked)
                            {
                               // this.dataGridView2.DataSource = deepCopyDataGridView().DataSource;

                                //Column2.Visible = false;
                                //Column2.Tag = PurchaseReturnOrderPrinter.PrinterNoCount;
                                BoundDetailBrandIDDataGridViewTextBoxColumn.Visible = false;
                                BoundDetailBrandIDDataGridViewTextBoxColumn.Tag = PurchaseReturnOrderPrinter.PrinterNoCount;
                                //Discount.Visible = false;
                                //Discount.Tag = PurchaseReturnOrderPrinter.PrinterNoCount;
                                //SumMoney.Visible = false;
                                //SumMoney.Tag = PurchaseReturnOrderPrinter.PrinterNoCount;

                                dtv = deepCopyDataGridView(); //深赋值
                                PurchaseReturnOrderPrinter.Print(item.PurchaseOrder, dtv, 2);
                                BoundDetailBrandIDDataGridViewTextBoxColumn.Visible = true;
                                //Discount.Visible = true;
                                //Column2.Visible = true;
                                //SumMoney.Visible = true;
                            }


                            if (skinCheckBoxPrintBarcode.Checked)
                            {
                                List<BarCode4Costume> barCode4s = new List<BarCode4Costume>();
                                foreach (BoundDetail detail in item.InboundDetailList)
                                {
                                    List<BarCode4Costume> codes = CheckDetailBarCodes(detail);
                                    barCode4s.AddRange(codes);
                                }

                                WebResponseObj<List<BarCode4CostumeInfo>> response = GlobalCache.ServerProxy.GetBarCode4CostumeInfos(barCode4s);
                                CostumeBarcodePrinter printer = new CostumeBarcodePrinter();
                                printer.Print(response?.Data, 1);
                            }

                            // PrintBarcode(item.InboundDetailList);
                        }

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
                GlobalMessageBox.Show("进货失败！");
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private List<BarCode4Costume> CheckDetailBarCodes(BoundDetail detail)
        {
            List<BarCode4Costume> barCode4Costumes = new List<BarCode4Costume>();

            foreach (var sizeName in CostumeStoreHelper.CostumeSizeColumn)
            {
                barCode4Costumes.AddRange(GetDetailBarCodesCount(detail, sizeName));
            }

            return barCode4Costumes;
        }

        private List<BarCode4Costume> GetDetailBarCodesCount(BoundDetail detail, string sizeName)
        {
            List<BarCode4Costume> barCode4Costumes = new List<BarCode4Costume>();
            //获取对应尺码的值

            short count = GetSizeCount(sizeName, detail);

            for (int i = 0; i < count; i++)
            {
                BarCode4Costume costume = new BarCode4Costume();
                ReflectionHelper.CopyProperty(detail, costume);
                costume.SizeName = sizeName;
                barCode4Costumes.Add(costume);
            }
            return barCode4Costumes;
        }

        /// <summary>
        /// 获取对应的尺码的数量值
        /// </summary>
        /// <param name="sizeName"></param>
        /// <returns></returns>
        private Int16 GetSizeCount(string sizeName, BoundDetail detail)
        {
            return Int16.Parse(ReflectUtil.GetModelValue(sizeName, detail));
        }
        private bool CheckValidate()
        {
            bool success = true;
            string msg = string.Empty;

            if (shop==null)
            {
                msg = "请选择店铺！";
                success = false;
            }
            foreach (BoundDetail detail in this.curInboundDetailList)
            {
                // SalePrice
                if (detail.CostPrice >Convert.ToDecimal(99999999.99) || detail.SalePrice > Convert.ToDecimal(99999999.99) || detail.SumMoney > Convert.ToDecimal(99999999.99))
                {
                    msg = "请检查售价、成本价或单款总金额是否大于99999999.99！";
                    success = false;
                    break;
                }
                //if (detail.SumCount <= 0)
                //{
                //    continue;
                //}
                //totalCount += detail.SumCount;
                //totalPrice += detail.SumMoney;
                //totalCost += detail.SumCost;
                //detail.BoundOrderID = id;
                //details.Add(detail);
            }



            if (!success)
            {
                GlobalMessageBox.Show(this.FindForm(), msg);
            }
            return success;
        }

        private void ResetAll(Boolean resetAction)
        {
            curSelectedCostumeStoreList = null;
            costumeFromSupplierTextBox1.SkinTxt.Text = string.Empty;
            curInboundDetailList = new List<BoundDetail>();
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
            if (resetAction) { 
            action = OperationEnum.Add;
            }
        }

        private PurchaseCostume Build()
        {
            if (
                this.curInboundDetailList == null || this.curInboundDetailList.Count == 0)
            {
                return null;
            }
            int totalCount = 0;
            decimal totalPrice = 0;
            decimal totalCost = 0;
            List<BoundDetail> details = new List<BoundDetail>();

            //使用补货申请单的店铺ID信息

            // Shop shop = GlobalCache.ShopList.Find(t => t.ID == this.curReplenishOrder.ShopID);
          
            string id = IDHelper.GetID(OrderPrefix.InboundOrder, shop.AutoCode);
            string pOrderID = IDHelper.GetID(OrderPrefix.PurchaseOrder, shop.AutoCode);
            if (action== OperationEnum.Pick)
            {
                pOrderID = this.order?.ID;
            }

            foreach (BoundDetail detail in this.curInboundDetailList)
            {
                if (detail.SumCount <= 0)
                {
                    continue;
                }
                totalCount += detail.SumCount;
                totalPrice += detail.SumMoney;
                totalCost += detail.SumCost;
                detail.BoundOrderID = id;
                details.Add(detail);
            }

            InboundOrder order = new InboundOrder()
            {
                SourceOrderID = pOrderID,
                ID = id,
                OperatorUserID = GlobalCache.CurrentUserID, 
                ShopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue),
                CreateTime = DateTime.Now,
                TotalCount = totalCount,
                TotalPrice = totalPrice,
                TotalCost = totalCost,
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text
            };


            PurchaseOrder pOrder = new PurchaseOrder()
            {
                SupplierID = ValidateUtil.CheckEmptyValue(skinComboBox_SupplierID.SelectedValue), 
                ID = pOrderID,
                AdminUserID = GlobalCache.CurrentUserID,
                InboundOrderID = order.ID,
                DestShopID = order.ShopID,
                CreateTime = dateTimePicker_Start.Value,
                TotalCount = totalCount,
                TotalPrice = totalPrice,
                TotalCost = totalCost, 
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text
            };

            return new PurchaseCostume()
            {
                PurchaseOrder = pOrder,
                InboundOrder = order,
                InboundDetailList = details 
            };
        }
        private void costumeFromSupplierTextBox1_CostumeSelected(Costume costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                if (costumeItem == null)
                {
                    this.costumeFromSupplierTextBox1.SkinTxt.Text = "";
                    this.curSelectedCostumeStoreList = null;
                }
                else
                {
                    this.curSelectedCostumeStoreList = CostumeFromSupplierTextBox.GetCostumeStores(costumeItem);
                }

                this.BindingSelectedCostumeStoreSource();
               
            }
        }

        /// <summary>
        /// 绑定要补货的集合源
        /// </summary>
        private void BindingInboundDetailSource()
        {
            foreach (var item in curInboundDetailList)
            {
               item.SupplierName = CommonGlobalCache.GetSupplierName(item.SupplierID);
                Costume costume = CommonGlobalCache.GetCostume(item.CostumeID);
                if (costume != null)
                {
                    item.BrandName = CommonGlobalCache.GetBrandName(costume.BrandID);
                    item.CostumeName = costume.Name;
                    item.Year = costume.Year;
                    item.Season = costume.Season;
                   // item.SupplierName = costume.SupplierName;
                    //item.Comment = item.Remarks;
                }
            }

            dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(DataGridViewUtil.ListToBindingList(this.curInboundDetailList));
            dataGridViewPagingSumCtrl2.ScrollToEnd();
        }

        /// <summary>
        /// 绑定选定款号对应的CostumeStore集合
        /// </summary>
        private void BindingSelectedCostumeStoreSource()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.BindingSelectedCostumeStoreSource));
            }
            else
            {
                this.dataGridViewPagingSumCtrl.SetDataSource<CostumeStore>(DataGridViewUtil.ListToBindingList(curSelectedCostumeStoreList));
                // cell获取焦点
                dataGridViewPagingSumCtrl.AutoFocusToWritableCell();
            }
        }
        private  DataGridView dtv = new DataGridView();

        private void BaseButton_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.curSelectedCostumeStoreList == null || this.curSelectedCostumeStoreList.Count == 0)
                {
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                List<CostumeStore> costumeStoreList = this.curSelectedCostumeStoreList;

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
                    BoundDetail detail = this.CostumeStoreConvertToInboundDetail(store);
                    detail.SupplierName = GlobalCache.GetSupplierName(detail.SupplierID);
                    detail.Discount = detail.Price == 0 ? 0 : Math.Round(detail.CostPrice * 100 / detail.Price, MidpointRounding.AwayFromZero);

                  /*  Costume costume = CommonGlobalCache.GetCostume(detail.CostumeID);
                    if (costume != null)
                    {
                        detail.BrandName = CommonGlobalCache.GetBrandName(costume.BrandID);
                        detail.CostumeName = costume.Name;
                        detail.Year = costume.Year;
                        detail.Season = costume.Season;
                    }
                    */ 
                    this.InboundDetailListAddItem(detail);
                }
                //清空dataGirdView1的绑定源 
                this.dataGridView1.DataSource = null;
                this.costumeFromSupplierTextBox1.Text = string.Empty;
                this.curSelectedCostumeStoreList = null;
                // this.BindingInboundDetailSource(); 
                dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(DataGridViewUtil.ListToBindingList(this.curInboundDetailList));

                


             /*   List<BoundDetail> listtb1 = DataGridViewUtil.BindingListToList<BoundDetail>(dataGridView2.DataSource);

                List<BoundDetail> tb2 = new List<BoundDetail>(); 
                foreach (BoundDetail idetail in listtb1)
                {
                    BoundDetail tDetail = new BoundDetail();
                    ReflectionHelper.CopyProperty(idetail, tDetail);
                    tb2.Add(tDetail);

                }  
                dtv.DataSource = tb2;
                */

                //  ReflectionHelper.CopyProperty(dataGridView2, dtv);

                dataGridViewPagingSumCtrl2.ScrollToEnd();

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
        private BoundDetail CostumeStoreConvertToInboundDetail(CostumeStore store)
        {
            if (store == null)
            {
                return null;
            }
            BoundDetail detail = new BoundDetail();
            ReflectionHelper.CopyProperty(store, detail);
            detail.SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBox_SupplierID.SelectedValue);
            detail.Comment = store.Remarks;
            return detail;
        }

        private void InboundDetailListAddItem(BoundDetail detail)
        {
            bool existed = false;
            DialogResult result = DialogResult.No;
            BoundDetail repeatItem = null;
            foreach (BoundDetail item in this.curInboundDetailList)
            {
                if (item.CostumeID.ToUpper() == detail.CostumeID.ToUpper() && item.ColorName == detail.ColorName)
                {
                    repeatItem = item;
                    existed = true;
                    result = GlobalMessageBox.Show(string.Format("款号：{0}  颜色：{1} 的服装已经存在待补货列表中，是否覆盖", item.CostumeID, item.ColorName), "", MessageBoxButtons.YesNo);

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
            CheckValidate(sender, e, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn44);
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            CheckValidate(sender,e, priceDataGridViewTextBoxColumn, xL6DataGridViewTextBoxColumn);
        }

        private void CheckValidate(object sender, DataGridViewCellValidatingEventArgs e,DataGridViewColumn fromColumn, DataGridViewColumn toColumn) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            try
            {
                if (CommonGlobalUtil.NotStoreColumnIndex(e.ColumnIndex, fromColumn.Index, toColumn.Index)
                 )
                {
                    return;
                }
                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Decimal.Parse(e.FormattedValue.ToString());
                }
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > e.RowIndex && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
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
                    GlobalMessageBox.Show("进货不能小于0！");
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
          
        Shop shop =null;
        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            shop = (Shop)this.skinComboBoxShopID.SelectedItem;
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCell cell = dataGridView.CurrentCell;
            if (cell != null)
            {
                if (cell.OwningColumn.DataPropertyName == Discount.DataPropertyName)
                { //折扣
                    BoundDetail detail = (BoundDetail)cell.OwningRow.DataBoundItem;
                    detail.CostPrice = Math.Round(detail.Price * detail.Discount / 100, MidpointRounding.AwayFromZero);
                }
                else if (cell.OwningColumn.DataPropertyName == CostPrice.DataPropertyName)
                {

                    BoundDetail detail = (BoundDetail)cell.OwningRow.DataBoundItem;
                    detail.Discount = Math.Round(detail.Price == 0 ? 0 : detail.CostPrice * 100 / detail.Price, MidpointRounding.AwayFromZero);
                }
            }
            dataGridView.Refresh();
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
            //AddCostumeClick?.Invoke(null, this);
            SaveCostumeForm form = new SaveCostumeForm();
            form.Costume_Newed += SaveCostumeForm_Costume_Newed;
            form.ShowDialog(this);
        }

        private void SaveCostumeForm_Costume_Newed(Costume costume)
        {
            //添加到列表中
            //skinComboBox_SupplierID.SelectedValue = costume.SupplierID;
            costumeFromSupplierTextBox1.Text = costume.ID;
            costumeFromSupplierTextBox1.Search(); 
        }

         

        private void baseButtonImport_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetFileToOpen("请选择导入文件");
            if (String.IsNullOrEmpty(path))
            { 
                return;
            }

            string fileExt = Path.GetExtension(path);
            if (fileExt != ".xlsx" && fileExt != ".xls")
            {
                ShowMessage("你所选择文件格式不正确，请重新上传文件！");
                return;
            }
            if (GlobalMessageBox.Show("是否开始导入" + System.IO.Path.GetFileName(path), "友情提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                path = null;
                return;
            }

            if (NPOIHelper.IsFileInUse(path))
            {
                ShowMessage("你所选择文件已被打开，请关闭后再重新导入！");
                return;
            }
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; } 
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoImport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }

        }
         
         

        private String path;
        private void DoImport()
        {
            try
            { 
                List<CostumeStore> emptyStore = new List<CostumeStore>(); 
                List<CostumeStore> stores = new List<CostumeStore>();
                List<CostumeStore> repeatItems = new List<CostumeStore>();
                DataTable dt = NPOIHelper.FormatToDatatable(path, 0);
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                  
                    DataRow row = dt.Rows[i];
                    int index = 0;
                    CostumeStore store = new CostumeStore();
                    try
                    {
                        if (!ImportValidate(row))
                        {
                            //款号	商品名称	色号	颜色名称	吊牌价	成本价	品牌	供应商名称	年份	季节	大类	小类	款型	风格	XS	S	M	L	XL	2XL	3XL	4XL	5XL	6XL	F

                            store.AutoID = i + 2;
                            ((CheckBaseDataPara)store).CostumeID = CommonGlobalUtil.ConvertToString(row[index]);
                            store.CostumeID = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.CostumeName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.CostumeColorID = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.CostumeColorName = CommonGlobalUtil.ConvertToString(row[index]);
                            store.ColorName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Price = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.CostPrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                           // store.SalePrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.BrandName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SupplierName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Year = CommonGlobalUtil.ConvertToInt32(row[index++]);
                            store.Season = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.ClassCode = CommonGlobalUtil.ConvertToString(row[index++]);
                            //  store.BigClass = CommonGlobalUtil.ConvertToString(row[index++]);
                            //   store.SmallClass = CommonGlobalUtil.ConvertToString(row[index++]);
                            //   store.Style = CommonGlobalUtil.ConvertToString(row[index++]);
                            //   store.Models = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.XS = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.S = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.M = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.L = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL2 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL3 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL4 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL5 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL6 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.F = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.SizeGroupShowName = SystemDefault.DefaultSizeGroup;
                            if (String.IsNullOrEmpty(store.CostumeID) || String.IsNullOrEmpty(store.CostumeName) || String.IsNullOrEmpty(store.CostumeColorName))
                            {
                                //必填项为空
                                emptyStore.Add(store);
                                continue;
                            }
                            else
                            {

                                //判断是否重复款号/颜色
                                if (stores.Find(t => t.CostumeID == store.CostumeID && t.CostumeColorName == store.CostumeColorName) != null)
                                {
                                    repeatItems.Add(store);
                                    continue;
                                }
                                 
                                stores.Add(store);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                if (emptyStore.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in emptyStore)
                    {
                        str += "第" + item.AutoID + "行\r\n";
                    }
                    ShowError("必填项没有填写，请补充完整！\r\n" + str);
                    return;
                }
                if (repeatItems.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in repeatItems)
                    {
                        str += "第" + item.AutoID + "行" + "\r\n";
                    }
                    ShowError("重复的款号与颜色，系统已过滤，详见错误报告！\r\n" + str);
                    //  return;
                }
                if (stores != null && stores.Count > 0)
                {
                }
                else
                {
                    ShowMessage("没有数据可以导入，请检查列表信息！");
                    return;
                }
                path = null;
                List<CheckBaseDataPara> paras = CJBasic.Collections.CollectionConverter.ConvertAll<CostumeStore, CheckBaseDataPara>(stores, delegate (CostumeStore c) { return c; });
                //檢查結果
                InteractResult result = GlobalCache.ServerProxy.CheckBaseData(paras);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        foreach (var item in stores)
                        {
                            Costume costume = CommonGlobalCache.GetCostume(item.CostumeID);
                            if (costume != null)
                            {
                                //重新给商品名称  
                                item.CostumeName = costume.Name;
                            }
                        }
                        AddItems4Display(stores);
                        ShowMessage("导入成功！");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void AddItems4Display(List<CostumeStore> stores)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<List<CostumeStore>>(this.AddItems4Display), stores);
            }
            else
            {
                this.curSelectedCostumeStoreList = stores;
                this.BindingSelectedCostumeStoreSource();
            }
        }

        private bool ImportValidate(DataRow row)
        {    //
            bool unValidate = true;
            for (int i = 0; i < 26; i++)
            {
                String value = CommonGlobalUtil.ConvertToString(row[i]);
                if (!String.IsNullOrEmpty(value))
                {
                    //有值
                    unValidate = false;
                    break;
                }
            }
            return unValidate;
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
                //case Keys.Add:
                //    BaseButton2.PerformClick();
                //    break;
                default:
                    break;
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
                PurchaseOrderPickForm tiDanForm = new PurchaseOrderPickForm(true);
               tiDanForm.HangedOrderSelected += TiDanForm_HangedOrderSelected;//提单被选择后触发
                tiDanForm.ShowDialog();
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }
         
        private void TiDanForm_HangedOrderSelected(PurchaseOrder hangedOrder)
        {
            action = OperationEnum.Pick;
            LoadOrder(hangedOrder); 
        }

        private void baseButtonHang_Click(object sender, EventArgs e)
        {
            Save(true);
        }

        //点击出库按钮
        private void BaseButton_Inbound_Click(object sender, EventArgs e)
        {
            Save(false);
        }

        private void baseButtonDownTemplate_Click(object sender, EventArgs e)
        {

        }

        private void skinCheckBoxPrint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "采购进货" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoExport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
        }
        private void DoExport()
        {
            try
            {
                if (dataGridView1.DataSource != null && dataGridView1.Rows.Count > 0)
                {
                    List<CostumeStore> list = DataGridViewUtil.BindingListToList<CostumeStore>(dataGridView1.DataSource);
                    System.Collections.SortedList columns = new System.Collections.SortedList();
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {
                         
                                keys.Add(item.DataPropertyName);
                                values.Add(item.HeaderText);
                           
                        }
                    }
                    NPOIHelper.Keys = keys.ToArray();
                    NPOIHelper.Values = values.ToArray();
                    NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);

                    GlobalMessageBox.Show("导出完毕！");
                }
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }
    }
}
