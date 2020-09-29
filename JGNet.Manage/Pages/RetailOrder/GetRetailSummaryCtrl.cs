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
using CJBasic;
using JieXi.Common;

namespace JGNet.Manage
{/// <summary>
/// 采购退货查询
/// </summary>
    public partial class GetRetailSummaryCtrl : BaseUserControl
    {

        private GetRetailSummaryPara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;
        private RetailSummaryInfo add;



        public event CJBasic.Action<PurchaseOrder, Panel,bool> DetailClick;
        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.BaseButton_Search_Click(null, null);
            } 
        }
     

        public GetRetailSummaryCtrl()
        {
            InitializeComponent();

            MenuPermission = RolePermissionMenuEnum.店铺收款汇总;
            //dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2);
            //dataGridViewPagingSumCtrl2.Initialize(); 
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1,
                new string[] {
                WeChat.DataPropertyName,
                Alipay.DataPropertyName, 
                Cash.DataPropertyName,
                UnionpayCard.DataPropertyName,
                Integrate.DataPropertyName,
                Card.DataPropertyName,
                Sum.DataPropertyName,
                Ticket.DataPropertyName, MoneyOther.DataPropertyName
              
            });


            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.Initialize();

            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;

          
            GlobalUtil.SetShop(skinComboBoxShopID,true);
            skinComboBoxShopID.SelectedValue = GlobalCache.GeneralStoreShopID;
        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }
         

        private void Initialize()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            this.pagePara = new GetRetailSummaryPara();   
        }



        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                this.pagePara = new GetRetailSummaryPara()
                {
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    ShopID = this.skinComboBoxShopID.SelectedValue.ToString(),
                 };
                

                RetailSummary listPage = GlobalCache.ServerProxy.GetRetailSummary(this.pagePara);
               
                this.BindingReturnOrderSource(listPage);

             
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
        
        
        private void BindingReturnOrderSource(RetailSummary listPage)
        {
            // this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.RetailSummaryInfos);
          
            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(listPage?.RetailSummaryInfos));
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
                //List <PurchaseOrder> curReturnOrderListSource = (List<PurchaseOrder>)this.dataGridView1.DataSource;
                //PurchaseOrder item = curReturnOrderListSource[e.RowIndex];

                //if (ColumnOrder.Index == e.ColumnIndex) {
                //        this.skinSplitContainer1.Panel2Collapsed = false;
                //        this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2,false);
                //} else if (ColumnPrint.Index== e.ColumnIndex) { 
                //        this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2,true);
                  
                //}
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
        }

        private void BindingOutboundDetailSource(List<BoundDetail> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (BoundDetail detail in list)
                {
                    detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
                }
            }

            dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(list);

        }

        #endregion

        private void ReturnOrderManageCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private String path;
        private void baseButton2_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "店铺收款汇总" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoExport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
        }
        private void DoExport()
        {
            try
            {
                if (dataGridView1.DataSource != null && dataGridView1.Rows.Count > 0)
                {
                    List<RetailSummaryInfo> list = DataGridViewUtil.BindingListToList<RetailSummaryInfo>(dataGridView1.DataSource);
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {
                            keys.Add(item.DataPropertyName);
                            values.Add(item.HeaderText);

                        }
                    }



                    NPOIHelper.Keys = keys.ToArray();
                    NPOIHelper.Values = values.ToArray();
                    NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);

                    GlobalMessageBox.Show("导出完毕！");
                }
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }
    }
}
 