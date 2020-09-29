using JGNet.Common.Core;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using JGNet.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data;
using System.Drawing; 
using System;

using JGNet.Core.MyEnum;
using System.Text;

using System.Windows.Forms;
using JGNet.Common;
using JGNet.Core.Tools;

namespace JGNet.Manage
{
    public partial class AddLevelModelForm : Common.BaseForm
    {

        private CommissionTemplate item;
     
        public CommissionTemplate Result { get { return item; } }
        private OperationEnum action;
        private int CurLevel = 0;
        private bool isDefaultRecord=false;
        private int lCount = 0;
        public AddLevelModelForm(int level,OperationEnum action=  OperationEnum.Add,int listcount=0,CommissionTemplate commtemp=null)
        {
            InitializeComponent();
            this.item = commtemp;
            this.action = action;
            CurLevel = level;
            lCount = listcount;
            Initialize();
        }

        private void Initialize()
        {
            skinTextBoxID.SkinTxt.Text = string.Empty;
            this.numericTxtBoxOne.SkinTxt.TextChanged += numericTxtBoxOne_TextValueChange;
            //  textBoxSort.Value = 100;
            if (action == OperationEnum.Edit)
            {
                //CurLevel=this.item.
                loadInfo();
                //  textBoxSort.Value = item.OrderNo;
                this.Text = "修改分销模板";
                this.baseButtonSave.Text = "保存";
            }
            else if(action == OperationEnum.Add) { 
                this.baseButtonSave.Text = "新增";
                if (lCount == 0)
                {
                    skinIsDefault.Checked = true;
                    skinIsDefault.Enabled = false;
                }
            }
             EnableOfTextBox();
        }
     

        private void loadInfo()
        {
           
           skinTextBoxID.Text = item.Name;
            InteractResult<DistributionInfo> interResult = CommonGlobalCache.ServerProxy.GetDistributionInfo();
            int DisLevel = 0;
            switch (interResult.ExeResult)
            {
                case ExeResult.Success:
                    DisLevel = interResult.Data.Level;
                    break;
                default:
                    break;
            }
            CurLevel = DisLevel;

            this.numericTxtBoxOne.SkinTxt.Text = item.Rate1.ToString();
            this.numericTxtBoxTwo.SkinTxt.Text = item.Rate2.ToString();
            this.numericTxtBoxThree.SkinTxt.Text = item.Rate3.ToString();
            this.numericTxtBoxFour.SkinTxt.Text = item.Rate4.ToString();
            this.numericTxtBoxFive.SkinTxt.Text = item.Rate5.ToString();
            this.numericTxtBoxSix.SkinTxt.Text = item.Rate6.ToString();
            this.numericTxtBoxSeven.SkinTxt.Text = item.Rate7.ToString();
            this.numericTxtBoxEight.SkinTxt.Text = item.Rate8.ToString();
            this.numericTxtBoxNine.SkinTxt.Text = item.Rate9.ToString();
            this.numericTxtBoxTen.SkinTxt.Text = item.Rate10.ToString();
            this.numericTxtFirstScale.SkinTxt.Text = item.FirstRate.ToString();
            this.skinIsDefault.Checked = item.IsDefault;
            if (item.IsDefault)
            {
                isDefaultRecord = true;
            }

        }
        private void numericTxtBoxOne_TextValueChange(object sender, EventArgs e)
        {
            this.numericTxtFirstScale.SkinTxt.Text = this.numericTxtBoxOne.SkinTxt.Text;
        }
        private void EnableOfTextBox()
        {
            if (action == OperationEnum.Add)
            {
                this.numericTxtBoxTen.SkinTxt.Text = "0";
                this.numericTxtBoxNine.SkinTxt.Text = "0";
                this.numericTxtBoxEight.SkinTxt.Text = "0";
                this.numericTxtBoxSeven.SkinTxt.Text = "0";
                this.numericTxtBoxSix.SkinTxt.Text = "0";
                this.numericTxtBoxFive.SkinTxt.Text = "0";

                this.numericTxtBoxFour.SkinTxt.Text = "0";
                this.numericTxtBoxThree.SkinTxt.Text = "0";
                this.numericTxtBoxTwo.SkinTxt.Text = "0";
                this.numericTxtBoxOne.SkinTxt.Text = "0";
                this.numericTxtFirstScale.SkinTxt.Text = "0";
                 
            }

            if (Convert.ToInt32(this.CurLevel) < 10)
            {
                //if (action == OperationEnum.Add)
                //{
                //    this.numericTxtBoxTen.SkinTxt.Text = "0";
                //}
                this.numericTxtBoxTen.SkinTxt.Enabled = false;
            }
            else
            {
             //   this.numericTxtBoxTen.SkinTxt.Text = distributionInfo.CommissionRate10.ToString();
                this.numericTxtBoxTen.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.CurLevel) < 9)
            {
                if (action == OperationEnum.Add)
                {
                    this.numericTxtBoxNine.SkinTxt.Text = "0";
                }
                this.numericTxtBoxNine.SkinTxt.Enabled = false;
            }
            else
            {

              //  this.numericTxtBoxNine.SkinTxt.Text = distributionInfo.CommissionRate9.ToString();
                this.numericTxtBoxNine.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.CurLevel) < 8)
            {
                if (action == OperationEnum.Add)
                {
                    this.numericTxtBoxEight.SkinTxt.Text = "0";
                }
                this.numericTxtBoxEight.SkinTxt.Enabled = false;
            }
            else
            {
              //  this.numericTxtBoxEight.SkinTxt.Text = distributionInfo.CommissionRate8.ToString();
                this.numericTxtBoxEight.SkinTxt.Enabled = true;

            }
            if (Convert.ToInt32(this.CurLevel) < 7)
            {
                if (action == OperationEnum.Add)
                {
                    this.numericTxtBoxSeven.SkinTxt.Text = "0";
                }
                this.numericTxtBoxSeven.SkinTxt.Enabled = false;
            }
            else
            {
               // this.numericTxtBoxSeven.SkinTxt.Text = distributionInfo.CommissionRate7.ToString();
                this.numericTxtBoxSeven.SkinTxt.Enabled = true;

            }
            if (Convert.ToInt32(this.CurLevel) < 6)
            {
                if (action == OperationEnum.Add)
                {
                    this.numericTxtBoxSix.SkinTxt.Text = "0";
                }
                this.numericTxtBoxSix.SkinTxt.Enabled = false;
            }
            else
            {
               // this.numericTxtBoxSix.SkinTxt.Text = distributionInfo.CommissionRate6.ToString();
                this.numericTxtBoxSix.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.CurLevel) < 5)
            {
                if (action == OperationEnum.Add)
                {
                    this.numericTxtBoxFive.SkinTxt.Text = "0";
                }
                this.numericTxtBoxFive.SkinTxt.Enabled = false;
            }
            else
            {
               // this.numericTxtBoxFive.SkinTxt.Text = distributionInfo.CommissionRate5.ToString();
                this.numericTxtBoxFive.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.CurLevel) < 4)
            {
                if (action == OperationEnum.Add)
                {
                    this.numericTxtBoxFour.SkinTxt.Text = "0";
                }
                this.numericTxtBoxFour.SkinTxt.Enabled = false;
            }
            else
            {
               // this.numericTxtBoxFour.SkinTxt.Text = distributionInfo.CommissionRate4.ToString();
                this.numericTxtBoxFour.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.CurLevel) < 3)
            {
                if (action == OperationEnum.Add)
                {
                    this.numericTxtBoxThree.SkinTxt.Text = "0";
                }
                this.numericTxtBoxThree.SkinTxt.Enabled = false;
            }
            else
            {
               // this.numericTxtBoxThree.SkinTxt.Text = distributionInfo.CommissionRate3.ToString();
                this.numericTxtBoxThree.SkinTxt.Enabled = true;

            }
            if (Convert.ToInt32(this.CurLevel) < 2)
            {
                if (action == OperationEnum.Add)
                {
                    this.numericTxtBoxTwo.SkinTxt.Text = "0";
                }
                this.numericTxtBoxTwo.SkinTxt.Enabled = false;
            }
            else
            {
               // this.numericTxtBoxTwo.SkinTxt.Text = distributionInfo.CommissionRate2.ToString();
                this.numericTxtBoxTwo.SkinTxt.Enabled = true;

            }
        }

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButton1_Click(null, null);
            }
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
        /*    try
            {
                string brandName = skinTextBoxID.SkinTxt.Text;

                if (string.IsNullOrEmpty(brandName))
                {
                    MessageBox.Show("名称不能为空！");
                    this.skinTextBoxID.Focus();
                    return;
                }

                if (action == OperationEnum.Edit)
                {
                    item.Name = brandName;
                    item.FirstCharSpell = DisplayUtil.GetPYString(item.Name);
                   // item.OrderNo = Decimal.ToInt32(textBoxSort.Value);

                    if (GlobalCache.BrandList.Exists(t => t.Name == item.Name && t.AutoID != item.AutoID))
                    {
                        GlobalMessageBox.Show("品牌已存在！");
                        return;
                    }
                }
                else
                {
                    this.item = new Brand()
                    {
                        Name = brandName,
                      //  OrderNo = Decimal.ToInt32(textBoxSort.Value),
                        FirstCharSpell = DisplayUtil.GetPYString(brandName),
                    };
                    if (GlobalCache.BrandList.Exists(t => t.Name == item.Name))
                    {
                        GlobalMessageBox.Show("品牌已存在！");
                        return;
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }*/
        }

        private bool CheckValidate()
        {
           

            int level = this.CurLevel;
            if (level == 1)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
            }
            if (level == 2)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }

            }
            if (level == 3)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }
                if (this.numericTxtBoxThree.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelThree); return false;
                }
            }
            if (level == 4)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }
                if (this.numericTxtBoxThree.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelThree); return false;
                }
                if (this.numericTxtBoxFour.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFour); return false;
                }
            }
            if (level == 5)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }
                if (this.numericTxtBoxThree.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelThree); return false;
                }
                if (this.numericTxtBoxFour.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFour); return false;
                }
                if (this.numericTxtBoxFive.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFive); return false;
                }
            }
            if (level == 6)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }
                if (this.numericTxtBoxThree.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelThree); return false;
                }
                if (this.numericTxtBoxFour.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFour); return false;
                }
                if (this.numericTxtBoxFive.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFive); return false;
                }
                if (this.numericTxtBoxSix.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSix); return false;
                }
            }

            if (level == 7)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }
                if (this.numericTxtBoxThree.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelThree); return false;
                }
                if (this.numericTxtBoxFour.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFour); return false;
                }
                if (this.numericTxtBoxFive.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFive); return false;
                }
                if (this.numericTxtBoxSix.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSix); return false;
                }
                if (this.numericTxtBoxSeven.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSeven); return false;
                }
            }
            if (level == 8)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }
                if (this.numericTxtBoxThree.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelThree); return false;
                }
                if (this.numericTxtBoxFour.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFour); return false;
                }
                if (this.numericTxtBoxFive.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFive); return false;
                }
                if (this.numericTxtBoxSix.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSix); return false;
                }
                if (this.numericTxtBoxSeven.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSeven); return false;
                }
                if (this.numericTxtBoxEight.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelEight); return false;
                }
            }
            if (level == 9)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }
                if (this.numericTxtBoxThree.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelThree); return false;
                }
                if (this.numericTxtBoxFour.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFour); return false;
                }
                if (this.numericTxtBoxFive.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFive); return false;
                }
                if (this.numericTxtBoxSix.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSix); return false;
                }
                if (this.numericTxtBoxSeven.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSeven); return false;
                }
                if (this.numericTxtBoxEight.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelEight); return false;
                }
                if (this.numericTxtBoxNine.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelNine); return false;
                }
            }
            if (level == 10)
            {
                if (this.numericTxtBoxOne.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelOne);
                    return false;
                }
                if (this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTwo);
                    return false;
                }
                if (this.numericTxtBoxThree.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelThree); return false;
                }
                if (this.numericTxtBoxFour.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFour); return false;
                }
                if (this.numericTxtBoxFive.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelFive); return false;
                }
                if (this.numericTxtBoxSix.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSix); return false;
                }
                if (this.numericTxtBoxSeven.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelSeven); return false;
                }
                if (this.numericTxtBoxEight.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelEight); return false;
                }
                if (this.numericTxtBoxNine.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelNine); return false;
                }
                if (this.numericTxtBoxTen.SkinTxt.Text.Trim() == "")
                {
                    checkFirstCharges(DistributorLevelType.LevelTen); return false;
                }
            }

            return true;
        }

        private void checkFirstCharges(DistributorLevelType distributorType)
        {
            ShowMessage("请填写" + EnumHelper.GetDescription(distributorType) + "佣金！");
        }

        private void baseButtonSave_Click(object sender, EventArgs e)
        {

            try
            {
                string tempName = skinTextBoxID.SkinTxt.Text;

                if (string.IsNullOrEmpty(tempName))
                {
                    ShowMessage("模板名称不能为空！");
                    this.skinTextBoxID.Focus();
                    return ;
                }
                if (!CheckValidate()) { return; }
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                CommissionTemplate comTemp = new CommissionTemplate();
                comTemp.Name = this.skinTextBoxID.SkinTxt.Text;
                comTemp.FirstRate= this.numericTxtFirstScale.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtFirstScale.SkinTxt.Text.Trim());
                comTemp.Rate1= this.numericTxtBoxOne.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxOne.SkinTxt.Text.Trim());
                comTemp.Rate2 = this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxTwo.SkinTxt.Text.Trim());
                comTemp.Rate3 = this.numericTxtBoxThree.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxThree.SkinTxt.Text.Trim());
                comTemp.Rate4 = this.numericTxtBoxFour.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxFour.SkinTxt.Text.Trim());
                comTemp.Rate5 = this.numericTxtBoxFive.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxFive.SkinTxt.Text.Trim());
                comTemp.Rate6 = this.numericTxtBoxSix.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxSix.SkinTxt.Text.Trim());
                comTemp.Rate7 = this.numericTxtBoxSeven.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxSeven.SkinTxt.Text.Trim());
                comTemp.Rate8 = this.numericTxtBoxEight.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxEight.SkinTxt.Text.Trim());
                comTemp.Rate9 = this.numericTxtBoxNine.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxNine.SkinTxt.Text.Trim());
                comTemp.Rate10 = this.numericTxtBoxTen.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxTen.SkinTxt.Text.Trim());
                comTemp.IsDefault = skinIsDefault.Checked;
                /*  DistributionInfo distributionInfo = new DistributionInfo();
                  distributionInfo.CommissionRate1 = this.numericTxtBoxOne.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxOne.SkinTxt.Text.Trim());
                  distributionInfo.CommissionRate2 = this.numericTxtBoxTwo.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxTwo.SkinTxt.Text.Trim());
                  distributionInfo.CommissionRate3 = this.numericTxtBoxThree.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxThree.SkinTxt.Text.Trim());
                  distributionInfo.CommissionRate4 = this.numericTxtBoxFour.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxFour.SkinTxt.Text.Trim());

                  distributionInfo.CommissionRate5 = this.numericTxtBoxFive.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxFive.SkinTxt.Text.Trim());


                  distributionInfo.CommissionRate6 = this.numericTxtBoxSix.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxSix.SkinTxt.Text.Trim());

                  distributionInfo.CommissionRate7 = this.numericTxtBoxSeven.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxSeven.SkinTxt.Text.Trim());

                  distributionInfo.CommissionRate8 = this.numericTxtBoxEight.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxEight.SkinTxt.Text.Trim());
                  distributionInfo.CommissionRate9 = this.numericTxtBoxNine.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxNine.SkinTxt.Text.Trim());
                  distributionInfo.CommissionRate10 = this.numericTxtBoxTen.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtBoxTen.SkinTxt.Text.Trim());
                  distributionInfo.CommissionFirstRate = this.numericTxtFirstScale.SkinTxt.Text.Trim() == "" ? 0 : Convert.ToDecimal(this.numericTxtFirstScale.SkinTxt.Text.Trim());

                  InteractResult interactR = CommonGlobalCache.ServerProxy.UpdateDistributionInfo(new DistributionInfo()
                  {
                   //   Level = (int)this.skinComboBox_Level.SelectedValue,
                      CommissionRate1 = distributionInfo.CommissionRate1,
                      CommissionRate2 = distributionInfo.CommissionRate2,
                      CommissionRate3 = distributionInfo.CommissionRate3,
                      CommissionRate4 = distributionInfo.CommissionRate4,
                      CommissionRate5 = distributionInfo.CommissionRate5,
                      CommissionRate6 = distributionInfo.CommissionRate6,
                      CommissionRate7 = distributionInfo.CommissionRate7,
                      CommissionRate8 = distributionInfo.CommissionRate8,
                      CommissionRate9 = distributionInfo.CommissionRate9,
                      CommissionRate10 = distributionInfo.CommissionRate10,
                      CommissionFirstRate = distributionInfo.CommissionFirstRate

                  });*/



                if (action == OperationEnum.Add)
                {
                    if (skinIsDefault.Checked)
                    {
                        InteractResult<bool> result = CommonGlobalCache.ServerProxy.IsCommissionTemplateHaveDefault();

                        if (result.Data)
                        {
                            if (GlobalMessageBox.Show("默认模板已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                comTemp.IsDefault = true;
                            }
                            else
                            {
                                comTemp.IsDefault = false;
                                this.skinIsDefault.Checked = false;
                            }
                            //ShowMessage("分销佣金模板已被设置");
                        }

                    }
                    else
                    {
                        comTemp.IsDefault = false;
                    }
                    InteractResult interactR = CommonGlobalCache.ServerProxy.InsertCommissionTemplate(comTemp);
                    switch (interactR.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("新增成功!");
                            this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(interactR.Msg);
                            break;
                        default:
                            break;
                    }

                }
                else if (action == OperationEnum.Edit)
                {
                    comTemp.AutoID = item.AutoID;
                    if (skinIsDefault.Checked)
                    {
                        InteractResult<bool> result = CommonGlobalCache.ServerProxy.IsCommissionTemplateHaveDefault();

                        if (result.Data && isDefaultRecord ==false)
                        {
                            if (GlobalMessageBox.Show("默认模板已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                comTemp.IsDefault = true;
                            }
                            else
                            {
                                comTemp.IsDefault = false;
                                this.skinIsDefault.Checked = false;
                            }
                            //ShowMessage("分销佣金模板已被设置");
                        }

                    }
                    else
                    {
                        comTemp.IsDefault = false;
                    }

                    InteractResult interactR = CommonGlobalCache.ServerProxy.UpdateCommissionTemplate(comTemp);
                    switch (interactR.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("保存成功!");
                            this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(interactR.Msg);
                            break;
                        default:
                            break;
                    }


                }

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

        private void AddLevelModelForm_Load(object sender, EventArgs e)
        {

        }

        private void skinIsDefault_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
