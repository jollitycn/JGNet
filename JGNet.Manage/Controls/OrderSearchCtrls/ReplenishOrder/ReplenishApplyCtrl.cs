using System;
using System.Collections.Generic;
using System.Drawing;
using JGNet.Core.InteractEntity;
using System.Windows.Forms;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.DBEntity;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Manage;
using JGNet.Common.Core;
using CJBasic.Helpers;

namespace JGNet.Manage
{
    public partial class ReplenishApplyCtrl : Common.Core.BaseModifyUserControl
    {
        private List<CostumeStore> curSelectedCostumeStoreList;//当前被选中的CostumeStore集合
        private List<ReplenishDetail> curReplenishDetailList = new List<ReplenishDetail>();//当前要补货的CostumeStore
        private ReplenishOrder order;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;
        private OperationEnum action;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        public ReplenishApplyCtrl(ReplenishOrder order = null, OperationEnum action = OperationEnum.Add)
        {
            InitializeComponent();

            skinComboBoxShopID.Initialize(true, true);
            this.order = order;
            if (order != null && action == OperationEnum.Pick)
            {
                skinComboBoxShopID.SelectedValue = order.ShopID;
            }
            else
            {
                skinComboBoxShopID.SelectedValue = GlobalCache.CurrentShopID;
            }
            if (order == null)
            {
                IsShowOnePage = true;
            }
            this.action = action;
            Init();
            MenuPermission = RolePermissionMenuEnum.店铺补货申请;
        }

        private void Init()
        {
            imageHelp1.Control = this;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(dataGridView2, new string[] {
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
                sumMoneyDataGridViewTextBoxColumn.DataPropertyName,
                sumCountDataGridViewTextBoxColumn1.DataPropertyName
            });
            dataGridViewPagingSumCtrl2.Initialize();
         
            DataGridViewUtil.SetAlternatingColor(dataGridView1, Color.Gainsboro, Color.White);
            this.CostumeCurrentShopTextBox1.CostumeSelected += CostumeCurrentShopTextBox1_CostumeSelected;
            this.guideComboBox1.Initialize(GuideComboBoxInitializeType.Null,shopID);
            if (CommonGlobalCache.CurrentUser.Type == UserInfoType.Guide)
            {
              //  this.guideComboBox1.SelectedValue = GlobalCache.CurrentUserID;
            }
        }

        //选择了款号时触发
        private void CostumeCurrentShopTextBox1_CostumeSelected(CostumeItem costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                this.SetCostumeDetails(costumeItem);
            }
        }

        /// <summary>
        /// 设置界面上服装的明细
        /// </summary>
        /// <param name="costumeItem"></param>
        private void SetCostumeDetails(CostumeItem costumeItem)
        {
            if (costumeItem == null)
            {
                this.CostumeCurrentShopTextBox1.SkinTxt.Text = "";
                this.curSelectedCostumeStoreList = null;
                this.BindingSelectedCostumeStoreSource();
            }
            else
            {
                this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
                this.curSelectedCostumeStoreList = costumeItem.CostumeStoreList;
                this.BindingSelectedCostumeStoreSource();
            }
            this.skinTextBox_Remarks.SkinTxt.Text = "";

        }

        //添加补货明细到补货列表中
        private void BaseButton_Add_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.curSelectedCostumeStoreList == null || this.curSelectedCostumeStoreList.Count == 0)
                {
                    return;
                }
                List<CostumeStore> costumeStoreList = this.curSelectedCostumeStoreList.FindAll((x) => x.Title == "补货数量");
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

                    ReplenishDetail detail = this.CostumeStoreConvertToReplenishDetail(store, "");
                    detail.Comment = store.Remarks;
                    detail.BrandName =CommonGlobalCache.GetBrandName(CommonGlobalCache.GetCostume(detail.CostumeID).BrandID);
                    this.CurReplenishDetailListAddItem(detail);
                }
                //清空dataGirdView1的绑定源

                this.SetCostumeDetails(null);
                this.BindingReplenishDetailSource();
                CostumeCurrentShopTextBox1.Focus();
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        /// <summary>
        /// 添加ReplenishDetail到当前要绑定的 待补货的 集合源中。（过滤掉源集合中已存在同款同颜色的服装）
        /// </summary>
        /// <param name="detail"></param>
        private void CurReplenishDetailListAddItem(ReplenishDetail detail)
        {
            foreach (ReplenishDetail item in this.curReplenishDetailList)
            {
                if (item.CostumeID.ToUpper() == detail.CostumeID.ToUpper() && item.ColorName == detail.ColorName)
                {
                    GlobalMessageBox.Show(string.Format("款号：{0}  颜色：{1} 的服装已经存在待补货列表中，重复添加", item.CostumeID, item.ColorName));
                    return;
                }
            }
            this.curReplenishDetailList.Add(detail);
        }

        //提交补货申请
        private void Save(bool isHang)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (string.IsNullOrEmpty(this.shopID))
                {
                    GlobalMessageBox.Show("请选择店铺！");
                    return;
                }
              /*  if (this.guideComboBox1.SelectedIndex == 0)
                {
                    GlobalMessageBox.Show("操作人不能为空！");
                    return;
                }
                */
                ReplenishCostume item = this.BuildReplenishCostume();
                if (item == null)
                {
                    GlobalMessageBox.Show("补货明细不能为空！");
                    return;
                }
                if (item.ReplenishOrder.TotalCount <= 0)
                {
                    GlobalMessageBox.Show("补货数量应大于0");
                    return;
                }
                DialogResult dialogResult = GlobalMessageBox.Show("您确定该申请操作？", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult != DialogResult.OK)
                {
                    return;
                }
                InteractResult result;

                if (isHang)
                {
                    result = GlobalCache.ServerProxy.HangUpReplenish(item);
                }
                else
                {
                    result = GlobalCache.ServerProxy.ReplenishCostume(item);
                }

                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        if (isHang)
                        {
                            GlobalMessageBox.Show("挂单成功！");
                        }
                        else
                        {
                            GlobalMessageBox.Show("补货申请成功！");
                            if (skinCheckBoxPrint.Checked)
                            {
                                DataGridView dgv = deepCopyDataGridView();
                                ReplenishOrderPrinter.Print(item.ReplenishOrder, dgv, 2);
                            }
                        }


                        ResetAll(true);
                        if (!IsShowOnePage)
                        {
                            TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
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



            List<ReplenishDetail> listtb1 = DataGridViewUtil.BindingListToList<ReplenishDetail>(dataGridView2.DataSource);

            List<ReplenishDetail> tb2 = new List<ReplenishDetail>();
            foreach (ReplenishDetail idetail in listtb1)
            {
                ReplenishDetail tDetail = new ReplenishDetail();
                ReflectionHelper.CopyProperty(idetail, tDetail);
                tb2.Add(tDetail);

            }

            dgvTmp.DataSource = tb2;



            return dgvTmp;
        }
        private void ResetAll(Boolean resetAction)
        {
            this.SetCostumeDetails(null);
            this.curReplenishDetailList.Clear();
            this.BindingReplenishDetailSource();
            if (resetAction)
            {
                action = OperationEnum.Add;
            }
        }

        //自动添加补货申请单到补货列表中
        private void BaseButton_AutoReplenish_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                this.SetCostumeDetails(null);
                AutoReplenishCostumePara para = new AutoReplenishCostumePara()
                {
                    ShopID = shopID,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value)
                };
                List<ReplenishDetail> autoReplenishDetailList = GlobalCache.ServerProxy.AutoReplenishCostume(para);
                if (autoReplenishDetailList != null && autoReplenishDetailList.Count > 0)
                { 
                    this.curReplenishDetailList = autoReplenishDetailList;
                    this.BindingReplenishDetailSource();
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

        #region 绑定源
        /// <summary>
        /// 绑定选定款号对应的CostumeStore集合
        /// </summary>
        private void BindingSelectedCostumeStoreSource()
        {
            if (this.curSelectedCostumeStoreList == null)
            {
                this.dataGridView1.DataSource = null;
            }
            else
            {

                dataGridViewPagingSumCtrl.DisableStyle();
                this.dataGridView1.DataSource = null;
                if (this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > 0)
                {
                    List<CostumeStore> tempList = new List<CostumeStore>();
                    foreach (CostumeStore store in this.curSelectedCostumeStoreList)
                    {
                        store.Title = "库存";
                        store.CostumeName = GlobalCache.GetCostumeName(store.CostumeID);
                        CostumeStore tempStore = this.BuildCostumeStore4NeedReplenish(store);
                        //CJBasic.Helpers.ReflectionHelper.CopyProperty(store, obj);
                        tempList.Add(store);
                        tempList.Add(tempStore);
                    }
                    this.curSelectedCostumeStoreList = tempList;

                    ////重新排序，同款同颜色排一起，且将补货数量拍在库存后面
                    //this.curSelectedCostumeStoreList.Sort((x, y) =>
                    //{
                    //    int sort = x.ColorName.CompareTo(y.ColorName);
                    //    if (sort == 0)
                    //    {
                    //        sort = -x.Title.CompareTo(y.Title);
                    //    }
                    //    return sort;
                    //});
                    this.dataGridView1.DataSource = this.curSelectedCostumeStoreList;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Index % 2 == 0)
                        {
                            row.ReadOnly = true;
                            row.HeaderCell.Value = "库存";

                        }
                        else
                        {
                            row.ReadOnly = false;
                            row.HeaderCell.Value = "补货申请";
                        }
                    }

                    dataGridViewPagingSumCtrl.EnableStyle();
                }
            }
            this.dataGridView1.Refresh();
            dataGridViewPagingSumCtrl.AutoFocusToWritableCell();
        }



        /// <summary>
        /// 绑定要补货的集合源
        /// </summary>
        private void BindingReplenishDetailSource()
        {
            if (this.curReplenishDetailList != null && this.curReplenishDetailList.Count > 0)
            {
                foreach (ReplenishDetail detail in this.curReplenishDetailList)
                {
                    detail.CostumeName = GlobalCache.GetCostumeName(detail.CostumeID);
                }
            }
            dataGridViewPagingSumCtrl2.BindingDataSource<ReplenishDetail>(DataGridViewUtil.ListToBindingList(this.curReplenishDetailList));
           // dataGridViewPagingSumCtrl3.BindingDataSource<ReplenishDetail>(DataGridViewUtil.ListToBindingList(this.curReplenishDetailList));
        }

        #endregion

        #region 对象生成与转换
        /// <summary>
        /// 根据现在库存对象生成需补货的库存对象
        /// </summary>
        /// <param name="oldCostumeStore"></param>
        /// <returns></returns>
        private CostumeStore BuildCostumeStore4NeedReplenish(CostumeStore oldCostumeStore)
        {
            if (oldCostumeStore == null)
            {
                return null;
            }
            return new CostumeStore()
            {
                CostumeID = oldCostumeStore.CostumeID,
                CostumeName = oldCostumeStore.CostumeName,
                ColorName = oldCostumeStore.ColorName,
                AllowReviseDiscount = oldCostumeStore.AllowReviseDiscount,
                ShopID = oldCostumeStore.ShopID,
                Price = oldCostumeStore.Price,
                Title = "补货数量",
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
                XL6 = 0
            };
        }

        /// <summary>
        /// 生成ReplenishCostume对象  
        /// </summary>
        /// <returns></returns>
        private ReplenishCostume BuildReplenishCostume()
        {
            if (this.curReplenishDetailList == null || this.curReplenishDetailList.Count == 0)
            {
                return null;
            }

            string id = IDHelper.GetID(OrderPrefix.ReplenishOrder, GlobalCache.GetShop(shopID).AutoCode);

            if (action == OperationEnum.Pick) {
                id = this.order?.ID;
            }
            int totalCount = 0;
            decimal totalMoney = 0;
            List<ReplenishDetail> list = new List<ReplenishDetail>();
            for (int i = 0; i < this.curReplenishDetailList.Count; i++)
            {
                if (this.curReplenishDetailList[i].SumCount == 0)
                {
                    continue;
                }
                list.Add(this.curReplenishDetailList[i]);
                totalCount += this.curReplenishDetailList[i].SumCount;
                totalMoney += this.curReplenishDetailList[i].SumMoney;
                this.curReplenishDetailList[i].ReplenishOrderID = id;
            }

            ReplenishOrder replenishOrder = new ReplenishOrder()
            {
                ID = id,
                RequestGuideID = GlobalCache.CurrentUserID,// (string)this.guideComboBox1.SelectedValue,
                ShopID = shopID,
                Remarks = this.skinTextBox_Remarks.SkinTxt.Text,
                State = (byte)ReplenishOrderState.NotProcessing,
                TotalCount = totalCount,
                TotalPrice = totalMoney,
                CreateTime = DateTime.Now,
                FinishedTime = SystemDefault.DateTimeNull,

            };

            return new ReplenishCostume()
            {
                ReplenishOrder = replenishOrder,
                ReplenishDetailList = list
            };

        }


        /// <summary>
        /// 将CostumeStore转化为ReplenishDetail  
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        private ReplenishDetail CostumeStoreConvertToReplenishDetail(CostumeStore store, string replenishOrderID)
        {
            if (store == null)
            {
                return null;
            }
            return new ReplenishDetail()
            {
                ReplenishOrderID = replenishOrderID,
                CostumeID = store.CostumeID,
                CostumeName = GlobalCache.GetCostumeName(store.CostumeID),
                ColorName = store.ColorName,
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


            };
        }

        #endregion

        #region 验证单元格中的值
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


                if (CommonGlobalUtil.NotStoreColumnIndex(e.ColumnIndex, fDataGridViewTextBoxColumn.Index, xL6DataGridViewTextBoxColumn.Index)
                 )
                {
                    return;
                }
                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = decimal.Parse(e.FormattedValue.ToString());
                }
                if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > e.RowIndex && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
                {
                    decimal oldCount = 0;
                    if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                    {
                        oldCount = decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
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
                    GlobalMessageBox.Show("补货数不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }
            }
            catch(Exception ex )
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
                if (e.ColumnIndex == fDataGridViewTextBoxColumn1.Index || e.ColumnIndex == xSDataGridViewTextBoxColumn1.Index 
                    || e.ColumnIndex == sDataGridViewTextBoxColumn1.Index || e.ColumnIndex == mDataGridViewTextBoxColumn1.Index
                    || e.ColumnIndex == lDataGridViewTextBoxColumn1.Index || e.ColumnIndex == xLDataGridViewTextBoxColumn1.Index
                    || e.ColumnIndex == xL2DataGridViewTextBoxColumn1.Index || e.ColumnIndex == xL3DataGridViewTextBoxColumn1.Index
                    || e.ColumnIndex == xL4DataGridViewTextBoxColumn1.Index || e.ColumnIndex == xL5DataGridViewTextBoxColumn1.Index
                    || e.ColumnIndex == xL6DataGridViewTextBoxColumn1.Index  
                    )
                {


                    decimal newCount = 0;
                    if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        newCount = decimal.Parse(e.FormattedValue.ToString());
                    }
                    if (isCostumeStoreList && this.curSelectedCostumeStoreList != null && this.curSelectedCostumeStoreList.Count > e.RowIndex && this.curSelectedCostumeStoreList[e.RowIndex].Title == "库存")
                    {
                        decimal oldCount = 0;
                        if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString()))
                        {
                            oldCount = decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
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
                        GlobalMessageBox.Show("补货数不能小于0！");
                        dataGridView.CancelEdit();
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                switch (this.dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    case "删除":
                        DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
                        if (dialogResult != DialogResult.OK)
                        {
                            return;
                        }
                        this.curReplenishDetailList.RemoveAt(e.RowIndex);
                        this.BindingReplenishDetailSource();
                        break;
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }


        #endregion


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.ReadOnly = true;
            }
        }

        private void ReplenishApplyCtrl_Load(object sender, EventArgs e)
        {
            LoadOrder(order);
        }

        private void LoadOrder(ReplenishOrder order)
        {
            if (order != null)
            {
                //重做
                try
                {
                    curReplenishDetailList = GlobalCache.ServerProxy.GetReplenishDetail(order.ID);
                   // this.guideComboBox1.SelectedValue = order.RequestGuideID;
                    BindingReplenishDetailSource();
                }
                catch (Exception ex)
                {
                    GlobalUtil.ShowError(ex);
                }
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
         
        private void baseButton4_Click(object sender, EventArgs e)
        {
            if (GlobalMessageBox.Show("确定清空下表数据吗？", "友情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView2.DataSource = null;
                curReplenishDetailList?.Clear();
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
                ReplenishPickForm tiDanForm = new ReplenishPickForm(shopID);
                tiDanForm.HangedOrderSelected += TiDanForm_HangedOrderSelected;//提单被选择后触发
                tiDanForm.ShowDialog();
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
         
        private void TiDanForm_HangedOrderSelected(ReplenishOrder hangedOrder)
        {
            action = OperationEnum.Pick;
            this.order = hangedOrder;
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

        string shopID;
        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            shopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue);
            CostumeCurrentShopTextBox1.ShopID = shopID;
            guideComboBox1.Initialize( GuideComboBoxInitializeType.Null,shopID);
        }
    }
}
