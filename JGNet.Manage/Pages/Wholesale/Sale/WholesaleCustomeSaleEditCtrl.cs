
using CCWin;
using CCWin.SkinControl;
using JGNet.Common;
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
    public partial class WholesaleCustomeSaleEditCtrl : BaseModifyUserControl
    {
        /// <summary>
        /// 会员被选择时触发
        /// </summary>
        /// 
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public WholesaleCustomeSaleEditCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.客户销售单查询;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            customerComboBox.Initialize(true, false);
        }
        private CostumeItem currentSelectedItem;//当前选中的CostumeItem 
        List<ListItem<String>> sizes = null;
        private CostumeStore currentSelectedStore;//当前选中的CostumeStore
        private void skinComboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据颜色获取对应尺码库存信息
            this.currentSelectedStore = this.currentSelectedItem.CostumeStoreList.Find(c => { return c.ColorName == ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedValue); });
            CommonGlobalUtil.SetCostumeSize(this.skinComboBox_Size, currentSelectedItem?.Costume);
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

        private void SetCostumeDetails(CostumeItem costumeItem)
        {
            if (costumeItem == null)
            {
                this.CleanCostumeDetails();
                return;
            }
            this.currentSelectedItem = costumeItem;
            //  this.skinLabel_CostumeName.Text = costumeItem.Costume.BrandName + "-" + costumeItem.Costume.Name;
            this.CostumeCurrentShopTextBox1.SkinTxt.Text = costumeItem.Costume.ID;
            this.skinComboBox_Color.DataSource = costumeItem.Costume.Colors.Split(',');
            this.skinComboBox_Color.SelectedIndex = 0;
            this.skinTextBox_bugCount.SkinTxt.Text = "1";
            CommonGlobalUtil.SetCostumeSize(skinComboBox_Size, costumeItem.Costume);
            //使用它自身的尺码组
            //  this.SetStoreCountText(this.skinComboBox_Color.SelectedValue, this.skinComboBox_Size.SelectedValue);
        }

        private void BaseButton_AddCostume_Click(object sender, EventArgs e)
        {
            try
            {
                int buyCount = int.Parse(this.skinTextBox_bugCount.SkinTxt.Text);
                //if (buyCount <= 0)
                //{
                //    GlobalMessageBox.Show("退货数量必须大于0！");
                //    return;
                //}

                PfCustomerRetailDetail detail = new PfCustomerRetailDetail()
                {
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
                dataGridViewPagingSumCtrl.BindingDataSource(this.PfCustomerRetailDetailList);
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
            // this.isAddDetail = true;
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
                InteractResult result = GlobalCache.ServerProxy.UpdatePfCustomerRetail(info);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("保存成功！");
                        //this.ResetForm(); 
                        base.TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
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


         //   string id = IDHelper.GetID(OrderPrefix.PfCustomerRetailOrder, CommonGlobalCache.CurrentShop.AutoCode);
            foreach (PfCustomerRetailDetail detail in this.PfCustomerRetailDetailList)
            {
                //if (detail.BuyCount <= 0)
                //{
                //    continue;
                //}
                detail.PfCustomerRetailOrderID = order.ID;
                totalCount += detail.BuyCount;
                details.Add(detail);
            }

            PfCustomerRetailOrder pOrder = new PfCustomerRetailOrder()
            {
                PfCustomerID = pfCustomer.ID,
                ID = order.ID,
                CreateTime = this.dateTimePicker_Start.Value,
                TotalCount = totalCount,
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
                    if (CommonGlobalUtil.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == "删除")
                    {
                        //DialogResult dialogResult = GlobalMessageBox.Show("确定删除该条数据？", "提示", MessageBoxButtons.OKCancel);
                        //if (dialogResult != DialogResult.OK)
                        //{
                        //    return;
                        //}
                        PfCustomerRetailDetail detail = this.PfCustomerRetailDetailList[e.RowIndex];
                        this.PfCustomerRetailDetailList.RemoveAt(e.RowIndex);
                        dataGridViewPagingSumCtrl.BindingDataSource(this.PfCustomerRetailDetailList);
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
        }

        PfCustomerRetailOrder order;
        public void Search(PfCustomerRetailOrder order)
        {
            this.order = order;
            PfCustomerRetailDetailList = GlobalCache.ServerProxy.GetPfCustomerRetailDetails(order.ID);
            foreach (PfCustomerRetailDetail detail in PfCustomerRetailDetailList)
            {
                detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
                detail.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(detail.CostumeID, detail.SizeName);
            }
            skinLabelOrderID.Text = order.ID;
            this.customerComboBox.SelectedValue = order.PfCustomerID;
            this.dateTimePicker_Start.Value = order.CreateTime;
            dataGridViewPagingSumCtrl.BindingDataSource(this.PfCustomerRetailDetailList);
            customerComboBox.Enabled = false;
        }
    }
}
