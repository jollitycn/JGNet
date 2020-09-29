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
    public partial class GiftTicketCtrl : BaseUserControl
    {

        public override void RefreshPage()
        {
            this.BaseButtonQuery_Click(null, null);
        }

        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public GiftTicketCtrl()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.优惠券设置;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
        }

        private void Search()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<GiftTicketTemplate> list = GlobalCache.ServerProxy.GetGiftTicketTemplates();

                foreach (var item in list)
                {
                    item.OperatorUserName = GlobalCache.GetUserName(item.OperatorUserID);
                }
                dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(list));
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

        private void BaseButtonQuery_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            this.SaveClick(null, this);
        }

        public event CJBasic.Action<GiftTicketTemplate, BaseUserControl> SaveClick;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                  
                    List<GiftTicketTemplate> list = DataGridViewUtil.BindingListToList<GiftTicketTemplate>(this.dataGridView1.DataSource);
                    GiftTicketTemplate item = (GiftTicketTemplate)list[e.RowIndex];
                    if (ColumnEdit.Index == e.ColumnIndex)
                    {
                        Edit(item);
                    } else if (ColumnDelete.Index == e.ColumnIndex)
                    {
                        Delete(list, item);
                    }
             
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void Edit(GiftTicketTemplate item)
        {
            if (HasPermission(RolePermissionEnum.编辑))
            {
                this.SaveClick(item, this);
            }
        }

        private void Delete(List<GiftTicketTemplate> list, GiftTicketTemplate item)
        {
            if (!HasPermission(RolePermissionEnum.删除)) { return; }
            if (GlobalMessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteResult result = GlobalCache.ServerProxy.DeleteGiftTicketTemplate(item.AutoID);
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
                    this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list);
                }
            }
        }

        private void Display()
        {
            //  判断是否有目标产品
            if (GlobalCache.CostumeGiftTicketInfo != null)
            {
                tempItem = GlobalCache.CostumeGiftTicketInfo;
                SetLabel(GlobalCache.CostumeGiftTicketInfo.CostumeIDs.Count, GlobalCache.CostumeGiftTicketInfo.IsUse);
            }
            else
            {
                this.skinLabelCostume.Text = "默认所有商品可使用优惠券";
            }
        }

        private void GiftTicketCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
            //BaseButtonQuery_Click(null, null);
            Search();
        }

        private void Initialize()
        {
            this.dataGridView1.DataSource = null;
            Display();
        }

        private TKeyValue<bool, List<Costume>> costumeResult;
        private  CostumeGiftTicketInfo tempItem = null;

        private void SetLabel(int count, bool containsSpecify)
        {
            if (count > 0)
            {

                String label = "";
                label += "有" + count + "个商品";
                label += containsSpecify ? "可以使用" : "不可以使用";
                label += "优惠券";

                this.skinLabelCostume.Text = label;
            }
            else
            {
                if (containsSpecify)
                {
                    this.skinLabelCostume.Text = "所有商品不可使用优惠券";
                }
                else
                {
                    this.skinLabelCostume.Text = "默认所有商品可使用优惠券";
                }
            }

        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            { 

                GiftTicketTemplateCostumeSelectForm form = new GiftTicketTemplateCostumeSelectForm(tempItem);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (GlobalMessageBox.Show("保存设置吗？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    { return; }
                        costumeResult = form.Result;

                    if (costumeResult.Value != null)
                    {
                        SetLabel(costumeResult.Value.Count, costumeResult.Key);
                    }
                    else
                    {
                        if (costumeResult.Key)
                        {
                            this.skinLabelCostume.Text = "所有商品不可使用优惠券";
                        }
                        else
                        {
                            this.skinLabelCostume.Text = "默认所有商品可使用优惠券";
                        }
                    }
                        if (tempItem == null)
                        {
                            tempItem = new CostumeGiftTicketInfo();
                        }
                        List<String> costumeIds = new List<string>();
                        if (costumeResult.Value != null && costumeResult.Value.Count > 0)
                        {
                            costumeResult.Value.ForEach(t => costumeIds.Add(t.ID));
                        }
                        tempItem = new CostumeGiftTicketInfo()
                        { 
                            IsUse = costumeResult.Key,
                            CostumeIDs = costumeIds
                        };
                        UpdateResult result = GlobalCache.ServerProxy.UpdateCostumeGiftTicket(tempItem);
                        switch (result)
                        {
                            case UpdateResult.Success:
                                GlobalMessageBox.Show("保存成功！");
                                GlobalCache.CostumeGiftTicketInfo_OnChange(tempItem);
                                break;
                            case UpdateResult.Error:
                                GlobalMessageBox.Show("内部错误！");
                                break;
                            default:
                                break;
                        }
                          
                    }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        } 
    }
}
