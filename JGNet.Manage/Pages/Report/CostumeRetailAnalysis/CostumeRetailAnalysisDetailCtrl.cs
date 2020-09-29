using System;
using System.Collections.Generic; 

using JGNet.Core.InteractEntity; 
using JGNet.Common.Core;   
using CJBasic.Helpers;
using JGNet.Common.Components;
using System.Windows.Forms;
using JGNet.Server.Tools;

namespace JGNet.Manage
{
    public partial class CostumeRetailAnalysisDetailCtrl : BaseModifyUserControl
    {
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private CostumeRetailAnalysisPagePara para;

        public CostumeRetailAnalysisDetailCtrl(CostumeRetailAnalysisPagePara para)
        {
            InitializeComponent();
            dataGridViewDetail.AutoGenerateColumns = false;
            this.para = para;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridViewDetail, null);
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.OrderSearch += Search;
            this.Initialize();
            SearchDetailList();
        } 
        


        private void Initialize()
        {  
          //this.dataGridViewDetail.DataSource = null;  
        }


        /// <summary>
        /// 绑定RetailDetail数据源并设置下方的Label值
        /// </summary>
        private void BindingDataSource(
               CostumeRetailAnalysisPage listPage)
        {
            this.dataGridViewDetail.DataSource = null; 
            if (listPage != null && listPage.CostumeRetailAnalysisList != null)
            {
                foreach (CostumeRetailAnalysis item in listPage.CostumeRetailAnalysisList)
                {
                    Costume costume = GlobalCache.GetCostume(item.CostumeID);
                    //按款查询需要前端补充颜色信息
                    if (string.IsNullOrEmpty(item.ColorName))
                    {
                        item.ColorName = costume.Colors;
                    }
                    item.Price = costume.Price;
                    item.BigClass = costume.BigClass;
                    item.SmallClass = costume.SmallClass;
                    item.Season = costume.Season;
                    item.Year = costume.Year;
                    item.CostumeName = costume.Name;
                    item.BrandName = GlobalCache.GetBrandName(costume.BrandID);
                    item.ShopName = GlobalCache.GetShopName(item.ShopID);
                    decimal totalPrice = item.Price * item.QuantityOfSale;
                    if (totalPrice == 0)
                    {
                        item.AvgDiscount = 100;
                    }
                    else
                    {
                        item.AvgDiscount = MathHelper.Rounded(item.MoneyOfSale / totalPrice, 2);
                    }
                }
                this.dataGridViewDetail.DataSource = listPage?.CostumeRetailAnalysisList;
            }
        }

        private void Search(Object sender, EventArgs args) {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }


                CostumeRetailAnalysisPage listPage = GlobalCache.ServerProxy.GetCostumeRetailAnalysisPage(para);

                this.BindingDataSource(listPage);
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
        public void SearchDetailList()
        {

            dataGridViewPagingSumCtrl.OrderPara = this.para;
            Search(null, null);
        }



        private void CostumeRetailAnalysisDetailCtrl_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewDetail_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataGridViewDetail.Rows[e.RowIndex];
            CostumeRetailAnalysis order = (CostumeRetailAnalysis)row.DataBoundItem;

            if (InboundDays.Index == e.ColumnIndex)
            {
                e.Value = order.InboundDays;

            }
            else if (UnmovedDays.Index == e.ColumnIndex)
            {
                e.Value = order.UnmovedDays;
            } 
        }
    }
}
