using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using CJBasic.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class SizeGroupEditForm : BaseForm
    {
        private SizeGroup CurItem { get; set; }
        public SizeGroupEditForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        public void Display()
        {
            try
            {
                if (CurItem != null)
                {
                    if (readOnly)
                    {
                        this.BaseButtonSave.Visible = false;
                        baseButtonCancel.Visible = false;
                    }

                    this.Text = "编辑尺码组";
                    textBoxSizeGroupName.Text = CurItem.ShowName;
                    textBoxDesc.Text = CurItem.Comment;
                    txtSize1.Text = CurItem.NameOfF;
                    txtSize2.Text = CurItem.NameOfXS;
                    txtSize3.Text = CurItem.NameOfS;
                    txtSize4.Text = CurItem.NameOfM;
                    txtSize5.Text = CurItem.NameOfL;
                    txtSize6.Text = CurItem.NameOfXL;
                    txtSize7.Text = CurItem.NameOfXL2;
                    txtSize8.Text = CurItem.NameOfXL3;
                    txtSize9.Text = CurItem.NameOfXL4;
                    txtSize10.Text = CurItem.NameOfXL5;
                    txtSize11.Text = CurItem.NameOfXL6;
                }
                
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }


        private void Initialize()
        { 
            this.txtSize2.Text = String.Empty;
        } 


        private List<ListItem<String>> ParameterConfigList(List<ListItem<String>> listItems)
        {
            List<ListItem<String>> list = new List<ListItem<String>>();
            //  list.Add(new ListItem<String>(GlobalCache.COMBOX_FIRST_LINE, null));
            list.AddRange(listItems);
            return list;
        }

        Costume item = null; 
        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                SizeGroup para = new SizeGroup()
                {
                    ShowName = textBoxSizeGroupName.Text.Trim(),
                    Comment = textBoxDesc.Text.Trim(),
                    NameOfF = txtSize1.Text.Trim(),
                    NameOfXS = txtSize2.Text.Trim(),
                    NameOfS = txtSize3.Text.Trim(),
                    NameOfM = txtSize4.Text.Trim(),
                    NameOfL = txtSize5.Text.Trim(),
                    NameOfXL = txtSize6.Text.Trim(),
                    NameOfXL2 = txtSize7.Text.Trim(),
                    NameOfXL3 = txtSize8.Text.Trim(),
                    NameOfXL4 = txtSize9.Text.Trim(),
                    NameOfXL5 = txtSize10.Text.Trim(),
                    NameOfXL6 = txtSize11.Text.Trim(),
                };
                if (!Validate(para)) { return; }
                 
                    if (CurItem != null)
                {
                    para.SizeGroupName = CurItem.SizeGroupName;
                    para.Enabled = CurItem.Enabled;
                    InteractResult result = GlobalCache.ServerProxy.UpdateSizeGroup(para);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("保存成功！");
                            GlobalCache.UpdateSizeGroup(para);
                            this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    para.Enabled  = true;
                    InteractResult result = GlobalCache.ServerProxy.InsertSizeGroup(para);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("保存成功！");
                            para.SizeGroupName = result.Msg;
                            GlobalCache.InsertSizeGroup(para);
                            this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
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

        private bool Validate(SizeGroup item)
        {
            bool success = true;
            if (String.IsNullOrEmpty(this.textBoxSizeGroupName.Text))
            {
                textBoxSizeGroupName.Focus();
                success = false;
                GlobalMessageBox.Show("尺码组名称不能为空！");
            }
            else if (ValidateUtil.InputOutOfLimit(this.textBoxSizeGroupName.Text, "尺码组名称", 20))
            {
                textBoxSizeGroupName.Focus();
                success = false;
                GlobalMessageBox.Show("尺码组名称不能为空！");
            }

            return success;
        }

        bool readOnly = false;
        internal DialogResult ShowDialog(SizeGroup item,bool readOnly)
        {
            this.readOnly = readOnly;
            this.CurItem = item;
            Display();
        
            return  this.ShowDialog();
        }

        public void ShowNew(Control parent)
        {
            try
            {
                this.TopMost = true;
                this.ShowDialog(parent);
                //ctrl.Search(para);
                this.TopMost = false;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }


        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierAccountSearchForm_Shown(object sender, EventArgs e)
        {
            if (CurItem != null)
            {
                if (
                readOnly) { 
                skinPanel1.Enabled = false;
                }
                //this. = false;
            }
        }
         
    }
}
