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
    public partial class PrintOfBalanceOnThatDay : BaseModifyUserControl
    {

        public PrintOfBalanceOnThatDay()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.打印设置;
        }
        
        private List<PrintSysInfo> lastPrintSysInfo = new List<PrintSysInfo>();
        private List<PrintColumnsInfo> lastPrintColumnsInfo = new List<PrintColumnsInfo>();
        private List<PrintSysInfo> firstList = new List<PrintSysInfo>();
        private List<PrintSysInfo> secondList = new List<PrintSysInfo>();
        private List<PrintSysInfo> thirdList = new List<PrintSysInfo>();
        private List<PrintSysInfo> fourthList = new List<PrintSysInfo>();
        private List<PrintSysInfo> fiveList = new List<PrintSysInfo>();
        private List<PrintSysInfo> sixList = new List<PrintSysInfo>();
        private void PrintSettingCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
           // this.panel7.Scroll += panel7_Scroll;
            this.txtDataName.SkinTxt.TextChanged += SkinTxt_TextChanged;
            //DataGridViewUtil.ListToBindingList(list)
             
            setSysVariable(); 
           // lastPrintSysInfo = (List<PrintSysInfo>)dataGridViewSys.DataSource;
            getAllList(lastPrintSysInfo,out firstList, out secondList, out thirdList, out fourthList, out fiveList, out sixList);
          //  setLblValue(firstList, secondList,  thirdList,  fourthList,  fiveList,  sixList); 
          
             selectPrintInfo();
            this.lblCurDataName.Text = this.txtDataName.SkinTxt.Text.Trim();
            //  dataGridViewSys.DataSource= GlobalUtilOfPrint.getPurchaseStockSysInfo();
              dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(nameDataGridViewTextBoxColumn1, type); 
        }

        private void getAllList(List<PrintSysInfo> list, out List<PrintSysInfo> firstL, out List<PrintSysInfo> secondL, out List<PrintSysInfo> thirdthL, out List<PrintSysInfo> fourthL, out List<PrintSysInfo> fithL, out List<PrintSysInfo> sixThL)
        {
           firstL = new List<PrintSysInfo>();
            secondL = new List<PrintSysInfo>();
            thirdthL = new List<PrintSysInfo>();
            fourthL = new List<PrintSysInfo>();
            fithL = new List<PrintSysInfo>();
            sixThL = new List<PrintSysInfo>();
            foreach (PrintSysInfo Pinfo in list)
            {
                if (Pinfo.name == "日结时间" || Pinfo.name == "日结日期" || Pinfo.name == "店铺名称")
                {
                    firstL.Add(Pinfo);
                }
                else if (Pinfo.name == "期初库存" || Pinfo.name == "采购进货" || Pinfo.name == "采购退货" || Pinfo.name == "调拨入库" || Pinfo.name == "调拨" || Pinfo.name == "报损出库"
                    || Pinfo.name == "盘盈数" || Pinfo.name == "盘亏数" || Pinfo.name == "批发发货" || Pinfo.name == "批发退货" || Pinfo.name == "当日销售" || Pinfo.name == "顾客退货"
                    || Pinfo.name == "差异调整" || Pinfo.name == "期末库存"
                    )
                {
                    secondL.Add(Pinfo);
                }
                else if ((Pinfo.name == "现金" && Pinfo.type==0)||( Pinfo.name == "银联卡" && Pinfo.type == 0) ||( Pinfo.name == "微信" && Pinfo.type == 0) || (Pinfo.name == "支付宝" && Pinfo.type == 0) || ( Pinfo.name == "VIP卡余额" && Pinfo.type == 0)
                    || (Pinfo.name == "VIP卡积分返现" && Pinfo.type == 0) ||( Pinfo.name == "优惠券金额" && Pinfo.type == 0))
                {
                    thirdthL.Add(Pinfo);
                }

                else if ((Pinfo.name == "现金" && Pinfo.type == 1) || (Pinfo.name == "银联卡" && Pinfo.type == 1) || (Pinfo.name == "微信" && Pinfo.type == 1) || (Pinfo.name == "支付宝" && Pinfo.type == 1) ||( Pinfo.name == "其他" && Pinfo.type == 1))
                {
                    fourthL.Add(Pinfo);
                }

                else if (Pinfo.name == "零售单数" || Pinfo.name == "营收金额" || Pinfo.name == "当日现金结余")
                {
                    fithL.Add(Pinfo);
                }
                else if (Pinfo.name == "营业员签名" || Pinfo.name == "财务签名")
                {
                    sixThL.Add(Pinfo);
                }
            }
        }
        private void selectPrintInfo()
        {
            InteractResult<PrintTemplateInfo>  result = GlobalCache.ServerProxy.GetPrintTemplateInfo(PrintTemplateType.DayReport);
             
            switch (result.ExeResult)
            {
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                case ExeResult.Success:
                    PrintTemplateInfo PTempInfo = result.Data;
                   /* if (PTempInfo.PrintColumnInfos.Count > 0)
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
                        setColumnsHeaderInfo(columnsSelect);
                        this.dataGridViewColumns.DataSource = source; 

                    }*/
                    if (PTempInfo.SystemVariables.Count > 0)
                    {
                        List<PrintSysInfo> list = (List<PrintSysInfo>)this.dataGridViewSys.DataSource;
                      //  lastPrintSysInfo.Clear();
                        List<PrintSysInfo> columnsSysfirst = new List<PrintSysInfo>();
                        List<PrintSysInfo> columnsSysSecnod = new List<PrintSysInfo>();
                        List<PrintSysInfo> columnsSysthirdth = new List<PrintSysInfo>();
                        List<PrintSysInfo> columnsSysfourth = new List<PrintSysInfo>();
                        List<PrintSysInfo> columnsSysfiveth = new List<PrintSysInfo>();
                        List<PrintSysInfo> columnsSyssixth = new List<PrintSysInfo>(); 
                        foreach (PrintSysInfo pSys in list)
                        {
                            foreach (string sysInfo in PTempInfo.SystemVariables)
                            {
                                string[] sArray = sysInfo.Split('#'); 

                                if (pSys.name == sArray[0] && pSys.type.ToString()==sArray[1])
                                {
                                    pSys.ischeck = true;
                                    if (pSys.name == "日结时间" || pSys.name == "日结日期" || pSys.name == "店铺名称")
                                    {
                                        columnsSysfirst.Add(pSys);
                                    }
                                    else if (pSys.name == "期初库存" || pSys.name == "采购进货" || pSys.name == "采购退货" || pSys.name == "调拨入库" || pSys.name == "调拨" || pSys.name == "报损出库"
                                        || pSys.name == "盘盈数" || pSys.name == "盘亏数" || pSys.name == "批发发货" || pSys.name == "批发退货" || pSys.name == "当日销售" || pSys.name == "顾客退货"
                                        || pSys.name == "差异调整" || pSys.name == "期末库存"
                                        )
                                    {
                                        columnsSysSecnod.Add(pSys);
                                    }
                                    else if ((pSys.name == "现金" && pSys.type == 0 && Convert.ToInt32(sArray[1])== pSys.type) || (pSys.name == "银联卡" && pSys.type == 0 && Convert.ToInt32(sArray[1]) == pSys.type) 
                                        || (pSys.name == "微信" && pSys.type == 0 && Convert.ToInt32(sArray[1]) == pSys.type) || (pSys.name == "支付宝" && pSys.type == 0 && Convert.ToInt32(sArray[1]) == pSys.type)  
                                        || (pSys.name == "VIP卡余额" && pSys.type == 0 && Convert.ToInt32(sArray[1]) == pSys.type)
                                        || (pSys.name == "VIP卡积分返现" && pSys.type == 0 && Convert.ToInt32(sArray[1]) == pSys.type) || (pSys.name == "优惠券金额" && pSys.type == 0 && Convert.ToInt32(sArray[1]) == pSys.type))
                                    {
                                        columnsSysthirdth.Add(pSys);
                                    }

                                    else if ((pSys.name == "现金" && pSys.type == 1 && Convert.ToInt32(sArray[1]) == pSys.type) || (pSys.name == "银联卡" && pSys.type == 1 && Convert.ToInt32(sArray[1]) == pSys.type) 
                                        || (pSys.name == "微信" && pSys.type == 1 && Convert.ToInt32(sArray[1]) == pSys.type) ||( pSys.name == "支付宝" && pSys.type == 1 && Convert.ToInt32(sArray[1]) == pSys.type) 
                                        || (pSys.name == "其他" && pSys.type == 1 && Convert.ToInt32(sArray[1]) == pSys.type))
                                    {
                                        columnsSysfourth.Add(pSys);
                                    }

                                    else if (pSys.name == "零售单数" || pSys.name == "营收金额" || pSys.name == "当日现金结余")
                                    {
                                        columnsSysfiveth.Add(pSys);
                                    }
                                    else if (pSys.name == "营业员签名" || pSys.name == "财务签名")
                                    {
                                        columnsSyssixth.Add(pSys);
                                    }
                                    // columnsSys.Add(pSys);
                                    break;
                                }
                                else
                                {
                                    pSys.ischeck = false;
                                }
                            }
                        }
                        loadList.AddRange(columnsSysfirst);
                        loadList.AddRange(columnsSysSecnod);
                        loadList.AddRange(columnsSysthirdth);
                        loadList.AddRange(columnsSysfourth);
                        loadList.AddRange(columnsSysfiveth);
                        loadList.AddRange(columnsSyssixth);

                        setLblValue(columnsSysfirst,columnsSysSecnod,columnsSysthirdth,columnsSysfourth,columnsSysfiveth,columnsSyssixth);
                        this.dataGridViewSys.DataSource = list;
                        lastPrintSysInfo = list;
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
        private void setSysVariable()
        {
            List<PrintSysInfo> list = GlobalUtilOfPrint.getBalanceOnThatDaySysInfo();
            foreach (PrintSysInfo pInfo in list)
            {
                pInfo.ischeck = true;
            }
            dataGridViewSys.DataSource = list;
        }


       


        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;

      /*  private void setSysSelectAll()
        {
            List<PrintSysInfo> source =
             //DataGridViewUtil.BindingListToList<PrintSysInfo>(dataGridViewSys.DataSource);
               (List<PrintSysInfo>)dataGridViewSys.DataSource;
         
            this.dataGridViewSys.DataSource = null;
            this.dataGridViewSys.DataSource = source;
        }
        private void setColSelectAll()
        {
            List<PrintColumnsInfo> source =
                //DataGridViewUtil.BindingListToList<PrintColumnsInfo>(this.dataGridViewColumns.DataSource);
                 (List<PrintColumnsInfo>)this.dataGridViewColumns.DataSource;
            this.dataGridViewColumns.DataSource = null;
            this.dataGridViewColumns.DataSource = source;
        }
        */
        private void Initialize()
        {

            dataGridViewSys.AutoGenerateColumns = false;
           
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridViewSys);
            dataGridViewPagingSumCtrl.ShowRowCounts = false;
            dataGridViewPagingSumCtrl.Initialize();

           /* dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(this.dataGridViewColumns);
            dataGridViewPagingSumCtrl1.ShowRowCounts = false;
            dataGridViewPagingSumCtrl1.Initialize();*/
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

            
            lblDay1.Text = "";
            lblDay2.Text = "";
            lblDay3.Text = "";
            lblDay4.Text = "";
            lblDay5.Text = "";
            lblDay6.Text = "";
            lblDay7.Text = "";

            lblrecharge1.Text = "";
            lblrecharge2.Text = "";
            lblrecharge3.Text = "";
            lblrecharge4.Text = "";
            lblrecharge5.Text = "";

            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";

            lblAutograph1.Text = "";
            lblAutograph2.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        bool flag = false;
        List<PrintSysInfo> loadList = new List<PrintSysInfo>();
        private void baseButtonSave_Click(object sender, EventArgs e)
        {
           // int gWidth=this.dataGridView3.Width;
            //          打印模板
            //GetPrintTemplateInfo
            //SavePrintTemplateInfo
        //    List<PrintColumnInfo> listOfColumns = new List<PrintColumnInfo>();
           // PrintColumnInfo p = new PrintColumnInfo();
            List<string> listSys = new List<string>();
            if (!flag)
            {
                lastPrintSysInfo = loadList;
            }
            foreach (PrintSysInfo pSysInfo in lastPrintSysInfo) {
                listSys.Add(pSysInfo.name+"#"+pSysInfo.type);
            }
            List<PrintColumnInfo> listOfColumns = new List<PrintColumnInfo>();
            
            try
            {
                InteractResult result = GlobalCache.ServerProxy.SavePrintTemplateInfo(new PrintTemplateInfo()
                {
                    Type = PrintTemplateType.DayReport,
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
           

            //for (int i = 0; i < curSysInfo.Count; i++)
            //{

            //}
           

        }

        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
            this.lblCurDataName.Text =this.txtDataName.SkinTxt.Text.Trim();
            
        }

        private void dataGridViewColumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          /*  List<PrintColumnsInfo> source =(List<PrintColumnsInfo>)this.dataGridViewSys.DataSource ;
            PrintColumnsInfo item = source[e.RowIndex];*/

        }

        private void dataGridViewSys_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            List<PrintSysInfo> curSysInfo = new List<PrintSysInfo>();
            List<PrintSysInfo> firstList1 = new List<PrintSysInfo>();
            List<PrintSysInfo> secondList2 = new List<PrintSysInfo>();
            List<PrintSysInfo> thirdList3 = new List<PrintSysInfo>();
            List<PrintSysInfo> fourthList4 = new List<PrintSysInfo>();
            List<PrintSysInfo> fiveList5 = new List<PrintSysInfo>();
            List<PrintSysInfo> sixList6 = new List<PrintSysInfo>();

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
                        if (item.name == pInfo.name && item.type==pInfo.type)
                        {

                            item.ischeck = (bool)this.dataGridViewSys[e.ColumnIndex, e.RowIndex].Value;
                            if (item.ischeck)
                            {
                                if (pInfo.name == "日结时间" || pInfo.name == "日结日期" || pInfo.name == "店铺名称")
                                {
                                    firstList1.Add(pInfo);
                                }
                                else if (pInfo.name == "期初库存" || pInfo.name == "采购进货" || pInfo.name == "采购退货"|| pInfo.name == "调拨入库" || pInfo.name == "调拨" || pInfo.name == "报损出库"
                                    || pInfo.name == "盘盈数" || pInfo.name == "盘亏数" || pInfo.name == "批发发货" || pInfo.name == "批发退货" || pInfo.name == "当日销售" || pInfo.name == "顾客退货"
                                    || pInfo.name == "差异调整" || pInfo.name == "期末库存" 
                                    )
                                {
                                    secondList2.Add(pInfo);
                                } 
                                else if ((pInfo.name == "现金" && pInfo.type == 0) || (pInfo.name == "银联卡" && pInfo.type == 0) || (pInfo.name == "微信" && pInfo.type == 0) ||(pInfo.name == "支付宝" && pInfo.type == 0) ||   (pInfo.name == "VIP卡余额" && pInfo.type == 0)
                                    || pInfo.name == "VIP卡积分返现" || pInfo.name == "优惠券金额" )
                                {
                                    thirdList3.Add(pInfo);
                                }

                                else if ((pInfo.name == "现金" && pInfo.type == 1) ||(pInfo.name == "银联卡" && pInfo.type == 1) || (pInfo.name == "微信" && pInfo.type == 1) || (pInfo.name == "支付宝" && pInfo.type == 1) || (pInfo.name == "其他" && pInfo.type == 1))
                                {
                                    pInfo.type = 1;
                                    fourthList4.Add(pInfo);
                                }

                                else if (pInfo.name == "零售单数" || pInfo.name == "营收金额" || pInfo.name == "当日现金结余")
                                {
                                    fiveList5.Add(pInfo);
                                }
                                else if (pInfo.name == "营业员签名" || pInfo.name == "财务签名")
                                {
                                    sixList6.Add(pInfo);
                                }
                                //curSysInfo.Add(pInfo);
                            }
                        }
                        else
                        {
                           if (pInfo.ischeck)
                            {
                                if (pInfo.name == "日结时间" || pInfo.name == "日结日期" || pInfo.name == "店铺名称")
                                {
                                    firstList1.Add(pInfo);
                                }
                                else if (pInfo.name == "期初库存" || pInfo.name == "采购进货" || pInfo.name == "采购退货" || pInfo.name == "调拨入库" || pInfo.name == "调拨" || pInfo.name == "报损出库"
                                    || pInfo.name == "盘盈数" || pInfo.name == "盘亏数" || pInfo.name == "批发发货" || pInfo.name == "批发退货" || pInfo.name == "当日销售" || pInfo.name == "顾客退货"
                                    || pInfo.name == "差异调整" || pInfo.name == "期末库存"
                                    )
                                {
                                    secondList2.Add(pInfo);
                                }
                                else if ((pInfo.name == "现金" && pInfo.type == 0) || (pInfo.name == "银联卡" && pInfo.type == 0) || (pInfo.name == "微信" && pInfo.type == 0) || (pInfo.name == "支付宝" && pInfo.type == 0) || (pInfo.name == "VIP卡余额" && pInfo.type == 0)
                                    || pInfo.name == "VIP卡积分返现" || pInfo.name == "优惠券金额")
                                {
                                    thirdList3.Add(pInfo);
                                }

                                else if ((pInfo.name == "现金" && pInfo.type == 1) || (pInfo.name == "银联卡" && pInfo.type == 1) || (pInfo.name == "微信" && pInfo.type == 1) || (pInfo.name == "支付宝" && pInfo.type == 1) || (pInfo.name == "其他" && pInfo.type == 1))
                                {
                                    pInfo.type = 1;
                                    fourthList4.Add(pInfo);
                                }

                                else if (pInfo.name == "零售单数" || pInfo.name == "营收金额" || pInfo.name == "当日现金结余")
                                {
                                    fiveList5.Add(pInfo);
                                }
                                else if (pInfo.name == "营业员签名" || pInfo.name == "财务签名")
                                {
                                    sixList6.Add(pInfo);
                                }
                            }
                        }
                    }
                    //if (item.ischeck)
                    //{
                    //    curSysInfo.Add(item);
                    //}
                    setLblValue(firstList1,secondList2,thirdList3,fourthList4,fiveList5,sixList6);
                     

                    foreach (PrintSysInfo oneItem in firstList1)
                    {
                        curSysInfo.Add(oneItem);
                    }
                    foreach (PrintSysInfo twoItem in secondList2)
                    {
                        curSysInfo.Add(twoItem);
                    }
                    foreach (PrintSysInfo threeItem in thirdList3)
                    {
                        curSysInfo.Add(threeItem);
                    }
                    foreach (PrintSysInfo fourItem in fourthList4)
                    {
                        curSysInfo.Add(fourItem);
                    }
                    foreach (PrintSysInfo fiveItem in fiveList5)
                    {
                        curSysInfo.Add(fiveItem);
                    }
                    foreach (PrintSysInfo sixItem in sixList6)
                    {
                        curSysInfo.Add(sixItem);
                    }



                     lastPrintSysInfo = curSysInfo;
                }
            }
        }
        /// <summary>
        /// 设置模板显示变量
        /// </summary>
        /// <param name="curSysInfo"></param>
        private void setLblValue(List<PrintSysInfo> FirstSysInfo, List<PrintSysInfo> SecondSysInf, List<PrintSysInfo>ThirdSysInf, List<PrintSysInfo> FourthSysInf, List<PrintSysInfo> FiveSysInf, List<PrintSysInfo> SixSysInf)
        {
            #region
            switch (FirstSysInfo.Count)
            {
                case 0:
                    this.lblName1.Text = "";
                    this.lblName2.Text = "";
                    this.lblName3.Text = ""; 
                    break;
                case 1:
                    this.lblName1.Text = FirstSysInfo[0].name;
                    this.lblName2.Text = "";
                    this.lblName3.Text = ""; 
                    break;
                case 2:
                    this.lblName1.Text = FirstSysInfo[0].name;
                    this.lblName2.Text = FirstSysInfo[1].name;
                    this.lblName3.Text = "";
                    break;
                case 3:
                    this.lblName1.Text = FirstSysInfo[0].name;
                    this.lblName2.Text = FirstSysInfo[1].name;
                    this.lblName3.Text = FirstSysInfo[2].name; 
                    break; 
                default:
                    break;
            }

            switch (SecondSysInf.Count)
            {
                case 0:
                    this.lblName4.Text = "";
                    this.lblName5.Text = "";
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;
                case 1: 
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = "";
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;
                case 2:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = "";
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;
                case 3: 
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = "";
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text =  "";
                    break;

                case 4:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = "";
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 5:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = "";
                    this.lblName10.Text = "";
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 6:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = "";
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 7:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = SecondSysInf[6].name;
                    this.lblName11.Text = "";
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 8:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = SecondSysInf[6].name;
                    this.lblName11.Text = SecondSysInf[7].name;
                    this.lblName12.Text = "";
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 9:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = SecondSysInf[6].name;
                    this.lblName11.Text = SecondSysInf[7].name;
                    this.lblName12.Text = SecondSysInf[8].name;
                    this.lblName13.Text = "";
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 10:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = SecondSysInf[6].name;
                    this.lblName11.Text = SecondSysInf[7].name;
                    this.lblName12.Text = SecondSysInf[8].name;
                    this.lblName13.Text = SecondSysInf[9].name;
                    this.lblName14.Text = "";
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 11:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = SecondSysInf[6].name;
                    this.lblName11.Text = SecondSysInf[7].name;
                    this.lblName12.Text = SecondSysInf[8].name;
                    this.lblName13.Text = SecondSysInf[9].name;
                    this.lblName14.Text = SecondSysInf[10].name;
                    this.lblName15.Text = "";
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 12:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = SecondSysInf[6].name;
                    this.lblName11.Text = SecondSysInf[7].name;
                    this.lblName12.Text = SecondSysInf[8].name;
                    this.lblName13.Text = SecondSysInf[9].name;
                    this.lblName14.Text = SecondSysInf[10].name;
                    this.lblName15.Text = SecondSysInf[11].name;
                    this.lblName16.Text = "";
                    this.lblName17.Text = "";
                    break;

                case 13:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = SecondSysInf[6].name;
                    this.lblName11.Text = SecondSysInf[7].name;
                    this.lblName12.Text = SecondSysInf[8].name;
                    this.lblName13.Text = SecondSysInf[9].name;
                    this.lblName14.Text = SecondSysInf[10].name;
                    this.lblName15.Text = SecondSysInf[11].name;
                    this.lblName16.Text = SecondSysInf[12].name;
                    this.lblName17.Text = "";
                    break;

                case 14:
                    this.lblName4.Text = SecondSysInf[0].name;
                    this.lblName5.Text = SecondSysInf[1].name;
                    this.lblName6.Text = SecondSysInf[2].name;
                    this.lblName7.Text = SecondSysInf[3].name;
                    this.lblName8.Text = SecondSysInf[4].name;
                    this.lblName9.Text = SecondSysInf[5].name;
                    this.lblName10.Text = SecondSysInf[6].name;
                    this.lblName11.Text = SecondSysInf[7].name;
                    this.lblName12.Text = SecondSysInf[8].name;
                    this.lblName13.Text = SecondSysInf[9].name;
                    this.lblName14.Text = SecondSysInf[10].name;
                    this.lblName15.Text = SecondSysInf[11].name;
                    this.lblName16.Text = SecondSysInf[12].name;
                    this.lblName17.Text = SecondSysInf[13].name;
                    break;
                default:
                    break;
            }


            switch (ThirdSysInf.Count)
            {
                case 0:
                    this.lblDay1.Text = "";
                    this.lblDay2.Text = "";
                    this.lblDay3.Text = "";
                    this.lblDay4.Text = "";
                    this.lblDay5.Text = "";
                    this.lblDay6.Text = "";
                    this.lblDay7.Text = "";
                    break;
                case 1: 
                    this.lblDay1.Text = ThirdSysInf[0].name;
                    this.lblDay2.Text = "";
                    this.lblDay3.Text = "";
                    this.lblDay4.Text = "";
                    this.lblDay5.Text = "";
                    this.lblDay6.Text = "";
                    this.lblDay7.Text = "";
                    break;
                case 2:

                    this.lblDay1.Text = ThirdSysInf[0].name;
                    this.lblDay2.Text = ThirdSysInf[1].name;
                    this.lblDay3.Text = "";
                    this.lblDay4.Text = "";
                    this.lblDay5.Text = "";
                    this.lblDay6.Text = "";
                    this.lblDay7.Text = "";
                    break;
                case 3:

                    this.lblDay1.Text = ThirdSysInf[0].name;
                    this.lblDay2.Text = ThirdSysInf[1].name;
                    this.lblDay3.Text = ThirdSysInf[2].name;
                    this.lblDay4.Text = "";
                    this.lblDay5.Text = "";
                    this.lblDay6.Text = "";
                    this.lblDay7.Text = "";
                    break;
                case 4:

                    this.lblDay1.Text = ThirdSysInf[0].name;
                    this.lblDay2.Text = ThirdSysInf[1].name;
                    this.lblDay3.Text = ThirdSysInf[2].name;
                    this.lblDay4.Text = ThirdSysInf[3].name;
                    this.lblDay5.Text = "";
                    this.lblDay6.Text = "";
                    this.lblDay7.Text = "";
                    break;
                case 5:

                    this.lblDay1.Text = ThirdSysInf[0].name;
                    this.lblDay2.Text = ThirdSysInf[1].name;
                    this.lblDay3.Text = ThirdSysInf[2].name;
                    this.lblDay4.Text = ThirdSysInf[3].name;
                    this.lblDay5.Text = ThirdSysInf[4].name;
                    this.lblDay6.Text = "";
                    this.lblDay7.Text = "";
                    break;
                case 6:

                    this.lblDay1.Text = ThirdSysInf[0].name;
                    this.lblDay2.Text = ThirdSysInf[1].name;
                    this.lblDay3.Text = ThirdSysInf[2].name;
                    this.lblDay4.Text = ThirdSysInf[3].name;
                    this.lblDay5.Text = ThirdSysInf[4].name;
                    this.lblDay6.Text = ThirdSysInf[5].name;
                    this.lblDay7.Text = "";
                    break;
                case 7:

                    this.lblDay1.Text = ThirdSysInf[0].name;
                    this.lblDay2.Text = ThirdSysInf[1].name;
                    this.lblDay3.Text = ThirdSysInf[2].name;
                    this.lblDay4.Text = ThirdSysInf[3].name;
                    this.lblDay5.Text = ThirdSysInf[4].name;
                    this.lblDay6.Text = ThirdSysInf[5].name;
                    this.lblDay7.Text = ThirdSysInf[6].name;
                    break;
                default:
                    break;
            }

            switch (FourthSysInf.Count)
            {
                case 0:
                    this.lblrecharge1.Text = "";
                    this.lblrecharge2.Text = "";
                    this.lblrecharge3.Text = "";
                    this.lblrecharge4.Text = "";
                    this.lblrecharge5.Text = ""; 
                    break;
                case 1:
                    this.lblrecharge1.Text = FourthSysInf[0].name;
                    this.lblrecharge2.Text = "";
                    this.lblrecharge3.Text = "";
                    this.lblrecharge4.Text = "";
                    this.lblrecharge5.Text = ""; 
                    break;
                case 2:

                    this.lblrecharge1.Text = FourthSysInf[0].name;
                    this.lblrecharge2.Text = FourthSysInf[1].name;
                    this.lblrecharge3.Text = "";
                    this.lblrecharge4.Text = "";
                    this.lblrecharge5.Text = ""; 
                    break;
                case 3:

                    this.lblrecharge1.Text = FourthSysInf[0].name;
                    this.lblrecharge2.Text = FourthSysInf[1].name;
                    this.lblrecharge3.Text = FourthSysInf[2].name;
                    this.lblrecharge4.Text = "";
                    this.lblrecharge5.Text = ""; 
                    break;
                case 4:

                    this.lblrecharge1.Text = FourthSysInf[0].name;
                    this.lblrecharge2.Text = FourthSysInf[1].name;
                    this.lblrecharge3.Text = FourthSysInf[2].name;
                    this.lblrecharge4.Text = FourthSysInf[3].name;
                    this.lblrecharge5.Text = ""; 
                    break;
                case 5:

                    this.lblrecharge1.Text = FourthSysInf[0].name;
                    this.lblrecharge2.Text = FourthSysInf[1].name;
                    this.lblrecharge3.Text = FourthSysInf[2].name;
                    this.lblrecharge4.Text = FourthSysInf[3].name;
                    this.lblrecharge5.Text = FourthSysInf[4].name; 
                    break;
                
                default:
                    break;
            }


            switch (FiveSysInf.Count)
            {
                case 0:
                    this.lbl1.Text = "";
                    this.lbl2.Text = "";
                    this.lbl3.Text = "";
                    break;
                case 1:
                    this.lbl1.Text = FiveSysInf[0].name;
                    this.lbl2.Text = "";
                    this.lbl3.Text = "";
                    break;
                case 2:
                    this.lbl1.Text = FiveSysInf[0].name;
                    this.lbl2.Text = FiveSysInf[1].name;
                    this.lbl3.Text = "";
                    break;
                case 3:
                    this.lbl1.Text = FiveSysInf[0].name;
                    this.lbl2.Text = FiveSysInf[1].name;
                    this.lbl3.Text = FiveSysInf[2].name;
                    break;
                default:
                    break;
            }

            switch (SixSysInf.Count)
            {
                case 0:
                    this.lblAutograph1.Text = "";
                    this.lblAutograph2.Text = ""; 
                    break;
                case 1:
                    this.lblAutograph1.Text = SixSysInf[0].name;
                    this.lblAutograph2.Text = ""; 
                    break;
                case 2:
                    this.lblAutograph1.Text = SixSysInf[0].name;
                    this.lblAutograph2.Text = SixSysInf[1].name; 
                    break; 
                default:
                    break;
            }
            #endregion

        }

        private void dataGridViewColumns_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            /*  List<PrintColumnsInfo> curColumnsInfo = new List<PrintColumnsInfo>(); 
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
                      setColumnsHeaderInfo(curColumnsInfo);
                  }
              }*/
           
        }

        private void panel7_Scroll(object sender, ScrollEventArgs e)
        {
          //  this.panel7.HorizontalScroll.Value = e.NewValue;
        }

      
        private void PrintOfBalanceOnThatDay_SizeChanged(object sender, EventArgs e)
        {


         
        }
    }
}
