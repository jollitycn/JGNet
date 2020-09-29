using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Core.Util;
using JGNet.Common.Models;
using JGNet.Core.Dev.InteractEntity;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using JGNet.Manage.Pages;
using CJBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class EmOrderReturnAddressForm :
        BaseForm
    { 
         
        public EmOrderReturnAddressForm( )
        {
            InitializeComponent();  
            Display();
        }
        List<EmRefundAddress> list;
       
        private void Display()
        {
            LoadTrack();
        }
        private void LoadTrack()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                list = GlobalCache.EMallServerProxy.GetEmRefundAddressList();
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

        private void BindingDataSource(List<EmRefundAddress> list)
        {
            skinFlowLayoutPanel1.Controls.Clear();
            //第一条是最上面的
            //其他就是下面的内容你给
            if (list != null && list.Count > 0)
            {


                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i].IsDefault)
                    {
                        result = list[i];
                    }

                    EmOrderReturnAddressCtrl ctrl
                    = new EmOrderReturnAddressCtrl(list[i]);
                    ctrl.Selected += EmOrderReturnAddressCtrl_CheckChanged;
                    ctrl.Removed += EmOrderReturnAddressCtrl_Removed;
                    ctrl.Updated += EmOrderReturnAddressCtrl_Update;
                    skinFlowLayoutPanel1.Controls.Add(ctrl);
                }
            }
        }

        private void EmOrderReturnAddressCtrl_Update(EmOrderReturnAddressCtrl obj)
        {
            
            Update( obj.Address);
        }

        private void EmOrderReturnAddressCtrl_Removed(EmOrderReturnAddressCtrl obj)
        {
            if(GlobalMessageBox.Show("删除该条收货地址？","提示", MessageBoxButtons.YesNo) != DialogResult.Yes){
                return;
            }
            skinFlowLayoutPanel1.Controls.Remove(obj);
            Remove(obj.Address);
        }

        private void EmOrderReturnAddressCtrl_CheckChanged(EmOrderReturnAddressCtrl obj)
        {
            //被选中了
            result = obj.Address;

            foreach (var item in skinFlowLayoutPanel1.Controls)
            {
                if (item is EmOrderReturnAddressCtrl)
                {
                    EmOrderReturnAddressCtrl addressCtrl = item as EmOrderReturnAddressCtrl;
                    if (addressCtrl.Address != result)
                    {
                        addressCtrl.SetRadio(false);
                    }
                }
            }
        }

        public EmRefundAddress result;
        private void EmOrderReturnAddressForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmOrderNewAddressForm form
                 = new EmOrderNewAddressForm(null);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                EmRefundAddress address = form.result;
                if (address != null)
                {
                    Insert(address);
                }
            }
        }
        private void Update(EmRefundAddress address)
        {
            try
            {
                UpdateResult result = GlobalCache.EMallServerProxy.UpdateEmRefundAddress(address);
                switch (result)
                {
                    case UpdateResult.Success:
                        break;
                    case UpdateResult.Error:
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

        private void Remove(EmRefundAddress address)
        {
            try
            {
                DeleteResult result = GlobalCache.EMallServerProxy.DeleteEmRefundAddress(address.AutoID);
                switch (result)
                {
                    case DeleteResult.Success:
                       // GlobalMessageBox.Show("删除成功！");
                        break;
                    case DeleteResult.Error:
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
        private void Insert(EmRefundAddress address)
        {
            try
            {
                InsertResult result = GlobalCache.EMallServerProxy.InsertEmRefundAddress(address);
                switch (result)
                {
                    case InsertResult.Success:
                       // GlobalMessageBox.Show("保存成功！");
                        Display();
                        break;
                    case InsertResult.Error:
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

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            if (result == null) {
                GlobalMessageBox.Show("请先新增收货地址!");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
