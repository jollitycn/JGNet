using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Core.InteractEntity;
using JGNet.Manage; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class UpdateShopPriceAndSalePriceForm : 
        BaseForm
    {
        private CostumePrice curItem;
        public UpdateShopPriceAndSalePriceForm(CostumePrice item)
        {
            InitializeComponent(); 
            if (item != null) {
                curItem = item;
                this.skinLabelCustomer.Text = item.CostumeID;
                skinTextBoxPrice.Text = item.Price.ToString();
                skinTextBoxSalePrice.Text = item.SalePrice.ToString();
                
            } 
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(skinTextBoxPrice.Text.Trim()))
            {
                GlobalMessageBox.Show("吊牌价不能为空！");
                skinTextBoxPrice.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(skinTextBoxPrice.Text.Trim()) > 0 && Convert.ToDecimal(skinTextBoxPrice.Text.Trim()) > Convert.ToDecimal(99999999.99))
                {
                    GlobalMessageBox.Show("吊牌价不能大于9999999.99！");
                    skinTextBoxPrice.Focus();
                    return;
                }
            }
            if (String.IsNullOrEmpty(skinTextBoxSalePrice.Text.Trim()))
            {
                GlobalMessageBox.Show("售价不能为空！");
                skinTextBoxSalePrice.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(skinTextBoxSalePrice.Text.Trim()) > 0 && Convert.ToDecimal(skinTextBoxSalePrice.Text.Trim()) > Convert.ToDecimal(99999999.99))
                {
                    GlobalMessageBox.Show("售价不能大于9999999.99！");
                    skinTextBoxSalePrice.Focus();
                    return;
                }
            }

            UpdateCostumeStorePricePara updatePrice = new UpdateCostumeStorePricePara()
            {
                CostumeID = this.skinLabelCustomer.Text,
                Price = Convert.ToDecimal(this.skinTextBoxPrice.Text.ToString()),
                SalePrice = Convert.ToDecimal(this.skinTextBoxSalePrice.Text.ToString()),
                shopIDs = GetShops(),
            };
            InteractResult iResult = GlobalCache.ServerProxy.UpdateCostumeStorePrice(updatePrice);

            switch (iResult.ExeResult)
            {
                case ExeResult.Success:
                    GlobalMessageBox.Show("修改成功！");
                    this.Close();
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(iResult.Msg);
                    break;
                default:
                    break;
            }

        }

        internal void Cancel()
        {
            this.Enabled = true;
        }

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private List<string> GetShops()
        {
            String shopIDStr = "";
            List<Shop> shops = (List<Shop>)this.dataGridViewRole.DataSource;
            List<string> shopList = new List<string>();
            foreach (var item in shops)
            {
                if (item.Selected)
                {
                    shopList.Add(item.ID);
                }
               

            }
            return shopList;
        }
        private void UpdateShopPriceAndSalePriceForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewRole.AutoGenerateColumns = false;
                List<Shop> shopList = GlobalCache.ServerProxy.GetShopList().FindAll(t => t.Enabled == true);
                foreach (Shop shopItem in shopList)
                {
                    if (curItem.ShopId == shopItem.ID)
                    {
                        shopItem.Selected = true;
                    }
                }
                 dataGridViewRole.DataSource = shopList;
              
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }

        }

        private void skinCheckBoxNew_CheckedChanged(object sender, EventArgs e)
        {
            List<Shop> list = (List<Shop>)dataGridViewRole.DataSource;
            if (this.skinCheckBoxNew.Checked)
            {
                
                foreach (Shop item in list)
                {
                    item.Selected = true;
                }
              
            }
            else
            {
                foreach (Shop item in list)
                {
                    item.Selected = false;
                }
            }
            dataGridViewRole.DataSource = null;
                dataGridViewRole.DataSource = list;
        }
    }
}
