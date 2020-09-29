using CCWin;
using JGNet.Common;
using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using JGNet.ForManage;
using CJBasic;
using JieXi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    public partial class WholesaleCustomerManageCtrl : BaseUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        public WholesaleCustomerManageCtrl()
        {
            InitializeComponent();
            MenuPermission =RolePermissionMenuEnum.客户管理;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButtonQuery_Click);
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
                 remarksDataGridViewTextBoxColumn });
            
            dataGridViewPagingSumCtrl.Initialize(); 
        } 

        public override void RefreshPage()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.RefreshPage));
            }
            else
            {
                if (para != null)
                {
                    dataGridViewPagingSumCtrl_CurrentPageIndexChanged(para.PageIndex);
                }
            }
        }

        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            if (this.para != null)
            {
                para.PageIndex = index;
                PfCustomerPage page = GlobalCache.ServerProxy.GetPfCustomerPage(para);
                this.BindingCostumeStoreDataSource(page);
            }
        }

        GetPfCustomerPagePara para;

        private void BaseButtonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                this.para = new GetPfCustomerPagePara()
                {
                    IdOrName = this.skinTextBoxName.SkinTxt.Text,
                    PageIndex = 0,
                    PageSize = dataGridViewPagingSumCtrl.PageSize,
                       
                };

                dataGridViewPagingSumCtrl.OrderPara = para;
                PfCustomerPage listPage =  GlobalCache.ServerProxy.GetPfCustomerPage(para);
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                this.BindingCostumeStoreDataSource(listPage);
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

        private void BindingCostumeStoreDataSource(PfCustomerPage listPage)
        {
            dataGridViewPagingSumCtrl.BindingDataSource(listPage?.PfCustomers,null, listPage?.TotalEntityCount);
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            SaveClick?.Invoke(null, this);
        }

        public event CJBasic.Action<PfCustomer, BaseUserControl> SaveClick;
        public event CJBasic.Action<PfCustomer, BaseUserControl> BalanceDetailClick;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                 /*   if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }*/
                    List<PfCustomer> list = (List<PfCustomer>)this.dataGridView1.DataSource;
                    PfCustomer item = (PfCustomer)list[e.RowIndex];
                    switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {
                        case "余额明细":
                          this.BalanceDetailClick?.Invoke(item, this);
                            break;
                        case "编辑":
                            this.SaveClick(item, this);
                            break;
                        case "删除":
                            if (GlobalMessageBox.Show("删除之后将查不到该客户的往来账，确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Remove(list, item);
                            }
                            break;
                    }
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

        private void Remove(List<PfCustomer>  list, PfCustomer item)
        {
            InteractResult result = PfCustomerCache.PfCustomer_OnRemove(item.ID);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    TreeModel treeM = new TreeModel();
                    treeM.ID = item.ID;
                    treeM.Name = item.Name;
                    CommonGlobalCache.DeletePFDistributor(treeM);
                    GlobalMessageBox.Show("删除成功！");
                    this.dataGridView1.DataSource = null;
                    list.Remove(item);
                    this.dataGridView1.DataSource = list;
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    break;
            }
        }

        private void PfCustomerManageCtrl_Load(object sender, EventArgs e)
        { 
            this.dataGridView1.DataSource = null;
            this.skinTextBoxName.SkinTxt.Text = string.Empty;

            BaseButtonQuery_Click(null, null);
        } 

        private void baseButton2_Click(object sender, EventArgs e)
        {
            try {
                WholesaleCustomerRechargeForm form = new WholesaleCustomerRechargeForm();
                form.PfCustomerRechargeRecordSuccess += WholesaleCustomerRechargeForm_PfCustomerRechargeRecordSuccess;
                form.ShowDialog();
            }
            catch (Exception ex) {
                ShowError(ex);
            }
        }

        private void WholesaleCustomerRechargeForm_PfCustomerRechargeRecordSuccess(PfCustomerRechargeRecord obj)
        {
            this.RefreshPage();
        }



        private void baseButtonImport_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetFileToOpen("请选择导入文件");
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            string fileExt = Path.GetExtension(path);
            if (fileExt != ".xlsx" && fileExt != ".xls")
            {
                ShowMessage("你所选择文件格式不正确，请重新上传文件！");
                return;
            }
            if (GlobalMessageBox.Show("是否开始导入" + System.IO.Path.GetFileName(path), "友情提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                path = null;
                return;
            }

            if (NPOIHelper.IsFileInUse(path))
            {
                ShowMessage("你所选择文件已被打开，请关闭后再重新导入！");
                return;
            }
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoImport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }

        }



        private String path;
        private void DoImport()
        {
            try
            {
                List<PfCustomer> emptyStore = new List<PfCustomer>();
                List<PfCustomer> stores = new List<PfCustomer>();
                List<PfCustomer> repeatItems = new List<PfCustomer>();
                DataTable dt = NPOIHelper.FormatToDatatable(path, 0);
                for (int i = 1; i < dt.Rows.Count; i++)
                {

                    DataRow row = dt.Rows[i];
                    int index = 0;
                    PfCustomer store = new PfCustomer();
                    try
                    {
                        if (!CommonGlobalUtil.ImportValidate(row, 10))
                        {
                            // 名称 进货折扣    联系人 联系电话    银行账户信息 应付款结余（正数表示欠供应商）	最后一次记账时间 创建时间    序号 备注

                            store.ID = "" + (i + 2);
                            store.Name = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.PfDiscount = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.Contact = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.ContactPhone = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.BankInfo = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.PaymentBalance = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.LastAccountTime = DateTimeUtil.ConvertToDateTime(CommonGlobalUtil.ConvertToString(row[index++]));
                            store.Balance = CommonGlobalUtil.ConvertToDecimal(CommonGlobalUtil.ConvertToString(row[index++]));
                            store.CreateTime = DateTimeUtil.ConvertToDateTime(CommonGlobalUtil.ConvertToString(row[index++]));
                            store.Remarks = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.FirstCharSpell = DisplayUtil.GetPYString(store.Name);
                            int tempindex = index++;
                            
                            store.CustomerType = (byte)CommonGlobalUtil.ConvertToInt16(row[tempindex]);
                            if (String.IsNullOrEmpty(store.Name)||String.IsNullOrEmpty(row[tempindex].ToString()))
                            {
                                //必填项为空
                                emptyStore.Add(store);
                                continue;
                            }
                            else
                            {
                                //判断是否重复款号/颜色
                                if (stores.Find(t => t.Name == store.Name) != null)
                                {
                                    repeatItems.Add(store);
                                    continue;
                                }

                                stores.Add(store);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                if (emptyStore.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in emptyStore)
                    {
                        str += "第" + item.ID + "行\r\n";
                    }
                    ShowError("必填项没有填写，请补充完整！\r\n" + str);
                    return;
                }
                if (repeatItems.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in repeatItems)
                    {
                        str += "第" + item.ID + "行" + "\r\n";
                    }
                    ShowError("名称重复，系统已过滤，详见错误报告！\r\n" + str);
                    //  return;
                }
                if (stores != null && stores.Count > 0)
                {
                }
                else
                {
                    ShowMessage("没有数据可以导入，请检查列表信息！");
                    return;
                }
                path = null;
                //檢查結果
                InteractResult result = GlobalCache.ServerProxy.ImportPfCustomer(stores);
                switch (result.ExeResult)
                {
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    case ExeResult.Success:
                        RefreshPage();
                        ShowMessage("导入成功！");
                        break;
                    default:
                        break;
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
         
        private void baseButton4_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "客户" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoExport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
        }
        private void DoExport()
        {
            try
            {

                List<PfCustomer> list = (List<PfCustomer>)this.dataGridView1.DataSource; ;
                System.Collections.SortedList columns = new System.Collections.SortedList();
                List<String> keys = new List<string>();
                List<String> values = new List<string>();
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    if (item.Visible)
                    {
                        if (item.Name != "Column1" &&item.Name != "Column2" && item.Name != "Column3" && item.Name != "enabledDataGridViewCheckBoxColumn")
                        {
                            keys.Add(item.DataPropertyName);
                            values.Add(item.HeaderText);
                        }
                    }
                }
              



                NPOIHelper.Keys = keys.ToArray();
                NPOIHelper.Values = values.ToArray();
                NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);

                GlobalMessageBox.Show("导出完毕！");
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }
    }
}
