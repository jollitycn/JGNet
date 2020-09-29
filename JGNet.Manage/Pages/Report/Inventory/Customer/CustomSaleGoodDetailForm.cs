
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core.Dev.MyEnum;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using CJBasic;
using CJBasic.Helpers;
using CJBasic.Loggers;
using JieXi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using JGNet.Manage.Components;
using static CCWin.SkinControl.SkinChatRichTextBox;

namespace JGNet.Common
{
    public partial class CustomSaleGoodDetailForm : BaseForm
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public CustomSaleGoodDetailForm()
        {
            InitializeComponent();
            dataGridView_RetailDetail.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(
                this.dataGridView_RetailDetail, new string[] {
           totalCountDataGridViewTextBoxColumn.DataPropertyName
            })
            {
                ShowColumnSetting = false
            };
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 totalCountDataGridViewTextBoxColumn
            });

            dataGridView_RetailDetail.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.Initialize();
        }

        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        GetPfInvoicingPara para;
        internal void ShowDialog(GetPfInvoicingPara changePara)
        {
            para = new GetPfInvoicingPara();
            ReflectionHelper.CopyProperty(changePara, para);
            Search();

           /* if (!String.IsNullOrEmpty(para.CostumeID)) {
                this.Text += ":款号-" + para.CostumeID;
            }*/
            this.ShowDialog();
        }

        public void Search()
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                //InteractResult<List<PfOrder>> listPage = CommonGlobalCache.ServerProxy.GetPfInvoicing4Delivery(para);
                InteractResult<List<PfCustomerRetailOrder>> listPage = CommonGlobalCache.ServerProxy.GetPfInvoicing4Retail(para);
                dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        } 

        private void dataGridView_RetailDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try {
                PfCustomerRetailOrder item = dataGridView_RetailDetail.Rows[e.RowIndex].DataBoundItem as PfCustomerRetailOrder;
                if (e.ColumnIndex == iDDataGridViewTextBoxColumn.Index )
                {
                    ShowForm(item);
                }

            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }
        }

        private void ShowForm(PfCustomerRetailOrder order)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                CustomerSaleOrderDetailForm form = new  CustomerSaleOrderDetailForm();
            form.ShowDialog(order);
                /*  if (order.Type == "调拨")
                  {
                      //采购进货明细
                      CostumeStoreTrackSearchTurnOutDetailForm form
                           = new CostumeStoreTrackSearchTurnOutDetailForm();
                      form.BaseModifyCostumeID = para.CostumeID;
                    //  form.ShowDialog(order);
                  }
                  else
                  {
                      CostumeStoreTrackSearchTurnOutDetailWholeSaleForm form = new CostumeStoreTrackSearchTurnOutDetailWholeSaleForm();
                      form.BaseModifyCostumeID = para.CostumeID;
                      form.ShowDialog(order);
                  }*/
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
    }
}
