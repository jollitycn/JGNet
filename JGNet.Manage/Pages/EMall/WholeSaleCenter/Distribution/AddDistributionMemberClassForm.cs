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
    public partial class AddDistributionMemberClassForm : BaseForm
    {

        private Brand page;

        public Brand Result { get { return page; } }
        private TreeNode node;
        private OperationEnum action;
        private List<TreeNode> nodes = null;

        public AddDistributionMemberClassForm(List<TreeNode> nodes, TreeNode node, OperationEnum action = OperationEnum.Add)
        {
            InitializeComponent();
            this.node = node;
            this.nodes = nodes;
            this.action = action;
            Initialize();
           // skinTextBoxID.SkinTxt.TextChanged += SkinTxt_TextChanged;
        }

        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
           /* if (String.IsNullOrEmpty(skinTextBoxName.Text))
            {
                skinTextBoxName.Text = DisplayUtil.GetPYString(skinTextBoxID.Text);
            }*/
        }

        private void Initialize()
        {
            TreeNode parent = node.Parent;
            if (node.Text == "所有分销人员")
            {

            }
            if (node.Level == 0)
            {
                parent = node;
            }

            if (action == OperationEnum.Edit)
            {
              //  skinTextBoxName.Text = parent.FullPath;
                this.Text = "编辑";
                TreeModel CurClass = node.Tag as TreeModel;
                Member curMember=GlobalCache.ServerProxy.GetOneMember(CurClass.ID);
                this.skinTextBoxID.Enabled = false;
                skinTextBoxID.SkinTxt.Text =CurClass.ID;
                 skinTextBoxName.SkinTxt.Text= curMember.Name; 
            }
            else
            {
                skinTextBoxName.Text = node.FullPath;
                this.Text = "新增下线会员";
                skinTextBoxName.Text = String.Empty;
               // costumeTextBoxSort.Value = 100;
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
                    GlobalMessageBox.Show("卡号不能为空！");
                    this.skinTextBoxID.Focus();
                    return;
                }
                 
                if (string.IsNullOrEmpty(skinTextBoxName.Text))
                {
                    MessageBox.Show("姓名不能为空！");
                    this.skinTextBoxName.Focus();
                    return;
                }

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
            TreeModel bigClass = node.Tag as TreeModel;
            string memberNumber = skinTextBoxID.SkinTxt.Text.Trim();
            string memberName = skinTextBoxName.SkinTxt.Text.Trim();
            InteractResult result = GlobalCache.ServerProxy.UpdateMemberName(memberNumber, memberName);
            switch (result.ExeResult)
            {
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                case ExeResult.Success:
                    //  bigClass.BigClass = para.NewClass;
                  List<TreeModel>  lTreeModel= CommonGlobalCache.DistributorList.FindAll(t => t.ID == memberNumber);
                    bigClass.ID = memberNumber;
                    bigClass.Name = memberName;
                    string accruedC = "0.00";
                   Member editM=GlobalCache.ServerProxy.GetOneMember(memberNumber);
                    //  if (lTreeModel.Count > 0) { accruedC=lTreeModel[0].AccruedCommission.ToString(); }
                    if (editM != null) {
                        accruedC = editM.AccruedCommission.ToString();
                    }
                    node.Text = memberName+"/"+memberNumber+"("+ accruedC + ")" ;
                    node.Tag = bigClass;

                    CommonGlobalCache.UpdateDistributor(bigClass);
                    this.DialogResult = DialogResult.OK;
                    break;
                default:
                    break;
            }
            
        } 

        private void Add()
        {
              

            TreeModel CurClass = node.Tag as TreeModel;

            string memberNumber = skinTextBoxID.SkinTxt.Text.Trim();
            string memberName = skinTextBoxName.SkinTxt.Text.Trim();
            if (CurClass.Name == "所有分销人员")
            {
                CurClass.ID = null;
            }
                InteractResult result = GlobalCache.ServerProxy.AddMember4Distribution(CurClass.ID, memberNumber, memberName);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        TreeModel CurChildrenClass = new TreeModel();
                       TreeNode newNode = new TreeNode(memberName);
                        CurChildrenClass.Name = memberName;
                        CurChildrenClass.ID = memberNumber;
                        CurChildrenClass.ParentID = CurClass.ID;
                        newNode.Tag = CurChildrenClass;
                    newNode.Text = memberName + "/" + memberNumber+"(0.00)";
                        node.Nodes.Add(newNode);
                        CommonGlobalCache.InsertDistributor(CurChildrenClass);
                        this.DialogResult = DialogResult.OK;
                        break;
                    default:
                        break;
                }
            
          
        }

        private void baseButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
