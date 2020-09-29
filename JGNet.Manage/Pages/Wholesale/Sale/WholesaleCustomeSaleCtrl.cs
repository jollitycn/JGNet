
using CCWin;
using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.InteractEntity; 
using JGNet.Manage;
using JGNet.Server.Tools;
using CJBasic.Loggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class WholesaleCustomeSaleCtrl : BaseUserControl
    {



        /// <summary>
        /// 会员被选择时触发
        /// </summary>
        /// 
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public WholesaleCustomeSaleCtrl()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.录入客户销售;

            if (!HasPermission(RolePermissionMenuEnum.录入客户销售, RolePermissionEnum.单据时间))
            {
                dateTimePicker_Start.Enabled = false;
            }
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            customerComboBox.Initialize(true, true,1);
        }
        private CostumeItem currentSelectedItem;//当前选中的CostumeItem 
        List<ListItem<String>> sizes = null;
        private CostumeStore currentSelectedStore;//当前选中的CostumeStore
        private void skinComboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据颜色获取对应尺码库存信息
            if (isHasStore)
            {
                this.currentSelectedStore = this.currentSelectedItem.CostumeStoreList.Find(c => { return c.ColorName == ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedValue); });
                CommonGlobalUtil.SetCostumeSize(this.skinComboBox_Size, currentSelectedItem?.Costume);
                string pfCustomeId = ValidateUtil.CheckEmptyValue(customerComboBox.SelectedValue);
                string CostomerID = CostumeCurrentShopTextBox1.SkinTxt.Text;
                string cColorName = ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedValue);
                string CountStr = string.Empty;

                InteractResult<PfCustomerStore> result = GlobalCache.ServerProxy.GetOnePfCustomerStore(pfCustomeId, CostomerID, cColorName);
                if (result.ExeResult == ExeResult.Success)
                {
                    if (result.Data != null)
                    {
                        CountStr = result.Data.CoutString;
                    }
                }

                this.skinLabelCountStr.Text = CountStr+"  ";
            }
        }

        //在输入款号按下回车键开始查询 款号被选中时触发
        private void CostumeCurrentShopTextBox1_CostumeSelected(CostumeItem costumeItem)
        {
            this.SetCostumeDetails(costumeItem);

        }
        private void CleanCostumeDetails()
        {
            this.skinComboBox_Color.DataSource = null;
            this.CostumeCurrentShopTextBox1.SkinTxt.Text = "";
            this.skinTextBox_bugCount.SkinTxt.Text = "";
        }
        private bool isHasStore = false;
        private void SetCostumeDetails(CostumeItem costumeItem)
        {
            if (costumeItem == null)
            {
                //  this.CleanCostumeDetails();
                //return;
                string CID = this.CostumeCurrentShopTextBox1.SkinTxt.Text;
                Costume cItem = CommonGlobalCache.GetCostume(CID);
                if (cItem != null)
                {
                    //this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
                    costumeItem = new CostumeItem();
                    costumeItem.Costume = cItem;
                    costumeItem.Costume.ID = cItem.ID;
                    costumeItem.Costume.Colors = cItem.Colors;
                    this.skinComboBox_Color.DataSource = costumeItem.Costume.Colors.Split(',');
                    this.skinComboBox_Color.SelectedIndex = 0;
                    this.skinTextBox_bugCount.SkinTxt.Text = "1";
                    CommonGlobalUtil.SetCostumeSize(skinComboBox_Size, costumeItem.Costume);
                    //   this.CostumeCurrentShopTextBox1.SkinTxt.Text = CID;
                    //  CostumeCurrentShopTextBox1.CustomerID = CID;
                    this.currentSelectedItem = costumeItem;
                  //  this.CostumeCurrentShopTextBox1.Visible = false;

                }

            }
            else
            {
                isHasStore = true;

               // this.CostumeCurrentShopTextBox1.Visible = true;

                this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
                 this.currentSelectedItem = costumeItem;
                this.skinComboBox_Color.DataSource = costumeItem.Costume.Colors.Split(',');
                this.skinComboBox_Color.SelectedIndex = 0;
                this.skinTextBox_bugCount.SkinTxt.Text = "1";
                CommonGlobalUtil.SetCostumeSize(skinComboBox_Size, costumeItem.Costume);
            }
             
             
                //  this.skinLabel_CostumeName.Text = costumeItem.Costume.BrandName + "-" + costumeItem.Costume.Name;
              
               
            
           }


        private PfCustomer lastAddCustomer;

        private void BaseButton_AddCostume_Click(object sender, EventArgs e)
        {
            try
            {

                int buyCount = int.Parse(this.skinTextBox_bugCount.SkinTxt.Text);
                PfCustomerRetailDetail detail = new PfCustomerRetailDetail()
                {
                    PfCustomerID = pfCustomer.ID,
                    PfCustomerName = PfCustomerCache.GetPfCustomerName(pfCustomer.ID),
                    CostumeID = this.currentSelectedItem.Costume.ID,
                    CostumeName = this.currentSelectedItem.Costume.Name,
                    ColorName = this.skinComboBox_Color.Text,
                    SizeName = ValidateUtil.CheckEmptyValue(this.skinComboBox_Size.SelectedValue),
                    // 显示自己设置的尺码组和对应的尺码列表
                    SizeDisplayName = CostumeStoreHelper.GetCostumeSizeName(ValidateUtil.CheckEmptyValue(this.skinComboBox_Size.SelectedValue), CommonGlobalCache.GetSizeGroup(this.currentSelectedItem.Costume.SizeGroupName)),
                    BuyCount = buyCount,

                };

                if (!this.AddSelectedCostumeToList(detail))
                {
                    return;
                }
                dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(this.PfCustomerRetailDetailList));
                lastAddCustomer = pfCustomer;
                this.skinTextBox_bugCount.SkinTxt.Text = "1";


            }
            catch (Exception ee)
            {
                CommonGlobalUtil.WriteLog(ee);
                GlobalMessageBox.Show("添加失败！");
            }
        }

        List<PfCustomerRetailDetail> PfCustomerRetailDetailList = new List<PfCustomerRetailDetail>();
        private bool AddSelectedCostumeToList(PfCustomerRetailDetail detail)
        {

            foreach (PfCustomerRetailDetail PfCustomerRetailDetail in this.PfCustomerRetailDetailList)
            {
                if (PfCustomerRetailDetail.CostumeID == detail.CostumeID && PfCustomerRetailDetail.ColorName == detail.ColorName && PfCustomerRetailDetail.SizeName == detail.SizeName)
                {
                    GlobalMessageBox.Show("列表中已存在该款商品！");
                    int rowIndex = this.PfCustomerRetailDetailList.IndexOf(PfCustomerRetailDetail);
                    this.dataGridView1.ClearSelection();
                    this.dataGridView1.Rows[rowIndex].Selected = true;
                    return false;
                }
            }
            this.PfCustomerRetailDetailList.Add(detail);
            return true;
        }

        private void baseButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                if (pfCustomer == null)
                {
                    GlobalMessageBox.Show("客户不存在，请重新选择！");
                    customerComboBox.Focus();
                    return;
                }
                if (this.PfCustomerRetailDetailList == null || this.PfCustomerRetailDetailList.Count == 0)
                {

                    GlobalMessageBox.Show("订单明细不能为空！");
                    return;
                }

                PfCustomerRetailInfo info = this.Build();
                InteractResult result = GlobalCache.ServerProxy.PfCustomerRetail(info);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("保存成功！");
                        this.ResetForm();
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
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

        private PfCustomerRetailInfo Build()
        {
            if (
                this.PfCustomerRetailDetailList == null || this.PfCustomerRetailDetailList.Count == 0)
            {
                return null;
            }
            int totalCount = 0;
            List<PfCustomerRetailDetail> details = new List<PfCustomerRetailDetail>();

            //使用补货申请单的店铺ID信息


            string id = IDHelper.GetID(OrderPrefix.PfCustomerRetailOrder, CommonGlobalCache.CurrentShop.AutoCode);
            foreach (PfCustomerRetailDetail detail in this.PfCustomerRetailDetailList)
            {
                //if (detail.BuyCount <= 0)
                //{
                //    continue;
                //}
                detail.PfCustomerRetailOrderID = id;
                totalCount += detail.BuyCount;
                
                details.Add(detail);
            }

            PfCustomerRetailOrder pOrder = new PfCustomerRetailOrder()
            {
                PfCustomerID = lastAddCustomer.ID,
                ID = id,
                CreateTime = this.dateTimePicker_Start.Value,
                TotalCount = totalCount,
                Comment = this.skinTextBox_Remarks.SkinTxt.Text,

            };

            return new PfCustomerRetailInfo()
            {
                PfCustomerRetailOrder = pOrder,
                PfCustomerRetailDetails = details
            };


        }

        private void ResetForm()
        {
            // customerComboBox.Text = string.Empty;
            this.PfCustomerRetailDetailList.Clear();
            CostumeCurrentShopTextBox1.Text = null;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();
            skinComboBox_Size.DataSource = null;
            skinComboBox_Color.DataSource = null;
            skinTextBox_bugCount.Text = "";
        }

        //将绑定的PfCustomerRetailDetail源转换成RefundDetail
        private PfCustomerRetailDetail PfCustomerRetailDetailToRefundDetail(PfCustomerRetailDetail PfCustomerRetailDetail, string orderID)
        {
            return new PfCustomerRetailDetail()
            {
                CostumeID = PfCustomerRetailDetail.CostumeID,
                CostumeName = GlobalCache.GetCostumeName(PfCustomerRetailDetail.CostumeID),
                ColorName = PfCustomerRetailDetail.ColorName,
                SizeName = PfCustomerRetailDetail.SizeName,
                BuyCount = PfCustomerRetailDetail.BuyCount,
                SizeDisplayName = PfCustomerRetailDetail.SizeDisplayName,
            

            };
        }

        //当单元格中的金额或折扣值发生变化时，对应修改另一项的值
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    PfCustomerRetailDetail detail = this.PfCustomerRetailDetailList[e.RowIndex];
                    this.dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    GlobalUtil.WriteLog(ex);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (e.ColumnIndex == Column1.Index)
                    {
                        PfCustomerRetailDetail detail = this.PfCustomerRetailDetailList[e.RowIndex];
                        this.PfCustomerRetailDetailList.RemoveAt(e.RowIndex);
                        if (PfCustomerRetailDetailList != null && PfCustomerRetailDetailList.Count == 0)
                        {
                            // 删除判断是否整个清空了，如果清空了，则清空客户信息
                            lastAddCustomer = null;
                        }
                        dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(this.PfCustomerRetailDetailList));
                    }
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.WriteLog(ee);
            }
        }

        PfCustomer pfCustomer;
        private void memberIDTextBox2_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;
            CostumeCurrentShopTextBox1.CustomerID = obj?.ID;
        }

        private void memberIDTextBox2_Leave(object sender, EventArgs e)
        {
            if (pfCustomer == null)
            {
                GlobalMessageBox.Show("客户不存在，请重新选择！");

            }
            else
            if ((lastAddCustomer != null && lastAddCustomer != pfCustomer) && (PfCustomerRetailDetailList != null && PfCustomerRetailDetailList.Count > 0))
            {
                GlobalMessageBox.Show("请选择同一个客户！");
                customerComboBox.SelectedItem = lastAddCustomer;
                return;
            }
        }
    }
}
