using CCWin;
using CCWin.SkinControl;
using JGNet.Core.InteractEntity;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JGNet.Core; 
using JGNet.Core.Tools;
using CJBasic.Loggers; 
using System.Reflection;
using JGNet.Common.Components;
using JGNet.Common;

namespace JGNet.Manage.Pages
{
    //继承DIALOGform,设置界面不闪动
    public partial class SalesPromotionCostumeSelectForm : BaseForm
    {


        private List<Costume> targets;
        private List<Costume> queryResults;

        private CostumeListPagePara pagePara;

        private bool filterValid { get; set; }
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public TKeyValue<Boolean, List<Costume>> Result
        {
            get
            {
                TKeyValue<Boolean, List<Costume>> result = new TKeyValue<bool, List<Costume>>(this.skinCheckBoxJoin.Checked, this.targets);
                return result;
            }
        }

        public SalesPromotionCostumeSelectForm(JGNet.SalesPromotion curItem, PromotionTypeEnum curType, bool isSalesPromotionUse, bool filterValid)
        {
            try
            {
                InitializeComponent();
                this.filterValid = filterValid;
                dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridViewQueryResults, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, this.BaseButton_Search_Click);
                dataGridViewPagingSumCtrl.Initialize();
                dataGridViewQueryResults.MultiSelect = true;
                this.dataGridViewQueryResults.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                new DataGridViewPagingSumCtrl(this.dataGridViewTarget).Initialize();
           


                dataGridViewTarget.MultiSelect = true;
                this.dataGridViewTarget.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

                if (curType == PromotionTypeEnum.YKJ)
                { 
                    dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(dataGridViewTextBoxColumnYear, dataGridViewTextBoxColumnSeason);
                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(CostPrice, Price);
                }
                else
                { 
                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(dataGridViewTextBoxColumnYear, dataGridViewTextBoxColumnSeason);
                    dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(CostPrice, Price);
                }
                if (curItem != null)
                {

                    if (curType == PromotionTypeEnum.YKJ)
                    {
                        SetBuyout(curItem);  
                    }
                    else
                    {
                        SetNormal(curItem);
                    }

                    this.skinCheckBoxJoin.Checked = curItem.ContainsSpecify;
                    if (!String.IsNullOrEmpty(curItem.ID) && isSalesPromotionUse)
                    {
                        this.skinPanelQuery.Enabled = false;
                        this.groupBoxQueryResult.Enabled = false;
                        this.skinPanelSelectBtn.Enabled = false;
                        this.skinPanelCheck.Enabled = false;
                    }
                }

                try
                {
                    SetYear();
                //    CommonGlobalUtil.SetSupplier(skinComboBoxSupplierID);
                    SetParameterConfig();
                    GlobalUtil.SetBrand(skinComboBox_Brand);
                    //skinComboBox_Brand.Initialize();
                }
                catch (Exception ex)
                {
                    CommonGlobalUtil.ShowError(ex);
                }
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void SetBuyout(SalesPromotion curItem)
        {

            if (!String.IsNullOrEmpty(curItem.CostumeIDStr))
            {
                this.targets = new List<Costume>();
                String[] buyoutRangeRule = curItem.RuleExpression.Split(';');
                String[] buyoutRange = curItem.CostumeIDStr.Split(';');

                for (int i = 0; i < buyoutRange.Length; i++)
                {
                    // var cos in buyoutRange
                    String cos = buyoutRange[i];
                    String buyoutPrice = buyoutRangeRule[i]==""?"0" : buyoutRangeRule[i];
                    String[] ids = cos.Split(',');

                    foreach (var id in ids)
                    {
                        Costume item = CommonGlobalCache.CostumeList.Find(t => t.ID == id);

                        if (item != null)
                        {
                            item.BuyoutPrice = Convert.ToDecimal(buyoutPrice);
                            if (filterValid)
                            {
                                if (item.IsValid)
                                {
                                    targets.Add(item);
                                }
                            }
                            else
                            {
                                targets.Add(item);
                            }
                        }
                    }
                }

                this.dataGridViewTarget.DataSource = targets;
            }
            
            dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(dataGridViewTextBoxColumnYear, dataGridViewTextBoxColumnSeason);
            dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(CostPrice, Price); 
        }

        private void SetNormal(SalesPromotion curItem)
        {
            if (!String.IsNullOrEmpty(curItem.CostumeIDStr))
            {
                this.targets = new List<Costume>();
                String[] ids = curItem.CostumeIDStr.Split(',');

                foreach (var id in ids)
                {
                    Costume item = CommonGlobalCache.CostumeList.Find(t => t.ID == id);
                    if (item != null)
                    {
                        if (filterValid)
                        {
                            if (item.IsValid)
                            {
                                targets.Add(item);
                            }
                        }
                        else
                        {
                            targets.Add(item);
                        }
                    }
                }
                this.dataGridViewTarget.DataSource = targets;

            }
            dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(dataGridViewTextBoxColumnYear, dataGridViewTextBoxColumnSeason);
            dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(CostPrice, Price); 
        }

        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            if (this.pagePara == null)
            {
                return;
            }
            pagePara.PageIndex = index;
            CostumeListPage list = CommonGlobalCache.ServerProxy.GetCostumeListPage(this.pagePara);
            this.BindingDataSource(list);
        }

        private void BaseButtonRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.targets = null;
                this.dataGridViewTarget.DataSource = null;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void BaseButtonAddAll_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTargets();
                if (queryResults != null)
                {
                    foreach (var item in queryResults)
                    {
                        if (!targets.Exists(x => x.ID == item.ID))
                        {
                            targets.Add(item);
                        }
                    }
                }
                this.dataGridViewTarget.DataSource = null;
                this.dataGridViewTarget.DataSource = targets;

            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void CheckTargets()
        {
            if (targets == null)
            {
                targets = new List<Costume>();
            }
            else
            {
                targets = (List<Costume>)this.dataGridViewTarget.DataSource;
            }
        }

        private void BaseButtonAddSingle_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTargets();
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewCell item in this.dataGridViewQueryResults.SelectedCells)
                {
                    if (!rows.Exists(t => t == item.OwningRow))
                    {
                        rows.Add(item.OwningRow);
                    }
                }
                IEnumerable<DataGridViewRow> selectedRows = rows;
                foreach (DataGridViewRow item in selectedRows)
                {
                    Costume c = (Costume)item.DataBoundItem;

                    if (!targets.Exists(x => x.ID == c.ID))
                    {
                        targets.Add(c);
                    }
                }
                this.dataGridViewTarget.DataSource = null;
                this.dataGridViewTarget.DataSource = targets;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void BaseButtonRemoveSingle_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.targets == null)
                {
                    return;
                }

                List<Costume> costumes = new List<Costume>();
                foreach (DataGridViewCell item in this.dataGridViewTarget.SelectedCells)
                {
                    if (!costumes.Exists(t => t == item.OwningRow.DataBoundItem))
                    {
                        costumes.Add(item.OwningRow.DataBoundItem as Costume);
                    }
                }

                foreach (var item in costumes)
                {
                    this.targets.Remove(item);
                }

                this.dataGridViewTarget.DataSource = null;
                this.dataGridViewTarget.DataSource = targets;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }

        }

        /// <summary>
        /// 设置系统配置参数信息，品牌、风格、款型
        /// </summary>
        private void SetParameterConfig()
        {
            this.skinComboBoxSeason.DataSource = ParameterConfigList(CommonGlobalCache.GetParameterConfig(ParameterConfigKey.Season));
            this.skinComboBoxSeason.DisplayMember = "Key";
            this.skinComboBoxSeason.ValueMember = "Value";
        }

        private List<ListItem<String>> ParameterConfigList(List<ListItem<String>> listItems)
        {
            List<ListItem<String>> list = new List<ListItem<String>>();
            list.Add(new ListItem<String>(CommonGlobalUtil.COMBOBOX_ALL, null));
            list.AddRange(listItems);
            return list;
        }
         

        private void SetYear()
        {
            List<ListItem<int>> list = new List<ListItem<int>>();
            list.Add(new ListItem<int>(CommonGlobalUtil.COMBOBOX_ALL, -1));
            List<int> years = YearHelper.GetYearList(DateTime.Now);
            foreach (int item in years)
            {
                list.Add(new ListItem<int>(item.ToString(), item));

            }
            this.skinComboBoxYear.DataSource = list;
            this.skinComboBoxYear.DisplayMember = "key";
            this.skinComboBoxYear.ValueMember = "value";
        }
        
        private void BaseButton_Search_Click(object sender, EventArgs e)
        {

            try
            {

                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                this.pagePara = new CostumeListPagePara()
                {
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    CostumeID = this.costumeTextBox1.SkinTxt.Text
                };

                if (((ListItem<String>)this.skinComboBoxSeason.SelectedItem).Value != null)
                {
                    this.pagePara.Season = ((ListItem<String>)this.skinComboBoxSeason.SelectedItem).Key;
                }
                this.pagePara.BrandID = (this.skinComboBox_Brand.SelectedValue != null && int.Parse(this.skinComboBox_Brand.SelectedValue.ToString()) != -1) ? int.Parse(this.skinComboBox_Brand.SelectedValue.ToString()) : -1;
                this.pagePara.ClassID = skinComboBoxBigClass.SelectedValue.ClassID;
                //   this.pagePara.SubSmallClass = this.skinComboBoxBigClass.SelectedValue?.SubSmallClass;
                this.pagePara.SupplierID = this.skinComboBoxSupplierID.SelectedValue != null ? this.skinComboBoxSupplierID.SelectedValue.ToString() : null;
                if (this.skinComboBoxYear.SelectedValue != null)
                {
                    String year = this.skinComboBoxYear.SelectedValue.ToString();


                    if (!String.IsNullOrEmpty(year))
                    {
                        this.pagePara.Year = int.Parse(year);
                    }
                }
                this.pagePara.IsQueryValid = IsQueryValid.True;

                CostumeListPage list = CommonGlobalCache.ServerProxy.GetCostumeListPage(this.pagePara);

                //      this.dataGridViewPagingSumCtrl.Initialize(list);
                this.BindingDataSource(list);

            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }
        private void BindingDataSource(CostumeListPage listPage)
        {
            if (listPage != null && listPage.CostumeList.Count > 0)
            {
                foreach (var item in listPage.CostumeList)
                {
                    item.BuyoutPrice = item.Price;
                }
            }
            this.SetOtherValue(listPage.CostumeList);
            this.queryResults = listPage.CostumeList;
            this.dataGridViewPagingSumCtrl.BindingDataSource(listPage?.CostumeList, null, listPage?.TotalEntityCount);
        }


        /// <summary>
        /// 将集合中GuideName赋值
        /// </summary>
        /// <param name="memberList"></param>
        private void SetOtherValue(List<Costume> list)
        {
            foreach (Costume item in list)
            {
                String name = CommonGlobalCache.GetSupplierName(item.SupplierID);
                item.SupplierName = name;
                item.BrandName = CommonGlobalCache.GetBrandName(item.BrandID);
            }
        }

        private void SalesPromotionCostumeSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void BaseButton2_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void skinCheckBoxUnJoin_CheckedChanged(object sender, EventArgs e)
        {
            this.skinCheckBoxJoin.Checked = !this.skinCheckBoxUnJoin.Checked;
        }

        private void skinCheckBoxJoin_CheckedChanged(object sender, EventArgs e)
        {
            this.skinCheckBoxUnJoin.Checked = !this.skinCheckBoxJoin.Checked;
        }


        private void skinComboBox_Brand_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                List<Brand> listNew = new List<Brand>();
                //  skinComboBox_Brand.Items.Clear();
                SkinComboBox box = (SkinComboBox)sender;
                String str = box.Text;
                foreach (var item in CommonGlobalCache.BrandList)
                {
                    if ((item.Name + item.FirstCharSpell).ToUpper().Contains(str.ToUpper()))
                    {
                        listNew.Add(item);
                    }
                }
                if (String.IsNullOrEmpty(str) || listNew.Count == 0)
                {
                    listNew = new List<Brand>();
                    listNew.Add(new Brand() { Name = CommonGlobalUtil.COMBOBOX_ALL, AutoID = -1 });
                    listNew.AddRange(CommonGlobalCache.BrandList);
                }
                box.DataSource = listNew;
                box.SelectedIndex = 0;
                //box.Text = str;
                box.SelectionStart = str.Length;
                box.DroppedDown = true;//自动展开下拉框
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void dataGridViewQueryResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BaseButtonAddSingle_Click(sender, e);
        }

        private void dataGridViewTarget_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BaseButtonRemoveSingle_Click(sender, e);
        }

        private void dataGridViewTarget_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                if (e.ColumnIndex != CostPrice.Index)
                {
                    return;
                }

                int newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Convert.ToInt32(e.FormattedValue);
                }
                if (newCount < 0)
                {
                    GlobalMessageBox.Show("成本价不能小于0！");
                    this.dataGridViewTarget.CancelEdit();
                    return;
                }
                //  }
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex, "输入格式错误");

                this.dataGridViewTarget.CancelEdit();
                return;
            }
        }
    }
}
