using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.InteractEntity;
using JGNet.Manage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JGNet.Manage.Pages.Setting.BasicSettings.Costume
{
    public partial class SizeGroupSelectForm : BaseForm
    { 
        private SizeGroupSetting result;
        public SizeGroupSetting Result
        {
            get { return result; }
        }

        private string costumeID;
        public SizeGroupSelectForm(SizeGroupSetting selectSizeGroup,String costumeID)
        {
            InitializeComponent();
            SetSize();
           
            if (selectSizeGroup != null && selectSizeGroup.SizeGroup != null)
            {
                skinComboBoxSizeGroup.SelectedItem = selectSizeGroup.SizeGroup;
            }

            this.costumeID = costumeID;
            this.result = selectSizeGroup;
        }

        private void SizeForm_Load(object sender, EventArgs e)
        {
                CheckCheckBox();
        }

        private void CheckCheckBox()
        {
            if (result != null && result.Items!=null)
            {
                foreach (var item in this.panel1.Controls)
                {
                    CheckBox box = item as CheckBox;
                    if (box != null)
                    {
                        if (result.Items.Contains(box.Tag.ToString()))
                        {
                            box.Checked = true;
                        }
                        else
                        {
                            box.Checked = false;
                        }
                    }
                }
            }
        }

        private void SetSize()
        {
            skinComboBoxSizeGroup.ValueMember = "SizeGroupName";
            skinComboBoxSizeGroup.DisplayMember = "DisplayName";
            skinComboBoxSizeGroup.DataSource = GlobalCache.SizeGroupList?.FindAll(t => t.Enabled);
            //skinComboBoxSizeGroup.SelectedItem = GlobalCache.GetSizeGroup(this.CurItem?.SizeGroupName);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.result = new SizeGroupSetting()
            {
                SizeGroup = this.skinComboBoxSizeGroup.SelectedItem as SizeGroup,
                Items = GetCheckBoxTags()
            };


            if (result.Items == null || result.Items.Count == 0)
            {
                GlobalMessageBox.Show("请至少选择一个尺码！");
                return;
            }

            if (!String.IsNullOrEmpty(costumeID))
            {
                InteractResult interactResult = GlobalCache.ServerProxy.CheckCostumeSize(this.costumeID, result.SizeGroup.SizeGroupName, GetUnCheckBoxTags());
                switch (interactResult.ExeResult)
                {
                    case ExeResult.Success:
                        this.DialogResult = DialogResult.OK;
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(interactResult.Msg);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private List<string> GetCheckBoxTags()
        {
            List<string> list = new List<string>();
            foreach (var item in this.panel1.Controls)
            {
                CheckBox box = item as CheckBox;
                if (box.Checked) {
                    list.Add(box.Tag.ToString());
                }
            }

            return list;
        }

        private List<string> GetUnCheckBoxTags()
        {
            List<string> list = new List<string>();
            foreach (var item in this.panel1.Controls)
            {
                CheckBox box = item as CheckBox;
                if (!box.Checked)
                {
                    list.Add(box.Tag.ToString());
                }
            }

            return list;
        }


        private void baseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinComboBoxSizeGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCheckBoxNamesAndState();
        }

        private void ChangeCheckBoxNamesAndState()
        {
            SizeGroup sizeGroup = skinComboBoxSizeGroup.SelectedItem as SizeGroup;

            int index = 0;
            foreach (var sizeName in CostumeStoreHelper.CostumeSizeColumn)
            {
                CheckBox box = this.panel1.Controls[index++] as CheckBox;
                box.Checked = false;
                box.Text = ReflectUtil.GetModelValue("NameOf" + sizeName, sizeGroup);
                box.Tag = sizeName;
            }
        }
    }
}
