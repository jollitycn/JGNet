using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core.InteractEntity;
using CCWin;

using JGNet.Common.Core;  
using JGNet.Common.Core.Util;
using JGNet.Common.Components;
using CCWin.SkinControl;
using JGNet.Manage.Components;
using JGNet.Common;
using JGNet.Core;
using JGNet.Common.cache.Wholesale;
using System.Threading;

namespace JGNet.Manage
{
    public partial class WholesaleBeginningStoreCtrl1 : BaseModifyUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl2;
        private SupplierAccountRecordPagePara pagePara;

        public Action< BaseUserControl> End;

        ///// <summary>
        ///// 点击查询入库差异单明细
        ///// </summary>
        //public event CJBasic.Action<SupplierAccountRecord,Type>SupplierAccountRecordDetailClick;
        public WholesaleBeginningStoreCtrl1()
        {
            InitializeComponent();
            MenuPermission= RolePermissionMenuEnum.客户期初库存录入;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl2 = new DataGridViewPagingSumCtrl(this.dataGridView2) { ShowRowCounts = false }; 
            dataGridViewPagingSumCtrl2.Initialize(); 
            colorComboBox1.HideEmpty = true;
            colorComboBox1.HideAll = true;
            skinLabelPrice.Text = string.Empty;
        }
         
        private void Initialize()
        {
            skinComboBox_PfCustomer.Initialize(true, true,1); 
            ResetAll(false);
        }

        private void BindingSource(List<PfCustomerStore> listPage)
        {
          if (this.InvokeRequired)
            {
                this.BeginInvoke(new  CJBasic.CbGeneric<List<PfCustomerStore>>(this.BindingSource), listPage);
            }
            else
            {

                if (listPage != null)
                {
                    for (int i=0;i<listPage.Count;i++)
                    {
                        listPage[i].CostumeName = CommonGlobalCache.GetCostumeName(listPage[i].CostumeID);
                        listPage[i].PfCustomerName = PfCustomerCache.GetPfCustomerName(listPage[i].PfCustomerID);
                         // Thread.Sleep(2);
                       //UpdateProgress("正在加载中 ");
                    }
                }
                dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerStore>(DataGridViewUtil.ListToBindingList(listPage));
                //CompleteProgressForm();
            } 
         
        }

        public override void RefreshPage()
        {
            this.BaseButton_Search_Click(null, null);
        }


        private void SupplierAccountSearchCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
            this.BaseButton_Search_Click(null, null);
        }

        private void Search()
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoSwitchShop);
                cb.BeginInvoke(null, null);
                //ShowProgressForm();
               
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }

        }

        private void CompleteEdit()
        {
            //if (this.InvokeRequired)
            //{
            //    this.BeginInvoke(new CJBasic.CbGeneric(this.CompleteEdit));
            //}
            //else
            //{
            //    CompleteProgressForm();
            //}
        }

        private void CompleteEdit(List<PfCustomerStore> listPage)
        {
           if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<List<PfCustomerStore>>(this.CompleteEdit), listPage);
            }
            else
            {
                DateTime startTime = DateTime.Now;
                this.curInboundDetailList = listPage;
                this.BindingSource(listPage);
              
              DateTime endTime = DateTime.Now;
              TimeSpan span = (TimeSpan)(endTime - startTime);
              WriteLog("客户期初导入界面加载开始时间：" + startTime + " 结束时间：" + endTime + " 总耗时数：" + span.TotalSeconds + "秒");
              CompleteEdit();
          }
        }



        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void DoSwitchShop()
        {
            try
            {
                List<PfCustomerStore> listPage = GlobalCache.ServerProxy.GetPfCostumeStores("","",0);
                
                //InitProgress(listPage.Count, "加载中……");
                //for (int i = 0; i < listPage.Count; i++)
                //{
                //    UpdateProgress(listPage.Count,i);
                //}

                CompleteEdit(listPage);
                /* this.curInboundDetailList = listPage;
                 this.BindingSource(listPage);*/

            }
            catch (Exception ex)
            {
                //FailedProgress(ex);
                ShowError(ex);
            }
            finally
            {
               // CompleteProgressForm();
                UnLockPage();
            }
        }

        private void BaseButtonSaveAccount_Click(object sender, EventArgs e)
        {
            try
            {  
                    if (pfCustomer==null)
                {
                    GlobalMessageBox.Show("款号不能为空！");
                    skinTextBoxID.Focus();
                    return;
                }else
                if (String.IsNullOrEmpty(skinTextBoxID.Text))
                {
                    GlobalMessageBox.Show("款号不能为空！");
                    skinTextBoxID.Focus();
                    return;
                }else
                if (skinTextBoxID.Text.Contains("#"))
                {
                    
                    GlobalMessageBox.Show("款号不能使用“#”！");
                    skinTextBoxID.Focus();
                    return;
                }
                else
                  if (String.IsNullOrEmpty(skinTextBox_Name.Text))
                {
                    GlobalMessageBox.Show("商品名称不能为空！");
                    skinTextBox_Name.Focus();
                    return;
                }

                CostumeColor color = colorComboBox1.SelectedItem as CostumeColor;
                if (String.IsNullOrEmpty(color?.Name))
                {

                    GlobalMessageBox.Show("颜色不能为空！");
                    colorComboBox1.Focus();
                    return;
                }

                PfCustomerStore detail = addValue[0];
                detail.ColorName = ValidateUtil.CheckEmptyValue(color?.Name);
                detail.CostumeID = skinTextBoxID.Text;
                detail.CostumeName = skinTextBox_Name.Text;
                detail.PfCustomerID = pfCustomer.ID;
                detail.PfCustomerName = pfCustomer.Name;
                detail.PfPrice = this.textBoxAmount.Value;
                //Shop shop = (Shop)skinComboBoxShopID.SelectedItem;
                //detail.ShopID = shop.ID;
                //detail.ShopName = shop.Name;

                //判断是否存在相同款号颜色，如果有则提示是否累加，确定就累加原来的，否的话则取消
                if (curInboundDetailList.Exists(t => t.PfCustomerID == detail.PfCustomerID && t.CostumeID == detail.CostumeID && t.ColorName == detail.ColorName))
                {

                    PfCustomerStore existDetail = curInboundDetailList.Find(t => t.PfCustomerID == detail.PfCustomerID && t.CostumeID == detail.CostumeID && t.ColorName == detail.ColorName);
                    dataGridViewPagingSumCtrl.ScrollToRowIndex(curInboundDetailList.IndexOf(existDetail));
                    if (GlobalMessageBox.Show("库存信息已存在，是否进行累加？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                     existDetail.XS += detail.XS;
                    existDetail.S += detail.S;
                    existDetail.M += detail.M;
                    existDetail.L += detail.L;
                    existDetail.XL += detail.XL;
                    existDetail.XL2 += detail.XL2;
                    existDetail.XL3 += detail.XL3;
                    existDetail.XL4 += detail.XL4;
                    existDetail.XL5 += detail.XL5;
                    existDetail.XL6 += detail.XL6;
                    existDetail.F += detail.F;
                    existDetail.PfPrice = detail.PfPrice;
                }
                else
                {
                    curInboundDetailList.Add(detail);
                }

                ResetAll();
                this.BindingInboundDetailSource();
                HighlightCostume(detail);
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        private List<PfCustomerStore> addValue = new List<PfCustomerStore>();

        private void ResetAll(bool restColor = true)
        {
            addValue.Clear();
            addValue.Add(new PfCustomerStore());
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = addValue;
            
            this.skinTextBoxID.Text = string.Empty;
            skinTextBox_Name.Text = string.Empty;
            if (restColor)
            {
                colorComboBox1.Filter(null);
            }
        }

        private List<PfCustomerStore> curInboundDetailList = new List<PfCustomerStore>();//当前要入库的PfCustomerStore


        private void BindingInboundDetailSource()
        {

              try
              {
                  if (GlobalUtil.EngineUnconnectioned(this))
                  {
                      return;
                  }
                  dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerStore>(DataGridViewUtil.ListToBindingList(this.curInboundDetailList));

                  dataGridViewPagingSumCtrl.ScrollToEnd();
              }
              catch (Exception ee)
              {
                  GlobalUtil.ShowError(ee);
              }
              finally
              {
                  GlobalUtil.UnLockPage(this);
              }
              
            /*  dataGridViewPagingSumCtrl.BindingDataSource<PfCustomerStore>(this.curInboundDetailList);
              dataGridViewPagingSumCtrl.ScrollToEnd();*/
        }



        private void HighlightCostume(PfCustomerStore store)
        {
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    PfCustomerStore rowStore = row.DataBoundItem as PfCustomerStore;
                    if (rowStore.PfCustomerID == store.PfCustomerID && rowStore.CostumeID == store.CostumeID && rowStore.ColorName == store.ColorName)
                    {
                        row.DefaultCellStyle.ApplyStyle(new DataGridViewCellStyle()
                        {
                            BackColor = Color.LightYellow
                        });
                    }
                } 
            }
        } 

        private object GetEntity()
        {
            PfCustomerStore item = new PfCustomerStore();
            return item;
        }
         
        private void BaseButtonRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshPage();
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            this.BaseButton_Search_Click(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                /* switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                 {
                     case "删除":*/

                if (e.ColumnIndex == Column1.Index)
                {
                    //try
                    //{
                    //   
                        this.curInboundDetailList.RemoveAt(e.RowIndex);
                    //this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    // this.dataGridView1.Rows[e.RowIndex].Visible= false;
                    this.BindingInboundDetailSource();
                    //}
                    //catch (Exception ex)
                    //{
                    //    ShowError(ex);
                    //}
                    //finally
                    //{
                    //    UnLockPage();
                    //}

                }
        //   break;
        // }
    }
            catch (Exception ee)
            {

                GlobalUtil.ShowError(ee);
            }
            finally
            {
                UnLockPage();
            }
        }

        Costume costumeItem;
        private void skinTextBoxID_CostumeSelected(Costume costumeItem, bool isEnter)
        {
            if (isEnter)
            {
                ResetAll();
                this.costumeItem = costumeItem;
                if (costumeItem == null)
                {
                    this.textBoxAmount.Text = string.Empty;
                    skinLabelPrice.Text = string.Empty;
                }
                else
                {
                    //计算客户折扣 批发价
                    this.textBoxAmount.Value = costumeItem.Price == 0 ? 0 : Math.Round(costumeItem.Price * pfCustomer.PfDiscount * (decimal)0.01, MidpointRounding.AwayFromZero);
                    skinLabelPrice.Text = costumeItem.Price.ToString();
                }
                this.SetCostumeDetails(costumeItem);
            }
        }

        private void SetCostumeDetails(Costume costumeItem)
        {
            if (costumeItem != null)
            {
                this.skinTextBoxID.Text = costumeItem.ID;
                skinTextBox_Name.Text = costumeItem.Name;
                //    this.colorComboBox1.DataSource = ;
                if (String.IsNullOrEmpty(costumeItem.Colors))
                {
                    this.colorComboBox1.Filter(null);
                }
                else
                {
                    this.colorComboBox1.Filter(costumeItem.Colors.Split(','));
                }
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isPfCustomerStoreList = dataGridView.DataSource is List<PfCustomerStore>;
            try
            {
                decimal newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Decimal.Parse(e.FormattedValue.ToString());
                   // newCount = Convert.ToInt32(e.FormattedValue);
                }
                if (newCount < 0)
                {
                    GlobalMessageBox.Show("不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
            dataGridView.Refresh();
        }

        private void baseButtonEnd_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalMessageBox.Show("期初客户库存只能录入一次，确定录入完毕？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                TabPageClose(this.CurrentTabPage, this.SourceCtrlType);
                GlobalUtil.SaveParameters(ParameterConfigKey.IsHideCreatePfStore, "1");
                End?.Invoke(this);
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void baseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pfCustomer == null)
                {
                    GlobalMessageBox.Show("客户不存在，请重新选择！");
                    skinComboBox_PfCustomer.Focus();
                    return;
                }
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                CreatePfCostumeStore cPfCostumeStore = new CreatePfCostumeStore();
                InteractResult result =  GlobalCache.ServerProxy.InsertPfCostumeStores(cPfCostumeStore);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalMessageBox.Show("保存成功！");
                        //baseButton3.Enabled = false;
                        //baseButtonEnd.Visible = false;
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                } 
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }  

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.ColumnIndex< xSDataGridViewTextBoxColumn.Index || e.ColumnIndex>fDataGridViewTextBoxColumn.Index)
            {
                return;
            }
            DataGridView dataGridView = (DataGridView)sender;
            bool isPfCustomerStoreList = dataGridView.DataSource is List<PfCustomerStore>;
            try
            {

                int newCount = 0;
                if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    newCount = Convert.ToInt32(e.FormattedValue);
                }
                if (newCount < 0)
                {
                    GlobalMessageBox.Show("不能小于0！");
                    dataGridView.CancelEdit();
                    return;
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show("输入格式错误！");
                dataGridView.CancelEdit();
            }
            dataGridView.Refresh();
        }
         
        PfCustomer pfCustomer;
        private void skinComboBox_PfCustomer_ItemSelected(PfCustomer obj)
        {
            pfCustomer = obj;
            if (costumeItem != null)
            {
                this.textBoxAmount.Value = costumeItem.Price == 0 ? 0 : Math.Round(costumeItem.Price * pfCustomer.PfDiscount * (decimal)0.01, MidpointRounding.AwayFromZero);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 )
            {
                return;
            }
            dataGridView1.Refresh();
        }
    }
}

