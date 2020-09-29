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
using JGNet.Common.Core.Util;

using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;

namespace JGNet.Manage.Pages
{
    public partial class SalesPromotionCtrl : BaseUserControl
    {
        public override void RefreshPage()
        {
            this.BaseButtonQuery_Click(null, null);
        }


        public SalesPromotionCtrl()
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.促销规则;
            new DataGridViewPagingSumCtrl(this.dataGridView1).Initialize(); 
        }
         
        private void SetQueryConfig()
        {
            this.skinComboBoxPromotionType.DisplayMember = "Key";
            this.skinComboBoxPromotionType.ValueMember = "Value";
            this.skinComboBoxPromotionType.DataSource = GlobalCache.PromotionTypeEnumList;
            skinComboBoxShopID.Initialize();
        }

        private void BaseButtonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                GetSalesPromotionListPara para = new GetSalesPromotionListPara();
                para.PromotionType = (int)this.skinComboBoxPromotionType.SelectedValue;
                para.ShopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);
                this.dataGridView1.DataSource = null;

                List<SalesPromotion> list = GlobalCache.ServerProxy.GetSalesPromotionList(para);
                if (list != null)
                {
                    list = list.FindAll(t=>t.IsValid);
                }
                foreach (var item in list)
                {
                    String shopNames = "";
                    if (!String.IsNullOrEmpty(item.ShopIDStr))
                    {
                        String[] ids = item.ShopIDStr.Split(',');
                        foreach (var id in ids)
                        {
                            Shop shop = GlobalCache.ShopList.Find(t => t.ID == id);
                            if (shop != null)
                            {
                                shopNames += shop.Name + ",";
                            }
                        }
                        if (!String.IsNullOrEmpty(shopNames))
                        {
                            shopNames = shopNames.Remove(shopNames.LastIndexOf(","));
                        }
                        item.ShopNames = shopNames;
                    }


                }
                this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList<SalesPromotion>(list);
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

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            this.SaveClick(null,this);
        }
        public event CJBasic.Action<SalesPromotion, BaseUserControl> SaveClick;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    List<SalesPromotion> list = DataGridViewUtil.BindingListToList<SalesPromotion>(dataGridView1.DataSource);  
                    SalesPromotion item = (SalesPromotion)list[e.RowIndex];
                    if (e.ColumnIndex == Column2.Index)
                    {
                        if (GlobalMessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DeleteResult result = GlobalCache.ServerProxy.DeleteSalesPromotion(item.ID);
                            if (result == DeleteResult.Error)
                            {
                                GlobalMessageBox.Show("内部错误！");
                                return;
                            }
                            else
                            {
                                GlobalMessageBox.Show("删除成功！");

                                this.dataGridView1.DataSource = null;
                                list.Remove(item);
                                this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList<SalesPromotion>(list);  
                            }

                        }
                    }
                    else if (e.ColumnIndex == Column1.Index)
                    {
                        this.SaveClick(item, this);
                    } 
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void SalesPromotionCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.dataGridView1.DataSource = null;
            SetQueryConfig();
        }
    }
}
