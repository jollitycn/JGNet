
using JGNet.Common;
using JGNet.Common.Components;
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
    public partial class EmRetailOrderForm : BaseForm
    {
         
        private List<EmRetailOrder> currentCostumes;
        private List<EmRetailOrder> currentSource=new List<EmRetailOrder>();
        public event System.Action<EmRetailOrder> EmRetailOrderSelected;

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public EmRetailOrderForm(List<EmRetailOrder> items,string costumeID)
        {
            InitializeComponent();
            this.skinTextBox1.SkinTxt.KeyDown += skinTextBox1_KeyDown;
            this.skinTextBox1.SkinTxt.Text = costumeID;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this. dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridView1.AutoGenerateColumns = false;
            this.SetDataSource(items);
        }

        private void skinTextBox1_KeyDown(object sender, KeyEventArgs e)
        { 
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        BaseButton1_Click(null, null);
                        break;
                    case Keys.Up:
                    case Keys.Down:
                        this.dataGridView1.Focus();
                        break;
 
            }
        }

        private void SetDataSource(List<EmRetailOrder> items)
        {
            this.currentCostumes = items;
            this.currentSource.Clear();
            for (int i = 0; i < items.Count; i++)
            {
             //   items[i].BrandName = CommonGlobalCache.GetBrandName(items[i].BrandID);
              //  items[i].SupplierName = CommonGlobalCache.GetSupplierName(items[i].SupplierID);
                this.currentSource.Add(items[i]);
            }
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.currentSource;
            this.dataGridView1.Refresh();
        }
        private bool isBarCode = false;
        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            {
                isBarCode = false;
                string costumeID = this.skinTextBox1.SkinTxt.Text.Trim();
                if (string.IsNullOrEmpty(costumeID))
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<EmRetailOrder> resultList = GlobalCache.EMallServerProxy.GetEmRetailOrderIdLike(costumeID.ToUpper());

              //  List<EmRetailOrder> resultList = CommonGlobalCache.CostumeList.FindAll(t => (t.ID.ToUpper().Contains(costumeID.ToUpper()) || t.Name.ToUpper().Contains(costumeID.ToUpper()))  && t.EmShowOnline);
                this.SetDataSource(resultList);
            }
            catch (Exception ee)
            {
                ShowError(ee);
            }

            finally
            {
               UnLockPage();
            }

        }

        private void BaseButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                int index = this.dataGridView1.SelectedCells[0].RowIndex;
                this.ConfirmSelectCell(this.currentCostumes[index]);
            }
            catch (Exception ee)
            {

                ShowError(ee);
            }
            finally {
               UnLockPage();
            }

        }

        private void ConfirmSelectCell(EmRetailOrder item)
        {
            if (this.EmRetailOrderSelected != null)
            {
                this.EmRetailOrderSelected(item);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex < 0)
            //{
            //    return;
            //}
            this.ConfirmSelectCell(this.currentCostumes[e.RowIndex]);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmSelectCell((EmRetailOrder)dataGridView1.CurrentRow.DataBoundItem);
            }
            else {
                //this.skinTextBox1.Focus();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.ConfirmSelectCell(this.currentCostumes[e.RowIndex]);
        }
    }
}
