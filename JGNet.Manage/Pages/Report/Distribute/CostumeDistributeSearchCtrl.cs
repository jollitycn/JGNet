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
using CCWin.SkinControl;
using CJBasic;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Core.Const;
using JGNet.Core.Tools;
using JGNet.Manage;
using JGNet.Common.cache.Wholesale;
using System.Threading;
using JieXi.Common;

namespace JGNet.Common
{
    public partial class CostumeDistributeSearchCtrl : BaseModifyUserControl
    { 

     // private List<RetailOrder> retailOrderList;//绑定DataGridVIew_RetailOrder的集合
        private GetCostumeDistributionsPara para; 
        public  CJBasic.Action<String, BaseUserControl> RefundDetailClick;
        public CJBasic.Action<PfCustomerRetailOrder, BaseUserControl> EditClick;
        public CJBasic.Action<String, BaseUserControl> RetailDetailClick;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;
        private string shopID; 

        public CostumeDistributeSearchCtrl()
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.商品分布;
            this.skinSplitContainer1.Panel2Collapsed = true;
            this.dataGridView_RetailOrder.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(
                this.dataGridView_RetailOrder ,
                 new string[] { CostumeStore.DataPropertyName, ColumnsCostPriceSum.DataPropertyName,
                    // CostPrice.DataPropertyName,
                     }
                 );
            dataGridViewPagingSumCtrl.Initialize();
            dateTimePicker1.Value = new DateTime( DateTime.Now.Year,1,1);
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView_RetailDetail, new string[] {
                inCountDataGridViewTextBoxColumn.DataPropertyName,retailCountDataGridViewTextBoxColumn.DataPropertyName,retailFDataGridViewTextBoxColumn.DataPropertyName,
                retailXSDataGridViewTextBoxColumn.DataPropertyName,retailSDataGridViewTextBoxColumn.DataPropertyName,retailMDataGridViewTextBoxColumn.DataPropertyName,
                retailLDataGridViewTextBoxColumn.DataPropertyName,retailXLDataGridViewTextBoxColumn.DataPropertyName,retailXL2DataGridViewTextBoxColumn.DataPropertyName,
                retailXL3DataGridViewTextBoxColumn.DataPropertyName,retailXL4DataGridViewTextBoxColumn.DataPropertyName,retailXL5DataGridViewTextBoxColumn.DataPropertyName,
                retailXL6DataGridViewTextBoxColumn.DataPropertyName,costumeStoreDataGridViewTextBoxColumn.DataPropertyName,costumeStoreFDataGridViewTextBoxColumn.DataPropertyName,
                costumeStoreXSDataGridViewTextBoxColumn.DataPropertyName,costumeStoreSDataGridViewTextBoxColumn.DataPropertyName,costumeStoreMDataGridViewTextBoxColumn.DataPropertyName,
                costumeStoreLDataGridViewTextBoxColumn.DataPropertyName,costumeStoreXLDataGridViewTextBoxColumn.DataPropertyName,costumeStoreXL2DataGridViewTextBoxColumn.DataPropertyName,
                costumeStoreXL3DataGridViewTextBoxColumn.DataPropertyName,costumeStoreXL4DataGridViewTextBoxColumn.DataPropertyName,costumeStoreXL5DataGridViewTextBoxColumn.DataPropertyName,
                costumeStoreXL6DataGridViewTextBoxColumn.DataPropertyName,



        });
            dataGridViewPagingSumCtrl2.Initialize();
            // 
            // new DataGridViewPagingSumCtrl(dataGridView_RetailDetail).Initialize();
        }

        private void PageControlPanel21_CurrentPageIndexChanged(int index)
        {
            if (this.para == null)
            {
                return;
            }
             
             InteractResult< List<CostumeDistribution>> list =  GlobalCache.ServerProxy.GetCostumeDistributions(para);
            if (list.ExeResult == ExeResult.Success)
            { 
                BindingDataSource(list.Data);
            }
            else
            {
                ShowMessage(list.Msg);
            }
        }
        public override void RefreshPage()
        {
          

        }

      



        private void Initialize()
        {
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
          //  this.retailOrderList = null;
            this.para = new  GetCostumeDistributionsPara();
           // skinComboBox_PfCustomer.Initialize(false, true,1);
            SetDisplay(); 
        }

        private void SetDisplay()
        { 

        }
            
         
        CreateAllReportSelectForm form = null;
        DateTime dateTime = DateTime.Now;
        String createAllReportParaShopId; 

        private bool stopUpdate;

        private void SetSelectPara()
        {
            bool isOpenDate = true;
            Date startDate = new Date(this.dateTimePicker_Start.Value);
            Date endDate = new Date(this.dateTimePicker_End.Value);
            string SCustumeId = string.IsNullOrEmpty(this.costumeTextBox1.Text) ? "" : this.costumeTextBox1.Text;

            this.para = new GetCostumeDistributionsPara()
            {

                BrandID = Convert.ToInt32(this.skinComboBox_Brand.SelectedValue),
                CostumeID = SCustumeId,
                StartDate = startDate,
                EndDate = endDate,
                ClassID = skinComboBoxBigClass.SelectedValue.ClassID,
                Year = Convert.ToInt32(skinComboBoxYear.SelectedValue),
                IsChooseColor = skinCheckBoxShowColor.Checked,
                InStartDate = new Date(dateTimePicker1.Value),
                QueryType = (CostumeDistributionType)skinComboBox_State.SelectedValue,
                Season = ((ListItem<String>)this.skinComboBoxSeason.skinComboBox.SelectedItem).Value,
                 OnlyShowStoreNotZero= skinCheckBox1.Checked,

            };
        }

        //点击查询按钮
        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                SetSelectPara(); 


           //   Search();
           // this.dPara = null;
           //dataGridViewPagingSumCtrl2.BindingDataSource(new List<CostumeDistributionDetail>());
                GetData();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

    /*    private void Search()
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.GetData);
                cb.BeginInvoke(null, null);
              //  ShowProgressForm();
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="para">内部调用的话不传</param>
        public void GetData()
        {
            try
            {

                DateTime startnow = DateTime.Now;

                InteractResult<List<CostumeDistribution>> listPage = GlobalCache.ServerProxy.GetCostumeDistributions(this.para);
                DateTime endtime = DateTime.Now;
                TimeSpan span = (TimeSpan)(endtime - startnow);
                WriteLog("主数据加载开始时间：" + startnow + " 结束时间：" + endtime + " 总耗时数：" + span.TotalSeconds + "秒");
                startnow = endtime;
                if (listPage.ExeResult == ExeResult.Success)
                {
                    if (listPage != null)
                    {
                        //  this.dataGridView_RetailDetail.DataSource = null;
                        // InitProgress(listPage.Data.Count, "加载中……");
                        // UpdateProgress();
                        //  CompleteEdit(listPage.Data);
                        if (listPage.Data != null)
                        {
                            BindingDataSource(listPage.Data);
                              endtime = DateTime.Now;
                             span = (TimeSpan)(endtime - startnow);
                            WriteLog("主数据界面加载开始时间：" + startnow + " 结束时间：" + endtime + " 总耗时数：" + span.TotalSeconds + "秒");
                        }
                        else
                        {
                            this.dataGridView_RetailDetail.DataSource = null;
                            this.dataGridView_RetailOrder.DataSource = null;
                            //dataGridViewPagingSumCtrl.BindingDataSource(new List<CostumeDistributionDetail>());
                            //dataGridViewPagingSumCtrl2.BindingDataSource(new List<CostumeDistributionDetail>());
                        }

                    }
                }
                else
                {
                    ShowMessage(listPage.Msg);
                }

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

      /*  private void CompleteEdit(List<CostumeDistribution> listPage)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<List<CostumeDistribution>>(this.CompleteEdit), listPage);
            }
            else
            {
                DateTime startTime = DateTime.Now;
                //  SetColumnDisplay();
                BindingDataSource(listPage); 
                DateTime endTime = DateTime.Now;
                TimeSpan span = (TimeSpan)(endTime - startTime);
                WriteLog("界面加载开始时间：" + startTime + " 结束时间：" + endTime + " 总耗时数：" + span.TotalSeconds + "秒");
                CompleteEdit();
            }
        }*/

        private void CompleteEdit()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.CompleteEdit));
            }
            else
            {
                CompleteProgressForm();
            }
        }
        private void BindingDataSource(List<CostumeDistribution> listPage)
        {
            if (skinCheckBoxShowColor.Checked)
            {
                dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(ColorName);
            }
            else
            {
                dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(ColorName);
            }
            foreach (CostumeDistribution cDisItem in listPage)
            {
                cDisItem.CostPriceSum = cDisItem.CostumeStore * cDisItem.CostPrice;
            }
            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(listPage));
            //   (DataGridViewUtil.ListToBindingList(listPage)


            if (listPage.Count == 0)
            {
                
                dataGridViewPagingSumCtrl2.BindingDataSource(new List<CostumeDistributionDetail>());
            }

        }

        private void SetQueryCondition()
        {
             
            this.dateTimePicker_Start.Value = para.StartDate.ToDateTime();
            this.dateTimePicker_End.Value = para.EndDate.ToDateTime();
         //   this.skinComboBox_PfCustomer.SelectedValue = para.PfCustomerID;
            this.costumeTextBox1.Text = para.CostumeID;
        }

        private void RetailOrderSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();

            List<ListItem<CostumeDistributionType>> stateList = new List<ListItem<CostumeDistributionType>>();
            stateList.Add(new ListItem<CostumeDistributionType>(EnumHelper.GetDescription(CostumeDistributionType.All), CostumeDistributionType.All));
            stateList.Add(new ListItem<CostumeDistributionType>(EnumHelper.GetDescription(CostumeDistributionType.Shop), CostumeDistributionType.Shop));
            stateList.Add(new ListItem<CostumeDistributionType>(EnumHelper.GetDescription(CostumeDistributionType.PfCustomer), CostumeDistributionType.PfCustomer));
            skinComboBox_State.DisplayMember = "Key";
            skinComboBox_State.ValueMember = "Value";

            skinComboBox_State.DataSource = stateList;
            CommonGlobalUtil.SetBrand(this.skinComboBox_Brand);
            CommonGlobalUtil.SetYear(skinComboBoxYear);
          
        }

        private void dataGridView_RetailOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        

        DataGridViewRow currRow = null;
        CostumeDistribution itemDis = null;
        GetCostumeDistributionDetailsPara dPara;
        private void dataGridView_RetailOrder_SelectionChanged(object sender, EventArgs e)
        {
                DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.CurrentRow;
            ///不重复提交  DataGridViewRow row = view.CurrentRow;
            if (row != null && row.Index > -1 && row != currRow)
            {
                itemDis = (CostumeDistribution)row.DataBoundItem;
                // para.RetailOrderType = item.IsRefundOrder ? RetailOrderType.RefundOrder : RetailOrderType.RetailOrder;
                SetDisplay();
                // this.BindingRetailDetailDataSourceAndCleanLabel(); 
                currRow = row;
                this.skinSplitContainer1.Panel2Collapsed = false;
                if (itemDis == null || String.IsNullOrEmpty(itemDis.CostumeID))
                {
                    this.dataGridView_RetailDetail.DataSource = null;
                }
                else
                {
                    dPara = new GetCostumeDistributionDetailsPara()
                    {
                        BrandID = para.BrandID,
                        ClassID = para.ClassID,
                        CostumeID = itemDis.CostumeID,
                        EndDate = para.EndDate,
                        InStartDate = para.InStartDate,
                        IsChooseColor = para.IsChooseColor,
                        QueryType = para.QueryType,
                        Season = itemDis.Season,
                        StartDate = para.StartDate,
                        Year = itemDis.Year,
                        ColorName = itemDis.ColorName,
                    };
                    SearchDetail();
                }
                //  BindingRetailDetailDataSourceAndCleanLabel();
            }
            else
            {
                return;
            }
        }

         private void SearchDetail()
         {
             try
             {
                 if (CommonGlobalUtil.EngineUnconnectioned(this))
                 {
                     return;
                 }
                 CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.BindingRetailDetailDataSourceAndCleanLabel);
                 cb.BeginInvoke(null, null);
                 ShowProgressForm();
             }
             catch (Exception ee)
             {
                 ShowError(ee);
             }
         }


        private void BindingRetailDetailDataSourceAndCleanLabel()
        {
           
            InteractResult<List<CostumeDistributionDetail>> retailDetailList = null;
           
            try
            {
                DateTime starttime = DateTime.Now;                 
                   retailDetailList = GlobalCache.ServerProxy.GetCostumeDistributionDetails(dPara);
                if (retailDetailList.ExeResult == ExeResult.Success)
                {
                    if (retailDetailList.Data != null)
                    { 
                        DateTime endtime = DateTime.Now;
                        TimeSpan span = (TimeSpan)(endtime - starttime);
                        WriteLog("明细数据加载开始时间：" + starttime + " 结束时间：" + endtime + " 总耗时数：" + span.TotalSeconds + "秒");
                        CompleteEditDetail(retailDetailList);
                    }
                }
                else
                {
                    ShowMessage(retailDetailList.Msg);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void CompleteEditDetail(InteractResult<List<CostumeDistributionDetail>> listPage)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<InteractResult<List<CostumeDistributionDetail>>>(this.CompleteEditDetail), listPage);
            }
            else
            {
                DateTime startTime = DateTime.Now; 
                //this.dataGridView_RetailDetail.Refresh();
                
                  DataGrid2Binding(listPage);
                  DateTime endTime = DateTime.Now;
                TimeSpan span = (TimeSpan)(endTime - startTime);
                WriteLog("明细界面加载开始时间：" + startTime + " 结束时间：" + endTime + " 总耗时数：" + span.TotalSeconds + "秒");
                CompleteEdit();
            }
        }

        private void DataGrid2Binding(InteractResult<List<CostumeDistributionDetail>> retailDetailList)
        {
            DateTime starttime = DateTime.Now;
            //this.dataGridView_RetailDetail.DataSource = null; 
            //dataGridViewPagingSumCtrl2.BindingDataSource(new List<CostumeDistributionDetail>());
            if (retailDetailList != null)
            {
               
            }
            //dataGridViewPagingSumCtrl2.BindingDataSource(retailDetailList.Data,false,null);
            dataGridViewPagingSumCtrl2.BindingDataSource(DataGridViewUtil.ListToBindingList(retailDetailList.Data));
            //dataGridViewPagingSumCtrl2.AppendNotShowInColumnSettings(nameDataGridViewTextBoxColumn);

        }

        private void costumeDistributionDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void skinCheckBoxShowImage_CheckedChanged(object sender, EventArgs e)
        {
           /* if (skinCheckBoxShowColor.Checked)
            {
                this.ColorName.Visible = true;
            }
            else
            {
                this.ColorName.Visible = false;
            }*/
        }

        private void dataGridView_RetailDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            if (this.dataGridView_RetailDetail.DataSource != null)
            {
                if ((e.ColumnIndex >= retailFDataGridViewTextBoxColumn.Index && e.ColumnIndex <= retailXL6DataGridViewTextBoxColumn.Index) || (e.ColumnIndex >= costumeStoreFDataGridViewTextBoxColumn.Index && e.ColumnIndex <= costumeStoreXL6DataGridViewTextBoxColumn.Index))
                {
                    List<CostumeDistributionDetail> list = DataGridViewUtil.BindingListToList<CostumeDistributionDetail>(this.dataGridView_RetailDetail.DataSource);
                    //this.dataGridView_RetailDetail.Columns[e.ColumnIndex]
                }
                else if (e.ColumnIndex == inCountDataGridViewTextBoxColumn.Index)
                {
                    List<CostumeDistributionDetail> list = DataGridViewUtil.BindingListToList<CostumeDistributionDetail>(this.dataGridView_RetailDetail.DataSource);
                    CostumeDistributionDetail curDetail = list[e.RowIndex];
                    GetCostumeDistributionDetailsPara detailPara = new GetCostumeDistributionDetailsPara();
                    detailPara.BrandID = this.dPara.BrandID;
                    detailPara.ClassID = this.dPara.ClassID;
                    detailPara.CostumeID = this.dPara.CostumeID;
                    detailPara.EndDate = this.dPara.EndDate;
                    detailPara.ID = curDetail.ID;
                    detailPara.InStartDate = new Date(curDetail.CreateTime);
                    detailPara.IsChooseColor = this.dPara.IsChooseColor;
                    detailPara.QueryType = curDetail.Type;
                    detailPara.Season = this.dPara.Season;
                    detailPara.StartDate = this.dPara.StartDate;
                    detailPara.Year = this.dPara.Year;
                    AccumulativeTotalStockGoodDetailForm form = new AccumulativeTotalStockGoodDetailForm();
                    form.ShowDialog(detailPara);
                }
                else if (e.ColumnIndex == retailCountDataGridViewTextBoxColumn.Index)
                {
                    List<CostumeDistributionDetail> list = DataGridViewUtil.BindingListToList<CostumeDistributionDetail>(this.dataGridView_RetailDetail.DataSource);
                    CostumeDistributionDetail curDetail = list[e.RowIndex];
                    GetCostumeDistributionDetailsPara detailPara = new GetCostumeDistributionDetailsPara();
                    detailPara.BrandID = this.dPara.BrandID;
                    detailPara.ClassID = this.dPara.ClassID;
                    detailPara.CostumeID = this.dPara.CostumeID;
                    detailPara.EndDate = this.dPara.EndDate;
                    detailPara.ID = curDetail.ID;
                    detailPara.InStartDate = new Date(curDetail.CreateTime);
                    detailPara.IsChooseColor = this.dPara.IsChooseColor;
                    detailPara.QueryType = curDetail.Type;
                    detailPara.Season = this.dPara.Season;
                    detailPara.StartDate = this.dPara.StartDate;
                    detailPara.Year = this.dPara.Year;
                    AccumulativeCurrentSaleDetailForm form = new AccumulativeCurrentSaleDetailForm();
                    form.ShowDialog(detailPara);
                }
            }
        }

        private String path;
        private void baseButton3_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "商品分布" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                
                List<CostumeDistribution> list = DataGridViewUtil.BindingListToList<CostumeDistribution>(dataGridView_RetailOrder.DataSource);
              // List<AllocateOrder> list = (List<AllocateOrder>)(dataGridView_RetailOrder.DataSource);
                // System.Collections.SortedList columns = new System.Collections.SortedList();
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                foreach (DataGridViewColumn item in dataGridView_RetailOrder.Columns)
                {
                    if (item.Visible)
                    {
                        
                            keys.Add(item.DataPropertyName);
                            values.Add(item.HeaderText);
                        
                    }
                }
                /*    List<AllocateOrder> ExportList = new List<AllocateOrder>();
                    foreach (AllocateOrder cItem in list)
                    {
                        AllocateOrder curBrand = new AllocateOrder();
                        curBrand.Name = cItem.Name;
                        curBrand.FirstCharSpell = cItem.FirstCharSpell;
                        ExportList.Add(curBrand);
                    }*/



                NPOIHelper.Keys = keys.ToArray();
                NPOIHelper.Values = values.ToArray();
                NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);

                GlobalMessageBox.Show("导出完毕！");
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }

        private void skinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetSelectPara();
            GetData();
        }
    }
}
