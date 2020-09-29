using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using JGNet.Core.InteractEntity; 
using System.Collections;
using CCWin.SkinControl;

using JGNet.Core;
using JGNet.Manage.Pages.RuleSettings.SalesPromotion;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using CJBasic.Helpers;
using JGNet.Common;

namespace JGNet.Manage.Pages
{
    /// <summary>
    /// 编辑促销规则
    /// </summary>
    public partial class SaveSalesPromotionCtrl : BaseModifyUserControl
    {

        private TKeyValue<bool, List<Costume>> costumeResult;
        private UserControl ruleCtrl; 
      
        private SalesPromotion tempItem = null;
        private SalesPromotion curItem = null;
        private bool isSalesPromotionUse = false;

        private bool filterValid = true;
        public bool FilterValid
        {
            get { return filterValid; }
            set
            {
                filterValid = value;
            }
        }

        public SaveSalesPromotionCtrl( SalesPromotion item )
        {
            InitializeComponent();
           DateTimeUtil.DateTimePicker_GetTodayAndAfterAMonth(dateTimePickerBeginDate, dateTimePickerEndDate);
            new DataGridViewPagingSumCtrl(this.dataGridViewShop).Initialize();
            this.dataGridViewShop.AutoGenerateColumns = false;
            this.curItem = item;
            if (this.curItem != null)
            {
                this.isSalesPromotionUse = this.IsSalesPromotionUse();
                skinLabel4.Visible = true;
            }
            else {
                skinLabel4.Visible = false;
            }

            try
            { 
                List<Shop> listItem = new List<Shop>();
                foreach (var shop in GlobalCache.EnabledShopList)
                {
                    Shop shopTemp = new Shop();
                    ReflectionHelper.CopyProperty(shop, shopTemp);
                    shopTemp.Selected = false;
                    listItem.Add(shopTemp);
                }

                //   this.dataGridViewShop.DataSource = null;
                this.dataGridViewShop.DataSource = listItem;
                List<ListItem<PromotionTypeEnum>> types = new List<ListItem<PromotionTypeEnum>>();
                types.AddRange(GlobalCache.PromotionTypeEnumList);
                types.RemoveAt(0);
                this.skinComboBoxPromotionType.DisplayMember = "Key";
                this.skinComboBoxPromotionType.ValueMember = "Value";
                this.skinComboBoxPromotionType.DataSource = types;

                Display();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }


        }

        private void SaveSalesPromotionCtrl_Load(object sender, EventArgs e)
        {
        }

        private bool Validate(SalesPromotion item) {
            bool success = true;
            if (String.IsNullOrEmpty(item.Name.Trim())) {
                this.skinTextBox_Name.Focus();
                success = false;
            }
            return success;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (curItem == null)
                {
                    SalesPromotion item = new SalesPromotion() { };

                    SetItem(item);
                    if (!Validate(item)) { return; }
                    item.CreateTime = DateTime.Now;
                    item.ID = IDHelper.GetID(OrderPrefix.SalesPromotion, OrderPrefix.ShopCode4Admin);
                    InsertResult result = GlobalCache.ServerProxy.InsertSalesPromotion(item);
                    switch (result)
                    {
                        case InsertResult.Error:
                            GlobalMessageBox.Show("内部错误！");
                            break;
                        default:
                            CommonGlobalCache.InsertSalesPromotion(item);
                            GlobalMessageBox.Show("添加成功！");

                            TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                    }
                }
                else
                {
                    SetItem(curItem);
                    if (!Validate(curItem)) { return; }
                    UpdateResult result = GlobalCache.ServerProxy.UpdateSalesPromotion(curItem);
                    switch (result)
                    {
                        case UpdateResult.Error:
                            GlobalMessageBox.Show("内部错误！");
                            break;
                        default: 
                            CommonGlobalCache.UpdateSalesPromotion(curItem);
                            GlobalMessageBox.Show("保存成功！");
                            TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void SetUpCostume(SalesPromotion item)
        {
            if (costumeResult != null)
            {
                item.ContainsSpecify = costumeResult.Key;
                List<Costume> list = costumeResult.Value;

                String str = "";
                if (list != null)
                {
                    foreach (var c in list)
                    {
                        str += c.ID + ",";
                    }
                    if (!String.IsNullOrEmpty(str))
                    {
                        str = str.Remove(str.LastIndexOf(","));
                    }
                }
                item.CostumeIDStr = str;
            }
            //现在一直是true
            item.ContainsSpecify = true;
        }

        private void SetItem(SalesPromotion item)
        {
            item.Name = this.skinTextBox_Name.SkinTxt.Text.Trim();
            item.PromotionType = Byte.Parse(((int)this.skinComboBoxPromotionType.SelectedValue).ToString());
            item.Enabled = this.skinCheckBox_Enabled.Checked;
            item.EndDate = this.dateTimePickerEndDate.Value;
            item.StartDate = this.dateTimePickerBeginDate.Value;
            item.Remarks = this.skinTextBox_Remarks.SkinTxt.Text.Trim();
            if (item.PromotionType == (int)PromotionTypeEnum.YKJ)
            {
                SetBuyoutRules(item);
            }
            else
            {
                item.RuleExpression = GetRules();
                SetUpCostume(item);
            }

            item.ShopIDStr = GetShopIDStr();
            item.Name = this.skinTextBox_Name.SkinTxt.Text.Trim(); 
           
            item.IsValid = true;
        }

        private void SetBuyoutRules(SalesPromotion item)
        {
            //获取所有相同价格，并且赋予RuleExpression 
            String costumeStr = string.Empty;
            String ruleExp = string.Empty;
            if (costumeResult != null)
            {
                List<Costume> list = costumeResult.Value;
                Dictionary<decimal, List<Costume>> hashTable = new Dictionary<decimal, List<Costume>>();

                foreach (var costume in list)
                {
                    if (!hashTable.ContainsKey(costume.BuyoutPrice))
                    {
                        List<Costume> costumes = new List<Costume>();
                        costumes.Add(costume);
                        hashTable.Add(costume.BuyoutPrice, costumes);
                    }
                    else
                    {
                        List<Costume> costumes = hashTable[costume.BuyoutPrice];
                        costumes.Add(costume);
                    }
                }

                foreach (decimal key in hashTable.Keys)
                {
                    ruleExp += key + ";";
                    String keyValue = string.Empty;
                    foreach (var cos in hashTable[key])
                    {
                        keyValue += cos.ID + ",";
                    }
                    if (keyValue.Length > 0)
                    {
                        keyValue = keyValue.Remove(keyValue.LastIndexOf(","));
                    }

                    costumeStr += keyValue + ";";
                }
                if (ruleExp.Length > 0)
                {
                    ruleExp = ruleExp.Remove(ruleExp.LastIndexOf(";"));
                }
                if (costumeStr.Length > 0)
                {
                    costumeStr = costumeStr.Remove(costumeStr.LastIndexOf(";"));
                }
                item.RuleExpression = ruleExp;
                item.CostumeIDStr = costumeStr;
            }

            //现在一直是true
            item.ContainsSpecify = true;
        }

        private String GetRules()
        {
            String rules = "";
            List<TKeyValue<decimal, decimal>> ruleResults = new List<TKeyValue<decimal, decimal>>();
            if (this.ruleCtrl.GetType().Equals(discountRuleCtrl1.GetType()))
            {

                ruleResults = discountRuleCtrl1.Result;
            }
            else { ruleResults = mjRuleCtrl1.Result; }

            if (ruleResults != null)
            {
                foreach (var item in ruleResults)
                {
                    rules += item.Key + "-" + item.Value + ",";
                }
            }
            if (rules.Length > 0)
            {
                rules = rules.Remove(rules.LastIndexOf(","));
            }

            return rules; 
        }

        private string GetShopIDStr()
        {
            String shopIDStr = "";
            List<Shop> shops = (List< Shop>) this.dataGridViewShop.DataSource;
            foreach (var item in shops)
            {
                if (item.Selected) {
                    shopIDStr += item.ID +",";
                }

            }
            if (shopIDStr.Length > 0) {
                shopIDStr = shopIDStr.Remove(shopIDStr.LastIndexOf(","));
            }
            return shopIDStr;
        }

        public void Refresh(SalesPromotion e)
        {
            curItem = e;
            Display();

        }

        private void Display()
        {

           
            if (curItem != null)
            {
                this.skinTextBox_Name.Text = this.curItem.Name;
                this.skinTextBox_Remarks.Text = this.curItem.Remarks;
                this.skinCheckBox_Enabled.Checked = this.curItem.Enabled;
                 
               this.dateTimePickerEndDate.Value = curItem.EndDate;
                 this.dateTimePickerBeginDate.Value= curItem.StartDate ;

                //判断是否有目标产品

                if (!String.IsNullOrEmpty(curItem.CostumeIDStr))
                {
                    int count = 0;
                    
                    if (PromotionTypeEnum.YKJ == (PromotionTypeEnum)curItem.PromotionType) {
                        String [] range = curItem.CostumeIDStr.Split(';');
                        foreach (var item in range)
                        {
                            String[] str = item.Split(',');
                            foreach (var i in str)
                            {
                                count++;
                            }
                        } 
                    } else {
                        count= curItem.CostumeIDStr.Split(',').Length;
                    }
                    SetLabel(count , curItem.ContainsSpecify);
                }
                else
                {
                    this.skinLabelCostume.Text = "没有商品参与该促销活动，请添加";
                }
                //this.skinTextBox_Name.Enabled = false;
                this.skinComboBoxPromotionType.SelectedValue =  Enum.Parse(typeof(PromotionTypeEnum), this.curItem.PromotionType.ToString());
                this.skinComboBoxPromotionType.Enabled = false;
                //this.groupBoxShop.Enabled = false;
                SetUpShopView();
                SetUpRule();
                //判断是否有绑定销售单，如果有则促销规则和参与商品不可以修改 
                if (isSalesPromotionUse)
                {
                    this.groupBoxRule.Enabled = false;
                }
            }
            else {
                ResetAll();
            }
        }

        private bool IsSalesPromotionUse() {
            IsSalesPromotionUseResult result =GlobalCache.ServerProxy.IsSalesPromotionUse(curItem.ID);
            bool isSalesPromotionUse = false;
            switch (result)
            {
                case IsSalesPromotionUseResult.Error:
                    GlobalMessageBox.Show("内部错误！");
                    break;
                case IsSalesPromotionUseResult.False:
                    break;
                case IsSalesPromotionUseResult.True:
                    isSalesPromotionUse = true;
                    break;
                default:
                    break;
            }
            return isSalesPromotionUse;
        }
        private void SetLabel(int count,bool containsSpecify)
        {
            if (count > 0)
            {

                String label = "";
                label += "有" + count + "个商品";
                label += containsSpecify ? "参加" : "不参加";
                label += "该促销活动";

                this.skinLabelCostume.Text = label;
            }
            else
            {
                if (containsSpecify)
                {
                    this.skinLabelCostume.Text = "没有商品参与该促销活动，请添加";
                }
                else
                {
                    this.skinLabelCostume.Text = "没有商品参与该促销活动，请添加";
                }
            }

        } 
        

        private void SetUpRule()
        {
            List<IPromotionRule> rules = this.curItem.Rules;
            if(this.curItem.PromotionType==0)
            {
                this.mjRuleCtrl1.FillResult(this.curItem.Rules);
            }
            else
            {
                this.discountRuleCtrl1.FillResult(this.curItem.Rules);
            }
        }

        private void SetUpShopView()
        {
            //设置店铺列表

            List<Shop> keyValues = (List<Shop>)this.dataGridViewShop.DataSource;
            String[] shopIds = this.curItem.ShopIDStr.Split(',');
            foreach (var item in shopIds)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    Shop shop = keyValues.Find(t => t.ID.Equals(item));
                    if (shop != null)
                    {
                        shop.Selected = true;
                    }
                }
            }
            this.dataGridViewShop.DataSource = null;
            this.dataGridViewShop.DataSource = keyValues;
        }

        private void ResetAll()
        {
            this.skinTextBox_Name.Text = null;
            this.skinTextBox_Remarks.Text = null;
            this.skinCheckBox_Enabled.Checked = true;
        }

        private PromotionTypeEnum curType;
        private void skinComboBoxPromotionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SkinComboBox box = (SkinComboBox)sender;
                //if (ruleCtrl != null) {
                //    this.ruleCtrl.Hide();
                //}
                curType = (PromotionTypeEnum)box.SelectedValue;
                switch (curType)
                {
                    case PromotionTypeEnum.MJ:
                        this.ruleCtrl = mjRuleCtrl1;
                        this.ruleCtrl.Enabled = true;
                        this.discountRuleCtrl1.Hide();
                        break;
                    case PromotionTypeEnum.Discount:
                        this.ruleCtrl = discountRuleCtrl1;
                        this.ruleCtrl.Enabled = true;
                        this.mjRuleCtrl1.Hide();
                        break;
                    case PromotionTypeEnum.YKJ:
                        this.ruleCtrl.Enabled = false;
                        break;
                    default:
                        this.ruleCtrl = mjRuleCtrl1;
                        this.ruleCtrl.Enabled = true;
                        this.discountRuleCtrl1.Hide();
                        break;
                }
                this.ruleCtrl.Show();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
         

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempItem == null)
                {
                    tempItem = curItem;
                }

                SalesPromotionCostumeSelectForm form = new SalesPromotionCostumeSelectForm(tempItem, curType,isSalesPromotionUse, filterValid);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    costumeResult = form.Result;
                    if (costumeResult.Value != null)
                    {
                        SetLabel(costumeResult.Value.Count, costumeResult.Key);
                    }
                    else
                    {
                        if (costumeResult.Key)
                        {
                            // this.skinLabelCostume.Text = "所有商品不参与促销";
                            this.skinLabelCostume.Text = "没有商品参与该促销活动，请添加";
                        }
                        else
                        {
                            this.skinLabelCostume.Text = "没有商品参与该促销活动，请添加";
                        }

                    }
                    if (tempItem == null)
                    {
                        tempItem = new SalesPromotion();
                    }
                    SetItem(tempItem);
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
       
    }


}
