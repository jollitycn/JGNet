
using CCWin;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Core.InteractEntity;
using JGNet.Manage;
using CJBasic.Loggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class ChooseGiftTicketForm : BaseForm
    {
        private List<GiftTicket> GiftTicketList;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public event CJBasic.Action<GiftTicket, EventArgs> ItemSelected;


        public ChooseGiftTicketForm(  List<GiftTicket> GiftTickets)
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            this.GiftTicketList = GiftTickets;
            effectDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
            expiredDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
            this.BindingDataSource();
        } 

        //绑定数据源
        private void BindingDataSource()
        { 
            this.dataGridViewPagingSumCtrl.SetDataSource ( this.GiftTicketList);
        }
         
        //点击确认按钮
        private void BaseButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.DataSource == null)
                {
                    return;
                }
                int index = this.dataGridView1.SelectedCells[0].RowIndex;
                this.ConfirmSelectCell(this.GiftTicketList[index]);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee); 
            }
        }
        private void ConfirmSelectCell(GiftTicket ticket)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(ticket, null);
            }
            this.DialogResult = DialogResult.OK;
        }
        //点击取消按钮
        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.ConfirmSelectCell(this.GiftTicketList[e.RowIndex]);
             

        }
    }
}
