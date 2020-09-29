using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;

using JGNet.Core.Tools;
using JGNet.Core.InteractEntity;
using CCWin;
using JGNet.Common.Core;  
using JGNet.Core;
using CCWin.SkinControl;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Server.Tools;
using JGNet.Manage;
using JGNet.Core.Const;
using CJBasic.Helpers;
using System.Collections;
using CJBasic;
using JieXi.Common;
using JGNet.Common.cache.Wholesale;

namespace JGNet.Common
{
    public partial class CustomerInventorySearchCtrl : BaseUserControl
    {

        //当前dataGridView_RetailOrder一页显示多少条数据
        private GetPfCustomerInvoicingPara pagePara;
        private List<CostumeStore> costumeStoreList = new List<CostumeStore>();
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl1;
        public CJBasic.Action<DataRowView, GetPfCustomerInvoicingPara, Panel> RowSelected;
        private DataGridViewRow currRow;
        DataMergedView view =  null;
        public CustomerInventorySearchCtrl()
        {
            InitializeComponent(); 
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new String[] {
         deliveryDataGridViewTextBoxColumn.DataPropertyName,
         retailDataGridViewTextBoxColumn.DataPropertyName,
         pfCustomerStoreDataGridViewTextBoxColumn.DataPropertyName
    });
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(deliveryDataGridViewTextBoxColumn, retailDataGridViewTextBoxColumn);
           dataGridViewPagingSumCtrl.Initialize(); 
             dataGridViewPagingSumCtrl.AutoIndex = false;
            Initialize();
            MenuPermission = RolePermissionMenuEnum.客户进销存;
        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        } 

        private void Initialize()
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
            List<ListItem<int>> stateList = new List<ListItem<int>>();
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            skinComboBox_PfCustomer.Initialize(false, true,1);
            SetDisplay();
        }

        private void SetDisplay()
        { 
            if (skinComboBox_PfCustomer.SelectedValue == null && String.IsNullOrEmpty(this.skinTextBox_costumeID.Text))
            {//正常
                if (view != null)
                {
                    this.skinSplitContainer1.Panel1.Controls.Remove(view);
                    view.Dispose(); dataGridViewPagingSumCtrl1.Dispose();
                }
                // view.SendToBack();
                dataGridView1.BringToFront();
                //view.Dispose();
                dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(pfCustomerNameDataGridViewTextBoxColumn);
                dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(costumeIDDataGridViewTextBoxColumn, costumeNameDataGridViewTextBoxColumn,
                    colorNameDataGridViewTextBoxColumn, sizeNameDataGridViewTextBoxColumn);
            }
            else if (!String.IsNullOrEmpty(this.skinTextBox_costumeID.Text) && skinComboBox_PfCustomer.SelectedValue == null)
            {
                view?.BringToFront();
               // dataGridView1.SendToBack(); 
            }
            else if (!String.IsNullOrEmpty(this.skinTextBox_costumeID.Text) && skinComboBox_PfCustomer.SelectedValue != null)
            {
                if (view != null)
                {
                    this.skinSplitContainer1.Panel1.Controls.Remove(view);
                    view.Dispose(); dataGridViewPagingSumCtrl1.Dispose();
                }
                dataGridView1.BringToFront();
                //dataGridView1.Visible = true;
                //view.Visible = false;
                //单独款号的时候
                dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(pfCustomerNameDataGridViewTextBoxColumn);
                dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(costumeIDDataGridViewTextBoxColumn, costumeNameDataGridViewTextBoxColumn,
                    colorNameDataGridViewTextBoxColumn, sizeNameDataGridViewTextBoxColumn);


            }
            else
            {
                if (view != null)
                {
                    this.skinSplitContainer1.Panel1.Controls.Remove(view);
                    view.Dispose(); dataGridViewPagingSumCtrl1.Dispose();
                }
                // view.Dispose();
                //dataGridView1.Visible = true;
                dataGridView1.BringToFront();
               // view.Visible = false;
             //   view.SendToBack();
                //款号和客户都有的时候
                dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(pfCustomerNameDataGridViewTextBoxColumn, colorNameDataGridViewTextBoxColumn, sizeNameDataGridViewTextBoxColumn);
                dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(costumeIDDataGridViewTextBoxColumn, costumeNameDataGridViewTextBoxColumn);

            }
        }

        private void SkinTextBox_costumeID_CostumeSelected(Costume costume, bool isEnter)
        {
            if (costume!=null && isEnter) {
                BaseButton_Search_Click(null, null);
            }
        }


        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            CommonGlobalUtil.Debug("开始查询");
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                string curPfCustomerID="";
                if (skinComboBox_PfCustomer.SelectedValue != null)
                {
                    curPfCustomerID = ValidateUtil.CheckEmptyValue(skinComboBox_PfCustomer.SelectedValue);
                }
                else
                {
                    if (skinComboBox_PfCustomer.Text != "" && skinComboBox_PfCustomer.Text!="所有")
                    {
                        GlobalMessageBox.Show("请输入正确的客户信息后再进行查询！");
                        this.skinComboBox_PfCustomer.Focus();
                        return;
                    }
                }
                

                this.pagePara = new GetPfCustomerInvoicingPara()
                {
                    PfCustomerID = curPfCustomerID,
                    StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value),
                    EndDate = new CJBasic.Date(this.dateTimePicker_End.Value),
                    CostumeID = this.skinTextBox_costumeID.Text,
                };

                //找到对应的大类
                if (!String.IsNullOrEmpty(this.skinTextBox_costumeID.Text) && skinComboBox_PfCustomer.SelectedValue == null)
                {
                    InteractResult<List<PfCustomerInvoicing>> listPage = GlobalCache.ServerProxy.GetPfInvoicingOnlyCostumeID(this.pagePara);
                    this.BindingCostumeStoreDataSource(listPage.Data);
                }
                else
                {
                    InteractResult<List<PfCustomerInvoicing>> listPage = GlobalCache.ServerProxy.GetPfCustomerInvoicing(this.pagePara);
                    this.BindingCostumeStoreDataSource(listPage.Data);
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
            CommonGlobalUtil.Debug("结束查询");
        }
        //存放发货、销售、库存控件
        private List<int> curControlList=new List<int>();
        

        /// <summary>
        /// 绑定CostumeStore数据源
        /// </summary>
        /// <param name="listPage"></param>
        private void BindingCostumeStoreDataSource(List<PfCustomerInvoicing> listPage)
        {
            SetDisplay();
            if (!String.IsNullOrEmpty(this.skinTextBox_costumeID.Text) && skinComboBox_PfCustomer.SelectedValue == null)
            {
                //  this.dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerInvoicing>(DataGridViewUtil.ToDataTable<PfCustomerInvoicing>(listPage));

                //set up columns
                List<PfInvoicingItem> customers = GetCostumerCount(listPage);
                 
                List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
                if (view != null)
                {
                    view.CellContentClick -= this.View1_CellContentClick;
                    this.skinSplitContainer1.Panel1.Controls.Remove(view);
                    view.Dispose();
                    dataGridViewPagingSumCtrl1.Dispose();
                }
                view = new DataMergedView();
                view.CellContentClick += this.View1_CellContentClick;
                view.Name = "autoView";
                view.AllowUserToAddRows = false;
                view.AllowUserToDeleteRows = false;
                view.AllowUserToOrderColumns = true;
                view.AutoGenerateColumns = false;
                view.MultiSelect = false;
                view.ReadOnly = true;
                this.skinSplitContainer1.Panel1.Controls.Add(view);
                view.Dock = DockStyle.Fill;
                DataGridViewTextBoxColumn costumeID = new DataGridViewTextBoxColumn();
                costumeID.DataPropertyName = "CostumeID"; view.Columns.Add(costumeID);
                costumeID.ValueType = typeof(String);
                costumeID.HeaderText = "款号";
                DataGridViewTextBoxColumn costumeName = new DataGridViewTextBoxColumn();
                costumeName.DataPropertyName = "CostumeName";
                costumeName.ValueType = typeof(String);
                view.Columns.Add(costumeName);
                costumeName.HeaderText = "商品名称";
                DataGridViewTextBoxColumn colorName = new DataGridViewTextBoxColumn();
                colorName.DataPropertyName = "ColorName";
                colorName.ValueType = typeof(String);
                view.Columns.Add(colorName);
                colorName.HeaderText = "颜色";
                DataGridViewTextBoxColumn sizeName = new DataGridViewTextBoxColumn();
                sizeName.DataPropertyName = "SizeName";
                sizeName.HeaderText = "尺码";
                sizeName.ValueType = typeof(String);
                view.Columns.Add(sizeName);
                DataGridViewTextBoxColumn delivery = new DataGridViewTextBoxColumn();
                delivery.DataPropertyName = "Delivery";
                delivery.ValueType = typeof(Int32);
                delivery.HeaderText = "发货";
                columns.Add(delivery);
                view.Columns.Add(delivery);
                DataGridViewTextBoxColumn retail = new DataGridViewTextBoxColumn();
                retail.DataPropertyName = "Retail";
                retail.ValueType = typeof(Int32);
                retail.HeaderText = "销售";
                view.Columns.Add(retail);
                columns.Add(retail);
                DataGridViewTextBoxColumn pfCustomerStore = new DataGridViewTextBoxColumn();
                pfCustomerStore.DataPropertyName = "PfCustomerStore";
                pfCustomerStore.HeaderText = "库存";
                pfCustomerStore.ValueType = typeof(Int32);
                view.Columns.Add(pfCustomerStore);
                columns.Add(pfCustomerStore);

                for (int i = 0; i < customers.Count; i++)
                {

                    DataGridViewLinkColumn Delivery = new DataGridViewLinkColumn();
                    Delivery.DataPropertyName = "Delivery" + i;
                    Delivery.ValueType = typeof(Int32);
                    Delivery.HeaderText = "发货";
                    columns.Add(Delivery);
                    view.Columns.Add(Delivery);

                    DataGridViewTextBoxColumn PfCustomerID = new DataGridViewTextBoxColumn();
                    PfCustomerID.DataPropertyName = "PfCustomerID" + i;
                    PfCustomerID.HeaderText = "客户编号";
                    PfCustomerID.ValueType = typeof(String);
                    PfCustomerID.Width = 1;
                    PfCustomerID.Visible = false;
                    view.Columns.Add(PfCustomerID);

                    DataGridViewLinkColumn Retail = new DataGridViewLinkColumn();
                    Retail.DataPropertyName = "Retail" + i;
                    Retail.ValueType = typeof(Int32);
                    Retail.HeaderText = "销售";
                    view.Columns.Add(Retail);
                    columns.Add(Retail);
                    
                    DataGridViewTextBoxColumn PfCustomerStore = new DataGridViewTextBoxColumn();
                    PfCustomerStore.DataPropertyName = "PfCustomerStore" + i;
                    PfCustomerStore.HeaderText = "库存";
                    PfCustomerStore.ValueType = typeof(Int32);
                    view.Columns.Add(PfCustomerStore);
                    columns.Add(PfCustomerStore);



                    //columns.Add(PfCustomerID);

                    curControlList.Add(i);
                }

                //生成 datatable
                var dt = new DataTable(typeof(PfCustomerInvoicing).Name);
                foreach (DataGridViewColumn p in view.Columns)
                {
                    dt.Columns.Add(new DataColumn(p.DataPropertyName, p.ValueType));
                }

                foreach (PfCustomerInvoicing item in listPage)
                {
                    ArrayList tempList = new ArrayList();
                    tempList.Add(item.CostumeID);
                    tempList.Add(item.CostumeName);
                    tempList.Add(item.ColorName);
                    tempList.Add(item.SizeName);
                    tempList.Add(item.Delivery);
                    tempList.Add(item.Retail);
                    tempList.Add(item.PfCustomerStore);
                    if (item != null)
                    {

                        foreach (var customer in customers)
                        {
                            if (item.PfInvoicingItems != null)
                            {
                                PfInvoicingItem pfInvoicing = item.PfInvoicingItems.Find(t => customer.PfCustomerID == t.PfCustomerID);
                                if (pfInvoicing != null)
                                {
                                    tempList.Add(pfInvoicing.Delivery);
                                    tempList.Add(pfInvoicing.PfCustomerID);
                                    tempList.Add(pfInvoicing.Retail);
                                    tempList.Add(pfInvoicing.PfCustomerStore);

                                }
                                else
                                {
                                    tempList.Add(0);
                                    tempList.Add(0);
                                    tempList.Add(0);
                                    tempList.Add(0);
                                }
                            }
                            else {
                                tempList.Add(0);
                                tempList.Add(0);
                                tempList.Add(0);
                               tempList.Add(0);
                            }
                        }
                    }
                    object[] array = tempList.ToArray();
                    dt.LoadDataRow(array, true);

                }
              
                dataGridViewPagingSumCtrl1 = new DataGridViewPagingSumCtrl(view, DataGridViewPagingSumCtrl.GetColumnDataPropertyNames(columns));
                dataGridViewPagingSumCtrl1.Initialize();
                dataGridViewPagingSumCtrl1.BindingDataSource<DataTable>(dt);
                SetSpanInfo(customers);
            }
            else
            {
                this.dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerInvoicing>(DataGridViewUtil.ToDataTable<PfCustomerInvoicing>(listPage));
                
            }
        }


        private void SetSpanInfo(List<PfInvoicingItem> customers)
        {
            view.ClearSpanInfo();
            int i = 0;
            view.ColumnHeadersHeight = 40;
            if (customers.Count > 0)
            {
                //this.view.MergeColumnNames.Add("Column" + (++i));
                this.view.MergeColumnNames.Add("Column" + (++i));
                this.view.MergeColumnNames.Add("Column" + (++i));
                this.view.MergeColumnNames.Add("Column" + (++i));
                this.view.AddSpanHeader((++i), 3,"小计");
                foreach (var customer in customers)
                {
                    this.view.MergeColumnNames.Add("Column" + (i));
                    this.view.MergeColumnNames.Add("Column" + (++i));
                    this.view.MergeColumnNames.Add("Column" + (++i));
                    this.view.MergeColumnNames.Add("Column" + (++i));

                    this.view.AddSpanHeader((i), 4, customer.PfCustomerName);
                  //  this.view.EnableHeadersVisualStyles = false;
                    i++;
                    //this.view.SortMode = DataGridViewColumnSortMode.NotSortable;
                } 
                    //this.view.SortMode
            }
        }

        private List<PfInvoicingItem> GetCostumerCount(List<PfCustomerInvoicing> listPage)
        {
            List<PfInvoicingItem> costumers = new List<PfInvoicingItem>();
            if (listPage != null)
            {
                foreach (var item in listPage)
                {
                    if (item.PfInvoicingItems != null && item.PfInvoicingItems.Count > 0)
                    {
                        foreach (PfInvoicingItem c in item.PfInvoicingItems)
                        {
                            if (costumers.Find(t => t.PfCustomerID == c.PfCustomerID) == null)
                            {
                                costumers.Add(c);
                            }
                        }
                    }
                }
            }
            return costumers;
        }

        Costume costumeItem;
        private void costumeFromSupplierTextBox1_CostumeSelected(Costume costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                this.costumeItem = costumeItem;
            }
        }
        private void View1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            foreach (var cItem in curControlList)
            {
                 
                DataGridViewColumnCollection ColumnsList = view.Columns;

                for (int i=0; i< ColumnsList.Count; i++ )
                {
                   string controlName = "Delivery" + cItem.ToString();
                   DataGridViewLinkColumn curLink = (DataGridViewLinkColumn)view.Columns[controlName];
                    DataGridViewColumn curI = ColumnsList[i];
                    DataTable dt = (DataTable) curI.DataGridView.DataSource;
                    int t = e.ColumnIndex;
                    int p = curI.Index;
                    if (curI.DataPropertyName == controlName && e.ColumnIndex == curI.Index)
                    {
                        if (e.RowIndex >=0)
                        {
                            sendOutGoodDetailForm form = new sendOutGoodDetailForm();
                            DataRow item = dt.Rows[e.RowIndex];
                            GetPfInvoicingPara changePara = new GetPfInvoicingPara();
                            //  ReflectionHelper.CopyProperty(this.pagePara, changePara);
                            // string headList = this.view.MergeColumnNames[0];
                            //this.view.MergeColumnNames[]
                            changePara.CostumeID = item["CostumeID"].ToString();
                            changePara.PfCustomerID = item["PfCustomerID" + cItem].ToString();
                            changePara.SizeName = item["SizeName"].ToString();
                            changePara.ColorName = item["ColorName"].ToString();
                            changePara.StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value);
                            changePara.EndDate = new CJBasic.Date(this.dateTimePicker_End.Value);
                            
                            form.ShowDialog(changePara);
                        }
                    }
                    string controlName1 = "Retail" + cItem.ToString();
                    DataGridViewLinkColumn curLink1 = (DataGridViewLinkColumn)view.Columns[controlName1];
                    DataGridViewColumn curI1 = ColumnsList[i];
                    if (curI1.DataPropertyName == controlName1 && e.ColumnIndex == curI1.Index)
                    {
                        if (e.RowIndex>=0)
                        {
                            CustomSaleGoodDetailForm form = new CustomSaleGoodDetailForm();
                            DataRow item = dt.Rows[e.RowIndex];
                            GetPfInvoicingPara changePara = new GetPfInvoicingPara();
                            //  ReflectionHelper.CopyProperty(this.pagePara, changePara);

                            changePara.CostumeID = item["CostumeID"].ToString();
                            changePara.PfCustomerID = item["PfCustomerID" + cItem].ToString();
                            changePara.SizeName = item["SizeName"].ToString();
                            changePara.ColorName = item["ColorName"].ToString();
                            changePara.StartDate = new CJBasic.Date(this.dateTimePicker_Start.Value);
                            changePara.EndDate = new CJBasic.Date(this.dateTimePicker_End.Value);
                            form.ShowDialog(changePara);
                        }
                    }
                  /*  string controlName2 = "PfCustomerStore" + cItem.ToString();
                    DataGridViewLinkColumn curLink2 = (DataGridViewLinkColumn)view.Columns[controlName2];
                    DataGridViewColumn curI2 = ColumnsList[i];
                    if (curI1.DataPropertyName == controlName2 && e.ColumnIndex == curI2.Index)
                    {

                        int j = 0;
                    }*/

                } 
                

                //if (e.ColumnIndex == curLink.Index)
                //{

                //}
               
                //DataGridViewLinkColumn curLink1 = (DataGridViewLinkColumn)view.Columns[controlName];
                //if (e.ColumnIndex == curLink1.Index)
                //{

                //}
                //string controlName2 = "PfCustomerStore" + cItem.ToString();
                //DataGridViewLinkColumn curLink2 = (DataGridViewLinkColumn)view.Columns[controlName];
                //if (e.ColumnIndex == curLink2.Index)
                //{

                //}
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                if (e.ColumnIndex == deliveryDataGridViewTextBoxColumn.Index)
                {
                    try
                    {
                        if (CommonGlobalUtil.EngineUnconnectioned(this))
                        {
                            return;
                        }

                        //发货明细
                        //  GetPfInvoicingPara

                        sendOutGoodDetailForm form = new sendOutGoodDetailForm();
                     DataTable dt = (DataTable)this.dataGridView1.DataSource;

                     DataRow item = dt.Rows[e.RowIndex];
                     GetPfInvoicingPara changePara = new GetPfInvoicingPara();
                     ReflectionHelper.CopyProperty(this.pagePara, changePara);
                    
                     changePara.CostumeID = item["CostumeID"].ToString();
                    changePara.PfCustomerID = item["PfCustomerID"].ToString();
                    changePara.SizeName = item["SizeName"].ToString();
                    changePara.ColorName= item["ColorName"].ToString();
                    changePara.StartDate = changePara.StartDate;
                     changePara.EndDate = changePara.EndDate;
                     form.ShowDialog(changePara);
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
                if (e.ColumnIndex == retailDataGridViewTextBoxColumn.Index )
                  {
                    //销售明细
                    try
                    {
                        if (CommonGlobalUtil.EngineUnconnectioned(this))
                        {
                            return;
                        }
                        CustomSaleGoodDetailForm form = new CustomSaleGoodDetailForm(); 
                      DataTable dt = (DataTable)this.dataGridView1.DataSource;
                      DataRow item = dt.Rows[e.RowIndex];
                    GetPfInvoicingPara changePara = new GetPfInvoicingPara();
                      ReflectionHelper.CopyProperty(this.pagePara, changePara); 

                    changePara.CostumeID = item["CostumeID"].ToString();
                    changePara.PfCustomerID = item["PfCustomerID"].ToString();
                    changePara.SizeName = item["SizeName"].ToString(); 
                    changePara.ColorName = item["ColorName"].ToString();
                    changePara.StartDate = changePara.StartDate;
                      changePara.EndDate = changePara.EndDate;
                      form.ShowDialog(changePara);
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

            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }
        }

        String path;
        private void baseButton1_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "客户进销存" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
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
                DataTable list =null;
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                if (this.skinTextBox_costumeID.SkinTxt.Text.Trim() != "" && ValidateUtil.CheckEmptyValue(this.skinComboBox_PfCustomer.SelectedValue)=="")
                {
                    var dt = new DataTable(typeof(PfCustomerInvoicing).Name);
                    foreach (DataGridViewColumn p in view.Columns)
                    {
                        if (!p.DataPropertyName.Contains("PfCustomerID"))
                        {
                            keys.Add(p.DataPropertyName);

                            if (p.DataPropertyName == "Delivery" || p.DataPropertyName == "Retail" || p.DataPropertyName == "PfCustomerStore")
                            {
                                values.Add("小计" + p.HeaderText);
                            }
                            else if ((p.DataPropertyName.Contains("Delivery") && p.DataPropertyName != "Delivery")
                                || (p.DataPropertyName.Contains("Retail") && p.DataPropertyName != "Retail")
                                || p.DataPropertyName.Contains("PfCustomerStore") && p.DataPropertyName != "PfCustomerStore")
                            {
                                /*   int CurColumnindex = -1;
                                   if (p.DataPropertyName.Contains("Delivery"))
                                   {
                                       CurColumnindex= p.Index + 1;
                                   }*/

                                DataTable curdt = p.DataGridView.DataSource as DataTable;

                                string pfcustomerId = curdt.Rows[0]["PfCustomerID" + p.DataPropertyName.Replace("PfCustomerStore", "").Replace("Retail", "").Replace("Delivery", "")].ToString();
                                if (pfcustomerId == "0")
                                {
                                    for(int i=0;i<curdt.Rows.Count;i++)
                                    {
                                        if (curdt.Rows[i]["PfCustomerID" + p.DataPropertyName.Replace("PfCustomerStore", "").Replace("Retail", "").Replace("Delivery", "")].ToString()!="0")
                                        {
                                            pfcustomerId = curdt.Rows[i]["PfCustomerID" + p.DataPropertyName.Replace("PfCustomerStore", "").Replace("Retail", "").Replace("Delivery", "")].ToString();
                                            break;
                                        }
                                    }
                                }
                                string CName = PfCustomerCache.PfCustomerList.Find(t => t.ID.Equals(pfcustomerId)).Name;
                                values.Add(CName + p.HeaderText);
                            }
                            else
                            {
                                values.Add( p.HeaderText);
                            }
                        }
                    }
                    list = (DataTable)view.DataSource;
                }
                else
                {
                    if (dataGridView1.DataSource != null && dataGridView1.Rows.Count > 0)
                    {
                         list = (DataTable)this.dataGridView1.DataSource;
                        foreach (DataGridViewColumn item in dataGridView1.Columns)
                        {
                            if (item.Visible)
                            {
                                keys.Add(item.DataPropertyName);
                                values.Add(item.HeaderText);

                            }
                        }




                    }
                }

                NPOIHelper.Keys = keys.ToArray();
                NPOIHelper.Values = values.ToArray();
                NPOIHelper.ExportExcel(list, path);

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
