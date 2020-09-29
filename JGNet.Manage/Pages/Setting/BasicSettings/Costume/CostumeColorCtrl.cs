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
using static System.Windows.Forms.DataGridView;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Common;
using JieXi.Common;
using CJBasic;
using System.IO;

namespace JGNet.Manage.Pages.BasicSettings.Costume
{
    public partial class CostumeColorCtrl : BaseUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        private List<CostumeColor> list;
        public CostumeColorCtrl()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.颜色;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
        }

        private void Initialize()
        {
            this.skinTextBoxName.SkinTxt.Text = string.Empty;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = null;
            list = GlobalCache.CostumeColorList;
            this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {

                    List<CostumeColor> list = DataGridViewUtil.BindingListToList<CostumeColor>(dataGridView1.DataSource);  
                    CostumeColor item = (CostumeColor)list[e.RowIndex];
                    switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {
                        case "编辑":
                            if (item.ID == "000")
                            {
                                GlobalMessageBox.Show("均色不能修改！");
                                return;
                            }
                            Edit(item);
                            break;
                        case "删除":
                            if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            {
                                return;
                            }
                            if (item.ID == "000")
                            {
                                GlobalMessageBox.Show("均色不能删除！");
                                return;
                            }
                            if (GlobalUtil.EngineUnconnectioned(this))
                            {
                                return;
                            }
                            this.dataGridView1.DataSource = null;
                            InteractResult result = GlobalCache.CostumeColor_OnRemove(item.ID);
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

        private void Edit(CostumeColor item)
        {
            List<CostumeColor> list = DataGridViewUtil.BindingListToList<CostumeColor>(dataGridView1.DataSource); 
            AddCostumeColorForm AddBrand = new AddCostumeColorForm(item, OperationEnum.Edit);
            AddBrand.Text = "修改颜色";
            try
            {
                if (AddBrand.ShowDialog(this) == DialogResult.OK)
                {
                    item = AddBrand.Result;
                    InteractResult result = GlobalCache.ServerProxy.UpdateCostumeColor(item);
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalCache.UpdateCostumeColor(item);
                            GlobalCache.LoadCostumeInfos();
                            baseButton1_Click(null, null);
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

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            List<CostumeColor> list = DataGridViewUtil.BindingListToList<CostumeColor>(dataGridView1.DataSource); 
            AddCostumeColorForm AddBrand = new AddCostumeColorForm();
            try
            {
                if (AddBrand.ShowDialog(this) == DialogResult.OK)
                {
                    if (list == null) { list = new List<CostumeColor>(); }
                    CostumeColor item = AddBrand.Result;
                    list.Add(item);
                    InteractResult result = GlobalCache.ServerProxy.InsertCostumeColor(item);
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            RefreshPage();
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

        private void CostumeColorCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            string idName = this.skinTextBoxName.SkinTxt.Text;
            List<CostumeColor> list = GlobalCache.ServerProxy.GetCostumeColor4IDOrName(idName);
            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(list));
            dataGridView1.Refresh();
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
                List<CostumeColor> emptyStore = new List<CostumeColor>();
                List<CostumeColor> stores = new List<CostumeColor>();
                List<CostumeColor> repeatItems = new List<CostumeColor>();
                DataTable dt = NPOIHelper.FormatToDatatable(path, 0);
                for (int i = 1; i < dt.Rows.Count; i++)
                {

                    DataRow row = dt.Rows[i];
                    int index = 0;
                    CostumeColor store = new CostumeColor();
                    try
                    {
                        if (!CommonGlobalUtil.ImportValidate(row, 2))
                        {
                            store.AutoCode = (i + 2);
                            store.Name = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.ID = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.FirstCharSpell = DisplayUtil.GetPYString(store.Name);
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
                        str += "第" + item.AutoCode + "行\r\n";
                    }
                    ShowError("必填项没有填写，请补充完整！\r\n" + str);
                    return;
                }
                if (repeatItems.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in repeatItems)
                    {
                        str += "第" + item.AutoCode + "行" + "\r\n";
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
                InteractResult result = GlobalCache.ServerProxy.ImportCostumeColors(stores);
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


        private new void RefreshPage()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new CJBasic.CbGeneric(this.RefreshPage));
            }
            else
            {
                baseButton1_Click(null, null);
            }
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "颜色" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                List<CostumeColor> list = DataGridViewUtil.BindingListToList<CostumeColor>(dataGridView1.DataSource);
                System.Collections.SortedList columns = new System.Collections.SortedList();
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    if (item.Visible)
                    {
                        if (item.Name == "Column1" || item.Name == "Column3" || item.Name == "Column4")
                        {
                            keys.Add(item.DataPropertyName);
                            values.Add(item.HeaderText);
                        }
                    }
                }
                List<CostumeColor> ExportList = new List<CostumeColor>();
                foreach (CostumeColor cItem in list)
                {
                    CostumeColor curBrand = new CostumeColor();
                    curBrand.Name = cItem.Name;
                    curBrand.ID = cItem.ID;
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
    }
}
