using JGNet.Common;
using JGNet.Core.InteractEntity;
using JieXi.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JGNet.Manage
{
    public static class EmExportUtil
    {
        public static List<CellType> getSaleCellList(EmOrderExportData emOrderInfo)
        {
            List<CellType> cellList = new List<CellType>(); 

          /*  CellType curCell = new CellType();
            curCell.RowIndex = 0;
            curCell.CellName = "调拨单";
            curCell.Title = true;
            curCell.CellMergeNum = ColNum;


            // curCell.CellMergeIndex = 12;
            cellList.Add(curCell);*/

            CellType curCellSys1 = new CellType();
            curCellSys1.RowIndex = 0;
            curCellSys1.CellName = "FA3";
            curCellSys1.CellMergeNum = 1;
            cellList.Add(curCellSys1);

            CellType curCellSys2 = new CellType();
            curCellSys2.RowIndex = 0;
            curCellSys2.CellName = "批发销货单";
            curCellSys2.CellMergeNum = 1;
            cellList.Add(curCellSys2);


            CellType curCellSys3 = new CellType();
            curCellSys3.RowIndex = 1;
            curCellSys3.CellName = "DJBH";
            curCellSys3.CellMergeNum = 1;
            cellList.Add(curCellSys3);

            CellType curCellSys4 = new CellType();
            curCellSys4.RowIndex = 1;
            curCellSys4.CellName = "单据编号：";
            curCellSys4.CellMergeNum = 1;
            cellList.Add(curCellSys4);



            CellType curCellSys5 = new CellType();
            curCellSys5.RowIndex = 2;
            curCellSys5.CellName = "RQ";
            curCellSys5.CellMergeNum = 1;
            cellList.Add(curCellSys5);

            CellType curCellSys6= new CellType();
            curCellSys6.RowIndex = 2;
            curCellSys6.CellName = "日期："+ emOrderInfo.OrderTime;
            curCellSys6.CellMergeNum = 1;
            cellList.Add(curCellSys6);



            CellType curCellSys7 = new CellType();
            curCellSys7.RowIndex = 3;
            curCellSys7.CellName = "YDJH";
            curCellSys7.CellMergeNum = 1;
            cellList.Add(curCellSys7);

            CellType curCellSys8 = new CellType();
            curCellSys8.RowIndex = 3;
            curCellSys8.CellName = "原单号：";
            curCellSys8.CellMergeNum = 1;
            cellList.Add(curCellSys8);



            CellType curCellSys9 = new CellType();
            curCellSys9.RowIndex = 4;
            curCellSys9.CellName = "QDDM";
            curCellSys9.CellMergeNum = 1;
            cellList.Add(curCellSys9);

            CellType curCellSys10 = new CellType();
            curCellSys10.RowIndex = 4;
            curCellSys10.CellName = "渠道:"+ emOrderInfo.EmOrderExportInfo.ChannelID;
            curCellSys10.CellMergeNum = 1;
            cellList.Add(curCellSys10);


            CellType curCellSysChanneName = new CellType();
            curCellSysChanneName.RowIndex = 4;
            curCellSysChanneName.CellName =  emOrderInfo.EmOrderExportInfo.ChannelName;
            curCellSysChanneName.CellMergeNum = 1;
            cellList.Add(curCellSysChanneName);



            CellType curCellSys12 = new CellType();
            curCellSys12.RowIndex = 5;
            curCellSys12.CellName = "DM1";
            curCellSys12.CellMergeNum = 1;
            cellList.Add(curCellSys12);

            CellType curCellSys13 = new CellType();
            curCellSys13.RowIndex = 5;
            curCellSys13.CellName = "客户：" + emOrderInfo.OrderUserID;
            curCellSys13.CellMergeNum = 1;
            cellList.Add(curCellSys13);


            CellType curCellSys14 = new CellType();
            curCellSys14.RowIndex = 5; 
            curCellSys14.CellName = emOrderInfo.OrderUserName; 
            curCellSys14.CellMergeNum = 1;
            cellList.Add(curCellSys14);



            CellType curCellSys15 = new CellType();
            curCellSys15.RowIndex = 6;
            curCellSys15.CellName = "DM3";
            curCellSys15.CellMergeNum = 1;
            cellList.Add(curCellSys15);

            CellType curCellSys16 = new CellType();
            curCellSys16.RowIndex = 6;
            curCellSys16.CellName = "关联仓库：";
            curCellSys16.CellMergeNum = 1;
            cellList.Add(curCellSys16);


            CellType curCellSys17 = new CellType();
            curCellSys17.RowIndex = 7;
            curCellSys17.CellName = "DM3_1";
            curCellSys17.CellMergeNum = 1;
            cellList.Add(curCellSys17);

            CellType curCellSys18 = new CellType();
            curCellSys18.RowIndex = 7;
            curCellSys18.CellName = "关联库位：";
            curCellSys18.CellMergeNum = 1;
            cellList.Add(curCellSys18);




            CellType curCellSys19 = new CellType();
            curCellSys19.RowIndex = 8;
            curCellSys19.CellName = "DM2";
            curCellSys19.CellMergeNum = 1;
            cellList.Add(curCellSys19);

            CellType curCellSys20 = new CellType();
            curCellSys20.RowIndex = 8;
            curCellSys20.CellName = "仓库："+emOrderInfo.EmOrderExportInfo.WarehouseID;
            curCellSys20.CellMergeNum = 1;
            cellList.Add(curCellSys20);


            CellType curCellSysHouseName = new CellType();
            curCellSysHouseName.RowIndex = 8;
            curCellSysHouseName.CellName = emOrderInfo.EmOrderExportInfo.WarehouseName;
            curCellSysHouseName.CellMergeNum = 1;
            cellList.Add(curCellSysHouseName);


            CellType curCellSys22= new CellType();
            curCellSys22.RowIndex = 9;
            curCellSys22.CellName = "DM2_1";
            curCellSys22.CellMergeNum = 1;
            cellList.Add(curCellSys22);

            CellType curCellSys23 = new CellType();
            curCellSys23.RowIndex = 9;
            curCellSys23.CellName = "库位：";
            curCellSys23.CellMergeNum = 1;
            cellList.Add(curCellSys23); 


            CellType curCellSys25 = new CellType();
            curCellSys25.RowIndex = 10;
            curCellSys25.CellName = "YGDM";
            curCellSys25.CellMergeNum = 1;
            cellList.Add(curCellSys25);

            CellType curCellSys26 = new CellType();
            curCellSys26.RowIndex = 10;
            curCellSys26.CellName = "业务员：";
            curCellSys26.CellMergeNum = 1;
            cellList.Add(curCellSys26);

             


            CellType curCellSys28 = new CellType();
            curCellSys28.RowIndex = 11;
            curCellSys28.CellName = "BYZD3";
            curCellSys28.CellMergeNum = 1;
            cellList.Add(curCellSys28);

            CellType curCellSys29 = new CellType();
            curCellSys29.RowIndex = 11;
            curCellSys29.CellName = "通知号：";
            curCellSys29.CellMergeNum = 1;
            cellList.Add(curCellSys29);



            CellType curCellSys30 = new CellType();
            curCellSys30.RowIndex = 12;
            curCellSys30.CellName = "LXDJ";
            curCellSys30.CellMergeNum = 1;
            cellList.Add(curCellSys30);

            CellType curCellSys31 = new CellType();
            curCellSys31.RowIndex = 12;
            curCellSys31.CellName = "订单号:";
            curCellSys31.CellMergeNum = 1;
            cellList.Add(curCellSys31);


            CellType curCellSys32 = new CellType();
            curCellSys32.RowIndex = 13;
            curCellSys32.CellName = "DM4";
            curCellSys32.CellMergeNum = 1;
            cellList.Add(curCellSys32);

            CellType curCellSys33 = new CellType();
            curCellSys33.RowIndex = 13;
            curCellSys33.CellName = "发货类型：";
            curCellSys33.CellMergeNum = 1;
            cellList.Add(curCellSys33);

             


            CellType curCellSys35 = new CellType();
            curCellSys35.RowIndex = 14;
            curCellSys35.CellName = "DM4_1";
            curCellSys35.CellMergeNum = 1;
            cellList.Add(curCellSys35);

            CellType curCellSys36 = new CellType();
            curCellSys36.RowIndex = 14;
            curCellSys36.CellName = "折扣类型:";
            curCellSys36.CellMergeNum = 1;
            cellList.Add(curCellSys36);


            CellType curCellSys37 = new CellType();
            curCellSys37.RowIndex = 15;
            curCellSys37.CellName = "BYZD1";
            curCellSys37.CellMergeNum = 1;
            cellList.Add(curCellSys37);

            CellType curCellSys38 = new CellType();
            curCellSys38.RowIndex = 15;
            curCellSys38.CellName = "价格选定：";
            curCellSys38.CellMergeNum = 1;
            cellList.Add(curCellSys38);

             

            CellType curCellSys40 = new CellType();
            curCellSys40.RowIndex = 16;
            curCellSys40.CellName = "BYZD12";
            curCellSys40.CellMergeNum = 1;
            cellList.Add(curCellSys40);

            CellType curCellSys41 = new CellType();
            curCellSys41.RowIndex = 16;
            curCellSys41.CellName = "折扣：";
            curCellSys41.CellMergeNum = 1;
            cellList.Add(curCellSys41);



            CellType curCellSys42 = new CellType();
            curCellSys42.RowIndex = 17;
            curCellSys42.CellName = "YXRQ";
            curCellSys42.CellMergeNum = 1;
            cellList.Add(curCellSys42);

            CellType curCellSys43 = new CellType();
            curCellSys43.RowIndex = 17;
            curCellSys43.CellName = "预发货日：";
            curCellSys43.CellMergeNum = 1;
            cellList.Add(curCellSys43);


            CellType curCellSys44= new CellType();
            curCellSys44.RowIndex = 18;
            curCellSys44.CellName = "DM5";
            curCellSys44.CellMergeNum = 1;
            cellList.Add(curCellSys44);

            CellType curCellSys45 = new CellType();
            curCellSys45.RowIndex = 18;
            curCellSys45.CellName = "品牌：";
            curCellSys45.CellMergeNum = 1;
            cellList.Add(curCellSys45);



            CellType curCellSys46 = new CellType();
            curCellSys46.RowIndex = 19;
            curCellSys46.CellName = "FZXX";
            curCellSys46.CellMergeNum = 1;
            cellList.Add(curCellSys46);

            CellType curCellSys47 = new CellType();
            curCellSys47.RowIndex = 19;
            curCellSys47.CellName = "分账信息："+emOrderInfo.EmOrderExportInfo.LedgerAccountID;
            curCellSys47.CellMergeNum = 1;
            cellList.Add(curCellSys47);

            CellType curCellSys48 = new CellType();
            curCellSys48.RowIndex = 19;
            curCellSys48.CellName = emOrderInfo.EmOrderExportInfo.LedgerAccountName;
            curCellSys48.CellMergeNum = 1;
            cellList.Add(curCellSys48);


            CellType curCellSys49 = new CellType();
            curCellSys49.RowIndex = 21;
            curCellSys49.CellName = "0";
            curCellSys49.CellMergeNum = 1;
            cellList.Add(curCellSys49);

            CellType curCellSys50 = new CellType();
            curCellSys50.RowIndex = 21;
            curCellSys50.CellName = "扩展" ;
            curCellSys50.CellMergeNum = 1;
            cellList.Add(curCellSys50);

            CellType curCellSys51 = new CellType();
            curCellSys51.RowIndex = 21;
            curCellSys51.CellName = "1";
            curCellSys51.CellMergeNum = 1;
            cellList.Add(curCellSys51);

             
            CellType curCellSys53 = new CellType();
            curCellSys53.RowIndex = 21;
            curCellSys53.CellName = "10";
            curCellSys53.CellMergeNum = 1;
            cellList.Add(curCellSys53);


            return cellList;
        }

        public static List<CellType> getPfCellList(EmOrderExportData emOrderInfo)
        {
            List<CellType> cellList = new List<CellType>();

            /*  CellType curCell = new CellType();
              curCell.RowIndex = 0;
              curCell.CellName = "调拨单";
              curCell.Title = true;
              curCell.CellMergeNum = ColNum;


              // curCell.CellMergeIndex = 12;
              cellList.Add(curCell);*/

            CellType curCellSys1 = new CellType();
            curCellSys1.RowIndex = 0;
            curCellSys1.CellName = "FA3";
            curCellSys1.CellMergeNum = 1;
            cellList.Add(curCellSys1);

            CellType curCellSys2 = new CellType();
            curCellSys2.RowIndex = 0;
            curCellSys2.CellName = "批发销货单";
            curCellSys2.CellMergeNum = 1;
            cellList.Add(curCellSys2);


            CellType curCellSys3 = new CellType();
            curCellSys3.RowIndex = 1;
            curCellSys3.CellName = "DJBH";
            curCellSys3.CellMergeNum = 1;
            cellList.Add(curCellSys3);

            CellType curCellSys4 = new CellType();
            curCellSys4.RowIndex = 1;
            curCellSys4.CellName = "单据编号：";
            curCellSys4.CellMergeNum = 1;
            cellList.Add(curCellSys4);



            CellType curCellSys5 = new CellType();
            curCellSys5.RowIndex = 2;
            curCellSys5.CellName = "RQ";
            curCellSys5.CellMergeNum = 1;
            cellList.Add(curCellSys5);

            CellType curCellSys6 = new CellType();
            curCellSys6.RowIndex = 2;
            curCellSys6.CellName = "日期：" + emOrderInfo.OrderTime;
            curCellSys6.CellMergeNum = 1;
            cellList.Add(curCellSys6);



            CellType curCellSys7 = new CellType();
            curCellSys7.RowIndex = 3;
            curCellSys7.CellName = "YDJH";
            curCellSys7.CellMergeNum = 1;
            cellList.Add(curCellSys7);

            CellType curCellSys8 = new CellType();
            curCellSys8.RowIndex = 3;
            curCellSys8.CellName = "原单号：";
            curCellSys8.CellMergeNum = 1;
            cellList.Add(curCellSys8);



            CellType curCellSys9 = new CellType();
            curCellSys9.RowIndex = 4;
            curCellSys9.CellName = "QDDM";
            curCellSys9.CellMergeNum = 1;
            cellList.Add(curCellSys9);

            CellType curCellSys10 = new CellType();
            curCellSys10.RowIndex = 4;
            curCellSys10.CellName = "渠道:" + emOrderInfo.EmOrderExportInfo.ChannelID;
            curCellSys10.CellMergeNum = 1;
            cellList.Add(curCellSys10);


            CellType curCellSysChanneName = new CellType();
            curCellSysChanneName.RowIndex = 4;
            curCellSysChanneName.CellName =  emOrderInfo.EmOrderExportInfo.ChannelName;
            curCellSysChanneName.CellMergeNum = 1;
            cellList.Add(curCellSysChanneName);




            CellType curCellSys12 = new CellType();
            curCellSys12.RowIndex = 5;
            curCellSys12.CellName = "DM1";
            curCellSys12.CellMergeNum = 1;
            cellList.Add(curCellSys12);

            CellType curCellSys13 = new CellType();
            curCellSys13.RowIndex = 5;
            curCellSys13.CellName = "客户：" + emOrderInfo.OrderUserID;
            curCellSys13.CellMergeNum = 1;
            cellList.Add(curCellSys13);


               CellType curCellSys14 = new CellType();
               curCellSys14.RowIndex = 5; 
               curCellSys14.CellName = emOrderInfo.OrderUserName; 
               curCellSys14.CellMergeNum = 1;
               cellList.Add(curCellSys14);



            CellType curCellSys15 = new CellType();
            curCellSys15.RowIndex = 6;
            curCellSys15.CellName = "DM3";
            curCellSys15.CellMergeNum = 1;
            cellList.Add(curCellSys15);

            CellType curCellSys16 = new CellType();
            curCellSys16.RowIndex = 6;
            curCellSys16.CellName = "关联仓库：";
            curCellSys16.CellMergeNum = 1;
            cellList.Add(curCellSys16);


            CellType curCellSys17 = new CellType();
            curCellSys17.RowIndex = 7;
            curCellSys17.CellName = "DM3_1";
            curCellSys17.CellMergeNum = 1;
            cellList.Add(curCellSys17);

            CellType curCellSys18 = new CellType();
            curCellSys18.RowIndex = 7;
            curCellSys18.CellName = "关联库位：";
            curCellSys18.CellMergeNum = 1;
            cellList.Add(curCellSys18);




            CellType curCellSys19 = new CellType();
            curCellSys19.RowIndex = 8;
            curCellSys19.CellName = "DM2";
            curCellSys19.CellMergeNum = 1;
            cellList.Add(curCellSys19);

            CellType curCellSys20 = new CellType();
            curCellSys20.RowIndex = 8;
            curCellSys20.CellName = "仓库：" + emOrderInfo.EmOrderExportInfo.WarehouseID;
            curCellSys20.CellMergeNum = 1;
            cellList.Add(curCellSys20);

            CellType curCellSysHouseName = new CellType();
            curCellSysHouseName.RowIndex = 8;
            curCellSysHouseName.CellName = emOrderInfo.EmOrderExportInfo.WarehouseID;
            curCellSysHouseName.CellMergeNum = 1;
            cellList.Add(curCellSysHouseName);



            CellType curCellSys22 = new CellType();
            curCellSys22.RowIndex = 9;
            curCellSys22.CellName = "DM2_1";
            curCellSys22.CellMergeNum = 1;
            cellList.Add(curCellSys22);

            CellType curCellSys23 = new CellType();
            curCellSys23.RowIndex = 9;
            curCellSys23.CellName = "库位：";
            curCellSys23.CellMergeNum = 1;
            cellList.Add(curCellSys23);


            CellType curCellSys25 = new CellType();
            curCellSys25.RowIndex = 10;
            curCellSys25.CellName = "YGDM";
            curCellSys25.CellMergeNum = 1;
            cellList.Add(curCellSys25);

            CellType curCellSys26 = new CellType();
            curCellSys26.RowIndex = 10;
            curCellSys26.CellName = "业务员：";
            curCellSys26.CellMergeNum = 1;
            cellList.Add(curCellSys26);




            CellType curCellSys28 = new CellType();
            curCellSys28.RowIndex = 11;
            curCellSys28.CellName = "BYZD3";
            curCellSys28.CellMergeNum = 1;
            cellList.Add(curCellSys28);

            CellType curCellSys29 = new CellType();
            curCellSys29.RowIndex = 11;
            curCellSys29.CellName = "通知号：";
            curCellSys29.CellMergeNum = 1;
            cellList.Add(curCellSys29);



            CellType curCellSys30 = new CellType();
            curCellSys30.RowIndex = 12;
            curCellSys30.CellName = "LXDJ";
            curCellSys30.CellMergeNum = 1;
            cellList.Add(curCellSys30);

            CellType curCellSys31 = new CellType();
            curCellSys31.RowIndex = 12;
            curCellSys31.CellName = "订单号:";
            curCellSys31.CellMergeNum = 1;
            cellList.Add(curCellSys31);


            CellType curCellSys32 = new CellType();
            curCellSys32.RowIndex = 13;
            curCellSys32.CellName = "DM4";
            curCellSys32.CellMergeNum = 1;
            cellList.Add(curCellSys32);

            CellType curCellSys33 = new CellType();
            curCellSys33.RowIndex = 13;
            curCellSys33.CellName = "发货类型：";
            curCellSys33.CellMergeNum = 1;
            cellList.Add(curCellSys33);




            CellType curCellSys35 = new CellType();
            curCellSys35.RowIndex = 14;
            curCellSys35.CellName = "DM4_1";
            curCellSys35.CellMergeNum = 1;
            cellList.Add(curCellSys35);

            CellType curCellSys36 = new CellType();
            curCellSys36.RowIndex = 14;
            curCellSys36.CellName = "折扣类型:";
            curCellSys36.CellMergeNum = 1;
            cellList.Add(curCellSys36);


            CellType curCellSys37 = new CellType();
            curCellSys37.RowIndex = 15;
            curCellSys37.CellName = "BYZD1";
            curCellSys37.CellMergeNum = 1;
            cellList.Add(curCellSys37);

            CellType curCellSys38 = new CellType();
            curCellSys38.RowIndex = 15;
            curCellSys38.CellName = "价格选定：";
            curCellSys38.CellMergeNum = 1;
            cellList.Add(curCellSys38);



            CellType curCellSys40 = new CellType();
            curCellSys40.RowIndex = 16;
            curCellSys40.CellName = "BYZD12";
            curCellSys40.CellMergeNum = 1;
            cellList.Add(curCellSys40);

            CellType curCellSys41 = new CellType();
            curCellSys41.RowIndex = 16;
            curCellSys41.CellName = "折扣：";
            curCellSys41.CellMergeNum = 1;
            cellList.Add(curCellSys41);



            CellType curCellSys42 = new CellType();
            curCellSys42.RowIndex = 17;
            curCellSys42.CellName = "YXRQ";
            curCellSys42.CellMergeNum = 1;
            cellList.Add(curCellSys42);

            CellType curCellSys43 = new CellType();
            curCellSys43.RowIndex = 17;
            curCellSys43.CellName = "预发货日：";
            curCellSys43.CellMergeNum = 1;
            cellList.Add(curCellSys43);


            CellType curCellSys44 = new CellType();
            curCellSys44.RowIndex = 18;
            curCellSys44.CellName = "DM5";
            curCellSys44.CellMergeNum = 1;
            cellList.Add(curCellSys44);

            CellType curCellSys45 = new CellType();
            curCellSys45.RowIndex = 18;
            curCellSys45.CellName = "品牌：";
            curCellSys45.CellMergeNum = 1;
            cellList.Add(curCellSys45);



            CellType curCellSys46 = new CellType();
            curCellSys46.RowIndex = 19;
            curCellSys46.CellName = "FZXX";
            curCellSys46.CellMergeNum = 1;
            cellList.Add(curCellSys46);

            CellType curCellSys47 = new CellType();
            curCellSys47.RowIndex = 19;
            curCellSys47.CellName = "分账信息：" + emOrderInfo.EmOrderExportInfo.LedgerAccountID;
            curCellSys47.CellMergeNum = 1;
            cellList.Add(curCellSys47);

            CellType curCellSys48 = new CellType();
            curCellSys48.RowIndex = 19;
            curCellSys48.CellName = emOrderInfo.EmOrderExportInfo.LedgerAccountName;
            curCellSys48.CellMergeNum = 1;
            cellList.Add(curCellSys48);


            CellType curCellSys49 = new CellType();
            curCellSys49.RowIndex = 21;
            curCellSys49.CellName = "0";
            curCellSys49.CellMergeNum = 1;
            cellList.Add(curCellSys49);

            CellType curCellSys50 = new CellType();
            curCellSys50.RowIndex = 21;
            curCellSys50.CellName = "扩展";
            curCellSys50.CellMergeNum = 1;
            cellList.Add(curCellSys50);

            CellType curCellSys51 = new CellType();
            curCellSys51.RowIndex = 21;
            curCellSys51.CellName = "1";
            curCellSys51.CellMergeNum = 1;
            cellList.Add(curCellSys51);


            CellType curCellSys53 = new CellType();
            curCellSys53.RowIndex = 21;
            curCellSys53.CellName = "10";
            curCellSys53.CellMergeNum = 1;
            cellList.Add(curCellSys53);


            return cellList;
        }
    }
}
