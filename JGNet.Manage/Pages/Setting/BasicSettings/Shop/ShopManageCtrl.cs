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
using JGNet.Common.Core;  
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core.Util;

namespace JGNet.Manage.Pages
{
    public partial class ShopManageCtrl : BaseUserControl
    {

        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public ShopManageCtrl()
        {
            InitializeComponent();
            MenuPermission= RolePermissionMenuEnum.店铺档案;
            skinTextBoxName.SkinTxt.KeyDown += SkinTxt_KeyDown;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            SetState();
        }
        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButtonQuery_Click(null, null);
            }
        }
        public override void RefreshPage()
        {
            this.BaseButtonQuery_Click(null, null);
        }

        private void SetState()
        {
            List<ListItem<string>> list = new List<ListItem<string>>();
            list.Add(new ListItem<string>("启用", "true"));
            list.Add(new ListItem<string>("所有", null));
            list.Add(new ListItem<string>("禁用", "false"));
            this.condition.DisplayMember = "Key";
            this.condition.ValueMember = "Value";
            this.condition.DataSource = list;
        }

        private void BaseButtonQuery_Click(object sender, EventArgs e)
        {

            try
            {

                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                String queryStr = this.skinTextBoxName.SkinTxt.Text.Trim();
                if (condition.SelectedValue == null)
                {
                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(EnabledLink, ColumnDisable, ColumnDelete);
                }
                else if (Convert.ToBoolean(condition.SelectedValue))
                {
                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(ColumnDisable );
                    dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(EnabledLink, ColumnDelete);
                }
                else
                {
                    dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(ColumnDisable);
                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(EnabledLink, ColumnDelete);
                }
                bool state=true;
                List<Shop> shops=null;
                if (condition.SelectedValue != null)
                {
                    state = Convert.ToBoolean(condition.SelectedValue);
                     shops = GlobalCache.ShopList.FindAll(t =>
                // (t.ID.Contains(queryStr) || t.Name.Contains(queryStr)) && condition.SelectedValue == null ? true : (Convert.ToBoolean(condition.SelectedValue) ? t.Enabled : !t.Enabled));
                (t.ID.Contains(queryStr) || t.Name.Contains(queryStr)) && t.Enabled == state);
                }
                else
                {
                    
                   shops = GlobalCache.ShopList.FindAll(t =>
                // (t.ID.Contains(queryStr) || t.Name.Contains(queryStr)) && condition.SelectedValue == null ? true : (Convert.ToBoolean(condition.SelectedValue) ? t.Enabled : !t.Enabled));
                (t.ID.Contains(queryStr) || t.Name.Contains(queryStr)));
                }
                //else 
                //{
                //   // state = Convert.ToBoolean(condition.SelectedValue);
                //}

             
               
                dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(shops));
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

            //新增的时候，判断是否超出店铺限制数量
            //415 在添加店铺时，增加判断店铺数是否超过最大店铺个数。
            if (GlobalCache.ShopList.Count >= CommonGlobalCache.BusinessAccount.ShopCount)
            {
                GlobalMessageBox.Show("超过授权店铺数量，如需添加请购买扩店服务。");
                return;
            }

            this.SaveClick(null, this);
        }

        public event CJBasic.Action<Shop, BaseUserControl> SaveClick;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    List<Shop> list = DataGridViewUtil.BindingListToList<Shop>(dataGridView1.DataSource);
                    Shop item = (Shop)list[e.RowIndex];

                    if (e.ColumnIndex == Column1.Index)
                    {
                        this.SaveClick(item, this);
                    }
                    else if (e.ColumnIndex == ColumnDisable.Index)
                    {
                        if (GlobalMessageBox.Show("确定禁用吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            InteractResult result = GlobalCache.Shop_OnDisable(item.ID);

                            switch (result.ExeResult)
                            {
                                case ExeResult.Success:
                                    GlobalMessageBox.Show("禁用成功！");
                                    this.dataGridView1.DataSource = null;
                                    item.Enabled = false;
                                    this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list) ;
                                    break;
                                case ExeResult.Error:
                                    GlobalMessageBox.Show(result.Msg);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else if (e.ColumnIndex == EnabledLink.Index)
                    {
                        if (GlobalMessageBox.Show("确定启用吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.Enabled = true;
                            InteractResult result = GlobalCache.ServerProxy.EnableShop(item.ID);
                             
                            switch (result.ExeResult)
                            {
                                case ExeResult.Success:
                                    GlobalMessageBox.Show("启用成功！");
                                    this.dataGridView1.DataSource = null;
                                    item.Enabled = true;
                                    this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list);
                                    break;
                                case ExeResult.Error:
                                    item.Enabled = false;
                                    GlobalMessageBox.Show(result.Msg);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else if (e.ColumnIndex == ColumnDelete.Index)
                    {
                        Delete(item);
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

        private void Delete(Shop item)
        {
            if (item != null)
            {
                if (GlobalMessageBox.Show("删除后将查无店铺信息，确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<Shop> list = DataGridViewUtil.BindingListToList<Shop>(dataGridView1.DataSource);
                    InteractResult result = GlobalCache.ServerProxy.DeleteShop(item.ID);

                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("删除成功！");
                            GlobalCache.RemoveShop(item.ID);
                            this.dataGridView1.DataSource = null;
                            list.Remove(item);
                            this.dataGridView1.DataSource = DataGridViewUtil.ListToBindingList(list);
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        private void ShopManageCtrl_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.skinTextBoxName.SkinTxt.Text = string.Empty;
            BaseButtonQuery_Click(null, null);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            if (e.Value == null)
            {
                return;
            }
            List<Shop> list = DataGridViewUtil.BindingListToList<Shop>(dataGridView1.DataSource) ;
            Shop item = (Shop)list[e.RowIndex];

            if (ColumnDisable.Index == e.ColumnIndex)
            {
                if (!item.Enabled)
                {
                    e.Value = null;
                }
            }
            else if (EnabledLink.Index == e.ColumnIndex)
            {
                if (item.Enabled)
                {
                    e.Value = null;  
                }
            }
            else if (ColumnDelete.Index == e.ColumnIndex)
            {
                if (item.Enabled)
                {
                    e.Value = null;
                }
            }
        }
    }
}

