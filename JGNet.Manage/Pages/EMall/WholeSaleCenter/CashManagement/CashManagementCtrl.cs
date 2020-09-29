using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms; 
using JGNet.Core.InteractEntity;
using CCWin;

using JGNet.Common.Core.Util;
using JGNet.Common.Core;
using JGNet.Common;
using JGNet.Common.Components;
using CJBasic;
using JGNet.Core.Tools;
using JGNet.Common.cache.Wholesale;

namespace JGNet.Manage
{
    public partial class CashManagementCtrl : BaseUserControl
    {

        private GetDistributorWithdrawRecordPagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        /// <summary>
        /// 点击收货按钮触发
        /// </summary>
        // public event CJBasic.Action<ScrapOrder> InboundClick;
        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }
        public CashManagementCtrl()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click, new string[] {
                ColumnAmount.DataPropertyName });
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;
            SetState();
            skinComboBoxShopID.SkinTxt.TextChanged += SkinTxt_TextChanged;
            MenuPermission = RolePermissionMenuEnum.提现管理;
        }

        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
            BaseButton_Search_Click(null, null);
        }

        private void SetState()
        {
            #region 初始化skinComboBox_State
            List<ListItem<DistributorWithdrawRecordState>> listItems = new List<ListItem<DistributorWithdrawRecordState>>();
            listItems.Add(new ListItem<DistributorWithdrawRecordState>(CommonGlobalUtil.COMBOBOX_ALL, DistributorWithdrawRecordState.All));
            listItems.Add(new ListItem<DistributorWithdrawRecordState>(EnumHelper.GetDescription(DistributorWithdrawRecordState.WaitPay), DistributorWithdrawRecordState.WaitPay));
            listItems.Add(new ListItem<DistributorWithdrawRecordState>(EnumHelper.GetDescription(DistributorWithdrawRecordState.Paid), DistributorWithdrawRecordState.Paid));
            listItems.Add(new ListItem<DistributorWithdrawRecordState>(EnumHelper.GetDescription(DistributorWithdrawRecordState.Cancel), DistributorWithdrawRecordState.Cancel));

            this.skinComboBoxState.DisplayMember = "Key";
            this.skinComboBoxState.ValueMember = "Value";
            this.skinComboBoxState.DataSource = listItems;
            #endregion
        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }
        private void Initialize()
        {
            skinSplitContainer1.Panel2Collapsed = true;
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            this.BindingScrapOrderSource(null);
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
                DistributorWithdrawRecordPage listPage = GlobalCache.ServerProxy.GetDistributorWithdrawRecordPage(this.pagePara);
                this.BindingScrapOrderSource(listPage);
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

                pagePara = new GetDistributorWithdrawRecordPagePara()
                {
                    DistributorID = skinComboBoxShopID.Text,
                    StartDate = new Date(dateTimePicker_Start.Value),
                    EndDate = new Date(dateTimePicker_End.Value),
                    PageIndex = 0,
                    PageSize = dataGridViewPagingSumCtrl.PageSize,
                    State = (DistributorWithdrawRecordState)skinComboBoxState.SelectedValue
                };

                DistributorWithdrawRecordPage listPage = GlobalCache.ServerProxy.GetDistributorWithdrawRecordPage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingScrapOrderSource(listPage);

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
        /// 绑定plenishOrderSource源到dataGridView中
        /// </summary>
        /// <param name="listPage"></param>
        private void BindingScrapOrderSource(DistributorWithdrawRecordPage listPage)
        {
            if (listPage != null && listPage.DistributorWithdrawRecords != null)
            {
                foreach (var item in listPage.DistributorWithdrawRecords)
                {
                    item.DistributorName = PfCustomerCache.GetUserNameWithPf(item.DistributorID);
                }
            }

            //   this.dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ToDataTable(listPage?.DistributorWithdrawRecords), null, listPage?.TotalEntityCount, listPage?.DistributorWithdrawRecordSum);
             this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.DistributorWithdrawRecords, null, listPage?.TotalEntityCount, listPage?.DistributorWithdrawRecordSum);
            //dataGridViewPagingSumCtrl.BindingDataSource<DistributorWithdrawRecord>(DataGridViewUtil.ToDataTable(listPage?.DistributorWithdrawRecords));
            this.skinSplitContainer1.Panel2Collapsed = true;
        }


        private void ScrapOrderManageCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                List<DistributorWithdrawRecord> curScrapOrderListSource = (List<DistributorWithdrawRecord>)this.dataGridView1.DataSource;

                DistributorWithdrawRecord item = curScrapOrderListSource[e.RowIndex];

                if (ColumnPay.Index == e.ColumnIndex)
                {
                    PaymentCashForm payform = new PaymentCashForm(item);
                     
                    if (payform.ShowDialog(this) == DialogResult.OK)
                    {
                        Payment(item);
                    }
                        //  payform.ConfirmClick += Payment(item);

                        // Payment(item);
                        //this.skinSplitContainer1.Panel2Collapsed = false;
                        //this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2, false);
                    }
                else if (ColumnCancel.Index == e.ColumnIndex)
                {
                    Cancel(item);
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }

        }

        private void Cancel(DistributorWithdrawRecord item)
        {
            try
            {

                if (GlobalMessageBox.Show("确定取消提现申请吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = GlobalCache.ServerProxy.CancelDistributorWithdrawRecord(item.AutoID);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("取消成功！");
                        RefreshPage();
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
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

        private void Payment(DistributorWithdrawRecord item)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = GlobalCache.ServerProxy.PayDistributorWithdrawRecord(item.AutoID);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("付款成功！");
                        RefreshPage();
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DistributorWithdrawRecord item = dataGridView1.Rows[e.RowIndex].DataBoundItem as DistributorWithdrawRecord;
            if (item.State != 0)
            {
                if (ColumnPay.Index == e.ColumnIndex)
                {
                    e.Value = string.Empty;
                }
                else if (ColumnCancel.Index == e.ColumnIndex)
                {
                    e.Value = string.Empty;
                }
            }
        }
    }
}
