using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Core.Dev.InteractEntity;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using JGNet.Manage.Pages;
using CJBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class EmOrderSellerForm :
        BaseForm
    {
        
        private EmRetailOrder Order { get; set; }

        private EmRefundTrackInfo TrackInfo { get; set; }
        public EmOrderSellerForm(EmRetailOrder order)
        {
            InitializeComponent();
            this.Order = order;
            //根据状态显示
            Display(Order.OrderStateName);
            if (TrackInfo.OnlyRefundMoney)
            {
                this.baseButton2.Text = "拒绝退款";
                this.baseButton3.Text = "同意退款";
            }
            else
            {

                this.baseButton2.Text = "拒绝退货";
                this.baseButton3.Text = "同意退货";
            }
        }

        private void Display(String orderStateName)
        {
            LoadTrack();
            skinPanel1.Visible = false;
            skinPanel3.Visible = false;
            skinPanel2.Visible = false;
            skinPanel4.Visible = false;
            skinPanel5.Visible = false;
            skinPanel6.Visible = false;

            if (Order.OrderStateName == EnumHelper.GetDescription(EmRetailOrderState.WaitDelivery))
            {
                baseButton2.Visible = false;
            }

            if (TrackInfo != null && TrackInfo.OperateType == (int)RefundTrackType.RefundApplication)
            {
                //申请退款中
                skinPanel3.Visible = true;
                skinLabel7.Text = TrackInfo.AutoRefundTime;
            }
            else if (TrackInfo != null && TrackInfo.OperateType == (int)RefundTrackType.Refused)
            {
                skinPanel1.Visible = true;
                skinLabel2.Text = TrackInfo.AutoRefundTime;
            }
            else if (TrackInfo != null && (TrackInfo.OperateType == (int)RefundTrackType.Agree || TrackInfo.OperateType == (int)RefundTrackType.Confirm))
            {
                if (Order.RefundStateName == EnumHelper.GetDescription(RefundStateEnum.WriteExpress))
                {
                    //待填写物流
                    skinPanel6.Visible = true;
                    skinLabel14.Text = TrackInfo.AutoRefundTime;
                }
                else if (Order.RefundStateName == EnumHelper.GetDescription(RefundStateEnum.Refunded))
                {
                    //已退款，显示退款成功 
                    skinPanel4.Visible = true;
                }
                else if (Order.RefundStateName == EnumHelper.GetDescription(RefundStateEnum.Refunding)) {
                    //买家退货填写了物流单号，商家确认退款
                    skinPanel5.Visible = true;
                }
            }
        }

        private void BindingDataSource(List<EmRefundTrackInfo> list)
        {
            //第一条是最上面的
            //其他就是下面的内容你给
            if (list != null && list.Count > 0)
            {
                TrackInfo = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    EmRefundTrackInfoCtrl ctrl
                        = new EmRefundTrackInfoCtrl(list[i]);
                    skinFlowLayoutPanel2.Controls.Add(ctrl);
                }
            }
        }

        private void LoadTrack()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                } 
                List <EmRefundTrackInfo>  list = GlobalCache.EMallServerProxy.GetEmRefundTrackInfos(Order.EmRefundOrderID);
                this.BindingDataSource(list);
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
        private void BaseButtonConfirm_Click(object sender, EventArgs e)
        {
            //if (Order.CancelOrRefund == "退货退款" && Order.RefundState == 3)
            //{
            //    skinLabelExpressCompanyTxt.Text = Order.ExpressCompany4Refund;
            //    skinLabelExpressOrderIdText.Text = Order.ExpressOrderID4Refund;
            //}
            //else {
            //}

            //判断是仅退款，还是退款退货
            if (TrackInfo.OnlyRefundMoney)
            {
                OnlyReturn();
            }
            else
            {
                ReturnMoneyAndStore();
            }
            
            
        }
        private void OnlyReturn() {
           
                if (GlobalMessageBox.Show("买家发起的是仅退款，确认退款？", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;

            }
            AgreeRefundPara para = new AgreeRefundPara()
            {
                EmRefundOrderID = Order.EmRefundOrderID,
                OperateID = CommonGlobalCache.CurrentUserID  
            };
            Agree(para);
        }
        private void Agree(AgreeRefundPara para) {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

              

                RefundResult result = GlobalCache.EMallServerProxy.AgreeRefund(para);
                switch (result)
                {
                    case RefundResult.Success:
                        GlobalMessageBox.Show("已同意退款！");
                        Display(EmRetailOrder.GetRefundState(RefundStateEnum.Refunding));
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
            catch (Exception ee)
            {

                GlobalUtil.ShowError(ee);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }

        }

        private void ReturnMoneyAndStore()
        {
            //选择退货地址
            EmOrderReturnAddressForm form = new EmOrderReturnAddressForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                EmRefundAddress address = form.result;
                   AgreeRefundPara para = new AgreeRefundPara()
                {   RefundReceiverCityZone = address.CityZone,
                 RefundReceiverDetailAddress = address.DetailAddress,
                  RefundReceiverName = address.Name,
                   RefundReceiverTelphone = address.Telphone,
                    EmRefundOrderID = Order.EmRefundOrderID,
                    OperateID = CommonGlobalCache.CurrentUserID    
                };
                Agree(para);
            }
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalMessageBox.Show("确认拒绝退款？", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                //if (GlobalUtil.EngineUnconnectioned(this))
                //{
                //    return;
                //}
                EmOrderRefundReasonForm form = new EmOrderRefundReasonForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    String refundReason = form.result;

                    RefusedRefundPara para = new RefusedRefundPara()
                    {
                        EmRefundOrderID = Order.EmRefundOrderID,
                        OperateID = CommonGlobalCache.CurrentUserID,
                        RejectCauese = refundReason
                    };
                    RefundResult result = GlobalCache.EMallServerProxy.RefusedRefund(para);
                    switch (result)
                    {
                        case RefundResult.Success:
                            GlobalMessageBox.Show("已拒绝退款！");
                            Display(EmRetailOrder.GetRefundState(RefundStateEnum.Refused));
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
                    this.DialogResult  = DialogResult.OK;
                }
            }
            catch (Exception ee)
            {

                GlobalUtil.ShowError(ee);
            }
            //finally
            //{
            //    GlobalUtil.UnLockPage(this);
            //}

}

        private void baseButton4_Click(object sender, EventArgs e)
        {
            //确认退款 
            try
            {
                
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                ConfirmRefundPara para = new ConfirmRefundPara()
                {  
                    EmRefundOrderID = Order.EmRefundOrderID,
                    OperateID = CommonGlobalCache.CurrentUserID,
                    Remarks =string.Empty
                };
                RefundResult result = GlobalCache.EMallServerProxy.ConfirmRefund(para);
                switch (result)
                {
                    case RefundResult.Success:
                        GlobalMessageBox.Show("已确认退款！");
                        Display(EmRetailOrder.GetRefundState(RefundStateEnum.Refunded));
                        this.DialogResult = DialogResult.OK;
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
            catch (Exception ee)
            {

                GlobalUtil.ShowError(ee);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void baseButtonLogistic_Click(object sender, EventArgs e)
        {
            //获取退货单信息
            EmRetailOrder item = GlobalCache.EMallServerProxy.GetEmRefundOrderLogistics(Order.EmRefundOrderID);
            EmOrderLogisticsForm form
              = new EmOrderLogisticsForm(item);
            //form.RefreshPageAction += EmOrderDeliverForm_RefreshPageAction;
            form.ShowDialog();
        }
    }
}
