using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CJBasic.Widget;
using CJBasic;
using CJBasic.Loggers;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
 
using CCWin.SkinControl;
using JGNet.Core.Tools;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Manage.Components;
using JGNet.Core.Dev.MyEnum;
using JGNet.Common.Core.Util;
using JieXi.Common;

namespace JGNet.Manage

{
    public partial class CostumeStoreAnalysisCtrl : BaseUserControl
    {
        private GetCostumeStoreAnalysisPara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private Costume curCostume;
         
        public override void RefreshPage()
        { 
        }

        public CostumeStoreAnalysisCtrl()
        {
            InitializeComponent();
            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new String[] {
            this.countDataGridViewTextBoxColumn.DataPropertyName,
            this.priceDataGridViewTextBoxColumn.DataPropertyName,
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName,
            this.countPercentageDataGridViewTextBoxColumn.DataPropertyName,
            this.pricePercentageDataGridViewTextBoxColumn.DataPropertyName,
            this.costPricePercentageDataGridViewTextBoxColumn.DataPropertyName
            });

            dataGridViewPagingSumCtrl.Initialize();
            MenuPermission = RolePermissionMenuEnum.库存分析;
        }

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                pagePara = new GetCostumeStoreAnalysisPara()
                {
                    ShopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue),
                    BrandID = (this.skinComboBox_Brand.SelectedValue != null && int.Parse(this.skinComboBox_Brand.SelectedValue.ToString()) != -1) ? int.Parse(this.skinComboBox_Brand.SelectedValue.ToString()) : -1,
                    Season = ValidateUtil.CheckEmptyValue(this.skinComboBoxSeason.SelectedValue),
                    GroupType = (GroupType)skinComboBoxGroup.SelectedValue
                };

                List<CostumeStoreAnalysisData> list = GlobalCache.ServerProxy.GetCostumeStoreAnalysis(this.pagePara);
                this.BindingDataSource(list);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }


        private void BindingDataSource(List<CostumeStoreAnalysisData> listPage)
        {

            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(listPage));
        //    this.dataGridView1.DataSource = listPage; 
        }
         

        private void CostumeManageCtrl_Load(object sender, EventArgs e)
        {
            try
            {

                this.dataGridViewPagingSumCtrl.SetDataSource<CostumeStoreAnalysisData>(null);
                pagePara = new GetCostumeStoreAnalysisPara();
                GlobalUtil.SetBrand(this.skinComboBox_Brand);
                SetGroup();
               skinComboBoxShopID.Initialize();
                CommonGlobalUtil.SetParameterConfig(skinComboBoxSeason, ParameterConfigKey.Season);
            }
            catch (Exception ex)
            {

                GlobalUtil.ShowError(ex);
            }
        }
        private void SetGroup() {

            List<ListItem<GroupType>> stateList = new List<ListItem<GroupType>>();
            stateList.Add(new ListItem<GroupType>(EnumHelper.GetDescription(GroupType.Shop), GroupType.Shop));
            stateList.Add(new ListItem<GroupType>(EnumHelper.GetDescription(GroupType.BigClass), GroupType.BigClass));
            stateList.Add(new ListItem<GroupType>(EnumHelper.GetDescription(GroupType.SmallClass), GroupType.SmallClass));
            stateList.Add(new ListItem<GroupType>(EnumHelper.GetDescription(GroupType.SubSmallClass), GroupType.SubSmallClass));
            stateList.Add(new ListItem<GroupType>(EnumHelper.GetDescription(GroupType.Brand), GroupType.Brand));
            stateList.Add(new ListItem<GroupType>(EnumHelper.GetDescription(GroupType.Supplier), GroupType.Supplier));

            this.skinComboBoxGroup.DisplayMember = "Key";
            this.skinComboBoxGroup.ValueMember = "Value";
            this.skinComboBoxGroup.DataSource = stateList; 

        }

        private String path;
        private void baseButton1_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "库存分析" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                    List<CostumeStoreAnalysisData> list = DataGridViewUtil.BindingListToList<CostumeStoreAnalysisData>(dataGridView1.DataSource); 
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
