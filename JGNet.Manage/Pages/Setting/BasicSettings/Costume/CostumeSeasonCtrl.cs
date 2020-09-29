using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core;
using JGNet.ForManage;
using CCWin;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core.Util;

namespace JGNet.Manage.Pages.BasicSettings.Costume
{
    public partial class CostumeSeasonCtrl : BaseUserControl
    {
        private List<SeasonClass> list;
        private String configKey = ParameterConfigKey.Season;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public CostumeSeasonCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.季节;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    
                    
                     list = DataGridViewUtil.BindingListToList<SeasonClass>(dataGridView1.DataSource);
                    // DataGridViewUtil.BindingListToList<ListItem<String>>(dataGridView1.DataSource);
                    SeasonClass item = (SeasonClass)list[e.RowIndex];
                    switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {

                        case "删除":
                            if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            {
                                return;
                            }
                            if (GlobalUtil.EngineUnconnectioned(this)) { return; }

                            InteractResult result = GlobalCache.ServerProxy.DeleteSeason(item.SeasonKey);

                            switch (result.ExeResult)
                            {
                                case ExeResult.Success:
                                    this.dataGridView1.DataSource = null;
                                    list.Remove(item);
                                    UpdateData();
                                    break;
                                case ExeResult.Error:
                                    GlobalMessageBox.Show(result.Msg);
                                    break;
                            }

                            break;
                    }
                }
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

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                String value = this.skinTextBoxName.SkinTxt.Text.Trim(); if (String.IsNullOrEmpty(value))
                {
                    this.skinTextBoxName.Focus();
                    return;
                }

                if (list.Exists(t => t.SeasonKey == value))
                {
                    GlobalMessageBox.Show("名称已存在！");
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                { return; }
                this.dataGridView1.DataSource = null;
                if (!list.Exists(t => t.SeasonKey == value)) {
                    SeasonClass curSeason = new SeasonClass();
                    curSeason.SeasonKey = value;
                    curSeason.SeasonValue = value;
                    list.Add(curSeason); }
                UpdateData();
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

        private void UpdateData()
        {
            ParameterConfig config = SetUpConfig();
            UpdateResult result = GlobalCache.ServerProxy.UpdateParameterConfig(config);
            switch (result)
            {
                case UpdateResult.Error:
                    GlobalMessageBox.Show("内部错误！");
                    break;
                default:
                    UpdateCache(config);
                    this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list);
                    this.skinTextBoxName.Text = "";
                    break;
            }
        }

        private void UpdateCache(ParameterConfig config)
        {
            GlobalCache.ParameterConfigList.Find(t => (t.ParaKey == config.ParaKey)).ParaValue = config.ParaValue;
        }

        private ParameterConfig SetUpConfig()
        {
            ParameterConfig config = new ParameterConfig();
            config.ParaKey = configKey;
            String values = "";
            foreach (var item in list)
            {
                values += item.SeasonValue + ",";

            }
            if (!String.IsNullOrEmpty(values))
            {
                values = values.Remove(values.LastIndexOf(","));
            }
            config.ParaValue = values;
            return config;
        }

        private void CostumeSeasonCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {
            this.skinTextBoxName.SkinTxt.Text = string.Empty;
            this.dataGridView1.AutoGenerateColumns = false; 
            List<ListItem<string>> confList= GlobalCache.GetParameterConfig(configKey);
            if (list == null)
            {
                list = new List<SeasonClass>();
            }
            foreach (var configItem in confList)
            {
                SeasonClass sItem = new SeasonClass();
                sItem.SeasonKey = configItem.Key;
                sItem.SeasonValue = configItem.Value;
                list.Add(sItem);
            }
            
            //new SortableBindingList<GiftTicketTemplate>( list)
            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(list));
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            DataGridView dataGridView = (DataGridView)sender;
            try
            {
                //检查现有的列表是否有重复名称
                List<SeasonClass> sizeGroups = DataGridViewUtil.BindingListToList<SeasonClass>(dataGridView1.DataSource);
                SeasonClass item = dataGridView1.Rows[e.RowIndex].DataBoundItem as SeasonClass;
                if (e.ColumnIndex == Column1.Index)
                {
                    if (e.FormattedValue == null || String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        GlobalMessageBox.Show("名称不能为空！");
                        dataGridView.CancelEdit();
                        return;
                    }
                    else {
                          SeasonClass existedItem = sizeGroups?.Find(t => t != item && t.SeasonKey.Equals(e.FormattedValue));
                        if(sizeGroups.Contains(item))
                        if (existedItem != null) {
                            GlobalMessageBox.Show("名称已存在！");
                            dataGridView.CancelEdit();
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
        } 


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        
            //if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            //DataGridView dataGridView = (DataGridView)sender;
            //try
            //{
            //    ListItem<String> group = dataGridView.Rows[e.RowIndex].DataBoundItem as ListItem<String>;

            //    InteractResult result = GlobalCache.ServerProxy.UpdateSeason(group.Value, group.Key);
            //    switch (result.ExeResult)
            //    {
            //        case ExeResult.Success:
            //            group.Value = group.Key;
            //            ParameterConfig config = SetUpConfig();
            //            UpdateCache(config);
            //            dataGridViewPagingSumCtrl.BindingDataSource(list);
            //            break;
            //        case ExeResult.Error:
            //            GlobalMessageBox.Show(result.Msg);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CommonGlobalUtil.ShowError(ex);
            //}
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            DataGridView dataGridView = (DataGridView)sender;
            try
            {
                SeasonClass group = dataGridView.Rows[e.RowIndex].DataBoundItem as SeasonClass;
                
                
                 

                InteractResult result = GlobalCache.ServerProxy.UpdateSeason(group.SeasonValue, group.SeasonKey);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        group.SeasonValue = group.SeasonKey;
                        ParameterConfig config = SetUpConfig();
                        UpdateCache(config);
                        dataGridView.RefreshEdit();
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }
    }
}
