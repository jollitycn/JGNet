using JGNet.Common.Core;
using JGNet.Common.Core.Util;
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
    public partial class AddCostumeClassForm : BaseForm
    {

        private Brand page;

        public Brand Result { get { return page; } }
        private TreeNode node;
        private OperationEnum action;
        private List<TreeNode> nodes = null;

        public AddCostumeClassForm(List<TreeNode> nodes, TreeNode node, OperationEnum action = OperationEnum.Add)
        {
            InitializeComponent();
            this.node = node;
            this.nodes = nodes;
            this.action = action;
            Initialize();
            skinTextBoxID.SkinTxt.TextChanged += SkinTxt_TextChanged;
        }

        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(skinTextBoxCode.Text))
            {
                skinTextBoxCode.Text = DisplayUtil.GetPYString(skinTextBoxID.Text);
            }
        }

        private void Initialize()
        {
            TreeNode parent = node.Parent;
            if (node.Level == 0)
            {
                parent = node;
            }

            if (action == OperationEnum.Edit)
            {
                skinTextBoxName.Text = parent.FullPath;
                this.Text = "修改类别";
                skinTextBoxID.Text = node.Text;
                if (node.Tag is CostumeClassInfo)
                {
                    CostumeClassInfo info = node.Tag as CostumeClassInfo;
                    costumeTextBoxSort.Value = info.OrderNo;
                    skinTextBoxCode.Text = info.ClassCode;
                }
                else if (node.Tag is SmallClass)
                {
                    SmallClass info = node.Tag as SmallClass;
                    costumeTextBoxSort.Value = info.OrderNo;
                    skinTextBoxCode.Text = info.ClassCode;
                }
                else if (node.Tag is SubSmallClass)
                {
                    SubSmallClass info = node.Tag as SubSmallClass;
                    costumeTextBoxSort.Value = info.OrderNo;
                    skinTextBoxCode.Text = info.ClassCode;
                }
            }
            else
            {
                skinTextBoxName.Text = node.FullPath;
                this.Text = "新增类别";
                skinTextBoxCode.Text = String.Empty;
                costumeTextBoxSort.Value = 100;
            }
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
                if (string.IsNullOrEmpty(skinTextBoxID.Text))
                {
                    GlobalMessageBox.Show("名称不能为空！");
                    this.skinTextBoxID.Focus();
                    return;
                }

                if (ValidateUtil.InputOutOfLimit(skinTextBoxID.Text, "名称", 10))
                {
                    this.skinTextBoxID.Focus();
                    return;
                }
                //if (string.IsNullOrEmpty(skinTextBoxCode.Text))
                //{
                //    MessageBox.Show("编码不能为空！");
                //    this.skinTextBoxCode.Focus();
                //    return;
                //}

                if (action == OperationEnum.Add)
                {
                    Add();
                }
                else
                {
                    Save();
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

        private void Save()
        {
            InteractResult result = null;

            //subSmallClass.ID = Int32.Parse(result.Msg);
            //TreeNode newNode = new TreeNode(subSmallClass.BigClass);
            //newNode.Tag = subSmallClass;
            //node.Nodes.Add(newNode);

            if (node.Level == 1)
            {
                CostumeClassInfo bigClass = node.Tag as CostumeClassInfo;
                UpdateBigClassPara para = new UpdateBigClassPara()
                { ID= bigClass.ID,  
                    NewClass = skinTextBoxID.Text,
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };

                result = GlobalCache.ServerProxy.UpdateBigCostumeClass(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        bigClass.BigClass = para.NewClass;
                        bigClass.ClassCode = para.ClassCode;
                        bigClass.OrderNo = para.OrderNo;
                        node.Text = para.NewClass;
                        node.Tag = bigClass;
                        this.DialogResult = DialogResult.OK;
                        break;
                    default:
                        break;
                }
            }
            else if (node.Level == 2)
            {
                SmallClass subSmallClass = node.Tag as SmallClass;
                UpdateSmallClassPara para = new UpdateSmallClassPara()
                {  ID = subSmallClass.ID, 
                    NewClass = skinTextBoxID.Text, 
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };
                result = GlobalCache.ServerProxy.UpdateSmallClass(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        subSmallClass.BigClass = node.Parent.Text;
                        subSmallClass.ClassCode = para.ClassCode;
                        subSmallClass.OrderNo = para.OrderNo;
                        subSmallClass.SmallClassStr = para.NewClass;
                        node.Text = para.NewClass;
                        node.Tag = subSmallClass;
                        this.DialogResult = DialogResult.OK;
                     
                        break;
                    default:
                        break;
                }
            }
            else if (node.Level == 3)
            {
                SubSmallClass subSmallClass = node.Tag as SubSmallClass;
                UpdateSubSmallClassPara para = new UpdateSubSmallClassPara()
                {   ID = subSmallClass.ID, 
                    NewClass = skinTextBoxID.Text, 
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };

                result = GlobalCache.ServerProxy.UpdateSubSmallClass(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        subSmallClass.ID = para.ID;
                        subSmallClass.ClassCode = para.ClassCode;
                        subSmallClass.OrderNo = para.OrderNo;
                        subSmallClass.SubSmallClassStr = para.NewClass;
                        node.Text = para.NewClass;
                        node.Tag = subSmallClass;
                        this.DialogResult = DialogResult.OK;
                        break;
                    default:
                        break;
                }
            }
        }

        private void UpdateNode(UpdateBigClassPara para)
        {
            CostumeClassInfo subSmallClass = node.Tag as CostumeClassInfo;
            subSmallClass.BigClass = para.NewClass;
            subSmallClass.ClassCode = para.ClassCode;
            subSmallClass.OrderNo = para.OrderNo;
        }

        private void Add()
        {
            InteractResult result = null;

            if (node.Level == 0)
            {
                InsertCostumeClassPara para = new InsertCostumeClassPara()
                {
                    BigClass = skinTextBoxID.Text,
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };
                CostumeClassInfo subSmallClass = new CostumeClassInfo()
                {
                    BigClass = skinTextBoxID.Text,
                    SmallClass = new List<SmallClass>(),
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };


                result = GlobalCache.ServerProxy.InsertBigCostumeClass(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        subSmallClass.ID = Int32.Parse( result.Msg);
                        TreeNode newNode = new TreeNode(subSmallClass.BigClass);
                        newNode.Tag = subSmallClass;
                        node.Nodes.Add(newNode);
                        this.DialogResult = DialogResult.OK;
                        break;
                    default:
                        break;
                }
            }
            else if (node.Level == 1)
            {
                InsertSmallClassPara para = new InsertSmallClassPara()
                {
                    ParentAutoID = (node.Tag as CostumeClassInfo).ID,  
                    SmallClass = skinTextBoxID.Text,
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };

                SmallClass subSmallClass = new SmallClass()
                {
                    SubSmallClass = new List<SubSmallClass>(),
                    BigClass = node.Text,
                    SmallClassStr = skinTextBoxID.Text,
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };

                result = GlobalCache.ServerProxy.InsertSmallClass(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        subSmallClass.ID = Int32.Parse(result.Msg);
                        TreeNode newNode = new TreeNode(subSmallClass.SmallClassStr);
                        newNode.Tag = subSmallClass;
                        node.Nodes.Add(newNode);
                        this.DialogResult = DialogResult.OK;
                        break;
                    default:
                        break;
                }
            }
            else if (node.Level == 2)
            {
                InsertSubSmallClassPara para = new InsertSubSmallClassPara()
                { ParentAutoID = (node.Tag as  SmallClass).ID, 
                    //BigClass = node.Parent.Text,
                    //SmallClass = node.Text,
                    SubSmallClass = skinTextBoxID.Text,
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };

                SubSmallClass subSmallClass = new SubSmallClass()
                {
                    BigClass = node.Parent.Text,
                    SmallClass = node.Text,
                    SubSmallClassStr = skinTextBoxID.Text,
                    OrderNo = Decimal.ToInt32(costumeTextBoxSort.Value),
                    ClassCode = skinTextBoxCode.Text
                };

                result = GlobalCache.ServerProxy.InsertSubSmallClass(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        subSmallClass.ID = Int32.Parse(result.Msg);
                        TreeNode newNode = new TreeNode(subSmallClass.SubSmallClassStr);
                        newNode.Tag = subSmallClass;
                        node.Nodes.Add(newNode);
                        SmallClass smallClass = node.Tag as SmallClass;
                        if (smallClass.SubSmallClass != null)
                        {
                            smallClass.SubSmallClass.Add(subSmallClass);
                        }
                        this.DialogResult = DialogResult.OK;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
