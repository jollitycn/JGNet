
using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core.Dev.MyEnum;
using JGNet.Core.InteractEntity;
using JGNet.Core.MyEnum;
using JGNet.Core.Tools;
using CJBasic;
using CJBasic.Helpers;
using CJBasic.Loggers;
using JieXi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using static CCWin.SkinControl.SkinChatRichTextBox;

namespace JGNet.Common
{
    public partial class RetailCommissionDetailForm : BaseForm
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private GetDistributorsPara Dispara =null;
        public RetailCommissionDetailForm(GetDistributorsPara para)
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.佣金查询;
            Dispara = para;
            dataGridView_RetailDetail.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(
                this.dataGridView_RetailDetail, new string[] {
            orderMoneyDataGridViewTextBoxColumn.DataPropertyName
            ,commissionDataGridViewTextBoxColumn.DataPropertyName
            })
            {
                ShowColumnSetting = false
            };
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                // TotalCount
            });
           
            dataGridView_RetailDetail.AutoGenerateColumns = false;
            SetLevelValue(skinComboBox_Level);
            dataGridViewPagingSumCtrl.Initialize();
        }

        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        GetCommissionRecordsPara para;
        private void SetLevelValue(SkinComboBox skinComboBox_level)
        {
            try
            {

                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<ListItem<DistributorLevelType>> levelTypes = new List<ListItem<DistributorLevelType>>();

                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.All), DistributorLevelType.All));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelOne), DistributorLevelType.LevelOne));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelTwo), DistributorLevelType.LevelTwo));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelThree), DistributorLevelType.LevelThree));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelFour), DistributorLevelType.LevelFour));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelFive), DistributorLevelType.LevelFive));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelSix), DistributorLevelType.LevelSix));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelSeven), DistributorLevelType.LevelSeven));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelEight), DistributorLevelType.LevelEight));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelNine), DistributorLevelType.LevelNine));
                levelTypes.Add(new ListItem<DistributorLevelType>(JGNet.Core.Tools.EnumHelper.GetDescription(DistributorLevelType.LevelTen), DistributorLevelType.LevelTen));
                skinComboBox_level.DisplayMember = "Key";
                skinComboBox_level.ValueMember = "Value";
                skinComboBox_level.DataSource = levelTypes;



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
        internal void ShowDialog(string distributorID)
        {
            this.dateTimePicker_Start.Value = Dispara.StartTime.ToDateTime();
            this.dateTimePicker_End.Value = Dispara.EndTime.ToDateTime();
            para = new GetCommissionRecordsPara()
            {
                   DistributorID= distributorID,
                   Level=Convert.ToInt32(this.skinComboBox_Level.SelectedValue),
                 StartDate = Dispara.StartTime,
                 EndDate = Dispara.EndTime,
                  
                //Level=this.skinComboBox_Type
            };
          //  ReflectionHelper.CopyProperty(changePara, para);
           // CommonGlobalUtil.SetCostomerSaleType(skinComboBox_Level);
            Search();

           /* if (!String.IsNullOrEmpty(para.CostumeID)) {
                this.Text += ":款号-" + para.CostumeID;
            }*/
            this.ShowDialog();
        }

        public void Search()
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                InteractResult<List<DistributorCommissionRecord>> listPage = CommonGlobalCache.ServerProxy.GetCommissionRecords4Retail(para);
                dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
            //finally
            //{
            //    UnLockPage();
            //}
        } 

        private void dataGridView_RetailDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
             try {

             /*   PurchaseOrder item = dataGridView_RetailDetail.Rows[e.RowIndex].DataBoundItem as PurchaseOrder;
                if (e.ColumnIndex == InboundOrderID.Index )
                 {
                     ShowForm(item);
                 }*/

             }
             catch (Exception ee)
             {
                 CommonGlobalUtil.ShowError(ee);
             }
        }

        private void ShowForm(PurchaseOrder order)
        {

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

             /*   CostumeInDetailForm form = new CostumeInDetailForm();

            form.BaseModifyCostumeID = para.CostumeID;
            // PurchaseOrder changeOrder = CommonGlobalCache.ServerProxy.GetOnePurchaseOrder(order.ID);
            form.ShowDialog(order);*/
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

        private void baseButton2_Click(object sender, EventArgs e)
        {
            //Search((CostumeInvoicingDetailInType)skinComboBox_Type.SelectedValue);
            para.Level = Convert.ToInt32(this.skinComboBox_Level.SelectedValue);
            para.StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value);
            para.EndDate = new CJBasic.Date(this.dateTimePicker_End.Value);
            InteractResult<List<DistributorCommissionRecord>> listPage = CommonGlobalCache.ServerProxy.GetCommissionRecords4Retail(para); 
              dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
            //this.dataGridView_RetailDetail.DataSource = listPage.Data;

        }

        string path = string.Empty;
        private void baseButton4_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "零售佣金明细" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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

                List<DistributorCommissionRecord> list = (List<DistributorCommissionRecord>)this.dataGridView_RetailDetail.DataSource; ;
                //System.Collections.SortedList columns = new System.Collections.SortedList();
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                foreach (DataGridViewColumn item in dataGridView_RetailDetail.Columns)
                {
                    if (item.Visible)
                    {
                        //if (item.Name != "Column1" &&item.Name != "Column2" && item.Name != "Column3" && item.Name != "enabledDataGridViewCheckBoxColumn")
                        //{
                        keys.Add(item.DataPropertyName);
                        values.Add(item.HeaderText);
                        //}
                    }
                }




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
