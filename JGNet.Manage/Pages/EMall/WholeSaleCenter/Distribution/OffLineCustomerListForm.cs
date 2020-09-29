using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Manage; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class OffLineCustomerListForm : BaseForm
    {
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        Distributor item;
        public OffLineCustomerListForm(Distributor item)
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.分销人员管理;
            this.item = item;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButtonQuery_Click);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridView1.AutoGenerateColumns = false;
            BaseButtonQuery_Click(null,null);
        }

        GetPfCustomerPage4DistributorPara para;
        private void BaseButtonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                para = new GetPfCustomerPage4DistributorPara()
                {
                    DistributorID = item.ID,
                    PageIndex = 0,
                    PageSize = dataGridViewPagingSumCtrl.PageSize
                };
                PfCustomerPage page = GlobalCache.ServerProxy.GetPfCustomerPage4Distributor(para);
                dataGridViewPagingSumCtrl.OrderPara = para;
                dataGridViewPagingSumCtrl.Initialize(page);
                BindingDataSource(page);
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
         
        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (this.para == null)
                {
                    return;
                }
                this.para.PageIndex = index;
                PfCustomerPage page = GlobalCache.ServerProxy.GetPfCustomerPage4Distributor(para);
                this.BindingDataSource(page);
            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }
        }

        private void BindingDataSource(PfCustomerPage page)
        {
            dataGridViewPagingSumCtrl.BindingDataSource(page?.PfCustomers, null, page?.TotalEntityCount);
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }  

        private void BaseButtonEdit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                { return; }
                DataGridView view = sender as DataGridView;
                PfCustomer item = view.Rows[e.RowIndex].DataBoundItem as PfCustomer;
                if (ColumnEdit.Index == e.ColumnIndex)
                {
                   
                    //修改
                    Edit(item);
                } 
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void Edit(PfCustomer item)
        {
            SaveOffLineCustomerForm form = new SaveOffLineCustomerForm(item.DistributorID,item);
            form.ConfirmClick += form_ConfirmClick_Edit;
            form.ShowDialog();
        }

        private void form_ConfirmClick_Edit(PfCustomer item, SaveOffLineCustomerForm form)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                UpdateResult result = GlobalCache.ServerProxy.UpdateDistributor(item.ID, item.Name, item.Password);
                switch (result)
                {
                    case UpdateResult.Success:
                        form.DialogResult = DialogResult.OK;
                        RefreshPage();
                        break;
                    case UpdateResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        form.Cancel();
                        break;
                    default:
                        break;
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

        private void RefreshPage()
        {
            BaseButtonQuery_Click(null,null);
        }
    }
}
