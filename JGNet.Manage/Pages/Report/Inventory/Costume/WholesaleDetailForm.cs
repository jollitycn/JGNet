using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using CJBasic.Helpers;

using System.Text;
using JGNet.Manage.Components;
using System.Windows.Forms;

namespace JGNet.Common
{
    public partial class WholesaleDetailForm :
        BaseForm
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public WholesaleDetailForm()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new string[] {
                  TotalCount.DataPropertyName
            }
            );

            dataGridView1.AutoGenerateColumns = false;
            dataGridViewPagingSumCtrl.Initialize();
        }
         
        private String orderId;

        GetCostumeInvoicingDetailPara para;
        public void ShowDialog(GetCostumeInvoicingDetailPara changePara)
        {
            try
            {

                para = new GetCostumeInvoicingDetailPara();
                ReflectionHelper.CopyProperty(changePara, para);

                CommonGlobalUtil.SetCostomerPfType(skinComboBox_Type);
                /* switch (para.Type)
                 {
                     case PARSQueryType.ShouldPay:
                         accountTypeNameDataGridViewTextBoxColumn.Visible = false;
                         createTimeDataGridViewTextBoxColumn.HeaderText = "单据日期";
                         accountMoneyDataGridViewTextBoxColumn.HeaderText = "总金额";
                         SourceOrderID.Visible = false;
                         sourceOrderIDDataGridViewTextBoxColumn.Visible = true;
                         this.Text = "应收货款明细";

                         break;
                     case PARSQueryType.OtherMoney:
                         accountTypeNameDataGridViewTextBoxColumn.Visible = false;
                         createTimeDataGridViewTextBoxColumn.HeaderText = "收款日期";
                         accountMoneyDataGridViewTextBoxColumn.HeaderText = "收款金额";
                         SourceOrderID.Visible = true;
                         sourceOrderIDDataGridViewTextBoxColumn.Visible = false;
                         this.Text = "其他费用明细";
                         break;
                     case PARSQueryType.PayMoney:
                         accountTypeNameDataGridViewTextBoxColumn.Visible = true;
                         accountTypeNameDataGridViewTextBoxColumn.HeaderText = "收款类型";
                         createTimeDataGridViewTextBoxColumn.HeaderText = "收款日期";
                         accountMoneyDataGridViewTextBoxColumn.HeaderText = "收款金额";
                         SourceOrderID.Visible = true;
                         sourceOrderIDDataGridViewTextBoxColumn.Visible = false;
                         this.Text = "已收金额明细";
                         break;
                     default:
                         break;
                 }*/
                this.ShowDialog();
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }
         

        private void Search(CostumeInvoicingDetailPfType type)
        {
            try
            {

                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                InteractResult<List<PfOrder>> listPage2 = CommonGlobalCache.ServerProxy.GetCostumeInvoicingDetail4Pf(para, type);
                /*   if (!String.IsNullOrEmpty(orderId))
                   {
                       InteractResult<PfAccountRecord> result = GlobalCache.ServerProxy.GetPfAccountRecord(orderId  ,para.Type);
                       List<PfAccountRecord> listPage = new List<PfAccountRecord>();
                       listPage.Add(result.Data);
                       this.dataGridViewPagingSumCtrl.BindingDataSource(listPage);
                   }
                   else
                   {
                       InteractResult<List<PfAccountRecord>> listPage = GlobalCache.ServerProxy.GetPfAccountRecord4Summary(para);
                       this.dataGridViewPagingSumCtrl.BindingDataSource(listPage.Data);
                   }*/
                dataGridViewPagingSumCtrl.BindingDataSource(listPage2.Data);
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

        private void PfAccountRecordOrderDetailForm_Load(object sender, EventArgs e)
        {
            Search(CostumeInvoicingDetailPfType.All);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

            List<PfOrder> list = (List<PfOrder>)this.dataGridView1.DataSource;
            PfOrder item = (PfOrder)list[e.RowIndex];
            if (e.ColumnIndex == SourceOrderID.Index)
            {
                try
                {
                    if (CommonGlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }

                    if (item.IsRetail)
                { 
                    RetailCostumeOrderDetailForm form = new RetailCostumeOrderDetailForm();
                    form.ShowDialog(item);
                }
                else
                {
                    PFCostumeOrderDetailForm Pfform = new PFCostumeOrderDetailForm();
                    Pfform.ShowDialog(item);
                }
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
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            Search((CostumeInvoicingDetailPfType)skinComboBox_Type.SelectedValue);
        }
    }
}
