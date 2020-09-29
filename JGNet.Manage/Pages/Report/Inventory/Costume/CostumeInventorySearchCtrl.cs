using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;

using JGNet.Core.Tools;
using JGNet.Core.InteractEntity;
using CCWin;
using JGNet.Common.Core;  
using JGNet.Core;
using CCWin.SkinControl;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Server.Tools;
using JGNet.Manage;
using JGNet.Core.Const;
using CJBasic.Helpers;
using CJBasic;
using JieXi.Common;

namespace JGNet.Common
{
    public partial class CostumeInventorySearchCtrl : BaseUserControl
    {

        //当前dataGridView_RetailOrder一页显示多少条数据
        private GetCostumeInvoicingPara pagePara;
        private List<CostumeStore> costumeStoreList = new List<CostumeStore>();
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public CJBasic.Action<DataRowView, GetCostumeInvoicingPara, Panel> RowSelected;
        private DataGridViewRow currRow;

        public CostumeInventorySearchCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new String[] { 
         inCountDataGridViewTextBoxColumn.DataPropertyName,
         inMoneyDataGridViewTextBoxColumn.DataPropertyName,
         pfSalesCountDataGridViewTextBoxColumn.DataPropertyName,
         pfSalesMoneyDataGridViewTextBoxColumn.DataPropertyName,
         retailCountDataGridViewTextBoxColumn.DataPropertyName,
         retailMoneyDataGridViewTextBoxColumn.DataPropertyName,
         costumeStoreCountDataGridViewTextBoxColumn.DataPropertyName,
         costumeStoreMoneyDataGridViewTextBoxColumn.DataPropertyName,
         FRetailCount.DataPropertyName,
XSRetailCount.DataPropertyName,
SRetailCount.DataPropertyName,
MRetailCount.DataPropertyName,
LRetailCount.DataPropertyName,
XLRetailCount.DataPropertyName,
XL2RetailCount.DataPropertyName,
XL3RetailCount.DataPropertyName,
XL4RetailCount.DataPropertyName,
XL5RetailCount.DataPropertyName,
XL6RetailCount.DataPropertyName,
RetailSumMoney.DataPropertyName,
RetailSumCount.DataPropertyName,
FCostumeStoreCount.DataPropertyName,
XSCostumeStoreCount.DataPropertyName,
SCostumeStoreCount.DataPropertyName,
MCostumeStoreCount.DataPropertyName,
LCostumeStoreCount.DataPropertyName,
XLCostumeStoreCount.DataPropertyName,
XL2CostumeStoreCount.DataPropertyName,
XL3CostumeStoreCount.DataPropertyName,
XL4CostumeStoreCount.DataPropertyName,
XL4CostumeStoreCount.DataPropertyName,
XL6CostumeStoreCount.DataPropertyName,
    });
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.AutoIndex = false;
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;
            dataGridViewPagingSumCtrl.SelectionChanged = dataGridView1_SelectionChanged;
            dataGridView1.ColumnHeadersHeight = 40;
            DateTime nowS = DateTime.Now;
            SetSpanInfo();
            DateTime endT = DateTime.Now;
            TimeSpan span = (TimeSpan)(endT - nowS);
            WriteLog("初始化加载合并列头开始时间：" + nowS + " 结束时间：" + endT + " 总耗时数：" + span.TotalSeconds + "秒");
            Initialize();
            MenuPermission = RolePermissionMenuEnum.商品进销存;
        }
        private void setAddCol(int num,ref int startI)
        { 
            for (int i = 0; i < num; i++) {
                this.dataGridView1.MergeColumnNames.Add("Column" + (++startI)); 
            }
        }
           List<DataGridViewColumn> columnsDisplay = new List<DataGridViewColumn>();
            List<DataGridViewColumn> columnsHide = new List<DataGridViewColumn>();
        private void SetSpanInfo()
        { 
            dataGridView1.ClearSpanInfo();
            columnsDisplay.Clear();
            columnsHide.Clear();
            int i = 0;
            setAddCol(4, ref i);
            if (skinCheckBoxColor.Checked)
            {
                columnsDisplay.Add(colorNameDataGridViewTextBoxColumn);

                this.dataGridView1.MergeColumnNames.Add("Column" + (++i));
            }
            else
            {

                ++i;
                columnsHide.Add(colorNameDataGridViewTextBoxColumn);
            }
            if (skinCheckBoxSizeName.Checked)
            {
                // i = i + 11;
                this.dataGridView1.AddSpanHeader((i), 2, "进货");
                setAddCol(2, ref i);

                this.dataGridView1.AddSpanHeader((i), 2, "批发");
                // setAddCol(13);

                setAddCol(2, ref i);
                this.dataGridView1.AddSpanHeader((i), 2, "零售");
                 setAddCol(2, ref i);

                this.dataGridView1.AddSpanHeader((i), 13, "销售合计");
                setAddCol(13, ref i);

                this.dataGridView1.AddSpanHeader((i), 13, "库存");
                setAddCol(13, ref i);

                columnsDisplay.Add(FRetailCount);
                columnsDisplay.Add(XSRetailCount);
                columnsDisplay.Add(SRetailCount);
                columnsDisplay.Add(MRetailCount);
                columnsDisplay.Add(LRetailCount);
                columnsDisplay.Add(XLRetailCount);
                columnsDisplay.Add(XL2RetailCount);
                columnsDisplay.Add(XL3RetailCount);
                columnsDisplay.Add(XL4RetailCount);
                columnsDisplay.Add(XL5RetailCount);
                columnsDisplay.Add(XL6RetailCount);
                columnsDisplay.Add(FCostumeStoreCount);
                columnsDisplay.Add(XSCostumeStoreCount);
                columnsDisplay.Add(SCostumeStoreCount);
                columnsDisplay.Add(MCostumeStoreCount);
                columnsDisplay.Add(LCostumeStoreCount);
                columnsDisplay.Add(XLCostumeStoreCount);
                columnsDisplay.Add(XL2CostumeStoreCount);
                columnsDisplay.Add(XL3CostumeStoreCount);
                columnsDisplay.Add(XL4CostumeStoreCount);
                columnsDisplay.Add(XL5CostumeStoreCount);
                columnsDisplay.Add(XL6CostumeStoreCount);


            }
            else
            {
                // i = i + 11;
                this.dataGridView1.AddSpanHeader((i), 2, "进货");
               setAddCol(2, ref i);
                this.dataGridView1.AddSpanHeader((i), 2, "批发");
                setAddCol(2, ref i);


               
                this.dataGridView1.AddSpanHeader((i), 2, "零售");

                setAddCol(13, ref i);
                this.dataGridView1.AddSpanHeader((i), 2, "销售合计");



                setAddCol(13, ref i);



                this.dataGridView1.AddSpanHeader((i), 2, "库存");

                columnsHide.Add(FRetailCount);
                columnsHide.Add(XSRetailCount);
                columnsHide.Add(SRetailCount);
                columnsHide.Add(MRetailCount);
                columnsHide.Add(LRetailCount);
                columnsHide.Add(XLRetailCount);
                columnsHide.Add(XL2RetailCount);
                columnsHide.Add(XL3RetailCount);
                columnsHide.Add(XL4RetailCount);
                columnsHide.Add(XL5RetailCount);
                columnsHide.Add(XL6RetailCount);
                columnsHide.Add(FCostumeStoreCount);
                columnsHide.Add(XSCostumeStoreCount);
                columnsHide.Add(SCostumeStoreCount);
                columnsHide.Add(MCostumeStoreCount);
                columnsHide.Add(LCostumeStoreCount);
                columnsHide.Add(XLCostumeStoreCount);
                columnsHide.Add(XL2CostumeStoreCount);
                columnsHide.Add(XL3CostumeStoreCount);
                columnsHide.Add(XL4CostumeStoreCount);
                columnsHide.Add(XL5CostumeStoreCount);
                columnsHide.Add(XL6CostumeStoreCount);
            }
          

        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        } 

        private void Initialize()
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
            String shopID = IsPos ? CommonGlobalCache.CurrentShopID : CommonGlobalCache.GeneralStoreShopID;
            List<ListItem<int>> stateList = new List<ListItem<int>>();
            DateTimeUtil.DateTimePicker_ThisMonth(dateTimePicker_Start, dateTimePicker_End);
            BindingCostumeStoreDataSource(null);
            
        }

         

        private void SkinTextBox_costumeID_CostumeSelected(Costume costume, bool isEnter)
        {
            if (costume!=null && isEnter) {
                BaseButton_Search_Click(null, null);
            }
        }


        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            CommonGlobalUtil.Debug("开始查询");
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                Brand curBrand = this.skinComboBox_Brand.SelectedItem;
                int curBrandID = -2;
                if (curBrand == null)
                {
                    curBrandID = -2;
                }
                else
                {
                    curBrandID = curBrand.AutoID;
                }
                this.pagePara = new GetCostumeInvoicingPara()
                { 
                    ClassID = skinComboBoxBigClass.SelectedValue.ClassID,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                     EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    CostumeID = this.skinTextBox_costumeID.Text,
                    BrandID  =curBrandID,
                    ChooseColor = skinCheckBoxColor.Checked,
                      ChooseSize  =skinCheckBoxSizeName.Checked ,

                    Season = ((ListItem<String>)this.skinComboBoxSeason.skinComboBox.SelectedItem).Value,

                };

                //找到对应的大类
                // pagePara.ClassID = GetBigClass( pagePara.ClassID);
                DateTime startTime = DateTime.Now;
                InteractResult<List<CostumeInvoicing>> listPage = GlobalCache.ServerProxy.GetCostumeInvoicing(this.pagePara);
                DateTime endTime = DateTime.Now;
                TimeSpan span = (TimeSpan)(endTime - startTime);
                WriteLog("数据加载开始时间：" + startTime + " 结束时间：" + endTime + " 总耗时数：" + span.TotalSeconds + "秒");
                startTime = DateTime.Now;

                SetSpanInfo();
                endTime = DateTime.Now;
                span = (TimeSpan)(endTime - startTime);
                WriteLog("表头列设置加载开始时间：" + startTime + " 结束时间：" + endTime + " 总耗时数：" + span.TotalSeconds + "秒");


                this.BindingCostumeStoreDataSource(listPage.Data);
                endTime = DateTime.Now;
                span = (TimeSpan)(endTime - startTime);
                WriteLog("总界面加载开始时间：" + startTime + " 结束时间：" + endTime + " 总耗时数：" + span.TotalSeconds + "秒");
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
            finally
            {
                UnLockPage();
            }
            CommonGlobalUtil.Debug("结束查询");
        }

        //private int GetBigClass(int classID)
        //{
        //    int id =0;
             
        //    return id;
        //}


        /// <summary>
        /// 绑定CostumeStore数据源
        /// </summary>
        /// <param name="listPage"></param>
        private void BindingCostumeStoreDataSource(List<CostumeInvoicing> listPage)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                this.skinSplitContainer1.Panel2Collapsed = true;
                if (columnsHide != null && columnsHide.Count > 0)
                {
                    dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(columnsHide.ToArray());
                }
                if (columnsDisplay != null && columnsDisplay.Count > 0)
                {
                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(columnsDisplay.ToArray());
                }
               // DataTable dt = DataGridViewUtil.ToDataTable<CostumeInvoicing>(listPage);
                this.dataGridViewPagingSumCtrl.BindingDataSource<CostumeInvoicing>(DataGridViewUtil.ToDataTable(listPage));
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1 == null || dataGridView1.Rows.Count< 0 || dataGridView1.CurrentRow==null)
            {

            }
            DataGridView view = (DataGridView)sender;
                DataGridViewRow row = view.CurrentRow;
                if (row.Index < 0 || row == null) { return; }
                if (row != null && row.Index != -1 && row != currRow)
                {
                    currRow = row;
                    DataRowView ranking = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                    if (RowSelected != null)
                    {
                        GetCostumeInvoicingPara tempPara = new GetCostumeInvoicingPara();
                        ReflectionHelper.CopyProperty(pagePara, tempPara);


                        tempPara.CostumeID = ranking["CostumeID"].ToString();
                        this.skinSplitContainer1.Panel2Collapsed = false;
                        RowSelected.Invoke(ranking, tempPara, this.skinSplitContainer1.Panel2);
                    }
                }
            }
       
               
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                 
                if (e.ColumnIndex==inCountDataGridViewTextBoxColumn.Index || e.ColumnIndex==inMoneyDataGridViewTextBoxColumn.Index)
                {
                    //进货明细
                    try
                    {
                        if (CommonGlobalUtil.EngineUnconnectioned(this))
                        {
                            return;
                        }


                          StockgoodDetailForm form = new StockgoodDetailForm();
                       DataTable dt =(DataTable)this.dataGridView1.DataSource; 
                       DataRow item = dt.Rows[e.RowIndex];
                       GetCostumeInvoicingDetailPara changePara = new GetCostumeInvoicingDetailPara(); 

                       ReflectionHelper.CopyProperty(this.pagePara, changePara);

                        changePara.CostumeID = item["CostumeID"].ToString();
                        if(skinCheckBoxColor.Checked)
                       { 
                         changePara.ColorName= item["ColorName"].ToString();
                       }
                       if (skinCheckBoxSizeName.Checked)
                       {
                           changePara.SizeName = item["SizeName"].ToString();
                       }

                       changePara.StartDate = changePara.StartDate;
                       changePara.EndDate = changePara.EndDate;
                       form.ShowDialog(changePara); 
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
                if (e.ColumnIndex == pfSalesCountDataGridViewTextBoxColumn.Index || e.ColumnIndex == pfSalesMoneyDataGridViewTextBoxColumn.Index)
                {
                    //批发明细
                    try
                    {
                        if (CommonGlobalUtil.EngineUnconnectioned(this))
                        {
                            return;
                        }

                        WholesaleDetailForm form = new WholesaleDetailForm();

                    DataTable dt = (DataTable)this.dataGridView1.DataSource;
                    DataRow item = dt.Rows[e.RowIndex];
                    GetCostumeInvoicingDetailPara changePara = new GetCostumeInvoicingDetailPara();
                    ReflectionHelper.CopyProperty(this.pagePara, changePara);

                    changePara.CostumeID = item["CostumeID"].ToString();
                    if (skinCheckBoxColor.Checked)
                    {
                        changePara.ColorName = item["ColorName"].ToString();
                    }
                    if (skinCheckBoxSizeName.Checked)
                    {
                        changePara.SizeName = item["SizeName"].ToString();
                    }
                    changePara.StartDate = changePara.StartDate;
                    changePara.EndDate = changePara.EndDate;
                    form.ShowDialog(changePara);
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
                if (e.ColumnIndex == retailCountDataGridViewTextBoxColumn.Index || e.ColumnIndex == retailMoneyDataGridViewTextBoxColumn.Index)
                {
                    //零售明细
                    try
                    {
                        if (CommonGlobalUtil.EngineUnconnectioned(this))
                        {
                            return;
                        }

                        sellDetailForm form = new sellDetailForm();
                    DataTable dt = (DataTable)this.dataGridView1.DataSource;
                    DataRow item = dt.Rows[e.RowIndex];
                    GetCostumeInvoicingDetailPara changePara = new GetCostumeInvoicingDetailPara();
                    ReflectionHelper.CopyProperty(this.pagePara, changePara);
                    changePara.CostumeID = item["CostumeID"].ToString();
                    if (skinCheckBoxColor.Checked)
                    {
                        changePara.ColorName = item["ColorName"].ToString();
                    }
                    if (skinCheckBoxSizeName.Checked)
                    {
                        changePara.SizeName = item["SizeName"].ToString();
                    }
                    changePara.StartDate = changePara.StartDate;
                    changePara.EndDate = changePara.EndDate;
                    form.ShowDialog(changePara);
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

            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
        }

        private String path;
        private void baseButton1_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "商品进销存" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                    DataTable list = dataGridView1.DataSource as DataTable;
                    System.Collections.SortedList columns = new System.Collections.SortedList();
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {

                            keys.Add(item.DataPropertyName);
                            if (item.Name == "inCountDataGridViewTextBoxColumn" || item.Name == "inMoneyDataGridViewTextBoxColumn")
                            {
                                values.Add("进货" + item.HeaderText);

                            }
                            else if (item.Name == "pfSalesCountDataGridViewTextBoxColumn" || item.Name == "pfSalesMoneyDataGridViewTextBoxColumn")
                            {

                                values.Add("批发" + item.HeaderText);
                            }
                            else if (item.Name == "retailCountDataGridViewTextBoxColumn" || item.Name == "retailMoneyDataGridViewTextBoxColumn")
                            {

                                values.Add("零售" + item.HeaderText);
                            }
                            else if (item.Name == "costumeStoreCountDataGridViewTextBoxColumn" || item.Name == "costumeStoreMoneyDataGridViewTextBoxColumn")
                            {

                                values.Add("库存" + item.HeaderText);
                            }
                            else
                            {  values.Add(item.HeaderText); }
                           

                        }
                    }



                    NPOIHelper.Keys = keys.ToArray();
                    NPOIHelper.Values = values.ToArray();
                    NPOIHelper.ExportExcel(list, path);

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
