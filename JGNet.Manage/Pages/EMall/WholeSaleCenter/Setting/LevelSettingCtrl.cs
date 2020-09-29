using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core;
using CCWin;
using JGNet.Common.Core.Util;
using System.Reflection;
using CJBasic.Loggers;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using CCWin.SkinControl;
using JGNet.Core.Tools;
using JGNet.Common.Models;
using JGNet.Common;
using JGNet.Core.InteractEntity;
using JGNet.Core.MyEnum;

namespace JGNet.Manage
{
    public partial class LevelSettingCtrl : BaseModifyUserControl
    {

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private int ListCount = 0;
        public LevelSettingCtrl()
        {
            InitializeComponent();
          // this.numericTxtBoxOne.SkinTxt.TextChanged += numericTxtBoxOne_TextValueChange;

            MenuPermission = RolePermissionMenuEnum.层级收益;

            dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.Initialize();
            Initialize();
        }
        private DistributionInfo distributionInfo;
        private void Initialize()
        { 
            SetLevelValue(this.skinComboBox_Level);
            SetDisLevel();
            RefreshPageGetData();


        }
        private void SetDisLevel()
        {
            InteractResult<DistributionInfo> interResult = CommonGlobalCache.ServerProxy.GetDistributionInfo();
            int DisLevel = 0;
            switch (interResult.ExeResult)
            {
                case ExeResult.Success:
                    DisLevel = interResult.Data.Level;
                    this.skinComboBox_Level.SelectedValue =(DistributorLevelType) DisLevel;
                    break;
                default:
                    break;
            }
           


        }
        private void SetLevelValue(SkinComboBox skinComboBox_level)
        {
            try
            {

                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List < ListItem < DistributorLevelType>> levelTypes = new List<ListItem<DistributorLevelType>>();
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelOne), DistributorLevelType.LevelOne));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelTwo), DistributorLevelType.LevelTwo));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelThree), DistributorLevelType.LevelThree));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelFour), DistributorLevelType.LevelFour));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelFive), DistributorLevelType.LevelFive));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelSix), DistributorLevelType.LevelSix));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelSeven), DistributorLevelType.LevelSeven));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelEight), DistributorLevelType.LevelEight));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelNine), DistributorLevelType.LevelNine));
                levelTypes.Add(new ListItem<DistributorLevelType>(EnumHelper.GetDescription(DistributorLevelType.LevelTen), DistributorLevelType.LevelTen));
                skinComboBox_level.DisplayMember = "Key";
                skinComboBox_level.ValueMember = "Value";
                skinComboBox_level.DataSource = levelTypes;

                 
             
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
        private void numericTxtBoxOne_TextValueChange(object sender, EventArgs e)
        {
          //  this.numericTxtFirstScale.SkinTxt.Text = this.numericTxtBoxOne.SkinTxt.Text;
        }
        private void SendGiftTicketCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
        }
 
        private void BindingDataSource()
        {
          //  dataGridViewMembers.DataSource = null;
          /*  if (this.members != null)
            {
                dataGridViewMembers.DataSource = members;
            }*/
        }

        private void skinComboBox_giftTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   GiftTicketTemplate template = skinComboBox_Level.SelectedItem as GiftTicketTemplate;
            //  skinTextBoxMoney.Text = template.Denomination.ToString();
         /*   if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 10)
            {
                this.numericTxtBoxTen.SkinTxt.Text = "0";
                  this.numericTxtBoxTen.SkinTxt.Enabled = false;
            }
            else
            {
                this.numericTxtBoxTen.SkinTxt.Text = distributionInfo.CommissionRate10.ToString();
                this.numericTxtBoxTen.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 9)
            {
                this.numericTxtBoxNine.SkinTxt.Text = "0";
                this.numericTxtBoxNine.SkinTxt.Enabled = false;
            }
            else
            {

                this.numericTxtBoxNine.SkinTxt.Text = distributionInfo.CommissionRate9.ToString();
                this.numericTxtBoxNine.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 8)
            {
                this.numericTxtBoxEight.SkinTxt.Text = "0";
                this.numericTxtBoxEight.SkinTxt.Enabled = false;
            }
            else
            {
                this.numericTxtBoxEight.SkinTxt.Text = distributionInfo.CommissionRate8.ToString();
                this.numericTxtBoxEight.SkinTxt.Enabled = true;

            }
            if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 7)
            {
                this.numericTxtBoxSeven.SkinTxt.Text = "0";
                this.numericTxtBoxSeven.SkinTxt.Enabled = false;
            }
            else
            {
                this.numericTxtBoxSeven.SkinTxt.Text = distributionInfo.CommissionRate7.ToString();
                this.numericTxtBoxSeven.SkinTxt.Enabled = true;

            }
            if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 6)
            {
                this.numericTxtBoxSix.SkinTxt.Text = "0";
                this.numericTxtBoxSix.SkinTxt.Enabled = false;
            }
            else
            {
                this.numericTxtBoxSix.SkinTxt.Text = distributionInfo.CommissionRate6.ToString();
                this.numericTxtBoxSix.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 5)
            {
                this.numericTxtBoxFive.SkinTxt.Text = "0";
                  this.numericTxtBoxFive.SkinTxt.Enabled = false;
            }
            else
            {
                this.numericTxtBoxFive.SkinTxt.Text = distributionInfo.CommissionRate5.ToString();
                this.numericTxtBoxFive.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 4)
            {
                this.numericTxtBoxFour.SkinTxt.Text = "0";
                this.numericTxtBoxFour.SkinTxt.Enabled = false;
            }
            else
            {
                this.numericTxtBoxFour.SkinTxt.Text = distributionInfo.CommissionRate4.ToString();
                this.numericTxtBoxFour.SkinTxt.Enabled = true;
            }
            if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 3)
            {
                this.numericTxtBoxThree.SkinTxt.Text ="0";
                  this.numericTxtBoxThree.SkinTxt.Enabled = false;
            }
            else
            {
                this.numericTxtBoxThree.SkinTxt.Text = distributionInfo.CommissionRate3.ToString();
                this.numericTxtBoxThree.SkinTxt.Enabled = true;

            }
            if (Convert.ToInt32(this.skinComboBox_Level.SelectedValue) < 2)
            {
                this.numericTxtBoxTwo.SkinTxt.Text = "0";
                   this.numericTxtBoxTwo.SkinTxt.Enabled = false;
            }
            else
            {
                this.numericTxtBoxTwo.SkinTxt.Text = distributionInfo.CommissionRate2.ToString();
                this.numericTxtBoxTwo.SkinTxt.Enabled = true;
                
            }*/
        }

        private void baseButtonSave_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                  /*  List<Member> list = (List<Member>)this.dataGridViewMembers.DataSource;
                    Member item = (Member)list[e.RowIndex];
                    switch (this.dataGridViewMembers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {

                        case "删除":
                            this.dataGridViewMembers.DataSource = null;
                            list.Remove(item);
                            this.dataGridViewMembers.DataSource = list;
                            break;
                    }*/
                }
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }


        private void BaseButton6_Click(object sender, EventArgs e)
        {
          /*  MemberMultiSelectForm multiselectForm = new MemberMultiSelectForm();
            multiselectForm.MemberMultiSelected += MemberMultiSelected;
            multiselectForm.ShowDialog();*/
        }
        private void RefreshPageGetData()
        {
            try
            {

                InteractResult<List<CommissionTemplate>> interResult = CommonGlobalCache.ServerProxy.GetCommissionTemplates();
                switch (interResult.ExeResult)
                {
                    case ExeResult.Success:
                        ListCount = interResult.Data.Count;
                        //  distributionInfo = interResult.Data;

                        //  this.skinComboBox_Level.SelectedValue = (CommissionTemplate)distributionInfo.Level;
                        /* this.numericTxtBoxOne.SkinTxt.Text = distributionInfo.CommissionRate1.ToString();
                         this.numericTxtBoxTwo.SkinTxt.Text = distributionInfo.CommissionRate2.ToString();
                         this.numericTxtBoxThree.SkinTxt.Text = distributionInfo.CommissionRate3.ToString();
                         this.numericTxtBoxFour.SkinTxt.Text = distributionInfo.CommissionRate4.ToString();
                         this.numericTxtBoxFive.SkinTxt.Text = distributionInfo.CommissionRate5.ToString();
                         this.numericTxtBoxSix.SkinTxt.Text = distributionInfo.CommissionRate6.ToString();
                         this.numericTxtBoxSeven.SkinTxt.Text = distributionInfo.CommissionRate7.ToString();
                         this.numericTxtBoxEight.SkinTxt.Text = distributionInfo.CommissionRate8.ToString();
                         this.numericTxtBoxNine.SkinTxt.Text = distributionInfo.CommissionRate9.ToString();
                         this.numericTxtBoxTen.SkinTxt.Text = distributionInfo.CommissionRate10.ToString();
                         this.numericTxtFirstScale.SkinTxt.Text= distributionInfo.CommissionFirstRate.ToString();*/
                        dataGridViewPagingSumCtrl.BindingDataSource(interResult.Data);
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(interResult.Msg);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                CommonGlobalUtil.WriteLog(ex);
            }
        }
        private void baseButtonSave_Click_1(object sender, EventArgs e)
        {
            DistributorLevelType d =(DistributorLevelType)skinComboBox_Level.SelectedValue;            
           AddLevelModelForm AddCommissionTemplate = new AddLevelModelForm(Convert.ToInt32(d), OperationEnum.Add, ListCount);
            if (AddCommissionTemplate.ShowDialog(this) == DialogResult.OK)
            {
                RefreshPageGetData();
            }


            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    List<CommissionTemplate> list = (List<CommissionTemplate>) (dataGridView1.DataSource);
                    CommissionTemplate item = (CommissionTemplate)list[e.RowIndex];
                    if (e.ColumnIndex == Column1.Index)
                    { 
                        AddLevelModelForm AddCommissionTemplate = new AddLevelModelForm(0, OperationEnum.Edit,ListCount,item);
                        if (AddCommissionTemplate.ShowDialog(this) == DialogResult.OK)
                        {
                            RefreshPageGetData();
                        }

                    }
                    else
                    if (e.ColumnIndex == ColumnDelete.Index)
                    {
                        InteractResult<bool> IsUseresult= CommonGlobalCache.ServerProxy.IsCommissionTemplateUse(item.AutoID);
                        if (IsUseresult.Data)
                        {
                            GlobalMessageBox.Show("有商品在使用该模板，不能删除！");
                            return;
                        }
                        else
                        {
                            if (item.IsDefault)
                            {
                                if (GlobalMessageBox.Show("删除默认模板会导致后续的批发分销佣金为0，若删除请重新设置默认模板，是否确认删除？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                                {
                                    return;
                                }
                                else
                                {
                                    Delete(list, item);

                                }
                            }
                            else
                            {
                                if (GlobalMessageBox.Show("确定删除该模板吗？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                                {
                                    return;
                                }
                                else
                                {
                                    Delete(list, item);
                                }
                            }
                       }
                      
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
        private void Delete(List<CommissionTemplate> list,CommissionTemplate item)
        {
            InteractResult result = CommonGlobalCache.ServerProxy.DeleteCommissionTemplate(item.AutoID);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    GlobalMessageBox.Show("删除成功！");
                    this.dataGridView1.DataSource = null;
                    list.Remove(item);
                    RefreshPageGetData();
                    //  this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list);
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    break;
            }
        }
        private void baseButton1_Click(object sender, EventArgs e)
        {
            if (GlobalMessageBox.Show("保存后会修改所有模板的层级，是否确认操作？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                DistributionInfo info = new DistributionInfo();
                info.Level = (int)this.skinComboBox_Level.SelectedValue;
             InteractResult updateResult=CommonGlobalCache.ServerProxy.UpdateDistributionInfo(new DistributionInfo() { Level = info.Level });
                if (updateResult.ExeResult == ExeResult.Success)
                {
                    GlobalMessageBox.Show("修改成功！");
                    RefreshPageGetData();
                }
                else {
                    GlobalMessageBox.Show(updateResult.Msg);
                }
            }
        }

        /*  private void MemberMultiSelected(List<Member> returnMembers)
          {
              if (members == null)
              {
                  members = new List<Member>();
              }
              foreach (var item in returnMembers)
              {
                  if (!this.members.Exists(t => t.PhoneNumber == item.PhoneNumber))
                  {
                      members.Add(item);
                  }
              }
              BindingDataSource();
          }*/
    }
    
}
 
