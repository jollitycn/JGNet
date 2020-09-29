using CCWin;
using JGNet.Common;
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
    public partial class SingleDiscountForm : Common.BaseForm
    {
        /// <summary>
        /// 折扣确认后触发
        /// </summary>
        public event CJBasic.Action<int, string> DiscountConfirm;
        private string curShopId;
        public SingleDiscountForm(string ShopId)
        {
            InitializeComponent();
            curShopId = ShopId;
            this.DiscountConfirm+= delegate { };
        }

        private void BaseButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                int discount = int.Parse(this.skinTextBox_Discount.SkinTxt.Text.Trim());
                if (discount > 100)
                {
                    GlobalMessageBox.Show("折扣值不能大于100");
                    return;
                }
                if (discount < GlobalCache.GetShop(curShopId).MinDiscount)
                {
                    GlobalMessageBox.Show(string.Format("本店最低折扣值{0},输入值不能低于它", GlobalCache.GetShop(curShopId).MinDiscount));
                    return;
                }

              this.DiscountConfirm(discount,"");
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                GlobalMessageBox.Show("折扣格式不正确！");
            }
            
        }

        private void BaseButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
