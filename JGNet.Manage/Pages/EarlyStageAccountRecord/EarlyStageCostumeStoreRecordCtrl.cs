using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core.InteractEntity;
using CCWin;

using JGNet.Common.Core;  
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using CCWin.SkinControl;
using JGNet.Manage.Components;
using JGNet.Common;
using JGNet.Core;
using CJBasic.Helpers;
using JieXi.Common;
using CJBasic;

namespace JGNet.Manage
{
    public partial class EarlyStageCostumeStoreRecordCtrl : BaseModifyUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private SupplierAccountRecordPagePara pagePara;

        public Action< BaseUserControl> End;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public EarlyStageCostumeStoreRecordCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1,new String[] {
        fDataGridViewTextBoxColumn.DataPropertyName,
        xSDataGridViewTextBoxColumn.DataPropertyName,
        sDataGridViewTextBoxColumn.DataPropertyName,
        mDataGridViewTextBoxColumn.DataPropertyName,
        lDataGridViewTextBoxColumn.DataPropertyName,
        xLDataGridViewTextBoxColumn.DataPropertyName,
        xL2DataGridViewTextBoxColumn.DataPropertyName,
        xL3DataGridViewTextBoxColumn.DataPropertyName,
        xL4DataGridViewTextBoxColumn.DataPropertyName,
        xL5DataGridViewTextBoxColumn.DataPropertyName,
        xL6DataGridViewTextBoxColumn.DataPropertyName
    });

            MenuPermission = RolePermissionMenuEnum.期初库存录入;
            dataGridViewPagingSumCtrl.Initialize();
        }
         
        private bool reportShowZero;
        private void Initialize()
        {
            
           skinComboBoxShopID.Initialize(true); 
            ResetAll(false); 
        }
         

        private List<ListItem<String>> ParameterConfigList(List<ListItem<String>> listItems)
        {
            List<ListItem<String>> list = new List<ListItem<String>>();
            list.AddRange(listItems);
            return list;
        }

        private void BindingSource(CostumeStoreInfoSum listPage)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<CostumeStoreInfoSum>(this.BindingSource), listPage);
            }
            else
            {
                if (listPage != null)
                {
                    foreach (var item in listPage.CostumeStores)
                    {
                      //  item.CostumeName = CommonGlobalCache.GetCostumeName(item.CostumeID);
                        item.ShopName = CommonGlobalCache.GetShopName(item.ShopID);
                    }
                }

                dataGridViewPagingSumCtrl.BindingDataSource<CostumeStore>(DataGridViewUtil.ListToBindingList(listPage?.CostumeStores),false, listPage?.CostumeStoreSum);
                CompleteProgressForm();
            }
        }


        private void BindingSource(List<CostumeStore> listPage)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<List<CostumeStore>>(this.BindingSource), listPage);
            }
            else
            {
                if (listPage != null)
                {
                    foreach (var item in listPage)
                    {
                        item.ShopName = CommonGlobalCache.GetShopName(item.ShopID);
                    }
                }
                if (costumeTextBox1.Text != "")
                {
                    dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(Column2);
                }
                else
                {
                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(Column2);
                }
                dataGridViewPagingSumCtrl.BindingDataSource<CostumeStore>(DataGridViewUtil.ListToBindingList(listPage));
                CompleteProgressForm();
            }
        }

        public override void RefreshPage()
        {
            this.BaseButton_Search_Click(null, null);
        }

        private void SupplierAccountSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private String shopID;
        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                brand = skinComboBox_Brand.SelectedItem as Brand;
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoSwitchShop);
                isFilter = false;
                cb.BeginInvoke(null, null);
                ShowProgressForm();
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
            finally
            {
                CompleteProgressForm();
                UnLockPage();
            }
        }

        Brand brand;
        private void DoSwitchShop()
        {
            try
            {
                String costumeID = costumeTextBox1.Text;
                if ((brand == null || brand.AutoID == -1) && String.IsNullOrEmpty(costumeID))
                {
                    isFilter = false;
                }
                else
                {
                    isFilter = true;
                }
                if (brand == null)
                {
                    brand = new Brand();
                    brand.AutoID = 0;
                }
               
                CostumeStoreInfoSum listPage = GlobalCache.ServerProxy.GetCostumeStores(shopID, costumeID, brand.AutoID);
                InitProgress(listPage.CostumeStores.Count);
                this.curInboundDetailList = listPage.CostumeStores;
                BindingSource(curInboundDetailList);
            }
            catch (Exception ex)
            {
                FailedProgress(ex);
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {

            EarlyStageCostumeStoreRecordSaveCostumeForm form = new EarlyStageCostumeStoreRecordSaveCostumeForm(shopID);
            form.SaveClick += EarlyStageCostumeStoreRecordSaveCostumeForm_SaveClick;
            form.ShowDialog(); 
        }

        private void EarlyStageCostumeStoreRecordSaveCostumeForm_SaveClick(CostumeStore obj)
        {
            BaseButton_Search_Click(null, null);
        }

        private List<CostumeStore> addValue = new List<CostumeStore>();

        private void ResetAll(bool restColor = true)
        {
            addValue.Clear();
            addValue.Add(new CostumeStore()); 
        }

        private List<CostumeStore> curInboundDetailList = new List<CostumeStore>();//当前要入库的CostumeStore
        private void BindingInboundDetailSource()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                dataGridViewPagingSumCtrl.BindingDataSource<CostumeStore>(DataGridViewUtil.ListToBindingList(this.curInboundDetailList));
         
            dataGridViewPagingSumCtrl.ScrollToEnd();
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

        private void HighlightCostume(CostumeStore store)
        {
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    CostumeStore rowStore = row.DataBoundItem as CostumeStore;
                    if (rowStore.ShopID == store.ShopID && rowStore.CostumeID == store.CostumeID && rowStore.ColorName == store.ColorName)
                    {
                        row.DefaultCellStyle.ApplyStyle(new DataGridViewCellStyle()
                        {
                            BackColor = Color.LightYellow
                        });
                    }
                }
            }
        } 
         
        private void BaseButtonRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshPage();
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            this.BaseButton_Search_Click(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    case "编辑":
                        CostumeStore store= this.dataGridView1.Rows[e.RowIndex].DataBoundItem as CostumeStore;
                        EarlyStageCostumeStoreRecordSaveCostumeForm form = new EarlyStageCostumeStoreRecordSaveCostumeForm(store);
                        if (form.ShowDialog() == DialogResult.OK) {
                            this.BaseButton_Search_Click(null, null);
                        }   
                        break;
                    case "删除":
                        DialogResult dialogResult = GlobalMessageBox.Show("确定删除该行数据吗？", "提示", MessageBoxButtons.OKCancel);
                        if (dialogResult != DialogResult.OK)
                        {
                            return;
                        }
                       // GlobalCache.ServerProxy.HideCreateStore()
                        this.curInboundDetailList.RemoveAt(e.RowIndex); 
                        this.BindingInboundDetailSource();
                        break;
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }
          

        private void baseButtonEnd_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalMessageBox.Show("期初库存只能录入一次，确定录入完毕？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                InteractResult result = GlobalCache.ServerProxy.HideCreateStore();

                switch (result.ExeResult)
                {
                    case ExeResult.Success: 
                        TabPageClose(this.CurrentTabPage, this.SourceCtrlType);
                        GlobalUtil.SaveParameters(ParameterConfigKey.IsHideCreateStore, "1");
                        End?.Invoke(this);
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void baseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalMessageBox.Show("确定保存该店铺的期初库存吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                bool flagIsRepeat;
                CreateCostumeStore store = new CreateCostumeStore()
                { 
                    ShopID = shopID, 
                     Date = new Date( dateTimePicker_Start.Value),    
                      CostumeStoreExcels = GetCostumeStoreExcels(out flagIsRepeat),
                       IsImport = isFilter
                };

                if (flagIsRepeat)
                {
                    GlobalMessageBox.Show("存在重复颜色的款号，请确认后再保存！");
                    return;
                }
                InteractResult result =  GlobalCache.ServerProxy.InsertCostumeStores(store);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("保存成功！"); 
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                } 
           
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private List<CostumeStoreExcel> GetCostumeStoreExcels(out bool flagIsRepeat)
        {
            List<CostumeStoreExcel> excels = new List<CostumeStoreExcel>();
            flagIsRepeat = false;     
            foreach (var item in this.curInboundDetailList)
            {
                int rows = 0;
                if (excels.Count > 0)
                {
                    rows = excels.FindAll(t => t.CostumeID == item.CostumeID.Trim() && t.CostumeColorName == item.ColorName.Trim()).Count;
                }
                if (rows > 0)
                {
                    flagIsRepeat = true;
                }
                excels.Add(GetCostumeStoreExcel(item));
            }
            
            return excels;
        }

        private CostumeStoreExcel GetCostumeStoreExcel(CostumeStore item)
        {
            CostumeStoreExcel excel = new CostumeStoreExcel();
            ReflectionHelper.CopyProperty(item, excel); 
            return excel;
        } 

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.ColumnIndex< xSDataGridViewTextBoxColumn.Index || e.ColumnIndex>fDataGridViewTextBoxColumn.Index)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            try
            {
                int newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Convert.ToInt32(e.FormattedValue);
                }
                if (newCount < 0)
                {
                    GlobalMessageBox.Show("不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
            dataGridView.Refresh();
        } 

        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            shopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue);
         //   this.BaseButton_Search_Click(null, null);
        }
                 
        private bool CheckDuplicate(CostumeStore detail)
        { 
            //判断是否存在相同款号颜色，如果有则提示是否累加，确定就累加原来的，否的话则取消
            if (curInboundDetailList.Exists(t => t.ShopID == detail.ShopID && t.CostumeID == detail.CostumeID && t.ColorName == detail.ColorName))
            {

                int index = curInboundDetailList.FindIndex(t => t.ShopID == detail.ShopID && t.CostumeID == detail.CostumeID && t.ColorName == detail.ColorName);
                CostumeStore existDetail = null;
                if (index >= 0)
                {
                    existDetail = curInboundDetailList[index];
                    dataGridViewPagingSumCtrl.ScrollToRowIndex(index);
                    GlobalMessageBox.Show("该款号颜色已存在，第" + (index + 1) + "行,请直接修改");
                    return true;
                } 
            }
            else
            {
                curInboundDetailList.Add(detail);
            }
            return false;
        }

        EarlyStageCostumeStoreRecordForm importForm = null;
        String importPath = string.Empty;
        String importShopID = string.Empty;
        
        //private void baseButtonFilter_Click(object sender, EventArgs e)
        //{
        //    FilterCostumeForm form = new FilterCostumeForm();
        //    form.ConfirmClick += FilterCostumeForm_ConfirmClick;
        //    form.ShowDialog();
        //}

         Boolean isFilter = false;


        private String path;
        private void baseButton1_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "期初库存录入" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoExport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
        }

        private void DoExport()
        {
            try
            {
                if (dataGridView1.DataSource != null && dataGridView1.Rows.Count > 0)
                {
                    List<CostumeStore> list = DataGridViewUtil.BindingListToList<CostumeStore>(dataGridView1.DataSource);
                    System.Collections.SortedList columns = new System.Collections.SortedList();
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {
                            if (item.Name != "Column1" && item.Name != "Column2")
                            {
                                keys.Add(item.DataPropertyName);
                                values.Add(item.HeaderText);
                            }
                        }
                    }
                /*    List<CostumeStore> ExportList = new List<CostumeStore>();
                    foreach (CostumeStore cItem in list)
                    {
                        CostumeStore curBrand = new CostumeStore();
                        curBrand.CostumeID = cItem.CostumeID;
                        curBrand.CostumeName = cItem.CostumeName;
                        curBrand.ColorName = cItem.ColorName;
                        curBrand.Price = cItem.Price;
                        curBrand.CostPrice = cItem.CostPrice;
                        curBrand.SalePrice = cItem.SalePrice;
                        curBrand.EmOnlinePrice = cItem.EmOnlinePrice;
                        curBrand.PfOnlinePrice = cItem.PfOnlinePrice;
                        curBrand.BrandName = cItem.BrandName;
                        curBrand.SupplierName = cItem.SupplierName;
                        curBrand.Year = cItem.Year;
                        curBrand.Season = cItem.Season;
                        curBrand.BigClass = cItem.BigClass;
                        curBrand.SmallClass = cItem.SmallClass;
                        curBrand.SubSmallClass = cItem.SubSmallClass;
                        curBrand.SizeGroupShowName = cItem.SizeGroupShowName;
                        curBrand.F = cItem.F;
                        curBrand.S = cItem.S;
                        curBrand.XS = cItem.XS;
                        curBrand.XL = cItem.XL;
                        curBrand.XL2 = cItem.XL2;
                        curBrand.XL3 = cItem.XL3;
                        curBrand.XL4 = cItem.XL4;
                        curBrand.XL5 = cItem.XL5;
                        curBrand.XL6 = cItem.XL6;
                        curBrand.M = cItem.M;
                        curBrand.L = cItem.L;
                        ExportList.Add(curBrand);
                    }*/



                    NPOIHelper.Keys = keys.ToArray();
                    NPOIHelper.Values = values.ToArray();
                    NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);

                    GlobalMessageBox.Show("导出完毕！");
                }
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }
        //private void FilterCostumeForm_ConfirmClick(Costume obj)
        //{
        //    if (obj != null)
        //    {
        //        isFilter = true;
        //        curInboundDetailList = curInboundDetailList.FindAll(
        //            t => (String.IsNullOrEmpty(obj.ID) || t.CostumeID == obj.ID)
        //              && (String.IsNullOrEmpty(obj.Name) || t.CostumeName == obj.Name)
        //        && (obj.BrandID == -1 || t.BrandID == obj.BrandID)
        //          && (String.IsNullOrEmpty(obj.BrandName) || t.BrandName == obj.BrandName)
        //         && (String.IsNullOrEmpty(obj.SupplierName) || t.SupplierName == obj.SupplierName)
        //        && (String.IsNullOrEmpty(obj.SupplierID) || t.SupplierID == obj.SupplierID)
        //         && (String.IsNullOrEmpty(obj.SupplierName) || t.SupplierName == obj.SupplierName)
        //        && (String.IsNullOrEmpty(obj.Colors) ||  t.ColorName == obj.Colors) 
        //          && (obj.Year == -1 || t.Year == obj.Year)
        //       );

        //        try
        //        {
        //            if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
        //            CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.Filter);
        //            cb.BeginInvoke(null, null);
        //            ShowProgressForm();
        //        }
        //        catch (Exception ex)
        //        {
        //            CommonGlobalUtil.ShowError(ex);
        //        }
        //    }
        //}

        //private void Filter() {
        //    try
        //    {
        //        InitProgress(curInboundDetailList.Count);
        //        foreach (var item in curInboundDetailList)
        //        {
        //            UpdateProgress();
        //        }
        //        BindingSource(curInboundDetailList);
        //    }
        //    catch (Exception ex)
        //    {
        //        FailedProgress(ex);
        //        ShowError(ex);
        //    }
        //    finally
        //    {
        //        UnLockPage();
        //    }
        //}


    }
}

