using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core; 
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core.Util;
using JGNet.Core.Const;
using JieXi.Common;
using CJBasic;
using System.IO;

namespace JGNet.Manage.Pages
{
    public partial class CostumeClassCtrl2019 : BaseModifyUserControl
    {

        public CostumeClassCtrl2019()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.类别;
        }

        List<TreeNode> allNodes = null;
        private void PermissonCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            skinTreeViewClass.Nodes.Clear();
            skinTreeViewClass.Nodes.AddRange(CostumeClassUtil.GetTreeNodes().ToArray());
            allNodes = WinformUIUtil.GetAllTreeNodes(skinTreeViewClass.Nodes);
            skinTreeViewClass.Nodes[0].ExpandAll();
        }

        private void skinTreeViewClass_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            skinTreeViewClass.SelectedNode = e.Node;

            //if (e.Button == MouseButtons.Right)
            //{
            //    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            //    //e.Node.;
            //}
            
            修改ToolStripMenuItem.Visible = e.Node.Level != 0;
            刪除ToolStripMenuItem.Visible = e.Node.Level != 0;
            新增ToolStripMenuItem.Visible = e.Node.Level < 3;
            if (e.Node.Level != 0 && e.Node.Level >= 3) {
                新增ToolStripMenuItem.Visible = false;
             //   skinTreeViewClass.ContextMenuStrip = null;
            }
            else {
                //skinTreeViewClass.ContextMenuStrip = contextMenuStrip1;
                新增ToolStripMenuItem.Visible = true;
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = skinTreeViewClass.SelectedNode;
            AddCostumeClassForm form = new AddCostumeClassForm(allNodes, node);
            
            form.ShowDialog();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = skinTreeViewClass.SelectedNode;
            AddCostumeClassForm form = new AddCostumeClassForm(allNodes, node, OperationEnum.Edit);
            form.ShowDialog();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TreeNode node = skinTreeViewClass.SelectedNode;
                if (node.Level == 1)
                {
                    CostumeClassInfo info = node.Tag as CostumeClassInfo;
                    InteractResult result = GlobalCache.ServerProxy.DeleteBigCostumeClass(info.ID);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            allNodes.Remove(node);
                            node.Remove();
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
                else if (node.Level == 2)
                {
                    SmallClass info = node.Tag as SmallClass; 
                    InteractResult result = GlobalCache.ServerProxy.DeleteSmallClass(info.ID);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            allNodes.Remove(node);
                            node.Remove();
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
                else if (node.Level == 3)
                {
                    SubSmallClass info = node.Tag as SubSmallClass;
                    InteractResult result = GlobalCache.ServerProxy.DeleteSubSmallClass(info.ID);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            allNodes.Remove(node);
                            node.Remove();
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
            }
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
                List<CostumeClass2> emptyStore = new List<CostumeClass2>();
                List<CostumeClass2> stores = new List<CostumeClass2>();
                List<CostumeClass2> repeatItems = new List<CostumeClass2>();
                DataTable dt = NPOIHelper.FormatToDatatable(path, 0);
                for (int i = 1; i < dt.Rows.Count; i++)
                {

                    DataRow row = dt.Rows[i];
                    int index = 0;
                    CostumeClass2 store = new CostumeClass2();
                    try
                    {
                        if (!CommonGlobalUtil.ImportValidate(row, 5))
                        {
                            store.Index = (i + 2);
                            store.AutoID = CommonGlobalUtil.ConvertToInt32(row[index++]);
                            store.ClassName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.ParentAutoID = CommonGlobalUtil.ConvertToInt32(row[index++]);
                            store.OrderNo = CommonGlobalUtil.ConvertToInt32(row[index++]);
                            store.ClassCode = CommonGlobalUtil.ConvertToString(row[index++]);
                            //  store.FirstCharSpell = DisplayUtil.GetPYString(store.Name);
                            if (store.AutoID == 0 || String.IsNullOrEmpty(store.ClassName))
                            {
                                //必填项为空
                                emptyStore.Add(store);
                                continue;
                            }
                            else
                            {
                                //判断是否重复款号/颜色
                                if (stores.Find(t => t.AutoID == store.AutoID) != null)
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
                        str += "第" + item.Index + "行\r\n";
                    }
                    ShowError("必填项没有填写，请补充完整！\r\n" + str);
                    return;
                }
                if (repeatItems.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in repeatItems)
                    {
                        str += "第" + item.Index + "行" + "\r\n";
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
                InteractResult result = GlobalCache.ServerProxy.ImportCostumeClass(stores);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        ShowMessage(result.Msg);
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
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.RefreshPage));
            }
            else
            {
                Initialize();
            }
        }

  

        private void baseButton1_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "类别" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                List<CostumeClassInfo> infos = GlobalCache.GetCostumeClassList();
                DataTable dt = new DataTable();
                dt.Columns.Add("FirstName");
                dt.Columns.Add("SecondName");
                dt.Columns.Add("ThirdName");
                DataTable secondDT = new DataTable();
                secondDT.Columns.Add("FirstName");
                secondDT.Columns.Add("SecondName");
                secondDT.Columns.Add("ThirdName");
                DataTable thiridDT = new DataTable();
                thiridDT.Columns.Add("FirstName");
                thiridDT.Columns.Add("SecondName");
                thiridDT.Columns.Add("ThirdName");

                foreach (CostumeClassInfo firtClassInfo in infos)
                {
                    DataRow dr = dt.NewRow();
                    dr["FirstName"] = firtClassInfo.Name;
                    if (firtClassInfo.SmallClass.Count > 0)
                    {
                        foreach (SmallClass SecondClassInfo in firtClassInfo.SmallClass)
                        {

                            //  dr["SecondName"] = SecondClassInfo.SmallClassStr;
                            DataRow drchildren = secondDT.NewRow();
                            drchildren["FirstName"] = firtClassInfo.Name;
                            drchildren["SecondName"] = SecondClassInfo.SmallClassStr;
                            secondDT.Rows.Add(drchildren);
                            if (SecondClassInfo.SubSmallClass.Count > 0)
                            {
                                foreach (SubSmallClass thirdClassInfo in SecondClassInfo.SubSmallClass)
                                {
                                    DataRow drSecondchildren = secondDT.NewRow();
                                    drSecondchildren["FirstName"] = firtClassInfo.Name;
                                    drSecondchildren["SecondName"] = SecondClassInfo.SmallClassStr;
                                    drSecondchildren["ThirdName"] = thirdClassInfo.SubSmallClassStr;
                                    secondDT.Rows.Add(drSecondchildren);
                                }

                            }
                        }
                    }

                    dt.Rows.Add(dr);
                    foreach (DataRow curDr in secondDT.Rows)
                    {
                        DataRow curTwoDR = dt.NewRow();
                        curTwoDR["FirstName"] = curDr["FirstName"];
                        curTwoDR["SecondName"] = curDr["SecondName"];
                        curTwoDR["ThirdName"] = curDr["ThirdName"];
                        dt.Rows.Add(curTwoDR);


                    }
                    secondDT.Rows.Clear();
                     
                }


                keys.Add("FirstName");
                keys.Add("SecondName");
                keys.Add("ThirdName");


                values.Add("一级类别");
                values.Add("二级类别");
                values.Add("三级类别");




                NPOIHelper.Keys = keys.ToArray();
                NPOIHelper.Values = values.ToArray();

                NPOIHelper.ExportExcel(dt, path);

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
