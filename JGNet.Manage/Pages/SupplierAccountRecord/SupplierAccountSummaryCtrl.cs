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
    public partial class SupplierAccountSummaryCtrl : BaseModifyUserControl
    {

        private SupplierAccountRecordSummaryPara pagePara;
        public event CJBasic.Action<String, BaseUserControl, Panel> SourceOrderDetailClick;
        private Supplier supplier;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public SupplierAccountSummaryCtrl()
        {
            InitializeComponent();

            MenuPermission= RolePermissionMenuEnum.供应商往来账汇总;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new String[] {
               startMoneyDataGridViewTextBoxColumn.DataPropertyName,
                shouldPayDataGridViewTextBoxColumn.DataPropertyName,
                otherMoneyDataGridViewTextBoxColumn.DataPropertyName,
                payMoneyDataGridViewTextBoxColumn.DataPropertyName,
                endMoneyDataGridViewTextBoxColumn.DataPropertyName
            });

            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                shouldPayDataGridViewTextBoxColumn,
                otherMoneyDataGridViewTextBoxColumn,
                payMoneyDataGridViewTextBoxColumn
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
            this.dataGridView1.AddSpanHeader(2, 3, "本期发生"); 
        }

            private void Initialize()
        {
            this.dataGridViewPagingSumCtrl.SetDataSource<SupplierAccountRecordSummaryInfo>(null);
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
                this.pagePara = new SupplierAccountRecordSummaryPara()
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




        public void Search(SupplierAccountRecordSummaryPara para)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult<List<SupplierAccountRecordSummaryInfo>> listPage = GlobalCache.ServerProxy.GetSupplierAccountRecordSummary(this.pagePara);
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
            this.pagePara = new SupplierAccountRecordSummaryPara()
            {
                SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBoxSupplier.SelectedValue),
                StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                EndDate = new CJBasic.Date(this.dateTimePicker_End.Value), 
            };
            Search(pagePara);
        }

        private void BindingSource(List<SupplierAccountRecordSummaryInfo> listPage)
        { 
            this.dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(listPage));
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

                List<SupplierAccountRecordSummaryInfo> list = DataGridViewUtil.BindingListToList<SupplierAccountRecordSummaryInfo>(dataGridView1.DataSource); 
                SupplierAccountRecordSummaryInfo item = (SupplierAccountRecordSummaryInfo)list[e.RowIndex];
                if (e.ColumnIndex == shouldPayDataGridViewTextBoxColumn.Index)
                {
                    SupplierAccountSummaryShouldPayForm form = new SupplierAccountSummaryShouldPayForm();
                    SupplierAccountRecord4SummaryPara para = new SupplierAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = SARSQueryType.ShouldPay;
                    para.SupplierID = item.SupplierID;
                    form.ShowDialog(para);
                }
                else if (e.ColumnIndex == otherMoneyDataGridViewTextBoxColumn.Index)
                {
                    SupplierAccountSummaryShouldPayForm form = new SupplierAccountSummaryShouldPayForm();
                    SupplierAccountRecord4SummaryPara para = new SupplierAccountRecord4SummaryPara();
                  
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = SARSQueryType.OtherMoney;
                    para.SupplierID = item.SupplierID;
                    form.ShowDialog(para);
                }
                else if (e.ColumnIndex == payMoneyDataGridViewTextBoxColumn.Index)
                {
                    SupplierAccountSummaryShouldPayForm form = new SupplierAccountSummaryShouldPayForm();
                    SupplierAccountRecord4SummaryPara para = new SupplierAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = SARSQueryType.PayMoney;
                    para.SupplierID = item.SupplierID;
                    form.ShowDialog(para);
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
        private void baseButton2_Click(object sender, EventArgs e)
        {


            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "供应商往来账汇总" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                    List<SupplierAccountRecordSummaryInfo> list = DataGridViewUtil.BindingListToList<SupplierAccountRecordSummaryInfo>(dataGridView1.DataSource);
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {
                            keys.Add(item.DataPropertyName);
                            if (item.Name == "shouldPayDataGridViewTextBoxColumn" || item.Name == "otherMoneyDataGridViewTextBoxColumn" || item.Name == "payMoneyDataGridViewTextBoxColumn")
                            {
                                values.Add("本期发生"+item.HeaderText);
                            }
                            else
                            {
                                values.Add(item.HeaderText);
                            }

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

