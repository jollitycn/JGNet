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
using System.IO;

namespace JGNet.Manage
{
    public partial class EarlyStageCostumeStoreRecordImportCtrl : BaseModifyUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private SupplierAccountRecordPagePara pagePara;
        public Action< BaseUserControl> End;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public EarlyStageCostumeStoreRecordImportCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new String[] {
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
            dataGridViewPagingSumCtrl.Initialize();
            MenuPermission = RolePermissionMenuEnum.期初库存录入;
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
                dataGridViewPagingSumCtrl.BindingDataSource<CostumeStore>(DataGridViewUtil.ListToBindingList(listPage?.CostumeStores),true, listPage?.CostumeStoreSum);
                CompleteProgressForm();
            }
        }

        public override void RefreshPage()
        {
            this.BaseButton_Search_Click(null, null);
        }

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoSwitchShop);
                cb.BeginInvoke(null, null);
                ShowProgressForm();
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void DoSwitchShop()
        {
            //try
            //{
            //    CostumeStoreInfoSum listPage = GlobalCache.ServerProxy.GetCostumeStores(shopID);
            //    InitProgress(listPage.CostumeStores.Count);
            //    this.curInboundDetailList = listPage.CostumeStores;
            //    foreach (var item in curInboundDetailList)
            //    {
            //        UpdateProgress();
            //    }
            //    BindingSource(listPage);
            //}
            //catch (Exception ex)
            //{
            //    FailedProgress(ex);
            //    ShowError(ex);
            //}
            //finally
            //{
            //    UnLockPage();
            //}
        }

        private void SupplierAccountSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private String shopID;
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

        private void skinTextBoxID_CostumeSelected(Costume costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                ResetAll();
                this.SetCostumeDetails(costumeItem);
            }
        }

        private void SetCostumeDetails(Costume costumeItem)
        {
            if (costumeItem != null)
            {
                Display(costumeItem);
            }
        }

        public void Display(Costume costumeItem)
        {
            try
            {
                if (costumeItem != null)
                { 
                    SizeGroup sizeGroup = CommonGlobalCache.GetSizeGroup(costumeItem.SizeGroupName);
                } 
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isCostumeStoreList = dataGridView.DataSource is List<CostumeStore>;
            try
            {
                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Decimal.Parse(e.FormattedValue.ToString());
                   // newCount = Convert.ToInt32(e.FormattedValue);
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
                CreateCostumeStore store = new CreateCostumeStore()
                { 
                    ShopID = shopID,
                      Date = new Date(dateTimePicker_Start.Value),
                    CostumeStoreExcels = GetCostumeStoreExcels(),
                       IsImport = true
                };
               
                InteractResult result =  GlobalCache.ServerProxy.InsertCostumeStores(store);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("保存成功！");
                        curInboundDetailList.Clear();
                        this.dataGridView1.DataSource = null;
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

        private List<CostumeStoreExcel> GetCostumeStoreExcels()
        {
            List<CostumeStoreExcel> excels = new List<CostumeStoreExcel>();
            foreach (var item in this.curInboundDetailList)
            {
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
            //this.BaseButton_Search_Click(null, null);
        }

        private void baseButton2_Click_1(object sender, EventArgs e)
        {
            //找到EXCEL模板文件
            String sourceFile = System.Environment.CurrentDirectory + "\\Templates\\期初库存导入模板.xls";
            String path = "";
            path = FileUtil.BrowseFolder("请选择保存模板的位置");
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            String toPath = path + "\\期初库存导入模板.xls";
            System.IO.File.Copy(sourceFile, toPath, true);
            GlobalMessageBox.Show("模板保存" + toPath + "！");
        }

        private void DoImport()
        {
            try
            {
                List<CostumeStore> unableStore = new List<CostumeStore>();
                List<CostumeStore> stores = new List<CostumeStore>();
                List<CostumeStore> repeatStores = new List<CostumeStore>();
                DataTable dt = NPOIHelper.FormatToDatatable(importPath, 0);
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    int index = 0;
                    CostumeStore store = new CostumeStore();
                    try
                    {
                        if (!ImportValidate(row))
                        {
                            //款号	商品名称	色号	颜色名称	吊牌价	成本价	品牌	供应商名称	年份	季节	大类	小类	款型	风格	XS	S	M	L	XL	2XL	3XL	4XL	5XL	6XL	F
                            store.AutoID = i + 2;
                            ((CheckBaseDataPara)store).CostumeID = CommonGlobalUtil.ConvertToString(row[index]);
                            store.CostumeID = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.CostumeName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.CostumeColorID = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.CostumeColorName = CommonGlobalUtil.ConvertToString(row[index]);
                            store.ColorName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Price = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.CostPrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.SalePrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.EmOnlinePrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.PfOnlinePrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.BrandName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SupplierName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Year = CommonGlobalUtil.ConvertToInt32(row[index++]);
                            store.Season = CommonGlobalUtil.ConvertToString(row[index++]);
                            // store.ClassCode = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.BigClass = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SmallClass = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SubSmallClass = CommonGlobalUtil.ConvertToString(row[index++]);
                            // store.Style = CommonGlobalUtil.ConvertToString(row[index++]);
                            //  store.Models = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SizeGroupShowName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.XS = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.S = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.M = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.L = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL2 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL3 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL4 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL5 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.XL6 = CommonGlobalUtil.ConvertToInt16(row[index++]);
                            store.F = CommonGlobalUtil.ConvertToInt16(row[index++]);

                            store.ShopID = shopID;
                            if ((String.IsNullOrEmpty(store.CostumeID) || String.IsNullOrEmpty(store.CostumeName) ||
                                String.IsNullOrEmpty(store.CostumeColorName) || String.IsNullOrEmpty(store.SizeGroupShowName)))
                            {
                                unableStore.Add(store);
                            }
                            else
                            {
                                if (stores.Find(t => t.CostumeID == store.CostumeID && t.CostumeName == store.CostumeName && t.CostumeColorName == store.CostumeColorName) != null)
                                {
                                    repeatStores.Add(store);
                                }
                                else
                                {

                                    //store.CostumeID = CommonGlobalCache.GetCorrectCostumeID(store.CostumeID);
                                    if (!String.IsNullOrEmpty(store.ClassCode))
                                    {
                                        store.ClassName = CommonGlobalCache.ServerProxy.GetCostumeClass4Code(store.ClassCode)?.ClassName;
                                    }
                                    stores.Add(store);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }

                if (unableStore.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in unableStore)
                    {
                        str += "第" + item.AutoID + "行\r\n";
                    }

                    ShowError("必填项没有填写，请补充完整！\r\n" + str);
                    ImportFormCancel();
                    return;
                }
                if (repeatStores.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in repeatStores)
                    {
                        str += "第" + item.AutoID + "行\r\n";
                    }

                    //这个与已导入的列表数据无关
                    ShowError("重复的款号与颜色，系统已过滤，详见错误报告！\r\n" + str);
                    ImportFormCancel();
                    return;
                }
                if (stores != null && stores.Count > 0)
                {
                }
                else
                {
                    ShowMessage("没有数据可以导入，请检查列表信息！");
                    ImportFormCancel();
                    return;
                }

                importPath = null;
                AddItems4Display(stores);
                //    ShowMessage("导入成功！");
                ImportFormDialogResult(DialogResult.OK);

            }
            catch (Exception ex)
            {
                ImportFormCancel();
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }
         

        private void ImportFormDialogResult(DialogResult result)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<DialogResult>(this.ImportFormDialogResult), result);
            }
            else
            {
                importForm.DialogResult = result;
            }
        }

        private void ImportFormCancel()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.ImportFormCancel));
            }
            else
            {
                importForm.Cancel();
            }
        }

        private void AddItems4Display(List<CostumeStore> stores)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<List<CostumeStore>>(this.AddItems4Display), stores);
            }
            else
            {
                if (CheckDuplicates(stores)) {
                    this.BindingInboundDetailSource();
                        }
            }
        }

        private Boolean CheckDuplicates(List<CostumeStore> stores)
        {
            bool add = true;
            List<CostumeStore> details = new List<CostumeStore>();
            foreach (var detail in stores)
            {  //判断是否存在相同款号颜色，如果有则提示是否累加，确定就累加原来的，否的话则取消
                if (curInboundDetailList.Exists(t => t.ShopID == detail.ShopID && t.CostumeID == detail.CostumeID && t.ColorName == detail.ColorName))
                {
                    details.Add(detail); 
                }
            }

            if (details != null && details.Count > 0)
            {
                String value = string.Empty;
                foreach (var item in details)
                {
                    value = item.CostumeID + " " + item.ColorName + "\r\n";
                }

                if (GlobalMessageBox.Show(value + "已存在，是否覆盖？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var detail in stores)
                    {
                        if (details.Contains(detail))
                        {
                            CostumeStore existDetail = curInboundDetailList.Find(t => t.ShopID == detail.ShopID && t.CostumeID == detail.CostumeID && t.ColorName == detail.ColorName);
                            //  dataGridViewPagingSumCtrl(curInboundDetailList.IndexOf(existDetail));
                            ReflectionHelper.CopyProperty(detail, existDetail);
                        }
                        else
                        {
                            curInboundDetailList.Add(detail);
                        }
                    }
                }
                else { add = false; }
            }
            else
            {
                curInboundDetailList.AddRange(stores);
            }
            //
            return add;
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
        private void baseButtonImport_Click(object sender, EventArgs e)
        {
            importForm = new EarlyStageCostumeStoreRecordForm(shopID);
            importForm.CloseWhenEscape = false;
            importForm.ConfirmClick += form_ConfirmClick;
            if (importForm.ShowDialog() != DialogResult.OK)
            {
                importShopID = string.Empty;
                importPath = string.Empty;
                return;
            }
        }

        private void form_ConfirmClick(string shopID, string path, EarlyStageCostumeStoreRecordForm form)
        {
            importShopID = shopID;
            importPath = path;

            string fileExt = Path.GetExtension(path);
            if (fileExt != ".xlsx" && fileExt != ".xls")
            {
                ShowMessage("你所选择文件格式不正确，请重新上传文件！");
                return;
            }
            if (GlobalMessageBox.Show("是否开始导入" + System.IO.Path.GetFileName(path), "友情提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                importPath = null;
                importForm.Cancel();
                return;
            }

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoImport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }
         

        private bool ImportValidate(DataRow row)
        {    //
            bool unValidate = true;
            for (int i = 0; i < 22; i++)
            {
                String value = CommonGlobalUtil.ConvertToString(row[i]);
                if (!String.IsNullOrEmpty(value))
                {
                    //有值
                    unValidate = false;
                    break;
                }
            }
            return unValidate;
        }

        private void downTemplateButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

