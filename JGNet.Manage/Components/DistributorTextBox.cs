using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CCWin.SkinControl;
using CCWin; 
using JGNet.Common;
using JGNet.Common.cache.Wholesale;

namespace JGNet.Manage
{
    public partial class DistributorTextBox : Common.TextBox
    {
        /// <summary>
        /// 款号被选中时触发
        /// </summary>
        public event System.Action<Distributor> ItemSelected;
        public bool HideEmpty { get; set; }
        /// <summary>
        /// 判断是否需要作会员检查
        /// </summary> 
        public bool CheckPfCustomer { get; set; } 
        public DistributorTextBox()
        {
            InitializeComponent(); 
            Text = "";
            WaterText = "输入编号/名称并回车";
            Leave += SkinTxt_Leave;
            PreviewKeyDown += SkinTxt_PreviewKeyDown;
            //如果是普通输入模式的话则TEXTCHANGED
            TextChanged += SkinTxt_TextChanged;
        } 

        private void SkinTxt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.Text))
            {
                this.ItemSelected?.Invoke(null);
            }
            else {
                resultList = GlobalCache.DistributorList.FindAll(t => t.ID.ToUpper().Equals(this.Text.ToUpper())); //CommonGlobalCache.ServerProxy.GetPfCustomersLike4IDOrName(PfCustomerID);




                if (resultList == null || resultList.Count == 0)
                {
                    if (this.ItemSelected != null)
                    {
                        this.ItemSelected(null);
                    } 
                    return;
                }
                if (resultList.Count == 1)
                {
                    this.Text = resultList[0].ID;
                    // this.SkinTxt.Focus();
                    if (this.ItemSelected != null)
                    {
                        this.ItemSelected(resultList[0]);
                    }
                } 
            }
        }

        private void SkinTxt_Leave(object sender, EventArgs e)
        {
            if (CheckPfCustomer)
            {
                String value = this.Text.Trim();
                if (!String.IsNullOrEmpty(value))
                {
                    if (resultList == null)
                    {
                        Search();
                    }
                    if (resultList == null || !resultList.Exists(t => t.ID == value))
                    {
                        GlobalMessageBox.Show("客户不存在，请重新输入！");
                        this.Focus();
                    }
                }
            }
        }

        List<Distributor> resultList = null;
        #region 回车后选择款号
        private void SkinTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            Search();
        }

        private void Search()
        {

            try
            {
                string PfCustomerID = this.Text.Trim();
                if (string.IsNullOrEmpty(PfCustomerID))
                {
                    this.ItemSelected?.Invoke(null);
                    return;
                }

                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                    resultList = GlobalCache.DistributorList.FindAll(t => t.ID.ToUpper().Contains(PfCustomerID.ToUpper()));
                if (resultList == null || resultList.Count == 0)
                {
                    if (this.ItemSelected != null)
                    {
                        this.ItemSelected(null);
                    }
                    //  this.SkinTxt.Text = "";
                    return;
                }
                if (resultList.Count == 1)
                {
                  
                        this.Text = resultList[0].ID;
         
                    this.ItemSelected?.Invoke(resultList[0]);
                }
                else
                {
                    DistributorSelectForm PfCustomerForm = new DistributorSelectForm(PfCustomerID, resultList);
                    PfCustomerForm.ItemSelected += PfCustomerForm_PfCustomerSelected;
                    PfCustomerForm.ShowDialog();
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

        protected void UnLockPage()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new CJBasic.CbGeneric(this.UnLockPage));
            }
            else
            {
                CommonGlobalUtil.UnLockPage(this);
            }
        }

        protected void ShowError(Exception ex)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new CJBasic.CbGeneric<Exception>(this.ShowError), ex);
            }
            else
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void PfCustomerForm_PfCustomerSelected(Distributor PfCustomer, EventArgs args)
        {
            this.Text = PfCustomer.ID;
            this.ItemSelected?.Invoke(PfCustomer);
        }

        private bool hideAll;
        private bool isEnableList;
        public void Initialize(bool hideAll, bool isEnableList)
        {
            this.hideAll = hideAll;
            this.isEnableList = isEnableList;
        }
             

        #endregion
    }
}
