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
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using CCWin.SkinControl;
using JGNet.Manage.Components;
using JGNet.Common;
using JGNet.Core;

namespace JGNet.Manage
{
    public partial class EarlyStageAccountRecordCtrl : BaseModifyUserControl
    {

        //   public CJBasic.Action<String, BaseUserControl> SourceOrderDetailClick;
        public CJBasic.Action<Supplier, BaseUserControl> RecordSearchClick;

        public Action<BaseUserControl> End;

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private SupplierAccountRecordPagePara pagePara;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public EarlyStageAccountRecordCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize(); 
            createTimeDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
            MenuPermission = RolePermissionMenuEnum.期初往来账录入;
        }

        private void Initialize()
        {
           // GlobalUtil.SetSupplier(this.skinComboBox_SupplierID, true, true);
            this.numericTextBox1.Value = 0;
            numericTextBox1.MinNum = decimal.MinValue;
            if (GlobalCache.GetParameter(ParameterConfigKey.IsHidePayment).ParaValue == "1")
            {
                BaseButtonEdit.Enabled = false;
                baseButtonEnd.Visible = false;
            }
        }

        private void BindingSource(List<Supplier> listPage)
        {
            this.dataGridView1.DataSource = null;
            List<Supplier> Supplierlist = listPage.FindAll(t => t.Enabled);
            if (Supplierlist != null)
            {

                dataGridViewPagingSumCtrl.BindingDataSource<Supplier>(DataGridViewUtil.ListToBindingList(Supplierlist), new String[] { paymentBalanceDataGridViewTextBoxColumn.DataPropertyName }, listPage.Count,null,null,false);
              
            }
            this.dataGridView1.Refresh();
        }



        public override void RefreshPage()
        {
            this.BaseButton_Search_Click(null, null);
        }


        private void SupplierAccountSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
            this.BaseButton_Search_Click(null, null);
        }

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<Supplier> listPage = GlobalCache.ServerProxy.GetSupplierList();

                this.BindingSource(listPage);

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

        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                String supllier = ValidateUtil.CheckEmptyValue(this.skinComboBox_SupplierID.SelectedValue);
                if (String.IsNullOrEmpty(supllier))
                {
                    skinComboBox_SupplierID.Focus();
                    GlobalMessageBox.Show("请先选择供应商！");
                    return;
                }
                if (String.IsNullOrEmpty(numericTextBox1.Text))
                {
                    numericTextBox1.Focus();
                    return;
                }


                //if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                //{
                //    return;
                //}
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                decimal money = this.numericTextBox1.Value; 
                Supplier supplier  = (Supplier)skinComboBox_SupplierID.SelectedItem;
                supplier.PaymentBalance = money;
                //InteractResult result = GlobalCache.ServerProxy.UpdateSupplier(supplier);
                InteractResult result = GlobalCache.ServerProxy.UpdateSupplierPaymentBalance(supplier.ID, supplier.PaymentBalance);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                       // GlobalMessageBox.Show("登记完成！");
                        this.ReLoad();
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
                numericTextBox1.SkinTxt.Text = string.Empty;
                //  this.skinTextBoxRemark.SkinTxt.Text = string.Empty;
                GlobalUtil.UnLockPage(this);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                Supplier supplier = dataGridView1.CurrentRow.DataBoundItem as Supplier;
            }

        }
         

        private void BaseButtonRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshPage();
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            this.BaseButton_Search_Click(null, null);

        }
         

        private void baseButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalMessageBox.Show("期初往来账只能录入一次，确定录入完毕？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                TabPageClose(this.CurrentTabPage, this.SourceCtrlType);
                GlobalUtil.SaveParameters(ParameterConfigKey.IsHidePayment, "1");
                End?.Invoke(this);
                BaseButtonEdit.Enabled = false;
                baseButtonEnd.Visible = false;
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }
    }
}

