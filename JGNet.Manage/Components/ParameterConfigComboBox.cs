using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Common.Components;
using JGNet.Common;

namespace JGNet.Manage.Components
{
    public partial class ParameterConfigComboBoxCtrl : UserControl
    {
        protected List<ListItem<String>> ParameterConfigList(List<ListItem<String>> listItems)
        {
            List<ListItem<String>> list = new List<ListItem<String>>();
            list.AddRange(listItems);
            return list;
        }

        private String key;

        protected string Title { get; set; }
        public Boolean ShowAdd{ get {return this.skinLabelAdd.Visible; } set { this.skinLabelAdd.Visible = value; } }
        private AddCorssComboBoxForm addForm;
        public ParameterConfigComboBoxCtrl()
        {
            InitializeComponent();
        }

        private void skinLabelAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return ;
                }

                addForm = new AddCorssComboBoxForm(Title);
                    if (addForm.ShowDialog(this.ParentForm) == DialogResult.OK)
                    {
                        List<ListItem<String>> list = (List<ListItem<String>>)this.skinComboBox.DataSource;
                        if (list == null) { list = new List<ListItem<string>>(); }
                        String value = addForm.Result;
                        ListItem<String> listItem = list.Find(t => t.Key == value);
                        if (listItem == null)
                        {
                            this.skinComboBox.DataSource = null;
                            ListItem<String> item = new ListItem<String>(value, value);
                            list.Add(item);
                            this.skinComboBox.DataSource = list;
                            this.skinComboBox.SelectedIndex = list.IndexOf(item);
                            //update to db
                            String paraValue = GlobalUtil.GetValueStringFromListItem(list);
                            UpdateResult result = GlobalCache.ParameterConfig_OnChange(key, paraValue);
                            switch (result)
                            {
                                case UpdateResult.Success:
                                    break;
                                case UpdateResult.Error:
                                    this.skinComboBox.DataSource = null;
                                    list.Remove(item);
                                    this.skinComboBox.DataSource = list;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                        //  JGNetMessage
                        GlobalMessageBox.Show(Title + "已存在！");
                        //
                        // this.skinComboBox.SelectedItem = listItem;
                    }
                    }
                } 
            catch (Exception ex) {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        protected void Initialize(string parameterConfigKey, Boolean showAll, List<ListItem<string>> list)
        {
            key = parameterConfigKey; 
            this.skinComboBox.WaterText = this.Title;
            this.skinComboBox.DisplayMember = "Key";
            this.skinComboBox.ValueMember = "Value";
            if (showAll) {
                if (list == null)
                {
                    list = new List<ListItem<string>>();
                }
                list.Insert(0, new ListItem<string>(CommonGlobalUtil.COMBOBOX_ALL, null));
            }
            this.skinComboBox.DataSource = list;
        }
    }
}
