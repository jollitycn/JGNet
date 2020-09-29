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
using JGNet.Core.MyEnum; 

namespace JGNet.Manage

{
    public partial class WholesaleEmOrderDetailCtrl : BaseModifyCostumeIDUserControl
    {
        private GetEmCostumePagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
         

        private PfCustomerOrder Order { get; set; }

        public override void RefreshPage()
        {
            if (pagePara != null)
            {

            }
        }

        public WholesaleEmOrderDetailCtrl(PfCustomerOrder order)
        {
            InitializeComponent();
            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1,new String[] {
                DeliveryCount.DataPropertyName,
                SumMoney.DataPropertyName

            });
            dataGridViewPagingSumCtrl.Initialize();
            this.Order = order;

            if (Order != null)
            {  
                Display();
                Initialize();
            }
        }
        BaseUserControl sourceCtrl = null;
        public WholesaleEmOrderDetailCtrl(String orderID, BaseUserControl sourceCtrl = null)
        {
            InitializeComponent();
            //  this.Controls.Add(imageCtrl);
           // ShowMessage("SourceCtrlType1:" + this);
            //ShowMessage( "SourceCtrlType:" + this.SourceCtrlType.ToString());
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            this.sourceCtrl = sourceCtrl;
            GetPfCustomerOrderPagePara para = new GetPfCustomerOrderPagePara()
            {
                CustomerOrderId = orderID,
                PageIndex = 0,
                PageSize = 1
            };
            PfCustomerOrderPage listPage = GlobalCache.EMallServerProxy.GetPfCustomerOrderPage(para);
            if (listPage != null && listPage.PfCustomerOrders.Count == 1)
            {
                //获取order
                this.Order = listPage.PfCustomerOrders[0];
                //skinLabel2.Text = Order.PayTypeName;
            }
            skinLabelRemarks.Text = Order.Remarks;
            skinLabelOrderId.Text = orderID;

            if (Order != null)
            {
                Display();
                Initialize();
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
              //  ShowMessage(this.SourceTabPage.ToString());
                PfCustomerDetails listPage = GlobalCache.EMallServerProxy.GetPfCustomerDetails(this.Order.ID);
                Dictionary<PfOrder, List<PfCustomerDetail>> Dlist = listPage.DeliveryDict;
                List<PfCustomerDetail> list = new List<PfCustomerDetail>();
                foreach (var item in Dlist)
                {
                    if (item.Key.PfCustomerOrderID == this.Order.ID)
                    {
                        list = item.Value;
                    }
                } 
                if (sourceCtrl.ToString() == "JGNet.Common.WholesaleCustomerBalanceDetailCtrl")
                {
                    if (list.Count == 0&& listPage.NotDeliverys.Count>0)
                    {  
                        list = listPage.NotDeliverys;
                    }
                }
                this.BindingDataSource(list);
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
                this.skinLabelOrderId.Text = Order.ID;
                skinLabelRemarks.Text = Order.Remarks;
            }
        }


        private void BindingDataSource(List<PfCustomerDetail> listPage)
        {
            foreach (var item in listPage)
            {
                item.SizeDisplayName = CommonGlobalUtil.GetCostumeSizeName(item.CostumeID, item.SizeName);
            }
            this.dataGridView1.DataSource = listPage;
        } 
         
 
    }


}
