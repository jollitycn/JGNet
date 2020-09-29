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
using JGNet.Common;
using JGNet.Core;
using CCWin.SkinControl;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using CJPlus;
using JieXi.Common;
using CJBasic;
using JGNet.Manage;
using JGNet.Common.cache.Wholesale;

namespace JGNet.Common
{
    public partial class WholesaleCustomeStoreCtrl_old : BaseModifyUserControl
    {

        private string shopID;
        //当前dataGridView_RetailOrder一页显示多少条数据
        private GetPfCustomerStorePagePara pagePara;
        private List<PfCustomerStore> costumeStoreList = new List<PfCustomerStore>();
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public WholesaleCustomeStoreCtrl_old()
        {
            InitializeComponent();

            MenuPermission = RolePermissionMenuEnum.客户库存;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1,
                new string[] {
                     xSDataGridViewTextBoxColumn.DataPropertyName,
       sDataGridViewTextBoxColumn.DataPropertyName,
       mDataGridViewTextBoxColumn.DataPropertyName,
       lDataGridViewTextBoxColumn.DataPropertyName,
       xLDataGridViewTextBoxColumn.DataPropertyName,
    xL2DataGridViewTextBoxColumn.DataPropertyName,
         xL3DataGridViewTextBoxColumn.DataPropertyName,
       xL4DataGridViewTextBoxColumn.DataPropertyName,
         xL5DataGridViewTextBoxColumn.DataPropertyName,
        xL6DataGridViewTextBoxColumn.DataPropertyName,
        fDataGridViewTextBoxColumn.DataPropertyName,
        SumCount.DataPropertyName,
        SumPfMoney.DataPropertyName
          });
            dataGridViewPagingSumCtrl.Initialize();
            // dataGridViewPagingSumCtrl.SpecAutoSizeMode(new TKeyValue<DataGridViewColumn, DataGridViewAutoSizeColumnMode>(Remarks, DataGridViewAutoSizeColumnMode.ColumnHeader));

        }  
        private void Initialize()
        {
            CommonGlobalUtil.SetBrand(skinComboBox_Brand);
            skinComboBoxSupplier.Initialize(false, true,1);
            this.CostumeCurrentShopTextBox1.Text = string.Empty;

            SetDisplay();
            BindingCostumeStoreDataSource(null);
        }

        private void ImageCtrl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.skinCheckBoxShowImage.Checked = false;
        }

        /// <summary>
        ///  根据平台内容显示
        /// </summary>
        private void SetDisplay()
        {

            SetColumnDisplay();
        }


        private void Search()
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {

                    return;
                }


                PfCustomerStorePage listPage = GlobalCache.ServerProxy.GetPfCustomerStorePage(this.pagePara);
                SetColumnDisplay();
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingCostumeStoreDataSource(listPage);

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

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            this.skinCheckBoxShowImage.Checked = false;
            BuildPara();
            Search();
        }


        /// <summary>
        /// 绑定CostumeStore数据源
        /// </summary>
        /// <param name="listPage"></param>
        private void BindingCostumeStoreDataSource(PfCustomerStorePage listPage)
        {
            this.dataGridView1.DataSource = null;
            this.costumeStoreList.Clear();
            if (listPage != null && listPage.PfCustomerStores != null)
            {
                foreach (PfCustomerStore store in listPage.PfCustomerStores)
                {
                    Costume costume = CommonGlobalCache.GetCostume(store.CostumeID);
                    if (costume != null)

                    {
                        store.PfCustomerName = PfCustomerCache.GetPfCustomerName(store.PfCustomerID);
                        store.CostumeName = costume.Name;
                        store.Remarks = costume.Remarks;
                    }
                    this.costumeStoreList.Add(store);

                }
                if (this.costumeStoreList != null && this.costumeStoreList.Count > 0)
                {
                    this.dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerStore>(DataGridViewUtil.ToDataTable<PfCustomerStore>(costumeStoreList));
                }
            }
            this.dataGridView1.Refresh();
        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pagePara = new GetPfCustomerStorePagePara();
           this.dataGridViewPagingSumCtrl.Initialize(1);
        }

        private void CostumeStoreSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void CostumeCurrentShopTextBox1_CostumeSelected(Costume costume, bool isEnter)
        {
            if (isEnter)
            {
                if (costume != null)
                {
                    this.BaseButton_Search_Click(null, null);
                }
            }
        }


        private void skinCheckBox_ShowPrice_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SetColumnDisplay()
        {
            this.CostPrice.Visible = skinCheckBox_ShowPrice.Checked;
            this.SumPfMoney.Visible = skinCheckBox_ShowPrice.Checked;
        }


        public void WorkDeskCtrlSearch()
        {
            this.skinCheckBox1.Checked = true;
            BuildPara();
            Search();
        }

        private void BuildPara()
        {
            string costumeID = string.IsNullOrEmpty(this.CostumeCurrentShopTextBox1.SkinTxt.Text.Trim()) ? null : this.CostumeCurrentShopTextBox1.SkinTxt.Text.Trim();
            bool isOnlyShowHaveNegative = this.skinCheckBox1.Checked;
            string curBrandStr = ValidateUtil.CheckEmptyValue(this.skinComboBox_Brand.SelectedValue);
            int curBrandID = 0;
            if (curBrandStr == null)
            {
                curBrandID = 0;
            }
              curBrandID = Convert.ToInt32(curBrandStr);
            string curPfCustomerID = "";
            if (skinComboBoxSupplier.SelectedValue != null)
            {
                curPfCustomerID = ValidateUtil.CheckEmptyValue(skinComboBoxSupplier.SelectedValue);
            }
            else
            {
                if (skinComboBoxSupplier.Text != ""&& skinComboBoxSupplier.Text != "所有")
                {
                    GlobalMessageBox.Show("请输入正确的客户信息后再进行查询！");
                    this.skinComboBoxSupplier.Focus();
                    return;
                }
            }

            this.pagePara = new GetPfCustomerStorePagePara()
            {
                CostumeID = costumeID,
                BrandID = curBrandID,
                PfCustomerID = curPfCustomerID,
                PageIndex = 0,
                PageSize = int.MaxValue,// this.dataGridViewPagingSumCtrl.PageSize,
                 
                IsOnlyShowNotZero = isOnlyShowHaveNegative,
            };
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            String headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            if (headerText == "批发总额" || headerText == "批发价" || headerText == "总成本" || headerText == "成本价" || headerText == "总价值" || headerText == "吊牌价")
            {
                return;
            }
            if (e.Value != null && e.Value.ToString() == "0")
            {
                e.Value = string.Empty;
            }


        }

        SingleImageForm imageCtrl;
        private void skinCheckBoxShowImage_CheckedChanged(object sender, EventArgs e)
        {
            if (skinCheckBoxShowImage.Checked)
            {
                dataGridView1_SelectionChanged(sender, e);
            }
            else
            {
                imageCtrl?.Close();
            }
        }

        DataRowView curCostume;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    if (CommonGlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }

                    DataRowView item = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                    if (curCostume != item && skinCheckBoxShowImage.Checked)
                    {
                        if (imageCtrl != null) {
                            imageCtrl?.Close();
                            imageCtrl = null;
                        }
                        imageCtrl = new SingleImageForm();
                        imageCtrl.FormClosing += ImageCtrl_FormClosing; 
                        imageCtrl.Text = "款号：" + item["CostumeID"];
                        imageCtrl.OnLoadingState();
                        skinCheckBoxShowImage.CheckedChanged -= skinCheckBoxShowImage_CheckedChanged;
                        skinCheckBoxShowImage.Checked = true;
                        skinCheckBoxShowImage.CheckedChanged += skinCheckBoxShowImage_CheckedChanged;

                        byte[] bytes = CommonGlobalCache.ServerProxy.GetCostumePhoto(item["CostumeID"].ToString());
                        if (bytes != null)
                        {
                            imageCtrl.Image = CCWin.SkinControl.ImageHelper.Convert(bytes);
                        }
                        else
                        {
                            imageCtrl.Image = null;
                        }
                        imageCtrl?.BringToFront();
                        imageCtrl?.Show();
                        curCostume = item;
                    }
                }
                catch (Exception ex)
                {
                   // ShowError(ex);
                }
                finally
                {
                    UnLockPage();
                }
            }
        }
    }
}
