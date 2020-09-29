using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using JGNet.Manage.Model;
using JGNet.Manage.Pages.Setting.BasicSettings.Costume;
using CJBasic.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class WholesaleBeginningSaveCostumeForm : BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private Costume CurItem { get; set; }
        private String customerID;

        public Action<PfCustomerStore> SaveClick;

        private OperationEnum action;



        public WholesaleBeginningSaveCostumeForm(String customerID)
        {
            try
            {
                InitializeComponent();
                this.customerID = customerID;
                this.Text = "新增客户期初库存录入";
                this.action = OperationEnum.Add;
                this.skinTextBox_ID.CostumeSelected += CostumeCurrentShopTextBox1_CostumeSelected;
            }
            catch (Exception ex) {
                GlobalUtil.ShowError(ex);
            }
        }
        private void CostumeCurrentShopTextBox1_CostumeSelected(Costume costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                if (costumeItem != null)
                {
                    this.skinTextBox_Name.Text = costumeItem.Name;
                    if (costumeItem.Name != "")
                    {
                        this.skinTextBox_Name.Enabled = false;
                    }
                    this.numericUpDown_Price.Value = costumeItem.Price;
                    //if (costumeItem.Price > 0)
                    //{
                        this.numericUpDown_Price.Enabled = false;
                    //}
                    this.skinComboBox_Season.skinComboBox.SelectedValue = costumeItem.Season;
                    if (costumeItem.Season != "")
                    {
                        this.skinComboBox_Season.Enabled = false;
                    }
                    this.skinComboBox_Year.SelectedValue = costumeItem.Year;
                    if (costumeItem.Year > 0)
                    {
                        this.skinComboBox_Year.Enabled = false;
                    }
                    this.skinComboBoxBigClass.SelectedValue = costumeItem;
                    if (costumeItem.BigClassID>0)
                    {
                        this.skinComboBoxBigClass.Enabled = false;
                    }
                    this.skinComboBox_Brand.SelectedValue = costumeItem.BrandID;
                    if (costumeItem.BrandID > 0)
                    {
                        this.skinComboBox_Brand.Enabled = false;
                    }
                    this.skinComboBox_SupplierID.SelectedValue = costumeItem.SupplierID;
                    if (costumeItem.SupplierID !="")
                    {
                        this.skinComboBox_SupplierID.Enabled = false;
                    }
                    this.colorComboBox1.SelectedValue = CommonGlobalCache.GetColorIDByName(costumeItem.Colors.Split(',')[0]);
                   
                        this.numericUpDownCostPrice.Value = costumeItem.CostPrice;

                    //if (costumeItem.CostPrice > 0)
                    //{
                        this.numericUpDownCostPrice.Enabled = false;
                    //}
                    numericTextBoxSalePrice.Value = costumeItem.SalePrice;
                    //if (costumeItem.SalePrice >= 0)
                    //{
                        this.numericTextBoxSalePrice.Enabled = false;
                    //}
                    selectSizeGroup = new SizeGroupSetting();
                    if (costumeItem.SizeNames != "")
                    {
                        baseButtonSelectSizeGroup.Enabled = false;
                    }
                    SizeGroup sizeGroup = GlobalCache.GetSizeGroup(costumeItem?.SizeGroupName);
                    selectSizeGroup.Items = costumeItem.SizeNameList;
                    selectSizeGroup.SizeGroup = sizeGroup;
                    //this.selectSizeGroup = selectSizeGroup;
                    SetDataGridData();
                    skinLabelSizeGroup.Text = CommonGlobalUtil.GetSizeDisplayNames(sizeGroup, costumeItem?.SizeNames);
                    if (costumeItem.Remarks != null)
                    {
                        this.skinTextBox_Remarks.Text = costumeItem.Remarks;
                    }

                }
                else
                {

                    this.skinTextBox_Name.Enabled = true; 
                    this.numericUpDown_Price.Enabled = true; 
                    this.skinComboBox_Season.Enabled = true; 
                    this.skinComboBox_Year.Enabled = true; 
                    this.skinComboBoxBigClass.Enabled = true; 
                    this.skinComboBox_Brand.Enabled = true; 
                    this.skinComboBox_SupplierID.Enabled = true;  
                    this.numericUpDownCostPrice.Enabled = true; 
                    this.numericTextBoxSalePrice.Enabled = true; 
                    baseButtonSelectSizeGroup.Enabled = true;
                }
            }
        }
        private PfCustomerStore curStore;
        public WholesaleBeginningSaveCostumeForm(PfCustomerStore store)
        {
            try
            {
                InitializeComponent();
            this.curStore = store;
                
            this.action = OperationEnum.Edit;
            Costume costume = GlobalCache.GetCostume(store.CostumeID);
            if (costume != null)
            {
                this.CurItem = costume;
            }
            else
            {
                costume = new Costume();
                ReflectionHelper.CopyProperty(store, costume);
                costume.ID = store.CostumeID;
                costume.Name = store.CostumeName;
                costume.Colors = store.ColorName;
                this.CurItem = costume;
                    this.customerID = store.PfCustomerID;
            }
                SetSize();
        }
            catch (Exception ex) {
                GlobalUtil.ShowError(ex);
            }
}
        private void SetSize()
        { 
            SizeGroup sizeGroup = GlobalCache.GetSizeGroup(this.CurItem?.SizeGroupName);
            skinLabelSizeGroup.Text = CommonGlobalUtil.GetSizeDisplayNames(sizeGroup, this.CurItem?.SizeNames);
        }
        public void Display()
        {
            try {
                if (CurItem != null)
                {
                    this.BaseButton3.Text = "保存";
                    this.skinTextBox_ID.Enabled = false;
                    this.skinTextBox_ID.Text = this.CurItem.ID;
                    this.skinTextBox_Name.Text = this.CurItem.Name;
                    this.numericUpDown_Price.Value = this.CurItem.Price;
                    this.numericUpDownCostPrice.Value = this.CurItem.CostPrice;
                    numericTextBoxSalePrice.Value = CurItem.SalePrice;
                    this.skinComboBox_SupplierID.SelectedValue = this.CurItem.SupplierID;
                    this.skinComboBox_Brand.SelectedValue = this.CurItem.BrandID;
                    this.skinComboBox_Year.SelectedValue = this.CurItem.Year;
                    if (this.CurItem.Season != null)
                    {
                        this.skinComboBox_Season.skinComboBox.SelectedValue = this.CurItem.Season;
                    }
                    this.selectSizeGroup = new SizeGroupSetting()
                    {
                        SizeGroup = CommonGlobalCache.GetSizeGroup(this.CurItem.SizeGroupName),
                        SelectedSizeNames = this.CurItem.SizeNames
                    };
                    this.skinComboBoxBigClass.SelectedValue = this.CurItem;
                     
                    if (this.CurItem.Remarks != null)
                    {
                        this.skinTextBox_Remarks.Text = this.CurItem.Remarks;
                    }

                    List<PfCustomerStore> stores = new List<PfCustomerStore>();
                    stores.Add(curStore);
                    
                    dataGridViewPagingSumCtrl.BindingDataSource(stores);
                    //if (this.CurItem.Colors != null)
                    //{
                    //    this.textBoxColor.Text = this.CurItem.Colors;
                    //}      

                    this.colorComboBox1.SelectedValue = CommonGlobalCache.GetColorIDByName(curStore.ColorName);
                    //this.textBoxColor.Enabled = false;
                }
                else
                {
                    ResetAll();
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
         
        public List<ListItem<String>> ColorList { get; private set; }

        private void ResetAll()
        {
            this.skinTextBox_ID.Text = string.Empty;
            this.skinTextBox_Name.Text = string.Empty;
            this.numericUpDown_Price.Value = 0;
            this.numericUpDownCostPrice.Value = 0;
            this.numericTextBoxSalePrice.Value = 0;
            this.skinTextBox_Remarks.Text = string.Empty;
            this.ColorList = new List<ListItem<string>>();

            List<PfCustomerStore> stores = new List<PfCustomerStore>();
            PfCustomerStore store = new PfCustomerStore();
            stores.Add(store);
            dataGridViewPagingSumCtrl.BindingDataSource(stores);
            this.BaseButton3.Text = "保存"; 
        }
          
        private void Initialize()
        {
            try
            {
                dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView2 );
                dataGridViewPagingSumCtrl.ShowRowCounts = false;
                dataGridViewPagingSumCtrl.Initialize();
                // CommonGlobalUtil.SetSmallClass(skinComboBox_SmallClass,true);
                //  CommonGlobalUtil.SetBigClass(skinComboBoxBigClass,true);
                // CommonGlobalUtil.SetYear(skinComboBox_Year,true);
                //YearComboBox.
                skinComboBox_Year.Initialize(true);
                //默认选择当年
                this.skinComboBox_Year.SelectedValue = DateTime.Now.Year;
             
                ColorList = new List<ListItem<String>>();
                Display();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }  

        Costume item = null;

        private CostumeStoreExcel GetCostumeStoreExcel(PfCustomerStore item)
        {
            CostumeStoreExcel excel = new CostumeStoreExcel();
            ReflectionHelper.CopyProperty(item, excel);
            return excel;
        }

        private void BaseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                item = GetEntity();

                if (!Validate(item)) { return; }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }

                if (this.CurItem != null)
                {
                    //线上商城原属性不替换
                    item.EmShowOnline = CurItem.EmShowOnline;
                    item.EmOnlinePrice = CurItem.EmOnlinePrice;
                    item.EmTitle = CurItem.EmTitle;
                    item.EmThumbnail = CurItem.EmThumbnail == null ? string.Empty : CurItem.EmThumbnail;
                    item.CreateTime = CurItem.CreateTime;
                    item.SizeNames = CurItem.SizeNames;

                   
                    CostumeColor color = this.colorComboBox1.SelectedItem;
                   List<string> colorList = CurItem.ColorList;
                    if (colorList != null) {
                        if (curStore.ColorName != color.Name) {
                            colorList.Remove(curStore.ColorName);
                            colorList.Add(color.Name);
                        }
                    }
                    
                    item.Colors = CommonGlobalUtil.GetColorFromGridView(colorList);



                    short F = 0, XS = 0, S = 0, M = 0, L = 0, XL = 0, XL2 = 0, XL3 = 0, XL4 = 0, XL5 = 0, XL6 = 0;
                    
                    if (this.dataGridView2!=null && this.dataGridView2.Rows.Count>0)
                    {
                        PfCustomerStore curStoreItem = this.dataGridView2.Rows[0].DataBoundItem as PfCustomerStore;
                        if (curStoreItem!=null)
                        {
                            F = curStoreItem.F;
                            XS = curStoreItem.XS;
                            S = curStoreItem.S;
                            M = curStoreItem.M;
                            L = curStoreItem.L;
                            XL = curStoreItem.XL;
                            XL2 = curStoreItem.XL2;
                            XL3 = curStoreItem.XL3;
                            XL4 = curStoreItem.XL4;
                            XL5 = curStoreItem.XL5;
                            XL6 = curStoreItem.XL6;
                            customerID = curStoreItem.PfCustomerID;
                            
                        } 
                    }
                    UpdateStartStoreCostumePara updateStorePara = new UpdateStartStoreCostumePara()
                    {
                        BrandID = item.BrandID,
                        ClassID = item.ClassID,
                        CostPrice = item.CostPrice,
                        ID = item.ID,
                        Name = item.Name,
                        Price = item.Price,
                        Remarks = item.Remarks,
                        SalePrice = item.SalePrice,
                        Season = item.Season,
                        SizeGroupName = item.SizeGroupName,
                        SizeNames = item.SizeNames,
                        SupplierID = item.SupplierID,
                        Year = item.Year,
                        OldColorName = curStore.ColorName,
                        NewColorName = color.Name,
                         
                        F = F,
                        XS = XS,
                        S = S,
                        L = L,
                        M = M,
                        XL = XL,
                        XL2 = XL2,
                        XL3 = XL3,
                        XL4 = XL4,
                        XL5 = XL5,
                        XL6 = XL6,
                         
                        //ShopID = curStore.PfCustomerID,
                        IsPf = true,
                       PfCustomerID = this.customerID,  
                        // PfCustomerID=  
                         Colors =item.Colors,
                          

                    };
                      InteractResult result = GlobalCache.ServerProxy.UpdateStartStoreCostume(updateStorePara);
                   // InteractResult result = GlobalCache.ServerProxy.UpdateCostume(item);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("保存成功！"); 
                           // GlobalCache.CostumeList_OnChange(item);
                            CurItem = item;
                            this.Hide();
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                    PfCustomerStore costumeStore = dataGridView2.Rows[0].DataBoundItem as PfCustomerStore;
                    PfCustomerStore item = new PfCustomerStore();
                    ReflectionHelper.CopyProperty(costumeStore, item);
                    item.CostumeID = skinTextBox_ID.Text;
                    item.CostumeName = skinTextBox_Name.Text;
                    item.Year = (int)(this.skinComboBox_Year.SelectedValue);
                    item.Price = numericUpDown_Price.Value;
                    // item.SalePrice = 
                    item.CostPrice = numericUpDownCostPrice.Value;
                    item.ClassID= skinComboBoxBigClass.SelectedValue.ClassID;
                    item.ClassCode= GetClassCode(item.ClassID);
                    
                    //线上商城原属性不替换
                    //  item.BigClass = this.skinComboBoxBigClass.SelectedValue?.BigClass;
                    //  item.SmallClass = this.skinComboBoxBigClass.SelectedValue?.SmallClass;
                    //  item.SubSmallClass = this.skinComboBoxBigClass.SelectedValue?.SubSmallClass;
                    if (this.skinComboBox_Brand.SelectedItem != null)
                    {
                        item.BrandID = this.skinComboBox_Brand.SelectedItem.AutoID;
                        item.BrandName = this.skinComboBox_Brand.SelectedItem.Name;
                    }
                    item.Season = ValidateUtil.CheckEmptyValue(this.skinComboBox_Season.SelectedValue);
                    item.SupplierID = skinComboBox_SupplierID.SelectedItem?.ID;
                    item.SupplierName = skinComboBox_SupplierID.SelectedItem?.Name;
                    item.ColorName = this.colorComboBox1.SelectedItem?.Name;
                    item.CostumeColorID = this.colorComboBox1.SelectedItem.ID;
                   // item.CostumeColorName = this.colorComboBox1.SelectedItem?.Name;
                    List<CostumeStoreExcel> costumeStoreExcels = new List<CostumeStoreExcel>();
                    //item.SizeGroupName= selectSizeGroup.SelectedSizeNames
                    if (selectSizeGroup!=null && selectSizeGroup.SizeGroup != null)
                    {
                        item.SizeGroupName = selectSizeGroup.SizeGroup.SizeGroupName;
                        item.SizeGroupShowName = selectSizeGroup.SizeGroup.ShowName;
                         
                     //   item.SizeNames = selectSizeGroup.SelectedSizeNames;
                    }
                    PfCustomer  pfCustomer=PfCustomerCache.GetPfCustomer(customerID);
                  item.SalePrice=this.numericTextBoxSalePrice.Value;
                    CostumeStoreExcel curCostumeStoreExcel = GetCostumeStoreExcel(item);
                    curCostumeStoreExcel.CostumeColorName = item.ColorName;
                    curCostumeStoreExcel.PfPrice = pfCustomer.PfDiscount * item.Price/100;

                    costumeStoreExcels.Add(curCostumeStoreExcel);
                     

                    CreatePfCostumeStore store = new CreatePfCostumeStore()
                    {
                         PfCustomerID = customerID,
                          
                       // Date = new CJBasic.Date(),
                        CostumeStoreExcels = costumeStoreExcels,
                        
                        IsImport = true
                    };
                     
                    InteractResult result = GlobalCache.ServerProxy.InsertPfCostumeStores(store);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("新增成功！");
                            ResetAll();
                            this.Close();
                            SaveClick?.Invoke(item);
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private string GetClassCode(int classID)
        {
            String code = string.Empty;
            try
            {
                InteractResult classResult = CommonGlobalCache.ServerProxy.GetClassCode4ID(this.skinComboBoxBigClass.SelectedValue.ClassID);
                switch (classResult.ExeResult)
                {
                    case ExeResult.Success:
                        code = classResult.Msg;
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(classResult.Msg);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally {
            }
            return code;
        }

        private void DoNotify()
        {
            //图片保存成功，通知商户网站地址，账套信息，款号
            String response = CommonGlobalUtil.BusinessWebCostumePhotoChangeNotify(item.ID);
        } 

        private bool Validate(Costume item)
        {
            bool success = true;
            if (String.IsNullOrEmpty(item.ID))
            {
                this.skinTextBox_ID.Focus();
                success = false;
                GlobalMessageBox.Show("请输入款号！");
            }else  if (item.ID.Contains("#"))
            {
                this.skinTextBox_ID.Focus();
                success = false;
                GlobalMessageBox.Show("款号不能使用“#”！");
            }
            else if (String.IsNullOrEmpty(item.Name))
            {
                skinTextBox_Name.Focus();
                success = false;
                GlobalMessageBox.Show("请输入名称！");
            }
            else if (item.Price == 0)
            {
                numericUpDown_Price.Focus();
                success = false;
                GlobalMessageBox.Show("价格不能为0！");
            }
            else if (item.Price > 0 && item.Price > Convert.ToDecimal(99999999.99))
            {

                numericUpDown_Price.Focus();
                success = false;
                GlobalMessageBox.Show("价格不能大于99999999.99！");
            }
            else if (item.CostPrice == 0)
            {
                numericUpDownCostPrice.Focus();
                success = false;
                GlobalMessageBox.Show("进货价不能为0！");
            }
            else if (item.CostPrice > 0 && item.CostPrice > Convert.ToDecimal(99999999.99))
            {
                numericUpDownCostPrice.Focus();
                success = false;
                GlobalMessageBox.Show("进货价不能大于99999999.99！");
            }
            else if (item.SalePrice > 0 && item.SalePrice > Convert.ToDecimal(99999999.99))
            {
                numericTextBoxSalePrice.Focus();
                success = false;
                GlobalMessageBox.Show("售价不能大于99999999.99！");
            }
            else if (this.skinComboBox_Year.SelectedValue==null)
            {
                skinComboBox_Year.Focus();
                success = false;
                GlobalMessageBox.Show("请选择年份！");
            }
            else if (String.IsNullOrEmpty(this.skinComboBox_Season.skinComboBox.SelectedValue?.ToString()))
            {
                skinComboBox_Season.skinComboBox.Focus();
                success = false;
                GlobalMessageBox.Show("请选择季节！");
            }
            else if (this.skinComboBoxBigClass.SelectedValue.ClassID==-1)
            {
                skinComboBoxBigClass.Focus();
                success = false;
                GlobalMessageBox.Show("请选择类别！");
            }

            else if (String.IsNullOrEmpty(this.skinComboBox_SupplierID.SelectedValue?.ToString()))
            {
                skinComboBox_SupplierID.Focus();
                success = false;
                GlobalMessageBox.Show("请选择供应商！");
            }
            else if (this.colorComboBox1.SelectedItem!=null && String.IsNullOrEmpty(this.colorComboBox1.SelectedValue.ToString()))
            {
                colorComboBox1.Focus();
                success = false;
                GlobalMessageBox.Show("请选择颜色！");
            }
            
            else if (String.IsNullOrEmpty(this.skinComboBox_Brand.skinComboBox.SelectedValue?.ToString()))
            {
                skinComboBox_Brand.skinComboBox.Focus();
                success = false;
                GlobalMessageBox.Show("请选择品牌！");
            }

            return success;
        }

        private Costume GetEntity()
        {
            Costume item = new Costume();

            item.ID = this.skinTextBox_ID.Text.Trim();
            item.Name = this.skinTextBox_Name.Text.Trim();
            item.Price = this.numericUpDown_Price.Value;
            //20180602增加默认线上价格
            item.EmOnlinePrice = item.Price;
            item.CostPrice = this.numericUpDownCostPrice.Value;
            item.SalePrice = this.numericTextBoxSalePrice.Value;
            item.SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBox_SupplierID.SelectedValue);
            String brandId = ValidateUtil.CheckEmptyValue(this.skinComboBox_Brand.SelectedValue);
            if (brandId != null)
            {
                item.BrandID = int.Parse(brandId);
            } 
             if (this.skinComboBox_Year.SelectedValue != null) item.Year = (int)this.skinComboBox_Year.SelectedValue;
            //else
            //{
            //    this.skinComboBox_Year.SelectedValue = DateTime.Now.Year;
            //    item.Year = (int)this.skinComboBox_Year.SelectedValue;
            //}
            item.Season = ValidateUtil.CheckEmptyValue(this.skinComboBox_Season.skinComboBox.SelectedValue);
            item.ClassID  = this.skinComboBoxBigClass.SelectedValue.ClassID;
            //item.BigClass = this.skinComboBoxBigClass.SelectedValue?.BigClass;
            //item.SmallClass = this.skinComboBoxBigClass.SelectedValue?.SmallClass;
            //item.SubSmallClass = this.skinComboBoxBigClass.SelectedValue?.SubSmallClass;
           // item.Photo = null;//图片不缓存本地
                              //从列表获取颜色属性并拼起来
          //  item.Colors = this.textBoxColor.Text;
            item.Remarks = this.skinTextBox_Remarks.Text.Trim();
            item.IsValid = true;
            if (selectSizeGroup != null &&  selectSizeGroup.SizeGroup != null)
            {
                item.SizeGroupName = selectSizeGroup.SizeGroup.SizeGroupName;

                item.SizeNames = selectSizeGroup.SelectedSizeNames;
            }
            return item;
        }
         

        public void Refresh(Costume e)
        {
            CurItem = e;
            Display();
        }


        private void skinComboBox_Color_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                List<CostumeColor> listNew = new List<CostumeColor>();
                //  skinComboBox_Brand.Items.Clear();
                SkinComboBox box = (SkinComboBox)sender;
                String str = box.Text;
                foreach (var item in GlobalCache.CostumeColorList)
                {
                    if ((item.ID + item.Name + item.FirstCharSpell).ToUpper().Contains(str.ToUpper()))
                    {
                        listNew.Add(item);
                    }
                }

                if (listNew.Count == 0)
                {
                    listNew = GlobalCache.CostumeColorList;
                }

                box.DataSource = listNew;
                box.Text = str;
                box.SelectionStart = str.Length;
                box.DroppedDown = true;//自动展开下拉框
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        } 
         

        private void numericUpDown_Price_ValueChanged(object sender)
        { 
                try
                {
                    decimal discount = 1;

                    List<ListItem<string>> config = GlobalCache.GetParameterConfig(ParameterConfigKey.SupplierDiscount);
                    if (config != null && config.Count > 0)
                    {
                        discount = Convert.ToDecimal(config[0].Value);
                    }
                    numericUpDownCostPrice.Value = Math.Round(numericUpDown_Price.Value * discount, 0, MidpointRounding.AwayFromZero);
                }
                catch (Exception ex)
                {
                    // GlobalUtil.ShowError(ex);
                } 
        }

        public void ShowNew(Control parent) {
            try
            {
                this.TopMost = true;
                this.ShowDialog(parent);
               //ctrl.Search(para);
                this.TopMost = false;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EarlyStageCostumeStoreRecordSaveCostumeForm_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private SizeGroupSetting selectSizeGroup=null;

        //  private List<CostumeStore> addValue = new List<CostumeStore>();

        private void SetDataGridData()
        {
            if (selectSizeGroup.Items.Count > 0)
            {
                List<string> disNames = selectSizeGroup.DisplayItems;
                List<string> Names = selectSizeGroup.Items;
                                                     
                List<PfCustomerStore> stores = new List<PfCustomerStore>();
                PfCustomerStore costumeStore = new PfCustomerStore();
                //  stores.Add();

                for (int j = 0; j < this.dataGridView2.Columns.Count; j++)
                {
                    bool flag = true;
                    for (int k = 0; k < selectSizeGroup.Items.Count; k++)
                    {
                        if (this.dataGridView2.Columns[j].DataPropertyName == selectSizeGroup.Items[k])
                        {
                            this.dataGridView2.Columns[j].HeaderText = disNames[k];
                            this.dataGridView2.Columns[j].Visible = true;
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        this.dataGridView2.Columns[j].Visible = false;
                    }

                }

                //dataGridView2.DataSource = addValue
            }
        }
        private void baseButtonSelectSizeGroup_Click(object sender, EventArgs e)
        {
            SizeGroupSelectForm size = new SizeGroupSelectForm(selectSizeGroup, skinTextBox_ID.Text);
            size.ShowDialog(this);
            if (size.DialogResult == DialogResult.OK)
            {
                selectSizeGroup = size.Result;
                skinLabelSizeGroup.Text = selectSizeGroup.SelectedDisplaySizeNames;

                SetDataGridData();
             /*   if (selectSizeGroup.Items.Count > 0)
                {
                    List<string> disNames = selectSizeGroup.DisplayItems;
                    List<string> Names = selectSizeGroup.Items;
                    List<CostumeStore> stores = new List<CostumeStore>();
                    CostumeStore costumeStore = new CostumeStore();
                    //  stores.Add();
                    
                    for (int j = 0; j < this.dataGridView2.Columns.Count; j++)
                    {
                        bool flag = true;
                        for (int k = 0; k < selectSizeGroup.Items.Count; k++)
                        {
                            if (this.dataGridView2.Columns[j].DataPropertyName == selectSizeGroup.Items[k])
                            {
                                this.dataGridView2.Columns[j].HeaderText = disNames[k];
                                this.dataGridView2.Columns[j].Visible = true;
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            this.dataGridView2.Columns[j].Visible = false;
                        }

                    }

                    //dataGridView2.DataSource = addValue
                }*/

            }

            /*  addValue.Clear();
              addValue.Add(new CostumeStore());
              dataGridView2.DataSource = null;
              dataGridView2.DataSource = addValue;*/
              
           
        }
    }
}
