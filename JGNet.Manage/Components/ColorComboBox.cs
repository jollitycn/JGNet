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
using CCWin.SkinControl; 
using JGNet.Core.InteractEntity;

namespace JGNet.Manage
{
    public partial class ColorComboBox : UserControl
    {

        public Boolean ShowAdd
        {
            get
            {
                return skinLabelAdd.Visible;
            }
            set
            {
                skinLabelAdd.Visible = value;
                if (value)
                {
                    this.skinComboBox_Color.WaterText = "点击“+”添加颜色";
                }
                else
                {
                    this.skinComboBox_Color.WaterText = String.Empty;
                }
            }
        }
         
        public CJBasic.Action<object, EventArgs> SelectionChangeCommitted;
        public bool HideEmpty { get; set; }
        public ColorComboBox()
        {
            InitializeComponent();
            this.skinComboBox_Color.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void DisableEvent()
        {
            this.skinComboBox_Color.SelectedIndexChanged -= SkinComboBox_SelectedIndexChanged;
            this.skinComboBox_Color.TextUpdate -= skinComboBox_Color_TextUpdate;
        }

        private void EnableEvent()
        {
            DisableEvent();
            this.skinComboBox_Color.SelectedIndexChanged += SkinComboBox_SelectedIndexChanged;
            this.skinComboBox_Color.TextUpdate += skinComboBox_Color_TextUpdate;
        }

        private void SkinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedIndexChanged?.Invoke(sender, e);
        }

        private void skinLabelAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                List<CostumeColor> list = (List<CostumeColor>)this.skinComboBox_Color.DataSource;
                AddCostumeColorComboBoxForm addForm = new AddCostumeColorComboBoxForm();
                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    if (list == null) { list = new List<CostumeColor>(); }
                    CostumeColor item = addForm.Result;
                    CostumeColor listItem = list.Find(t => t.Name == item.Name || t.ID == item.ID);
                    if (listItem == null)
                    {
                        InteractResult result = GlobalCache.CostumeColorList_OnChange(item);
                        switch (result.ExeResult)
                        {
                            case ExeResult.Success:
                                skinComboBox_Color.DataSource = null;
                                list.Add(item);
                                skinComboBox_Color.DisplayMember = "Name";
                                skinComboBox_Color.ValueMember = "ID";
                                skinComboBox_Color.DataSource = list;
                                skinComboBox_Color.SelectedIndex = list.IndexOf(item);
                                break;
                            case ExeResult.Error:
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        skinComboBox_Color.SelectedItem = listItem;
                    }
                }
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
            }
        }


        public EventHandler SelectedIndexChanged { get; internal set; }
        public  String SelectedValue
        {
            get
            {
                Object obj = this.skinComboBox_Color.SelectedValue;
                if (obj == null)
                {
                    return null;
                }
                return obj.ToString();
            }
            set
            {
                if (value != null)
                {
                    DisableEvent();
                    this.skinComboBox_Color.SelectedValue = value;
                    EnableEvent();
                }
            }
        }

        public String SelectedText
        {
            get {
                return this.skinComboBox_Color.SelectedText;
            }
            set
            {
                if (value != null)
                {
                    DisableEvent();
                    this.skinComboBox_Color.SelectedText = value;
                    EnableEvent();
                }
            }
        }

        public CostumeColor SelectedItem
        {
            get { return this.skinComboBox_Color.SelectedItem as CostumeColor; }
            set
            {
                if (value != null)
                {
                    DisableEvent();
                    this.skinComboBox_Color.SelectedItem = value;
                    EnableEvent();
                }
            }
        }


        internal void Initialize()
        {
            DisableEvent();
            SetCostumeColor(null);
            EnableEvent();
        }

        private void SetCostumeColor(string[] colors)
        {
            DisableEvent();
            CommonGlobalUtil.SetCostumeColor(skinComboBox_Color,hideAll,colors);
            EnableEvent();
        }

        private void skinComboBox_Color_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                List<CostumeColor> listNew = new List<CostumeColor>();
                //  skinComboBox_Brand.Items.Clear();
                SkinComboBox box = (SkinComboBox)sender;
                List<CostumeColor> temp = (List<CostumeColor>)box.DataSource;
                if(temp!= null && temp.Count == 0)
                {
                    box.DataSource = null;
                    return;
                }

                String str = box.Text;
                if (String.IsNullOrEmpty(str))
                {
                    listNew.AddRange( GlobalCache.CostumeColorList);
                }
                else
                {
                    foreach (var item in GlobalCache.CostumeColorList)
                    {
                        if ((item.ID + item.Name + item.FirstCharSpell).ToUpper().Contains(str.ToUpper()))
                        {
                            listNew.Add(item);
                        }
                    }
                }

                if (listNew.Count == 0)
                {
                    if (!HideEmpty)
                    {

                        listNew.Add(new CostumeColor()
                        {
                            ID = null,
                            Name = "（无）"
                        });
                    }
                }

                if (listNew == null || listNew.Count == 0)
                {
                    box.DataSource = null;
                    box.DisplayMember = null;
                    box.ValueMember = null;
                }
                else
                {
                    box.DataSource = null;
                    box.DisplayMember = "Name";
                    box.ValueMember = "ID";
                    box.DataSource = listNew;
                }
               
                box.Text = str;
                box.SelectionStart = str.Length;
                box.DroppedDown = true;//自动展开下拉框 
                //box.Cursor = Cursors.Default;

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                box.Cursor = System.Windows.Forms.Cursors.Default;
            }
            catch (Exception ex)
            {
              //  CommonGlobalUtil.ShowError(ex);
            }
        }

        private void skinComboBox_Color_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectionChangeCommitted?.Invoke(sender,e);
        }

        public void Filter(string[] colors)
        {
            SetCostumeColor(colors);
        }

        private void ColorComboBox_Load(object sender, EventArgs e)
        {
            Initialize();
        }


        private Boolean hideAll;
        public Boolean HideAll
        {
            get { return this.hideAll; }
            set
            {
                this.hideAll = value; 
            }
        }
         
    }
}
