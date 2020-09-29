using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CJBasic.Widget;
using CJBasic;
using CJBasic.Loggers;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
 
using CCWin.SkinControl;
using JGNet.Core.Tools;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Common.Core.Util;

namespace JGNet.Manage

{
    public partial class EmRefundOrderDetailCtrl : BaseModifyUserControl
    {
        private GetEmCostumePagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
         

        private EmRefundOrder Order { get; set; }

        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                 
            }
        }

        public EmRefundOrderDetailCtrl(EmRefundOrder order)
        {
            InitializeComponent();
            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            this.Order = order; 
            Display();
            Initialize();
        }


         

        private void Initialize()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<EmRefundDetail> listPage = GlobalCache.EMallServerProxy.GetEmRefundDetails(this.Order.ID);
                //      this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingDataSource(listPage);
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

        private void Display()
        { 
            this.skinLabelMemberID.Text = Order.MemeberID;
           // this.skinLabelMemberAddressPhone.Text = Order.ReceiverTelphone;
          //  skinLabelMemberAddress.Text = Order.ReceiverCityZone + Order.ReceiverDetailAddress;
            this.skinLabelOrderId.Text = Order.EmRetailOrderID;
            SetRetailOrderInfo();
            skinLabelCancelOrRefund.Text = Order.CancelOrRefund;
            if (Order.CancelOrRefund == "退货退款" && Order.RefundState == 3)
            {
                skinLabelExpressCompanyTxt.Text = Order.ExpressCompany4Refund;
                skinLabelExpressOrderIdText.Text = Order.ExpressOrderID4Refund;
            }
            else
            {
                skinLabelExpressCompany.Visible = false;
                skinLabelExpressCompanyTxt.Visible = false;
                skinLabelExpressOrderId.Visible = false;
                skinLabelExpressOrderIdText.Visible = false;
            }
        


            //this.skinLabelMemberRemark.Text = Order.BuyerMessage;
            this.skinLabelOrderTimeRefundAgree.Text = Order.TimeRefundAgree.ToString(DateTimeUtil.DEFAULT_DATETIME_FORMAT);
           // skinLabelDiscountAmount.Text =  Order.
            if (Order.RefundState == 0 || Order.RefundState == 1)
            {
                this.skinLabelOrderTimeRefundAgree.Text = string.Empty;
            } 

                updateBaseButtonApplyRefund(); 


        }

        private void SetRetailOrderInfo()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                EmRetailOrder retailOrder = GlobalCache.EMallServerProxy.GetOneEmRetailOrder(this.Order.EmRetailOrderID);

                skinLabelDiscountAmount.Text = retailOrder.MoneyDeductedByTicket.ToString();
                if (retailOrder.State == 0)
                {
                    this.skinLabelOrderPayTime.Text = String.Empty;
                }
                else
                {
                    this.skinLabelOrderPayTime.Text = retailOrder.TimePay.ToString(DateTimeUtil.DEFAULT_DATETIME_FORMAT);
                }

                this.skinLabelSalePrice.Text = retailOrder.TotalEmOnlinePrice.ToString(); //(retailOrder.TotalMoneyReceived - retailOrder.CarriageCost).ToString();
                                                                                  //   this.skinLabelCarriage.Text = retailOrder.CarriageCost.ToString();
                this.skinLabelOrderPayAmount.Text = retailOrder.TotalMoneyReceived.ToString();
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

        private void BindingDataSource(List<EmRefundDetail> listPage)
        {
            foreach (var item in listPage)
            {
                item.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(item.CostumeID, item.SizeName);
            }
                this.dataGridView1.DataSource = listPage;
           
        }


        private void EmCostumeManageCtrl_Load(object sender, EventArgs e)
        {
        }
          
            private void baseButtonApplyRefund_Click(object sender, EventArgs e)
        {
            if (baseButtonApplyRefund.Text=="同意退款") {
                applyRefund();
            }
            else {
                confirmRefund();
            }
           updateBaseButtonApplyRefund();
        }

        private void updateBaseButtonApplyRefund()
        {
            baseButtonApplyRefund.Visible = false;
            baseButtonRefused.Visible = false;
            skinLabelRefundReason.Visible = false;
            skinLabel1.Visible = false;
           
            switch (Order.RefundState)
            {
                case 0:
                  
                        baseButtonApplyRefund.Text = "同意退款";
                    baseButtonApplyRefund.Visible = true;
                    if (Order.RefundRequestCount < 2)
                    {
                        baseButtonRefused.Visible = true;
                    }
                    break;
                case 1:
                    //1：已拒绝
                    skinLabelRefundReason.Visible = true;
                    skinLabel1.Visible = true;
                    skinLabelRefundReason.Text = Order.RejectCauese;
                    break;
                case 2:
                    //2：等待输入物流信息
                    baseButtonApplyRefund.Text = "确认退款";
                    baseButtonApplyRefund.Visible = true;
                    baseButtonRefused.Visible = false;
                    break;
                case 3:
                    //2：退款中
                    baseButtonApplyRefund.Text = "确认退款";
                    baseButtonApplyRefund.Visible = true;
                    baseButtonRefused.Visible = false;
                    break;
                case 4:
                    //3：已退款
                    baseButtonApplyRefund.Text = "确认退款";
                    baseButtonApplyRefund.Visible = false;
                    baseButtonRefused.Visible = false; 
                  //  baseButtonRefused.Visible = true;
                    break; 
                default:
                    baseButtonApplyRefund.Text = "同意退款";
                    break;
            }
        }

        private void confirmRefund()
        {

            try
            {
                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;

                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                ConfirmRefundPara para =  new ConfirmRefundPara()
                {
                    OperateID = CommonGlobalCache.CurrentUserID,
                    EmRefundOrderID = Order.ID
                };
                RefundResult result = GlobalCache.EMallServerProxy.ConfirmRefund(para);
                switch (result)
                {
                    case RefundResult.Success:
                        GlobalMessageBox.Show("确认退款成功！");
                        //this.baseButtonOutbound.Visible = false;
                        //this.baseButtonRefused.Visible = false;
                        //  baseButtonApplyRefund.Visible = false; 
                        Order.RefundState = 3;
                        this.RefreshPageAction?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                        break;
                    case RefundResult.StateIsError:
                        GlobalMessageBox.Show("退款申请状态不符合要求！");
                        break;
                    case RefundResult.IsRefund:
                        GlobalMessageBox.Show("已经退过货！");
                        break;
                    case RefundResult.MemberIsNotExist:
                        GlobalMessageBox.Show("会员不存在！");
                        break;
                    case RefundResult.Error:
                        GlobalMessageBox.Show("内部错误！");
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
                GlobalUtil.UnLockPage(this);
            }
        }
        private void applyRefund() {

            try
            {
                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;

                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                AgreeRefundPara para =  new AgreeRefundPara() {
                EmRefundOrderID = Order.ID,
                 OperateID  = CommonGlobalCache.CurrentUserID
                };
                RefundResult result = GlobalCache.EMallServerProxy.AgreeRefund(para);
                switch (result)
                {
                    case RefundResult.Success:
                        GlobalMessageBox.Show("已同意退款！"); 
                        //this.baseButtonOutbound.Visible = false; 
                        this.baseButtonRefused.Visible = false;
                        Order.RefundState = 2;
                      //  updateBaseButtonApplyRefund();
                        //baseButtonApplyRefund.Visible = false;
                        this.RefreshPageAction?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                        break;
                    case RefundResult.StateIsError:
                        GlobalMessageBox.Show("退款申请状态不符合要求！");
                        break;
                    case RefundResult.IsRefund:
                        GlobalMessageBox.Show("已经退过货！");
                        break;
                    case RefundResult.MemberIsNotExist:
                        GlobalMessageBox.Show("会员不存在！");
                        break;
                    case RefundResult.Error:
                        GlobalMessageBox.Show("内部错误！");
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
                GlobalUtil.UnLockPage(this);
            }
        } 
        private void baseButtonRefused_Click(object sender, EventArgs e)
        {
            try
            {
                EmRefundOrderRefusedReasonForm form = new EmRefundOrderRefusedReasonForm();

                //if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                //{
                //    return;
                //}
                String reason = string.Empty;

                if (form.ShowDialog() == DialogResult.OK) {
                    reason = form.Result;
                }
                else { return; }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                RefusedRefundPara para =  new RefusedRefundPara() {
                 EmRefundOrderID =  Order.ID,
                 RejectCauese = reason,
                    OperateID = CommonGlobalCache.CurrentUserID
                };
                RefundResult result = GlobalCache.EMallServerProxy.RefusedRefund(para);
                switch (result)
                {
                    case RefundResult.Success:
                        GlobalMessageBox.Show("已拒绝退款！");
                      //  this.baseButtonOutbound.Visible = false;
                        this.baseButtonRefused.Visible = false;
                        baseButtonApplyRefund.Visible = false;
                        this.RefreshPageAction?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                        break;
                    case RefundResult.StateIsError:
                        GlobalMessageBox.Show("退款申请状态不符合要求！");
                        break;
                    case RefundResult.IsRefund:
                        GlobalMessageBox.Show("已经退过货！");
                        break;
                    case RefundResult.MemberIsNotExist:
                        GlobalMessageBox.Show("会员不存在！");
                        break;
                    case RefundResult.Error:
                        GlobalMessageBox.Show("内部错误！");
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
                GlobalUtil.UnLockPage(this);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
