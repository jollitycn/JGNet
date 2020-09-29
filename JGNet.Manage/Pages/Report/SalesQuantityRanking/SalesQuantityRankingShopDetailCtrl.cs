using System;
using System.Collections.Generic; 

using JGNet.Core.InteractEntity; 
using JGNet.Common.Core;   
using CJBasic.Helpers;
using JGNet.Common.Components;
using System.Windows.Forms;
using JGNet.Common.Core.Util;
using JGNet.Common;

namespace JGNet.Manage
{
    public partial class SalesQuantityRankingShopDetailCtrl : BaseModifyUserControl
    {


        DataGridViewPagingSumCtrl dataGridSumCtrl;
        public SalesQuantityRankingShopDetailCtrl()
        {
            InitializeComponent();
            DataGridViewPagingSumCtrl dataGridSumCtrl = new DataGridViewPagingSumCtrl(dataGridViewDetail);
            dataGridSumCtrl.Initialize();
            dataGridViewTextBoxColumn14.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
            dataGridViewTextBoxColumn13.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
            LastSaleTime.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
        } 
        


        private void Initialize()
        {  
          this.dataGridViewDetail.DataSource = null;
            
        }


        /// <summary>
        /// 绑定RetailDetail数据源并设置下方的Label值
        /// </summary>
        private void BindingDataSource(List<SalesQuantityRanking> retailDetailList)
        {
            this.dataGridViewDetail.DataSource = null;
            if (retailDetailList != null && retailDetailList.Count > 0)
            {
                foreach (SalesQuantityRanking detail in retailDetailList)
                {
                    Costume costume = GlobalCache.GetCostume(detail.CostumeID);
                    detail.CostumeName = costume?.Name;
                    //按款查询需要前端补充颜色信息
                    if (string.IsNullOrEmpty(detail.ColorName))
                    {
                        detail.ColorName = costume?.Colors;
                    }
                    detail.ShopName = GlobalCache.GetShopName(detail.ShopID);
                }
                this.dataGridViewDetail.DataSource = retailDetailList;
            }
        }


        public void SearchDetailList(SalesQuantityRankingsPara para)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                List<SalesQuantityRanking> listPage = GlobalCache.ServerProxy.GetSalesQuantityRankings(para);
                if (this.dataGridSumCtrl!=null && !this.dataGridSumCtrl.IsPageSet)
                {
                    dataGridViewTextBoxColumn14.Visible = true;
                    dataGridViewTextBoxColumn13.Visible = true;
                    LastSaleTime.Visible = true;
                dataGridViewTextBoxColumnColor.Visible = true;
                }
                switch (para.QueryType)
                {
                    case QueryType.CostumeID:

                       
                            dataGridViewTextBoxColumnColor.Visible = false;
                         
                        SizeName.Visible = false;
                        break;
                    case QueryType.ColorName: 
                        SizeName.Visible = false;
                        break;
                    case QueryType.CostumeIDColorNameSize:
                        //if (!this.dataGridSumCtrl.IsPageSet)
                        //{
                            LastSaleTime.Visible = false;
                            dataGridViewTextBoxColumn14.Visible = false;
                            dataGridViewTextBoxColumn13.Visible = false;
                        //}
                        break;
                    default:
                        break;
                } 
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



        private void SalesQuantityRankingShopDetailCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private bool reportShowZero;
        private void dataGridViewDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }
    }
}
