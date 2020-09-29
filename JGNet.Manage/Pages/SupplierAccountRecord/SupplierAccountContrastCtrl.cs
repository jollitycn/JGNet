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
using CJBasic;
using JieXi.Common;

namespace JGNet.Manage
{
    public partial class SupplierAccountContrastCtrl : BaseModifyUserControl
    {

        private SupplierAccountContrastPara pagePara;
        public event CJBasic.Action<String, BaseUserControl, Panel> SourceOrderDetailClick;
        private Supplier supplier;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public SupplierAccountContrastCtrl()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.供应商往来账对账表;
         
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
            this.dataGridView1.AddSpanHeader(i, 2, "进货");
            this.dataGridView1.MergeColumnNames.Add("Column" + (i));
            this.dataGridView1.MergeColumnNames.Add("Column" + (++i));
            this.dataGridView1.MergeColumnNames.Add("Column" + (++i));
            this.dataGridView1.AddSpanHeader(i, 2, "退货");
        }

        private void Initialize()
        {
            this.dataGridViewPagingSumCtrl.SetDataSource<SupplierAccountContrastInfo>(null);
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
        }

        public void Search()
        {
            if (this.pagePara != null)
            {
                this.pagePara.SupplierID = supplier?.ID;
            }
            else
            {
                this.pagePara = new SupplierAccountContrastPara()
                {
                    SupplierID = supplier?.ID,
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

        public void Search(SupplierAccountContrastPara para)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult<SupplierAccountContrastItem> listPage = GlobalCache.ServerProxy.GetSupplierAccountContrast(this.pagePara);
                this.BindingSource(listPage.Data);
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
            this.pagePara = new SupplierAccountContrastPara()
            {
                SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBoxSupplier.SelectedValue),
                StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
            };
            Search(pagePara);
        }

        private void BindingSource(SupplierAccountContrastItem listPage)
        {
            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.Infos,false,listPage?.Sum);
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

                List<SupplierAccountContrastInfo> list = (List<SupplierAccountContrastInfo>)this.dataGridView1.DataSource;
                SupplierAccountContrastInfo item = (SupplierAccountContrastInfo)list[e.RowIndex];
                DataGridViewCell cell=   this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value!=null && String.IsNullOrEmpty(cell.Value.ToString()) || cell.Value.ToString() == "0") {
                    return;
                }
                if (e.ColumnIndex == inCountDataGridViewTextBoxColumn.Index || e.ColumnIndex == inMoneyDataGridViewTextBoxColumn.Index)
                {
                    CostumeStoreTrackSearchInDetailForm form = new CostumeStoreTrackSearchInDetailForm();
                    PurchaseOrder order = new PurchaseOrder()
                    {
                        ID = item.OrderID
                    };
                    form.ShowDialog(order);
                }
                else
                if (e.ColumnIndex == outCountDataGridViewTextBoxColumn.Index || e.ColumnIndex == outMoneyDataGridViewTextBoxColumn.Index)
                {
                    CostumeStoreTrackSearchReturnDetailForm form = new CostumeStoreTrackSearchReturnDetailForm();
                    PurchaseOrder order = new PurchaseOrder()
                    {
                        ID = item.OrderID
                    };
                    form.ShowDialog(order);
                }
                else if (e.ColumnIndex == otherMoneyDataGridViewTextBoxColumn.Index)
                {
                    SupplierAccountSummaryShouldPayForm form = new SupplierAccountSummaryShouldPayForm();
                    SupplierAccountRecord4SummaryPara para = new SupplierAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = SARSQueryType.OtherMoney;
                    form.ShowDialog(para, item.OrderID);
                }
                else if (e.ColumnIndex == payMoneyDataGridViewTextBoxColumn.Index)
                {
                    SupplierAccountSummaryShouldPayForm form = new SupplierAccountSummaryShouldPayForm();
                    SupplierAccountRecord4SummaryPara para = new SupplierAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = SARSQueryType.PayMoney;
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
                supplier = skinComboBoxSupplier.SelectedItem as Supplier;
            }
            catch { }
        }

        private String path;
        private void baseButtonExport_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "供应商往来对账表" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                List<SupplierAccountContrastInfo> unableStore = new List<SupplierAccountContrastInfo>();
                List<SupplierAccountContrastInfo> stores = new List<SupplierAccountContrastInfo>();
                List<SupplierAccountContrastInfo> list = (List<SupplierAccountContrastInfo>)dataGridView1.DataSource;
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
                        else
                        {
                            keys.Add(item.DataPropertyName);
                            values.Add(item.HeaderText);
                        }


                    }


                }

                List<CellType> cellList = new List<CellType>();
                NPOIHelper.hsRowCount = 1;
                CellType curCell = new CellType();
                curCell.RowIndex = 0;
                curCell.CellName = "供应商：" + CommonGlobalCache.GetSupplierName(ValidateUtil.CheckEmptyValue(skinComboBoxSupplier.SelectedValue)) ;
                curCell.CellMergeNum = 4;
                cellList.Add(curCell);

                CellType curCellTime = new CellType();
                curCellTime.RowIndex = 0;
                curCellTime.CellName = "业务时间：" + new CJBasic.Date(this.dateTimePicker_Start.Value) + "至" + new CJBasic.Date(this.dateTimePicker_End.Value);
                curCellTime.CellMergeNum = 6;
                cellList.Add(curCellTime);

                NPOIHelper.CellValues = cellList;



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
    }
}

