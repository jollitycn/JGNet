using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core; 
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core.Util;
using JGNet.Core.Const;
using JieXi.Common;
using CJBasic;
using JGNet.Core.Tools;

namespace JGNet.Manage.Pages
{
    public partial class RetailDistributorCtrl : BaseModifyUserControl
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public RetailDistributorCtrl()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.分销人员管理;
             
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView3, new string[] {
                accruedCommissionDataGridViewTextBoxColumn2.DataPropertyName , remainingCommissionDataGridViewTextBoxColumn2.DataPropertyName,
                withdrawCommissionDataGridViewTextBoxColumn2.DataPropertyName

            });
            dataGridView3.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.Initialize();
        }

        List<TreeNode> allNodes = null;
        private void PermissonCtrl_Load(object sender, EventArgs e)
        {
            TreeNode e2 = new TreeNode();
            Initialize(out e2);
        }

        private void Initialize(out TreeNode node,string SelectStr="" )
        {
            
            skinTreeViewClass.Nodes.Clear();
            skinTreeViewClass.Nodes.AddRange(DistributorClassUtil.GetTreeNodes(out node,SelectStr).ToArray());
            allNodes = WinformUIUtil.GetAllTreeNodes(skinTreeViewClass.Nodes);
            skinTreeViewClass.Nodes[0].ExpandAll();
            SetUnconsumedDays();
            SetCommissionBox();
        }
        private void SetUnconsumedDays()
        {

            List<ListItem<int>> list = new List<ListItem<int>>();
            list.Add(new ListItem<int>("所有", -1));
            list.Add(new ListItem<int>("从未消费", -2));
            list.Add(new ListItem<int>("0天以上", 0));
            list.Add(new ListItem<int>("30天以上", 30));
            list.Add(new ListItem<int>("60天以上", 60));
            list.Add(new ListItem<int>("90天以上", 90));
            list.Add(new ListItem<int>("180天以上", 180));
            this.unconsumedComboBox.DisplayMember = "Key";
            this.unconsumedComboBox.ValueMember = "Value";
            this.unconsumedComboBox.DataSource = list;
        }
        private void SetCommissionBox()
        {

            List<ListItem<SeeCommission>> stateList = new List<ListItem<SeeCommission>>();
            stateList.Add(new ListItem<SeeCommission>(EnumHelper.GetDescription(JGNet.Core.InteractEntity.SeeCommission.All), JGNet.Core.InteractEntity.SeeCommission.All));
            stateList.Add(new ListItem<SeeCommission>(EnumHelper.GetDescription(JGNet.Core.InteractEntity.SeeCommission.True), JGNet.Core.InteractEntity.SeeCommission.True));
            stateList.Add(new ListItem<SeeCommission>(EnumHelper.GetDescription(JGNet.Core.InteractEntity.SeeCommission.False), JGNet.Core.InteractEntity.SeeCommission.False));
            this.skinComboBoxCommission.DisplayMember = "Key";
            this.skinComboBoxCommission.ValueMember = "Value";
            this.skinComboBoxCommission.DataSource = stateList;

           
            //skinComboBoxCommission
        }
        private void skinTreeViewClass_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            skinTreeViewClass.SelectedNode = e.Node;

            修改ToolStripMenuItem.Visible = e.Node.Level != 0;
            /*   刪除ToolStripMenuItem.Visible = e.Node.Level != 0;

               TreeModel info = e.Node.Tag as TreeModel;
               if (  info.Childrens.Count>0)
               {*/
            刪除ToolStripMenuItem.Visible = false;
            /*  }
              else
              {
                  刪除ToolStripMenuItem.Visible = true;
              }*/
            if (e.Node.Text == "所有分销人员")
            {

                TreeModel CurClass = new TreeModel();
                CurClass.ID = "0";
                CurClass.Name = "所有分销人员";
                e.Node.Tag = CurClass;


                刷新ToolStripMenuItem.Visible = true;
            }
            else
            {
                刷新ToolStripMenuItem.Visible = false;
            }

            if (!HasPermission(RolePermissionEnum.新增下线))
            {
                新增ToolStripMenuItem.Enabled = false;
            }
            新增ToolStripMenuItem.Visible = e.Node.Level < 11;
            if ((e.Node.Level != 0 && e.Node.Level >= 11)) { 新增ToolStripMenuItem.Visible = false; }
            else
            {
                新增ToolStripMenuItem.Visible = true;
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = skinTreeViewClass.SelectedNode;

            AddDistributionMemberClassForm form = new AddDistributionMemberClassForm(allNodes, node);

            form.ShowDialog();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = skinTreeViewClass.SelectedNode;
            AddDistributionMemberClassForm form = new AddDistributionMemberClassForm(allNodes, node, OperationEnum.Edit);
            form.ShowDialog();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void baseButtonImport_Click(object sender, EventArgs e)
        {

        }



        private String path;
        private void DoImport()
        {

        }

        private new void RefreshPage()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.RefreshPage));
            }
            else
            {
                TreeNode t = new TreeNode();
                Initialize(out t);
            }
        }



        private void baseButton1_Click(object sender, EventArgs e)
        {

        }
        private void DoExport()
        {

        }

        private void check(TreeNode tNode, string name,out bool ischeck,out TreeNode selectNode)
        {
            ischeck = false;
            bool isflag = false;
            selectNode = null;
            foreach (TreeNode titem in tNode.Nodes)
            {
                string[] list=titem.Text.Split('/');


                if (list.Length > 1)
                {
                    for (int i = 0; i < list.Length; i++)
                    {

                        if (list[i].Split('(').Length > 0 && list[i].Split('(')[0] == name && i == 1)
                        {
                            this.skinTreeViewClass.SelectedNode = titem;
                            // this.skinTreeViewClass.Focus();
                            selectNode = titem;
                            ischeck = true;
                            isflag = true;
                            break;
                        }
                        else
                        {
                            if (!ischeck)
                            {
                                check(titem, name, out ischeck,out selectNode);
                            }
                        }
                        //else
                        //{
                        //    if (list[i].Split('(').Length > 0)
                        //    {
                        //        if (list[i].Split('(')[0] == name)
                        //        {
                        //            this.skinTreeViewClass.SelectedNode = titem;
                        //            ischeck = true;

                        //            //   this.skinTreeViewClass.Focus();
                        //            isflag = true;
                        //            break;
                        //        }
                        //    }
                        //}
                    }
                    if (isflag) { break; }
                  
                }
                else
                {
                    if (!ischeck)
                    {
                        check(titem, name, out ischeck,out selectNode);
                    }
                }


                /*   if (list.Length > 0)
                   {
                       for (int i = 0; i < list.Length; i++)
                       {

                           if (list[i] == name && i == 0)
                           {
                               this.skinTreeViewClass.SelectedNode = titem;
                               // this.skinTreeViewClass.Focus();
                               ischeck = true;
                               isflag = true;
                               break;
                           }
                           else
                           {
                               if (list[i].Split('(').Length > 0)
                               {
                                   if (list[i].Split('(')[0] == name)
                                   {
                                       this.skinTreeViewClass.SelectedNode = titem;
                                       ischeck = true;

                                       //   this.skinTreeViewClass.Focus();
                                       isflag = true;
                                       break;
                                   }
                               }
                           }
                       }
                       if (isflag) { break; }
                       else
                       {
                           if (!ischeck)
                           {
                               check(titem, name, out ischeck);
                           }
                       }
                   }
                   else
                   {
                       if (!ischeck)
                       {
                           check(titem, name, out ischeck);
                       }
                   }*/

            }
        }
        GetDistributors4MemberPara para;
        private void BaseButton3_Click(object sender, EventArgs e)
        {

 string telStr = this.skinTextBoxTitle.Text;
            string nameStr = this.textBoxName.Text;



             para = new GetDistributors4MemberPara() { Phone = telStr,
                Name = nameStr,
                NoRetailDay = Convert.ToInt32(this.unconsumedComboBox.SelectedValue),
                 SeeCommission=(SeeCommission)this.skinComboBoxCommission.SelectedValue,
            };
          InteractResult<List<Member>>  mList=  CommonGlobalCache.ServerProxy.GetDistributors4Member(para);
            if (mList.ExeResult == ExeResult.Success)
            {
                if (mList != null)
                {
                    dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(mList.Data));
                }
            }
            /*
             bool ischeck = false;
             if (nameStr != "")
             {

                 TreeNode ew = null;
                 //Initialize(out ew,nameStr);
                 bool isflag = false;
                 TreeNodeCollection tCol=this.skinTreeViewClass.Nodes;
                 foreach (TreeNode treeNode in tCol)
                 {

                     string[] list = treeNode.Text.Split('/');
                     if (list.Length > 0)
                     {
                         for (int i=0;i<list.Length;i++)
                         {

                             if (list[i] == nameStr && i == 0)
                             {
                                 this.skinTreeViewClass.SelectedNode = treeNode;
                                 ischeck = true;
                                 // this.skinTreeViewClass.Focus();
                                 isflag = true;
                                 break;
                             }
                             else
                             {
                                 if (list[i].Split('(').Length > 0)
                                 {
                                     if (list[i].Split('(')[0] == nameStr)
                                     {
                                         this.skinTreeViewClass.SelectedNode = treeNode;
                                         ischeck = true;
                                         isflag = true;
                                         break;
                                     }
                                 }
                             }

                         }
                         if (isflag) { break; }
                         else
                         {
                             check(treeNode, nameStr,out ischeck);
                         }
                     }
                     else
                     {
                         check(treeNode, nameStr,out ischeck);
                     }
                 }
                 if (!ischeck)
                 {
                     this.skinTreeViewClass.SelectedNode = tCol[0];
                 }
                 this.skinTreeViewClass.Focus();

                 //  skinTreeViewClass.SelectedNode = ew;
             }*/
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                List<Member> memberList = DataGridViewUtil.BindingListToList<Member>(dataGridView3.DataSource);
               // List<Member> memberList = (List<Member>)this.dataGridView3.DataSource;
                    Member Mitem = memberList[e.RowIndex];
                if (e.ColumnIndex == Column2.Index)
                {
                    if (curSelectNode != null)
                    {
                        AddDistributionMemberClassForm form = new AddDistributionMemberClassForm(allNodes, curSelectNode, OperationEnum.Edit);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            InteractResult<List<Member>> mList = CommonGlobalCache.ServerProxy.GetDistributors4Member(para);
                            if (mList.ExeResult == ExeResult.Success)
                            {
                                if (mList != null)
                                {
                                    //this.dataGridViewTextBoxColumn1.Visible = true;
                                    List<Member> ListMember = mList.Data;
                                    //foreach (PfCustomer Pitem in ListPfCustomer)
                                    //{
                                    //    Pitem.CustomerCode = Pitem.ID;
                                    //}
                                    dataGridViewPagingSumCtrl.BindingDataSource(ListMember);
                                    this.dataGridView3.CurrentCell = this.dataGridView3.Rows[e.RowIndex].Cells[1];

                                    this.dataGridView3.Rows[e.RowIndex].Selected = true;
                                }
                            }
                        }
                        // form.ShowDialog();
                    }
                }
                else if (e.ColumnIndex == Column1.Index)
                {
                    GetDistributorsPara para = new GetDistributorsPara() { StartTime = new Date("1900-01-01"), EndTime = new Date(DateTime.Now) };

                    RetailCommissionDetailForm form = new RetailCommissionDetailForm(para);
                    // form.PfCustomerRechargeRecordSuccess += WholesaleCustomerRechargeForm_PfCustomerRechargeRecordSuccess;


                    form.ShowDialog(Mitem.PhoneNumber);
                }
               /* else if (e.ColumnIndex == seeCommissionDataGridViewCheckBoxColumn2.Index)
                {
                    Mitem.SeeCommission = (bool)this.dataGridView3[e.ColumnIndex, e.RowIndex].Value;
                    UpIsCheck(Mitem.PhoneNumber, Mitem.SeeCommission);
                }*/

            }
        }
        #region    //设置是否热卖
        private void UpIsCheck(string itemID, bool isSee)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = CommonGlobalCache.ServerProxy.UpdateMemberSeeCommission(itemID, isSee);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
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
        #endregion
        DataGridViewRow currRow = null;
        Member Memitem;
        TreeNode curSelectNode=null;
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.CurrentRow;

            ///不重复提交  DataGridViewRow row = view.CurrentRow;

            if (row==null) return;
            if (view.CurrentCell.ColumnIndex == 6)
            { 
                DataGridViewCheckBoxColumn curColumn = (DataGridViewCheckBoxColumn)view.Columns[6];
                curColumn.Selected = !curColumn.Selected; 
            }
            else
            {
                if (row != null && row.Index > -1 && row != currRow)
                {
                    Memitem = (Member)row.DataBoundItem;

                    bool ischeck = false;

                    TreeNode selectNode = null;
                    TreeNode ew = null;
                    //Initialize(out ew,nameStr);
                    bool isflag = false;
                    TreeNodeCollection tCol = this.skinTreeViewClass.Nodes;
                    foreach (TreeNode treeNode in tCol)
                    {

                        string[] list = treeNode.Text.Split('/');


                        if (list.Length > 1)
                        {
                            for (int i = 0; i < list.Length; i++)
                            {

                                if (list[i].Split('(').Length > 0 && list[i].Split('(')[0] == Memitem.PhoneNumber && i == 1)
                                {
                                    this.skinTreeViewClass.SelectedNode = treeNode;
                                    ischeck = true;
                                    selectNode = treeNode;
                                    curSelectNode = treeNode;
                                    // this.skinTreeViewClass.Focus();
                                    isflag = true;
                                    break;
                                }
                                else
                                {
                                    check(treeNode, Memitem.PhoneNumber, out ischeck, out selectNode);
                                    if (selectNode != null)
                                    {
                                        curSelectNode = selectNode;
                                    }
                                }

                            }
                            if (isflag) { break; }
                           
                        }
                        else
                        {
                            check(treeNode, Memitem.PhoneNumber, out ischeck, out selectNode);
                            if (selectNode != null)
                            {
                                curSelectNode = selectNode;
                            }
                        }
                    }
                    if (!ischeck)
                    {
                        this.skinTreeViewClass.SelectedNode = tCol[0];
                    }
                    this.skinTreeViewClass.Focus();
                  

                }
            }
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridView3.SelectionChanged -= new EventHandler(dataGridView3_SelectionChanged); 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridView3.Rows[e.RowIndex].IsNewRow)
            {
                DataGridView view = (DataGridView)sender;
                List<Member> list = DataGridViewUtil.BindingListToList<Member>(view.DataSource);
              //  List<Member> list = (List<Member>)view.DataSource;
                Member Mitem = (Member)list[e.RowIndex];
                if (e.ColumnIndex == seeCommissionDataGridViewCheckBoxColumn2.Index)
                {
                    Mitem.SeeCommission = (bool)this.dataGridView3[e.ColumnIndex, e.RowIndex].Value;
                    UpIsCheck(Mitem.PhoneNumber, Mitem.SeeCommission);
                }

            }

            //this.dataGridView3.SelectionChanged += new EventHandler(dataGridView3_SelectionChanged);
        }

        private void dataGridView3_Scroll(object sender, ScrollEventArgs e)
        {
            /* System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
             dataGridView3.Cursor = System.Windows.Forms.Cursors.Default;*/
            
            //this.dataGridView3.Scroll.HorizontalScroll.Value = e.NewValue;
            //this.dataGridView3.VerticalScrollingOffset
        }

        private void splitContainer1_Scroll(object sender, ScrollEventArgs e)
        {
            //ShowMessage();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode e2 = new TreeNode();
            Initialize(out e2);
        }

        private void dataGridView3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView3.CurrentCell.ColumnIndex == 1 && dataGridView3.CurrentCell.RowIndex != -1) //控制要处理的列
            {
                //  (e.Control as DataGridViewCheckBoxColumn).SelectedIndexChanged += new EventHandler(form1_SelectedIndexChanged); //订阅事件
            }
        }
    }
}
