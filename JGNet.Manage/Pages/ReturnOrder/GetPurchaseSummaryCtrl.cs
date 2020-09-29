using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
using CCWin;

using JGNet.Common.Core.Util;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Manage.Pages;

namespace JGNet.Manage
{/// <summary>
/// 采购退货查询
/// </summary>
    public partial class GetPurchaseSummaryCtrl : BaseUserControl
    {
        public static String CONFIG_PATH = CommonGlobalUtil.AgileConfiguration("Manage.PurchaseSummaryConfiguration");
        private GetPurchaseSummaryPara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2; 

        /// <summary>
        /// 点击补货申请单明细触发
        /// </summary>
        public event CJBasic.Action<PurchaseOrder, Panel, bool> DetailClick;
        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.BaseButton_Search_Click(null, null);
            }
        }
        /// <summary>
        /// 点击收货按钮触发
        /// </summary>
        // public event CJBasic.Action<ReturnOrder> InboundClick;

        private void SkinTextBox_costumeID_CostumeSelected(Costume costume, bool isEnter)
        { if (costume != null && isEnter) {
                BaseButton_Search_Click(null, null);
            }
        }

        private PurchaseSummaryConfiguration config;
        public GetPurchaseSummaryCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2);
            
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl2.Initialize();

            this.dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1,
                new string[] {
                AllCount.DataPropertyName,
                BidCount.DataPropertyName
            });
            this.dataGridView1.AutoGenerateColumns = false;
          //  ShowMessage("COMEATypeValue1=" + TypeValue1.Visible + "TypeValue2=" + TypeValue2.Visible);
            dataGridViewPagingSumCtrl.Initialize();  //执行后TypeValue1，TypeValue2 的Visible=True

            //  ShowMessage("COMEBTypeValue1=" + TypeValue1.Visible + "TypeValue2=" + TypeValue2.Visible);
            dataGridViewPagingSumCtrl.ColumnSorting = dataGridViewPagingSumCtrl_ColumnSorting;  
            //dataGridViewPagingSumCtrl.ColumnSorting用处  
            this.TypeValue1.HeaderText = "款号";
            this.TypeValue2.Visible = false;
        
            TypeValue3.Visible = false;
            TypeValue4.Visible = false;
            TypeValue5.Visible = false;
            TypeValue6.Visible = false;
            TypeValue7.Visible = false;
            TypeValue8.Visible = false;
            TypeValue9.Visible = false;
            TypeValue10.Visible = false;


            // ShowMessage("COME11TypeValue1=" + TypeValue1.Visible + "TypeValue2=" + TypeValue2.Visible);
            config = PurchaseSummaryConfiguration.Load(CONFIG_PATH) as PurchaseSummaryConfiguration;
            if (config != null)
            {
                List<String> list = new List<string>();
                list.Add("款号");
                list.Add("供应商+款号");
                list.Add("品牌+款号");
                list.Add("日期+款号");
                list.Add("日期+单号+供应商");

                foreach (var item in config.Types)
                {
                    if (list.Find(t => t == item)==null)
                    {
                        list.Add(item);
                    }
                }
                config.Types = list;
            }
            else
            {
                config = new PurchaseSummaryConfiguration() { Types = new List<String>() };
                config.Types.Add("款号");
                config.Types.Add("供应商+款号");
                config.Types.Add("品牌+款号");
                config.Types.Add("日期+款号");
                config.Types.Add("日期+单号+供应商");
            }

            SetUnconsumedDays();
            MenuPermission = RolePermissionMenuEnum.采购汇总;
        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        private void Initialize()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            this.pagePara = new GetPurchaseSummaryPara();
            this.skinTextBox_costumeID.SkinTxt.Text = string.Empty;
            CommonGlobalUtil.SetBrand(skinComboBox_Brand);
            if (TypeValue2.HeaderText == "TypeValue2")
            {
                TypeValue2.HeaderText = "品牌";
                this.TypeValue2.Visible = false;

            }
            if (TypeValue3.HeaderText == "TypeValue3")
            {
                TypeValue3.HeaderText = "供应商";
                this.TypeValue3.Visible = false;
            }
            if (TypeValue3.HeaderText == "TypeValue4")
            {
                TypeValue3.HeaderText = "商品名称";
                this.TypeValue3.Visible = false;
            }
            if (TypeValue2.HeaderText == "TypeValue5")
            {
                TypeValue2.HeaderText = "单号";
                this.TypeValue2.Visible = false;

            }
            if (TypeValue3.HeaderText == "TypeValue6")
            {
                TypeValue3.HeaderText = "颜色";
                this.TypeValue3.Visible = false;
            }
            if (TypeValue3.HeaderText == "TypeValue7")
            {
                TypeValue3.HeaderText = "日期";
                this.TypeValue3.Visible = false;
            }
            if (TypeValue2.HeaderText == "TypeValue8")
            {
                TypeValue2.HeaderText = "类别";
                this.TypeValue2.Visible = false;

            }
            if (TypeValue3.HeaderText == "TypeValue9")
            {
                TypeValue3.HeaderText = "季节";
                this.TypeValue3.Visible = false;
            }
            if (TypeValue3.HeaderText == "TypeValue10")
            {
                TypeValue3.HeaderText = "年份";
                this.TypeValue3.Visible = false;
            }
            // CommonGlobalUtil.SetSupplier(skinComboBoxSupplierID);
            // ShowMessage(this.colletStyle.SelectedValue.ToString());

        }
        private void SetStore()
        {

        }

        private void SetUnconsumedDays()
        {
            List<ListItem<String>> list = new List<ListItem<string>>();
            foreach (var item in config.Types)
            {
                list.Add(new ListItem<string>(item, item));
            }
            
            this.colletStyle.DisplayMember = "Key";
            this.colletStyle.ValueMember = "Value";
            this.colletStyle.DataSource = list;
        }


        private void SetVisible(List<DataGridViewTextBoxColumn> listColumn)
        {
            foreach (DataGridViewTextBoxColumn cItem in listColumn)
            {
                if (cItem.Visible)
                {
                    cItem.Visible = false;
                }

            }
        }
        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                this.pagePara = new GetPurchaseSummaryPara()
                {
                    
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    CostumeID = skinTextBox_costumeID.Text.Trim(),
                    Type = (string)colletStyle.SelectedValue,
                    BrandID= (int)this.skinComboBox_Brand.SelectedValue,
                    SupplierID=(string)this.skinComboBoxSupplierID.SelectedValue,
                    OrderId = this.skinTextBox_OrderID.SkinTxt.Text.Trim(),
                    //款号，供应商+款号、品牌 + 款号、日期 + 款号、日期 + 单号 + 供应商
                };

                PurchaseSummary listPage = GlobalCache.ServerProxy.GetPurchaseSummary(this.pagePara);
                String[] strs = pagePara.Type.Split('+');
                if (strs.Length == 1)
                {//款号 
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = false;
                    TypeValue3.Visible = false;
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                    listColumn.Add(TypeValue4);
                    listColumn.Add(TypeValue5);
                    listColumn.Add(TypeValue6);
                    listColumn.Add(TypeValue7);
                    listColumn.Add(TypeValue8);
                    listColumn.Add(TypeValue9);
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);

                }
                else
                if (strs.Length == 2)
                {//供应商+款号、品牌 + 款号、日期 + 款号
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = false;
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                    listColumn.Add(TypeValue4);
                    listColumn.Add(TypeValue5);
                    listColumn.Add(TypeValue6);
                    listColumn.Add(TypeValue7);
                    listColumn.Add(TypeValue8);
                    listColumn.Add(TypeValue9);
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);
                }
                else 
                if (strs.Length == 3)
                {//日期 + 单号 + 供应商
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                    listColumn.Add(TypeValue4);
                    listColumn.Add(TypeValue5);
                    listColumn.Add(TypeValue6);
                    listColumn.Add(TypeValue7);
                    listColumn.Add(TypeValue8);
                    listColumn.Add(TypeValue9);
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);
                }
                else
                if (strs.Length == 4)
                {//日期 + 单号 + 供应商+年份
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    TypeValue4.Visible = true;
                    TypeValue4.HeaderText = strs[3];
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                    listColumn.Add(TypeValue5);
                    listColumn.Add(TypeValue6);
                    listColumn.Add(TypeValue7);
                    listColumn.Add(TypeValue8);
                    listColumn.Add(TypeValue9);
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);
                }
                else
                if (strs.Length == 5)
                {//日期 + 单号 + 供应商+年份+季节
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    TypeValue4.Visible = true;
                    TypeValue4.HeaderText = strs[3];
                    TypeValue5.Visible = true;
                    TypeValue5.HeaderText = strs[4];
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                    listColumn.Add(TypeValue6);
                    listColumn.Add(TypeValue7);
                    listColumn.Add(TypeValue8);
                    listColumn.Add(TypeValue9);
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);
                }
                else
                if (strs.Length == 6)
                {//日期 + 单号 + 供应商+年份+季节+名称
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    TypeValue4.Visible = true;
                    TypeValue4.HeaderText = strs[3];
                    TypeValue5.Visible = true;
                    TypeValue5.HeaderText = strs[4];
                    TypeValue6.Visible = true;
                    TypeValue6.HeaderText = strs[5];
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                    listColumn.Add(TypeValue7);
                    listColumn.Add(TypeValue8);
                    listColumn.Add(TypeValue9);
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);
                }
                else
                if (strs.Length == 7)
                {//日期 + 单号 + 供应商+年份+季节+名称+款号
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    TypeValue4.Visible = true;
                    TypeValue4.HeaderText = strs[3];
                    TypeValue5.Visible = true;
                    TypeValue5.HeaderText = strs[4];
                    TypeValue6.Visible = true;
                    TypeValue6.HeaderText = strs[5];
                    TypeValue7.Visible = true;
                    TypeValue7.HeaderText = strs[6];
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                    listColumn.Add(TypeValue8);
                    listColumn.Add(TypeValue9);
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);
                }
                else
                if (strs.Length == 8)
                {//日期 + 单号 + 供应商+年份+季节+名称+颜色+款号
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    TypeValue4.Visible = true;
                    TypeValue4.HeaderText = strs[3];
                    TypeValue5.Visible = true;
                    TypeValue5.HeaderText = strs[4];
                    TypeValue6.Visible = true;
                    TypeValue6.HeaderText = strs[5];
                    TypeValue7.Visible = true;
                    TypeValue7.HeaderText = strs[6];
                    TypeValue8.Visible = true;
                    TypeValue8.HeaderText = strs[7];
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>(); 
                    listColumn.Add(TypeValue9);
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);
                }
                else
                if (strs.Length == 9)
                {//日期 + 单号 + 供应商+年份+季节+名称+品牌+颜色+款号
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    TypeValue4.Visible = true;
                    TypeValue4.HeaderText = strs[3];
                    TypeValue5.Visible = true;
                    TypeValue5.HeaderText = strs[4];
                    TypeValue6.Visible = true;
                    TypeValue6.HeaderText = strs[5];
                    TypeValue7.Visible = true;
                    TypeValue7.HeaderText = strs[6];
                    TypeValue8.Visible = true;
                    TypeValue8.HeaderText = strs[7];
                    TypeValue9.Visible = true;
                    TypeValue9.HeaderText = strs[8];
                    List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                    listColumn.Add(TypeValue10);
                    SetVisible(listColumn);
                }
                else
                if (strs.Length == 10)
                {//日期 + 单号 + 供应商+年份+季节+商品名称+品牌+颜色+款号+其他
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    TypeValue4.Visible = true;
                    TypeValue4.HeaderText = strs[3];
                    TypeValue5.Visible = true;
                    TypeValue5.HeaderText = strs[4];
                    TypeValue6.Visible = true;
                    TypeValue6.HeaderText = strs[5];
                    TypeValue7.Visible = true;
                    TypeValue7.HeaderText = strs[6];
                    TypeValue8.Visible = true;
                    TypeValue8.HeaderText = strs[7];
                    TypeValue9.Visible = true;
                    TypeValue9.HeaderText = strs[8];
                    TypeValue10.Visible = true;
                    TypeValue10.HeaderText = strs[9];
                }

                if (!String.IsNullOrEmpty(pagePara.CostumeID))
                {

                    if (strs.Length == 1)
                    {//款号 
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = false;
                        TypeValue3.Visible = false;
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue4);
                        listColumn.Add(TypeValue5);
                        listColumn.Add(TypeValue6);
                        listColumn.Add(TypeValue7);
                        listColumn.Add(TypeValue8);
                        listColumn.Add(TypeValue9);
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                    else
                if (strs.Length == 2)
                    {//供应商+款号、品牌 + 款号、日期 + 款号
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = true;
                        TypeValue2.HeaderText = strs[1];
                        TypeValue3.Visible = false;
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue4);
                        listColumn.Add(TypeValue5);
                        listColumn.Add(TypeValue6);
                        listColumn.Add(TypeValue7);
                        listColumn.Add(TypeValue8);
                        listColumn.Add(TypeValue9);
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                    else
                if (strs.Length == 3)
                    {//日期 + 单号 + 供应商
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = true;
                        TypeValue2.HeaderText = strs[1];
                        TypeValue3.Visible = true;
                        TypeValue3.HeaderText = strs[2];
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue4);
                        listColumn.Add(TypeValue5);
                        listColumn.Add(TypeValue6);
                        listColumn.Add(TypeValue7);
                        listColumn.Add(TypeValue8);
                        listColumn.Add(TypeValue9);
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                else
                if (strs.Length == 4)
                {//日期 + 单号 + 供应商+年份
                    TypeValue1.Visible = true;
                    TypeValue1.HeaderText = strs[0];
                    TypeValue2.Visible = true;
                    TypeValue2.HeaderText = strs[1];
                    TypeValue3.Visible = true;
                    TypeValue3.HeaderText = strs[2];
                    TypeValue4.Visible = true;
                    TypeValue4.HeaderText = strs[3];
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue5);
                        listColumn.Add(TypeValue6);
                        listColumn.Add(TypeValue7);
                        listColumn.Add(TypeValue8);
                        listColumn.Add(TypeValue9);
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                    else
                if (strs.Length == 5)
                    {//日期 + 单号 + 供应商+年份+季节
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = true;
                        TypeValue2.HeaderText = strs[1];
                        TypeValue3.Visible = true;
                        TypeValue3.HeaderText = strs[2];
                        TypeValue4.Visible = true;
                        TypeValue4.HeaderText = strs[3];
                        TypeValue5.Visible = true;
                        TypeValue5.HeaderText = strs[4];
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue6);
                        listColumn.Add(TypeValue7);
                        listColumn.Add(TypeValue8);
                        listColumn.Add(TypeValue9);
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                    else
                if (strs.Length == 6)
                    {//日期 + 单号 + 供应商+年份+季节+名称
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = true;
                        TypeValue2.HeaderText = strs[1];
                        TypeValue3.Visible = true;
                        TypeValue3.HeaderText = strs[2];
                        TypeValue4.Visible = true;
                        TypeValue4.HeaderText = strs[3];
                        TypeValue5.Visible = true;
                        TypeValue5.HeaderText = strs[4];
                        TypeValue6.Visible = true;
                        TypeValue6.HeaderText = strs[5];
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue7);
                        listColumn.Add(TypeValue8);
                        listColumn.Add(TypeValue9);
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                    else
                if (strs.Length == 7)
                    {//日期 + 单号 + 供应商+年份+季节+名称+款号
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = true;
                        TypeValue2.HeaderText = strs[1];
                        TypeValue3.Visible = true;
                        TypeValue3.HeaderText = strs[2];
                        TypeValue4.Visible = true;
                        TypeValue4.HeaderText = strs[3];
                        TypeValue5.Visible = true;
                        TypeValue5.HeaderText = strs[4];
                        TypeValue6.Visible = true;
                        TypeValue6.HeaderText = strs[5];
                        TypeValue7.Visible = true;
                        TypeValue7.HeaderText = strs[6];
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue8);
                        listColumn.Add(TypeValue9);
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                    else
                if (strs.Length == 8)
                    {//日期 + 单号 + 供应商+年份+季节+名称+颜色+款号
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = true;
                        TypeValue2.HeaderText = strs[1];
                        TypeValue3.Visible = true;
                        TypeValue3.HeaderText = strs[2];
                        TypeValue4.Visible = true;
                        TypeValue4.HeaderText = strs[3];
                        TypeValue5.Visible = true;
                        TypeValue5.HeaderText = strs[4];
                        TypeValue6.Visible = true;
                        TypeValue6.HeaderText = strs[5];
                        TypeValue7.Visible = true;
                        TypeValue7.HeaderText = strs[6];
                        TypeValue8.Visible = true;
                        TypeValue8.HeaderText = strs[7];
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue9);
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                    else
                if (strs.Length == 9)
                    {//日期 + 单号 + 供应商+年份+季节+名称+品牌+颜色+款号
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = true;
                        TypeValue2.HeaderText = strs[1];
                        TypeValue3.Visible = true;
                        TypeValue3.HeaderText = strs[2];
                        TypeValue4.Visible = true;
                        TypeValue4.HeaderText = strs[3];
                        TypeValue5.Visible = true;
                        TypeValue5.HeaderText = strs[4];
                        TypeValue6.Visible = true;
                        TypeValue6.HeaderText = strs[5];
                        TypeValue7.Visible = true;
                        TypeValue7.HeaderText = strs[6];
                        TypeValue8.Visible = true;
                        TypeValue8.HeaderText = strs[7];
                        TypeValue9.Visible = true;
                        TypeValue9.HeaderText = strs[8];
                        List<DataGridViewTextBoxColumn> listColumn = new List<DataGridViewTextBoxColumn>();
                        listColumn.Add(TypeValue10);
                        SetVisible(listColumn);
                    }
                    else
                if (strs.Length == 10)
                    {//日期 + 单号 + 供应商+年份+季节+商品名称+品牌+颜色+款号+其他
                        TypeValue1.Visible = true;
                        TypeValue1.HeaderText = strs[0];
                        TypeValue2.Visible = true;
                        TypeValue2.HeaderText = strs[1];
                        TypeValue3.Visible = true;
                        TypeValue3.HeaderText = strs[2];
                        TypeValue4.Visible = true;
                        TypeValue4.HeaderText = strs[3];
                        TypeValue5.Visible = true;
                        TypeValue5.HeaderText = strs[4];
                        TypeValue6.Visible = true;
                        TypeValue6.HeaderText = strs[5];
                        TypeValue7.Visible = true;
                        TypeValue7.HeaderText = strs[6];
                        TypeValue8.Visible = true;
                        TypeValue8.HeaderText = strs[7];
                        TypeValue9.Visible = true;
                        TypeValue9.HeaderText = strs[8];
                        TypeValue10.Visible = true;
                        TypeValue10.HeaderText = strs[9];
                    }

                }

                /*.CostumeID, PurchaseSummaryType.CostumeID));
                queryResults.Add(new ListItem<string>(PurchaseSummaryType.CostumeName, PurchaseSummaryType.CostumeName));
                queryResults.Add(new ListItem<string>(PurchaseSummaryType.Date, PurchaseSummaryType.Date));
                queryResults.Add(new ListItem<string>(PurchaseSummaryType.SupplierName, PurchaseSummaryType.SupplierName));
                queryResults.Add(new ListItem<string>(PurchaseSummaryType.BrandName, PurchaseSummaryType.BrandName));
                queryResults.Add(new ListItem<string>(PurchaseSummaryType.PurchaseOrderID, PurchaseSummaryType.PurchaseOrderID));
                queryResults.Add(new ListItem<string>(PurchaseSummaryType.Color, PurchaseSummaryType.CostumeID));
                queryResults.Add(new ListItem<string>(PurchaseSummaryType.Year, PurchaseSummaryType.Year));
                queryResults.Add(new ListItem<string>(PurchaseSummaryType.Season,*/

                this.BindingReturnOrderSource(listPage);


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

        /// <summary>
        /// 绑定plenishOrderSource源到dataGridView中
        /// </summary>
        /// <param name="listPage"></param>
        private void BindingReturnOrderSource(PurchaseSummary listPage)
        {
            this.dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(listPage?.PurchaseSummaryInfos));
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        #region 点击单元格
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                //List <PurchaseOrder> curReturnOrderListSource = (List<PurchaseOrder>)this.dataGridView1.DataSource;
                //PurchaseOrder item = curReturnOrderListSource[e.RowIndex];

                //if (ColumnOrder.Index == e.ColumnIndex) {
                //        this.skinSplitContainer1.Panel2Collapsed = false;
                //        this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2,false);
                //} else if (ColumnPrint.Index== e.ColumnIndex) { 
                //        this.DetailClick?.Invoke(item, this.skinSplitContainer1.Panel2,true);

                //}
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
        }

        //private void BindingOutboundDetailSource(List<BoundDetail> list)
        //{
        //    if (list != null && list.Count > 0)
        //    {
        //        foreach (BoundDetail detail in list)
        //        {
        //            detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
        //        }
        //    }

        //    dataGridViewPagingSumCtrl2.BindingDataSource<BoundDetail>(list);

        //}

        #endregion

        private void ReturnOrderManageCtrl_Load(object sender, EventArgs e)
        {
             this.Initialize();

           
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            PurchaseSummaryTypeForm1 multiselectForm = new PurchaseSummaryTypeForm1();
            //  multiselectForm.MemberMultiSelected += MemberMultiSelected;
            // multiselectForm.ShowDialog();
            //    SalesPromotionCostumeSelectForm form = new SalesPromotionCostumeSelectForm(tempItem, curType, isSalesPromotionUse, filterValid);

            List<ListItem<String>> costumeResult = null;
            if (multiselectForm.ShowDialog(this) == DialogResult.OK)
            {
                costumeResult = multiselectForm.Result;
            }

            if (costumeResult == null)
            {
                return;
            }

            String value = String.Empty;
            foreach (var item in costumeResult)
            {
                value += item.Key + "+";
            }
            if (!String.IsNullOrEmpty(value)) { value = value.Remove(value.LastIndexOf("+")); }

            List<ListItem<string>> list = this.colletStyle.DataSource as List<ListItem<string>>;
            if (list.Find(t => t.Key == value) == null)
            {
                list.Add(new ListItem<string>(value, value));
            }
            config.Types.Clear();
            foreach (var item in list)
            {
                config.Types.Add(item.Key);
            }

            config.Save(CONFIG_PATH);
            SetUnconsumedDays();
            colletStyle.SelectedValue = value;
        }
        //private void MemberMultiSelected(List<ListItem<String>> returnMembers)
        //{
           
           
        //}
    }
}
 