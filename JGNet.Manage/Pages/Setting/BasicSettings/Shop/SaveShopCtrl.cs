using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using System.Reflection;
using CJBasic.Security;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core;  
using JGNet.Core;
using JGNet.Common;

namespace JGNet.Manage.Pages
{
    public partial class SaveShopCtrl : BaseModifyUserControl
    {  

        private Shop curShop = null; 
        //public SaveShopCtrl()
        //{
        //    InitializeComponent();
        //}

        public SaveShopCtrl(Shop shop)
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.店铺档案;
            this.curShop = shop;
            Display();
            //this.dateTimePicker_CreateTime.Value = this.curShop.CreateTime;

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValidate()) { return; };
                Shop shop = Build();
                if (curShop == null)
                {
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }
                    InsertShopResult result = GlobalCache.Shop_OnInsert(shop);
                    switch (result)
                    {
                        case InsertShopResult.Error:
                            GlobalMessageBox.Show("内部错误！");
                            break;
                        case InsertShopResult.GeneralStoreIsExist:
                            GlobalMessageBox.Show("总仓已存在！");
                            break;
                        case InsertShopResult.IDIsExist:
                            GlobalMessageBox.Show("编号被占用！");
                            break;
                        case InsertShopResult.MoreThanShopCount:
                            GlobalMessageBox.Show("超过授权店铺数量，如需添加请购买扩店服务。！");
                            break;
                        default:
                            GlobalMessageBox.Show("添加成功！");
                            TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                    }
                }
                else
                {
                    UpdateShopResult result = GlobalCache.Shop_OnUpdate(shop);
                    switch (result)
                    {
                        case UpdateShopResult.Error:
                            GlobalMessageBox.Show("内部错误！");
                            break;
                        case UpdateShopResult.GeneralStoreIsExist:
                            GlobalMessageBox.Show("总仓已存在！");
                            break;
                        default:
                            GlobalMessageBox.Show("保存成功！");
                            curShop = shop;
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

        private Shop Build()
        {
            Shop shop = new Shop()
            {
                ID = this.skinTextBox_ID.SkinTxt.Text.ToLower().Trim(),
                Name = this.skinTextBox_Name.SkinTxt.Text.Trim(),
                Password = this.skinTextBox_Password.Text.Trim(),
                IsGeneralStore = this.skinCheckBox_IsGeneralStore.Checked,
                AutoCode = curShop == null ? 0 : curShop.AutoCode,
                NameOnEMall = curShop == null ? string.Empty : curShop.NameOnEMall,
                RechargeRuleID = curShop == null ? 0 : curShop.RechargeRuleID,
                Selected = curShop == null ? false : curShop.Selected,
                ShowOnEMall = curShop == null ? false : curShop.ShowOnEMall,
                // ShowValue4CheckStore = this.skinCheckBox_ShowValue4CheckStore.Checked,
                MinDiscount = Decimal.ToInt32(this.numericUpDown_MinDiscount.Value),
                MaxChangeRemoved = Decimal.ToInt32(this.numericUpDown_MaxChangeRemoved.Value),
                CreateTime = DateTime.Now,
                ForeShiftStartTime = dateTimePickerForeShiftStartTime.Text,
                ForeShiftEndTime = dateTimePickerForeShiftEndTime.Text,
                NightShiftStartTime = dateTimePickerNightShiftStartTime.Text,
                NightShiftEndTime = dateTimePickerNightShiftEndTime.Text,
                Address = this.skinTextBoxAddress.SkinTxt.Text.Trim(),
                PhoneNumber = this.skinTextBoxPhone.SkinTxt.Text.Trim(),
                Enabled = true,
                Remarks = this.txtRemark.SkinTxt.Text.Trim(),
            };
            return shop;
        }

        private bool CheckValidate()
        {
            bool result = true;
               String id = this.skinTextBox_ID.SkinTxt.Text.ToLower().Trim();
            String pwd = this.skinTextBox_Password.Text.Trim();
            if (String.IsNullOrEmpty(id) )
            {
                this.skinTextBox_ID.Focus();
                GlobalMessageBox.Show("编号不能为空！");
                result = false;
            }
            else if ( skinTextBox_ID.Enabled && GlobalCache.ShopList.Exists(t => t.ID == id) )
            {
                this.skinTextBox_ID.Focus();
                GlobalMessageBox.Show("已存在相同编号！");
                result = false;
            }
            else if (String.IsNullOrEmpty(this.skinTextBox_Name.SkinTxt.Text.Trim()))
            {
                this.skinTextBox_Name.Focus();
                GlobalMessageBox.Show("名称不能为空！");
                result = false;
            }
            else if (this.skinTextBox_Name.SkinTxt.Text.Length > 10)
            {
                this.skinTextBox_Name.Focus();
                GlobalMessageBox.Show("店铺名称最多十个字！");
                result = false;
            }
            else
            if (String.IsNullOrEmpty(pwd))
            {
                GlobalMessageBox.Show("请输入密码！");
                skinTextBox_Password.Focus();
                result = false;
            }
            return result;
        }

        //public void Refresh(Shop e)
        //{
        //    curShop = e;
        //    Display();

        //}

        private void Display()
        {
            if (curShop != null)
            {
                this.skinTextBox_ID.Text = this.curShop.ID;
                this.skinTextBox_Name.Text = this.curShop.Name;
                this.skinTextBox_Password.Text = this.curShop.Password; 
                this.skinCheckBox_IsGeneralStore.Checked = this.curShop.IsGeneralStore;
                //this.skinCheckBoxIsGeneralStoreSaleInPos.Checked = this.curShop.
               // this.skinCheckBox_ShowValue4CheckStore.Checked = this.curShop.ShowValue4CheckStore;
                this.numericUpDown_MinDiscount.Value = this.curShop.MinDiscount; 
                this.numericUpDown_MaxChangeRemoved.Value = this.curShop.MaxChangeRemoved;
                dateTimePickerForeShiftStartTime.Text =  this.curShop.ForeShiftStartTime ;
                dateTimePickerForeShiftEndTime.Text=    this.curShop.ForeShiftEndTime ;
                dateTimePickerNightShiftStartTime.Text = this.curShop.NightShiftStartTime;
                dateTimePickerNightShiftEndTime.Text = this.curShop.NightShiftEndTime;
                this.skinTextBoxAddress.SkinTxt.Text = this.curShop.Address;
                this.skinTextBoxPhone.SkinTxt.Text = this.curShop.PhoneNumber;
                this.skinTextBox_ID.Enabled = false;
                this.txtRemark.Text = this.curShop.Remarks;
              //  this.skinTextBox_Name.Enabled = false;
            }
            else
            {
              
                ResetAll();
            }
        }

        private void ResetAll()
        {
            this.skinTextBox_ID.Text = null;
            this.skinTextBox_Name.Text = null;
            this.skinTextBox_Password.Text = null;
            //this.skinCheckBox_ShowValue4CheckStore.Checked = false;
            this.skinCheckBox_IsGeneralStore.Checked = false;

            dateTimePickerForeShiftStartTime.Text = "08:00";
            dateTimePickerForeShiftEndTime.Text = "17:00";
            dateTimePickerNightShiftStartTime.Text = "14:00";
            dateTimePickerNightShiftEndTime.Text = "23:00";

            this.skinTextBoxAddress.SkinTxt.Text = null;
            this.skinTextBoxPhone.SkinTxt.Text = null;
            this.txtRemark.SkinTxt.Text = null;
            //如果是第一次创建店铺，默认这个店铺为总仓
            if (GlobalCache.ShopList == null || GlobalCache.ShopList.Count == 0)
            {
                skinCheckBox_IsGeneralStore.Checked = true;
                skinCheckBox_IsGeneralStore.Enabled = true;
            }
        }
    }

}
