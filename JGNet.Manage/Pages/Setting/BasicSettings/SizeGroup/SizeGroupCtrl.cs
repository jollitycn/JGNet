using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms; 
using CJBasic.Widget;
using CJBasic;
using CJBasic.Loggers;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Core.InteractEntity;
using CCWin;
using JGNet.Core.Tools;
using JGNet.Manage;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Manage.Components;
using JieXi.Common;

namespace JGNet.Common
{
    public partial class SizeGroupCtrl : BaseModifyUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private Member member;

        public SizeGroupCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.尺码;
            InitializeConstruct();
        }

        private void InitializeConstruct()
        {
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridView1.AutoGenerateColumns = false;
         //  dataGridView1.CellValidated += this.dataGridView1_CellValidated;
        }


        public override void RefreshPage()
        {
            Search();
        }

        //点击搜索按钮
        private void Search()
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                this.BindingMemberDateSource(CommonGlobalCache.SizeGroupList);
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

        /// <summary>
        /// 绑定MemberList源到dataGridView 中
        /// </summary>
        /// <param name="memberListPage"></param>
        private void BindingMemberDateSource(List<SizeGroup> sizeGroups)
        {
            //this.dataGridView1.DataSource = sizeGroup;


            dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(sizeGroups));
            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    SizeGroup group = item.DataBoundItem as SizeGroup;
            //    if (group.SizeGroupName == SystemDefault.DefaultSizeGroup) {
            //        item.ReadOnly = true;
            //    }
            //}

        }

        private void SizeGroupCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
            Search();
        }

        private void Initialize()
        {
            this.dataGridView1.DataSource = null;
        }

        private void DoEnable(SizeGroup item)
        {
            try
            {

                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                EnabledSizeGroupPara para = new EnabledSizeGroupPara()
                {
                    SizeGroupName = item.SizeGroupName,
                    Enabled = item.Enabled
                };
                InteractResult result = CommonGlobalCache.ServerProxy.EnabledSizeGroup(para);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        item.Enabled = !item.Enabled;
                        dataGridView1.RefreshEdit();
                        break;
                    default:
                        break;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    SizeGroup item = (SizeGroup)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                    if (e.ColumnIndex == enabledDataGridViewCheckBoxColumn.Index)
                    {
                        item.Enabled = !item.Enabled;
                        DoEnable(item);
                    }
                    else if (e.ColumnIndex == ColumnEdit.Index)
                    {
                        Edit(item);
                    }
                    else if (e.ColumnIndex == ColumnDelete.Index)
                    {
                        Removed(item);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void Edit(SizeGroup item)
        {
            SizeGroupEditForm form = new SizeGroupEditForm();
            if (form.ShowDialog(item, false) == DialogResult.OK)
            {
                RefreshPage();
            }
        }

        private void Removed(SizeGroup item)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (GlobalMessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String sizeGroupName = item.SizeGroupName;
                    InteractResult result = GlobalCache.ServerProxy.DeleteSizeGroup(sizeGroupName);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalCache.DeleteSizeGroup(sizeGroupName);
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
            catch (Exception ee)
            {
                ShowError(ee);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            DataGridView dataGridView = (DataGridView)sender;
            try
            {
                //检查现有的列表是否有重复名称
                List<SizeGroup> sizeGroups = DataGridViewUtil.BindingListToList<SizeGroup>(dataGridView1.DataSource); 
                SizeGroup group = dataGridView1.Rows[e.RowIndex].DataBoundItem as SizeGroup;
                if (e.ColumnIndex == sizeGroupNameDataGridViewTextBoxColumn.Index)
                {
                    if (e.FormattedValue == null || String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        GlobalMessageBox.Show("尺码组名称不能为空！");
                        dataGridView.CancelEdit();
                        return;
                    }
                    if (sizeGroups != null)
                    {
                        int index = sizeGroups.FindIndex(t => e.FormattedValue?.ToString() == t.ShowName);
                        if (e.RowIndex != index)
                        {
                            if (index > -1)
                            {
                                GlobalMessageBox.Show("尺码组名称已存在！");
                                dataGridView.CancelEdit();
                                return;
                            }
                        }
                    }
                }
                else if (e.ColumnIndex >= nameOfFDataGridViewTextBoxColumn.Index && e.ColumnIndex <= nameOfXL6DataGridViewTextBoxColumn.Index)
                {

                    if (e.FormattedValue == null || String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        GlobalMessageBox.Show("尺码名称不能为空！");
                        dataGridView.CancelEdit();
                        return;
                    }
                    else
                    {
                        //不能重复
                        string currertKeyValue = e.FormattedValue.ToString();
                        //排除这一个单元格的判断
                        foreach (SizeGroup sizeGroup in sizeGroups)
                        {
                            bool checkBool = false;
                            //如果是同一个group，那么只检查不是同个属性的值
                            if (group == sizeGroup)
                            {
                                if (e.ColumnIndex != nameOfFDataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfF == currertKeyValue; }
                                if (e.ColumnIndex != nameOfXSDataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfXS == currertKeyValue; }
                                if (e.ColumnIndex != nameOfSDataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfS == currertKeyValue; }
                                if (e.ColumnIndex != nameOfMDataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfM == currertKeyValue; }
                                if (e.ColumnIndex != nameOfLDataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfL == currertKeyValue; }
                                if (e.ColumnIndex != nameOfXLDataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfXL == currertKeyValue; }
                                if (e.ColumnIndex != nameOfXL2DataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfXL2 == currertKeyValue; }
                                if (e.ColumnIndex != nameOfXL3DataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfXL3 == currertKeyValue; }
                                if (e.ColumnIndex != nameOfXL4DataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfXL4 == currertKeyValue; }
                                if (e.ColumnIndex != nameOfXL5DataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfXL5 == currertKeyValue; }
                                if (e.ColumnIndex != nameOfXL6DataGridViewTextBoxColumn.Index) { checkBool = checkBool || sizeGroup.NameOfXL6 == currertKeyValue; }
                            }
                            else
                            {
                                //不是同一个GROUP，那么检查所有字段
                                checkBool = sizeGroup.NameOfF == currertKeyValue ||
                                   sizeGroup.NameOfS == currertKeyValue ||
                                   sizeGroup.NameOfM == currertKeyValue ||
                                   sizeGroup.NameOfL == currertKeyValue ||
                                   sizeGroup.NameOfXL == currertKeyValue ||
                                   sizeGroup.NameOfXL2 == currertKeyValue ||
                                   sizeGroup.NameOfXL3 == currertKeyValue ||
                                   sizeGroup.NameOfXL4 == currertKeyValue ||
                                   sizeGroup.NameOfXL5 == currertKeyValue ||
                                   sizeGroup.NameOfXL6 == currertKeyValue;
                            }

                            if (checkBool)
                            {
                                GlobalMessageBox.Show("尺码名称已存在！");
                                dataGridView.CancelEdit();
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
        }

        private void BaseButton3_Click(object sender, EventArgs e)
        {
            SizeGroupEditForm form = new SizeGroupEditForm();
            form.Text = "添加尺码";
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshPage();
            }
        }

        //    private void BaseButton3_Click(object sender, EventArgs e)
        //{
        //    List<SizeGroup> sizeGroups = CommonGlobalCache.SizeGroupList;
        //    SizeGroup group = new SizeGroup();

        //    int i = 1;
        //    String sizeGroupName = "尺码组" + i++;
        //    while (sizeGroups.FindIndex(t => t.ShowName == sizeGroupName) >= 0)
        //    {
        //        sizeGroupName = "尺码组" + i++;
        //    }
        //    group.SizeGroupName = sizeGroupName;
        //    group.ShowName = sizeGroupName;
        //    i = 1;
        //    int i1 = 1, i2 = 1;
        //    for (int a = 0; a < sizeGroups.Count; a++)
        //    {
        //        if (sizeGroups[a].NameOfF.Length > 2 && sizeGroups[a].NameOfF.Substring(0, 2) == "尺码")
        //        {
        //            i2 = Convert.ToInt32(sizeGroups[a].NameOfF.Substring(2, sizeGroups[a].NameOfF.Length - 2));
        //        }
        //        if (sizeGroups[a].NameOfXS.Length > 2 && sizeGroups[a].NameOfXS.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfXS.Substring(2, sizeGroups[a].NameOfXS.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }
        //        if (sizeGroups[a].NameOfS.Length > 2 && sizeGroups[a].NameOfS.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfS.Substring(2, sizeGroups[a].NameOfS.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }
        //        if (sizeGroups[a].NameOfM.Length > 2 && sizeGroups[a].NameOfM.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfM.Substring(2, sizeGroups[a].NameOfM.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }

        //        if (sizeGroups[a].NameOfL.Length > 2 && sizeGroups[a].NameOfL.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfL.Substring(2, sizeGroups[a].NameOfL.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }

        //        if (sizeGroups[a].NameOfXL2.Length > 2 && sizeGroups[a].NameOfXL2.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfXL2.Substring(2, sizeGroups[a].NameOfXL2.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }
        //        if (sizeGroups[a].NameOfXL3.Length > 2 && sizeGroups[a].NameOfXL3.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfXL3.Substring(2, sizeGroups[a].NameOfXL3.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }
        //        if (sizeGroups[a].NameOfXL4.Length > 2 && sizeGroups[a].NameOfXL4.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfXL4.Substring(2, sizeGroups[a].NameOfXL4.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }
        //        if (sizeGroups[a].NameOfXL5.Length > 2 && sizeGroups[a].NameOfXL5.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfXL5.Substring(2, sizeGroups[a].NameOfXL5.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }
        //        if (sizeGroups[a].NameOfXL6.Length > 2 && sizeGroups[a].NameOfXL6.Substring(0, 2) == "尺码")
        //        {
        //            i1 = Convert.ToInt32(sizeGroups[a].NameOfXL6.Substring(2, sizeGroups[a].NameOfXL6.Length - 2));
        //            if (i1 > i2)
        //            {
        //                i2 = i1;
        //            }
        //        }
        //        if (i2 > i)
        //        {
        //            i = i2;
        //        }
        //    }

        //    //检查重复尺码

        //    group.NameOfF = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfF))
        //    {
        //        group.NameOfF = "尺码" + i++;
        //    }
        //    group.NameOfXS = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfXS))
        //    {
        //        group.NameOfXS = "尺码" + i++;
        //    }
        //    group.NameOfS = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfS))
        //    {
        //        group.NameOfS = "尺码" + i++;
        //    }
        //    group.NameOfM = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfM))
        //    {
        //        group.NameOfM = "尺码" + i++;
        //    }
        //    group.NameOfL = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfL))
        //    {
        //        group.NameOfL = "尺码" + i++;
        //    }
        //    group.NameOfXL = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfXL))
        //    {
        //        group.NameOfXL = "尺码" + i++;
        //    }
        //    group.NameOfXL2 = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfXL2))
        //    {
        //        group.NameOfXL2 = "尺码" + i++;
        //    }
        //    group.NameOfXL3 = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfXL3))
        //    {
        //        group.NameOfXL3 = "尺码" + i++;
        //    }
        //    group.NameOfXL4 = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfXL4))
        //    {
        //        group.NameOfXL4 = "尺码" + i++;
        //    }
        //    group.NameOfXL5 = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfXL5))
        //    {
        //        group.NameOfXL5 = "尺码" + i++;
        //    }
        //    group.NameOfXL6 = "尺码" + i++;
        //    while (CheckDuplicateSizeName(group.NameOfXL6))
        //    {
        //        group.NameOfXL6 = "尺码" + i++;
        //    }
        //    group.Enabled = true;
        //    //    sizeGroups.Add(group);

        //    InteractResult result = GlobalCache.ServerProxy.InsertSizeGroup(group);
        //    switch (result.ExeResult)
        //    {
        //        case ExeResult.Success:
        //            group.SizeGroupName = result.Msg;
        //            GlobalCache.InsertSizeGroup(group);
        //            break;
        //        case ExeResult.Error:
        //            GlobalMessageBox.Show(result.Msg);
        //            break;
        //        default:
        //            break;
        //    }

        //    BindingMemberDateSource(sizeGroups);
        //    DataGridViewUtil.AutoFocusToFirstWritableCell(dataGridView1, sizeGroups.Count - 1);
        //}

        private bool CheckDuplicateSizeName(string checkName)
        {
            bool duplicated = false;
            List<SizeGroup> sizeGroups = CommonGlobalCache.SizeGroupList;
            foreach (var sizeGroup in sizeGroups)
            {
                if (sizeGroup.NameOfF.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfXS.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfS.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfM.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfL.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfXL.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfXL2.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfXL3.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfXL4.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfXL5.ToLower().Trim() == checkName.ToLower().Trim() ||
                    sizeGroup.NameOfXL6.ToLower().Trim() == checkName.ToLower().Trim())
                {
                    duplicated = true;
                    break;
                }
            }
            return duplicated;
        }
        private String path;

        private void DoExport()
        {
            try
            {
                List<SizeGroup> list = DataGridViewUtil.BindingListToList<SizeGroup>(dataGridView1.DataSource);
                System.Collections.SortedList columns = new System.Collections.SortedList();
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    if (item.Visible)
                    {
                        if (item.Name != "enabledDataGridViewCheckBoxColumn" && item.Name != "ColumnEdit" && item.Name != "ColumnDelete")
                        {
                            keys.Add(item.DataPropertyName);
                            values.Add(item.HeaderText);
                        }
                    }
                }
                //List<Brand> ExportList = new List<Brand>();
                //foreach (Brand cItem in list)
                //{
                //    Brand curBrand = new Brand();
                //    curBrand.Name = cItem.Name;
                //    curBrand.FirstCharSpell = cItem.FirstCharSpell;
                //    ExportList.Add(curBrand);
                //}



                NPOIHelper.Keys = keys.ToArray();
                NPOIHelper.Values = values.ToArray();
                NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);

                GlobalMessageBox.Show("导出完毕！");
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }
        private void baseButton1_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "尺码" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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

        //private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
        //    if (e.ColumnIndex == enabledDataGridViewCheckBoxColumn.Index || e.ColumnIndex == ColumnDelete.Index) { return; }             
        //    DataGridView dataGridView = (DataGridView)sender;
        //    try
        //    {
        //        SizeGroup group = dataGridView.Rows[e.RowIndex].DataBoundItem as SizeGroup;
        //        if (group.SizeGroupName != SystemDefault.DefaultSizeGroup)
        //        {

        //            InteractResult result = GlobalCache.ServerProxy.UpdateSizeGroup(group);
        //            switch (result.ExeResult)
        //            {
        //                case ExeResult.Success:
        //                    break;
        //                case ExeResult.Error:
        //                    GlobalMessageBox.Show(result.Msg); 
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CommonGlobalUtil.ShowError(ex);
        //    }
        //}
    }
}
