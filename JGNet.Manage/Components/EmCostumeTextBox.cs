using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CCWin.SkinControl;
using JGNet.Core.InteractEntity;
using JGNet.Common;
using JGNet.Core.Tools;

namespace JGNet.Manage
{
    public partial class EmCostumeTextBox : JGNet.Common.TextBox
    {


        /// <summary>
        /// 款号被选中时触发
        /// </summary>
        public event System.Action<Costume> CostumeSelected;
        public EmCostumeTextBox()
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
                if (this.CostumeSelected != null)
                {
                    this.CostumeSelected(null);
                }
            }
        }
        private bool filterValid = true;
        public bool FilterValid
        {
            get { return filterValid; }
            set
            {
                filterValid = value;
            }
        }


        private bool emOnline = true;
        public bool EmOnline
        {
            get
            {
                return emOnline;
            }
            set { emOnline = value; }
        }

        private bool
   isBarCode  { get; set; }
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
                    if (this.CostumeSelected != null)
                    {
                        this.CostumeSelected(null);
                    }
                    return;
                }

                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                //条形码，先根据条形码获取款号
                //List<BarCode> barCodes = GlobalCache.BarCodeList?.FindAll(t => t.BarCodeValue.ToUpper().Contains(costumeID.ToUpper()));

                ////，条形码为一条，找到这个款号
                //if (barCodes != null && barCodes.Count == 1)
                //{
                //    costumeID = barCodes[0].CostumeID;
                //    this.SkinTxt.Text = barCodes[0].BarCodeValue;
                //    isBarCode = true;
                //}
                if (costumeID.Length == 15)
                {
                    BarCode4Costume costume = CommonGlobalUtil.GetBarCode(costumeID);
                    if (costume != null)
                    {
                        costumeID = costume.CostumeID;
                        SkinTxt.Text = costume.BarCode;
                        isBarCode = true;
                    }
                }

                List<Costume> resultList = GlobalCache.CostumeList.FindAll(t => (t.ID.ToUpper().Contains(costumeID.ToUpper()) || t.Name.ToUpper().Contains(costumeID.ToUpper())) && t.EmShowOnline == EmOnline );
                if (filterValid)
                {
                    resultList = resultList.FindAll(t => t.IsValid);
                }
                if (resultList == null || resultList.Count == 0)
                {
                    if (this.CostumeSelected != null)
                    {
                        this.CostumeSelected(null);
                    }
                    this.SkinTxt.Text = "";
                    return;
                }
                if (resultList.Count == 1)
                {
                    resultList[0].BrandName = GlobalCache.GetBrandName(resultList[0].BrandID);
                    resultList[0].SupplierName = GlobalCache.GetSupplierName(resultList[0].SupplierID);
                    if (!isBarCode)
                    {
                        this.SkinTxt.Text = resultList[0].ID;
                    }
                    if (this.CostumeSelected != null)
                    {
                        this.CostumeSelected(resultList[0]);
                    }
                }
                else
                {
                    EmCostumeForm costumeForm = new EmCostumeForm(resultList, costumeID, filterValid,emOnline);
                    costumeForm.CostumeSelected += CostumeForm_CostumeSelected;
                    costumeForm.ShowDialog();
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

        private void CostumeForm_CostumeSelected(Costume costumeItem)
        {

            this.SkinTxt.Text = costumeItem.ID;
            if (this.CostumeSelected != null)
            {
                this.CostumeSelected(costumeItem);
            }
        }
        #endregion
    }
}
