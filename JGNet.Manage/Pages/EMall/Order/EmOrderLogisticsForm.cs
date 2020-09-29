using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
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
    public partial class EmOrderLogisticsForm :
        BaseForm
    {

        public EmRetailOrder Order { get; private set; }


        public EmOrderLogisticsForm(EmRetailOrder order)
        {
            InitializeComponent();
            this.Order = order;
            Display();
        }


        private void Display()
        {
            skinLabelReceiveAddress.Text = Order.ReceiverCityZone + "" + Order.ReceiverDetailAddress;
            skinLabelReceiver.Text = Order.ReceiverName + "，" + Order.ReceiverTelphone;
            // skinLabelRemarks.Text = Order.BuyerMessage;
            skinLabelCompany.Text = this.Order.ExpressCompany;
            skinLabelLogisticOrderId.Text = this.Order.ExpressOrderID;

        }



        private void GetInfo()
        {


            try
            {
                // this.Order.ExpressCompany = "yuantong";
                // this.Order.ExpressOrderID = "800458383600959695";

                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                if (!(string.IsNullOrEmpty(this.Order.ExpressCompany) || string.IsNullOrEmpty(this.Order.ExpressOrderID)))
                {
                    String result = KuaiDi100Helper.WebQueryJson(GlobalUtil.GetExpressCode(this, this.Order.ExpressCompany), this.Order.ExpressOrderID);
                    JavaScriptObject jObject = (JavaScriptObject)JavaScriptConvert.DeserializeObject(result);
                    String state = jObject["state"].ToString();
                    //查询失败
                    String msg = jObject["message"].ToString();
                    String status = jObject["status"].ToString();
                    //  skinLabelResult.Text = status + " " + msg + "\r\n";
                    if (status != "200")
                    {
                        richTextBox1.Text = status + " " + msg + "\r\n";
                    }

                    JavaScriptArray data = (JavaScriptArray)jObject["data"];
                    foreach (JavaScriptObject item in data)
                    {
                        // skinLabelResult.Text += item["ftime"] + " " + item["context"] + "\r\n";
                        richTextBox1.Text += item["ftime"] + " " + item["context"] + "\r\n";
                    }
                }
                else
                {
                    //    skinLabelResult.Text = "没有物理信息";
                    richTextBox1.Text = "没有物流信息";
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

        private void EmOrderLogisticsForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                //异步调用

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
