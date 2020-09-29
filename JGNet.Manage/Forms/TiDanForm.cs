using CCWin;
using JGNet.Common;
using JGNet.Common.Core.Util;
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
    public partial class TiDanForm : Common.BaseForm
    {
        private HangedOrderBag orderAggregate;
        private  HangedOrder selectedHangedOrder;
        public event System.Action<HangedOrder> HangedOrderSelected;

        public TiDanForm(HangedOrderBag hangedOrderAggregate)
        {
            InitializeComponent();
            this.orderAggregate = hangedOrderAggregate;
            this.InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            if (this.orderAggregate.HangedOrderList != null && this.orderAggregate.HangedOrderList.Count > 0)
            {
                //按挂单的时间倒序排序
                this.orderAggregate.HangedOrderList.Sort((x, y) => y.CreateTime.CompareTo(x.CreateTime));


                //foreach (var item in this.orderAggregate.HangedOrderList)
                //{
                //   // item.SizeDisplayName  = item.size
                //}
                this.dataGridView_HangedOrder.DataSource = this.orderAggregate?.HangedOrderList;
            }
            else
            {
                //若没有挂单，则明细也为null
                this.dataGridView_Detail.DataSource = null;
            }
            this.dataGridView_HangedOrder.Refresh();
            this.dataGridView_Detail.DataSource = null;
            this.dataGridView_Detail.Refresh();
          //  this.dataGridView_HangedOrder_CellClick(null, new DataGridViewCellEventArgs(0, 0));//默认选择第一个挂单
        }



        //点击选择按钮
        private void BaseButton_Select_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.HangedOrderSelected != null)
                {
                    //如果未选择一行，默认为第一行被选中
                    if (this.selectedHangedOrder==null&& this.orderAggregate.HangedOrderList!=null&& this.orderAggregate.HangedOrderList.Count>0)
                    {
                        this.selectedHangedOrder = this.orderAggregate.HangedOrderList[0];
                    } 
                    this.HangedOrderSelected(this.selectedHangedOrder);
                }
                this.DeleteSelectedHangedOrder();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ee)
            {
                ShowError(ee);
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
                    if (e.ColumnIndex == Column1.Index)
                    {
                        DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
                        if (dialogResult != DialogResult.OK)
                        {
                            return;
                        }
                        this.selectedHangedOrder = this.orderAggregate.HangedOrderList[e.RowIndex];
                        this.DeleteSelectedHangedOrder();
                        GlobalMessageBox.Show("删除成功！");
                    }
                    else
                    {
                        if (this.orderAggregate == null || this.orderAggregate.HangedOrderList == null || this.orderAggregate.HangedOrderList.Count == 0)
                        {
                            return;
                        }
                        this.selectedHangedOrder = this.orderAggregate.HangedOrderList[e.RowIndex];
                        if (this.selectedHangedOrder.DetailList != null && this.selectedHangedOrder.DetailList.Count > 0)
                        {
                            foreach (var item in this.selectedHangedOrder.DetailList)
                            {
                                item.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(item.CostumeID, item.SizeName);
                            }

                            this.dataGridView_Detail.DataSource = this.selectedHangedOrder?.DetailList;
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private void DeleteSelectedHangedOrder()
        {
            //if (this.orderAggregate.HangedOrderList.Count == 1)
            //{
                this.dataGridView_HangedOrder.DataSource = null;
           // }
            this.orderAggregate.HangedOrderList.Remove(this.selectedHangedOrder);
            this.orderAggregate.Save(GlobalUtil.HangedOrderBagPath);
            this.selectedHangedOrder = null;
            this.InitializeDataGridView();
        }
    }
}
