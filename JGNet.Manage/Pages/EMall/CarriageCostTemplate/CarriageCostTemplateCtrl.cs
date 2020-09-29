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
using JGNet.Core.Dev.InteractEntity;
using JGNet.Common.Core.Util;

namespace JGNet.Manage

{
    public partial class EmCarriageCostTemplateCtrl : BaseUserControl
    {
        //   private GetEmCarriageCostTemplatePagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private CarriageCostTemplatePagePara pagePara;

        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }

        public EmCarriageCostTemplateCtrl()
        {
            InitializeComponent();

            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click);
            dataGridViewPagingSumCtrl.Initialize();
            MenuPermission = RolePermissionMenuEnum.运费模板;
        }


        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (this.pagePara == null)
                {
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                pagePara.PageIndex = index;
                CarriageCostTemplatePage listPage = GlobalCache.EMallServerProxy.GetCarriageCostTemplatePage(this.pagePara);

                this.BindingDataSource(listPage);

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
        private void BaseButton_Search_Click(object sender, EventArgs e)
        {

            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                //  pagePara = new GetEmCarriageCostTemplatePagePara()
                //{ 
                //    PageIndex = 0,
                //    PageSize = this.dataGridViewPagingSumCtrl.PageSize
                //};

                // EmCarriageCostTemplatePage listPage = GlobalCache.EMallServerProxy.(this.pagePara);
                // this.dataGridViewPagingSumCtrl.Initialize(listPage);
                //  this.BindingDataSource(listPage);
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


        //private void BindingDataSource(EmCarriageCostTemplatePage listPage)
        //{
        //    if (listPage!= null && listPage.EmCarriageCostTemplates != null)
        //    {
        //        this.dataGridView1.DataSource = listPage.EmCarriageCostTemplates;
        //    }
        //    else
        //    {
        //        this.dataGridView1.DataSource = null;
        //    }
        //}


        private void EmCarriageCostTemplateCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                //  pagePara = new GetEmCarriageCostTemplatePagePara();
            }
            catch (Exception ex)
            {

                GlobalUtil.ShowError(ex);
            }
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            this.OpenModifyDialog(null, this);
        }

        public event CJBasic.Action<EmCarriageCostTemplate, BaseUserControl> OpenModifyDialog;

         

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) {
                    return;
                }
                if (e.RowIndex >= 0 && e.RowIndex != -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    List<EmCarriageCostTemplate> list = (List<EmCarriageCostTemplate>)view.DataSource;
                    EmCarriageCostTemplate item = (EmCarriageCostTemplate)list[e.RowIndex];
                    switch (view.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.HeaderText)
                    {

                        case "编辑":

                            this.OpenModifyDialog(item, this);

                            break;
                        case "删除":

                            RemoveTemplate(item.AutoID);
                            // UpdateEmShowOnlineIsFalse(item);
                            break;
                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void RemoveTemplate(int autoID)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                InteractResult result = GlobalCache.EMallServerProxy.DeleteCarriageCostTemplate(autoID);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("删除成功！");
                        this.RefreshPage();
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
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    List<EmCarriageCostTemplate> list = (List<EmCarriageCostTemplate>)view.DataSource;
                    EmCarriageCostTemplate item = (EmCarriageCostTemplate)list[e.RowIndex];
                    switch (view.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.HeaderText)
                    {
                        //case "推荐":
                        //    item.EmIsRecommand = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                        //    Recommend(item);

                        //    break;
                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void baseButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this))
                { return; }

                this.pagePara = new Core.Dev.InteractEntity.CarriageCostTemplatePagePara()
                {
                    IsValid = -1,
                    Name = skinTextBoxTitle.Text,
                    PageIndex = 0,
                    PageSize = dataGridViewPagingSumCtrl.PageSize,
                };
                CarriageCostTemplatePage listPage = GlobalCache.EMallServerProxy.GetCarriageCostTemplatePage(pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                dataGridViewPagingSumCtrl.Initialize(listPage);
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

        private void BindingDataSource(CarriageCostTemplatePage listPage)
        {
            if (listPage != null && listPage.CarriageCostTemplates != null)
            {
                foreach (var item in listPage.CarriageCostTemplates)
                {
                    item.LastOperatorUserName = GlobalCache.GetUserName(item.LastOperatorUserID);
                }
                 
            }
            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.CarriageCostTemplates, null, listPage?.TotalEntityCount);
        }
    }


}
