using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;
using JGNet.Core.InteractEntity;
using CCWin;
using JGNet.Common.Core;  
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Core;
using JGNet.Core.Const;
using CCWin.SkinControl;
using System.Reflection;
using JGNet.Manage;
using JGNet.Core.Tools;

namespace JGNet.Common
{
    public partial class WholesaleCustomerBalanceDetailCtrl : BaseModifyUserControl
    {
        private string shopID;
        private GetPfCustomerBalanceRecordPagePara pagePara;
        public CJBasic.Action<PfCustomerBalanceRecord, BaseUserControl, Panel> DetailClick;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<CostumeStoreTrack,Type> CostumeStoreTrackDetailClick;
        public WholesaleCustomerBalanceDetailCtrl()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click, new String[] {
            ChangeCount.DataPropertyName});
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.ColumnSorting += dataGridViewPagingSumCtrl_ColumnSorting;

        }
        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        /// <summary>
        /// 款号颜色相关切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {

        }

        //private void SetCostumeColor()
        //{
        //    List<String> list = new List<String>(); 
        //    list.Add(  CommonGlobalUtil.COMBOBOX_ALL);
        //    foreach (var item in CommonGlobalCache.CostumeColorList)
        //    {
        //        list.Add(item.Name);

        //    }  
        //    this.skinComboBox_Color.DataSource = list;
        //}

        private void Initialize()
        {
            this.pagePara = new GetPfCustomerBalanceRecordPagePara();
            this.dataGridView1.DataSource = null;
            this.dateTimePicker_Start.Value = DateTime.Now.AddMonths(-1);
            this.dateTimePicker_End.Value = DateTime.Now;

            this.skinSplitContainer1.Panel2Collapsed = true;
            this.textBoxCustomer.Initialize(false, false);
            SetChangeType();

        }
        private void SetChangeType()
        {
            List<ListItem<PfCustomerBalanceType>> shopList = new List<ListItem<PfCustomerBalanceType>>(); 
            shopList.Add(new ListItem<PfCustomerBalanceType>(EnumHelper.GetDescription( PfCustomerBalanceType.All), PfCustomerBalanceType.All));
            shopList.Add(new ListItem<PfCustomerBalanceType>(EnumHelper.GetDescription(PfCustomerBalanceType.Recharge), PfCustomerBalanceType.Recharge));
            shopList.Add(new ListItem<PfCustomerBalanceType>(EnumHelper.GetDescription(PfCustomerBalanceType.PayPfCustomerOrder), PfCustomerBalanceType.PayPfCustomerOrder));
            shopList.Add(new ListItem<PfCustomerBalanceType>(EnumHelper.GetDescription(PfCustomerBalanceType.PayPfOrderDelivery), PfCustomerBalanceType.PayPfOrderDelivery));
            shopList.Add(new ListItem<PfCustomerBalanceType>(EnumHelper.GetDescription(PfCustomerBalanceType.PayPfOrderReturn), PfCustomerBalanceType.PayPfOrderReturn));
            shopList.Add(new ListItem<PfCustomerBalanceType>(EnumHelper.GetDescription(PfCustomerBalanceType.AccountCollection), PfCustomerBalanceType.AccountCollection));
          //  shopList.Add(new ListItem<PfCustomerBalanceType>(EnumHelper.GetDescription(PfCustomerBalanceType.AccountRefund), PfCustomerBalanceType.AccountRefund));
            this.skinComboBoxChangeType.DisplayMember = "Key";
            this.skinComboBoxChangeType.ValueMember = "Value";
            this.skinComboBoxChangeType.DataSource = shopList;
        }




        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (this.pagePara == null)
                {
                    return;
                }
                this.pagePara.PageIndex = index;
                PfCustomerBalanceRecordPage listPage = GlobalCache.ServerProxy.GetPfCustomerBalanceRecordPage(this.pagePara);
                this.BindingSource(listPage);

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

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                this.pagePara = new GetPfCustomerBalanceRecordPagePara()
                {
                    PfCustomerBalanceType = (PfCustomerBalanceType)this.skinComboBoxChangeType.SelectedValue,
                     
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                      
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                   PfCustomerID= pfCustomer?.ID
                };
                PfCustomerBalanceRecordPage listPage =GlobalCache.ServerProxy.GetPfCustomerBalanceRecordPage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingSource(listPage);

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

        private void BindingSource(PfCustomerBalanceRecordPage listPage)
        {
            dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerBalanceRecord>(listPage?.PfCustomerBalanceRecords,null,listPage?.TotalEntityCount, listPage?.PfCustomerBalanceRecordSum);
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
                List<PfCustomerBalanceRecord> list = (List<PfCustomerBalanceRecord>)this.dataGridView1.DataSource;
                PfCustomerBalanceRecord item = (PfCustomerBalanceRecord)list[e.RowIndex];
                if (e.ColumnIndex == SourceOrderID.Index)
                {
                    this.skinSplitContainer1.Panel2Collapsed = false;
                    this.DetailClick?.Invoke(item, this,
                    this.skinSplitContainer1.Panel2);
                }
            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }
        }



        #endregion

        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }

        private void CostumeStoreTrackSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }  

        internal void Search(PfCustomer e)
        {
            this.textBoxCustomer.SelectedValue = e.ID;
            // this.pagePara.PfCustomerID = e.ID;
            CommonGlobalUtil.DateTime_All(dateTimePicker_Start, dateTimePicker_End);
            this.BaseButton_Search_Click(null, null);
        }

        PfCustomer pfCustomer;
        private void textBoxCustomer_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;

        }
    }
}

