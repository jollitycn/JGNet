using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CJBasic;
using JGNet.Core.InteractEntity;
using CCWin;
using CJBasic.Loggers;
using JGNet.Common;
using CJBasic.Helpers;
using JGNet.Common.Components;
using JGNet.Core;
using JGNet.Common.Core;

namespace JGNet.Manage
{
    public partial class MemberRefundOrderSearchCtrl : Common.Core.BaseUserControl
    {
        private RefundListPagePara pagePara;
        private List<RetailOrder> refundOrderList;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public int pageCount { get; private set; }

        public MemberRefundOrderSearchCtrl()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView_RefundOrder, PageControlPanel21_CurrentPageIndexChanged,BaseButton_Search_Click);
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 remarksDataGridViewTextBoxColumn });
            dataGridViewPagingSumCtrl.Initialize();
            //ataGridViewPagingSumCtrl.SpecAutoSizeMode(new TKeyValue<DataGridViewColumn, DataGridViewAutoSizeColumnMode>(remarksDataGridViewTextBoxColumn, DataGridViewAutoSizeColumnMode.ColumnHeader));


        }

        private void PageControlPanel21_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                if (this.pagePara == null)
                {
                    return;
                }
                this.pagePara.PageIndex = index;
                RefundListPage listPage = GlobalCache.ServerProxy.GetRefundListPage(this.pagePara);
                this.BindingRefundOrderDataSource(listPage);
                this.BindingRefundDetailDataSource(null);
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                string memberID = string.IsNullOrEmpty(this.skinTextBox_MemberID.SkinTxt.Text) ? null : this.skinTextBox_MemberID.SkinTxt.Text;
                string orderID = string.IsNullOrEmpty(this.skinTextBox_OrderID.SkinTxt.Text) ? null : this.skinTextBox_OrderID.SkinTxt.Text;
                string costumeID = string.IsNullOrEmpty(this.CostumeCurrentShopTextBox1.SkinTxt.Text) ? null : this.CostumeCurrentShopTextBox1.SkinTxt.Text;

                Date startDate = null;
                Date endDate = null;
                if (this.skinCheckBox1.CheckState == CheckState.Checked)
                {
                    startDate = new Date(this.dateTimePicker_Start.Value);
                    endDate = new Date(this.dateTimePicker_End.Value);
                }
                this.pagePara = new Core.InteractEntity.RefundListPagePara()
                {
                    CostumeID = costumeID,
                    RefundOrderID = orderID,
                    MemberID = memberID,
                    StartDate = startDate,
                    EndDate = endDate,
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    ShopID = GlobalCache.CurrentShopID
                };
                RefundListPage listPage = GlobalCache.ServerProxy.GetRefundListPage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingRefundOrderDataSource(listPage);
                #region 清空dataGridView_RetailDetail的绑定源 
                this.BindingRefundDetailDataSource(null);
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

        /// <summary>
        /// 绑定RefundOrder数据源
        /// </summary>
        private void BindingRefundOrderDataSource(RefundListPage listPage)
        { 
            if (listPage != null)
            {
                this.refundOrderList = listPage.ResultList;
                if (this.refundOrderList != null && this.refundOrderList.Count > 0)
                {
                    foreach (RetailOrder refundOrder in this.refundOrderList)
                    {
                        refundOrder.GuideName = GlobalCache.GetUserName(refundOrder.GuideID);
                        refundOrder.ShopName = GlobalCache.GetShopName(refundOrder.ShopID);
                    }
                }
            }
            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.ResultList, null,listPage?.TotalEntityCount, listPage?.RetailOrderSum);

            this.dataGridView_RefundOrder.Refresh();
            this.dataGridView_RefundDetail.Visible = false;
        }


        /// <summary>
        /// 绑定RefundDetail数据源
        /// </summary>
        private void BindingRefundDetailDataSource(RetailOrder refundOrder)
        {
            if (refundOrder == null)
            {
                this.dataGridView_RefundDetail.DataSource = null;
            }
            else
            {
                List<RetailDetail> refundDetailList = GlobalCache.ServerProxy.GetRetailDetailList(refundOrder.ID);
                this.dataGridView_RefundDetail.DataSource = null;
                if (refundDetailList != null && refundDetailList.Count > 0)
                {
                    foreach (RetailDetail detail in refundDetailList)
                    {
                        detail.CostumeName = GlobalCache.GetCostumeName(detail.CostumeID);
                        detail.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(detail.CostumeID, detail.SizeName);
                    }

                    this.dataGridView_RefundDetail.DataSource = refundDetailList;
                }
            }

            this.dataGridView_RefundDetail.Refresh();
            this.dataGridView_RefundDetail.Visible = true;
         }

        private void dataGridView_RetailOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                RetailOrder refundOrder = this.refundOrderList[e.RowIndex];
                this.BindingRefundDetailDataSource(refundOrder);
            }
        }

        /// <summary>
        /// 根据退货单号查询
        /// </summary>
        /// <param name="refundOrderID">退货单号</param>
        public void RefundOrderIDSearch(string refundOrderID)
        {
            this.skinTextBox_OrderID.Text = refundOrderID;
            this.BaseButton_Search_Click(null, null);
            if (this.refundOrderList == null || this.refundOrderList.Count == 0)
            {
                return;
            }
            RetailOrder refundOrder = this.refundOrderList[0];
            this.BindingRefundDetailDataSource(refundOrder);

        }

        private void MemberRefundOrderSearchCtrl_Load(object sender, EventArgs e)
        {

            this.Initialize();
        }

        private void CostumeCurrentShopTextBox1_CostumeSelected(CostumeItem obj)
        {
            if (obj != null)
            {
                BaseButton_Search_Click(null, null);
            }
        }
    }
}
