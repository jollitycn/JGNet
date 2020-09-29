
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
    public partial class DistributeCostumeSalePfDetailForm : BaseDialogCostumeIDForm
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public DistributeCostumeSalePfDetailForm()
        {
            InitializeComponent(); 
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(
                this.dataGridView_RetailDetail, new string[] { 
    })  ;
            dataGridViewPagingSumCtrl.Initialize();
        }
        

        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
         
        internal void ShowDialog(string orderId)
        { 
            this.Initialize(orderId);
            this.ShowDialog();
        }    


    private void Initialize(string orderID)
    {
        if (orderID == string.Empty || String.IsNullOrEmpty(orderID))
        {
            return;
        }
        try
        {
            this.Text += "-"+ orderID;


                List<PfCustomerRetailDetail> list = CommonGlobalCache.ServerProxy.GetPfCustomerRetailDetails(orderID);

                this.BindingOutboundDetailSource(list);
        }
        catch (Exception ee)
        {
            CommonGlobalUtil.ShowError(ee);
        }

    }
        private void BindingOutboundDetailSource(List<PfCustomerRetailDetail> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (PfCustomerRetailDetail detail in list)
                {
                    //detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
                  //  detail.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(detail.CostumeID, detail.SizeName);
                }
            }
            this.dataGridViewPagingSumCtrl.BindingDataSource(list);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        } 

        public override void HighlightCostume()
        {
            if (dataGridView_RetailDetail.DataSource != null)
            {
                if (!String.IsNullOrEmpty(BaseModifyCostumeID))
                {
                    foreach (DataGridViewRow row in dataGridView_RetailDetail.Rows)
                    {
                        PfCustomerRetailDetail detail = row.DataBoundItem as PfCustomerRetailDetail;
                        HighlightCostume(row, detail?.CostumeID);
                    }
                }
                dataGridView_RetailDetail.Refresh();
            }
        }

        private void dataGridView_RetailDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }

        private void CostumeStoreTrackSearchRetailDetailForm_Load(object sender, EventArgs e)
        {
            HighlightCostume();
        }
    }
}
