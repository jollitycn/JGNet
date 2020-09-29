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
using CCWin.SkinControl;
using JGNet.Manage.Components;
using JGNet.Common;
using CJBasic.Helpers;
using JieXi.Common;
using CJBasic;
using JGNet.Common.cache.Wholesale;

namespace JGNet.Manage
{
    public partial class WholesaleAccountContrastCtrl : BaseModifyUserControl
    {

        private PfAccountContrastPara pagePara;
        public event CJBasic.Action<String, BaseUserControl, Panel> SourceOrderDetailClick;
        private PfCustomer supplier;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public WholesaleAccountContrastCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.客户往来账对账表;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new String[] {
                 this.inCountDataGridViewTextBoxColumn.DataPropertyName,
            this.inMoneyDataGridViewTextBoxColumn.DataPropertyName,
            this.outCountDataGridViewTextBoxColumn.DataPropertyName,
            this.outMoneyDataGridViewTextBoxColumn.DataPropertyName,
            this.otherMoneyDataGridViewTextBoxColumn.DataPropertyName,
            this.payMoneyDataGridViewTextBoxColumn.DataPropertyName,
            dataGridViewTextBoxColumn1.DataPropertyName,
                createTimeDataGridViewTextBoxColumn.DataPropertyName
            });
            dataGridViewPagingSumCtrl.HideSummaryRowHeader = true;
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
            this.inCountDataGridViewTextBoxColumn,
            this.inMoneyDataGridViewTextBoxColumn,
            this.outCountDataGridViewTextBoxColumn,
            this.outMoneyDataGridViewTextBoxColumn,
            });
            dataGridViewPagingSumCtrl.Initialize();
            SetSpanInfo();
            Initialize();
        }

        private void SetSpanInfo()
        {
            //this.dataGridView1.myColHeaderTreeView = new TreeView();
            //TreeNode 
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ClearSpanInfo();
            int i = 0;
            this.dataGridView1.MergeColumnNames.Add("Column" + (++i));
            this.dataGridView1.MergeColumnNames.Add("Column" + (++i));
            this.dataGridView1.MergeColumnNames.Add("Column" + (++i));
            this.dataGridView1.AddSpanHeader(i, 2, "发货");
            this.dataGridView1.MergeColumnNames.Add("Column" + (i));
            this.dataGridView1.MergeColumnNames.Add("Column" + (++i));
            this.dataGridView1.MergeColumnNames.Add("Column" + (++i));
            this.dataGridView1.AddSpanHeader(i, 2,"退货");
        }

            private void Initialize()
        {
             this.dataGridViewPagingSumCtrl.SetDataSource<PfAccountContrastInfo>(null);
            //DataGridViewUtil.ListToBindingList(list)
            //List<PfAccountContrastInfo> list = null;
           // dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(list));
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            skinComboBoxSupplier.Initialize(true, true);
        }

 

        public void Search()
        { 

            if (this.pagePara != null)
            {
                this.pagePara.PfCustomerID = supplier?.ID;
            }
            else
            {
                this.pagePara = new PfAccountContrastPara()
                {
                    PfCustomerID = supplier?.ID,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),  
                };
            }
            if (supplier != null)
            {
                skinComboBoxSupplier.SelectedValue = supplier.ID;
            }
            Search(this.pagePara);

        }




        public void Search(PfAccountContrastPara para)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult<PfAccountContrastItem> listPage = GlobalCache.ServerProxy.GetPfAccountContrast(this.pagePara);
                this.BindingSource(listPage?.Data);
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
            string curPfCustomerID = "";
            if (skinComboBoxSupplier.SelectedValue != null)
            {
                curPfCustomerID = ValidateUtil.CheckEmptyValue(skinComboBoxSupplier.SelectedValue);
            }
            else
            {
                if (skinComboBoxSupplier.Text != "" && skinComboBoxSupplier.Text != "所有")
                {
                    GlobalMessageBox.Show("请输入正确的客户信息后再进行查询！");
                    this.skinComboBoxSupplier.Focus();
                    return;
                }
            }
            this.pagePara = new PfAccountContrastPara()
            {
                PfCustomerID = curPfCustomerID,
                StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                EndDate = new CJBasic.Date(this.dateTimePicker_End.Value), 
            };
            Search(pagePara);
        }

        private void BindingSource(PfAccountContrastItem listPage)
        { 
           this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.Infos,false,listPage?.Sum);
           //  dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(listPage?.Infos),listPage?.Sum,false);
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
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                //  List<PfAccountContrastInfo> list = DataGridViewUtil.BindingListToList<PfAccountContrastInfo>(dataGridView1.DataSource);  
                List<PfAccountContrastInfo> list = dataGridView1.DataSource as List<PfAccountContrastInfo>;
                PfAccountContrastInfo item = (PfAccountContrastInfo)list[e.RowIndex];
                DataGridViewCell cell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && String.IsNullOrEmpty(cell.Value.ToString()) || cell.Value.ToString() == "0")
                {
                    return;
                }
                if (e.ColumnIndex == inCountDataGridViewTextBoxColumn.Index || e.ColumnIndex == inMoneyDataGridViewTextBoxColumn.Index)
                {
                    CostumeStoreTrackSearchTurnOutDetailWholeSaleForm form = new CostumeStoreTrackSearchTurnOutDetailWholeSaleForm();
                    AllocateOrder order = new AllocateOrder() {
                        ID = item.OrderID
                    };
                    form.ShowDialog(order);
                }
                else
                if (e.ColumnIndex == outCountDataGridViewTextBoxColumn.Index || e.ColumnIndex == outMoneyDataGridViewTextBoxColumn.Index)
                {
                    CostumeStoreTrackSearchIntoDetailWholeSaleForm form = new CostumeStoreTrackSearchIntoDetailWholeSaleForm();
                    AllocateOrder order = new AllocateOrder()
                    {
                        ID = item.OrderID
                    };
                    form.ShowDialog(order);
                } else if (e.ColumnIndex == otherMoneyDataGridViewTextBoxColumn.Index)
                {
                    WholesaleAccountSummaryShouldPayForm form = new WholesaleAccountSummaryShouldPayForm();
                    PfAccountRecord4SummaryPara para = new PfAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = PARSQueryType.OtherMoney; 
                    form.ShowDialog(para,item.OrderID);
                }  else if (e.ColumnIndex == payMoneyDataGridViewTextBoxColumn.Index)
                {
                    WholesaleAccountSummaryShouldPayForm form = new WholesaleAccountSummaryShouldPayForm();
                    PfAccountRecord4SummaryPara para = new PfAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = PARSQueryType.PayMoney;
                    form.ShowDialog(para, item.OrderID);
                }
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
         

        #endregion

        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                Search(pagePara);
            }
        }


        private void SupplierAccountRecordSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }


        private void skinComboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                supplier = skinComboBoxSupplier.SelectedItem as PfCustomer;
            }
            catch { }
        }

        private String path;
        private void baseButtonExport_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "客户往来账对账表" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                List<PfAccountContrastInfo> unableStore = new List<PfAccountContrastInfo>();
                List<PfAccountContrastInfo> stores = new List<PfAccountContrastInfo>();
               // List<PfAccountContrastInfo> list = DataGridViewUtil.BindingListToList<PfAccountContrastInfo>(dataGridView1.DataSource);
                List<PfAccountContrastInfo> list = (List<PfAccountContrastInfo>)this.dataGridView1.DataSource;
                System.Collections.SortedList columns = new System.Collections.SortedList();
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
            
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    //if (IsPos)
                    //{
                    //    if (item.Index == CostPrice.Index || item.Index == SumCostMoney.Index)
                    //    {
                    //        continue;
                    //    }
                    //}
                    if (item.Visible)
                    {
                        if (item.DataPropertyName == "InCount")
                        {
                            keys.Add(item.DataPropertyName);
                            //  values.Add("发货\r\n" + item.HeaderText);
                            values.Add("发货" + item.HeaderText);

                        }
                        else if (item.DataPropertyName == "InMoney")
                        {
                            keys.Add(item.DataPropertyName);
                            // values.Add("发货\r\n" + item.HeaderText);
                            values.Add("发货" + item.HeaderText);

                        }
                        else if (item.DataPropertyName == "OutCount")
                        {
                            keys.Add(item.DataPropertyName);
                            //values.Add("退货\r\n" + item.HeaderText);
                            values.Add("退货" + item.HeaderText);

                        }
                        else if (item.DataPropertyName == "OutMoney")
                        {
                            keys.Add(item.DataPropertyName);
                            //values.Add("退货\r\n" + item.HeaderText);
                            values.Add("退货" + item.HeaderText);

                        }
                        else {
                            keys.Add(item.DataPropertyName);
                            values.Add(item.HeaderText);
                        }
                        
                       
                    }
                    

                }

                List<CellType> cellList = new List<CellType>();
                NPOIHelper.hsRowCount = 1;
                CellType curCell = new CellType();
                curCell.RowIndex=0;
                curCell.CellName = "客户：" + PfCustomerCache.PfCustomerList.Find(t => t.ID.Equals(ValidateUtil.CheckEmptyValue(skinComboBoxSupplier.SelectedValue))).Name; 
                curCell.CellMergeNum = 4;
                cellList.Add(curCell);

                CellType curCellTime = new CellType();
                curCellTime.RowIndex = 0;
                curCellTime.CellName = "业务时间：" + new CJBasic.Date(this.dateTimePicker_Start.Value)+"至"+new CJBasic.Date(this.dateTimePicker_End.Value);
                curCellTime.CellMergeNum = 6;
                cellList.Add(curCellTime);

                NPOIHelper.CellValues = cellList;
                NPOIHelper.Keys = keys.ToArray();
                NPOIHelper.Values = values.ToArray();
                NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);
                NPOIHelper.CellValues = null;
                GlobalMessageBox.Show("导出完毕！");
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

