using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core;
using JGNet.ForManage;
using CCWin;
using JGNet.Common.Core.Util;
using System.Reflection;
using CJBasic.Loggers;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Core.Util;
using JGNet.Manage.Components;
using JGNet.Common;
using JieXi.Common;
using CJBasic;
using System.IO;

namespace JGNet.Manage.Pages.BasicSettings.Costume
{
    public partial class CostumeBrandCtrl : BaseUserControl
    {
        private List<Brand> list;
        private Brand pagePare;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public CostumeBrandCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.品牌;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.Initialize();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {

                    List<Brand> list = DataGridViewUtil.BindingListToList<Brand>(dataGridView1.DataSource);
                    Brand item = (Brand)list[e.RowIndex];
                    switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {
                        case "编辑":
                            Edit(item);
                            break;

                        case "删除":
                            Delete(list,item);
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

        private void Delete(List<Brand> list, Brand item)
        {
            if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            if (GlobalUtil.EngineUnconnectioned(this))
            {
                return;
            }
            this.dataGridView1.DataSource = null;
            InteractResult result = GlobalCache.Brand_OnRemove(item.AutoID);
            switch (result.ExeResult)
            {
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    this.dataGridView1.DataSource = null;
                    list.Remove(item);
                    this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list);
                    break;
            }
            this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list);
        }

        private void Edit(Brand item)
        {
            CostumeAddBrandForm AddBrand = new CostumeAddBrandForm(item, OperationEnum.Edit);
            try
            {
               
                if (AddBrand.ShowDialog(this) == DialogResult.OK)
                {
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    InteractResult result = GlobalCache.ServerProxy.UpdateBrand(item);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalCache.UpdateBrand(item);
                            baseButton1_Click(null, null);
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                    //UpdateResult result = GlobalCache.ServerProxy.UpdateBrand(item);
                    //switch (result)
                    //{
                    //    case UpdateResult.Success:
                    //        GlobalCache.UpdateBrand(item);
                    //        baseButton1_Click(null, null);
                    //        break;
                    //    case UpdateResult.Error:
                    //        GlobalMessageBox.Show("内部错误！");
                    //        break;
                    //    default:
                    //        break;
                    //}
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
        public override void RefreshPage()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.RefreshPage));
            }
            else
            {
                baseButton1_Click(null, null);
            }
        }
         
        private void CostumeBrandCtrl_Load(object sender, EventArgs e)
        {
            baseButton1_Click(sender,e);
            this.Initialize();
        }

        private void Initialize()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.textBox1.SkinTxt.Text = string.Empty;
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            List<Brand> list = null;
            if (dataGridView1.DataSource != null)
            {
                list = DataGridViewUtil.BindingListToList<Brand>(dataGridView1.DataSource);
            }
            //List<Brand> list = DataGridViewUtil.BindingListToList<Brand>(dataGridView1.DataSource); 
            CostumeAddBrandForm AddBrand = new CostumeAddBrandForm();
            try
            { 
                if (AddBrand.ShowDialog(this) == DialogResult.OK)
                {
                    if (list == null)
                    { list = new List<Brand>(); }
                    Brand item = AddBrand.Result;
                    list.Add(item);
                    InsertResult result = GlobalCache.BrandList_OnInsert(item);
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    switch (result)
                        {
                            case InsertResult.Success:
                                baseButton1_Click(sender,e);
                                break;
                            case InsertResult.Error:
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

        private void baseButton1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text.ToString();
            //if (name != "")
            //{
                List<Brand> list = GlobalCache.ServerProxy.GetBrands4IdOrName(name);
            foreach (Brand bItem in list)
            {
                bItem.IsEnable = !bItem.IsDisable;
            }
            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(list));
            //}
        }

        private void baseButtonImport_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetFileToOpen("请选择导入文件");
            if (String.IsNullOrEmpty(path))
            {
                return;
            }


            string fileExt = Path.GetExtension(path);
            if (fileExt != ".xlsx" && fileExt != ".xls")
            {
                ShowMessage("你所选择文件格式不正确，请重新上传文件！");
                return;
            }
            if (GlobalMessageBox.Show("是否开始导入" + System.IO.Path.GetFileName(path), "友情提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                path = null;
                return;
            }

            /*  if (NPOIHelper.IsFileInUse(path))
              {
                  ShowMessage("你所选择文件已被打开，请关闭后再重新导入！");
                  return;
              }
              */
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoImport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }

        }



        private String path;
        private void DoImport()
        {
            try
            {
                List<Brand> emptyStore = new List<Brand>();
                List<Brand> stores = new List<Brand>();
                List<Brand> repeatItems = new List<Brand>();
                DataTable dt = NPOIHelper.FormatToDatatable(path, 0);
                for (int i = 1; i < dt.Rows.Count; i++)
                {

                    DataRow row = dt.Rows[i];
                    int index = 0;
                    Brand store = new Brand();
                    try
                    {
                        if (!CommonGlobalUtil.ImportValidate(row, 2))
                        {
                            store.AutoID = (i + 2);
                            store.Name = CommonGlobalUtil.ConvertToString(row[index++]); 
                            store.OrderNo = CommonGlobalUtil.ConvertToInt32(row[index++]); 
                            if (String.IsNullOrEmpty(store.Name))
                            {
                                //必填项为空
                                emptyStore.Add(store);
                                continue;
                            }
                            else
                            {
                                //判断是否重复款号/颜色
                                if (stores.Find(t => t.Name == store.Name) != null)
                                {
                                    repeatItems.Add(store);
                                    continue;
                                }

                                stores.Add(store);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                if (emptyStore.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in emptyStore)
                    {
                        str += "第" + item.AutoID + "行\r\n";
                    }
                    ShowError("必填项没有填写，请补充完整！\r\n" + str);
                    return;
                }
                if (repeatItems.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in repeatItems)
                    {
                        str += "第" + item.AutoID + "行" + "\r\n";
                    }
                    ShowError("名称重复，系统已过滤，详见错误报告！\r\n" + str);
                    //  return;
                }
                if (stores != null && stores.Count > 0)
                {
                }
                else
                {
                    ShowMessage("没有数据可以导入，请检查列表信息！");
                    return;
                }
                path = null;
                //檢查結果
                InteractResult result = GlobalCache.ServerProxy.ImportBrand(stores);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        RefreshPage();
                        ShowMessage("导入成功！");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void baseButtonDownTemplate_Click(object sender, EventArgs e)
        {

        }

        private void baseButton3_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "品牌" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                List<Brand> list = DataGridViewUtil.BindingListToList<Brand>(dataGridView1.DataSource);  
                System.Collections.SortedList columns = new System.Collections.SortedList();
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    if (item.Visible)
                    {
                        if (item.Name == "Column1" || item.Name == "Column3")
                        {
                            keys.Add(item.DataPropertyName);
                            values.Add(item.HeaderText);
                        }
                    }
                }
                List<Brand> ExportList = new List<Brand>();
                foreach (Brand cItem in list)
                {
                    Brand curBrand = new Brand();
                    curBrand.Name = cItem.Name;
                    curBrand.FirstCharSpell = cItem.FirstCharSpell;
                    ExportList.Add(curBrand);
                }

                    

                NPOIHelper.Keys = keys.ToArray();
                NPOIHelper.Values = values.ToArray();
                NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(ExportList), path);

                GlobalMessageBox.Show("导出完毕！");
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                DataGridView view = (DataGridView)sender;
                List<Brand> list =null;
                if (dataGridView1.DataSource != null)
                {
                    list = DataGridViewUtil.BindingListToList<Brand>(dataGridView1.DataSource);
                }
               
                Brand Mitem = (Brand)list[e.RowIndex];
              /*  if (e.ColumnIndex == isDisableDataGridViewCheckBoxColumn.Index)
                {
                    Mitem.IsEnable = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                    Mitem.IsDisable = !Mitem.IsEnable;
                    UpIsCheck(Mitem.AutoID, Mitem.IsDisable);
                    //  RefreshPage();
                    // baseButton1_Click(null,null);


                }
                else*/ if (e.ColumnIndex == Column2.Index)
                {
                    Mitem.IsEnable = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                    Mitem.IsDisable = !Mitem.IsEnable;
                    UpIsCheck(Mitem.AutoID, Mitem.IsDisable);
                    //CommonGlobalCache. = GlobalCache.ServerProxy.GetEnableBrands().Data;
                    GlobalCache.UpdateBrand(Mitem);
                }
                

            }
        }
        private void UpIsCheck(int itemID, bool isSee)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = CommonGlobalCache.ServerProxy.UpdateBrandDisable(itemID, isSee);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                     /*   string name = textBox1.Text.ToString();
                        //if (name != "")
                        //{
                        List<Brand> getlist = GlobalCache.ServerProxy.GetBrands4IdOrName(name);
                        foreach (Brand bItem in getlist)
                        {
                            bItem.IsEnable = !bItem.IsDisable;
                        }
                        dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(getlist));*/
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
    }
}
