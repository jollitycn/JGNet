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
using JGNet.Common.cache.Wholesale;

namespace JGNet.Manage
{
    public partial class WholesaleBeginningBillCtrl : BaseModifyUserControl
    {

        //   public CJBasic.Action<String, BaseUserControl> SourceOrderDetailClick;
      //  public CJBasic.Action<Supplier, BaseUserControl> RecordSearchClick;

        public Action<BaseUserControl> End;

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private SupplierAccountRecordPagePara pagePara;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public WholesaleBeginningBillCtrl()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.客户期初往来账录入;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize(); 
            createTimeDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;

        }

        private void Initialize()
        {
            skinComboBox_PfCustomer.Initialize(true, true);
            this.numericTextBox1.Value = 0;
            numericTextBox1.MinNum = decimal.MinValue;
            if (GlobalCache.GetParameter(ParameterConfigKey.IsHidePfPayment).ParaValue == "1")
            {
                BaseButtonEdit.Enabled = false;
                baseButtonEnd.Visible = false;
            }
        }

        private void BindingSource(List<PfCustomer> listPage)
        {
            this.dataGridView1.DataSource = null;
            if (listPage != null)
            {

                dataGridViewPagingSumCtrl.BindingDataSource<PfCustomer>(DataGridViewUtil.ListToBindingList(listPage), new String[] { paymentBalanceDataGridViewTextBoxColumn.DataPropertyName }, listPage.Count, null, null, false);
                // this.dataGridView1.DataSource = listPage;
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
                GetPfCustomerPagePara para =  new GetPfCustomerPagePara() {
                     PageIndex=0,
                      PageSize= int.MaxValue
                };
                PfCustomerPage listPage = GlobalCache.ServerProxy.GetPfCustomerPage(para);
               
                this.BindingSource( listPage?.PfCustomers);

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
                // String supllier = ValidateUtil.CheckEmptyValue(this.skinComboBox_SupplierID.SelectedValue);
                if (pfCustomer == null)
                {
                    GlobalMessageBox.Show("客户不存在，请重新选择！");
                    skinComboBox_PfCustomer.Focus();
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
                pfCustomer.PaymentBalance = money;
                 //InteractResult result = PfCustomerCache.PfCustomer_OnUpdate(pfCustomer);
                InteractResult result =GlobalCache.ServerProxy.UpdatePfPaymentBalance(pfCustomer.ID, pfCustomer.PaymentBalance);
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

        private void skinLabelAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                List<PfCustomer> list = (List<PfCustomer>)this.skinComboBox_PfCustomer.DataSource;
                NewWholesaleCustomerSimpleForm addForm = new NewWholesaleCustomerSimpleForm();
                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    if (list == null) { list = new List<PfCustomer>(); }
                    PfCustomer item = addForm.Result;
                    PfCustomer listItem = list.Find(t => t.Name == item.Name || t.ID == item.ID);
                    if (listItem == null)
                    {
                        item.Enabled = true;
                        item.CreateTime = DateTime.Now;
                        InteractResult result = PfCustomerCache.PfCustomer_OnInsert(item);
                        switch (result.ExeResult)
                        {
                            case ExeResult.Success:
                                this.skinComboBox_PfCustomer.DataSource = null;
                                list.Add(item);
                                this.skinComboBox_PfCustomer.DisplayMember = "Name";
                                this.skinComboBox_PfCustomer.ValueMember = "ID";
                                this.skinComboBox_PfCustomer.DataSource = list;
                                // this.skinComboBox_SupplierID.SelectedIndex = list.IndexOf(item);
                                break;
                            case ExeResult.Error:
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        // this.skinComboBox_SupplierID.SelectedItem = listItem;
                    }

                }
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void baseButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalMessageBox.Show("期初客户往来账只能录入一次，确定录入完毕？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                TabPageClose(this.CurrentTabPage, this.SourceCtrlType);
                GlobalUtil.SaveParameters(ParameterConfigKey.IsHidePfPayment, "1");
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

        PfCustomer pfCustomer;
        private void skinComboBox_PfCustomer_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;
        }
    }
}

