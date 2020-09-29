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
    public partial class WholesaleAccountSummaryCtrl : BaseModifyUserControl
    {

        private PfAccountRecordSummaryPara pagePara;
        public event CJBasic.Action<String, BaseUserControl, Panel> SourceOrderDetailClick;
        private PfCustomer supplier;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public WholesaleAccountSummaryCtrl()
        {
            InitializeComponent();

            MenuPermission=RolePermissionMenuEnum.客户往来账汇总;
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
            this.dataGridViewPagingSumCtrl.SetDataSource<PfAccountRecordSummaryInfo>(null);
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            skinComboBoxSupplier.Initialize(false, true);
        }

 

        public void Search()
        { 

            if (this.pagePara != null)
            {
                this.pagePara.PfCustomerID = supplier?.ID;
            }
            else
            {
                this.pagePara = new PfAccountRecordSummaryPara()
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




        public void Search(PfAccountRecordSummaryPara para)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult<List<PfAccountRecordSummaryInfo>> listPage = GlobalCache.ServerProxy.GetPfAccountRecordSummary(this.pagePara);
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
            string curPfCustomerID = "";
            if (skinComboBoxSupplier.SelectedValue != null)
            {
                curPfCustomerID = ValidateUtil.CheckEmptyValue(skinComboBoxSupplier.SelectedValue);
            }
            else
            {
                if (skinComboBoxSupplier.Text != ""&& skinComboBoxSupplier.Text != "所有")
                {
                    GlobalMessageBox.Show("请输入正确的客户信息后再进行查询！");
                    this.skinComboBoxSupplier.Focus();
                    return;
                }
            }

            this.pagePara = new PfAccountRecordSummaryPara()
            {
                PfCustomerID = curPfCustomerID,
                StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                EndDate = new CJBasic.Date(this.dateTimePicker_End.Value), 
            };
            Search(pagePara);
        }

        private void BindingSource(List<PfAccountRecordSummaryInfo> listPage)
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

                List<PfAccountRecordSummaryInfo> list = DataGridViewUtil.BindingListToList<PfAccountRecordSummaryInfo>(dataGridView1.DataSource); 
                PfAccountRecordSummaryInfo item = (PfAccountRecordSummaryInfo)list[e.RowIndex];
                if (e.ColumnIndex == shouldPayDataGridViewTextBoxColumn.Index)
                {
                    WholesaleAccountSummaryShouldPayForm form = new WholesaleAccountSummaryShouldPayForm();
                    PfAccountRecord4SummaryPara para = new PfAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = PARSQueryType.ShouldPay;
                    para.PfCustomerID = item.SupplierID;
                    form.ShowDialog(para);
                }
                else if (e.ColumnIndex == otherMoneyDataGridViewTextBoxColumn.Index)
                {
                    WholesaleAccountSummaryShouldPayForm form = new WholesaleAccountSummaryShouldPayForm();
                    PfAccountRecord4SummaryPara para = new PfAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = PARSQueryType.OtherMoney;
                    para.PfCustomerID = item.SupplierID;
                    form.ShowDialog(para);
                }
                else if (e.ColumnIndex == payMoneyDataGridViewTextBoxColumn.Index)
                {
                    WholesaleAccountSummaryShouldPayForm form = new WholesaleAccountSummaryShouldPayForm();
                    PfAccountRecord4SummaryPara para = new PfAccountRecord4SummaryPara();
                    ReflectionHelper.CopyProperty(this.pagePara, para);
                    para.Type = PARSQueryType.PayMoney;
                    para.PfCustomerID = item.SupplierID;
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


        private String path;
        private void skinComboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                supplier = skinComboBoxSupplier.SelectedItem as PfCustomer;
            }
            catch { }
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "客户往来账汇总" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                    List<PfAccountRecordSummaryInfo> list = DataGridViewUtil.BindingListToList<PfAccountRecordSummaryInfo>(dataGridView1.DataSource);
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {
                                keys.Add(item.DataPropertyName);
                            if (item.Name == "shouldPayDataGridViewTextBoxColumn" || item.Name == "otherMoneyDataGridViewTextBoxColumn" || item.Name == "payMoneyDataGridViewTextBoxColumn")
                            { values.Add("本期发生"+item.HeaderText); }
                            else
                            { values.Add(item.HeaderText); }

                               
                            


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

