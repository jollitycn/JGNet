using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core.InteractEntity;
using CCWin;  
using JGNet.Common.Core;  
using CCWin.SkinControl;
using CJBasic;
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using JGNet.Core.Const;
using JGNet.Core.Tools;
using JGNet.Manage;
using JGNet.Common.cache.Wholesale;

namespace JGNet.Common
{
    public partial class WholesaleCustomeSaleManageCtrl : BaseModifyUserControl
    { 

     // private List<RetailOrder> retailOrderList;//绑定DataGridVIew_RetailOrder的集合
        private GetCustomerRetailPagePara para; 
        public  CJBasic.Action<String, BaseUserControl> RefundDetailClick;
        public CJBasic.Action<PfCustomerRetailOrder, BaseUserControl> EditClick;
        public CJBasic.Action<String, BaseUserControl> RetailDetailClick;
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private string shopID; 

        public WholesaleCustomeSaleManageCtrl()
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.客户销售单查询;
            this.skinSplitContainer1.Panel2Collapsed = true;
            this.dataGridView_RetailOrder.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(
                this.dataGridView_RetailOrder, PageControlPanel21_CurrentPageIndexChanged,
                BaseButton_Search_Click, new String[] {
                        totalCountDataGridViewTextBoxColumn.DataPropertyName
            });
            dataGridViewPagingSumCtrl.Initialize();
            new DataGridViewPagingSumCtrl(dataGridView_RetailDetail).Initialize();
        }

        private void PageControlPanel21_CurrentPageIndexChanged(int index)
        {
            if (this.para == null)
            {
                return;
            }
            para.PageIndex = index;
            CustomerRetailPage page =  GlobalCache.ServerProxy.GetCustomerRetailPage(para);

            if (this.para.PfCustomerID == null)
            {
                PfCustomerID.Visible = true;
            }
            else
            {
                PfCustomerID.Visible = false;
            }
            BindingDataSource(page);
        }
        public override void RefreshPage()
        {
            if (para != null)
            {
                PageControlPanel21_CurrentPageIndexChanged(para.PageIndex);
            }
        }



        private void Initialize()
        {
            DateTimeUtil.DateTimePicker_SetDateTimePicker(dateTimePicker_Start, dateTimePicker_End);
          //  this.retailOrderList = null;
            this.para = new GetCustomerRetailPagePara();
            skinComboBox_PfCustomer.Initialize(false, true,1);
            SetDisplay(); 
        }

        private void SetDisplay()
        { 
        }
            
         
        CreateAllReportSelectForm form = null;
        DateTime dateTime = DateTime.Now;
        String createAllReportParaShopId; 

        private bool stopUpdate;  
         
         

        //点击查询按钮
        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            bool isOpenDate = true;
            Date startDate = new Date(this.dateTimePicker_Start.Value);
            Date endDate = new Date(this.dateTimePicker_End.Value);
            string SCustumeId =string.IsNullOrEmpty(this.costumeTextBox1.Text)?"": this.costumeTextBox1.Text;
            if((pfCustomer == null || pfCustomer.ID==null || pfCustomer.ID=="") && skinComboBox_PfCustomer.Text!="所有") {
                GlobalMessageBox.Show("无效的客户信息！");
                this.skinComboBox_PfCustomer.Focus();
                return;
            }

            this.para = new GetCustomerRetailPagePara()
            {
                PfCustomerID = pfCustomer?.ID,
                CostumeID= SCustumeId,
                StartDate = startDate,
                EndDate = endDate,
                PageIndex = 0,
                PageSize = this.dataGridViewPagingSumCtrl.PageSize,
                  
            };

            dataGridViewPagingSumCtrl.OrderPara = para;
            Search();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="para">内部调用的话不传</param>
        public void Search(GetCustomerRetailPagePara para = null)
        {
            if (para != null)
            {
                this.para = para;
                SetQueryCondition();
            }
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                CustomerRetailPage listPage = GlobalCache.ServerProxy.GetCustomerRetailPage(this.para);
                dataGridViewPagingSumCtrl.Initialize(listPage);

                if (this.para.PfCustomerID == null)
                {
                    PfCustomerID.Visible = true;
                }
                else
                {
                    PfCustomerID.Visible = false;
                }

                BindingDataSource(listPage);
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

        private void BindingDataSource(CustomerRetailPage listPage)
        {
            if (listPage?.PfCustomerRetailOrders != null)
            {
                foreach (var item in listPage?.PfCustomerRetailOrders)
                {
                    item.PfCustomerName = PfCustomerCache.GetPfCustomerName(item.PfCustomerID);
                }
            }
            dataGridViewPagingSumCtrl.BindingDataSource(listPage?.PfCustomerRetailOrders,null, listPage?.TotalEntityCount);
        }

        private void SetQueryCondition()
        {
             
            this.dateTimePicker_Start.Value = para.StartDate.ToDateTime();
            this.dateTimePicker_End.Value = para.EndDate.ToDateTime();
            this.skinComboBox_PfCustomer.SelectedValue = para.PfCustomerID;
            this.costumeTextBox1.Text = para.CostumeID;
        }

        private void RetailOrderSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize(); 
        }

        private void dataGridView_RetailOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                   List<PfCustomerRetailOrder> source = (List<PfCustomerRetailOrder>)this.dataGridView_RetailOrder.DataSource; 
                PfCustomerRetailOrder item = source[e.RowIndex];
                 if (ColumnEdit.Index == e.ColumnIndex)
                {
                    EditDetail(item);
                }else
                if (ColumnRemoved.Index == e.ColumnIndex)
                {
                    Removed(item);
                }

            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }
        }
        private void EditDetail(PfCustomerRetailOrder item)
        {
            ////打开修改日期窗口
            //DateSelectForm form = new DateSelectForm("修改开单日期", "修改日期：", item.CreateTime, "正在处理中……");
            //editOrder = item;
            //form.ConfirmClick += form_ConfirmClick;
            //form.ShowDialog();
            EditClick?.Invoke(item, this);
        }
        private void Removed(PfCustomerRetailOrder item)
        {
            if (GlobalMessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                String id = item.ID;
                InteractResult result = GlobalCache.ServerProxy.DeletePfCustomerRetailOrder(id);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("删除成功！");
                        this.RefreshPage();
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                } 
            }
        }


        

        DataGridViewRow currRow = null;
        private void dataGridView_RetailOrder_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.CurrentRow;
            ///不重复提交  DataGridViewRow row = view.CurrentRow;
            if (row != null && row.Index > -1 && row != currRow)
            {
                PfCustomerRetailOrder item = (PfCustomerRetailOrder)row.DataBoundItem;
               // para.RetailOrderType = item.IsRefundOrder ? RetailOrderType.RefundOrder : RetailOrderType.RetailOrder;
                SetDisplay();
                this.BindingRetailDetailDataSourceAndCleanLabel(item);
                currRow = row;

            }
        }
        private void BindingRetailDetailDataSourceAndCleanLabel(PfCustomerRetailOrder retailOrder)
        {
            this.skinSplitContainer1.Panel2Collapsed = false;
            //  this.skinSplitContainer1.Panel2Collapsed = true;

            if (retailOrder == null || String.IsNullOrEmpty(retailOrder.ID))
            {
                this.dataGridView_RetailDetail.DataSource = null;
            }
            else
            {
                List<PfCustomerRetailDetail> retailDetailList =  GlobalCache.ServerProxy.GetPfCustomerRetailDetails(retailOrder.ID);
                this.dataGridView_RetailDetail.DataSource = null;
                if (retailDetailList != null && retailDetailList.Count > 0)
                {
                    foreach (PfCustomerRetailDetail detail in retailDetailList)
                    {
                        detail.CostumeName = CommonGlobalCache.GetCostumeName(detail.CostumeID);
                        detail.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(detail.CostumeID, detail.SizeName);
                    }
                    this.dataGridView_RetailDetail.DataSource = retailDetailList;
                    //this.dataGridView_RetailDetail.BindSource4Reports<RetailDetail>(retailDetailList,new string[] { buyCountDataGridViewTextBoxColumn.DataPropertyName, sumMoneyDataGridViewTextBoxColumn.DataPropertyName } );
                    // this.skinSplitContainer1.Panel2Collapsed = false;
                }
            }
            this.dataGridView_RetailDetail.Refresh(); 
        }
        PfCustomer pfCustomer;
        private void skinComboBox_PfCustomer_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;
        }
    }
}
