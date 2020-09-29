using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CCWin.SkinControl;
using JGNet.Core.InteractEntity;
using JGNet.Manage;

namespace JGNet.Manage
{
    public partial class EmOrderTextBox :  JGNet.Common.TextBox
    {

       
        /// <summary>
        /// 款号被选中时触发
        /// </summary>
        public event Action<EmRetailOrder> EmRetailOrderSelected;
        public EmOrderTextBox()
        {
            InitializeComponent();
            base.SkinTxt.PreviewKeyDown += SkinTxt_PreviewKeyDown;
            base.SkinTxt.TextChanged += SkinTxt_TextChanged;
            this.SkinTxt.Text = "";
        }

        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.SkinTxt.Text))
            {
                if (this.EmRetailOrderSelected != null)
                {
                    this.EmRetailOrderSelected(null);
                }
            }
        }


        #region 回车后选择款号
        private void SkinTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)

        {

            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            try
            {

                string costumeID = this.SkinTxt.Text.Trim();
                if (string.IsNullOrEmpty(costumeID))
                {
                    if (this.EmRetailOrderSelected != null)
                    {
                        this.EmRetailOrderSelected(null);
                    }
                    return;
                }

                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                List<EmRetailOrder> resultList = GlobalCache.EMallServerProxy.GetEmRetailOrderIdLike(costumeID.ToUpper());
                if (resultList == null || resultList.Count == 0)
                {
                    if (this.EmRetailOrderSelected != null)
                    {
                        this.EmRetailOrderSelected(null);
                    }
                    this.SkinTxt.Text = "";
                    return;
                }
                if (resultList.Count == 1)
                {
                    // resultList[0].BrandName = CommonGlobalCache.GetBrandName(resultList[0].BrandID);
                    //   resultList[0].SupplierName = CommonGlobalCache.GetSupplierName(resultList[0].SupplierID);

                    if (this.EmRetailOrderSelected != null)
                    {
                        this.EmRetailOrderSelected(resultList[0]);
                    }
                    this.SkinTxt.Text = resultList[0].ID;
                }
                else
                {
                    EmRetailOrderForm costumeForm = new EmRetailOrderForm(resultList, costumeID);
                    costumeForm.EmRetailOrderSelected += CostumeForm_CostumeSelected;
                    costumeForm.ShowDialog();
                    //走吗，将错就错，让他自然过去？
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

        private void CostumeForm_CostumeSelected(EmRetailOrder costumeItem)
        {

            this.SkinTxt.Text = costumeItem.ID;
            if (this.EmRetailOrderSelected != null)
            {
                this.EmRetailOrderSelected(costumeItem);
            }
        }
        #endregion
    }
}
