using JGNet.Common.Core;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using JGNet.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common.Components
{
    public partial class AddCostumeColorForm : BaseForm
    {
         
     
        public CostumeColor Result { get { return color; } }

        private CostumeColor color;
        private OperationEnum action;
        public AddCostumeColorForm(CostumeColor color = null, OperationEnum action = OperationEnum.Add)
        {
            InitializeComponent();
            this.color = color;
            this.action = action;

            Initialize();
        }

        private void Initialize()
        {
            if (action == OperationEnum.Edit)
            {
                skinTextBoxID.Text = color.ID;
                skinTextBoxName.Text = color.Name;
                skinTextBoxID.Enabled = false;
            }
            else
            {
                skinTextBoxName.Text = string.Empty;
                skinTextBoxID.Text = this.GetNewColorID();
            }
        }

        private String GetNewColorID()
        {
            String id = string.Empty;
            try
            {
                InteractResult result = GlobalCache.ServerProxy.GetCostumeColorId();
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        id = result.Msg;
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
                GlobalUtil.ShowError(ex);
            }
            return id;
        }


        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButton1_Click(null, null);
            }
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = skinTextBoxName.Text;
                string id = skinTextBoxID.Text;

                List<CostumeColor> costumeColor = GlobalCache.CostumeColorList;

                if (string.IsNullOrEmpty(id))
                {
                    GlobalMessageBox.Show("色号不能为空！");
                    this.skinTextBoxID.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(name))
                {
                    GlobalMessageBox.Show("名称不能为空！");
                    this.skinTextBoxName.Focus();
                    return;
                }
                else
                {

                    if (this.color != null)
                    {

                        //编辑的时候，判断是否有重复ID。排除自己
                       List< CostumeColor> colorChecked = costumeColor.FindAll(t => t.ID == id);
                        if (colorChecked != null && colorChecked.Count > 1)
                        {
                            GlobalMessageBox.Show("该色号已存在！");
                            this.skinTextBoxID.Focus();
                            return;
                        }
                    }
                    else
                    {
                        CostumeColor colorChecked = costumeColor.Find(t => t.ID == id);
                        if (colorChecked != null)
                        {
                            GlobalMessageBox.Show("该色号已存在！");
                            this.skinTextBoxID.Focus();
                            return;
                        }
                    }

                    if (this.color != null)
                    {

                        //编辑的时候，判断是否有重复ID。排除自己
                        List<CostumeColor> colorChecked = costumeColor.FindAll(t => t.Name == name);
                        if (colorChecked != null && colorChecked.Count > 1)
                        {
                            GlobalMessageBox.Show("名称已存在！");
                            this.skinTextBoxName.Focus();
                            return;
                        }
                    }
                    else
                    {
                        CostumeColor colorChecked = costumeColor.Find(t => t.Name == name);
                        if (colorChecked != null)
                        {
                            GlobalMessageBox.Show("名称已存在！");
                            this.skinTextBoxName.Focus();
                            return;
                        }
                    }
                }




                if (action == OperationEnum.Edit)
                {
                    color.ID = id;
                    color.Name = name;
                    color.FirstCharSpell = DisplayUtil.GetPYString(name);
                }
                else
                {
                    this.color = new CostumeColor()
                    {
                        ID = id,
                        Name = name,
                        FirstCharSpell = DisplayUtil.GetPYString(name),
                    };

                }

                this.DialogResult = DialogResult.OK;
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

    }
}
