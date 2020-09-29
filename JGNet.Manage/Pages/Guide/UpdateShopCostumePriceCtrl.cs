using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
using CCWin;

using JGNet.Common.Core.Util;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JGNet.Manage
{/// <summary>
/// 采购退货查询
/// </summary>
    public partial class UpdateShopCostumePriceCtrl : BaseUserControl
    {

        private GetCostumePricesPara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;



        public event CJBasic.Action<PurchaseOrder, Panel, bool> DetailClick;
        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.BaseButton_Search_Click(null, null);
            }
        }


        public UpdateShopCostumePriceCtrl()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.价格管理;
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2);
            dataGridViewPagingSumCtrl2.Initialize();
            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1,
                new string[] {

            });

            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.Initialize();

            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;


            GlobalUtil.SetShop(skinComboBoxShopID,false);
            skinComboBoxShopID.SelectedValue = GlobalCache.GeneralStoreShopID;
          //  CommonGlobalUtil.SetBigClass(skinComboBoxBigClass);
            GlobalUtil.SetBrand(this.skinComboBox_Brand);
        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        private void Initialize()
        {
            this.dataGridView1.AutoGenerateColumns = false;

            this.pagePara = new GetCostumePricesPara();
        }

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                string curShopId = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);
                
                this.pagePara = new GetCostumePricesPara()
                {
                    BrandID = (this.skinComboBox_Brand.SelectedValue != null && int.Parse(this.skinComboBox_Brand.SelectedValue.ToString()) != -1) ? int.Parse(this.skinComboBox_Brand.SelectedValue.ToString()) : -1,
                    ClassID = skinComboBoxBigClass.SelectedValue.ClassID,
                    // SubSmallClass = skinComboBoxBigClass.SelectedValue?.SubSmallClass,
                    CostumeID = costumeFromSupplierTextBox1.Text,
                    ShopId = curShopId,
                };
               
                List<CostumePrice> listPage = GlobalCache.ServerProxy.GetShopCostumePrices(this.pagePara);
                this.BindingReturnOrderSource(listPage);
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

        /// <summary>
        /// 绑定plenishOrderSource源到dataGridView中
        /// </summary>
        /// <param name="listPage"></param>
        private void BindingReturnOrderSource(List<CostumePrice> listPage)
        {
            this.dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(listPage));
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        private void BindingOutboundDetailSource(List<BoundDetail> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (BoundDetail detail in list)
                {
                    detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
                }
            }

            dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(DataGridViewUtil.ListToBindingList(list));

        }

        private void ReturnOrderManageCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
                DataGridView dataGridView = sender as DataGridView;
                CostumePrice costumePrice = dataGridView.Rows[e.RowIndex].DataBoundItem as CostumePrice; 
                UpdateShopCostumePricePara para = new UpdateShopCostumePricePara()
                {
                    ShopId = costumePrice.ShopId,
                    CostumeID = costumePrice.CostumeID,
                    Price = costumePrice.Price,
                    SalePrice = costumePrice.SalePrice, 

            };
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result= GlobalCache.ServerProxy.UpdateShopCostumePrice(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
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


        

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dataGridView1.Rows.Count <= 0) { return; }
            DataGridView dataGridView = sender as DataGridView;
            CostumePrice detail = (CostumePrice)dataGridView.Rows[e.RowIndex].DataBoundItem;
            try
            {

                if (e.ColumnIndex == SalePriceColumn.Index || e.ColumnIndex == priceDataGridViewTextBoxColumn1.Index)
                {
                    decimal newCount = 0;
                    if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        newCount = Decimal.Parse(e.FormattedValue.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
        }
         
        private void costumeFromSupplierTextBox1_CostumeSelected(Costume costume, bool isEnter)
        {
            if (costume != null && isEnter)
            {
                BaseButton_Search_Click(null, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                      List<CostumePrice> list = DataGridViewUtil.BindingListToList<CostumePrice>(dataGridView1.DataSource); 
                    CostumePrice item = (CostumePrice)list[e.RowIndex];
                    if (e.ColumnIndex == ColumnUpdate.Index)
                    {
                        //  this.AddClick(item, this);
                        Edit(item);
                    }
                 
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }

        }


        private void Edit(CostumePrice item)
        {
            UpdateShopPriceAndSalePriceForm form = new UpdateShopPriceAndSalePriceForm(item);
            form.ShowDialog();

        }
    }
}
 