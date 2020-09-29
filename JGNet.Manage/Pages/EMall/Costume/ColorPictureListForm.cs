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
    public partial class ColorPictureListForm : Common.BaseForm
    {
        /// <summary>
        /// 折扣确认后触发
        /// </summary>
        public event Action<EmCostumePhoto> DiscountConfirm;
        //Action<EmCostumeInfo>

        private string curShopId;
        List<EmCostumePhoto> CurCostumePhoto;
        public ColorPictureListForm(string ShopId, List<EmCostumePhoto> costumePhotos)
        {
            InitializeComponent();
            curShopId = ShopId;
            CurCostumePhoto = costumePhotos;
            databindPic();
           this.DiscountConfirm+= delegate { };
        }
        private void databindPic()
        {
            try {  
            List<ListViewItem> lItems = new List<ListViewItem>();
            if (CurCostumePhoto != null)
            {
                for (int i = 0; i < CurCostumePhoto.Count; i++)
                {
                    if (CurCostumePhoto[i] != null)
                    {
                        this.imageList1.Images.Add(CurCostumePhoto[i].Image);
                        this.imageList1.Images.SetKeyName(i, CurCostumePhoto[i].PhotoName);
                        System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(CurCostumePhoto[i].PhotoName, i);
                        listViewItem1.Tag = CurCostumePhoto[i];
                        lItems.Add(listViewItem1);
                    }

                }
            }
            this.listView1.LargeImageList = this.imageList1;
              this.listView1.Items.AddRange(lItems.ToArray());

            }
            catch (Exception ex)
            {
                WriteLog("Message:" + ex.Message + "StackTrace:" + ex.StackTrace);
                GlobalMessageBox.Show(ex.Message + "StackTrace:" + ex.StackTrace);
            }
        }

        private void BaseButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                /*  int discount = int.Parse(this.skinTextBox_Discount.SkinTxt.Text.Trim());
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

                this.DiscountConfirm(discount,"");*/
                if (listView1.SelectedItems.Count > 0)
                {
                    this.DiscountConfirm((EmCostumePhoto)listView1.SelectedItems[0].Tag);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                GlobalMessageBox.Show(ex.Message);
            }
            
        }

        private void BaseButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ColorPictureListForm_Load(object sender, EventArgs e)
        {
           // databindPic();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string strName = listView1.SelectedItems[0].Name;

                this.DiscountConfirm((EmCostumePhoto)listView1.SelectedItems[0].Tag);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
