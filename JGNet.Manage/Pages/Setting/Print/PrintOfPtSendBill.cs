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
using JGNet.Core.Const; 
using CJBasic.Helpers;
using JGNet.Core.Tools;
using JGNet.Common.Core.Util;

namespace JGNet.Manage.Pages
{
    public partial class PrintOfPtSendBill : BaseModifyUserControl
    {

        public PrintOfPtSendBill()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.打印设置;
        }
        
        private List<PrintSysInfo> lastPrintSysInfo = new List<PrintSysInfo>();
        private List<PrintColumnsInfo> lastPrintColumnsInfo = new List<PrintColumnsInfo>();
        private List<PrintSysInfo> firstList = new List<PrintSysInfo>();
        private List<PrintSysInfo> secondList = new List<PrintSysInfo>();
        private void PrintSettingCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
            this.txtDataName.SkinTxt.TextChanged += SkinTxt_TextChanged;
            //DataGridViewUtil.ListToBindingList(list)

            //List<PfAccountContrastInfo> list = DataGridViewUtil.BindingListToList<PfAccountContrastInfo>(dataGridView1.DataSource);
            // skinTreeViewPermisson.Nodes.Clear();
            //   skinTreeViewPermisson.Nodes.AddRange(getTypeAll().ToArray());
            setSysVariable();
            setColumnsInfo();
           
           
            lastPrintColumnsInfo = (List<PrintColumnsInfo>)dataGridViewColumns.DataSource;
            lastPrintSysInfo = (List<PrintSysInfo>)dataGridViewSys.DataSource;
            getAllList(lastPrintSysInfo, out firstList, out secondList);
            // setLblValue(lastPrintSysInfo);
            if (result.Data == null)
            {
                setColumnsHeaderInfo(lastPrintColumnsInfo,new List<PrintColumnInfo>());
            }
          
             selectPrintInfo();
            this.lblCurDataName.Text = this.txtDataName.SkinTxt.Text.Trim();
            //  dataGridViewSys.DataSource= GlobalUtilOfPrint.getPurchaseStockSysInfo();
              dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(nameDataGridViewTextBoxColumn1);
            dataGridViewPagingSumCtrl1.AppendNotShowInColumnSettings(nameDataGridViewTextBoxColumn);
        }
        private void getAllList(List<PrintSysInfo> allList, out List<PrintSysInfo> oneList, out List<PrintSysInfo> twoList)
        {
            oneList = new List<PrintSysInfo>();
            twoList = new List<PrintSysInfo>();
            foreach (PrintSysInfo Pinfo in allList)
            {
                if (Pinfo.name == "单据备注")
                {
                    twoList.Add(Pinfo);
                }
                else
                {

                    oneList.Add(Pinfo);
                }
            }
        }
        InteractResult<PrintTemplateInfo> result = GlobalCache.ServerProxy.GetPrintTemplateInfo(PrintTemplateType.PfTOrder);
        private void selectPrintInfo()
        {
             
            switch (result.ExeResult)
            {
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                case ExeResult.Success:
                    PrintTemplateInfo PTempInfo = result.Data;
                    if (PTempInfo.PrintColumnInfos.Count > 0)
                    {
                        // List<PrintColumnsInfo> list = GlobalUtilOfPrint.getPurchaseStockColumnsInfo();

                        List<PrintColumnsInfo> source = (List<PrintColumnsInfo>)this.dataGridViewColumns.DataSource;
                        //lastPrintColumnsInfo.Clear();
                        List<PrintColumnsInfo> columnsSelect = new List<PrintColumnsInfo>();
                        foreach (PrintColumnsInfo cInfo in source)
                        {
                            foreach (PrintColumnInfo item in PTempInfo.PrintColumnInfos)
                            {

                                if (cInfo.name == item.Name)
                                {
                                    cInfo.ischeck = true;
                                    
                                    columnsSelect.Add(cInfo);
                                    break;
                                }
                                else
                                {
                                    cInfo.ischeck = false;
                                }
                            }
                        }
                        curColumnInfo = PTempInfo.PrintColumnInfos;
                        curColumnsSelect = columnsSelect;
                        setColumnsHeaderInfo(columnsSelect,PTempInfo.PrintColumnInfos);
                        this.dataGridViewColumns.DataSource = source;

                    }
                    else
                    {
                        List<PrintColumnsInfo> source = (List<PrintColumnsInfo>)this.dataGridViewColumns.DataSource;
                        foreach (PrintColumnsInfo cItem in source)
                        {
                            cItem.ischeck = false;
                        }
                        List<PrintColumnInfo> sourceList = null;

                        this.dataGridView3.DataSource = sourceList;
                    }
                    if (PTempInfo.SystemVariables.Count > 0)
                    {
                        List<PrintSysInfo> list = (List<PrintSysInfo>)this.dataGridViewSys.DataSource;
                      //  lastPrintSysInfo.Clear();
                        List<PrintSysInfo> columnsSys = new List<PrintSysInfo>();
                        List<PrintSysInfo> markSys = new List<PrintSysInfo>();
                        foreach (PrintSysInfo pSys in list)
                        {
                            foreach (string sysInfo in PTempInfo.SystemVariables)
                            {

                                if (pSys.name == sysInfo)
                                {
                                    pSys.ischeck = true;
                                    if (pSys.name == "单据备注") { markSys.Add(pSys); }
                                    else
                                    {
                                        columnsSys.Add(pSys);
                                    }
                                    break;
                                }
                                else
                                {
                                    pSys.ischeck = false;
                                }
                            }
                        }


                        loadList.AddRange(columnsSys);
                        loadList.AddRange(markSys);
                        setLblValue(columnsSys, markSys);
                        this.dataGridViewSys.DataSource = list;
                    }
                    else
                    {
                        List<PrintSysInfo> list = (List<PrintSysInfo>)this.dataGridViewSys.DataSource;
                        foreach (PrintSysInfo item in list)
                        {
                            item.ischeck = false;
                        }
                    }
                    if (PTempInfo.OrderName != null && PTempInfo.OrderName != "")
                    {
                        this.lblCurDataName.Text = PTempInfo.OrderName;
                        this.txtDataName.Text = PTempInfo.OrderName;
                    }
                    if (PTempInfo.PrintCount > 0)
                    {
                        this.numericTxtCount.Text = PTempInfo.PrintCount.ToString();
                    }

                    // lastPrintColumnsInfo=result.Data.
                    // listColumns = result.Data.PrintColumnInfos;
                    break;
                default:
                    break;
            }

           

        } 
        private void setColumnsInfo()
        {
            List<PrintColumnsInfo> list = GlobalUtilOfPrint.getPfSendBillColumnsInfo();
            foreach (PrintColumnsInfo pInfo in list)
            {
                pInfo.ischeck = true;
            }
            dataGridViewColumns.DataSource = list;
        }
        private void setSysVariable()
        {
            List<PrintSysInfo> list = GlobalUtilOfPrint.getPfSendBillSysInfo();
            foreach (PrintSysInfo pInfo in list)
            {
                pInfo.ischeck = true;
            }
            dataGridViewSys.DataSource = list;
        }


       


        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;

       

        private void Initialize()
        {

            dataGridViewSys.AutoGenerateColumns = false;
            dataGridViewColumns.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridViewSys);
            dataGridViewPagingSumCtrl.ShowRowCounts = false;
            dataGridViewPagingSumCtrl.Initialize();

            dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(this.dataGridViewColumns);
            dataGridViewPagingSumCtrl1.ShowRowCounts = false;
            dataGridViewPagingSumCtrl1.Initialize();
            lblCurDataName.Text = "";
            lblName1.Text = "";
            lblName2.Text = "";
            lblName3.Text = "";
            lblName4.Text = "";
            lblName5.Text = "";
            lblName6.Text = "";
            lblName7.Text = "";
            lblName8.Text = "";
            lblName9.Text = "";
            lblName10.Text = "";




        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }


        bool flag = false;
        List<PrintSysInfo> loadList = new List<PrintSysInfo>();
        private void baseButtonSave_Click(object sender, EventArgs e)
        {
            int gWidth=this.dataGridView3.Width;
            //          打印模板
            //GetPrintTemplateInfo
            //SavePrintTemplateInfo
            List<PrintColumnInfo> listOfColumns = new List<PrintColumnInfo>();
           // PrintColumnInfo p = new PrintColumnInfo();
            List<string> listSys = new List<string>();

            if (!flag)
            {
                lastPrintSysInfo = loadList;
            }
            foreach (PrintSysInfo pSysInfo in lastPrintSysInfo) {
                listSys.Add(pSysInfo.name);
            }
            foreach (PrintColumnsInfo cColumnInfo in lastPrintColumnsInfo)
            {

                for (int i = 0; i < this.dataGridView3.Columns.Count; i++)
                {
                    if (this.dataGridView3.Columns[i].HeaderText == cColumnInfo.name)
                    {
                        PrintColumnInfo sCol = new PrintColumnInfo();
                        sCol.Name = cColumnInfo.name;
                        sCol.Rate = Math.Round(Convert.ToDecimal(this.dataGridView3.Columns[i].Width)/Convert.ToDecimal(this.dataGridView3.Width)*100,2);
                        // ShowMessage(sCol.Name+"=" + sCol.Rate);
                        listOfColumns.Add(sCol);
                    }
                }
                
            }


            try
            {
                InteractResult result = GlobalCache.ServerProxy.SavePrintTemplateInfo(new PrintTemplateInfo()
                {
                    Type = PrintTemplateType.PfTOrder,
                    OrderName = lblCurDataName.Text,
                    PrintCount = Convert.ToInt32(numericTxtCount.Text),
                    PrintColumnInfos = listOfColumns,
                    SystemVariables = listSys,

                });
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        GlobalMessageBox.Show("保存成功！");
                        // ReflectionHelper.CopyProperty(role, user);
                        //   dataGridViewSys.Refresh();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) {
                CommonGlobalUtil.ShowError(ex);
            }
                   
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
           
        }



        private void baseButtonNew_Click(object sender, EventArgs e)
        {
            
        }
        private void SetUpShopView(List<string> list)
        {
            //设置系统变量

            List<string> keyValues = list;
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewSys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<PrintSysInfo> source = (List<PrintSysInfo>) this.dataGridViewSys.DataSource;
            PrintSysInfo item = source[e.RowIndex];
            List<PrintSysInfo> curSysInfo = new List<PrintSysInfo>();
           

            for (int i = 0; i < curSysInfo.Count; i++)
            {

            }
           

        }

        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
            this.lblCurDataName.Text =this.txtDataName.SkinTxt.Text.Trim();
            
        }

        private void dataGridViewColumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            List<PrintColumnsInfo> source =(List<PrintColumnsInfo>)this.dataGridViewSys.DataSource ;
            PrintColumnsInfo item = source[e.RowIndex];

        }

        private void dataGridViewSys_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*  List<PrintSysInfo> source = DataGridViewUtil.BindingListToList<PrintSysInfo>(dataGridViewSys.DataSource);  //(List<PrintSysInfo>)this.dataGridViewSys.DataSource;
              PrintSysInfo item = source[e.RowIndex];

              */
            List<PrintSysInfo> curSysInfo = new List<PrintSysInfo>();

            List<PrintSysInfo> OtherSysInfo = new List<PrintSysInfo>();
            List<PrintSysInfo> MarkSysInfo = new List<PrintSysInfo>();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridViewSys.Rows[e.RowIndex].IsNewRow)
            {
                DataGridView view = (DataGridView)sender;
                List<PrintSysInfo> source = (List<PrintSysInfo>)view.DataSource;
                PrintSysInfo item = (PrintSysInfo)source[e.RowIndex];

                if (e.ColumnIndex == Column5.Index)
                {
                    flag = true;
                    foreach (PrintSysInfo pInfo in source)
                    {
                        if (item.name == pInfo.name)
                        {
                            item.ischeck = (bool)this.dataGridViewSys[e.ColumnIndex, e.RowIndex].Value;
                            if (item.ischeck)
                            {
                                if (pInfo.name == "单据备注") { MarkSysInfo.Add(pInfo); }
                                else
                                {
                                    OtherSysInfo.Add(pInfo);
                                }
                            }
                        }
                        else
                        {
                            if (pInfo.ischeck)
                            {

                                if (pInfo.name == "单据备注") { MarkSysInfo.Add(pInfo); }
                                else
                                {
                                    OtherSysInfo.Add(pInfo);
                                }
                            }
                        }
                    }
                    //if (item.ischeck)
                    //{
                    //    curSysInfo.Add(item);
                    //}
                    setLblValue(OtherSysInfo, MarkSysInfo);
                    foreach (PrintSysInfo oneItem in OtherSysInfo)
                    {
                        curSysInfo.Add(oneItem);
                    }
                    foreach (PrintSysInfo twoItem in MarkSysInfo)
                    {
                        curSysInfo.Add(twoItem);
                    }

                    lastPrintSysInfo = curSysInfo;
                }
            }
        }
        /// <summary>
        /// 设置模板显示变量
        /// </summary>
        /// <param name="curSysInfo"></param>
        private void setLblValue(List<PrintSysInfo> curSysInfo, List<PrintSysInfo> MarkSysInfo)
        {
            #region
            switch (curSysInfo.Count)
            {
                case 0:
                    this.lblName1.Text = "";
                    this.lblName2.Text = "";
                    this.lblName3.Text = "";
                    this.lblName4.Text = "";
                    this.lblName5.Text = "";
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;
                case 1:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = "";
                    this.lblName3.Text = "";
                    this.lblName4.Text = "";
                    this.lblName5.Text = "";
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;
                case 2:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = "";
                    this.lblName4.Text = "";
                    this.lblName5.Text = "";
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;
                case 3:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = curSysInfo[2].name;
                    this.lblName4.Text = "";
                    this.lblName5.Text = "";
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;

                case 4:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = curSysInfo[2].name;
                    this.lblName4.Text = curSysInfo[3].name;
                    this.lblName5.Text = "";
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;

                case 5:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = curSysInfo[2].name;
                    this.lblName4.Text = curSysInfo[3].name;
                    this.lblName5.Text = curSysInfo[4].name;
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;

                case 6:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = curSysInfo[2].name;
                    this.lblName4.Text = curSysInfo[3].name;
                    this.lblName5.Text = curSysInfo[4].name;
                    this.lblName6.Text = curSysInfo[5].name;
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;

                case 7:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = curSysInfo[2].name;
                    this.lblName4.Text = curSysInfo[3].name;
                    this.lblName5.Text = curSysInfo[4].name;
                    this.lblName6.Text = curSysInfo[5].name;
                    this.lblName7.Text = curSysInfo[6].name;
                    this.lblName8.Text ="";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;

                case 8:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = curSysInfo[2].name;
                    this.lblName4.Text = curSysInfo[3].name;
                    this.lblName5.Text = curSysInfo[4].name;
                    this.lblName6.Text = curSysInfo[5].name;
                    this.lblName7.Text = curSysInfo[6].name;
                    this.lblName8.Text = curSysInfo[7].name;
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;
                case 9:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = curSysInfo[2].name;
                    this.lblName4.Text = curSysInfo[3].name;
                    this.lblName5.Text = curSysInfo[4].name;
                    this.lblName6.Text = curSysInfo[5].name;
                    this.lblName7.Text = curSysInfo[6].name;
                    this.lblName8.Text = curSysInfo[7].name;
                    this.lblName9.Text = curSysInfo[8].name;
                    this.lblName10.Text = "";
                    break;
                case 10:
                    this.lblName1.Text = curSysInfo[0].name;
                    this.lblName2.Text = curSysInfo[1].name;
                    this.lblName3.Text = curSysInfo[2].name;
                    this.lblName4.Text = curSysInfo[3].name;
                    this.lblName5.Text = curSysInfo[4].name;
                    this.lblName6.Text = curSysInfo[5].name;
                    this.lblName7.Text = curSysInfo[6].name;
                    this.lblName8.Text = curSysInfo[7].name;
                    this.lblName9.Text = curSysInfo[8].name;
                    this.lblName10.Text = curSysInfo[9].name;
                    break;
                default:
                    break;
            }
            #endregion
            #region
            switch (MarkSysInfo.Count)
            {
                case 0:
                    this.lblName10.Text = "";
                    break;
                case 1:
                    this.lblName10.Text = MarkSysInfo[0].name;
                    break;

                default:
                    break;
            }
            #endregion
        }

        private void dataGridViewColumns_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            List<PrintColumnsInfo> curColumnsInfo = new List<PrintColumnsInfo>(); 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridViewColumns.Rows[e.RowIndex].IsNewRow)
            {
                DataGridView view = (DataGridView)sender;
                List<PrintColumnsInfo> source = (List<PrintColumnsInfo>)view.DataSource;
                PrintColumnsInfo item = (PrintColumnsInfo)source[e.RowIndex];

                if (e.ColumnIndex == Column5.Index)
                {
                    foreach (PrintColumnsInfo pInfo in source)
                    {
                        if (item.name == pInfo.name)
                        {
                            item.ischeck = (bool)this.dataGridViewColumns[e.ColumnIndex, e.RowIndex].Value;
                            if (item.ischeck)
                            {
                                curColumnsInfo.Add(pInfo);
                            }
                        }
                        else
                        {
                            if (pInfo.ischeck)
                            {
                                curColumnsInfo.Add(pInfo);
                            }
                        }
                    }
                    //if (item.ischeck)
                    //{
                    //    curSysInfo.Add(item);
                    //}

                    lastPrintColumnsInfo = curColumnsInfo; 
                    setColumnsHeaderInfo(curColumnsInfo,new List<PrintColumnInfo>());
                }
            }
        }
        /// <summary>
        /// 设置模板显示表头列名
        /// </summary>
        /// <param name="columnsInfo"></param>
        private void setColumnsHeaderInfo(List<PrintColumnsInfo> columnsInfo,  List<PrintColumnInfo> printCol = null)
        {

            switch (columnsInfo.Count)
            {
                case 0:
                    this.dataGridView3.Columns.Clear();
                    break;
                case 1:
                    #region
                    GlobalUtilOfPrint.CreateColumns1(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;
                case 2:
                    GlobalUtilOfPrint.CreateColumns2(columnsInfo, this.dataGridView3, printCol);
                    break;
                case 3:
                    GlobalUtilOfPrint.CreateColumns3(columnsInfo, this.dataGridView3, printCol);
                    break;
                case 4:
                    GlobalUtilOfPrint.CreateColumns4(columnsInfo, this.dataGridView3, printCol);
                    break;

                case 5:
                    GlobalUtilOfPrint.CreateColumns5(columnsInfo, this.dataGridView3, printCol);
                    break;

                case 6:
                    GlobalUtilOfPrint.CreateColumns6(columnsInfo, this.dataGridView3, printCol);
                    break;

                case 7:
                    GlobalUtilOfPrint.CreateColumns7(columnsInfo, this.dataGridView3, printCol);
                    break;
                case 8:
                    GlobalUtilOfPrint.CreateColumns8(columnsInfo, this.dataGridView3, printCol);
                    break;
                case 9:
                    GlobalUtilOfPrint.CreateColumns9(columnsInfo, this.dataGridView3, printCol);
                    break;
                case 10:

                    #region

                    GlobalUtilOfPrint.CreateColumns10(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;
                case 11:
                    #region

                    GlobalUtilOfPrint.CreateColumns11(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;
                case 12:
                    #region
                    GlobalUtilOfPrint.CreateColumns12(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;
                case 13:
                    #region
                    GlobalUtilOfPrint.CreateColumns13(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;

                case 14:
                    #region
                    GlobalUtilOfPrint.CreateColumns14(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;

                case 15:
                    #region
                    GlobalUtilOfPrint.CreateColumns15(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;

                case 16:
                    #region
                    GlobalUtilOfPrint.CreateColumns16(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;

                case 17:
                    #region
                    GlobalUtilOfPrint.CreateColumns17(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;

                case 18:
                    #region
                    GlobalUtilOfPrint.CreateColumns18(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;

                case 19:
                    #region
                    GlobalUtilOfPrint.CreateColumns19(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;

                case 20:
                    #region
                    GlobalUtilOfPrint.CreateColumns20(columnsInfo, this.dataGridView3, printCol);
                    #endregion
                    break;



                default:
                    break;
            }
        }

        private List<PrintColumnInfo> curColumnInfo = null;
        private List<PrintColumnsInfo> curColumnsSelect = null;

        private void PrintOfPtSendBill_SizeChanged(object sender, EventArgs e)
        {

            if (curColumnsSelect != null && curColumnInfo != null)
            {
                setColumnsHeaderInfo(curColumnsSelect, curColumnInfo);
            }
        }
    }
}
