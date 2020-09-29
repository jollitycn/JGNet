
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
using static CCWin.SkinControl.SkinChatRichTextBox;

namespace JGNet.Common
{
    public partial class AccumulativeTotalStockGoodDetailForm : BaseForm
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public AccumulativeTotalStockGoodDetailForm()
        {
            InitializeComponent();
            dataGridView_RetailDetail.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(
                this.dataGridView_RetailDetail, new string[] {
             Count.DataPropertyName
            })
            {
                ShowColumnSetting = false
            };
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 Count
            });

            dataGridView_RetailDetail.AutoGenerateColumns = false;
            
            dataGridViewPagingSumCtrl.Initialize();
        }

        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        GetCostumeDistributionDetailsPara para;
         
        internal void ShowDialog(GetCostumeDistributionDetailsPara changePara)
        {
            para = new GetCostumeDistributionDetailsPara();
            
            ReflectionHelper.CopyProperty(changePara, para);
            CommonGlobalUtil.SetCostomerSaleType(skinComboBox_Type);
             
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
                InteractResult<List<OrderInfo>> listPage = CommonGlobalCache.ServerProxy.GetCostumeDistributionDetails4In(para);
                dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
            //finally
            //{
            //    UnLockPage();
            //}
        } 

        private void dataGridView_RetailDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
             try {

                OrderInfo item = dataGridView_RetailDetail.Rows[e.RowIndex].DataBoundItem as OrderInfo;
                if (e.ColumnIndex == InboundOrderID.Index )
                 {
                     ShowForm(item);
                 }

             }
             catch (Exception ee)
             {
                 CommonGlobalUtil.ShowError(ee);
             }
        }

        private void ShowForm(OrderInfo order)
        {

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                if (order.Type == "采购")
                {
                    DistributeCostumeInDetailForm form = new DistributeCostumeInDetailForm();
                    form.BaseModifyCostumeID = para.CostumeID;
                    form.ShowDialog(order.ID);
                }
                else if (order.Type == "调拨单")
                {
                    DistributeCostumeAllocateInDetailForm form = new DistributeCostumeAllocateInDetailForm();
                    form.BaseModifyCostumeID = para.CostumeID;
                    form.ShowDialog(order.ID);
                }
                else if (order.Type == "批发")
                { 
                    DistributePFCostumeInDetailForm form = new DistributePFCostumeInDetailForm();
                    form.BaseModifyCostumeID = para.CostumeID;
                    form.ShowDialog(order.ID);
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

        private void baseButton2_Click(object sender, EventArgs e)
        {
            //Search((CostumeInvoicingDetailInType)skinComboBox_Type.SelectedValue);
            InteractResult<List<OrderInfo>> listPage = CommonGlobalCache.ServerProxy.GetCostumeDistributionDetails4In(para);
              dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
            //this.dataGridView_RetailDetail.DataSource = listPage.Data;

        }
    }
}
