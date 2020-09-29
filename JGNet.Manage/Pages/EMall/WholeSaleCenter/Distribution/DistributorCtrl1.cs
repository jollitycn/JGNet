using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JGNet.Common.Core;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Common.cache.Wholesale;

namespace JGNet.Manage

{
    public partial class DistributorCtrl1 : BaseUserControl
    {
        private List<RetailDetail> retailDetailList = new List<RetailDetail>();//当前dataGridView绑定的源
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public DistributorCtrl1()
        {
            InitializeComponent();
            skinTextBoxName.SkinTxt.KeyDown += SkinTxt_KeyDown;
            this.dataGridView.AutoGenerateColumns = false; 
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButtonQuery_Click);
            dataGridViewPagingSumCtrl.Initialize();
            MenuPermission = RolePermissionMenuEnum.分销人员管理;
        }

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButtonQuery_Click(null, null);
            }
        }

        private void Control_Load(object sender, EventArgs e)
        {
            BaseButtonQuery_Click(null, null);
        }

        public override void RefreshPage()
        {
            if (para != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(para.PageIndex);
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
                DistributorPage page = GlobalCache.ServerProxy.GetDistributorPage(para);
                this.BindingDataSource(page);
            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }
        }

        GetDistributorPagePara para;
        private void BaseButtonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                para = new GetDistributorPagePara()
                {
                    IdOrName = skinTextBoxName.Text,
                    PageIndex = 0,
                    PageSize = dataGridViewPagingSumCtrl.PageSize
                };
                DistributorPage page = GlobalCache.ServerProxy.GetDistributorPage(para);
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

        private void BindingDataSource(DistributorPage page)
        {
            dataGridViewPagingSumCtrl.BindingDataSource(page?.Distributors, null, page?.TotalEntityCount);
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            // this.AddClick(null, this);
            SaveDistributorForm form = new SaveDistributorForm(null);
            form.ConfirmClick += form_ConfirmClick;
            form.ShowDialog();
        }

        private void form_ConfirmClick_Edit(Distributor item, SaveDistributorForm form)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                UpdateResult result = GlobalCache.ServerProxy.UpdateDistributor(item.ID,item.Name,item.Password);
                switch (result)
                {
                    case UpdateResult.Success:
                        form.DialogResult = DialogResult.OK;
                        this.RefreshPage();
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                { return; }
                Distributor item = dataGridView.Rows[e.RowIndex].DataBoundItem as Distributor;
                if (ColumnOffline.Index == e.ColumnIndex)
                {
                    //下线客户
                    OfflineCustomers(item);
                }
                else if (ColumnEdit.Index == e.ColumnIndex)
                {
                    //修改
                    Edit(item);
                }
                else if (ColumnNewOffline.Index == e.ColumnIndex)
                {
                    //新增下线
                    NewOffline(item);
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void NewOffline(Distributor item)
        {
            SaveOffLineCustomerForm form = new SaveOffLineCustomerForm(item.ID,null);
            form.ConfirmClick += SaveOffLineCustomerForm_ConfirmClick;
            form.ShowDialog();
        }

        private void SaveOffLineCustomerForm_ConfirmClick(PfCustomer item, SaveOffLineCustomerForm form)
        {
            this.RefreshPage();
            //try
            //{
            //    if (GlobalUtil.EngineUnconnectioned(this))
            //    {
            //        return;
            //    }
            //    InteractResult result = GlobalCache.ServerProxy.InsertPfCustomer(item);
            //    switch (result.ExeResult)
            //    {
            //        case ExeResult.Success:
            //            PfCustomerCache.InsertPfCustomer(item);
            //            form.DialogResult = DialogResult.OK;
            //            this.RefreshPage();
            //            break;
            //        case ExeResult.Error:
            //            GlobalMessageBox.Show(result.Msg);
            //            form.Cancel();
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    GlobalUtil.ShowError(ex);
            //}
            //finally
            //{
            //    GlobalUtil.UnLockPage(this);
            //}
        }

        private void Edit(Distributor item)
        {
            SaveDistributorForm form = new SaveDistributorForm(item);
            form.ConfirmClick += form_ConfirmClick_Edit;
            form.ShowDialog();

        }

        private void form_ConfirmClick(Distributor item, SaveDistributorForm form)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = GlobalCache.ServerProxy.InsertDistributor(item);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        form.DialogResult = DialogResult.OK;
                        this.RefreshPage();
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
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

        private void OfflineCustomers(Distributor item)
        {
            OffLineCustomerListForm form = new OffLineCustomerListForm(item); 
            form.ShowDialog();
        }
         

    }
}
