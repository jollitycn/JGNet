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
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core.MyEnum; 

namespace JGNet.Manage

{
    public partial class WholesaleEmOrderDeliveryCtrl : BaseModifyUserControl
    {
        private GetEmCostumePagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
         

        private PfCustomerOrder Order { get; set; }

        public WholesaleEmOrderDeliveryCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new string[] {
            DeliveryCount.DataPropertyName,
            SumDeliveryMoney.DataPropertyName
            });
            dataGridViewPagingSumCtrl.Initialize();
            
        }
        bool reportShowZero = false;

        public override void RefreshPage()
        {
            if (pagePara != null)
            {

            }
        }

        public void Search(PfCustomerOrder order)
        {
            this.Order = order;
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }


                PfCustomerDetails listPage = GlobalCache.EMallServerProxy.GetPfCustomerDetails(this.Order.ID);
                this.BindingDataSource(listPage.NotDeliverys);
                this.skinLabelOrderId.Text = this.Order.ID;
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

        private void BindingDataSource(List<PfCustomerDetail> listPage)
        {
            foreach (var item in listPage)
            {
                item.CostumeName = CommonGlobalCache.GetCostumeName(item.CostumeID);
                item.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(item.CostumeID, item.SizeName);
                item.OrgCount = item.Count;
            }
            this.dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerDetail>
                (listPage);
        }


        private void RefreshPageInvoke()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(RefreshPageInvoke));
            }
            else
            {
                this.RefreshPageAction?.Invoke(CurrentTabPage, SourceCtrlType);
            }
        }

        private void BaseButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<PfCustomerDetail> details = (List<PfCustomerDetail>)this.dataGridView1.DataSource;
                InteractResult result = GlobalCache.EMallServerProxy.PfCustomerOrderDelivery(this.Order.ID, GlobalCache.CurrentUserID, details.FindAll(t => t.IsSelected));
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(this.FindForm(), result.Msg);
                        break;
                    case ExeResult.Success:
                        GlobalMessageBox.Show("发货成功！");
                        TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
                        break;
                    default:
                        break;
                }
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

        private void skinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<PfCustomerDetail> details = this.dataGridView1.DataSource as List<PfCustomerDetail>;
            if (this.skinCheckBox1.Checked)
            {
                foreach (PfCustomerDetail detail in details)
                {
                    detail.IsSelected = true;
                }
            }
            else
            {
                foreach (PfCustomerDetail detail in details)
                {
                    detail.IsSelected = false;
                }
            }
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            this.dataGridView1.Refresh();

        }

        //private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.IsCurrentCellDirty)
        //    {
        //        dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //    }
        //}


        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                if (e.ColumnIndex == DeliveryCount.Index)
                {
                    PfCustomerDetail detail = dataGridView1.Rows[e.RowIndex].DataBoundItem as PfCustomerDetail;
                    int newCount = 0;
                    int orgCount = detail.OrgCount;
                    if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        newCount = Convert.ToInt32(e.FormattedValue);
                    }
                    if (newCount <= 0)
                    {
                        GlobalMessageBox.Show("不能少于0！");
                        this.dataGridView1.CancelEdit();
                        return;
                    }
                    if (newCount > orgCount)
                    {
                        GlobalMessageBox.Show("不能超过该款的下单数" + orgCount + "！");
                        this.dataGridView1.CancelEdit();
                        return;
                    }
                }
            }
            catch
            {
                GlobalMessageBox.Show("输入格式错误！");
                this.dataGridView1.CancelEdit();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
             
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }
    }
}

