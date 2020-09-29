using CCWin;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Manage;
using JGNet.Manage;
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
    public partial class ReplenishPickForm : Common.BaseForm
    { 
        List<ReplenishOrder> orders;
        public event System.Action<ReplenishOrder> HangedOrderSelected;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;
        public ReplenishPickForm(string shopID)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.ShowRowCounts = false;
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(this.dataGridView2);
            dataGridViewPagingSumCtrl1.ShowRowCounts = false;
            dataGridViewPagingSumCtrl1.Initialize();

            if (!string.IsNullOrEmpty(shopID))
            {
                orders = GlobalCache.ServerProxy.GetHangUpReplenishOrders(shopID, null);
                if (orders != null)
                {
                    foreach (var item in orders)
                    {
                        item.ShopName = CommonGlobalCache.GetShopName(item.ShopID);
                        item.GuideName = CommonGlobalCache.GetUserName(item.RequestGuideID);
                    }
                }

            }
            dataGridViewPagingSumCtrl.BindingDataSource(orders);
        }


        //点击选择按钮
        private void BaseButton_Select_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.HangedOrderSelected != null)
                {
                    this.HangedOrderSelected(curOrder);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ee)
            {
             //   GlobalUtil.WriteLog(ee);
                GlobalMessageBox.Show("选择失败！");
            }
        }

        //点击取消按钮
        private void BaseButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void dataGridView_HangedOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    List<ReplenishOrder> orders = dataGridView1.DataSource as List<ReplenishOrder>;
                    if (e.ColumnIndex == Column2.Index)
                    {
                        DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
                        if (dialogResult != DialogResult.OK)
                        {
                            return;
                        }
                        ReplenishOrder order = dataGridView1.Rows[e.RowIndex].DataBoundItem as ReplenishOrder;
                        InteractResult result = GlobalCache.ServerProxy.DeleteHangUpReplenishOrder(order?.ID);

                        switch (result.ExeResult)
                        {
                            case ExeResult.Success:
                                GlobalMessageBox.Show("删除成功！");
                                DeleteSelectedHangedOrder(order);
                                break;
                            case ExeResult.Error:
                                GlobalMessageBox.Show(result.Msg);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ee)
            {
               GlobalUtil.ShowError(ee);
            }
        }


        private void DeleteSelectedHangedOrder(ReplenishOrder order)
        { 
            orders.Remove(order);
            flag = true;
            dataGridViewPagingSumCtrl.BindingDataSource(orders);
        }

        ReplenishOrder curOrder;
        bool flag = false;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    if (this.dataGridView1.CurrentRow.DataBoundItem != null && this.dataGridView1.Rows.Count > 0)
                    {
                        ReplenishOrder order = (ReplenishOrder)this.dataGridView1.CurrentRow.DataBoundItem;
                        if (order != null && order != curOrder)
                        {
                            List<ReplenishDetail> curInboundDetailList = GlobalCache.ServerProxy.GetReplenishDetail(order.ID);
                            if (curInboundDetailList != null && curInboundDetailList.Count > 0)
                            {
                                foreach (var item in curInboundDetailList)
                                {
                                    Costume costume = CommonGlobalCache.GetCostume(item.CostumeID);
                                    item.CostumeName = costume.Name;
                                }
                            }
                            dataGridViewPagingSumCtrl1.BindingDataSource(curInboundDetailList);
                            curOrder = order;
                        }
                    }
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception ex)
            {
               // CommonGlobalUtil.ShowError(ex);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            try
            {
                DataGridView view = sender as DataGridView;
                ReplenishOrder order = view.CurrentRow.DataBoundItem as ReplenishOrder;
                curOrder = order;
                BaseButton_Select_Click(null, null);
            }
            catch (Exception ex)
            {
              //  CommonGlobalUtil.ShowError(ex);
            }

        }
    }
}
