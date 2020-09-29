
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
    public partial class StockgoodDetailForm : BaseForm
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public StockgoodDetailForm()
        {
            InitializeComponent();
            dataGridView_RetailDetail.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(
                this.dataGridView_RetailDetail, new string[] {
            TotalCount.DataPropertyName
            })
            {
                ShowColumnSetting = false
            };
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 TotalCount });

            dataGridView_RetailDetail.AutoGenerateColumns = false;
            
            dataGridViewPagingSumCtrl.Initialize();
        }

        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        GetCostumeInvoicingDetailPara para;
        internal void ShowDialog(GetCostumeInvoicingDetailPara changePara)
        {
            para = new GetCostumeInvoicingDetailPara();
            ReflectionHelper.CopyProperty(changePara, para);
            CommonGlobalUtil.SetCostomerSaleType(skinComboBox_Type);
            Search(CostumeInvoicingDetailInType.All);

           /* if (!String.IsNullOrEmpty(para.CostumeID)) {
                this.Text += ":款号-" + para.CostumeID;
            }*/
            this.ShowDialog();
        }

        public void Search(CostumeInvoicingDetailInType type )
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                InteractResult<List<PurchaseOrder>> listPage = CommonGlobalCache.ServerProxy.GetCostumeInvoicingDetail4In(para, type);
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

                PurchaseOrder item = dataGridView_RetailDetail.Rows[e.RowIndex].DataBoundItem as PurchaseOrder;
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

        private void ShowForm(PurchaseOrder order)
        {

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                CostumeInDetailForm form = new CostumeInDetailForm();

            form.BaseModifyCostumeID = para.CostumeID;
            // PurchaseOrder changeOrder = CommonGlobalCache.ServerProxy.GetOnePurchaseOrder(order.ID);
            form.ShowDialog(order);
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
            InteractResult<List<PurchaseOrder>> listPage = CommonGlobalCache.ServerProxy.GetCostumeInvoicingDetail4In(para, (CostumeInvoicingDetailInType)skinComboBox_Type.SelectedValue);
              dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
            //this.dataGridView_RetailDetail.DataSource = listPage.Data;

        }
    }
}
