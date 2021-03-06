﻿
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
    public partial class CostumeStoreTrackSearchIntoDetailWholeSaleForm : BaseDialogCostumeIDForm
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public CostumeStoreTrackSearchIntoDetailWholeSaleForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(
                this.dataGridView1, new string[] {
        fDataGridViewTextBoxColumn.DataPropertyName,
        xSDataGridViewTextBoxColumn.DataPropertyName,
        sDataGridViewTextBoxColumn.DataPropertyName,
        mDataGridViewTextBoxColumn.DataPropertyName,
        lDataGridViewTextBoxColumn.DataPropertyName,
        xLDataGridViewTextBoxColumn.DataPropertyName,
        xL2DataGridViewTextBoxColumn.DataPropertyName,
        xL3DataGridViewTextBoxColumn.DataPropertyName,
        xL4DataGridViewTextBoxColumn.DataPropertyName,
        xL5DataGridViewTextBoxColumn.DataPropertyName,
        xL6DataGridViewTextBoxColumn.DataPropertyName,
        sumCountDataGridViewTextBoxColumn.DataPropertyName,
        sumMoneyDataGridViewTextBoxColumn.DataPropertyName
    });
            dataGridViewPagingSumCtrl.Initialize();
            
        }
        


        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void ShowDialog(AllocateOrder order)
        {
            this.Initialize(order);
            this.ShowDialog();
        }

        private void Initialize(AllocateOrder order)
        {
            if (order == null || String.IsNullOrEmpty(order.ID))
            {
                return;
            }
            try
            {
                this.Text += "-" + order.ID;

                List<PfOrderDetail> list = CommonGlobalCache.ServerProxy.GetPfOrderDetails(order.ID);
                this.BindingOutboundDetailSource(list);
            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }

        }
        private void BindingOutboundDetailSource(List<PfOrderDetail> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (PfOrderDetail detail in list)
                {
                    detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
                }
            }

            dataGridViewPagingSumCtrl.BindingDataSource<PfOrderDetail>(list);
        }
         

        public override void HighlightCostume()
        {
            if (dataGridView1.DataSource != null)
            {
                if (!String.IsNullOrEmpty(BaseModifyCostumeID))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        PfOrderDetail detail = row.DataBoundItem as PfOrderDetail;
                        HighlightCostume(row, detail?.CostumeID);
                    }
                }
                dataGridView1.Refresh();
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }

        private void CostumeStoreTrackSearchIntoDetailWholeSaleForm_Load(object sender, EventArgs e)
        {
            HighlightCostume();
        }
    }
}
