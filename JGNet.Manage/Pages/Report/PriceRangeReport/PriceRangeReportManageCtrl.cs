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
    public partial class PriceRangeReportManageCtrl : BaseUserControl
    {

        //当前dataGridView_RetailOrder一页显示多少条数据
        private GetPriceRangeReportsPara pagePara;
        private List<CostumeStore> costumeStoreList = new List<CostumeStore>();
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public CJBasic.Action<GetShopPriceRangeReportPara,  Panel> RowSelected;
        private DataGridViewRow currRow;

        public PriceRangeReportManageCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new string[] {
               countDataGridViewTextBoxColumn.DataPropertyName,
               moneyDataGridViewTextBoxColumn.DataPropertyName,
               CountRate.DataPropertyName,
               MoenyRate.DataPropertyName
});
            dataGridViewPagingSumCtrl.SelectionChanged = dataGridView1_SelectionChanged;
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;
            dataGridViewPagingSumCtrl.AutoIndex = false;
            // skinTextBox_costumeID.SkinTxt.TextChanged += SkinTxt_TextChanged;
            Initialize();
            MenuPermission = RolePermissionMenuEnum.商品价格区间简报;
        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        private void Initialize()
        {

            this.skinSplitContainer1.Panel2Collapsed = true;
            SetRange(skinComboBoxPrice);
           skinComboBoxShop.Initialize( false, CommonGlobalCache.IsGeneralStoreRetail != "1",true);
            List<ListItem<int>> stateList = new List<ListItem<int>>(); 
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            BindingCostumeStoreDataSource(null);
            SetDisplay();
            
        }

        private bool reportShowZero;
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }

        private void SetRange(SkinComboBox  comboBox) {
            List<int> rangeList = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                rangeList.Add(i * 50);
            }
            comboBox.DataSource = rangeList;

        }
        private void SetDisplay()
        {
            this.skinSplitContainer1.Panel2Collapsed = true; 

         //   this.skinComboBoxShopID

                



        }

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                int range = 0;
                try
                {
                     range = Convert.ToInt32(this.skinComboBoxPrice.Text);
                    if (range <= 0)
                    {
                        GlobalMessageBox.Show("价格区间必须大于0！");
                        return;
                    }
                }
                catch (Exception ex) {
                    GlobalMessageBox.Show("请输入正整数！");
                    skinComboBoxPrice.Focus();
                    return;
                }
                 
                this.pagePara = new GetPriceRangeReportsPara()
                {
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    Range = range,
                    IsGetGeneralStore = CommonGlobalCache.IsGeneralStoreRetail == "1",
                    ShopId = ValidateUtil.CheckEmptyValue(skinComboBoxShop.SelectedValue)
                };
                InteractResult<List<PriceRangeReport>> listPage=new InteractResult<List<PriceRangeReport>>();
              
                    if (listPage.ExeResult == ExeResult.Success)
                    {
                        listPage = GlobalCache.ServerProxy.GetPriceRangeReports(this.pagePara);
                    }
                    else
                    {
                        ShowError(listPage.Msg);
                    }
               
             
               

                SetDisplay();
                this.BindingCostumeStoreDataSource(listPage.Data);
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


        /// <summary>
        /// 绑定CostumeStore数据源
        /// </summary>
        /// <param name="listPage"></param>
        private void BindingCostumeStoreDataSource(List<PriceRangeReport> listPage)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
            dataGridViewPagingSumCtrl.BindingDataSource<PriceRangeReport>(DataGridViewUtil.ToDataTable<PriceRangeReport>(listPage));
        }
        Boolean isAll = true; 
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (isAll) { 

            this.skinSplitContainer1.Panel2Collapsed = false;
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.CurrentRow;
            if (row != null && row.Index != -1 && row != currRow)
            {
                DataRowView rowView = (DataRowView)row.DataBoundItem;
                // PriceRangeReport ranking = (PriceRangeReport)dataGridView1.CurrentRow.DataBoundItem;
                if (!String.IsNullOrEmpty(rowView["StartMoney"].ToString()))
                {

                    GetShopPriceRangeReportPara searchPara = new GetShopPriceRangeReportPara();
                    ReflectionHelper.CopyProperty(pagePara, searchPara);
                    searchPara.StartMoney = Convert.ToInt32(rowView["StartMoney"]);
                    RowSelected?.Invoke(searchPara, this.skinSplitContainer1.Panel2);
                    currRow = row;
                } 
            }
            }
        }
          
        private void skinComboBoxShopID_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.skinComboBoxPrice.Text))
            {
                if (!ValidateUtil.CheckMoney(this.skinComboBoxPrice.Text))
                {
                    e.Cancel = true;
                    skinComboBoxPrice.Text = "50";
                }
                else
                {
                   // skinComboBoxShopID.Text = Convert.ToDecimal(this.skinComboBoxShopID.Text);
                }
            } 
        }

        private void skinComboBoxShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skinComboBoxShop.SelectedValue == null)
            {
                isAll = true;
            }
            else { isAll = false; }
        }

        private String path;
        private void baseButton1_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "商品价格区间简报" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                   DataTable list =  dataGridView1.DataSource as DataTable;
                   
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
