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
using JGNet.Common.cache.Wholesale;
using JGNet.Core.Tools;
using JGNet.Core.MyEnum;

namespace JGNet.Manage.Pages
{
    public partial class PfDistributorCtrl : BaseModifyUserControl
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public PfDistributorCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.分销人员管理;

            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView3, new string[] { withdrawCommissionDataGridViewTextBoxColumn1.DataPropertyName, accruedCommissionDataGridViewTextBoxColumn1.DataPropertyName, withdrawCommissionDataGridViewTextBoxColumn1.DataPropertyName });
            dataGridView3.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.Initialize();
        }

        List<TreeNode> allNodes = null;
        private void PermissonCtrl_Load(object sender, EventArgs e)
        {
            TreeNode tree = null;
            Initialize(out tree);
        }

        private void Initialize(out TreeNode node, string SelectStr = "")
        {
            skinTreeViewClass.Nodes.Clear();
            skinTreeViewClass.Nodes.AddRange(DistributorClassUtil.GetPfTreeNodes(out node, SelectStr).ToArray());
            allNodes = WinformUIUtil.GetAllTreeNodes(skinTreeViewClass.Nodes);
            skinTreeViewClass.Nodes[0].ExpandAll();

            SetUnconsumedDays();
            SetCommissionBox();
            SetTypeBox();
        }
        private void SetUnconsumedDays()
        {

            List<ListItem<int>> list = new List<ListItem<int>>();
            list.Add(new ListItem<int>("所有", -1));
            list.Add(new ListItem<int>("从未消费", -2));
            list.Add(new ListItem<int>("0天以上", 0));
            list.Add(new ListItem<int>("30天以上", 30));
            list.Add(new ListItem<int>("60天以上", 60));
            list.Add(new ListItem<int>("90天以上", 90));
            list.Add(new ListItem<int>("180天以上", 180));
            this.unconsumedComboBox.DisplayMember = "Key";
            this.unconsumedComboBox.ValueMember = "Value";
            this.unconsumedComboBox.DataSource = list;
        }
        private void SetCommissionBox()
        {

            List<ListItem<SeeCommission>> stateList = new List<ListItem<SeeCommission>>();
            stateList.Add(new ListItem<SeeCommission>(EnumHelper.GetDescription(SeeCommission.All), SeeCommission.All));
            stateList.Add(new ListItem<SeeCommission>(EnumHelper.GetDescription(SeeCommission.True), SeeCommission.True));
            stateList.Add(new ListItem<SeeCommission>(EnumHelper.GetDescription(SeeCommission.False), SeeCommission.False));
            this.skinComboBoxCommission.DisplayMember = "Key";
            this.skinComboBoxCommission.ValueMember = "Value";
            this.skinComboBoxCommission.DataSource = stateList;


            //skinComboBoxCommission
        }
        private void SetTypeBox()
        {
             
            List<ListItem<CustomerType>> stateList = new List<ListItem<CustomerType>>();
            stateList.Add(new ListItem<CustomerType>(EnumHelper.GetDescription(CustomerType.All), CustomerType.All));
            stateList.Add(new ListItem<CustomerType>(EnumHelper.GetDescription(CustomerType.AgentSell), CustomerType.AgentSell));
            stateList.Add(new ListItem<CustomerType>(EnumHelper.GetDescription(CustomerType.Buyout), CustomerType.Buyout));
            this.skinComboBoxType.DisplayMember = "Key";
            this.skinComboBoxType.ValueMember = "Value";
            this.skinComboBoxType.DataSource = stateList;


            //skinComboBoxCommission
        }
        private void skinTreeViewClass_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            skinTreeViewClass.SelectedNode = e.Node;

            // if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            
 
             修改ToolStripMenuItem.Visible = e.Node.Level != 0;
           /* 刪除ToolStripMenuItem.Visible = e.Node.Level != 0;
            TreeModel info = e.Node.Tag as TreeModel;
            if (info.Childrens.Count>0)
            {*/
                刪除ToolStripMenuItem.Visible = false;
           /* }
            else
            {
                刪除ToolStripMenuItem.Visible = true;
            }*/

            新增ToolStripMenuItem.Visible = e.Node.Level <11;
            if (e.Node.Text == "所有分销客户")
            {
                TreeModel CurClass = new TreeModel();
                CurClass.ID = "0";
                CurClass.Name = "所有分销客户";
                e.Node.Tag = CurClass;
                刷新ToolStripMenuItem.Visible = true;
            }
            else
            {
                刷新ToolStripMenuItem.Visible = false;
            }
            if (!HasPermission(RolePermissionEnum.新增下线)) {
                新增ToolStripMenuItem.Enabled = false;
            }
            if ((e.Node.Level != 0 && e.Node.Level >= 11)) {
                新增ToolStripMenuItem.Visible = false;
            }
            else {
                新增ToolStripMenuItem.Visible = true;
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = skinTreeViewClass.SelectedNode;
            TreeModel CurClass = node.Tag as TreeModel;
           
            if (CurClass.ID != null && CurClass.ID!="")
            {
                SaveOffLineCustomerForm form = new SaveOffLineCustomerForm(CurClass.ID, null,node);
                form.ShowDialog();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = skinTreeViewClass.SelectedNode;
            TreeModel CurClass = node.Tag as TreeModel;
            PfCustomer pfCustomer = PfCustomerCache.GetPfCustomer(CurClass.ID);
            SaveOffLineCustomerForm form = new SaveOffLineCustomerForm(CurClass.ID, pfCustomer,node);
            form.ShowDialog();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }


        private void baseButtonImport_Click(object sender, EventArgs e)
        {

          /*  path = CJBasic.Helpers.FileHelper.GetFileToOpen("请选择导入文件");
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            if (GlobalMessageBox.Show("是否开始导入" + System.IO.Path.GetFileName(path), "友情提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                path = null;
                return;
            }

            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoImport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }*/

        }



        private String path;
        private void DoImport()
        {
          /*  try
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
            }*/
        }

        private new void RefreshPage()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.RefreshPage));
            }
            else
            {
                TreeNode node = null;
                Initialize(out node);
            }
        }

  

        private void baseButton1_Click(object sender, EventArgs e)
        {
           /* path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "类别" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }*/
        }
         private void DoExport()
{
          /*  try
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
            }*/
}

        private void check(TreeNode tNode, string name, out bool ischeck, out TreeNode selectNode)
        {
            ischeck = false;
            bool isflag = false;
            selectNode = null;
            foreach (TreeNode titem in tNode.Nodes)
            {
                string[] list = titem.Text.Split('/');


                if (list.Length > 0)
                {
                    for (int i = 0; i < list.Length; i++)
                    {

                        if ( list[i] == name && i == 0)
                        {
                            this.skinTreeViewClass.SelectedNode = titem;
                            // this.skinTreeViewClass.Focus();
                            selectNode = titem;
                            ischeck = true;
                            isflag = true;
                            break;
                        }
                        else
                        {
                            if (!ischeck)
                            {
                                check(titem, name, out ischeck, out selectNode);
                            }
                        }
                        //else
                        //{
                        //    if (list[i].Split('(').Length > 0)
                        //    {
                        //        if (list[i].Split('(')[0] == name)
                        //        {
                        //            this.skinTreeViewClass.SelectedNode = titem;
                        //            ischeck = true;

                        //            //   this.skinTreeViewClass.Focus();
                        //            isflag = true;
                        //            break;
                        //        }
                        //    }
                        //}
                    }
                    if (isflag) { break; }

                }
                else
                {
                    if (!ischeck)
                    {
                        check(titem, name, out ischeck, out selectNode);
                    }
                }


                /*   if (list.Length > 0)
                   {
                       for (int i = 0; i < list.Length; i++)
                       {

                           if (list[i] == name && i == 0)
                           {
                               this.skinTreeViewClass.SelectedNode = titem;
                               // this.skinTreeViewClass.Focus();
                               ischeck = true;
                               isflag = true;
                               break;
                           }
                           else
                           {
                               if (list[i].Split('(').Length > 0)
                               {
                                   if (list[i].Split('(')[0] == name)
                                   {
                                       this.skinTreeViewClass.SelectedNode = titem;
                                       ischeck = true;

                                       //   this.skinTreeViewClass.Focus();
                                       isflag = true;
                                       break;
                                   }
                               }
                           }
                       }
                       if (isflag) { break; }
                       else
                       {
                           if (!ischeck)
                           {
                               check(titem, name, out ischeck);
                           }
                       }
                   }
                   else
                   {
                       if (!ischeck)
                       {
                           check(titem, name, out ischeck);
                       }
                   }*/

            }
        }
        GetPfDistributorsPara para;
        private void BaseButton3_Click(object sender, EventArgs e)
        {
             

            string idStr = this.skinTextBoxTitle.Text;
            string nameStr = this.textBoxName.Text;
            string telStr = this.textBoxTel.Text; 

             para = new GetPfDistributorsPara()
            { 
                Phone = telStr, 
                ID=idStr, 
                CustomerType=(CustomerType)this.skinComboBoxType.SelectedValue,
                Name = nameStr,
                NoRetailDay = Convert.ToInt32(this.unconsumedComboBox.SelectedValue),
                SeeCommission = (SeeCommission)this.skinComboBoxCommission.SelectedValue,
            };
            InteractResult<List<PfCustomer>> mList = CommonGlobalCache.ServerProxy.GetPfDistributors(para);
            if (mList.ExeResult == ExeResult.Success)
            {
                if (mList != null)
                {
                    List<PfCustomer> ListPfCustomer = mList.Data;
                    //foreach (PfCustomer Pitem in ListPfCustomer)
                    //{
                    //    Pitem.CustomerCode = Pitem.ID;
                    //}
                    dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(ListPfCustomer));
                   // dataGridViewPagingSumCtrl.BindingDataSource(mList.Data);
                }
            }
            /* bool ischeck = false;
             if (nameStr != "")
             {

                 TreeNode ew = null;
                 //Initialize(out ew,nameStr);
                 bool isflag = false;
                 TreeNodeCollection tCol = this.skinTreeViewClass.Nodes;
                 foreach (TreeNode treeNode in tCol)
                 {

                     string[] list = treeNode.Text.Split('/');
                     if (list.Length > 0)
                     {
                         for (int i = 0; i < list.Length; i++)
                         {

                             if (list[i] == nameStr && i == 0)
                             {
                                 this.skinTreeViewClass.SelectedNode = treeNode;
                                 ischeck = true;
                                 // this.skinTreeViewClass.Focus();
                                 isflag = true;
                                 break;
                             }
                             else
                             {
                                 if (list[i].Split('(').Length > 0)
                                 {
                                     if (list[i].Split('(')[0] == nameStr)
                                     {
                                         this.skinTreeViewClass.SelectedNode = treeNode;
                                         ischeck = true;
                                         isflag = true;
                                         break;
                                     }
                                 }
                             }

                         }
                         if (isflag) { break; }
                         else
                         {
                             check(treeNode, nameStr, out ischeck);
                         }
                     }
                     else
                     {
                         check(treeNode, nameStr, out ischeck);
                     }
                 }
                 if (!ischeck)
                 {
                     this.skinTreeViewClass.SelectedNode = tCol[0];
                 }
                 this.skinTreeViewClass.Focus();

                 //  skinTreeViewClass.SelectedNode = ew;
             }*/

        }

        DataGridViewRow currRow = null;
        PfCustomer Cusitem;
        TreeNode curSelectNode = null;
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.CurrentRow;
            ///不重复提交  DataGridViewRow row = view.CurrentRow;

            if (row == null) return;
            if (row != null && row.Index > -1 && row != currRow)
            {
                if (view.CurrentCell.ColumnIndex == 8)
                {
                    DataGridViewCheckBoxColumn curColumn = (DataGridViewCheckBoxColumn)view.Columns[8];
                    curColumn.Selected = !curColumn.Selected;
                }
                else
                {
                    Cusitem = (PfCustomer)row.DataBoundItem;

                    bool ischeck = false;

                    TreeNode selectNode = null;
                    TreeNode ew = null;
                    //Initialize(out ew,nameStr);
                    bool isflag = false;
                    TreeNodeCollection tCol = this.skinTreeViewClass.Nodes;
                    foreach (TreeNode treeNode in tCol)
                    {

                        string[] list = treeNode.Text.Split('/');


                        if (list.Length > 0)
                        {
                            for (int i = 0; i < list.Length; i++)
                            {

                                if (list[i] == Cusitem.Name && i == 0)
                                {
                                    this.skinTreeViewClass.SelectedNode = treeNode;
                                    ischeck = true;
                                    selectNode = treeNode;
                                    curSelectNode = treeNode;
                                    // this.skinTreeViewClass.Focus();
                                    isflag = true;
                                    break;
                                }
                                else
                                {
                                    check(treeNode, Cusitem.Name, out ischeck, out selectNode);
                                    if (selectNode != null)
                                    {
                                        curSelectNode = selectNode;
                                    }
                                }

                            }
                            if (isflag) { break; }
                            //else
                            //{

                            //}
                        }
                        else
                        {
                            check(treeNode, Cusitem.Name, out ischeck, out selectNode);
                            if (selectNode != null)
                            {
                                curSelectNode = selectNode;
                            }
                        }
                    }
                    if (!ischeck)
                    {
                        this.skinTreeViewClass.SelectedNode = tCol[0];
                    }
                    this.skinTreeViewClass.Focus();
                    /*  if (list.Length > 0)
                      {
                          for (int i = 0; i < list.Length; i++)
                          {

                              if (list[i] == Memitem.Name && i == 0)
                              {
                                  this.skinTreeViewClass.SelectedNode = treeNode;
                                  ischeck = true;
                                  // this.skinTreeViewClass.Focus();
                                  isflag = true;
                                  break;
                              }
                              else
                              {
                                  if (list[i].Split('(').Length > 0)
                                  {
                                      if (list[i].Split('(')[0] == Memitem.Name)
                                      {
                                          this.skinTreeViewClass.SelectedNode = treeNode;
                                          ischeck = true;
                                          isflag = true;
                                          break;
                                      }
                                  }
                              }

                          }
                          if (isflag) { break; }
                          else
                          {
                              check(treeNode, Memitem.Name, out ischeck);
                          }
                      }
                      else
                      {
                          check(treeNode, Memitem.Name, out ischeck);
                      }
                  }
                  if (!ischeck)
                  {
                      this.skinTreeViewClass.SelectedNode = tCol[0];
                  }
                  this.skinTreeViewClass.Focus();
                  */

                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                List<PfCustomer> memberList = DataGridViewUtil.BindingListToList<PfCustomer>(dataGridView3.DataSource);
              //  List<PfCustomer> memberList = (List<PfCustomer>)this.dataGridView3.DataSource;
                PfCustomer Mitem = memberList[e.RowIndex];
                if (e.ColumnIndex == dataGridViewLinkColumn2.Index)
                {
                    if (curSelectNode != null)
                    {
                        SaveOffLineCustomerForm form = new SaveOffLineCustomerForm(Mitem.ID, Mitem, curSelectNode);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            InteractResult<List<PfCustomer>> mList = CommonGlobalCache.ServerProxy.GetPfDistributors(para);
                            if (mList.ExeResult == ExeResult.Success)
                            {
                                if (mList != null)
                                {
                                    //this.dataGridViewTextBoxColumn1.Visible = true;
                                    List<PfCustomer> ListPfCustomer = mList.Data;
                                    //foreach (PfCustomer Pitem in ListPfCustomer)
                                    //{
                                    //    Pitem.CustomerCode = Pitem.ID;
                                    //}
                                    dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(ListPfCustomer));
                                    this.dataGridView3.CurrentCell = this.dataGridView3.Rows[e.RowIndex].Cells[1];

                                    this.dataGridView3.Rows[e.RowIndex].Selected = true;
                                }
                            }
                        }



                    }
                }
                else if (e.ColumnIndex == dataGridViewLinkColumn1.Index)
                {
                    GetDistributorsPara paradetail = new GetDistributorsPara() { StartTime = new Date("1900-01-01"), EndTime = new Date(DateTime.Now) };

                    PfCommissionDetailForm form = new PfCommissionDetailForm(paradetail);
                    // form.PfCustomerRechargeRecordSuccess += WholesaleCustomerRechargeForm_PfCustomerRechargeRecordSuccess;
                    form.ShowDialog(Mitem.ID);



                    //  RetailCommissionDetailForm form = new RetailCommissionDetailForm(para);
                    // form.PfCustomerRechargeRecordSuccess += WholesaleCustomerRechargeForm_PfCustomerRechargeRecordSuccess;
                    //  form.ShowDialog(Mitem.ID);


                }
            /*    else if (e.ColumnIndex == seeCommissionDataGridViewCheckBoxColumn.Index)
                {
                    UpIsCheck(Mitem.ID, Mitem.SeeCommission);
                }*/

            }
        }

        #region    //设置是否热卖
        private void UpIsCheck(string itemID, bool isSee)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = CommonGlobalCache.ServerProxy.UpdatePfCustomerSeeCommission(itemID, isSee);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
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
        #endregion

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridView3.Rows[e.RowIndex].IsNewRow)
            {
                DataGridView view = (DataGridView)sender;
                List<PfCustomer> list = DataGridViewUtil.BindingListToList<PfCustomer>(view.DataSource);
              //  List<PfCustomer> list = (List<PfCustomer>)view.DataSource;
                PfCustomer Mitem = (PfCustomer)list[e.RowIndex];
                if (e.ColumnIndex == seeCommissionDataGridViewCheckBoxColumn1.Index)
                {
                    Mitem.SeeCommission = (bool)this.dataGridView3[e.ColumnIndex, e.RowIndex].Value;
                    UpIsCheck(Mitem.ID, Mitem.SeeCommission);
                }

            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode tree = null;
            Initialize(out tree);
        }
    }
}
