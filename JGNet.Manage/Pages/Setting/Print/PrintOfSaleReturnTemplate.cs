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
    public partial class PrintOfSaleReturnTemplate : BaseModifyUserControl
    {

        public PrintOfSaleReturnTemplate()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.打印设置;
        }
        
        private List<PrintSysInfo> lastPrintSysInfo = new List<PrintSysInfo>();
        private List<PrintSysInfo> lastPrintSysInfoOfBillTemplate = new List<PrintSysInfo>();
        private List<PrintColumnsInfo> lastPrintColumnsInfo = new List<PrintColumnsInfo>();
        private List<PrintColumnsInfo> lastPrintColumnsInfoOfBillTemplate = new List<PrintColumnsInfo>();
        private List<PrintSysInfo> firstL  = new List<PrintSysInfo>();
        private List<PrintSysInfo> secondL  = new List<PrintSysInfo>();

        private List<PrintSysInfo> firstLOfBillTemplate = new List<PrintSysInfo>();
        private List<PrintSysInfo> secondLOfBillTemplate = new List<PrintSysInfo>();

        private List<PrintSysInfo> thirdL = new List<PrintSysInfo>();
        private List<PrintSysInfo> fourthL  = new List<PrintSysInfo>();
        private bool isAddQRCode=false;
        private RetailPrintType curType=RetailPrintType.SmallTickets;
        private void PrintSettingCtrl_Load(object sender, EventArgs e)
        {
            if (rPrintType.ExeResult == ExeResult.Success)
            {
                curType = rPrintType.Data;
            }
            if (curType == RetailPrintType.Order)
            {
               
                this.skinRadioButton2.Checked = true;
            }
            else
            {
               
                this.skinRadioButton1.Checked = true;
            }
            Initialize();
                setSysVariable();
                setColumnsInfo();
            lastPrintColumnsInfo = (List<PrintColumnsInfo>)dataGridViewColumns.DataSource;

            getSaleReturnAllList(lastPrintSysInfo, out firstL, out secondL, out thirdL, out fourthL);

            selectPrintInfo();
            dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(nameDataGridViewTextBoxColumn1);
            dataGridViewPagingSumCtrl1.AppendNotShowInColumnSettings(nameDataGridViewTextBoxColumn);
            if (this.skinRadioButton1.Checked)
            {
               
                SetDisplayPanle(0);
                if (result.Data.PrintColumnInfos == null)
                {
                    setColumnsHeaderInfo((List<PrintColumnsInfo>)dataGridViewColumns.DataSource, new List<PrintColumnInfo>());
                }

              
            }
            else
            {
                if (resultOfBillTemplate.Data.PrintColumnInfos == null)
                {
                    setColumnsHeaderInfoOfBillTemplate((List<PrintColumnsInfo>)dataGridViewColumnsOfBillTemplate.DataSource, new List<PrintColumnInfo>());

                }

              

                SetDisplayPanle(1);
            }
            
            this.txtDataName.SkinTxt.TextChanged += SkinTxt_TextChanged;
            this.skinLabel8.Text = this.txtDataName.SkinTxt.Text.Trim();
            InitializeOfBillTemplate();
            setSysVariableOfBillTemplate();
            setColumnsInfoOfBillTemplate();

            lastPrintColumnsInfoOfBillTemplate = (List<PrintColumnsInfo>)dataGridViewColumnsOfBillTemplate.DataSource;
            getSaleReturnAllListOfBillTemplate(lastPrintSysInfoOfBillTemplate, out firstLOfBillTemplate, out secondLOfBillTemplate);
            selectPrintInfoOfBillTemplate();


            //  selectPrintInfoOfBillTemplate();
        }
        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
            this.skinLabel8.Text = this.txtDataName.SkinTxt.Text.Trim();

        }
        private void getSaleReturnAllList(List<PrintSysInfo> list, out List<PrintSysInfo> firstList, out List<PrintSysInfo> secondeList, out List<PrintSysInfo> thirdList, out List<PrintSysInfo> fourthList)
        {
            firstList = new List<PrintSysInfo>();
            secondeList = new List<PrintSysInfo>();
            thirdList = new List<PrintSysInfo>();
            fourthList = new List<PrintSysInfo>();
            foreach (PrintSysInfo info in list)
            {
                if (info.name == "单号" || info.name == "日期" || info.name == "电话" || info.name == "地址" || info.name == "顾问")
                {
                    firstList.Add(info);
                }
                else if (info.name == "卡号" || info.name == "本次积分" || info.name == "当前积分" || info.name == "累计积分" || info.name == "余额")
                {
                    secondeList.Add(info);
                }
                else if (info.name == "银联卡" || info.name == "现金" || info.name == "VIP卡" || info.name == "支付宝" || info.name == "微信" || info.name == "积分兑现" || info.name == "优惠券" || info.name == "其他")
                {
                    thirdList.Add(info);
                }
                else if (info.name == "数量" || info.name == "折扣优惠" || info.name == "应收" || info.name == "姓名" || info.name == "找零" || info.name == "结尾附加文字" || info.name == "商城二维码"|| info.name== "店铺")
                {
                    fourthList.Add(info);
                }
            }

        }
        private void getSaleReturnAllListOfBillTemplate(List<PrintSysInfo> list, out List<PrintSysInfo> firstList, out List<PrintSysInfo> secondeList)
        {
            firstList = new List<PrintSysInfo>();
            secondeList = new List<PrintSysInfo>();
            firstList.Clear();
            secondeList.Clear();
            foreach (PrintSysInfo info in list)
            {
                if (info.name == "销售单号" || info.name == "单据日期" || info.name == "客户名称" || info.name == "客户电话" || info.name == "客户地址"
                    || info.name == "操作人" || info.name == "单据备注")
                {
                    firstList.Add(info);
                }
                else if (info.name == "店铺地址" || info.name == "联系电话")
                {
                    secondeList.Add(info);
                }
                //销售单号、单据日期、客户名称、客户电话、客户地址、操作人、单据备注、店铺地址、联系电话
            }

        }
        InteractResult<PrintTemplateInfo> result = GlobalCache.ServerProxy.GetPrintTemplateInfo(PrintTemplateType.Retail);

        InteractResult<PrintTemplateInfo> resultOfBillTemplate = GlobalCache.ServerProxy.GetPrintTemplateInfo(PrintTemplateType.RetailOrder);
           InteractResult<RetailPrintType> rPrintType =  GlobalCache.ServerProxy.GetRetailPrintType(); 
        private List<PrintColumnInfo> curColumnInfo = null;

        private List<PrintColumnInfo> curColumnInfoOfBillTemplate = null;
        private List<PrintColumnsInfo> curColumnsSelect = null;
        private List<PrintColumnsInfo> curColumnsSelectOfBillTemplate = null;
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
                        List<PrintColumnsInfo> source = (List<PrintColumnsInfo>)this.dataGridViewColumns.DataSource; 
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
                        List<PrintSysInfo> columnsSys = new List<PrintSysInfo>();

                        List<PrintSysInfo> curFirstInfo = new List<PrintSysInfo>();
                        List<PrintSysInfo> curSecondInfo = new List<PrintSysInfo>();
                        List<PrintSysInfo> curThirdInfo = new List<PrintSysInfo>();
                        List<PrintSysInfo> curFourthInfo = new List<PrintSysInfo>();
                        foreach (PrintSysInfo pSys in list)
                        {
                            foreach (string sysInfo in PTempInfo.SystemVariables)
                            {

                                if (pSys.name == sysInfo)
                                {
                                    pSys.ischeck = true;
                                    if (pSys.name == "单号" || pSys.name == "日期" || pSys.name == "电话" || pSys.name == "地址" || pSys.name == "顾问")
                                    {
                                        curFirstInfo.Add(pSys);
                                    }
                                    else if (pSys.name == "卡号" || pSys.name == "本次积分" || pSys.name == "当前积分" || pSys.name == "累计积分" || pSys.name == "余额")
                                    {
                                        curSecondInfo.Add(pSys);
                                    }
                                    else if (pSys.name == "银联卡" || pSys.name == "现金" || pSys.name == "VIP卡" || pSys.name == "支付宝" || pSys.name == "微信" || pSys.name == "积分兑现" || pSys.name == "优惠券" || pSys.name == "其他")
                                    {
                                        curThirdInfo.Add(pSys);
                                    }
                                    else if (pSys.name == "数量" || pSys.name == "折扣优惠" || pSys.name == "应收" || pSys.name == "姓名" || pSys.name == "找零" || pSys.name == "结尾附加文字" || pSys.name == "商城二维码" || pSys.name == "店铺")
                                    {
                                        curFourthInfo.Add(pSys);
                                    } 

                                    break;
                                }
                                else
                                {
                                    pSys.ischeck = false;
                                } 
                            }
                        }
                        loadList.AddRange(curFirstInfo);
                        loadList.AddRange(curSecondInfo);
                        loadList.AddRange(curThirdInfo);
                        loadList.AddRange(curFourthInfo);

                        setLblValue(curFirstInfo, curSecondInfo, curThirdInfo, curFourthInfo, PTempInfo.AdditionalText);
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
                 
                    if (PTempInfo.PrintCount > 0)
                    {
                        this.numericTxtCount.Text = PTempInfo.PrintCount.ToString();
                    }
                     
                    break;
                default:
                    break;
            }



        } 
        private void selectPrintInfoOfBillTemplate()
        {

            switch (resultOfBillTemplate.ExeResult)
            {
                case ExeResult.Error:
                    GlobalMessageBox.Show(resultOfBillTemplate.Msg);
                    break;
                case ExeResult.Success:
                    PrintTemplateInfo PTempInfo = resultOfBillTemplate.Data;
                    this.numericTextBox1.Text=PTempInfo.PrintCount.ToString();
                    this.txtDataName.Text = PTempInfo.OrderName;
                    this.numericTextBox2.Text = PTempInfo.Rows.ToString();
                    if (PTempInfo.PrintColumnInfos.Count > 0)
                    {
                        List<PrintColumnsInfo> source = (List<PrintColumnsInfo>)this.dataGridViewColumnsOfBillTemplate.DataSource;
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
                        curColumnInfoOfBillTemplate = PTempInfo.PrintColumnInfos;
                        curColumnsSelectOfBillTemplate = columnsSelect;
                        setColumnsHeaderInfoOfBillTemplate(columnsSelect, PTempInfo.PrintColumnInfos);
                        this.dataGridViewColumnsOfBillTemplate.DataSource = source;

                    }
                    else
                    {
                        List<PrintColumnsInfo> source = (List<PrintColumnsInfo>)this.dataGridViewColumnsOfBillTemplate.DataSource;
                        foreach (PrintColumnsInfo cItem in source)
                        {
                            cItem.ischeck = false;
                        }
                        List<PrintColumnInfo> sourceList = null;

                        this.dataGridView4.DataSource = sourceList;

                    }
                    if (PTempInfo.SystemVariables.Count > 0)
                    {
                        List<PrintSysInfo> list = (List<PrintSysInfo>)this.dataGridViewSysOfTemplate.DataSource;
                        List<PrintSysInfo> columnsSys = new List<PrintSysInfo>();

                        List<PrintSysInfo> curFirstInfo = new List<PrintSysInfo>();
                        List<PrintSysInfo> curSecondInfo = new List<PrintSysInfo>(); 
                        foreach (PrintSysInfo pSys in list)
                        {
                            foreach (string sysInfo in PTempInfo.SystemVariables)
                            {

                                if (pSys.name == sysInfo)
                                {
                                    pSys.ischeck = true;
                                    if (pSys.name == "销售单号" || pSys.name == "单据日期" || pSys.name == "客户名称" || pSys.name == "客户电话" || pSys.name == "客户地址"
                                        || pSys.name == "操作人" || pSys.name == "单据备注"
                                        )
                                    {
                                        curFirstInfo.Add(pSys);
                                    }
                                    else if (pSys.name == "店铺地址" || pSys.name == "联系电话")
                                    {
                                        curSecondInfo.Add(pSys);
                                    }
                                    //销售单号、单据日期、客户名称、客户电话、客户地址、操作人、单据备注、店铺地址、联系电话

                                    break;
                                }
                                else
                                {
                                    pSys.ischeck = false;
                                }
                            }
                        }
                        loadListOfBillTemplate.AddRange(curFirstInfo);
                        loadListOfBillTemplate.AddRange(curSecondInfo);

                        setLblValueOfBillTemplate(curFirstInfo, curSecondInfo);
                        this.dataGridViewSysOfTemplate.DataSource = list;
                    }
                    else
                    {
                        List<PrintSysInfo> list = (List<PrintSysInfo>)this.dataGridViewSysOfTemplate.DataSource;
                        foreach (PrintSysInfo item in list)
                        {
                            item.ischeck = false;
                        }
                    }  
                    break;
                default:
                    break;
            }



        }
         
        private void setColumnsInfo()
        {
            List<PrintColumnsInfo> list = GlobalUtilOfPrint.getSaleReturnColumnsInfo();
            foreach (PrintColumnsInfo pInfo in list)
            {
                pInfo.ischeck = true;
            }
            dataGridViewColumns.DataSource = list;
        }
        private void setColumnsInfoOfBillTemplate()
        {
            List<PrintColumnsInfo> list = GlobalUtilOfPrint.getSaleReturnColumnsInfoOfBillTemplate();
            foreach (PrintColumnsInfo pInfo in list)
            {
                pInfo.ischeck = true;
            }
            dataGridViewColumnsOfBillTemplate.DataSource = list;
        }


        private void setSysVariable()
        {
            
            List<PrintSysInfo> list = GlobalUtilOfPrint.getSaleReturnSysInfo();
            foreach (PrintSysInfo pInfo in list)
            {
                pInfo.ischeck = true;
            }
            dataGridViewSys.DataSource = list;
        }

        private void setSysVariableOfBillTemplate()
        {
            List<PrintSysInfo> list = GlobalUtilOfPrint.getSaleReturnSysInfoOfBillTemplate();
            foreach (PrintSysInfo pInfo in list)
            {
                pInfo.ischeck = true;
            }
            dataGridViewSysOfTemplate.DataSource = list;
        }
       


        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;


        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl3;


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
            lblName11.Text = "";
            lblName12.Text = "";
            lblName13.Text = "";
            lblName14.Text = "";
            lblName15.Text = "";
            lblName16.Text = "";
            lblName17.Text = "";
            lblName18.Text = "";
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            this.rtfRichTextBox_Remarks.Enabled = false;



        }

        private void InitializeOfBillTemplate()
        {

            dataGridViewSys.AutoGenerateColumns = false;
            dataGridViewColumns.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridViewSysOfTemplate);
            dataGridViewPagingSumCtrl2.ShowRowCounts = false;
            dataGridViewPagingSumCtrl2.Initialize();

            dataGridViewPagingSumCtrl3 = new DataGridViewPagingSumCtrl(this.dataGridViewColumnsOfBillTemplate);
            dataGridViewPagingSumCtrl3.ShowRowCounts = false;
            dataGridViewPagingSumCtrl3.Initialize();
            lblSale1.Text = "";
            lblSale2.Text = "";
            lblSale3.Text = "";
            lblSale4.Text = "";
            lblSale5.Text = "";
            lblSale6.Text = "";
            lblSale7.Text = "";
            lblSale8.Text = "";
            lblSale9.Text = "";
            //lblName9.Text = "";
            //lblName10.Text = "";
            //lblName11.Text = "";
            //lblName12.Text = "";
            //lblName13.Text = "";
            //lblName14.Text = "";
            //lblName15.Text = "";
            //lblName16.Text = "";
            //lblName17.Text = "";
            //lblName18.Text = "";
            //lbl1.Text = "";
            //lbl2.Text = "";
            //lbl3.Text = "";
            //lbl4.Text = "";
            //lbl5.Text = "";
            //this.rtfRichTextBox_Remarks.Enabled = false;



        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        List<PrintSysInfo> loadList = new List<PrintSysInfo>();
        List<PrintSysInfo> loadListOfBillTemplate = new List<PrintSysInfo>();
        private void baseButtonSave_Click(object sender, EventArgs e)
        {
            //小票形式
            if (this.skinRadioButton1.Checked)
            {
                int gWidth = this.dataGridView3.Width;

                WriteLog("dataGridView3.Width=" + gWidth);
                List<PrintColumnInfo> listOfColumns = new List<PrintColumnInfo>();
                List<string> listSys = new List<string>();

                if (!flag)
                {
                    lastPrintSysInfo = loadList;
                }
                foreach (PrintSysInfo pSysInfo in lastPrintSysInfo)
                { 
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
                            sCol.Rate = Math.Round(Convert.ToDecimal(this.dataGridView3.Columns[i].Width) / Convert.ToDecimal(this.dataGridView3.Width) * 100, 2);

                            listOfColumns.Add(sCol);
                        }
                    }

                }


                try
                {
                    InteractResult result = GlobalCache.ServerProxy.SavePrintTemplateInfo(new PrintTemplateInfo()
                    {
                        Type = PrintTemplateType.Retail,
                        OrderName = "",
                        PrintCount = Convert.ToInt32(numericTxtCount.Text),
                        PrintColumnInfos = listOfColumns,
                        SystemVariables = listSys,
                        AdditionalText = rtfRichTextBox_Remarks.Text,
                        IsPrintQRCode = isAddQRCode,

                    });
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        case ExeResult.Success:
                            GlobalCache.ServerProxy.SetRetailPrintType(RetailPrintType.SmallTickets);
                            GlobalMessageBox.Show("保存成功！");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    CommonGlobalUtil.ShowError(ex);
                }
            }
            else   //单据形式
            {

                int gWidth = this.dataGridView4.Width;

                WriteLog("dataGridView4.Width=" + gWidth);
                List<PrintColumnInfo> listOfColumns = new List<PrintColumnInfo>();
                List<string> listSys = new List<string>();

                if (!flag)
                {
                    
                    lastPrintSysInfoOfBillTemplate = loadListOfBillTemplate;
                }
                foreach (PrintSysInfo pSysInfo in lastPrintSysInfoOfBillTemplate)
                {

                    listSys.Add(pSysInfo.name);

                }
                foreach (PrintColumnsInfo cColumnInfo in lastPrintColumnsInfoOfBillTemplate )
                {

                    for (int i = 0; i < this.dataGridView4.Columns.Count; i++)

                    {
                        if (this.dataGridView4.Columns[i].HeaderText == cColumnInfo.name)
                        {



                            PrintColumnInfo sCol = new PrintColumnInfo();
                            sCol.Name = cColumnInfo.name;
                            sCol.Rate = Math.Round(Convert.ToDecimal(this.dataGridView4.Columns[i].Width) / Convert.ToDecimal(this.dataGridView4.Width) * 100, 2);

                            listOfColumns.Add(sCol);
                        }
                    }

                }


                try
                {
                    InteractResult result = GlobalCache.ServerProxy.SavePrintTemplateInfo(new PrintTemplateInfo()
                    {
                        Type = PrintTemplateType.RetailOrder,
                        OrderName = txtDataName.SkinTxt.Text,
                        PrintCount = Convert.ToInt32(numericTextBox1.Text),
                        PrintColumnInfos = listOfColumns,
                        SystemVariables = listSys, 
                          Rows = Convert.ToByte(numericTextBox2.Text),

                    });
                    switch (result.ExeResult)
                    {
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        case ExeResult.Success:

                            GlobalCache.ServerProxy.SetRetailPrintType(RetailPrintType.Order);
                            GlobalMessageBox.Show("保存成功！");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    CommonGlobalUtil.ShowError(ex);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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

       

        private void dataGridViewColumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        List<PrintSysInfo> curSysInfo;
        List<PrintSysInfo> curSysInfoOfBillTemplate;
        bool flag = false;
        private void dataGridViewSys_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                curSysInfo = new List<PrintSysInfo>();

                if (!dataGridViewSys.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    List<PrintSysInfo> source = (List<PrintSysInfo>)view.DataSource;
                    PrintSysInfo item = (PrintSysInfo)source[e.RowIndex];

                    List<PrintSysInfo> curFirstInfo = new List<PrintSysInfo>();
                    List<PrintSysInfo> curSecondInfo = new List<PrintSysInfo>();
                    List<PrintSysInfo> curThirdInfo = new List<PrintSysInfo>();
                    List<PrintSysInfo> curFourthInfo = new List<PrintSysInfo>();
                    if (e.ColumnIndex == Column5.Index)
                    {
                        flag = true;
                        foreach (PrintSysInfo pInfo in source)
                        {
                           
                            if (pInfo.ischeck)
                            {
                                if (pInfo.name == "单号" || pInfo.name == "日期" || pInfo.name == "电话" || pInfo.name == "地址" || pInfo.name == "顾问")
                                {
                                    curFirstInfo.Add(pInfo);
                                }
                                else if (pInfo.name == "卡号" || pInfo.name == "本次积分" || pInfo.name == "当前积分" || pInfo.name == "累计积分" || pInfo.name == "余额")
                                {
                                    curSecondInfo.Add(pInfo);
                                }
                                else if (pInfo.name == "银联卡" || pInfo.name == "现金" || pInfo.name == "VIP卡" || pInfo.name == "支付宝" || pInfo.name == "微信" || pInfo.name == "积分兑现" || pInfo.name == "优惠券" || pInfo.name == "其他")
                                {
                                    curThirdInfo.Add(pInfo);
                                }
                                else if (pInfo.name == "数量" || pInfo.name == "折扣优惠" || pInfo.name == "应收" || pInfo.name == "姓名" || pInfo.name == "找零" || pInfo.name == "结尾附加文字" || pInfo.name == "商城二维码" || pInfo.name == "店铺")
                                {
                                    curFourthInfo.Add(pInfo);
                                }
                            }
                          
                        }
                        setLblValue(curFirstInfo, curSecondInfo, curThirdInfo, curFourthInfo);
                        foreach (PrintSysInfo oneItem in curFirstInfo)
                        {
                            curSysInfo.Add(oneItem);
                        }
                        foreach (PrintSysInfo twoItem in curSecondInfo)
                        {
                            curSysInfo.Add(twoItem);
                        }
                        foreach (PrintSysInfo threeItem in curThirdInfo)
                        {
                            curSysInfo.Add(threeItem);
                        }
                        foreach (PrintSysInfo fourItem in curFourthInfo)
                        {
                            curSysInfo.Add(fourItem);
                        }

                        lastPrintSysInfo = curSysInfo;
                    }
                }
            }
        }
        private void setLblValue(List<PrintSysInfo> oneList, List<PrintSysInfo> twoList, List<PrintSysInfo> threeList, List<PrintSysInfo> fourList,string AddText="")
        {

            #region
            switch (oneList.Count)
            {
                case 0:
                    this.lblName1.Text = "";
                    this.lblName2.Text = "";
                    this.lblName3.Text = "";
                    this.lblName4.Text = "";
                    this.lblName5.Text = "";
                    break;
                case 1:
                    this.lblName1.Text = oneList[0].name;
                    this.lblName2.Text = "";
                    this.lblName3.Text = "";
                    this.lblName4.Text = "";
                    this.lblName5.Text = "";
                    break;
                case 2:
                    this.lblName1.Text = oneList[0].name;
                    this.lblName2.Text = oneList[1].name;
                    this.lblName3.Text = "";
                    this.lblName4.Text = "";
                    this.lblName5.Text = ""; 
                    break;
                case 3:
                    this.lblName1.Text = oneList[0].name;
                    this.lblName2.Text = oneList[1].name;
                    this.lblName3.Text = oneList[2].name;
                    this.lblName4.Text = "";
                    this.lblName5.Text = ""; 
                    break;

                case 4:
                    this.lblName1.Text = oneList[0].name;
                    this.lblName2.Text = oneList[1].name;
                    this.lblName3.Text = oneList[2].name;
                    this.lblName4.Text = oneList[3].name;
                    this.lblName5.Text = ""; 
                    break;

                case 5:
                    this.lblName1.Text = oneList[0].name;
                    this.lblName2.Text = oneList[1].name;
                    this.lblName3.Text = oneList[2].name;
                    this.lblName4.Text = oneList[3].name;
                    this.lblName5.Text = oneList[4].name; 
                    break;  
                default:
                    break;
            }
            #endregion


            #region
            switch (twoList.Count)
            {
                case 0:
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;
                case 1:
                    this.lblName6.Text = twoList[0].name;
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;
                case 2:
                    this.lblName6.Text = twoList[0].name;
                    this.lblName7.Text = twoList[1].name;
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;
                case 3:
                    this.lblName6.Text = twoList[0].name;
                    this.lblName7.Text = twoList[1].name;
                    this.lblName8.Text = twoList[2].name;
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    break;

                case 4:
                    this.lblName6.Text = twoList[0].name;
                    this.lblName7.Text = twoList[1].name;
                    this.lblName8.Text = twoList[2].name;
                    this.lblName9.Text = twoList[3].name;
                    this.lblName10.Text = "";
                    break;

                case 5:
                    this.lblName6.Text = twoList[0].name;
                    this.lblName7.Text = twoList[1].name;
                    this.lblName8.Text = twoList[2].name;
                    this.lblName9.Text = twoList[3].name;
                    this.lblName10.Text = twoList[4].name;
                    break;
                default:
                    break;
            }
            #endregion


            #region
            switch (threeList.Count)
            {
                case 0:
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    this.lblName18.Text = "";
                    break;
                case 1:
                    this.lblName11.Text = threeList[0].name;
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    this.lblName18.Text = "";
                    break;
                case 2:
                    this.lblName11.Text = threeList[0].name;
                    this.lblName12.Text = threeList[1].name;
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    this.lblName18.Text = "";
                    break;
                case 3:
                    this.lblName11.Text = threeList[0].name;
                    this.lblName12.Text = threeList[1].name;
                    this.lblName13.Text = threeList[2].name;
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    this.lblName18.Text = "";
                    break;

                case 4:
                    this.lblName11.Text = threeList[0].name;
                    this.lblName12.Text = threeList[1].name;
                    this.lblName13.Text = threeList[2].name;
                    this.lblName14.Text = threeList[3].name;
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    this.lblName18.Text = "";
                    break;

                case 5:
                    this.lblName11.Text = threeList[0].name;
                    this.lblName12.Text = threeList[1].name;
                    this.lblName13.Text = threeList[2].name;
                    this.lblName14.Text = threeList[3].name;
                    this.lblName15.Text = threeList[4].name;
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    this.lblName18.Text = "";
                    break;

                case 6:
                    this.lblName11.Text = threeList[0].name;
                    this.lblName12.Text = threeList[1].name;
                    this.lblName13.Text = threeList[2].name;
                    this.lblName14.Text = threeList[3].name;
                    this.lblName15.Text = threeList[4].name;
                    this.lblName16.Text = threeList[5].name;
                    this.lblName17.Text = "";
                    this.lblName18.Text = "";
                    break;

                case 7:
                    this.lblName11.Text = threeList[0].name;
                    this.lblName12.Text = threeList[1].name;
                    this.lblName13.Text = threeList[2].name;
                    this.lblName14.Text = threeList[3].name;
                    this.lblName15.Text = threeList[4].name;
                    this.lblName16.Text = threeList[5].name;
                    this.lblName17.Text = threeList[6].name;
                    this.lblName18.Text ="";
                    break;

                case 8:
                    this.lblName11.Text = threeList[0].name;
                    this.lblName12.Text = threeList[1].name;
                    this.lblName13.Text = threeList[2].name;
                    this.lblName14.Text = threeList[3].name;
                    this.lblName15.Text = threeList[4].name;
                    this.lblName16.Text = threeList[5].name;
                    this.lblName17.Text = threeList[6].name;
                    this.lblName18.Text = threeList[7].name;
                    break;
                default:
                    break;
            }
            #endregion


            #region
            if (fourList.Count > 0)
            {
                PrintSysInfo sumL = fourList.Find(t => t.name == "数量");
                if (sumL != null)
                {
                    lbl1.Text = sumL.name;
                }
                else
                {
                    lbl1.Text = "";
                }

                PrintSysInfo DisL = fourList.Find(t => t.name == "折扣优惠");
                if (DisL != null)
                {
                    lbl2.Text = DisL.name;
                }
                else
                {
                    lbl2.Text = "";
                }

                PrintSysInfo GetL = fourList.Find(t => t.name == "应收");
                if (GetL != null)
                {
                    lbl3.Text = GetL.name;
                }
                else
                {
                    lbl3.Text = "";
                }
                PrintSysInfo GetNameL = fourList.Find(t => t.name == "姓名");
                if (GetNameL != null)
                {
                    lbl4.Text = GetNameL.name;
                }
                else
                {
                    lbl4.Text = "";
                }

                PrintSysInfo GetZeroL = fourList.Find(t => t.name == "找零");
                if (GetZeroL != null)
                {
                    lbl5.Text = GetZeroL.name;
                }
                else
                {
                    lbl5.Text = "";
                }
                PrintSysInfo ShopCodeL = fourList.Find(t => t.name == "商城二维码");
                if (ShopCodeL != null)
                {
                    isAddQRCode = true;
                }
                else
                {
                    isAddQRCode = false;
                }

                PrintSysInfo addRemarkL = fourList.Find(t => t.name == "结尾附加文字");
                if (addRemarkL != null)
                {
                    rtfRichTextBox_Remarks.Enabled = true;
                    if (AddText != "") { rtfRichTextBox_Remarks.Text = AddText; }
                   
                }
                else
                { 
                    rtfRichTextBox_Remarks.Text = "";
                    rtfRichTextBox_Remarks.Enabled = false;
                }
                PrintSysInfo ShopTitleL = fourList.Find(t => t.name == "店铺");
                if (ShopTitleL != null)
                { 
                    lblCurDataName.Text = "店铺名称";
                }
                else
                {
                    lblCurDataName.Text = "";
                } 
            }

            #endregion


        }
        private void setLblValueOfBillTemplate(List<PrintSysInfo> oneList, List<PrintSysInfo> twoList)
        {

            #region
            switch (oneList.Count)
            {
                case 0:
                    this.lblSale1.Text = "";
                    this.lblSale2.Text = "";
                    this.lblSale3.Text = "";
                    this.lblSale4.Text = "";
                    this.lblSale5.Text = "";
                    this.lblSale6.Text = "";
                    this.lblSale7.Text = "";


                    break;
                case 1:
                    this.lblSale1.Text = oneList[0].name;
                    this.lblSale2.Text = "";
                    this.lblSale3.Text = "";
                    this.lblSale4.Text = "";
                    this.lblSale5.Text = "";
                    break;
                case 2:
                    this.lblSale1.Text = oneList[0].name;
                    this.lblSale2.Text = oneList[1].name;
                    this.lblSale3.Text ="";
                    this.lblSale4.Text = "";
                    this.lblSale5.Text = "";
                    this.lblSale6.Text = "";
                    this.lblSale7.Text = "";
                    break;
                case 3:
                    this.lblSale1.Text = oneList[0].name;
                    this.lblSale2.Text = oneList[1].name;
                    this.lblSale3.Text = oneList[2].name;
                    this.lblSale4.Text = "";
                    this.lblSale5.Text = "";
                    this.lblSale6.Text = "";
                    this.lblSale7.Text = "";
                    break;

                case 4:
                    this.lblSale1.Text = oneList[0].name;
                    this.lblSale2.Text = oneList[1].name;
                    this.lblSale3.Text = oneList[2].name;
                    this.lblSale4.Text = oneList[3].name;
                    this.lblSale5.Text = ""; 
                    this.lblSale6.Text = "";
                    this.lblSale7.Text = "";
                    break;

                case 5:
                    this.lblSale1.Text = oneList[0].name;
                    this.lblSale2.Text = oneList[1].name;
                    this.lblSale3.Text = oneList[2].name;
                    this.lblSale4.Text = oneList[3].name;
                    this.lblSale5.Text = oneList[4].name;
                    this.lblSale6.Text = "";
                    this.lblSale7.Text = "";
                    break;
                case 6:
                    this.lblSale1.Text = oneList[0].name;
                    this.lblSale2.Text = oneList[1].name;
                    this.lblSale3.Text = oneList[2].name;
                    this.lblSale4.Text = oneList[3].name;
                    this.lblSale5.Text = oneList[4].name;
                    this.lblSale6.Text = oneList[5].name;
                    this.lblSale7.Text = "";
                    break;
                case 7:
                    this.lblSale1.Text = oneList[0].name;
                    this.lblSale2.Text = oneList[1].name;
                    this.lblSale3.Text = oneList[2].name;
                    this.lblSale4.Text = oneList[3].name;
                    this.lblSale5.Text = oneList[4].name;
                    this.lblSale6.Text = oneList[5].name;
                    this.lblSale7.Text = oneList[6].name;
                    break;
                default:
                    break;
            }
            #endregion


            #region
            switch (twoList.Count)
            {
                case 0: 
                    this.lblSale8.Text = "";
                    this.lblSale9.Text = ""; 
                    break;
                case 1:
                    this.lblSale8.Text = twoList[0].name;
                    this.lblSale9.Text = ""; 
                    break;
                case 2:
                    this.lblSale8.Text = twoList[0].name;
                    this.lblSale9.Text = twoList[1].name; 
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

                    lastPrintColumnsInfo = curColumnsInfo; 
                    setColumnsHeaderInfo(curColumnsInfo ,new List<PrintColumnInfo>());
                }
            }
        }
        private void setColumnsHeaderInfo(List<PrintColumnsInfo> columnsInfo, List<PrintColumnInfo> printCol=null)
        {
            switch (columnsInfo.Count)
            {

                case 0:
                    this.dataGridView3.Columns.Clear();
                    break;
                case 1:
                    #region
                    GlobalUtilOfPrint.CreateColumns1(columnsInfo, this.dataGridView3 ,printCol);
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
                     

                default:
                    break;
            }
            foreach (DataGridViewColumn columnItem in this.dataGridView3.Columns)
            {
                columnItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                columnItem.FillWeight = 100;
                //columnItem.Width= columnsInfo[0].
                
               // PrintColumnInfo
            }
        }
        private void setColumnsHeaderInfoOfBillTemplate(List<PrintColumnsInfo> columnsInfo, List<PrintColumnInfo> printCol = null)
        {
            switch (columnsInfo.Count)
            {

                case 0:
                    this.dataGridView4.Columns.Clear();
                    break;
                case 1:
                    #region
                    GlobalUtilOfPrint.CreateColumns1(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;
                case 2:
                    GlobalUtilOfPrint.CreateColumns2(columnsInfo, this.dataGridView4, printCol);
                    break;
                case 3:
                    GlobalUtilOfPrint.CreateColumns3(columnsInfo, this.dataGridView4, printCol);
                    break;
                case 4:
                    GlobalUtilOfPrint.CreateColumns4(columnsInfo, this.dataGridView4, printCol);
                    break;

                case 5:
                    GlobalUtilOfPrint.CreateColumns5(columnsInfo, this.dataGridView4, printCol);
                    break;

                case 6:
                    GlobalUtilOfPrint.CreateColumns6(columnsInfo, this.dataGridView4, printCol);
                    break;

                case 7:
                    GlobalUtilOfPrint.CreateColumns7(columnsInfo, this.dataGridView4, printCol);
                    break;
                case 8:
                    GlobalUtilOfPrint.CreateColumns8(columnsInfo, this.dataGridView4, printCol);
                    break;
                case 9:
                    GlobalUtilOfPrint.CreateColumns9(columnsInfo, this.dataGridView4, printCol);
                    break;
                case 10:

                    #region

                    GlobalUtilOfPrint.CreateColumns10(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;
                case 11:
                    #region

                    GlobalUtilOfPrint.CreateColumns11(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;
                case 12:
                    #region
                    GlobalUtilOfPrint.CreateColumns12(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;
                case 13:
                    #region
                    GlobalUtilOfPrint.CreateColumns13(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;

                case 14:
                    #region
                    GlobalUtilOfPrint.CreateColumns14(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;

                case 15:
                    #region
                    GlobalUtilOfPrint.CreateColumns15(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;

                case 16:
                    #region
                    GlobalUtilOfPrint.CreateColumns16(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;

                case 17:
                    #region
                    GlobalUtilOfPrint.CreateColumns17(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;

                case 18:
                    #region
                    GlobalUtilOfPrint.CreateColumns18(columnsInfo, this.dataGridView4, printCol);
                    #endregion
                    break;


                default:
                    break;
            }
            foreach (DataGridViewColumn columnItem in this.dataGridView4.Columns)
            {
                columnItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                columnItem.FillWeight = 100;
                //columnItem.Width= columnsInfo[0].

                // PrintColumnInfo
            }
        }

        private void PrintOfSaleReturn_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PrintOfSaleReturn_SizeChanged(object sender, EventArgs e)
        { 
            if (curColumnsSelect != null && curColumnInfo != null)
            {
                setColumnsHeaderInfo(curColumnsSelect, curColumnInfo);
            }
            if (curColumnsSelectOfBillTemplate != null && curColumnInfoOfBillTemplate != null)
            {
                setColumnsHeaderInfoOfBillTemplate(curColumnsSelectOfBillTemplate, curColumnInfoOfBillTemplate);
               // setColumnsHeaderInfo(curColumnsSelect, curColumnInfo);
            }
        }
        /// <summary>
        /// 根据形式显示面板
        /// </summary>
        /// <param name="type"></param>
        private void SetDisplayPanle( int type)
        {
            if (type == 0)
            {
                panelTicket.Visible = true;
                panelSaletype.Visible = false;
                this.panel10.Visible = true;
                this.panel16.Visible = false;

            }
            else
            {
                panelTicket.Visible = false;
                panelSaletype.Visible = true;
                this.panel10.Visible = false;
                this.panel16.Visible = true;
            }
        }

        private void skinRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int typeValue = 0;
            if( skinRadioButton2.Checked)
            {
                typeValue = 1;
            }
            SetDisplayPanle(typeValue);
        }

        private void skinRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int typeValue = 1;
            if (skinRadioButton1.Checked)
            {
                typeValue = 0;
            }
            SetDisplayPanle(typeValue);
        }

        private void dataGridViewSysOfTemplate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                curSysInfoOfBillTemplate = new List<PrintSysInfo>();

                if (!dataGridViewSysOfTemplate.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    List<PrintSysInfo> source = (List<PrintSysInfo>)view.DataSource;
                    PrintSysInfo item = (PrintSysInfo)source[e.RowIndex];

                    List<PrintSysInfo> curFirstInfo = new List<PrintSysInfo>();
                    List<PrintSysInfo> curSecondInfo = new List<PrintSysInfo>();
                    //List<PrintSysInfo> curThirdInfo = new List<PrintSysInfo>();
                    //List<PrintSysInfo> curFourthInfo = new List<PrintSysInfo>();
                    if (e.ColumnIndex == Column5.Index)
                    {
                        flag = true;
                        foreach (PrintSysInfo pInfo in source)
                        {
                            //销售单号、单据日期、客户名称、客户电话、客户地址、操作人、单据备注、店铺地址、联系电话
                            if (pInfo.ischeck)
                            {
                                if (pInfo.name == "销售单号" || pInfo.name == "单据日期" || pInfo.name == "客户名称" || pInfo.name == "客户电话" || pInfo.name == "客户地址"
                                    || pInfo.name == "操作人" || pInfo.name == "单据备注"  
                                    )
                                {
                                    curFirstInfo.Add(pInfo);
                                }
                                else if (pInfo.name == "店铺地址" || pInfo.name == "联系电话")
                                {
                                    curSecondInfo.Add(pInfo);
                                }
                                
                            }

                        }
                        setLblValueOfBillTemplate(curFirstInfo, curSecondInfo);
                        foreach (PrintSysInfo oneItem in curFirstInfo)
                        {
                            curSysInfoOfBillTemplate.Add(oneItem);
                        }
                        foreach (PrintSysInfo twoItem in curSecondInfo)
                        {
                            curSysInfoOfBillTemplate.Add(twoItem);
                        }


                        lastPrintSysInfoOfBillTemplate = curSysInfoOfBillTemplate;
                    }
                }
            }
        }

        private void dataGridViewColumnsOfBillTemplate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            List<PrintColumnsInfo> curColumnsInfo = new List<PrintColumnsInfo>();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridViewColumnsOfBillTemplate.Rows[e.RowIndex].IsNewRow)
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
                            item.ischeck = (bool)this.dataGridViewColumnsOfBillTemplate[e.ColumnIndex, e.RowIndex].Value;
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

                    lastPrintColumnsInfoOfBillTemplate = curColumnsInfo;
                    setColumnsHeaderInfoOfBillTemplate(curColumnsInfo, new List<PrintColumnInfo>());
                }
            }
        }
    }
}
