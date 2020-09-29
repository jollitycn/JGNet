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
using CJBasic.Helpers;

namespace JGNet.Manage.Pages
{
    public partial class PermissonCtrl : BaseModifyUserControl
    {

        public PermissonCtrl()
        {
            InitializeComponent();
            MenuPermission= RolePermissionMenuEnum.角色管理;
        }

        List<TreeNode> allNodes = null;
        private void PermissonCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        private void Initialize()
        {
            skinTreeViewPermisson.Nodes.AddRange(PermissonUtil.GetTreeNodes().ToArray());
            allNodes = WinformUIUtil.GetAllTreeNodes(skinTreeViewPermisson.Nodes);
            skinTreeViewPermisson.Nodes[0].FirstNode.ExpandAll();
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.ShowRowCounts = false;
            dataGridViewPagingSumCtrl.Initialize();

            //List<UserInfo> adminList =  new List<UserInfo>();

            //foreach (var item in CommonGlobalCache.UserInfoList)
            //{
            //    if (item.State == 0)
            //    {
            //        if (item == CommonGlobalCache.GetSupperUserInfo()) { continue; }
            //        adminList.Add(item);
            //    }
            //}
            //adminList.Insert(0, CommonGlobalCache.GetSupperUserInfo());
            LoadRoles();


        }


        private void LoadRoles()
        {
            InteractResult<List<Role>> result = GlobalCache.ServerProxy.GetRoles();
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    dataGridViewPagingSumCtrl.BindingDataSource( DataGridViewUtil.ListToBindingList(result.Data));
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    break;
            }
        }


        Role user;

        private void ResetNodeCheck(bool nodeChecked)
        {
            foreach (var item in allNodes)
            {
                item.Checked = nodeChecked;
            }
        }

        private void ResetNodeFullPathCheck(int fullPath, bool nodeChecked)
        {
            foreach (var item in allNodes)
            {
                
                if (item.Tag is RolePermissionMenuEnum)
                {
                    if (item.Nodes != null && item.Nodes.Count > 0)
                    {
                        if (item.Nodes[0].Tag is RolePermissionMenuEnum)
                        {
                            string value = string.Empty + (int)item.Tag + (int)RolePermissionEnum.查看;
                            if (int.Parse(value) == fullPath)
                            {
                                item.Checked = nodeChecked;
                                break;
                            }
                        }
                        else
                        {
                            string value = string.Empty + (int)item.Tag;
                            if (int.Parse(value) == fullPath)
                            {
                                item.Checked = nodeChecked;
                                break;
                            }
                        }
                    }
                    else
                    {
                        string value = string.Empty + (int)item.Tag + (int)RolePermissionEnum.查看;
                        if (int.Parse(value) == fullPath)
                        {
                            item.Checked = nodeChecked;
                            break;
                        }
                    }
                }
                else if (item.Tag is RolePermissionEnum)
                {
                    int permissonPath = int.Parse(GetPermissonTag(item));
                    if (permissonPath == fullPath)
                    {
                        item.Checked = nodeChecked;
                        break;
                    }
                }

            }
        }

        private String GetPermissonTag(TreeNode item)
        {
            String value = string.Empty;
            if (item != null && item.Tag is RolePermissionEnum)
            {
                value = GetPermissonOnlyTag(item);
            }
            else if (item != null && item.Tag is RolePermissionMenuEnum)
            {
                value = GetPermissonMenuTag(item);
            }
            return value;
        }

        private String GetPermissonMenuTag(TreeNode item)
        {
            String tagStr = string.Empty;
            if (item.Tag is RolePermissionMenuEnum)
            {
                if (item.Nodes != null && item.Nodes.Count > 0)
                {
                    if (item.Nodes[0].Tag is RolePermissionMenuEnum)
                    {
                        tagStr = string.Empty + (int)item.Tag + (int)RolePermissionEnum.查看;
                    }
                    else
                    {
                        tagStr = string.Empty + (int)item.Tag;
                    }
                }
                else
                {
                    tagStr =  string.Empty + (int)item.Tag + (int)RolePermissionEnum.查看; 
                }
            }
            return tagStr;
        }

        private String GetPermissonOnlyTag(TreeNode item)
        {
            String tagStr = string.Empty;
            if (item.Tag is RolePermissionEnum)
            {
                tagStr = ((int)(RolePermissionEnum)item.Tag).ToString();
                if (item.Parent != null)
                {

                    TreeNode menuNode = item.Parent;
                    while (menuNode.Tag is RolePermissionEnum)
                    {
                        menuNode = menuNode.Parent;
                    }
                    tagStr = GetPermissonOnlyTag(menuNode) + tagStr;
                }
            }
            else if (item.Tag is RolePermissionMenuEnum)
            {
                tagStr = ((int)(RolePermissionMenuEnum)item.Tag).ToString();

            }
            return tagStr;
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            base.TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
        }

        private List<int> GetPermisson()
        {
            List<int> permission = new List<int>();
            bool hasChecked = false;
            foreach (var item in allNodes)
            {
                if (item.Checked)
                {
                    hasChecked = true;
                    String value = GetPermissonTag(item);
                    int tag = int.Parse(value);
                    if (!permission.Contains(tag))
                    {
                        permission.Add(tag);
                    }
                }
            }

            if (!hasChecked)
            {
                permission = null;
            }

            return permission;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.skinTreeViewPermisson.AfterCheck -= this.skinTreeViewPermisson_AfterCheck;
            DataGridView view = sender as DataGridView;
            if (view.CurrentRow != null)
            {
                user = view.CurrentRow.DataBoundItem as Role;
            }
            if (user == null) { return; }
            skinTextBoxRoleName.Text = user.Name;
            textBoxRemark.Text = user.Remarks;
            if (SystemDefault.DefaultAdminRole == user.AutoID)
            {
                skinSplitContainer1.Panel2.Enabled = false;
            }
            else
            {
                skinSplitContainer1.Panel2.Enabled = true;
            }

            ResetNodeCheck(false);
            List<int> permissions = null;
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                InteractResult<List<int>> result = GlobalCache.ServerProxy.GetRolePermissions4RoleID(user.AutoID);
                permissions = result.Data;
            }
            catch (Exception ex)
            {
               // GlobalUtil.ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }

            if (permissions == null)
            {
                ResetNodeCheck(true);
            }
            else if (permissions.Count == 0)
            {
                ResetNodeCheck(false);
            }
            else
            {
                //    String[] permissions = permission.Split(',');
                foreach (var item in permissions)
                {
                    ResetNodeFullPathCheck(item, true);
                }
            }

            skinTreeViewPermisson.Refresh();
            this.skinTreeViewPermisson.AfterCheck += this.skinTreeViewPermisson_AfterCheck;
        }

        private void CheckNode(TreeNode node)
        {
            this.skinTreeViewPermisson.AfterCheck -= this.skinTreeViewPermisson_AfterCheck;
            CheckParentNode(node);
            CheckChildNode(node);
            this.skinTreeViewPermisson.AfterCheck += this.skinTreeViewPermisson_AfterCheck;
        }

        private void CheckParentNode(TreeNode node)
        {
            if (node.Parent != null)
            {
                TreeNode nodeParent = node.Parent;
                if (nodeParent.Tag is RolePermissionMenuEnum)
                {
                    nodeParent.Checked = node.Checked;
                }
                if (nodeParent.Nodes != null)
                {
                    foreach (TreeNode item in nodeParent.Nodes)
                    {
                        if ((item.Checked && item != node) || (item.Checked && item == node))
                        {
                            nodeParent.Checked = true;
                        }
                    }
                }

                CheckParentNode(nodeParent);
            }
        }

        private void CheckChildNode(TreeNode node)
        {
            if (node.Nodes != null)
            {
                if (node.Tag is RolePermissionEnum)
                {
                    foreach (TreeNode item in node.Nodes)
                    {
                        item.Checked = node.Checked;
                    }
                        return;
                 
                }

                foreach (TreeNode item in node.Nodes)
                {
                    item.Checked = node.Checked;
                    CheckChildNode(item);
                }
            }
        }

        private void skinTreeViewPermisson_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode node = e.Node;
                CheckNode(node);
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void baseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Role role = new Role();
                ReflectionHelper.CopyProperty(user, role);
                role.Name = skinTextBoxRoleName.Text;
                role.Remarks = textBoxRemark.Text;
                role.Permissions = GetPermisson();
                InteractResult result = GlobalCache.ServerProxy.UpdateRole(role);
                //通知桌面更新对应结果
                //((MainForm)GlobalUtil.MainForm).UpdatePermisson();
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        GlobalMessageBox.Show("保存成功！");
                        ReflectionHelper.CopyProperty(role, user);
                        dataGridView1.Refresh();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
                DataGridView view = sender as DataGridView;
                Role role = view.Rows[e.RowIndex].DataBoundItem as Role;
                if (e.ColumnIndex == ColumnDelete.Index)
                {
                    DialogResult dialogResult = GlobalMessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel);
                    if (dialogResult != DialogResult.OK)
                    {
                        return;
                    }
                    InteractResult result = GlobalCache.ServerProxy.DeleteRole(role.AutoID);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        case ExeResult.Success:
                            List<Role> roles = DataGridViewUtil.BindingListToList<Role>(view.DataSource) ;
                            view.DataSource = null;
                            roles.Remove(role);
                            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList<Role>(roles) );
                            GlobalMessageBox.Show("删除成功！");
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            if (e.Value == null) { return; }
            if (e.ColumnIndex == ColumnDelete.Index)
            {
                DataGridView view = sender as DataGridView;
                Role role = view.Rows[e.RowIndex].DataBoundItem as Role;
                if (role.AutoID == SystemDefault.DefaultAdminRole)
                {
                    e.Value = null;
                }
            }
        }

        private void baseButtonNew_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            int i = 1;
            role.Name = "新角色" + i;
            List<Role> roles = DataGridViewUtil.BindingListToList<Role>(dataGridView1.DataSource);  
            while (roles.Find(t => t.Name == role.Name) != null)
            {
                i++;
                role.Name = "新角色" + i;
            }
            role.Permissions = new List<int>();
            InteractResult<int> result = GlobalCache.ServerProxy.InsertRole(role);
            int autoId = result.Data;
            role.AutoID = autoId;
            roles.Add(role);
           // this.dataGridView1.Refresh();
            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList<Role>(roles));
            dataGridViewPagingSumCtrl.ScrollToEnd();
          //  roles
        }
    }
}
