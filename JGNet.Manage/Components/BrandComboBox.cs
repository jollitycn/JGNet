using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Manage.Components;
using JGNet.Common;
using JGNet.Common.Components;

namespace JGNet.Manage
{
    public partial class BrandComboBox : UserControl
    {

        public Boolean ShowAdd { get { return skinLabelAdd.Visible; } set { skinLabelAdd.Visible = value; } }

        public bool ShowAll { get { return skinComboBox.ShowAll; } set { skinComboBox.ShowAll = value; } }
        public ComboBoxStyle DropDownStyle
        {
            get { return skinComboBox.DropDownStyle; }
            set { skinComboBox.DropDownStyle = value; }
        }

        public AutoCompleteMode AutoCompleteMode
        {
            get { return skinComboBox.AutoCompleteMode; }
            set
            {
                skinComboBox.AutoCompleteMode = value;
                if (skinComboBox.AutoCompleteMode == AutoCompleteMode.None)
                {
                    skinComboBox.AutoCompleteSource = AutoCompleteSource.None;
                }
            }
        }

        public BrandComboBox()
        {
            InitializeComponent();

            this.skinComboBox.SelectedIndexChanged += SkinComboBox_SelectedIndexChanged;
        }

        private void SkinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedIndexChanged?.Invoke(sender, e);
        }

        private void skinLabelAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                CostumeAddBrandForm addForm = new CostumeAddBrandForm();
                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    List<Brand> list = (List<Brand>)this.skinComboBox.DataSource;
                    if (list == null) { list = new List<Brand>(); }
                    Brand value = addForm.Result;
                    //从所有品牌中查找
                    Brand listItem = CommonGlobalCache.BrandList.Find(t => t.Name == value.Name);
                    if (listItem == null)
                    {

                        //   Brand item = new Brand() { Name = value, FirstCharSpell = DisplayUtil.GetPYString(value) };
                        InsertResult result = GlobalCache.BrandList_OnInsert(value);
                        switch (result)
                        {
                            case InsertResult.Success:
                                this.skinComboBox.DataSource = null;
                                list.Add(value);
                                this.skinComboBox.DisplayMember = "Name";
                                this.skinComboBox.ValueMember = "AutoID";
                                this.skinComboBox.DataSource = list;
                                this.skinComboBox.SelectedIndex = list.IndexOf(value);
                                break;
                            case InsertResult.Error:
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        GlobalMessageBox.Show("品牌已存在");
                        //this.skinComboBox.SelectedItem = listItem;
                    }
                }
            }
            catch (Exception ex)
            {
                // GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }

        }

        public EventHandler SelectedIndexChanged { get; set; }
        public object SelectedValue
        {
            get { return this.skinComboBox.SelectedValue; }
            set
            {
                if (value != null) { this.skinComboBox.SelectedValue = value; }
            }
        }

        public Brand SelectedItem
        {
            get { return this.skinComboBox.SelectedItem as Brand; }
            set
            {
                if (value != null) { this.skinComboBox.SelectedItem = value; }
            }
        }

        private void Initialize()
        {
            GlobalUtil.SetBrand(skinComboBox, !ShowAll);
        }

        private void BrandComboBox_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void BrandComboBox_SizeChanged(object sender, EventArgs e)
        {
            skinComboBox.Width = this.Width - 5 - skinLabelAdd.Width;
        }
    }
}
