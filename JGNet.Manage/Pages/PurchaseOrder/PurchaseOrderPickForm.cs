using CCWin;
using JGNet.Common;
using JGNet.Common.Components;
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
    public partial class PurchaseOrderPickForm : Common.BaseForm
    {
        List<PurchaseOrder> orders;
        public event System.Action<PurchaseOrder> HangedOrderSelected;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public PurchaseOrderPickForm(bool isPurchase)
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.ShowRowCounts = false;
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(this.dataGridView2);
            dataGridViewPagingSumCtrl1.ShowRowCounts = false;
            dataGridViewPagingSumCtrl1.Initialize();
            GetHangUpPurchasesPara para = new GetHangUpPurchasesPara()
            {
                IsPurchase = isPurchase
            };

            if (isPurchase)
            {
                this.Text = "采购进货单提单";
            }
            else
            {
                this.Text = "采购退货单提单";
            }

            orders = GlobalCache.ServerProxy.GetHangUpPurchases(para);
            if (orders != null)
            {
                foreach (var item in orders)
                {
                    item.SupplierName = CommonGlobalCache.GetSupplierName(item.SupplierID);
                    item.UserName = CommonGlobalCache.GetUserName(item.AdminUserID);
                    item.ShopName = CommonGlobalCache.GetShopName(item.DestShopID);
                }
            }

            dataGridViewPagingSumCtrl.BindingDataSource(orders);
        }


        //点击选择按钮
        private void BaseButton_Select_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(curOrder.SupplierID) && !String.IsNullOrEmpty(curOrder.SupplierAccountID))
                {
                    SelectSupplierForm form = new SelectSupplierForm();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Supplier supplier = form.Result;
                        if (supplier != null)
                        {
                            curOrder.SupplierID = supplier.ID;
                            InteractResult result = GlobalCache.ServerProxy.PurchaseBindingSupplierID(curOrder.ID, curOrder.SupplierID);
                            switch (result.ExeResult)
                            {
                                case ExeResult.Success:
                                    this.HangedOrderSelected?.Invoke(curOrder);
                                    this.DialogResult = DialogResult.OK;
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
                else
                {
                    this.HangedOrderSelected?.Invoke(curOrder);
                    this.DialogResult = DialogResult.OK;
                }
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
                    List<PurchaseOrder> orders = dataGridView1.DataSource as List<PurchaseOrder>;
                    if (e.ColumnIndex == Column1.Index)
                    {
                        DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
                        if (dialogResult != DialogResult.OK)
                        {
                            return;
                        }
                        PurchaseOrder order = dataGridView1.Rows[e.RowIndex].DataBoundItem as PurchaseOrder;
                        InteractResult result = GlobalCache.ServerProxy.DeleteHangUpPurchase(order?.ID);

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


        private void DeleteSelectedHangedOrder(PurchaseOrder order)
        {
            orders.Remove(order);
            dataGridViewPagingSumCtrl.BindingDataSource(orders);
        }

        PurchaseOrder curOrder;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrder order = (PurchaseOrder)this.dataGridView1.CurrentRow.DataBoundItem;
                if (order != null && order != curOrder)
                {
                    List<BoundDetail> curInboundDetailList = GlobalCache.ServerProxy.GetPurchaseDetails(order.ID);
                    if (curInboundDetailList != null)
                    {
                        foreach (BoundDetail item in curInboundDetailList)
                        {
                            Costume costume = CommonGlobalCache.GetCostume(item.CostumeID);
                            item.SupplierName = CommonGlobalCache.GetSupplierName(item.SupplierID) ?? item.SupplierID;
                            if (costume != null)
                            {                                
                                item.BrandName = CommonGlobalCache.GetBrandName(costume.BrandID);
                                item.CostumeName = costume.Name;
                            }                           
                        }
                    }
                    // dataGridView2.DataSource = null;
                    // dataGridView2.DataSource = curInboundDetailList;
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
                PurchaseOrder order = view.CurrentRow.DataBoundItem as PurchaseOrder;
                curOrder = order;
                BaseButton_Select_Click(null, null);
            }
            catch (Exception ex)
            {
               // CommonGlobalUtil.ShowError(ex);
            }
        }
    }
}
