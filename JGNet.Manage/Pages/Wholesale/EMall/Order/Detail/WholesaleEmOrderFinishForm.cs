using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Core.MyEnum;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using CJBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class WholesaleEmOrderFinishForm :
        BaseForm
    {


        public PfCustomerOrder Order { get; private set; }

        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public WholesaleEmOrderFinishForm(PfCustomerOrder order)
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.订单管理;
            this.Order = order;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, new string[] {
            countDataGridViewTextBoxColumn.DataPropertyName,
            SumMoney.DataPropertyName
            });
            dataGridViewPagingSumCtrl.Initialize();
            GlobalUtil.SetLogisticCompany(this.skinTextBoxLogisticCompany);
        }

        private void BindingDataSource(List<PfCustomerDetail> listPage)
        {
            if (listPage != null)
            {
                foreach (var item in listPage)
                {
                    item.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(item.CostumeID, item.SizeName);
                    item.CostumeName = CommonGlobalCache.GetCostumeName(item.CostumeID);
                }
            }
            this.dataGridViewPagingSumCtrl.SetDataSource<PfCustomerDetail>(listPage);
        }
         
        private PfCustomerOrder pfCustomerOrder;
        private void EmOrderLogisticsForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                PfCustomerDetails listPage = GlobalCache.EMallServerProxy.GetPfCustomerDetails(this.Order.ID);
                skinLabelPayState.Text = this.Order.IsPay ? "已付款" : "未付款";
                if (this.Order.IsPay)
                {
                    skinLabel2.Text = this.Order.Remarks+"  ";
                }
                    //tabPage1.Hide();
                    tabControl1.TabPages.Remove(tabPageCancel);
                  // this.BindingDataSource(listPage.NotDeliverys);
                  pfCustomerOrder = listPage.PfCustomerOrder;
               // skinLabelReceivedContact.Text = pfCustomerOrder.ReceiverName + "," + pfCustomerOrder.ReceiverTelphone;
                skinLabelReceivedInfo.Text = pfCustomerOrder.ReceiverName + "," + pfCustomerOrder.ReceiverTelphone +" " +pfCustomerOrder.ReceiverCityZone + " " + pfCustomerOrder.ReceiverDetailAddress+"  ";
                switch (Order.State)
                {
                    case (int)PfCustomerOrderState.WaitDelivery:
                        skinPanelLogic.Visible = false;
                        baseButtonCancel.Text = "作废";
                        tabPageNotDeliver.Tag = listPage.NotDeliverys;
                        BindingDataSource(listPage.NotDeliverys);
                        break;
                    case (int)PfCustomerOrderState.PartDelivery:
                        {
                            skinPanelLogic.Visible = false;
                            tabPageNotDeliver.Tag = listPage.NotDeliverys;
                            BindingDataSource(listPage.NotDeliverys);
                            baseButtonCancel.Text = "取消";
                            int i = 1;
                            Dictionary<PfOrder, List<PfCustomerDetail>> keyValues = listPage.DeliveryDict;
                            foreach (var item in keyValues)
                            {
                                TabPage page = new TabPage("已发货" + (i));
                                page.Tag = item;
                                tabControl1.TabPages.Insert(i, page);
                                i++;
                            }
                            break;
                        }
                    case (int)PfCustomerOrderState.Finish:
                        {
                            int i = 1;
                            Dictionary<PfOrder, List<PfCustomerDetail>> keyValues = listPage.DeliveryDict;
                            foreach (var item in keyValues)
                            {
                                TabPage page = new TabPage("已发货" + (i));
                                page.Tag = item;
                                tabControl1.TabPages.Insert(i, page);
                                i++;
                            }
                            tabPageCancel.Tag = listPage.NotDeliverys;
                            tabControl1.TabPages.Add(tabPageCancel);
                            skinPanelBtn.Visible = false;
                            skinPanelLogic.Visible = false;
                            break;
                        }
                    case (int)PfCustomerOrderState.Invalid:
                        skinPanelBtn.Visible = false;
                        skinPanelLogic.Visible = false;
                        BindingDataSource(listPage.NotDeliverys);
                        break;
                    default:
                        break;
                }



                CheckPermisson();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void CheckPermisson()
        {
            if (!HasPermission(RolePermissionEnum.操作))
            {
                skinPanelBtn.Visible = false;
                skinPanelLogic.Visible = false;
            }
        }

        private void BaseButtonConfirm_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK; 
        }

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<PfCustomerDetail> details = (List<PfCustomerDetail>)this.dataGridView1.DataSource;
                InteractResult result;
                String successMsg;
                if (Order.State == (int)PfCustomerOrderState.PartDelivery)
                {
                    if (GlobalMessageBox.Show("确定将剩余未发货商品取消发货？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    result = GlobalCache.EMallServerProxy.CancelPfCustomerOrder(this.Order.ID);
                    successMsg = "取消成功！";
                }
                else
                {
                    result = GlobalCache.EMallServerProxy.InvalidPfCustomerOrder(this.Order.ID);
                    successMsg = "作废成功！";
                }
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(this.FindForm(), result.Msg);
                        break;
                    case ExeResult.Success:
                        GlobalMessageBox.Show(successMsg);
                        this.DialogResult = DialogResult.Yes;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //切换数据
            
            if (tabControl1.SelectedTab == tabPageCancel|| tabControl1.SelectedTab == tabPageNotDeliver)
            {
                TabPage page = tabControl1.SelectedTab;
                List<PfCustomerDetail> details = (List<PfCustomerDetail>)page.Tag;
                this.BindingDataSource(details);
                skinPanelBtn.Visible = true;
                //skinPanel1.Enabled = false;
                skinPanelLogic.Visible = false; 
                if (Order.State == (int)PfCustomerOrderState.PartDelivery)
                {
                    baseButtonCancel.Text = "取消";
                }
                else
                {
                    baseButtonCancel.Text = "作废";
                }
                if (Order.State == (int)PfCustomerOrderState.Invalid)
                {
                    skinPanelBtn.Visible = false;
                    skinPanelLogic.Visible = false;
                }else
                if (Order.State == (int)PfCustomerOrderState.Finish)
                {
                    skinPanelBtn.Visible = false; 
                }
            }
            else
            {
                TabPage page = tabControl1.SelectedTab;
                KeyValuePair<PfOrder, List<PfCustomerDetail>> details = (KeyValuePair<PfOrder, List<PfCustomerDetail>>)page.Tag;
                this.BindingDataSource(details.Value);
                skinLabelPayState.Text = details.Key.IsPay ? "已付款" : "未付款";
                skinPanelBtn.Visible = false;
                skinPanelLogic.Visible = true;
               // skinPanel2.Enabled = false;
                skinTextBoxLogisticCompany.SelectedValue = details.Key.ExpressCompany;
                skinTextBoxLogisticId.Text = details.Key.ExpressOrderID;
            }
            //  BaseButton_Search_Click(null, null);
            //重新获取数量
            //    UpdateTabPageTitle(true);
            CheckPermisson();
        }


        private void GetInfo()
        {
            try
            {
                
                String expressCompany = ValidateUtil.CheckEmptyValue(skinTextBoxLogisticCompany.SelectedValue);
                String expressOrderID = skinTextBoxLogisticId.Text;
                bool rightExpress = KuaiDi100Helper.CheckKuaiDi(GlobalUtil.GetExpressCode(this, expressCompany), expressOrderID);

                if (!rightExpress)
                {
                    ShowMessage("单号不存在或者已过期！");
                    return;
                }

                TabPage page = tabControl1.SelectedTab;
                KeyValuePair<PfOrder, List<PfCustomerDetail>> details = (KeyValuePair<PfOrder, List<PfCustomerDetail>>)page.Tag;
                InteractResult result = GlobalCache.EMallServerProxy.SetPfOrderExpressInfo(details.Key.ID, expressCompany, expressOrderID);

                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        ShowMessage("保存成功！");
                        break;
                    case ExeResult.Error:
                        ShowMessage(result.Msg);
                        break;
                    default:
                        break;
                }
            }
            catch (KuaiDiException ex)
            {
                ShowErrorMessage(ex.Message);
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

        private void baseButtonSaveLogistic_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.GetInfo);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
    }
}
