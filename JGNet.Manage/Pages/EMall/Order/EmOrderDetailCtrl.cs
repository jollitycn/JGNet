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
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;

namespace JGNet.Manage

{
    public partial class EmOrderDetailCtrl : BaseModifyUserControl
    {
        private GetEmCostumePagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
         

        private EmRetailOrder Order { get; set; }

        public override void RefreshPage()
        {
            if (pagePara != null)
            {

            }
        }

        public EmOrderDetailCtrl(EmRetailOrder order)
        {
            InitializeComponent();
            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            this.Order = order;

            if (Order != null)
            {

                if (this.Order.OrderState == EmRetailOrderState.WaitDelivery || this.Order.OrderState == EmRetailOrderState.WaitPay)
                {
                    //this.baseButtonOutbound.Visible = false;
                    //// this.skinLabelLogisticCompany.Visible = false;
                    ////  this.skinLabelLogisticId.Visible = false;
                    //this.skinTextBoxLogisticCompany.Enabled = false;
                    //this.skinTextBoxLogisticId.Enabled = false;
                    //skinComboBoxShopID.Enabled = false;
                    skinLabelLogisticCompany.Visible = false;
                    skinLabelLogisticId.Visible = false;
                    skinLabel1.Visible = false;
                    skinLabel2.Visible = false;
                    skinLabel3.Visible = false;
                    skinLabel4.Visible = false;
                }
                else
                {
                    skinLabelLogisticCompany.Visible = true;
                    skinLabelLogisticId.Visible = true;
                    skinLabel1.Visible = true;
                    skinLabel2.Visible = true;
                    skinLabel3.Visible = true;
                    skinLabel4.Visible = true;
                }


              //  SetLogisticCompany(skinTextBoxLogisticCompany);

               // config = EmExpressCompanyAgileConfiguration.Load(CONFIG_PATH) as EmExpressCompanyAgileConfiguration;
             //   if (config != null) { skinTextBoxLogisticCompany.SelectedItem = config.EmExpressCompany; }
                Display();
                Initialize();
            }
        } 


        private void SetLogisticCompany(SkinComboBox skinTextBoxLogisticCompany)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<EmExpressCompany> list = new List<EmExpressCompany>();

                list = GlobalCache.EMallServerProxy.GetEnabledEmExpressCompanys(); 

                if (list != null)
                {
                    skinTextBoxLogisticCompany.DisplayMember = "ExpressCompanyName";
                    skinTextBoxLogisticCompany.ValueMember = "ExpressCompanyName";
                    skinTextBoxLogisticCompany.DataSource = list;
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

        private void Initialize()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                List<EmRetailDetail> listPage = GlobalCache.EMallServerProxy.GetEmRetailDetail(this.Order.ID);
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
            if (Order != null)
            {

                if (Order.MemeberID != null)
                {
                    Member member = CommonGlobalCache.ServerProxy.GetOneMember(Order.MemeberID);
                    skinLabelPhoneNumber.Text = member?.PhoneNumber + "," + member?.Name;
                }

                this.skinLabelMemberAddressPhone.Text = Order.ReceiverName + ","+Order.ReceiverTelphone;
                skinLabelMemberAddress.Text = Order.ReceiverCityZone + Order.ReceiverDetailAddress+"   ";
                this.skinLabelOrderId.Text = Order.ID;
               this.skinLabel3.Text = Order.ExpressCompany;
                this.skinLabel2.Text = Order.ExpressOrderID;
                this.skinLabel6.Text = Order.BuyerMessage;
                skinLabel4.Text =  Order.ShopName;
                this.skinLabelOrderCreateTime.Text = Order.CreateTime.ToString(DateTimeUtil.DEFAULT_DATETIME_FORMAT);
                if (Order.State == 0)
                {
                    this.skinLabelOrderPayTime.Text = String.Empty;
                }
                else
                {
                    this.skinLabelOrderPayTime.Text = Order.TimePay.ToString(DateTimeUtil.DEFAULT_DATETIME_FORMAT);
                }

                this.skinLabelSalePrice.Text = Order.TotalEmOnlinePrice.ToString();// (Order.TotalMoneyReceived - Order.CarriageCost).ToString();
                this.skinLabelCarriage.Text = Order.CarriageCost.ToString();
                this.skinLabelOrderPayAmount.Text = Order.TotalMoneyReceived.ToString();
                skinLabelDiscountAmount.Text = Order.MoneyDeductedByTicket.ToString();
            }
        }


        private void BindingDataSource(List<EmRetailDetail> listPage)
        {
            foreach (var item in listPage)
            {
                item.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(item.CostumeID, item.SizeName);
            }
            this.dataGridView1.DataSource = listPage;
        } 
         

        private void RefreshPageInvoke()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(RefreshPageInvoke));
            }
            else
            {
                this.RefreshPageAction?.Invoke(CurrentTabPage, SourceCtrlType);
            }
        }

       

       

        private void skinLabel16_Click(object sender, EventArgs e)
        {

        }

        private void skinLabelSalePrice_Click(object sender, EventArgs e)
        {

        }
    }


}
