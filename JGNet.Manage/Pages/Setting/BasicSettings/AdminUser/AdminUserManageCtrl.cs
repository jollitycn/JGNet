using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using System.Reflection;
using JGNet.Common.Core; 
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core.Util;

namespace JGNet.Manage.Pages
{
    public partial class AdminUserManageCtrl : BaseUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public override void RefreshPage()
        {
            BaseButtonQuery_Click(null, null);
        }

        public AdminUserManageCtrl()
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.管理员;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] { remarksDataGridViewTextBoxColumn });
            dataGridViewPagingSumCtrl.Initialize();
           // baseButtonPermission.Visible =(CommonGlobalCache.CurrentUserID == SystemDefault.DefaultAdmin);
        }

        private void BaseButtonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                Core.InteractEntity.GetAdminUsersPara para = new Core.InteractEntity.GetAdminUsersPara()
                {
                    IDOrName = skinTextBox_ID.Text
                };
                InteractResult<List<AdminUser>> result = GlobalCache.ServerProxy.GetAdminUsers(para);
                dataGridViewPagingSumCtrl.BindingDataSource(result?.Data);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            this.SaveClick(null,this);
        }
        public event CJBasic.Action<AdminUser, BaseUserControl> SaveClick;
        public event CJBasic.Action<AdminUser, BaseUserControl,Boolean> EditPasswordClick; 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {

                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    List<AdminUser> list = (List<AdminUser>)this.dataGridView1.DataSource;
                        AdminUser item = (AdminUser)list[e.RowIndex];
                    //switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    //{
                    //    case "编辑":
                    if (e.ColumnIndex == Column1.Index)
                    {
                        this.SaveClick(item, this);
                    }
                    //break;
                    //    case "设置密码":
                    else if (e.ColumnIndex == Column3.Index)
                    {
                        this.EditPasswordClick(item, this, false);
                    }
                    else if (e.ColumnIndex == Column2.Index)
                    {


                        if (item.ID == SystemDefault.DefaultAdmin) { GlobalMessageBox.Show("默认管理员不能删除"); return; }
                        if (GlobalMessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DeleteAdminUserResult result = GlobalCache.AdminUser_OnRemove(item.ID);
                            if (result == DeleteAdminUserResult.Error)
                            {
                                GlobalMessageBox.Show("内部错误！");
                                return;
                            }
                            else if (result == DeleteAdminUserResult.DefaultAdminIsNoDelete)
                            {
                                GlobalMessageBox.Show("不能删除超级管理员！");
                                return;
                            }
                            else
                            {
                                GlobalMessageBox.Show("删除成功！");
                                RefreshPage();
                            }

                        }
                    }
                         
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

        private void AdminUserManageCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
            BaseButtonQuery_Click(null, null);
           
        }

        private void Initialize()
        {
            skinTextBox_ID.Text = null;
        }

        private void baseButtonPermission_Click(object sender, EventArgs e)
        {
            AdminUserPermissionClick?.Invoke(this);
        }

        public event Action<BaseUserControl> AdminUserPermissionClick;
    }
}
