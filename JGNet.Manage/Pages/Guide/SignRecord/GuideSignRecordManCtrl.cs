using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using CJBasic;
using JGNet.Common.Core;
using JGNet.Common;
using JGNet.Common.Components;

namespace JGNet.Common.Pages.Guide.SignRecord
{
    public partial class GuideSignRecordManCtrl : BaseUserControl
    {
        private SignRecordPagePara para;

        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public GuideSignRecordManCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridViewMain, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_search_Click, new String[] { ColumnAbsentMinutes.DataPropertyName });
          
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.ColumnSorting += dataGridViewPagingSumCtrl_ColumnSorting;
            MenuPermission = RolePermissionMenuEnum.导购签到记录;
            this.Initialize();
        }

        private void dataGridViewPagingSumCtrl_ColumnSorting(String columnName, bool aesc)
        {
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (this.para == null)
                {
                    return;
                }
                para.PageIndex = index;
                SignRecordPage listPage = CommonGlobalCache.ServerProxy.GetSignRecordPage(para);
                //这里不用调初始化分页
                this.BindingSource(listPage);

            }
            catch (Exception ee)
            {
                ShowError(ee);
            }
            finally
            {
                UnLockPage();
            }

        }

        private void BaseButton_search_Click(object sender, EventArgs e)
        {
            try
            {

                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;

                }
                para = new SignRecordPagePara()
                {
                    EndDate = new Date(this.dateTimePicker_End.Value),
                    StartDate = new Date(this.dateTimePicker_Start.Value),
                    GuideID = ValidateUtil.CheckEmptyValue(this.guideComboBox1.SelectedValue),
                    ShopID =  ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue),
                    PageIndex = 0,
                    PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                    SignType = (SignType)this.skinComboBox_signType.SelectedValue,

                };
                dataGridViewPagingSumCtrl.OrderPara = para;
                SignRecordPage listPage = CommonGlobalCache.ServerProxy.GetSignRecordPage(para);
                
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                BindingSource(listPage);
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

        private void BindingSource(SignRecordPage page)
        {
            if (page != null && page.SignRecords != null && page.SignRecords.Count > 0)
            {
                foreach (var item in page.SignRecords)
                {
                    item.ShopName = CommonGlobalCache.GetShopName(item.ShopID);
                    item.GuideName = CommonGlobalCache.GetUserName(item.GuideID);
                }
            }
            //this.dataGridViewPagingSumCtrl.BindingDataSource(DataGridViewUtil.ListToBindingList(page?.SignRecords), null, page?.TotalEntityCount, page?.SignRecordSum);
            this.dataGridViewPagingSumCtrl.BindingDataSource(page?.SignRecords, null, page?.TotalEntityCount, page?.SignRecordSum);
        }

        private void GuideSignRecordManCtr_Load(object sender, EventArgs e)
        {
        }

        private void Initialize()
        { 
            SetSignType();
            this.skinComboBoxShopID.Initialize();
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
            this.guideComboBox1.Initialize(Common.GuideComboBoxInitializeType.All, ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue));
            this.skinSplitContainer1.Panel2Collapsed = true;
        }

        private void SetSignType()
        { List<TKeyValue<String, SignType>> data = new List<TKeyValue<string, SignType>>();
            data.Add(new TKeyValue<String, SignType>(CommonGlobalUtil.COMBOBOX_ALL,SignType.All));
            data.Add(new TKeyValue<String, SignType>("早班上班", SignType.EarlyWork));
            data.Add(new TKeyValue<String, SignType>("早班下班", SignType.EarlyQuitting));
            data.Add(new TKeyValue<String, SignType>("晚班上班", SignType.EveningWork));
            data.Add(new TKeyValue<String, SignType>("晚班下班", SignType.EveningQuitting));
            skinComboBox_signType.DisplayMember = "Key";
            skinComboBox_signType.ValueMember = "Value";
            skinComboBox_signType.DataSource = null;
            skinComboBox_signType.DataSource = data ;
        }

        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.guideComboBox1.Initialize(Common.GuideComboBoxInitializeType.All, ValidateUtil.CheckEmptyValue(this.skinComboBoxShopID.SelectedValue));
        }
    }
}
