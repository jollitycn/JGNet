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
using JGNet.Common.Core.Util;

namespace JGNet.Manage.Pages.BasicSettings.Costume
{
    public partial class CashFeeTypeCtrl : BaseUserControl
    { 
        private List<ListItem<String>> list;
        private String configKey= ParameterConfigKey.IncomeTypes;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public CashFeeTypeCtrl( )
        {
            InitializeComponent();

            MenuPermission=RolePermissionMenuEnum.费用类型;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            Query();
            SetFeeType();
        }

        private void Query()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                list = GlobalCache.GetParameterConfig(configKey);
                dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(list));
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

        private void SetFeeType() {
            List<TKeyValue<String, String>> list = new List<TKeyValue<String, String>>(); 
            list.Add(new TKeyValue<String, String>("收入", ParameterConfigKey.IncomeTypes));
            list.Add(new TKeyValue<String, String>("支出", ParameterConfigKey.SpendingTypes));
            this.skinComboBoxFeeType.DisplayMember = "Key";
            this.skinComboBoxFeeType.ValueMember = "Value";
            this.skinComboBoxFeeType.DataSource = list; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    //  List<ListItem<String>> list = (List<ListItem<String>>)this.dataGridView1.DataSource;
                    List<ListItem<String>> list = DataGridViewUtil.BindingListToList<ListItem<String>>(dataGridView1.DataSource);
                    ListItem <String> item = (ListItem<String>)list[e.RowIndex];
                    switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {

                        case "删除":
                            this.dataGridView1.DataSource = null;
                            list.Remove(item);
                            UpdateData(list);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String value = this.skinTextBoxName.SkinTxt.Text.Trim();
                if (String.IsNullOrEmpty(value))
                {
                    this.skinTextBoxName.Focus();
                    return;
                }
                this.dataGridView1.DataSource = null;
                if (!list.Exists(t => t.Key == value))
                {
                    list.Add(new ListItem<String>(value, value));
                }
                else
                {
                    GlobalMessageBox.Show("名称已存在！");
                    return;
                }

                UpdateData(list);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void UpdateData(List<ListItem<string>> list)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                ParameterConfig config = SetUpConfig(list);
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
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally { 
                GlobalUtil.UnLockPage(this);
            }
        } 

        private void UpdateCache(ParameterConfig config)
        {
            GlobalCache.ParameterConfigList.Find(t => (t.ParaKey == config.ParaKey)).ParaValue = config.ParaValue;
        }

        private ParameterConfig SetUpConfig(List<ListItem<string>> list)
        {
            ParameterConfig config = new ParameterConfig();
            config.ParaKey = configKey;
            String values = "";
            foreach (var item in list)
            {
                values += item.Value + ",";

            }
            if(!String.IsNullOrEmpty(values)){
                values = values.Remove(values.LastIndexOf(","));
            }
            config.ParaValue = values;
            return config;
        }

        private void skinComboBoxFeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            configKey = this.skinComboBoxFeeType.SelectedValue.ToString();
            Query();

        }
    }
}
