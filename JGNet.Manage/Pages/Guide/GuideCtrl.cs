using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms; 
using JGNet.Core.Const;
using CCWin;
using JGNet.Core;
using CJBasic.Loggers;
using CJPlus;
using JGNet.ForManage;
using JGNet.Manage.Pages.RuleSettings;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Common;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;

namespace JGNet.Manage.Retail

{
    public partial class GuideCtrl : BaseUserControl
    {
        public event CJBasic.Action<Guide, BaseUserControl> AddClick;
        public event CJBasic.Action<Guide, BaseUserControl> ChangePwdClick;
        private List<IPromotionRule> currentPromotionRuleList= new List<IPromotionRule>();
        private List<RetailDetail> retailDetailList = new List<RetailDetail>();//当前dataGridView绑定的源
         
        public override void RefreshPage() {
            this.BaseButtonQuery_Click(null,null);
        }

        public GuideCtrl()
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.导购员;
            BaseButtonAdd.Enabled = HasPermission(RolePermissionEnum.编辑);
            BaseButtonSearch.Enabled = HasPermission(RolePermissionEnum.查看);
            skinTextBoxName.SkinTxt.KeyDown += SkinTxt_KeyDown;
            this.dataGridView.AutoGenerateColumns = false;
            this.birthdayDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
        }

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButtonQuery_Click(null, null);
            }
        }

        private void SetState()
        {
            List<ListItem<GuideState>> list = new List<ListItem<GuideState>>();
            list.Add(new ListItem<GuideState>() { Key = EnumHelper.GetDescription(GuideState.All), Value = GuideState.All });
            list.Add(new ListItem<GuideState>() { Key = EnumHelper.GetDescription(GuideState.Enable), Value = GuideState.Enable });
            list.Add(new ListItem<GuideState>() { Key = EnumHelper.GetDescription(GuideState.Disable), Value = GuideState.Disable });
            this.skinComboBoxState.DisplayMember = "Key";
            this.skinComboBoxState.ValueMember = "Value";
            this.skinComboBoxState.DataSource = list;
        }

        private void Control_Load(object sender, EventArgs e)
        {
            this.Initialize();
            this.skinComboBoxState.SelectedValue = GuideState.Enable;
                BaseButtonQuery_Click(null, null); 
        }

        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private void Initialize()
        {
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView);
            dataGridViewPagingSumCtrl.Initialize();
            SetState();
           skinComboBoxShopID.Initialize();
            skinTextBoxName.SkinTxt.Text = string.Empty;
            this.dataGridView.DataSource = null;
        }

        private void BaseButtonQuery_Click(object sender, EventArgs e)
        {

            if (!HasPermission(RolePermissionEnum.查看))
            {
                return;
            }

            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                String shopID = ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue);
                GetGuidesPara para = new GetGuidesPara()
                {
                    IdOrName = skinTextBoxName.SkinTxt.Text,
                    ShopID = shopID,
                    State = (GuideState)skinComboBoxState.SelectedValue
                };
                InteractResult<List<Guide>> result = GlobalCache.ServerProxy.GetGuides(para);
                //List<Guide> list = GlobalCache.GuideList.FindAll(t => (t.Name.Contains(skinTextBoxName.SkinTxt.Text)
                //|| t.ID.Contains(skinTextBoxName.SkinTxt.Text)) && (t.ShopID == shopID || shopID == null)
                //);

                //if ((int)skinComboBoxState.SelectedValue != -1)
                //{
                //    list = list.FindAll(t => t.State == (int)skinComboBoxState.SelectedValue);
                //}
                if (result.Data != null)
                {

                    //foreach (Guide guide in result.Data)
                    //{
                    //    guide.ShopName = GlobalCache.GetShopName(guide.ShopID);
                    //}
                    //this.dataGridView.DataSource = list;
                    
                    dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList<Guide>(result.Data) );
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

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            this.AddClick(null,this);
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    List<Guide> list = DataGridViewUtil.BindingListToList<Guide>(this.dataGridView.DataSource);
                    Guide item = (Guide)list[e.RowIndex];
                    if (e.ColumnIndex == Column12.Index)
                    {
                        this.AddClick(item, this);
                    }
                    else if (e.ColumnIndex == Column5.Index)
                    {
                        this.ChangePwdClick(item, this);
                    }
                    switch (this.dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {
                        //case "修改":

                        //    this.AddClick(item,this);


                        //    break;
                        //    case "修改密码":

                        //        this.ChangePwdClick(item,this);


                        //break;
                        case "删除":
                            if (GlobalMessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                DeleteResult result = GlobalCache.GuideList_OnDelete(item.ID);
                                if (result == DeleteResult.Error)
                                {
                                    GlobalMessageBox.Show("内部错误！");
                                    return;
                                }
                                else
                                {
                                    GlobalMessageBox.Show("删除成功！");

                                    this.dataGridView.DataSource = null;
                                    list.Remove(item);
                                    this.dataGridView.DataSource = DataGridViewUtil.ListToBindingList(list);

                                }

                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }    
}
