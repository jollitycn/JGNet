using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CJBasic.Widget;
using CJBasic;
using CJBasic.Loggers;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
 
using CCWin.SkinControl;
using JGNet.Core.Tools;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Common.Core.Util;

namespace JGNet.Manage

{
    public partial class EmRefundOrderManageCtrl : BaseUserControl
    {
        private GetEmOrderPagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
         

        public CJBasic.Action<EmRefundOrder, BaseUserControl, Panel> DetailClick;
        public CJBasic.Action<EmRefundOrder, Panel> LogisticsClick; 

        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }

        public EmRefundOrderManageCtrl()
        {
            InitializeComponent();
            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click);
            dataGridViewPagingSumCtrl.Initialize();
            SetOrderState();
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            SetRefundStateEnum();
        }

        private void SetOrderState()
        {
            List<ListItem<EmRetailOrderState>> list = new List<ListItem<EmRetailOrderState>>();
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.All), EmRetailOrderState.All));
            //list.Add(new ListItem<EmRefundOrderState>(EmRefundOrder.GetOrderState(EmRefundOrderState.Closed), OrderState.Closed));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.Finish), EmRetailOrderState.Finish));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.WaitDelivery), EmRetailOrderState.WaitDelivery));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.WaitEvaluation), EmRetailOrderState.WaitEvaluation));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.WaitPay), EmRetailOrderState.WaitPay));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.WaitSign), EmRetailOrderState.WaitSign));
            list.Add(new ListItem<EmRetailOrderState>(EmRetailOrder.GetOrderState(EmRetailOrderState.Closed), EmRetailOrderState.Closed));
            skinComboBoxOrderState.DisplayMember = "Key";
            skinComboBoxOrderState.ValueMember = "Value";
            skinComboBoxOrderState.DataSource = list;
        }

        private void SetRefundStateEnum()
        {
            List<ListItem<RefundStatus>> list = new List<ListItem<RefundStatus>>();
            list.Add(new ListItem<RefundStatus>(EnumHelper.GetDescription(RefundStatus.NotSelect), RefundStatus.NotSelect));
           // list.Add(new ListItem<RefundStateEnum>(EmRetailOrder.GetRefundState(RefundStateEnum.None), RefundStateEnum.None));
            list.Add(new ListItem<RefundStatus>(EnumHelper.GetDescription(RefundStatus.RefundingRefundSuccess), RefundStatus.RefundingRefundSuccess));
            list.Add(new ListItem<RefundStatus>(EnumHelper.GetDescription(RefundStatus.Refunding), RefundStatus.Refunding));
            list.Add(new ListItem<RefundStatus>(EnumHelper.GetDescription(RefundStatus.RefundSuccess), RefundStatus.RefundSuccess));
            skinComboBoxRefundState.DisplayMember = "Key";
            skinComboBoxRefundState.ValueMember = "Value";
            skinComboBoxRefundState.DataSource = list;
        }

        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (this.pagePara == null)
                {
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                pagePara.PageIndex = index;
                EmRefundOrderPage listPage = GlobalCache.EMallServerProxy.GetEmRefundOrderPage(this.pagePara);
                this.BindingDataSource(listPage);

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

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                pagePara = new GetEmOrderPagePara()
                {
                    OrderID = this.skinTextBoxOrderId.Text,
                    StartDate = new Date(this.dateTimePicker_Start.Value),
                    EndDate = new Date(this.dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    MemberPhoneOrName = this.textBoxPhoneOrName.Text,
                    CostumeIDOrName = this.skinTextBoxID.Text,
                    OrderState =(EmRetailOrderState)( this.skinComboBoxOrderState.SelectedValue),
                    RefundStatus = (RefundStatus)(this.skinComboBoxRefundState.SelectedValue),
                };


                
                EmRefundOrderPage listPage = GlobalCache.EMallServerProxy.GetEmRefundOrderPage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingDataSource(listPage);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }


        private void BindingDataSource(EmRefundOrderPage listPage)
        {
            if (listPage != null && listPage.ResultList != null && listPage.ResultList.Count > 0)
            {
              //  this.dataGridView1.DataSource = listPage?.ResultList;
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
             //   dataGridView1.DataSource = null;
                //清空下面的详情内容
            }
            dataGridViewPagingSumCtrl.BindingDataSource(listPage?.ResultList, null, listPage?.TotalEntityCount);
        }


        private void EmRefundOrderManageCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.Panel2Collapsed = true;
                dataGridView1.DataSource = null;
                pagePara = new GetEmOrderPagePara();
            }
            catch (Exception ex)
            {

                GlobalUtil.ShowError(ex);
            }
        }

        public event CJBasic.Action<EmRefundOrder, BaseUserControl> OpenModifyDialog;

         
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {

                if (e.RowIndex > -1 && e.ColumnIndex > -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    List<EmRefundOrder> list = (List<EmRefundOrder>)view.DataSource;
                    EmRefundOrder item = (EmRefundOrder)list[e.RowIndex];
                  //  splitContainer1.Panel2Collapsed = true;
                    switch (view.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.HeaderText)
                    {
                        case "查看物流":
                            splitContainer1.Panel2Collapsed = false;
                            this.LogisticsClick?.Invoke(item, this.splitContainer1.Panel2);
                            break;
                        case "退货状态":
                            splitContainer1.Panel2Collapsed = false;
                            this.DetailClick?.Invoke(item, this, this.splitContainer1.Panel2);
                            break;
                        default: break;

                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        } 
    }


}
