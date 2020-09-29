using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;

using CCWin;
using JGNet.Core;
using JGNet.Common;
using JGNet.Manage;

namespace JGNet.Manage
{
    public partial class CashRecordInsertCtrl : Common.Core.BaseModifyUserControl
    {


        private List<ListItem<string>> remittancesTypeListItems;//上缴销售款明细列表
        private List<ListItem<string>> incomeTypeListItems;//收入明细列表
        private List<ListItem<string>> spendingTypeListItems;//支出明细列表
        public CashRecordInsertCtrl()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
            //this.guideComboBox1.Initialize(GuideComboBoxInitializeType.Null,GlobalCache.CurrentShopID);
            #region skinComboBox_FeeType
            List<ListItem<CashRecordFeeType>> feeTypeListItems = new List<ListItem<CashRecordFeeType>>();
            // feeTypeListItems.Add(new ListItem<CashRecordFeeType>(GlobalUtil.COMBOBOX_ALL, CashRecordFeeType.All));
            feeTypeListItems.Add(new ListItem<CashRecordFeeType>("上缴销售款", CashRecordFeeType.Remittances));
            feeTypeListItems.Add(new ListItem<CashRecordFeeType>("收入", CashRecordFeeType.Income));
            feeTypeListItems.Add(new ListItem<CashRecordFeeType>("支出", CashRecordFeeType.Spending));
            this.skinComboBox_FeeType.DisplayMember = "Key";
            this.skinComboBox_FeeType.ValueMember = "Value";
            this.skinComboBox_FeeType.DataSource = feeTypeListItems;
            this.skinComboBox_FeeType.SelectedIndex = 0;
            #endregion

            #region skinComboBox_FeeDetailType

            //上缴销售款明细列表
            this.remittancesTypeListItems = new List<ListItem<string>>();
            this.remittancesTypeListItems.Add(new ListItem<string>("上缴销售款", "上缴销售款"));

            //收入明细列表
            this.incomeTypeListItems = new List<ListItem<string>>();
            foreach (string incomeItem in GlobalCache.IncomeList)
            {
                this.incomeTypeListItems.Add(new ListItem<string>(incomeItem, incomeItem));
            }

            //支出明细列表
            this.spendingTypeListItems = new List<ListItem<string>>();
            foreach (string spendingItem in GlobalCache.SpendingList)
            {
                this.spendingTypeListItems.Add(new ListItem<string>(spendingItem, spendingItem));
            }

            this.skinComboBox_FeeDetailType.DisplayMember = "Key";
            this.skinComboBox_FeeDetailType.ValueMember = "Value";
            this.skinComboBox_FeeDetailType.DataSource = this.remittancesTypeListItems;
            #endregion

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                decimal moneyCash = decimal.Parse(this.skinTextBox_MoneyCash.SkinTxt.Text);
                if (moneyCash <= 0)
                {
                    GlobalMessageBox.Show("输入的金额必须大于0！");
                    return;
                }
                else
                {
                    if (moneyCash > Convert.ToDecimal(99999999.99))
                    {

                        GlobalMessageBox.Show("输入的金额不能大于99999999.99！");
                        return;
                    }
                }
                //if (this.guideComboBox1.SelectedIndex == 0)
                //{
                //    GlobalMessageBox.Show("操作人不能为空");
                //    return;
                //}

                CashRecordFeeType feeType = (CashRecordFeeType)(this.skinComboBox_FeeType.SelectedValue);

                if (feeType != CashRecordFeeType.Income)
                {
                    moneyCash = moneyCash * -1;
                }
                CashRecord cashRecord = new CashRecord()
                {
                    ShopID = GlobalCache.CurrentShopID,
                    FeeType = (byte)feeType,
                    FeeDetailType = this.skinComboBox_FeeDetailType.SelectedValue.ToString(),
                    MoneyCash = moneyCash,
                    Remarks = this.skinTextBox_Remarks.SkinTxt.Text.Trim(),
                    CreateTime = DateTime.Now,
                    OperatorUserID = CommonGlobalCache.CurrentUserID //(string)this.guideComboBox1.SelectedValue,
                };
                InsertResult result = GlobalCache.ServerProxy.InsertCashRecord(cashRecord);
                switch (result)
                {
                    case InsertResult.Success:
                        GlobalMessageBox.Show("新增成功！");
                        
                       TabPageClose(this.CurrentTabPage, this.SourceCtrlType);
                        break;
                    case InsertResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }  
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
                GlobalMessageBox.Show("新增失败！");
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        //类型改变时，明细需跟着变动
        private void skinComboBox_FeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ListItem<string>> feeDetailTypeListItems = null;
            CashRecordFeeType type = (CashRecordFeeType)this.skinComboBox_FeeType.SelectedValue;
            switch (type)
            {
                case CashRecordFeeType.Remittances:
                    feeDetailTypeListItems = this.remittancesTypeListItems;
                    break;
                case CashRecordFeeType.Income:
                    feeDetailTypeListItems = this.incomeTypeListItems;
                    break;
                case CashRecordFeeType.Spending:
                    feeDetailTypeListItems = this.spendingTypeListItems;
                    break;
                default:
                    feeDetailTypeListItems = this.remittancesTypeListItems;
                    break;
            }

            this.skinComboBox_FeeDetailType.DataSource = feeDetailTypeListItems;
            //this.skinComboBox_FeeDetailType.SelectedIndex = 0;
        }

        private void skinTextBox_Remarks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
