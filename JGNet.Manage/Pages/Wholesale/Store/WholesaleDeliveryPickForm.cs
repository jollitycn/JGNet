using CCWin;
using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
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
    public partial class WholesaleDeliveryPickForm : Common.BaseForm
    { 
        List<PfOrder> orders;
        public event System.Action<PfOrder> HangedOrderSelected;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;
        public WholesaleDeliveryPickForm(bool isPurchase)
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.批发发货;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.ShowRowCounts = false;
            dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(this.dataGridView2);
            dataGridViewPagingSumCtrl1.Initialize();
            dataGridViewPagingSumCtrl1.ShowRowCounts = false;

            if (isPurchase)
            {
                this.Text = "批发发货单提单";
            } else {
                this.Text = "批发退货单提单";
            }
            GetHangUpPfsPara para = new GetHangUpPfsPara()
            {
                IsDelivery = isPurchase
            };
            orders = GlobalCache.ServerProxy.GetHangUpPfs(para);
            if (orders != null)
            {
                foreach (var item in orders)
                {
                    item.PfCustomerName = PfCustomerCache.GetPfCustomerName(item.PfCustomerID);
                    item.AdminUserName = CommonGlobalCache.GetUserName(item.AdminUserID);
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
                GlobalUtil.WriteLog(ee);
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
                    List<PfOrder> orders = dataGridView1.DataSource as List<PfOrder>;
                    if (e.ColumnIndex== Column2.Index)
                    {
                        DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
                        if (dialogResult != DialogResult.OK)
                        {
                            return;
                        }
                        PfOrder order = dataGridView1.Rows[e.RowIndex].DataBoundItem as PfOrder;
                        InteractResult result = GlobalCache.ServerProxy.DeleteHangUpPf(order?.ID);

                        switch (result.ExeResult)
                        {
                            case ExeResult.Success:
                                GlobalMessageBox.Show("删除成功！");
                                DeleteSelectedHangedOrder( order);
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


        private void DeleteSelectedHangedOrder(PfOrder order)
        { 
            orders.Remove(order);
            dataGridViewPagingSumCtrl.BindingDataSource(orders);
        }

        PfOrder curOrder;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        { 
            try
            { 
                PfOrder order = (PfOrder)this.dataGridView1.CurrentRow.DataBoundItem;
                if (order != null && order != curOrder)
                {
                    List<PfOrderDetail> curInboundDetailList = CommonGlobalCache.ServerProxy.GetPfOrderDetails(order.ID);
                    if (curInboundDetailList != null) {
                        foreach (var item in curInboundDetailList)
                        {
                            Costume costume = CommonGlobalCache.GetCostume(item.CostumeID);
                            item.BrandName = CommonGlobalCache.GetBrandName(costume.BrandID);
                            item.CostumeName = costume.Name;
                        }
                    }
                    dataGridViewPagingSumCtrl1.BindingDataSource(curInboundDetailList); 
                    curOrder = order; 
                }
            }
            catch (Exception ex)
            {
              //  CommonGlobalUtil.ShowError(ex);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            try
            {
                DataGridView view = sender as DataGridView;
                PfOrder order = view.CurrentRow.DataBoundItem as PfOrder;
                curOrder = order;
                BaseButton_Select_Click(null, null);
            }
            catch (Exception ex)
            {
             //   CommonGlobalUtil.ShowError(ex);
            }

        }
    }
}
