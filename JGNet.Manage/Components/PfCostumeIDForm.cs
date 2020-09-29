
using JGNet.Common.Components;
using JGNet.Core.Tools;
using JGNet.Manage;
using CJBasic.Loggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common
{
    public partial class PfCostumeIDForm : BaseForm
    {

        private String CustomerID { get; set; }
        private List<CostumeItem> currentCostumeitems;
        private List<Costume> currentSource=new List<Costume>();
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

     //   public event CJBasic.Action<CostumeItem, EventArgs> CostumeSelected;
        private bool filterValid { get; set; }
        public CostumeItem Result { get; private set; }

        public PfCostumeIDForm(List<CostumeItem> items, string costumeID, String customerID,bool filterValid)
        {
            InitializeComponent();
            this.filterValid = filterValid;
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            this.skinTextBox1.SkinTxt.Text = costumeID;
            this.CustomerID = customerID;
            this.SetDataSource(items);
        }

        private void SetDataSource(List<CostumeItem> items)
        {
            this.currentCostumeitems = items;
            this.currentSource.Clear();
            for (int i = 0; i < items.Count; i++)
            {
               
                items[i].Costume.BrandName = CommonGlobalCache.GetBrandName(items[i].Costume.BrandID);
                items[i].Costume.SupplierName = CommonGlobalCache.GetSupplierName(items[i].Costume.SupplierID);
                if (items[i].CostumeStoreList != null)
                {
                    foreach (var item in items[i].CostumeStoreList)
                    {
                        item.CostumeName = items[i].Costume.Name;
                        item.BrandName = items[i].Costume.BrandName;
                        item.Price = items[i].Costume.Price;
                    }
                     
                }
                this.currentSource.Add(items[i].Costume);
            }
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.currentSource; 
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            {

                string costumeID = this.skinTextBox1.SkinTxt.Text.Trim();
                if (string.IsNullOrEmpty(costumeID))
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                //条形码，先根据条形码获取款号
                //List<BarCode> barCodes = GlobalCache.BarCodeList?.FindAll(t => t.BarCodeValue.ToUpper().Equals(costumeID.ToUpper()));

                ////，条形码为一条，找到这个款号
                //if (barCodes != null && barCodes.Count == 1)
                //{
                //    costumeID = barCodes[0].CostumeID;
                //    this.skinTextBox1.SkinTxt.Text = barCodes[0].BarCodeValue;
                //}
                if (costumeID.Length == 15)
                {
                    BarCode4Costume costume = CommonGlobalUtil.GetBarCode(costumeID);
                    if (costume != null)
                    {
                        costumeID = costume.CostumeID;
                        skinTextBox1.SkinTxt.Text = costume.BarCode;
                        //isBarCode = true;
                    }
                }
                List<CostumeItem> resultList = GlobalCache.ServerProxy.GetPfCustomerStores(CustomerID, costumeID);
             
               
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
                this.ConfirmSelectCell(this.currentCostumeitems[index]);
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

        private void ConfirmSelectCell(CostumeItem item)
        {
            //if (this.CostumeSelected!=null)
            //{
            //    this.CostumeSelected(item,null);
            //}
            Result = item;
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
            //this.ConfirmSelectCell(this.currentCostumeitems[e.RowIndex]);
        }


        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           // BaseButton_OK_Click(null, null);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.ConfirmSelectCell(this.currentCostumeitems[e.RowIndex]);
        }
    }
}
