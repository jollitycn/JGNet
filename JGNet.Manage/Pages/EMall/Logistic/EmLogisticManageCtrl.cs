using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CJBasic.Widget;
using CJBasic;
using CJBasic.Loggers;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
 
using CCWin.SkinControl;
using JGNet.Core.Tools;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Common.Core.Util;

namespace JGNet.Manage

{
    public partial class EmLogisticManageCtrl : BaseUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
         
        public override void RefreshPage()
        {
            this.BaseButton_Search_Click(null, null);
        }

        public EmLogisticManageCtrl()
        {
            InitializeComponent();

            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            //dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] { expressCompanyNameDataGridViewTextBoxColumn,
            //      commentDataGridViewTextBoxColumn,
            //    enabledDataGridViewCheckBoxColumn });
            dataGridViewPagingSumCtrl.Initialize();
            MenuPermission = RolePermissionMenuEnum.物流管理;

        }
         



        private void BaseButton_Search_Click(object sender, EventArgs e)
        {

            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<EmExpressCompany> listPage = GlobalCache.EMallServerProxy.GetAllEmExpressCompany();
                this.BindingDataSource(listPage);
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


        private void BindingDataSource(List<EmExpressCompany> listPage)
        {

            this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(listPage); ;

        }
         

        private void EmLogisticManageCtrl_Load(object sender, EventArgs e)
        { 
            BaseButton_Search_Click(null, null);
        }


        public event CJBasic.Action<EmExpressCompany, BaseUserControl> OpenModifyDialog;


        private void UpdateCompany(EmExpressCompany item)
        {

            UpdateResult result = GlobalCache.EMallServerProxy.UpdateEmExpressCompany(item);
            switch (result)
            {
                case UpdateResult.Success:
                    //  成功，刷新界面！
                    //this.dataGridView1.EndEdit();
                    //刷新会报编辑中的错误！
                    //  RefreshPage();
                    break;
                case UpdateResult.Error:
                    GlobalMessageBox.Show("内部错误！");
                    break;
                default:
                    break;
            }

        }
         
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                //
                List<EmExpressCompany> companys = DataGridViewUtil.BindingListToList<EmExpressCompany>(dataGridView1.DataSource);

                foreach (var item in companys)
                {
                    UpdateCompany(item);
                }
                GlobalMessageBox.Show("保存成功！");
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
         
    }
}
