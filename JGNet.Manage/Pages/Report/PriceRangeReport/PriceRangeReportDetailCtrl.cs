using System;
using System.Collections.Generic; 

using JGNet.Core.InteractEntity; 
using JGNet.Common.Core;   
using CJBasic.Helpers;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using System.Windows.Forms;
using JGNet.Common;

namespace JGNet.Manage
{
    public partial class PriceRangeReportDetailCtrl : BaseModifyUserControl
    {



        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public PriceRangeReportDetailCtrl()
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl =   new DataGridViewPagingSumCtrl(dataGridViewDetail, new string[] {
               countDataGridViewTextBoxColumn.DataPropertyName,
               moneyDataGridViewTextBoxColumn.DataPropertyName,
               CountRate.DataPropertyName,
               MoenyRate.DataPropertyName
            }) ;

            dataGridViewPagingSumCtrl.Initialize();
        } 
        


        private void Initialize()
        {  
          this.dataGridViewDetail.DataSource = null;
            
        }
        private bool reportShowZero;
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
        }


        /// <summary>
        /// 绑定RetailDetail数据源并设置下方的Label值
        /// </summary>
        private void BindingDataSource(List<PriceRangeReport> retailDetailList)
        {
         this.dataGridViewDetail.DataSource = null;
                if (retailDetailList != null && retailDetailList.Count > 0)
                {
                foreach (PriceRangeReport detail in retailDetailList)
                {
                    //Costume costume= GlobalCache.GetCostume(detail.CostumeID);
                    //detail.CostumeName = costume.Name;
                    ////按款查询需要前端补充颜色信息
                    //if (string.IsNullOrEmpty(detail.ColorName))
                    //{
                    //    detail.ColorName = costume.Colors;
                    //}
                    detail.ShopName = GlobalCache.GetShopName(detail.ShopID);
                }
                // this.dataGridViewDetail.DataSource = retailDetailList; 
                this.dataGridViewPagingSumCtrl.BindingDataSource< PriceRangeReport>(DataGridViewUtil.ToDataTable<PriceRangeReport>(retailDetailList));

            }
        }


        public void SearchDetailList(GetShopPriceRangeReportPara para)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                 
                List<PriceRangeReport> listPage = GlobalCache.ServerProxy.GetShopPriceRangeReport(para);

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



        private void PriceRangeReportDetailCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }
    }
}
