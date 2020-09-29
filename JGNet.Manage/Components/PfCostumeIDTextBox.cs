using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CCWin.SkinControl;
using CCWin;
using JGNet.Manage;
using JGNet.Core.Tools;
using CJBasic.Helpers;

namespace JGNet.Common
{ 
    public partial class PfCostumeCurrentShopTextBox :  JGNet.Common.TextBox
    {

        
        /// <summary>
        /// 款号被选中时触发
        /// </summary>
        public event System.Action<CostumeItem> CostumeSelected;
        private bool isBarCode = false;
       public String CustomerID { get; set; }
        private bool filterValid = true;
        public bool FilterValid { get { return filterValid; }set { filterValid = value; } }

         
            public PfCostumeCurrentShopTextBox()
        {
            InitializeComponent();
            base.SkinTxt.PreviewKeyDown += SkinTxt_PreviewKeyDown;
            base.SkinTxt.TextChanged += SkinTxt_TextChanged; 
            base.SkinTxt.Text = "";
            base.Text = "";
            this.Text = "";
            this.SkinTxt.Text = "";
             
            base.WaterText = "输入款号或条形码回车";
            base.SkinTxt.WaterText = "输入款号或条形码回车";
        }

        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
            //if (this.Text.Contains("pfCustomerIDTextBox"))
            //{
            //    this.Text = "";
            //    this.SkinTxt.Text = "";
            //}
            if (String.IsNullOrEmpty(this.SkinTxt.Text))
            {
                if (this.CostumeSelected != null)
                {
                    this.CostumeSelected(null);
                }
            }
        }

        private void SkinTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //取消登登登
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true;
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
                isBarCode = false;
                string costumeID = this.SkinTxt.Text.Trim();
                if (string.IsNullOrEmpty(costumeID))
                {
                    if (this.CostumeSelected != null)
                    {
                        this.CostumeSelected(null);
                    }
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                //条形码，先根据条形码获取款号
                //List<BarCode> barCodes = CommonGlobalCache.BarCodeList?.FindAll(t => t.BarCodeValue.ToUpper().Equals(costumeID.ToUpper()));

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




                List<Costume> resultList = CommonGlobalCache.CostumeList.FindAll(t => t.ID.ToUpper().Contains(costumeID.ToUpper()) && t.IsValid==true);
              //  List<CostumeItem> resultList = GlobalCache.ServerProxy.GetPfCustomerStores("", costumeID);
                if (resultList == null || resultList.Count == 0)
                {
                    this.CostumeSelected?.Invoke(null);
                   //this.SkinTxt.Text = "";

                    return;
                }
                if (resultList.Count == 1)
                {
                    List<CostumeItem> OneresultList = GlobalCache.ServerProxy.GetPfCustomerStores(CustomerID, costumeID,true);
                    if (OneresultList.Count == 0) {
                        CostumeItem createItem = new CostumeItem();

                        createItem.Costume = resultList[0];
                        createItem.CostumeStoreList = SetupStores(resultList[0]);
                        OneresultList.Add(createItem);
                    }  
                    OneresultList[0].Costume.BrandName = CommonGlobalCache.GetBrandName(OneresultList[0].Costume.BrandID);
                    OneresultList[0].Costume.SupplierName = CommonGlobalCache.GetSupplierName(OneresultList[0].Costume.SupplierID);
                      if (OneresultList[0].CostumeStoreList != null)
                      {
                          foreach (var item in OneresultList[0].CostumeStoreList)
                          {
                              item.CostumeName = OneresultList[0].Costume.Name;
                              item.BrandName = OneresultList[0].Costume.BrandName;
                              item.Price = OneresultList[0].Costume.Price;
                          }
                      }


                      if (!isBarCode)
                      {
                          this.SkinTxt.Text = OneresultList[0].Costume.ID;
                      } 
                      if (this.CostumeSelected != null)
                      {
                          this.CostumeSelected(OneresultList[0]);
                      }
                }
                else
                {
                    PfCostumeFromShopForm costumeForm = new PfCostumeFromShopForm(resultList, costumeID, CustomerID, filterValid);
                    //   costumeForm.Hide();
                    // costumeForm.CostumeSelected += CostumeForm_CostumeSelected;
                    if (costumeForm.ShowDialog() == DialogResult.OK)
                    {
                        if (costumeForm.Result == null)
                        {
                            return;
                        }
                        this.SkinTxt.Text = costumeForm.Result.Costume.ID;
                        CostumeSelected?.Invoke(costumeForm.Result);
                    }
                }
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
        private static List<CostumeStore>  SetupStores(Costume costume)
        {
            List<CostumeStore> store = new List<CostumeStore>();
            ReflectionHelper.CopyProperty(costume, store);
            foreach (string s in costume.Colors.Split(','))
            {
                CostumeStore sItem = new CostumeStore();
                sItem.ColorName = s;
                sItem.F = 0;
                sItem.L = 0;
                sItem.XS = 0;
                sItem.M = 0;
                sItem.S = 0;
                sItem.XL = 0;
                sItem.XL2 = 0;
                sItem.XL3 = 0;
                sItem.XL4 = 0;
                sItem.XL5 = 0;
                sItem.XL6 = 0;
                store.Add(sItem);
            }
            return store;
        }
        protected void UnLockPage()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new CJBasic.CbGeneric(this.UnLockPage));
            }
            else
            {
                CommonGlobalUtil.UnLockPage(this);
            }
        }

        protected void ShowError(Exception ex)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new CJBasic.CbGeneric<Exception>(this.ShowError), ex);
            }
            else
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }
        private void CostumeForm_CostumeSelected(CostumeItem costumeItem, EventArgs args)
        {
            if (costumeItem == null)
            {
                return;
            }
            this.SkinTxt.Text = costumeItem.Costume.ID;
            if (this.CostumeSelected != null)
            {
                this.CostumeSelected(costumeItem);
            }
        }
        #endregion
    }
}
