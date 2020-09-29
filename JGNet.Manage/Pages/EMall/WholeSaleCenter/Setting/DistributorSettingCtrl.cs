using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Core.InteractEntity; 
using CJBasic.Security;
using JGNet.Common.cache.Wholesale;
using JGNet.Common;
using JGNet.Core.Util;
using JGNet.Core;

namespace JGNet.Manage.Pages
{
    public partial class DistributorSettingCtrl : BaseModifyUserControl
    {

       // public Action<PfCustomer> SaveResult;
       // private PfCustomer curPfCustomer = null; 
        public DistributorSettingCtrl()
        {
            InitializeComponent();

            MenuPermission = RolePermissionMenuEnum.分销设置;
            InteractResult<Core.PfCommissionPayWay> result = GlobalCache.ServerProxy.GetPfCommissionPayWay();
            if (result != null)
            {
                PfCommissionPayWay payWay = result.Data;

                if (PfCommissionPayWay.Application == payWay) { skinRadioButtonSale.Checked = true; }
                else
                {
                    skinRadioButtonBuyout.Checked = true;
                }
            }

        }

        public DistributorSettingCtrl(PfCustomer PfCustomer)
        {
            InitializeComponent();
           // this.curPfCustomer = PfCustomer;
           // Display(); 
        }


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                //ShowMessage(Pinyin.GetInitials("埼", Encoding.GetEncoding("GB2312")));

                PfCommissionPayWay payWay = new PfCommissionPayWay();
                if (skinRadioButtonSale.Checked == true)
                {
                    payWay = PfCommissionPayWay.Application;
                }
                else
                {
                    payWay = PfCommissionPayWay.Active;
                }

                
              InteractResult result=GlobalCache.ServerProxy.SetPfCommissionPayWay(payWay);

                if (result.ExeResult == ExeResult.Success)
                {
                    GlobalMessageBox.Show("保存成功！");

                } else
                {
                    GlobalMessageBox.Show(result.Msg);
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

        public void RefreshPfCustomer(PfCustomer e)
        {
            //curPfCustomer = e;
            //Display();

        }

        private void Display()
        {
            //if (curPfCustomer != null)
            //{
               
            //    skinRadioButtonSale.Checked = this.curPfCustomer.CustomerType == 1;
            //    skinRadioButtonBuyout.Checked = this.curPfCustomer.CustomerType == 0;
            //   // this.skinTextBox_Name.Enabled = false;
            //}
        }



        private String GetNewId()
        {
            String id = string.Empty;
            InteractResult result = GlobalCache.ServerProxy.GetPfCustomerId();
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    id = result.Msg;
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    break;
            }
            return id;
        }


    
    


    

      
    }

}
