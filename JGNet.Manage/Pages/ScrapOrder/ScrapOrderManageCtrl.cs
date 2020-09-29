using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
using CCWin;

using JGNet.Common.Core.Util;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;

namespace JGNet.Manage
{
    public partial class ScrapOrderManageCtrl : BaseUserControl
    {
        
        private ScrapPagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl; 
        /// <summary>
        /// 点击补货申请单明细触发
        /// </summary>
        public event CJBasic.Action<ScrapOrder,Panel,bool> DetailClick;

        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }
        public ScrapOrderManageCtrl()
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.报损单查询;

            this.dataGridView1.AutoGenerateColumns = false; 
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged,BaseButton_Search_Click, new string[] {
                totalCountDataGridViewTextBoxColumn.DataPropertyName,
                totalPriceDataGridViewTextBoxColumn.DataPropertyName });
            //dataGridViewPagingSumCtrl.SpecAutoSizeMode(new TKeyValue<DataGridViewColumn, DataGridViewAutoSizeColumnMode>(Column6, DataGridViewAutoSizeColumnMode.ColumnHeader));
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 Column6 });
            dataGridViewPagingSumCtrl.Initialize();
     
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;


        }
        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }
        private void Initialize()
        {
            skinSplitContainer1.Panel2Collapsed = true;
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            GlobalUtil.SetShop(this.skinComboBoxShopID);
            skinTextBox_OrderID.Text = string.Empty;
            skinTextBox_costumeID.Text = string.Empty;
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
                ScrapPage listPage = GlobalCache.ServerProxy.GetScrapPage(this.pagePara);
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
                string orderID = string.IsNullOrEmpty(this.skinTextBox_OrderID.SkinTxt.Text) ? null : this.skinTextBox_OrderID.SkinTxt.Text;
                    this.pagePara = new ScrapPagePara()
                    {
                        ScrapOrderID = orderID,  
                        StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                        EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                        PageIndex = 0,
                        PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                        ShopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue),
                        CostumeID = ValidateUtil.CheckEmptyValue(skinTextBox_costumeID.SkinTxt.Text)

                    };
                ScrapPage listPage = GlobalCache.ServerProxy.GetScrapPage(this.pagePara);
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
        private void BindingScrapOrderSource(ScrapPage listPage)
        { 
            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.ScrapOrderList, null, listPage?.TotalEntityCount, listPage?.ScrapOrderSum);
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        #region 点击单元格
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                List <ScrapOrder> curScrapOrderListSource = (List<ScrapOrder>)this.dataGridView1.DataSource;
                ScrapOrder item = curScrapOrderListSource[e.RowIndex];

                if (ColumnOrder.Index == e.ColumnIndex)
                {
                    this.skinSplitContainer1.Panel2Collapsed = false;
                    this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2,false);
                }
                else if(ColumnPrint.Index == e.ColumnIndex) {
                    this.skinSplitContainer1.Panel2Collapsed = false;
                    this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2,true);
                }
                else if (ColumnCancel.Index == e.ColumnIndex)
                {
                    this.Cancel(item);
                }
                else if (ColumnRedo.Index == e.ColumnIndex)
                {
                    this.Redo(item);
                }

            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
        }
        private void Cancel(ScrapOrder allocateOrder)
        {
            try
            {
                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = null;
                    result = GlobalCache.ServerProxy.CancelScrap(allocateOrder.ID, CommonGlobalCache.CurrentUserID);
                switch (result?.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("冲单成功！");
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
                this.RefreshPage();
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
            finally
            {
                UnLockPage();
            }
        }
        public event CJBasic.Action<ScrapOrder, BaseUserControl> RedoClick;

        private void Redo(ScrapOrder allocateOrder)
        {
            if (this.RedoClick != null)
            {
                this.RedoClick(allocateOrder, this);
            }
        }


        #endregion

        private void ScrapOrderManageCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < -1 || e.ColumnIndex <  - 1) { return; }
            if (e.Value == null) {
                return;
            }

            DataGridView view = sender as DataGridView;
            ScrapOrder order = view.Rows[e.RowIndex].DataBoundItem as ScrapOrder;
            if (e.ColumnIndex == ShopNameColumn.Index)
            {
                e.Value = GlobalCache.GetShopName(e.Value.ToString());
            }
            else if (e.ColumnIndex == AdminUserColumn.Index)
            {
                e.Value = GlobalCache.GetUserName(e.Value.ToString());
            }
            else if (e.ColumnIndex == ColumnCancel.Index)
            {
                if (order.IsCancel)
                {
                    e.Value = null;
                }
            }
            else if (e.ColumnIndex == ColumnRedo.Index)
            {
                if (!order.IsCancel)
                {
                    e.Value = null;
                }
            } 
        }

        private void skinTextBox_costumeID_CostumeSelected(Costume costume, bool isEnter)
        {
            if (costume != null && isEnter)
            {
                BaseButton_Search_Click(null, null);
            }
        }
    }
}
