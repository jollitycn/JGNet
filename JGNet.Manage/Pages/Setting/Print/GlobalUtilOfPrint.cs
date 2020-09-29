using JGNet.Core.InteractEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    public class GlobalUtilOfPrint
    {
        #region
        /// <summary>
        /// 采购系统变量
        /// </summary>
        /// <returns></returns>
        public static  List<PrintSysInfo> getPurchaseStockSysInfo()
        {
            List<PrintSysInfo> list = new List<PrintSysInfo>();
            PrintSysInfo pSysInfoID = new PrintSysInfo();
            pSysInfoID.name = "采购单号";
            list.Add(pSysInfoID);
            PrintSysInfo pSysInfoTime = new PrintSysInfo();
            pSysInfoTime.name = "开单时间";
            list.Add(pSysInfoTime);
            PrintSysInfo pSysInfoSupplier = new PrintSysInfo();
            pSysInfoSupplier.name = "供应商";
            list.Add(pSysInfoSupplier);
            PrintSysInfo pSysInfoOpertion = new PrintSysInfo();
            pSysInfoOpertion.name = "操作人";
            list.Add(pSysInfoOpertion);
            PrintSysInfo pSysInfoCount= new PrintSysInfo();
            pSysInfoCount.name = "总数量";
            list.Add(pSysInfoCount);
            PrintSysInfo pSysInfoCostPirce = new PrintSysInfo();
            pSysInfoCostPirce.name = "总成本";
            list.Add(pSysInfoCostPirce);
            PrintSysInfo pSysInfoRemark = new PrintSysInfo();
            pSysInfoRemark.name = "单据备注";
            list.Add(pSysInfoRemark);
            return list;
        }
        #endregion

        #region
        /// <summary>
        /// 批发发货单变量
        /// </summary>
        /// <returns></returns>
        public static List<PrintSysInfo> getPfSendBillSysInfo()
        {//单号、客户、开单时间、操作人、付款方式、总数量、批发总额、单据备注
            List<PrintSysInfo> list = new List<PrintSysInfo>();
            PrintSysInfo pSysInfoID = new PrintSysInfo();
            pSysInfoID.name = "单号";
            list.Add(pSysInfoID);
            PrintSysInfo pSysInfoCustomer = new PrintSysInfo();
            pSysInfoCustomer.name = "客户";
            list.Add(pSysInfoCustomer);

            PrintSysInfo pSysInfoTime = new PrintSysInfo();
            pSysInfoTime.name = "开单时间";
            list.Add(pSysInfoTime); 
            PrintSysInfo pSysInfoOpertion = new PrintSysInfo();
            pSysInfoOpertion.name = "操作人";
            list.Add(pSysInfoOpertion);

            PrintSysInfo pSysInfoPayforType = new PrintSysInfo();
            pSysInfoPayforType.name = "付款方式";
            list.Add(pSysInfoPayforType);

            PrintSysInfo pSysInfoCount = new PrintSysInfo();
            pSysInfoCount.name = "总数量";
            list.Add(pSysInfoCount);

            PrintSysInfo pSysInfoSumPirce = new PrintSysInfo();
            pSysInfoSumPirce.name = "上欠金额";
            list.Add(pSysInfoSumPirce);


            PrintSysInfo pSysInfoSumMoney = new PrintSysInfo();
            pSysInfoSumMoney.name = "本次应收金额";
            list.Add(pSysInfoSumMoney);



            PrintSysInfo pSysInfoPaySumMoney = new PrintSysInfo();
            pSysInfoPaySumMoney.name = "应收总额";
            list.Add(pSysInfoPaySumMoney);


            PrintSysInfo pSysInfoRemark = new PrintSysInfo();
            pSysInfoRemark.name = "单据备注";
            list.Add(pSysInfoRemark);
            return list;
        }
        #endregion
        #region
        /// <summary>
        /// 补货申请单变量
        /// </summary>
        /// <returns></returns>
        public static List<PrintSysInfo> getFreplenishBillSysInfo()
        {//单号、申请时间、申请店铺、申请人、总数量、总金额、单据备注
            List<PrintSysInfo> list = new List<PrintSysInfo>();
            PrintSysInfo pSysInfoID = new PrintSysInfo();
            pSysInfoID.name = "单号";
            list.Add(pSysInfoID);
            PrintSysInfo pSysInfoTime = new PrintSysInfo();
            pSysInfoTime.name = "申请时间";
            list.Add(pSysInfoTime);


            PrintSysInfo pSysInfoShop = new PrintSysInfo();
            pSysInfoShop.name = "申请店铺";
            list.Add(pSysInfoShop);

            PrintSysInfo pSysInfoOpertion = new PrintSysInfo();
            pSysInfoOpertion.name = "申请人";
            list.Add(pSysInfoOpertion);

            PrintSysInfo pSysInfoCount = new PrintSysInfo();
            pSysInfoCount.name = "总数量";
            list.Add(pSysInfoCount);

            PrintSysInfo pSysInfoSumPirce = new PrintSysInfo();
            pSysInfoSumPirce.name = "总金额";
            list.Add(pSysInfoSumPirce); 

            PrintSysInfo pSysInfoRemark = new PrintSysInfo();
            pSysInfoRemark.name = "单据备注";
            list.Add(pSysInfoRemark);
            return list;
        }
        #endregion
         
        #region
        /// <summary>
        /// 调拨单变量
        /// </summary>
        /// <returns></returns>
        public static List<PrintSysInfo> getAllocateSysInfo()
        {//单号、开单员、开单时间、发货方、收货方、总数量、总金额、单据备注
            List<PrintSysInfo> list = new List<PrintSysInfo>();
            PrintSysInfo pSysInfoID = new PrintSysInfo();
            pSysInfoID.name = "单号";
            list.Add(pSysInfoID);
            PrintSysInfo pSysInfoCustomer = new PrintSysInfo();
            pSysInfoCustomer.name = "开单员";
            list.Add(pSysInfoCustomer);

            PrintSysInfo pSysInfoTime = new PrintSysInfo();
            pSysInfoTime.name = "开单时间";
            list.Add(pSysInfoTime);
            PrintSysInfo pSysInfoOpertion = new PrintSysInfo();
            pSysInfoOpertion.name = "发货方";
            list.Add(pSysInfoOpertion);

            PrintSysInfo pSysInfoDelivery = new PrintSysInfo();
            pSysInfoDelivery.name = "收货方";
            list.Add(pSysInfoDelivery);

            PrintSysInfo pSysInfoCount = new PrintSysInfo();
            pSysInfoCount.name = "总数量";
            list.Add(pSysInfoCount);

            PrintSysInfo pSysInfoSumPirce = new PrintSysInfo();
            pSysInfoSumPirce.name = "总金额";
            list.Add(pSysInfoSumPirce);
            PrintSysInfo pSysInfoRemark = new PrintSysInfo();
            pSysInfoRemark.name = "单据备注";
            list.Add(pSysInfoRemark);
            return list;
        }
        #endregion

        #region
        /// <summary>
        /// 盘点单系统变量
        /// </summary>
        /// <returns></returns>
        public static List<PrintSysInfo> getCheckStoreSysInfo()
        {//单号、店铺、操作人、审核人、盘点时间、审核时间、单据备注
            List<PrintSysInfo> list = new List<PrintSysInfo>();
            PrintSysInfo pSysInfoID = new PrintSysInfo();
            pSysInfoID.name = "单号";
            list.Add(pSysInfoID);
            PrintSysInfo pSysInfoShop = new PrintSysInfo();
            pSysInfoShop.name = "店铺";
            list.Add(pSysInfoShop);

            PrintSysInfo pSysInfoOpertion = new PrintSysInfo();
            pSysInfoOpertion.name = "操作人";
            list.Add(pSysInfoOpertion);

            PrintSysInfo pSysInfoChecker = new PrintSysInfo();
            pSysInfoChecker.name = "审核人";
            list.Add(pSysInfoChecker);
            PrintSysInfo pSysInfoTime = new PrintSysInfo();
            pSysInfoTime.name = "盘点时间";
            list.Add(pSysInfoTime);

            PrintSysInfo pSysInfoVailite = new PrintSysInfo();
            pSysInfoVailite.name = "审核时间";
            list.Add(pSysInfoVailite);
             
            PrintSysInfo pSysInfoRemark = new PrintSysInfo();
            pSysInfoRemark.name = "单据备注";
            list.Add(pSysInfoRemark);
            return list;
        }
        #endregion

        public static List<PrintSysInfo> getBalanceOnThatDaySysInfo()
        {

            List<PrintSysInfo> list = new List<PrintSysInfo>();
            PrintSysInfo pSysInfoTime = new PrintSysInfo();
            pSysInfoTime.name = "日结时间";
            list.Add(pSysInfoTime);
            PrintSysInfo pSysInfoDay= new PrintSysInfo();
            pSysInfoDay.name = "日结日期";
            list.Add(pSysInfoDay);
            PrintSysInfo pSysInfoShopName = new PrintSysInfo();
            pSysInfoShopName.name = "店铺名称";
            list.Add(pSysInfoShopName);


            PrintSysInfo pSysInfoFirstStore = new PrintSysInfo();
            pSysInfoFirstStore.name = "期初库存";
            list.Add(pSysInfoFirstStore); 
            PrintSysInfo pSysInfoPurchaseStock = new PrintSysInfo();
            pSysInfoPurchaseStock.name = "采购进货";
            list.Add(pSysInfoPurchaseStock);
            PrintSysInfo pSysInfoPurchaseStockReturn = new PrintSysInfo();
            pSysInfoPurchaseStockReturn.name = "采购退货";
            list.Add(pSysInfoPurchaseStockReturn);
            PrintSysInfo pSysInfoInStock = new PrintSysInfo();
            pSysInfoInStock.name = "调拨入库";
            list.Add(pSysInfoInStock);
            PrintSysInfo pSysInfoAllocate = new PrintSysInfo();
            pSysInfoAllocate.name = "调拨";
            list.Add(pSysInfoAllocate);
            PrintSysInfo pSysInfoOut = new PrintSysInfo();
            pSysInfoOut.name = "报损出库";
            list.Add(pSysInfoOut);
            PrintSysInfo pSysInfoInventoryProfit = new PrintSysInfo();
            pSysInfoInventoryProfit.name = "盘盈数";
            list.Add(pSysInfoInventoryProfit);
            PrintSysInfo pSysInfoInventoryLoss = new PrintSysInfo();
            pSysInfoInventoryLoss.name = "盘亏数";
            list.Add(pSysInfoInventoryLoss);
            PrintSysInfo pSysInfoPfSend = new PrintSysInfo();
            pSysInfoPfSend.name = "批发发货";
            list.Add(pSysInfoPfSend);
            PrintSysInfo pSysInfoPfRetun = new PrintSysInfo();
            pSysInfoPfRetun.name = "批发退货";
            list.Add(pSysInfoPfRetun);
            PrintSysInfo pSysInfoSaleOfThatDay = new PrintSysInfo();
            pSysInfoSaleOfThatDay.name = "当日销售";
            list.Add(pSysInfoSaleOfThatDay);
            PrintSysInfo pSysInfoCustomerReturn = new PrintSysInfo();
            pSysInfoCustomerReturn.name = "顾客退货";
            list.Add(pSysInfoCustomerReturn);
            PrintSysInfo pSysInfoAdjustDiffient = new PrintSysInfo();
            pSysInfoAdjustDiffient.name = "差异调整";
            list.Add(pSysInfoAdjustDiffient);
            PrintSysInfo pSysInfoEndStore = new PrintSysInfo();
            pSysInfoEndStore.name = "期末库存";
            list.Add(pSysInfoEndStore);



            PrintSysInfo pSysInfoCash = new PrintSysInfo();
            pSysInfoCash.name = "现金";
            pSysInfoCash.type = 0;
            list.Add(pSysInfoCash);
            PrintSysInfo pSysInfoBandkCard= new PrintSysInfo();
            pSysInfoBandkCard.name = "银联卡";
            pSysInfoBandkCard.type = 0;
            list.Add(pSysInfoBandkCard);
            PrintSysInfo pSysInfoWinXin= new PrintSysInfo();
            pSysInfoWinXin.name = "微信";
            pSysInfoWinXin.type = 0;
            list.Add(pSysInfoWinXin);
            PrintSysInfo pSysInfoPay = new PrintSysInfo();
            pSysInfoPay.name = "支付宝";
            pSysInfoPay.type = 0;
            list.Add(pSysInfoPay);  
            PrintSysInfo pSysInfoVIP = new PrintSysInfo();
            pSysInfoVIP.name = "VIP卡余额";
            pSysInfoVIP.type = 0;
            list.Add(pSysInfoVIP);
            PrintSysInfo pSysInfoVIPInter = new PrintSysInfo();
            pSysInfoVIPInter.name = "VIP卡积分返现";
            pSysInfoVIPInter.type = 0;
            list.Add(pSysInfoVIPInter);
            PrintSysInfo pSysInfoCoupon = new PrintSysInfo();
            pSysInfoCoupon.name = "优惠券金额";
            pSysInfoCoupon.type = 0;
            list.Add(pSysInfoCoupon);



            PrintSysInfo pSysInfoRechargeCash = new PrintSysInfo();
            pSysInfoRechargeCash.name = "现金";
            pSysInfoRechargeCash.type = 1;
            list.Add(pSysInfoRechargeCash);
            PrintSysInfo pSysInfoRechargeBankCard = new PrintSysInfo();
            pSysInfoRechargeBankCard.name = "银联卡";
            pSysInfoRechargeBankCard.type = 1;
            list.Add(pSysInfoRechargeBankCard);
            PrintSysInfo pSysInfoRechargeWinXin = new PrintSysInfo();
            pSysInfoRechargeWinXin.name = "微信";
            pSysInfoRechargeWinXin.type = 1;
            list.Add(pSysInfoRechargeWinXin);
            PrintSysInfo pSysInfoRechargePay = new PrintSysInfo();
            pSysInfoRechargePay.name = "支付宝";
            pSysInfoRechargePay.type = 1;
            list.Add(pSysInfoRechargePay);
            PrintSysInfo pSysInfoRechargeOther = new PrintSysInfo();
            pSysInfoRechargeOther.name = "其他";
            pSysInfoRechargeOther.type = 1;
            list.Add(pSysInfoRechargeOther);



            PrintSysInfo pSysInfoRetailCount = new PrintSysInfo();
            pSysInfoRetailCount.name = "零售单数";
            list.Add(pSysInfoRetailCount);
            PrintSysInfo pSysInfoSaleCash = new PrintSysInfo();
            pSysInfoSaleCash.name = "营收金额";
            list.Add(pSysInfoSaleCash);
            PrintSysInfo pSysInfoThatDay = new PrintSysInfo();
            pSysInfoThatDay.name = "当日现金结余";
            list.Add(pSysInfoThatDay);


            PrintSysInfo pSysInfoSaleManAutograph = new PrintSysInfo();
            pSysInfoSaleManAutograph.name = "营业员签名";
            list.Add(pSysInfoSaleManAutograph);
            PrintSysInfo pSysInfoFinanceAutograph = new PrintSysInfo();
            pSysInfoFinanceAutograph.name = "财务签名";
            list.Add(pSysInfoFinanceAutograph);

            /* 日结时间、日结日期、店铺名称、
 期初库存、采购进货、采购退货、调拨入库、调拨、报损出库、盘盈数、盘亏数、批发发货、批发退货、当日销售、顾客退货、差异调整、期末库存

 现金、银联卡、微信、支付宝、其他、VIP卡余额、VIP卡积分返现、优惠券金额

 现金、银联卡、微信、支付宝、其他

 零售单数、营收金额、当日现金结余

 营业员签名、财务签名*/

            return list;

        }

        /// <summary>
        /// 销售退货小票形式系统变量
        /// </summary>
        /// <returns></returns>
        public static List<PrintSysInfo> getSaleReturnSysInfo()
        { 
            List<PrintSysInfo> list = new List<PrintSysInfo>();
            PrintSysInfo pSysInfo1 = new PrintSysInfo();
            pSysInfo1.name = "店铺";
            list.Add(pSysInfo1);
            PrintSysInfo pSysInfo2 = new PrintSysInfo();
            pSysInfo2.name = "单号";
            list.Add(pSysInfo2);
            PrintSysInfo pSysInfo3 = new PrintSysInfo();
            pSysInfo3.name = "日期";
            list.Add(pSysInfo3);
            PrintSysInfo pSysInfo4 = new PrintSysInfo();
            pSysInfo4.name = "电话";
            list.Add(pSysInfo4);
            PrintSysInfo pSysInfo5= new PrintSysInfo();
            pSysInfo5.name = "地址";
            list.Add(pSysInfo5);
            PrintSysInfo pSysInfo6 = new PrintSysInfo();
            pSysInfo6.name = "顾问";
            list.Add(pSysInfo6);
            PrintSysInfo pSysInfo7= new PrintSysInfo();
            pSysInfo7.name = "数量";
            list.Add(pSysInfo7); 
            PrintSysInfo pSysInfo8 = new PrintSysInfo();
            pSysInfo8.name = "折扣优惠";
            list.Add(pSysInfo8); 
            PrintSysInfo pSysInfo9= new PrintSysInfo();
            pSysInfo9.name = "应收";
            list.Add(pSysInfo9);
             
  
            PrintSysInfo pSysInfo10 = new PrintSysInfo();
            pSysInfo10.name = "卡号";
            list.Add(pSysInfo10);
            PrintSysInfo pSysInfo11 = new PrintSysInfo();
            pSysInfo11.name = "姓名";
            list.Add(pSysInfo11);
            PrintSysInfo pSysInfo12 = new PrintSysInfo();
            pSysInfo12.name = "本次积分";
            list.Add(pSysInfo12);
            PrintSysInfo pSysInfo13 = new PrintSysInfo();
            pSysInfo13.name = "当前积分";
            list.Add(pSysInfo13);
            PrintSysInfo pSysInfo14 = new PrintSysInfo();
            pSysInfo14.name = "累计积分";
            list.Add(pSysInfo14);
            PrintSysInfo pSysInfo15 = new PrintSysInfo();
            pSysInfo15.name = "余额";
            list.Add(pSysInfo15);
            PrintSysInfo pSysInfo16 = new PrintSysInfo();
            pSysInfo16.name = "银联卡";
            list.Add(pSysInfo16);
            PrintSysInfo pSysInfo17 = new PrintSysInfo();
            pSysInfo17.name = "现金";
            list.Add(pSysInfo17);
            PrintSysInfo pSysInfo18 = new PrintSysInfo();
            pSysInfo18.name = "VIP卡";
            list.Add(pSysInfo18);
             
            PrintSysInfo pSysInfo19 = new PrintSysInfo();
            pSysInfo19.name = "支付宝";
            list.Add(pSysInfo19);
            PrintSysInfo pSysInfo20 = new PrintSysInfo();
            pSysInfo20.name = "微信";
            list.Add(pSysInfo20);
            PrintSysInfo pSysInfo21= new PrintSysInfo();
            pSysInfo21.name = "积分兑现";
            list.Add(pSysInfo21);
            PrintSysInfo pSysInfo22 = new PrintSysInfo();
            pSysInfo22.name = "优惠券";
            list.Add(pSysInfo22);
            PrintSysInfo pSysInfo23 = new PrintSysInfo();
            pSysInfo23.name = "其他";
            list.Add(pSysInfo23);
            PrintSysInfo pSysInfo24= new PrintSysInfo();
            pSysInfo24.name = "找零";
            list.Add(pSysInfo24);
            PrintSysInfo pSysInfo25 = new PrintSysInfo();
            pSysInfo25.name = "结尾附加文字";
            list.Add(pSysInfo25);
            PrintSysInfo pSysInfo26 = new PrintSysInfo();
            pSysInfo26.name = "商城二维码";
            list.Add(pSysInfo26);

            return list;
        }
        /// <summary>
        /// 销售/退货单单据形式系统变量
        /// </summary>
        /// <returns></returns>
        public static List<PrintSysInfo> getSaleReturnSysInfoOfBillTemplate()
        {
            List<PrintSysInfo> list = new List<PrintSysInfo>();
            PrintSysInfo pSysInfo1 = new PrintSysInfo();
            pSysInfo1.name = "销售单号";
            list.Add(pSysInfo1);

            PrintSysInfo pSysInfo2 = new PrintSysInfo();
            pSysInfo2.name = "单据日期";
            list.Add(pSysInfo2);
            PrintSysInfo pSysInfo3 = new PrintSysInfo();
            pSysInfo3.name = "客户名称";
            list.Add(pSysInfo3);
            PrintSysInfo pSysInfo4 = new PrintSysInfo();
            pSysInfo4.name = "客户电话";
            list.Add(pSysInfo4);
            PrintSysInfo pSysInfo5 = new PrintSysInfo();
            pSysInfo5.name = "客户地址";
            list.Add(pSysInfo5);
            PrintSysInfo pSysInfo6 = new PrintSysInfo();
            pSysInfo6.name = "操作人";
            list.Add(pSysInfo6);
            PrintSysInfo pSysInfo7 = new PrintSysInfo();
            pSysInfo7.name = "单据备注";
            list.Add(pSysInfo7);

            PrintSysInfo pSysInfo8 = new PrintSysInfo();
            pSysInfo8.name = "店铺地址";
            list.Add(pSysInfo8);
            PrintSysInfo pSysInfo9 = new PrintSysInfo();
            pSysInfo9.name = "联系电话";
            list.Add(pSysInfo9);
            return list;
            //销售单号、单据日期、客户名称、客户电话、客户地址、操作人、单据备注、店铺地址、联系电话
        }



        /// <summary>
        /// 销售退货小票格式列名
        /// </summary>
        /// <returns></returns>
        public static List<PrintColumnsInfo> getSaleReturnColumnsInfo()
        {
            /*款号、颜色、尺码、数量、吊牌价、金额*/
            List<PrintColumnsInfo> list = new List<PrintColumnsInfo>();
            PrintColumnsInfo pComstomerID = new PrintColumnsInfo();
            pComstomerID.name = "款号";
            list.Add(pComstomerID);


            PrintColumnsInfo pComstomerColor = new PrintColumnsInfo();
            pComstomerColor.name = "颜色";
            list.Add(pComstomerColor);

            PrintColumnsInfo pComstomerSize1 = new PrintColumnsInfo();
            pComstomerSize1.name = "尺码";
            list.Add(pComstomerSize1);
 
            PrintColumnsInfo pComstomerNum = new PrintColumnsInfo();
            pComstomerNum.name = "数量";
            list.Add(pComstomerNum);


            PrintColumnsInfo pComstomerPrice = new PrintColumnsInfo();
            pComstomerPrice.name = "吊牌价";
            list.Add(pComstomerPrice);

            PrintColumnsInfo pComstomerSalePrice = new PrintColumnsInfo();
            pComstomerSalePrice.name = "金额";
            list.Add(pComstomerSalePrice);
            return list;
        }


        /// <summary>
        /// 销售退货单价打印形式列名
        /// </summary>
        /// <returns></returns>
        public static List<PrintColumnsInfo> getSaleReturnColumnsInfoOfBillTemplate()
        { 
            /*款号、颜色、尺码、数量、吊牌价、金额*/
            List<PrintColumnsInfo> list = new List<PrintColumnsInfo>();
            PrintColumnsInfo pComstomerID = new PrintColumnsInfo();
            pComstomerID.name = "款号";
            list.Add(pComstomerID);


            PrintColumnsInfo pComstomeName = new PrintColumnsInfo();
            pComstomeName.name = "商品名称";
            list.Add(pComstomeName);

            PrintColumnsInfo pComstomerColor = new PrintColumnsInfo();
            pComstomerColor.name = "颜色";
            list.Add(pComstomerColor);

            PrintColumnsInfo pComstomerSize1 = new PrintColumnsInfo();
            pComstomerSize1.name = "尺码";
            list.Add(pComstomerSize1);
 
            PrintColumnsInfo pComstomerPrice = new PrintColumnsInfo();
            pComstomerPrice.name = "吊牌价";
            list.Add(pComstomerPrice);

            PrintColumnsInfo pComstomerNum = new PrintColumnsInfo();
            pComstomerNum.name = "数量";
            list.Add(pComstomerNum);
             


            PrintColumnsInfo pComstomerSalePrice = new PrintColumnsInfo();
            pComstomerSalePrice.name = "金额";
            list.Add(pComstomerSalePrice);

            PrintColumnsInfo pComstomerRemarak = new PrintColumnsInfo();
            pComstomerRemarak.name = "备注";
            list.Add(pComstomerRemarak);
            return list;
        }


        


        #region
        /// <summary>
        /// 调拨单列名
        /// </summary>
        /// <returns></returns>
        /// 款号、商品名称、品牌、颜色、吊牌价、尺码列、数量、总金额、备注
        public static List<PrintColumnsInfo> getCheckStoreColumnsInfo()
        {
            List<PrintColumnsInfo> list = new List<PrintColumnsInfo>();
            PrintColumnsInfo pComstomerID = new PrintColumnsInfo();
            pComstomerID.name = "款号";
            list.Add(pComstomerID);
            PrintColumnsInfo pComstomerName = new PrintColumnsInfo();
            pComstomerName.name = "商品名称";
            list.Add(pComstomerName); 
            PrintColumnsInfo pComstomerBrand = new PrintColumnsInfo();
            pComstomerBrand.name = "品牌";
            list.Add(pComstomerBrand);

            PrintColumnsInfo pComstomerColor = new PrintColumnsInfo();
            pComstomerColor.name = "颜色";
            list.Add(pComstomerColor);
              
            PrintColumnsInfo pComstomerPrice = new PrintColumnsInfo();
            pComstomerPrice.name = "吊牌价";
            list.Add(pComstomerPrice);


            PrintColumnsInfo pComstomerSize1 = new PrintColumnsInfo();
            pComstomerSize1.name = "F";
            list.Add(pComstomerSize1);

            PrintColumnsInfo pComstomerSize2 = new PrintColumnsInfo();
            pComstomerSize2.name = "XS";
            list.Add(pComstomerSize2);

            PrintColumnsInfo pComstomerSize3 = new PrintColumnsInfo();
            pComstomerSize3.name = "S";
            list.Add(pComstomerSize3);

            PrintColumnsInfo pComstomerSize4 = new PrintColumnsInfo();
            pComstomerSize4.name = "M";
            list.Add(pComstomerSize4);

            PrintColumnsInfo pComstomerSize5 = new PrintColumnsInfo();
            pComstomerSize5.name = "L";
            list.Add(pComstomerSize5);

            PrintColumnsInfo pComstomerSize6 = new PrintColumnsInfo();
            pComstomerSize6.name = "XL";
            list.Add(pComstomerSize6);

            PrintColumnsInfo pComstomerSize7 = new PrintColumnsInfo();
            pComstomerSize7.name = "2XL";
            list.Add(pComstomerSize7);

            PrintColumnsInfo pComstomerSize8 = new PrintColumnsInfo();
            pComstomerSize8.name = "3XL";
            list.Add(pComstomerSize8);

            PrintColumnsInfo pComstomerSize9 = new PrintColumnsInfo();
            pComstomerSize9.name = "4XL";
            list.Add(pComstomerSize9);

            PrintColumnsInfo pComstomerSize10 = new PrintColumnsInfo();
            pComstomerSize10.name = "5XL";
            list.Add(pComstomerSize10);

            PrintColumnsInfo pComstomerSize11 = new PrintColumnsInfo();
            pComstomerSize11.name = "6XL";
            list.Add(pComstomerSize11);

            PrintColumnsInfo pComstomerNum = new PrintColumnsInfo();
            pComstomerNum.name = "数量";
            list.Add(pComstomerNum);

            PrintColumnsInfo pComstomerAllPrice = new PrintColumnsInfo();
            pComstomerAllPrice.name = "总金额";
            list.Add(pComstomerAllPrice);

            PrintColumnsInfo pComstomerRemark = new PrintColumnsInfo();
            pComstomerRemark.name = "备注";
            list.Add(pComstomerRemark);
            return list;
        }
        #endregion

        #region
        /// <summary>
        /// 调拨单列名
        /// </summary>
        /// <returns></returns>
        /// 款号、商品名称、品牌、颜色、年份、季节、吊牌价、售价、尺码列、数量、总金额、备注
        public static List<PrintColumnsInfo> getAllocateColumnsInfo()
        {
            List<PrintColumnsInfo> list = new List<PrintColumnsInfo>();
            PrintColumnsInfo pComstomerID = new PrintColumnsInfo();
            pComstomerID.name = "款号";
            list.Add(pComstomerID);
            PrintColumnsInfo pComstomerName = new PrintColumnsInfo();
            pComstomerName.name = "商品名称";
            list.Add(pComstomerName);
            //商品名称、品牌、颜色、年份、季节、成本价、吊牌价、售价、尺码列、数量、总成本、备注
            PrintColumnsInfo pComstomerBrand = new PrintColumnsInfo();
            pComstomerBrand.name = "品牌";
            list.Add(pComstomerBrand);

            PrintColumnsInfo pComstomerColor = new PrintColumnsInfo();
            pComstomerColor.name = "颜色";
            list.Add(pComstomerColor);

            PrintColumnsInfo pComstomerYear = new PrintColumnsInfo();
            pComstomerYear.name = "年份";
            list.Add(pComstomerYear);

            PrintColumnsInfo pComstomerSearon = new PrintColumnsInfo();
            pComstomerSearon.name = "季节";
            list.Add(pComstomerSearon);


            PrintColumnsInfo pComstomerPrice = new PrintColumnsInfo();
            pComstomerPrice.name = "吊牌价";
            list.Add(pComstomerPrice);

            PrintColumnsInfo pComstomerSalePrice = new PrintColumnsInfo();
            pComstomerSalePrice.name = "售价";
            list.Add(pComstomerSalePrice);


            PrintColumnsInfo pComstomerSize1 = new PrintColumnsInfo();
            pComstomerSize1.name = "F";
            list.Add(pComstomerSize1);

            PrintColumnsInfo pComstomerSize2 = new PrintColumnsInfo();
            pComstomerSize2.name = "XS";
            list.Add(pComstomerSize2);

            PrintColumnsInfo pComstomerSize3 = new PrintColumnsInfo();
            pComstomerSize3.name = "S";
            list.Add(pComstomerSize3);

            PrintColumnsInfo pComstomerSize4 = new PrintColumnsInfo();
            pComstomerSize4.name = "M";
            list.Add(pComstomerSize4);

            PrintColumnsInfo pComstomerSize5 = new PrintColumnsInfo();
            pComstomerSize5.name = "L";
            list.Add(pComstomerSize5);

            PrintColumnsInfo pComstomerSize6 = new PrintColumnsInfo();
            pComstomerSize6.name = "XL";
            list.Add(pComstomerSize6);

            PrintColumnsInfo pComstomerSize7 = new PrintColumnsInfo();
            pComstomerSize7.name = "2XL";
            list.Add(pComstomerSize7);

            PrintColumnsInfo pComstomerSize8 = new PrintColumnsInfo();
            pComstomerSize8.name = "3XL";
            list.Add(pComstomerSize8);

            PrintColumnsInfo pComstomerSize9 = new PrintColumnsInfo();
            pComstomerSize9.name = "4XL";
            list.Add(pComstomerSize9);

            PrintColumnsInfo pComstomerSize10 = new PrintColumnsInfo();
            pComstomerSize10.name = "5XL";
            list.Add(pComstomerSize10);

            PrintColumnsInfo pComstomerSize11 = new PrintColumnsInfo();
            pComstomerSize11.name = "6XL";
            list.Add(pComstomerSize11);

            PrintColumnsInfo pComstomerNum = new PrintColumnsInfo();
            pComstomerNum.name = "数量";
            list.Add(pComstomerNum);
             
            PrintColumnsInfo pComstomerAllPrice = new PrintColumnsInfo();
            pComstomerAllPrice.name = "总金额";
            list.Add(pComstomerAllPrice);

            PrintColumnsInfo pComstomerRemark = new PrintColumnsInfo();
            pComstomerRemark.name = "备注";
            list.Add(pComstomerRemark);
            return list;
        }
        #endregion

        #region
        /// <summary>
        /// 补货申请列名
        /// </summary>
        /// <returns></returns>
        /// 款号、商品名称、品牌、颜色、吊牌价、尺码列、数量、总金额、备注
        public static List<PrintColumnsInfo> getFreplenishBillColumnsInfo()
        {
            List<PrintColumnsInfo> list = new List<PrintColumnsInfo>();
            PrintColumnsInfo pComstomerID = new PrintColumnsInfo();
            pComstomerID.name = "款号";
            list.Add(pComstomerID);
            PrintColumnsInfo pComstomerName = new PrintColumnsInfo();
            pComstomerName.name = "商品名称";
            list.Add(pComstomerName);
            PrintColumnsInfo pComstomerBrand = new PrintColumnsInfo();
            pComstomerBrand.name = "品牌";
            list.Add(pComstomerBrand);

            PrintColumnsInfo pComstomerColor = new PrintColumnsInfo();
            pComstomerColor.name = "颜色";
            list.Add(pComstomerColor);

            PrintColumnsInfo pComstomerPrice = new PrintColumnsInfo();
            pComstomerPrice.name = "吊牌价";
            list.Add(pComstomerPrice);


            PrintColumnsInfo pComstomerSize1 = new PrintColumnsInfo();
            pComstomerSize1.name = "F";
            list.Add(pComstomerSize1);

            PrintColumnsInfo pComstomerSize2 = new PrintColumnsInfo();
            pComstomerSize2.name = "XS";
            list.Add(pComstomerSize2);

            PrintColumnsInfo pComstomerSize3 = new PrintColumnsInfo();
            pComstomerSize3.name = "S";
            list.Add(pComstomerSize3);

            PrintColumnsInfo pComstomerSize4 = new PrintColumnsInfo();
            pComstomerSize4.name = "M";
            list.Add(pComstomerSize4);

            PrintColumnsInfo pComstomerSize5 = new PrintColumnsInfo();
            pComstomerSize5.name = "L";
            list.Add(pComstomerSize5);

            PrintColumnsInfo pComstomerSize6 = new PrintColumnsInfo();
            pComstomerSize6.name = "XL";
            list.Add(pComstomerSize6);

            PrintColumnsInfo pComstomerSize7 = new PrintColumnsInfo();
            pComstomerSize7.name = "2XL";
            list.Add(pComstomerSize7);

            PrintColumnsInfo pComstomerSize8 = new PrintColumnsInfo();
            pComstomerSize8.name = "3XL";
            list.Add(pComstomerSize8);

            PrintColumnsInfo pComstomerSize9 = new PrintColumnsInfo();
            pComstomerSize9.name = "4XL";
            list.Add(pComstomerSize9);

            PrintColumnsInfo pComstomerSize10 = new PrintColumnsInfo();
            pComstomerSize10.name = "5XL";
            list.Add(pComstomerSize10);

            PrintColumnsInfo pComstomerSize11 = new PrintColumnsInfo();
            pComstomerSize11.name = "6XL";
            list.Add(pComstomerSize11);


            PrintColumnsInfo pComstomerNum = new PrintColumnsInfo();
            pComstomerNum.name = "数量";
            list.Add(pComstomerNum);
            PrintColumnsInfo pComstomerAllPrice = new PrintColumnsInfo();
            pComstomerAllPrice.name = "总金额";
            list.Add(pComstomerAllPrice);

            PrintColumnsInfo pComstomerRemark = new PrintColumnsInfo();
            pComstomerRemark.name = "备注";
            list.Add(pComstomerRemark);


            return list;
        }
        #endregion

        #region
        /// <summary>
        /// 批发发货列名
        /// </summary>
        /// <returns></returns>
        /// 款号、商品名称、品牌、颜色、批发价、尺码列、数量、批发总额、备注
        public static List<PrintColumnsInfo> getPfSendBillColumnsInfo()
        {
            List<PrintColumnsInfo> list = new List<PrintColumnsInfo>();
            PrintColumnsInfo pComstomerID = new PrintColumnsInfo();
            pComstomerID.name = "款号";
            list.Add(pComstomerID);
            PrintColumnsInfo pComstomerName = new PrintColumnsInfo();
            pComstomerName.name = "商品名称";
            list.Add(pComstomerName);
            PrintColumnsInfo pComstomerBrand = new PrintColumnsInfo();
            pComstomerBrand.name = "品牌";
            list.Add(pComstomerBrand);

            PrintColumnsInfo pComstomerColor = new PrintColumnsInfo();
            pComstomerColor.name = "颜色";
            list.Add(pComstomerColor);


            PrintColumnsInfo pComstomerPfPrice = new PrintColumnsInfo();
            pComstomerPfPrice.name = "批发价";
            list.Add(pComstomerPfPrice);



            PrintColumnsInfo pComstomerPrice = new PrintColumnsInfo();
            pComstomerPrice.name = "吊牌价";
            list.Add(pComstomerPrice);

            PrintColumnsInfo pComstomerSize1 = new PrintColumnsInfo();
            pComstomerSize1.name = "F";
            list.Add(pComstomerSize1);

            PrintColumnsInfo pComstomerSize2 = new PrintColumnsInfo();
            pComstomerSize2.name = "XS";
            list.Add(pComstomerSize2);

            PrintColumnsInfo pComstomerSize3 = new PrintColumnsInfo();
            pComstomerSize3.name = "S";
            list.Add(pComstomerSize3);

            PrintColumnsInfo pComstomerSize4 = new PrintColumnsInfo();
            pComstomerSize4.name = "M";
            list.Add(pComstomerSize4);

            PrintColumnsInfo pComstomerSize5 = new PrintColumnsInfo();
            pComstomerSize5.name = "L";
            list.Add(pComstomerSize5);

            PrintColumnsInfo pComstomerSize6 = new PrintColumnsInfo();
            pComstomerSize6.name = "XL";
            list.Add(pComstomerSize6);

            PrintColumnsInfo pComstomerSize7 = new PrintColumnsInfo();
            pComstomerSize7.name = "2XL";
            list.Add(pComstomerSize7);

            PrintColumnsInfo pComstomerSize8 = new PrintColumnsInfo();
            pComstomerSize8.name = "3XL";
            list.Add(pComstomerSize8);

            PrintColumnsInfo pComstomerSize9 = new PrintColumnsInfo();
            pComstomerSize9.name = "4XL";
            list.Add(pComstomerSize9);

            PrintColumnsInfo pComstomerSize10 = new PrintColumnsInfo();
            pComstomerSize10.name = "5XL";
            list.Add(pComstomerSize10);

            PrintColumnsInfo pComstomerSize11 = new PrintColumnsInfo();
            pComstomerSize11.name = "6XL";
            list.Add(pComstomerSize11);

            PrintColumnsInfo pComstomerNum = new PrintColumnsInfo();
            pComstomerNum.name = "数量";
            list.Add(pComstomerNum);
            PrintColumnsInfo pComstomerAllPrice = new PrintColumnsInfo();
            pComstomerAllPrice.name = "批发总额";
            list.Add(pComstomerAllPrice);

            PrintColumnsInfo pComstomerRemark = new PrintColumnsInfo();
            pComstomerRemark.name = "备注";
            list.Add(pComstomerRemark); 


            return list;
        }
        #endregion

        #region
        /// <summary>
        /// 采购列名
        /// </summary>
        /// <returns></returns>
        public static List<PrintColumnsInfo> getPurchaseStockColumnsInfo()
        {
            List<PrintColumnsInfo> list = new List<PrintColumnsInfo>();
            PrintColumnsInfo pComstomerID = new PrintColumnsInfo();
            pComstomerID.name = "款号";
            list.Add(pComstomerID);
            PrintColumnsInfo pComstomerName = new PrintColumnsInfo();
            pComstomerName.name = "商品名称";
            list.Add(pComstomerName);
            //商品名称、品牌、颜色、年份、季节、成本价、吊牌价、售价、尺码列、数量、总成本、备注
            PrintColumnsInfo pComstomerBrand = new PrintColumnsInfo();
            pComstomerBrand.name = "品牌";
            list.Add(pComstomerBrand);

            PrintColumnsInfo pComstomerColor = new PrintColumnsInfo();
            pComstomerColor.name = "颜色";
            list.Add(pComstomerColor);

            PrintColumnsInfo pComstomerYear = new PrintColumnsInfo();
            pComstomerYear.name = "年份";
            list.Add(pComstomerYear);

            PrintColumnsInfo pComstomerSearon = new PrintColumnsInfo();
            pComstomerSearon.name = "季节";
            list.Add(pComstomerSearon);

            PrintColumnsInfo pComstomerCostPrice = new PrintColumnsInfo();
            pComstomerCostPrice.name = "成本价";
            list.Add(pComstomerCostPrice);

            PrintColumnsInfo pComstomerPrice = new PrintColumnsInfo();
            pComstomerPrice.name = "吊牌价";
            list.Add(pComstomerPrice);

            PrintColumnsInfo pComstomerSalePrice = new PrintColumnsInfo();
            pComstomerSalePrice.name = "售价";
            list.Add(pComstomerSalePrice);

            PrintColumnsInfo pComstomerSize1 = new PrintColumnsInfo();
            pComstomerSize1.name = "F";
            list.Add(pComstomerSize1);

            PrintColumnsInfo pComstomerSize2 = new PrintColumnsInfo();
            pComstomerSize2.name = "XS";
            list.Add(pComstomerSize2);

            PrintColumnsInfo pComstomerSize3 = new PrintColumnsInfo();
            pComstomerSize3.name = "S";
            list.Add(pComstomerSize3);

            PrintColumnsInfo pComstomerSize4 = new PrintColumnsInfo();
            pComstomerSize4.name = "M";
            list.Add(pComstomerSize4);

            PrintColumnsInfo pComstomerSize5 = new PrintColumnsInfo();
            pComstomerSize5.name = "L";
            list.Add(pComstomerSize5);

            PrintColumnsInfo pComstomerSize6 = new PrintColumnsInfo();
            pComstomerSize6.name = "XL";
            list.Add(pComstomerSize6);

            PrintColumnsInfo pComstomerSize7 = new PrintColumnsInfo();
            pComstomerSize7.name = "2XL";
            list.Add(pComstomerSize7);

            PrintColumnsInfo pComstomerSize8 = new PrintColumnsInfo();
            pComstomerSize8.name = "3XL";
            list.Add(pComstomerSize8);

            PrintColumnsInfo pComstomerSize9 = new PrintColumnsInfo();
            pComstomerSize9.name = "4XL";
            list.Add(pComstomerSize9);

            PrintColumnsInfo pComstomerSize10 = new PrintColumnsInfo();
            pComstomerSize10.name = "5XL";
            list.Add(pComstomerSize10);

            PrintColumnsInfo pComstomerSize11 = new PrintColumnsInfo();
            pComstomerSize11.name = "6XL";
            list.Add(pComstomerSize11);

            PrintColumnsInfo pComstomerNum = new PrintColumnsInfo();
            pComstomerNum.name = "数量";
            list.Add(pComstomerNum);

            PrintColumnsInfo pComstomerAllCostPrice = new PrintColumnsInfo();
            pComstomerAllCostPrice.name = "总成本"; 
            list.Add(pComstomerAllCostPrice);

            PrintColumnsInfo pComstomerRemark = new PrintColumnsInfo();
            pComstomerRemark.name = "备注";
            list.Add(pComstomerRemark);
            return list;
        }
        #endregion

        #region
        /// <summary>
        /// 采购退货列名
        /// </summary>
        /// <returns></returns>
        public static List<PrintColumnsInfo> getPurchaseStockReturnColumnsInfo()
        {
            List<PrintColumnsInfo> list = new List<PrintColumnsInfo>();
            PrintColumnsInfo pComstomerID = new PrintColumnsInfo();
            pComstomerID.name = "款号";
            list.Add(pComstomerID);
            PrintColumnsInfo pComstomerName = new PrintColumnsInfo();
            pComstomerName.name = "商品名称";
            list.Add(pComstomerName);
            //商品名称、品牌、颜色、年份、季节、成本价、吊牌价、售价、尺码列、数量、总成本、备注
            PrintColumnsInfo pComstomerBrand = new PrintColumnsInfo();
            pComstomerBrand.name = "品牌";
            list.Add(pComstomerBrand);

            PrintColumnsInfo pComstomerColor = new PrintColumnsInfo();
            pComstomerColor.name = "颜色";
            list.Add(pComstomerColor);

            PrintColumnsInfo pComstomerYear = new PrintColumnsInfo();
            pComstomerYear.name = "年份";
            list.Add(pComstomerYear);

            PrintColumnsInfo pComstomerSearon = new PrintColumnsInfo();
            pComstomerSearon.name = "季节";
            list.Add(pComstomerSearon);

            PrintColumnsInfo pComstomerCostPrice = new PrintColumnsInfo();
            pComstomerCostPrice.name = "成本价";
            list.Add(pComstomerCostPrice);

            PrintColumnsInfo pComstomerPrice = new PrintColumnsInfo();
            pComstomerPrice.name = "吊牌价";
            list.Add(pComstomerPrice);

            //PrintColumnsInfo pComstomerSalePrice = new PrintColumnsInfo();
            //pComstomerSalePrice.name = "售价";
            //list.Add(pComstomerSalePrice);

            PrintColumnsInfo pComstomerSize1 = new PrintColumnsInfo();
            pComstomerSize1.name = "F";
            list.Add(pComstomerSize1);

            PrintColumnsInfo pComstomerSize2 = new PrintColumnsInfo();
            pComstomerSize2.name = "XS";
            list.Add(pComstomerSize2);

            PrintColumnsInfo pComstomerSize3 = new PrintColumnsInfo();
            pComstomerSize3.name = "S";
            list.Add(pComstomerSize3);

            PrintColumnsInfo pComstomerSize4 = new PrintColumnsInfo();
            pComstomerSize4.name = "M";
            list.Add(pComstomerSize4);

            PrintColumnsInfo pComstomerSize5 = new PrintColumnsInfo();
            pComstomerSize5.name = "L";
            list.Add(pComstomerSize5);

            PrintColumnsInfo pComstomerSize6 = new PrintColumnsInfo();
            pComstomerSize6.name = "XL";
            list.Add(pComstomerSize6);

            PrintColumnsInfo pComstomerSize7 = new PrintColumnsInfo();
            pComstomerSize7.name = "2XL";
            list.Add(pComstomerSize7);

            PrintColumnsInfo pComstomerSize8 = new PrintColumnsInfo();
            pComstomerSize8.name = "3XL";
            list.Add(pComstomerSize8);

            PrintColumnsInfo pComstomerSize9 = new PrintColumnsInfo();
            pComstomerSize9.name = "4XL";
            list.Add(pComstomerSize9);

            PrintColumnsInfo pComstomerSize10 = new PrintColumnsInfo();
            pComstomerSize10.name = "5XL";
            list.Add(pComstomerSize10);

            PrintColumnsInfo pComstomerSize11 = new PrintColumnsInfo();
            pComstomerSize11.name = "6XL";
            list.Add(pComstomerSize11);

            PrintColumnsInfo pComstomerNum = new PrintColumnsInfo();
            pComstomerNum.name = "数量";
            list.Add(pComstomerNum);

            PrintColumnsInfo pComstomerAllCostPrice = new PrintColumnsInfo();
            pComstomerAllCostPrice.name = "总成本";
            list.Add(pComstomerAllCostPrice);

            PrintColumnsInfo pComstomerRemark = new PrintColumnsInfo();
            pComstomerRemark.name = "备注";
            list.Add(pComstomerRemark);
            return list;
        }
        #endregion


        public static void CreateColumns1(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[0].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            
            dataGridViewColumn1.ReadOnly = true;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width*pInfo.Rate / 100);
                    }
                }
            }
           // dataGridViewColumn1.Width = 50;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn1});
        }
        public static void CreateColumns2(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            #region
            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[0].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
           
            // dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[1].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                }
            }
            //   dataGridViewColumn3.Width = 50;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn2,dataGridViewColumn3});

            #endregion
        }
        public static void CreateColumns3(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            #region
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[0].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            
           // dataGridViewColumn4.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn5.HeaderText = columnsInfo[1].name;
            dataGridViewColumn5.Name = "dataGridViewColumn5";
            dataGridViewColumn5.ReadOnly = true;
            dataGridViewColumn5.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn6 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn6.HeaderText = columnsInfo[2].name;
            dataGridViewColumn6.Name = "dataGridViewColumn6";
            dataGridViewColumn6.ReadOnly = true;
            dataGridViewColumn6.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn5.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn6.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn4,dataGridViewColumn5,dataGridViewColumn6});
            
            #endregion
        }
        public static void CreateColumns4(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            #region

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn7 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn7.HeaderText = columnsInfo[0].name;
            dataGridViewColumn7.Name = "dataGridViewColumn7";
            dataGridViewColumn7.ReadOnly = true;

            dataGridViewColumn7.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn8 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn8.HeaderText = columnsInfo[1].name;
            dataGridViewColumn8.Name = "dataGridViewColumn8";
            dataGridViewColumn8.ReadOnly = true;
            dataGridViewColumn8.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn9 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn9.HeaderText = columnsInfo[2].name;
            dataGridViewColumn9.Name = "dataGridViewColumn9";
            dataGridViewColumn9.ReadOnly = true;
            dataGridViewColumn9.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn10 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn10.HeaderText = columnsInfo[3].name;
            dataGridViewColumn10.Name = "dataGridViewColumn10";
            dataGridViewColumn10.ReadOnly = true;
            dataGridViewColumn10.Width = 50;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn7.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn8.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn9.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn10.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn7,dataGridViewColumn8,dataGridViewColumn9,dataGridViewColumn10});
            #endregion
        }
        public static void CreateColumns5(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {
            #region

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn11 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn11.HeaderText = columnsInfo[0].name;
            dataGridViewColumn11.Name = "dataGridViewColumn11";
            dataGridViewColumn11.ReadOnly = true;

            dataGridViewColumn11.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn12 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn12.HeaderText = columnsInfo[1].name;
            dataGridViewColumn12.Name = "dataGridViewColumn12";
            dataGridViewColumn12.ReadOnly = true;
            dataGridViewColumn12.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn13 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn13.HeaderText = columnsInfo[2].name;
            dataGridViewColumn13.Name = "dataGridViewColumn13";
            dataGridViewColumn13.ReadOnly = true;
            dataGridViewColumn13.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn14 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn14.HeaderText = columnsInfo[3].name;
            dataGridViewColumn14.Name = "dataGridViewColumn14";
            dataGridViewColumn14.ReadOnly = true;
            dataGridViewColumn14.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn15 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn15.HeaderText = columnsInfo[4].name;
            dataGridViewColumn15.Name = "dataGridViewColumn15";
            dataGridViewColumn15.ReadOnly = true;
            dataGridViewColumn15.Width = 50;


            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn11.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn12.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn13.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn14.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn15.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn11,dataGridViewColumn12,dataGridViewColumn13,dataGridViewColumn14,dataGridViewColumn15});
            #endregion

        }
        public static void CreateColumns6(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            #region
            DataGridViewTextBoxColumn dataGridViewColumn16 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn16.HeaderText = columnsInfo[0].name;
            dataGridViewColumn16.Name = "dataGridViewColumn16";
            dataGridViewColumn16.ReadOnly = true;
            dataGridViewColumn16.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //   dataGridViewColumn16.Width = 200;

            DataGridViewTextBoxColumn dataGridViewColumn17 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn17.HeaderText = columnsInfo[1].name;
            dataGridViewColumn17.Name = "dataGridViewColumn17";
            dataGridViewColumn17.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewColumn17.ReadOnly = true;
         //   dataGridViewColumn17.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn18 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn18.HeaderText = columnsInfo[2].name;
            dataGridViewColumn18.Name = "dataGridViewColumn18";
            dataGridViewColumn18.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewColumn18.ReadOnly = true;
          //  dataGridViewColumn18.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn19 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn19.HeaderText = columnsInfo[3].name;
            dataGridViewColumn19.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewColumn19.Name = "dataGridViewColumn19";
            dataGridViewColumn19.ReadOnly = true;
         //   dataGridViewColumn19.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn20 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn20.HeaderText = columnsInfo[4].name;
            dataGridViewColumn20.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewColumn20.Name = "dataGridViewColumn20";
            dataGridViewColumn20.ReadOnly = true;
          //  dataGridViewColumn20.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn21 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn21.HeaderText = columnsInfo[5].name;
            dataGridViewColumn21.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewColumn21.Name = "dataGridViewColumn21";
            dataGridViewColumn21.ReadOnly = true;
            //  dataGridViewColumn21.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn16.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    else if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn17.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate/100);
                    }


                    else if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn18.Width =Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    else if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn19.Width =Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    else if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn20.Width =  Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    else if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn21.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn16,dataGridViewColumn17,dataGridViewColumn18,dataGridViewColumn19,dataGridViewColumn20,dataGridViewColumn21});
            #endregion
        }
        public static void CreateColumns7(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            #region
            DataGridViewTextBoxColumn dataGridViewColumn22 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn22.HeaderText = columnsInfo[0].name;
            dataGridViewColumn22.Name = "dataGridViewColumn22";
            dataGridViewColumn22.ReadOnly = true;

            dataGridViewColumn22.Width = 100;

            DataGridViewTextBoxColumn dataGridViewColumn23 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn23.HeaderText = columnsInfo[1].name;
            dataGridViewColumn23.Name = "dataGridViewColumn23";
            dataGridViewColumn23.ReadOnly = true;
            dataGridViewColumn23.Width = 100;
            DataGridViewTextBoxColumn dataGridViewColumn24 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn24.HeaderText = columnsInfo[2].name;
            dataGridViewColumn24.Name = "dataGridViewColumn24";
            dataGridViewColumn24.ReadOnly = true;
            dataGridViewColumn24.Width = 100;
            DataGridViewTextBoxColumn dataGridViewColumn25 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn25.HeaderText = columnsInfo[3].name;
            dataGridViewColumn25.Name = "dataGridViewColumn25";
            dataGridViewColumn25.ReadOnly = true;
            dataGridViewColumn25.Width = 100;
            DataGridViewTextBoxColumn dataGridViewColumn26 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn26.HeaderText = columnsInfo[4].name;
            dataGridViewColumn26.Name = "dataGridViewColumn26";
            dataGridViewColumn26.ReadOnly = true;
            dataGridViewColumn26.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn27 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn27.HeaderText = columnsInfo[5].name;
            dataGridViewColumn27.Name = "dataGridViewColumn27";
            dataGridViewColumn27.ReadOnly = true;
            dataGridViewColumn27.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn28 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn28.HeaderText = columnsInfo[6].name;
            dataGridViewColumn28.Name = "dataGridViewColumn28";
            dataGridViewColumn28.ReadOnly = true;
            dataGridViewColumn28.Width = 50;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn22.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn23.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn24.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn25.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn26.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn27.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn28.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn22,dataGridViewColumn23,dataGridViewColumn24,dataGridViewColumn25,dataGridViewColumn26,dataGridViewColumn27,dataGridViewColumn28});
            #endregion
        }
        public static void CreateColumns8(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {
            #region

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn29 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn29.HeaderText = columnsInfo[0].name;
            dataGridViewColumn29.Name = "dataGridViewColumn29";
            dataGridViewColumn29.ReadOnly = true;

            dataGridViewColumn29.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn30 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn30.HeaderText = columnsInfo[1].name;
            dataGridViewColumn30.Name = "dataGridViewColumn30";
            dataGridViewColumn30.ReadOnly = true;
            dataGridViewColumn30.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn31 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn31.HeaderText = columnsInfo[2].name;
            dataGridViewColumn31.Name = "dataGridViewColumn31";
            dataGridViewColumn31.ReadOnly = true;
            dataGridViewColumn31.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn32 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn32.HeaderText = columnsInfo[3].name;
            dataGridViewColumn32.Name = "dataGridViewColumn32";
            dataGridViewColumn32.ReadOnly = true;
            dataGridViewColumn32.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn33 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn33.HeaderText = columnsInfo[4].name;
            dataGridViewColumn33.Name = "dataGridViewColumn33";
            dataGridViewColumn33.ReadOnly = true;
            dataGridViewColumn33.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn34 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn34.HeaderText = columnsInfo[5].name;
            dataGridViewColumn34.Name = "dataGridViewColumn34";
            dataGridViewColumn34.ReadOnly = true;
            dataGridViewColumn34.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn35 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn35.HeaderText = columnsInfo[6].name;
            dataGridViewColumn35.Name = "dataGridViewColumn35";
            dataGridViewColumn35.ReadOnly = true;
            dataGridViewColumn35.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn36 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn36.HeaderText = columnsInfo[7].name;
            dataGridViewColumn36.Name = "dataGridViewColumn36";
            dataGridViewColumn36.ReadOnly = true;
            dataGridViewColumn36.Width = 50;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn29.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn30.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn31.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn32.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn33.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn34.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn35.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn36.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn29,dataGridViewColumn30,dataGridViewColumn31,dataGridViewColumn32,dataGridViewColumn33,dataGridViewColumn34,dataGridViewColumn35,dataGridViewColumn36});
            #endregion

        }
        public static void CreateColumns9(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {


            dataGridView.Columns.Clear();
            #region
            DataGridViewTextBoxColumn dataGridViewColumn37 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn37.HeaderText = columnsInfo[0].name;
            dataGridViewColumn37.Name = "dataGridViewColumn37";
            dataGridViewColumn37.ReadOnly = true;

            dataGridViewColumn37.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn38 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn38.HeaderText = columnsInfo[1].name;
            dataGridViewColumn38.Name = "dataGridViewColumn38";
            dataGridViewColumn38.ReadOnly = true;
            dataGridViewColumn38.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn39 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn39.HeaderText = columnsInfo[2].name;
            dataGridViewColumn39.Name = "dataGridViewColumn39";
            dataGridViewColumn39.ReadOnly = true;
            dataGridViewColumn39.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn40 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn40.HeaderText = columnsInfo[3].name;
            dataGridViewColumn40.Name = "dataGridViewColumn40";
            dataGridViewColumn40.ReadOnly = true;
            dataGridViewColumn40.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn41 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn41.HeaderText = columnsInfo[4].name;
            dataGridViewColumn41.Name = "dataGridViewColumn41";
            dataGridViewColumn41.ReadOnly = true;
            dataGridViewColumn41.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn42 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn42.HeaderText = columnsInfo[5].name;
            dataGridViewColumn42.Name = "dataGridViewColumn42";
            dataGridViewColumn42.ReadOnly = true;
            dataGridViewColumn42.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn43 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn43.HeaderText = columnsInfo[6].name;
            dataGridViewColumn43.Name = "dataGridViewColumn43";
            dataGridViewColumn43.ReadOnly = true;
            dataGridViewColumn43.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn44 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn44.HeaderText = columnsInfo[7].name;
            dataGridViewColumn44.Name = "dataGridViewColumn44";
            dataGridViewColumn44.ReadOnly = true;
            dataGridViewColumn44.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn45 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn45.HeaderText = columnsInfo[8].name;
            dataGridViewColumn45.Name = "dataGridViewColumn45";
            dataGridViewColumn45.ReadOnly = true;
            dataGridViewColumn45.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn37.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn38.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn39.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn40.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn41.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn42.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn43.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn44.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn45.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn37,dataGridViewColumn38,dataGridViewColumn39,dataGridViewColumn40,dataGridViewColumn41,dataGridViewColumn42,dataGridViewColumn43,dataGridViewColumn44,dataGridViewColumn45});
            #endregion
        }



        public static void CreateColumns10(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn46 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn46.HeaderText = columnsInfo[0].name;
            dataGridViewColumn46.Name = "dataGridViewColumn46";
            dataGridViewColumn46.ReadOnly = true;

            dataGridViewColumn46.Width = 50;
            //this.dataGridViewTextBoxColumn3.Width = 80;

            DataGridViewTextBoxColumn dataGridViewColumn47 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn47.HeaderText = columnsInfo[1].name;
            dataGridViewColumn47.Name = "dataGridViewColumn47";
            dataGridViewColumn47.ReadOnly = true;
            dataGridViewColumn47.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn48 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn48.HeaderText = columnsInfo[2].name;
            dataGridViewColumn48.Name = "dataGridViewColumn48";
            dataGridViewColumn48.ReadOnly = true;
            dataGridViewColumn48.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn49 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn49.HeaderText = columnsInfo[3].name;
            dataGridViewColumn49.Name = "dataGridViewColumn49";
            dataGridViewColumn49.ReadOnly = true;
            dataGridViewColumn49.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn50 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn50.HeaderText = columnsInfo[4].name;
            dataGridViewColumn50.Name = "dataGridViewColumn50";
            dataGridViewColumn50.ReadOnly = true;
            dataGridViewColumn50.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn51 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn51.HeaderText = columnsInfo[5].name;
            dataGridViewColumn51.Name = "dataGridViewColumn51";
            dataGridViewColumn51.ReadOnly = true;
            dataGridViewColumn51.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn52 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn52.HeaderText = columnsInfo[6].name;
            dataGridViewColumn52.Name = "dataGridViewColumn52";
            dataGridViewColumn52.ReadOnly = true;
            dataGridViewColumn52.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn53 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn53.HeaderText = columnsInfo[7].name;
            dataGridViewColumn53.Name = "dataGridViewColumn53";
            dataGridViewColumn53.ReadOnly = true;
            dataGridViewColumn53.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn54 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn54.HeaderText = columnsInfo[8].name;
            dataGridViewColumn54.Name = "dataGridViewColumn54";
            dataGridViewColumn54.ReadOnly = true;
            dataGridViewColumn54.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn55 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn55.HeaderText = columnsInfo[9].name;
            dataGridViewColumn55.Name = "dataGridViewColumn55";
            dataGridViewColumn55.ReadOnly = true;
            dataGridViewColumn55.Width = 50;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn46.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn47.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn48.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn49.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn50.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn52.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn52.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn53.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn54.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn55.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn46,dataGridViewColumn47,dataGridViewColumn48,dataGridViewColumn49,dataGridViewColumn50,dataGridViewColumn51,dataGridViewColumn52,dataGridViewColumn53,dataGridViewColumn54,dataGridViewColumn55});

        }

        public static void CreateColumns11(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol) {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn56 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn56.HeaderText = columnsInfo[0].name;
            dataGridViewColumn56.Name = "dataGridViewColumn56";
            dataGridViewColumn56.ReadOnly = true;

            dataGridViewColumn56.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn57 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn57.HeaderText = columnsInfo[1].name;
            dataGridViewColumn57.Name = "dataGridViewColumn57";
            dataGridViewColumn57.ReadOnly = true;
            dataGridViewColumn57.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn58 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn58.HeaderText = columnsInfo[2].name;
            dataGridViewColumn58.Name = "dataGridViewColumn58";
            dataGridViewColumn58.ReadOnly = true;
            dataGridViewColumn58.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn59 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn59.HeaderText = columnsInfo[3].name;
            dataGridViewColumn59.Name = "dataGridViewColumn59";
            dataGridViewColumn59.ReadOnly = true;
            dataGridViewColumn59.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn60 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn60.HeaderText = columnsInfo[4].name;
            dataGridViewColumn60.Name = "dataGridViewColumn60";
            dataGridViewColumn60.ReadOnly = true;
            dataGridViewColumn60.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn61 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn61.HeaderText = columnsInfo[5].name;
            dataGridViewColumn61.Name = "dataGridViewColumn61";
            dataGridViewColumn61.ReadOnly = true;
            dataGridViewColumn61.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn62 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn62.HeaderText = columnsInfo[6].name;
            dataGridViewColumn62.Name = "dataGridViewColumn62";
            dataGridViewColumn62.ReadOnly = true;
            dataGridViewColumn62.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn63 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn63.HeaderText = columnsInfo[7].name;
            dataGridViewColumn63.Name = "dataGridViewColumn63";
            dataGridViewColumn63.ReadOnly = true;
            dataGridViewColumn63.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn64 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn64.HeaderText = columnsInfo[8].name;
            dataGridViewColumn64.Name = "dataGridViewColumn64";
            dataGridViewColumn64.ReadOnly = true;
            dataGridViewColumn64.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn65 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn65.HeaderText = columnsInfo[9].name;
            dataGridViewColumn65.Name = "dataGridViewColumn65";
            dataGridViewColumn65.ReadOnly = true;
            dataGridViewColumn65.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn66 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn66.HeaderText = columnsInfo[10].name;
            dataGridViewColumn66.Name = "dataGridViewColumn66";
            dataGridViewColumn66.ReadOnly = true;
            dataGridViewColumn66.Width = 50;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn56.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn57.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn58.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn59.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn60.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn61.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn62.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn63.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn64.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn65.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn66.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn56,dataGridViewColumn57,dataGridViewColumn58,dataGridViewColumn59,dataGridViewColumn60,dataGridViewColumn61,dataGridViewColumn62,dataGridViewColumn63,dataGridViewColumn64,dataGridViewColumn65,dataGridViewColumn66});

        }


        public static void CreateColumns12(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn67 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn67.HeaderText = columnsInfo[0].name;
            dataGridViewColumn67.Name = "dataGridViewColumn67";
            dataGridViewColumn67.ReadOnly = true;

            dataGridViewColumn67.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn68 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn68.HeaderText = columnsInfo[1].name;
            dataGridViewColumn68.Name = "dataGridViewColumn68";
            dataGridViewColumn68.ReadOnly = true;
            dataGridViewColumn68.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn69 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn69.HeaderText = columnsInfo[2].name;
            dataGridViewColumn69.Name = "dataGridViewColumn69";
            dataGridViewColumn69.ReadOnly = true;
            dataGridViewColumn69.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn70 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn70.HeaderText = columnsInfo[3].name;
            dataGridViewColumn70.Name = "dataGridViewColumn70";
            dataGridViewColumn70.ReadOnly = true;
            dataGridViewColumn70.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn71 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn71.HeaderText = columnsInfo[4].name;
            dataGridViewColumn71.Name = "dataGridViewColumn71";
            dataGridViewColumn71.ReadOnly = true;
            dataGridViewColumn71.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn72 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn72.HeaderText = columnsInfo[5].name;
            dataGridViewColumn72.Name = "dataGridViewColumn72";
            dataGridViewColumn72.ReadOnly = true;
            dataGridViewColumn72.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn73 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn73.HeaderText = columnsInfo[6].name;
            dataGridViewColumn73.Name = "dataGridViewColumn73";
            dataGridViewColumn73.ReadOnly = true;
            dataGridViewColumn73.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn74 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn74.HeaderText = columnsInfo[7].name;
            dataGridViewColumn74.Name = "dataGridViewColumn74";
            dataGridViewColumn74.ReadOnly = true;
            dataGridViewColumn74.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn75 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn75.HeaderText = columnsInfo[8].name;
            dataGridViewColumn75.Name = "dataGridViewColumn75";
            dataGridViewColumn75.ReadOnly = true;
            dataGridViewColumn75.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn76 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn76.HeaderText = columnsInfo[9].name;
            dataGridViewColumn76.Name = "dataGridViewColumn76";
            dataGridViewColumn76.ReadOnly = true;
            dataGridViewColumn76.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn77 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn77.HeaderText = columnsInfo[10].name;
            dataGridViewColumn77.Name = "dataGridViewColumn77";
            dataGridViewColumn77.ReadOnly = true;
            dataGridViewColumn77.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn78 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn78.HeaderText = columnsInfo[11].name;
            dataGridViewColumn78.Name = "dataGridViewColumn78";
            dataGridViewColumn78.ReadOnly = true;
            dataGridViewColumn78.Width = 50;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn67.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn68.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn69.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn70.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn71.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn72.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn73.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn74.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn75.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn76.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn77.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn78.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             dataGridViewColumn67,dataGridViewColumn68,dataGridViewColumn69,dataGridViewColumn70,dataGridViewColumn71,dataGridViewColumn72,dataGridViewColumn73,dataGridViewColumn74,dataGridViewColumn75,dataGridViewColumn76,dataGridViewColumn77,dataGridViewColumn78});

        }
         
        public static void CreateColumns13(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {
            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,dataGridViewColumn91});


        }


        public static void CreateColumns14(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50; 

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,dataGridViewColumn91,dataGridViewColumn1
            });

        }


        public static void CreateColumns15(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2
            }); 

        }



        public static void CreateColumns16(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3

            });

        }


        public static void CreateColumns17(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[16].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            dataGridViewColumn4.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[16].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                   
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3,dataGridViewColumn4

            });

        }


        public static void CreateColumns18(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {
            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[16].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            dataGridViewColumn4.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn5.HeaderText = columnsInfo[17].name;
            dataGridViewColumn5.Name = "dataGridViewColumn5";
            dataGridViewColumn5.ReadOnly = true;
            dataGridViewColumn5.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[16].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[17].name)
                    {
                        dataGridViewColumn5.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3
                ,dataGridViewColumn4,dataGridViewColumn5

            });

        }
        public static void CreateColumns19(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {
            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[16].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            dataGridViewColumn4.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn5.HeaderText = columnsInfo[17].name;
            dataGridViewColumn5.Name = "dataGridViewColumn5";
            dataGridViewColumn5.ReadOnly = true;
            dataGridViewColumn5.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn6 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn6.HeaderText = columnsInfo[18].name;
            dataGridViewColumn6.Name = "dataGridViewColumn6";
            dataGridViewColumn6.ReadOnly = true;
            dataGridViewColumn6.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[16].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[17].name)
                    {
                        dataGridViewColumn5.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[18].name)
                    {
                        dataGridViewColumn6.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3
                ,dataGridViewColumn4,dataGridViewColumn5,dataGridViewColumn6

            });

        }
        public static void CreateColumns20(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[16].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            dataGridViewColumn4.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn5.HeaderText = columnsInfo[17].name;
            dataGridViewColumn5.Name = "dataGridViewColumn5";
            dataGridViewColumn5.ReadOnly = true;
            dataGridViewColumn5.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn6 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn6.HeaderText = columnsInfo[18].name;
            dataGridViewColumn6.Name = "dataGridViewColumn6";
            dataGridViewColumn6.ReadOnly = true;
            dataGridViewColumn6.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn7 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn7.HeaderText = columnsInfo[19].name;
            dataGridViewColumn7.Name = "dataGridViewColumn7";
            dataGridViewColumn7.ReadOnly = true;
            dataGridViewColumn7.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[16].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[17].name)
                    {
                        dataGridViewColumn5.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[18].name)
                    {
                        dataGridViewColumn6.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[19].name)
                    {
                        dataGridViewColumn7.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3
                ,dataGridViewColumn4,dataGridViewColumn5,dataGridViewColumn6,dataGridViewColumn7

            });

        }

        public static void CreateColumns21(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {
            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[16].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            dataGridViewColumn4.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn5.HeaderText = columnsInfo[17].name;
            dataGridViewColumn5.Name = "dataGridViewColumn5";
            dataGridViewColumn5.ReadOnly = true;
            dataGridViewColumn5.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn6 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn6.HeaderText = columnsInfo[18].name;
            dataGridViewColumn6.Name = "dataGridViewColumn6";
            dataGridViewColumn6.ReadOnly = true;
            dataGridViewColumn6.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn7 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn7.HeaderText = columnsInfo[19].name;
            dataGridViewColumn7.Name = "dataGridViewColumn7";
            dataGridViewColumn7.ReadOnly = true;
            dataGridViewColumn7.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn8 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn8.HeaderText = columnsInfo[20].name;
            dataGridViewColumn8.Name = "dataGridViewColumn8";
            dataGridViewColumn8.ReadOnly = true;
            dataGridViewColumn8.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[16].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[17].name)
                    {
                        dataGridViewColumn5.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[18].name)
                    {
                        dataGridViewColumn6.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[19].name)
                    {
                        dataGridViewColumn7.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[20].name)
                    {
                        dataGridViewColumn8.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    } 
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3
                ,dataGridViewColumn4,dataGridViewColumn5,dataGridViewColumn6,dataGridViewColumn7,dataGridViewColumn8

            });

        }


        public static void CreateColumns22(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {
            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[16].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            dataGridViewColumn4.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn5.HeaderText = columnsInfo[17].name;
            dataGridViewColumn5.Name = "dataGridViewColumn5";
            dataGridViewColumn5.ReadOnly = true;
            dataGridViewColumn5.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn6 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn6.HeaderText = columnsInfo[18].name;
            dataGridViewColumn6.Name = "dataGridViewColumn6";
            dataGridViewColumn6.ReadOnly = true;
            dataGridViewColumn6.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn7 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn7.HeaderText = columnsInfo[19].name;
            dataGridViewColumn7.Name = "dataGridViewColumn7";
            dataGridViewColumn7.ReadOnly = true;
            dataGridViewColumn7.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn8 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn8.HeaderText = columnsInfo[20].name;
            dataGridViewColumn8.Name = "dataGridViewColumn8";
            dataGridViewColumn8.ReadOnly = true;
            dataGridViewColumn8.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn9= new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn9.HeaderText = columnsInfo[21].name;
            dataGridViewColumn9.Name = "dataGridViewColumn9";
            dataGridViewColumn9.ReadOnly = true;
            dataGridViewColumn9.Width = 50;
            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[16].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[17].name)
                    {
                        dataGridViewColumn5.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[18].name)
                    {
                        dataGridViewColumn6.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[19].name)
                    {
                        dataGridViewColumn7.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[20].name)
                    {
                        dataGridViewColumn8.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[21].name)
                    {
                        dataGridViewColumn9.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }

                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3
                ,dataGridViewColumn4,dataGridViewColumn5,dataGridViewColumn6,dataGridViewColumn7,dataGridViewColumn8
                ,dataGridViewColumn9
            });

        }

        public static void CreateColumns23(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[16].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            dataGridViewColumn4.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn5.HeaderText = columnsInfo[17].name;
            dataGridViewColumn5.Name = "dataGridViewColumn5";
            dataGridViewColumn5.ReadOnly = true;
            dataGridViewColumn5.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn6 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn6.HeaderText = columnsInfo[18].name;
            dataGridViewColumn6.Name = "dataGridViewColumn6";
            dataGridViewColumn6.ReadOnly = true;
            dataGridViewColumn6.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn7 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn7.HeaderText = columnsInfo[19].name;
            dataGridViewColumn7.Name = "dataGridViewColumn7";
            dataGridViewColumn7.ReadOnly = true;
            dataGridViewColumn7.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn8 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn8.HeaderText = columnsInfo[20].name;
            dataGridViewColumn8.Name = "dataGridViewColumn8";
            dataGridViewColumn8.ReadOnly = true;
            dataGridViewColumn8.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn9 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn9.HeaderText = columnsInfo[21].name;
            dataGridViewColumn9.Name = "dataGridViewColumn9";
            dataGridViewColumn9.ReadOnly = true;
            dataGridViewColumn9.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn10 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn10.HeaderText = columnsInfo[22].name;
            dataGridViewColumn10.Name = "dataGridViewColumn10";
            dataGridViewColumn10.ReadOnly = true;
            dataGridViewColumn10.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[16].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[17].name)
                    {
                        dataGridViewColumn5.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[18].name)
                    {
                        dataGridViewColumn6.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[19].name)
                    {
                        dataGridViewColumn7.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[20].name)
                    {
                        dataGridViewColumn8.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[21].name)
                    {
                        dataGridViewColumn9.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }

                    if (pInfo.Name == columnsInfo[22].name)
                    {
                        dataGridViewColumn10.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3
                ,dataGridViewColumn4,dataGridViewColumn5,dataGridViewColumn6,dataGridViewColumn7,dataGridViewColumn8
                ,dataGridViewColumn9,dataGridViewColumn10
            });

        }
        public static void CreateColumns24(List<PrintColumnsInfo> columnsInfo, DataGridView dataGridView, List<PrintColumnInfo> printCol)
        {

            dataGridView.Columns.Clear();
            DataGridViewTextBoxColumn dataGridViewColumn79 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn79.HeaderText = columnsInfo[0].name;
            dataGridViewColumn79.Name = "dataGridViewColumn79";
            dataGridViewColumn79.ReadOnly = true;

            dataGridViewColumn79.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn80 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn80.HeaderText = columnsInfo[1].name;
            dataGridViewColumn80.Name = "dataGridViewColumn80";
            dataGridViewColumn80.ReadOnly = true;
            dataGridViewColumn80.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn81 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn81.HeaderText = columnsInfo[2].name;
            dataGridViewColumn81.Name = "dataGridViewColumn81";
            dataGridViewColumn81.ReadOnly = true;
            dataGridViewColumn81.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn82 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn82.HeaderText = columnsInfo[3].name;
            dataGridViewColumn82.Name = "dataGridViewColumn82";
            dataGridViewColumn82.ReadOnly = true;
            dataGridViewColumn82.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn83 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn83.HeaderText = columnsInfo[4].name;
            dataGridViewColumn83.Name = "dataGridViewColumn83";
            dataGridViewColumn83.ReadOnly = true;
            dataGridViewColumn83.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn84 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn84.HeaderText = columnsInfo[5].name;
            dataGridViewColumn84.Name = "dataGridViewColumn84";
            dataGridViewColumn84.ReadOnly = true;
            dataGridViewColumn84.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn85 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn85.HeaderText = columnsInfo[6].name;
            dataGridViewColumn85.Name = "dataGridViewColumn85";
            dataGridViewColumn85.ReadOnly = true;
            dataGridViewColumn85.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn86 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn86.HeaderText = columnsInfo[7].name;
            dataGridViewColumn86.Name = "dataGridViewColumn86";
            dataGridViewColumn86.ReadOnly = true;
            dataGridViewColumn86.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn87 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn87.HeaderText = columnsInfo[8].name;
            dataGridViewColumn87.Name = "dataGridViewColumn87";
            dataGridViewColumn87.ReadOnly = true;
            dataGridViewColumn87.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn88 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn88.HeaderText = columnsInfo[9].name;
            dataGridViewColumn88.Name = "dataGridViewColumn88";
            dataGridViewColumn88.ReadOnly = true;
            dataGridViewColumn88.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn89 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn89.HeaderText = columnsInfo[10].name;
            dataGridViewColumn89.Name = "dataGridViewColumn89";
            dataGridViewColumn89.ReadOnly = true;
            dataGridViewColumn89.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn90 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn90.HeaderText = columnsInfo[11].name;
            dataGridViewColumn90.Name = "dataGridViewColumn90";
            dataGridViewColumn90.ReadOnly = true;
            dataGridViewColumn90.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn91 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn91.HeaderText = columnsInfo[12].name;
            dataGridViewColumn91.Name = "dataGridViewColumn91";
            dataGridViewColumn91.ReadOnly = true;
            dataGridViewColumn91.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn1 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn1.HeaderText = columnsInfo[13].name;
            dataGridViewColumn1.Name = "dataGridViewColumn1";
            dataGridViewColumn1.ReadOnly = true;
            dataGridViewColumn1.Width = 50;


            DataGridViewTextBoxColumn dataGridViewColumn2 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn2.HeaderText = columnsInfo[14].name;
            dataGridViewColumn2.Name = "dataGridViewColumn2";
            dataGridViewColumn2.ReadOnly = true;
            dataGridViewColumn2.Width = 50;

            DataGridViewTextBoxColumn dataGridViewColumn3 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn3.HeaderText = columnsInfo[15].name;
            dataGridViewColumn3.Name = "dataGridViewColumn3";
            dataGridViewColumn3.ReadOnly = true;
            dataGridViewColumn3.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn4 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn4.HeaderText = columnsInfo[16].name;
            dataGridViewColumn4.Name = "dataGridViewColumn4";
            dataGridViewColumn4.ReadOnly = true;
            dataGridViewColumn4.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn5 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn5.HeaderText = columnsInfo[17].name;
            dataGridViewColumn5.Name = "dataGridViewColumn5";
            dataGridViewColumn5.ReadOnly = true;
            dataGridViewColumn5.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn6 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn6.HeaderText = columnsInfo[18].name;
            dataGridViewColumn6.Name = "dataGridViewColumn6";
            dataGridViewColumn6.ReadOnly = true;
            dataGridViewColumn6.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn7 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn7.HeaderText = columnsInfo[19].name;
            dataGridViewColumn7.Name = "dataGridViewColumn7";
            dataGridViewColumn7.ReadOnly = true;
            dataGridViewColumn7.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn8 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn8.HeaderText = columnsInfo[20].name;
            dataGridViewColumn8.Name = "dataGridViewColumn8";
            dataGridViewColumn8.ReadOnly = true;
            dataGridViewColumn8.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn9 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn9.HeaderText = columnsInfo[21].name;
            dataGridViewColumn9.Name = "dataGridViewColumn9";
            dataGridViewColumn9.ReadOnly = true;
            dataGridViewColumn9.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn10 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn10.HeaderText = columnsInfo[22].name;
            dataGridViewColumn10.Name = "dataGridViewColumn10";
            dataGridViewColumn10.ReadOnly = true;
            dataGridViewColumn10.Width = 50;
            DataGridViewTextBoxColumn dataGridViewColumn11 = new DataGridViewTextBoxColumn();
            // this.dataGridViewTextBoxColumn1.DataPropertyName = columnsInfo[0].name;
            dataGridViewColumn11.HeaderText = columnsInfo[23].name;
            dataGridViewColumn11.Name = "dataGridViewColumn11";
            dataGridViewColumn11.ReadOnly = true;
            dataGridViewColumn11.Width = 50;

            if (printCol == null)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                foreach (PrintColumnInfo pInfo in printCol)
                {
                    if (pInfo.Name == columnsInfo[0].name)
                    {
                        dataGridViewColumn79.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[1].name)
                    {
                        dataGridViewColumn80.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }


                    if (pInfo.Name == columnsInfo[2].name)
                    {
                        dataGridViewColumn81.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[3].name)
                    {
                        dataGridViewColumn82.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[4].name)
                    {
                        dataGridViewColumn83.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[5].name)
                    {
                        dataGridViewColumn84.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[6].name)
                    {
                        dataGridViewColumn85.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[7].name)
                    {
                        dataGridViewColumn86.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[8].name)
                    {
                        dataGridViewColumn87.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[9].name)
                    {
                        dataGridViewColumn88.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[10].name)
                    {
                        dataGridViewColumn89.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[11].name)
                    {
                        dataGridViewColumn90.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[12].name)
                    {
                        dataGridViewColumn91.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[13].name)
                    {
                        dataGridViewColumn1.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[14].name)
                    {
                        dataGridViewColumn2.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[15].name)
                    {
                        dataGridViewColumn3.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[16].name)
                    {
                        dataGridViewColumn4.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[17].name)
                    {
                        dataGridViewColumn5.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[18].name)
                    {
                        dataGridViewColumn6.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[19].name)
                    {
                        dataGridViewColumn7.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[20].name)
                    {
                        dataGridViewColumn8.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                    if (pInfo.Name == columnsInfo[21].name)
                    {
                        dataGridViewColumn9.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }

                    if (pInfo.Name == columnsInfo[22].name)
                    {
                        dataGridViewColumn10.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }

                    if (pInfo.Name == columnsInfo[23].name)
                    {
                        dataGridViewColumn11.Width = Convert.ToInt32(dataGridView.Width * pInfo.Rate / 100);
                    }
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewColumn79,dataGridViewColumn80,dataGridViewColumn81,
                dataGridViewColumn82,dataGridViewColumn83,dataGridViewColumn84,
                dataGridViewColumn85,dataGridViewColumn86,dataGridViewColumn87,
                dataGridViewColumn88,dataGridViewColumn89,dataGridViewColumn90,
                dataGridViewColumn91,dataGridViewColumn1,dataGridViewColumn2,dataGridViewColumn3
                ,dataGridViewColumn4,dataGridViewColumn5,dataGridViewColumn6,dataGridViewColumn7,dataGridViewColumn8
                ,dataGridViewColumn9,dataGridViewColumn10,dataGridViewColumn11
            });

        }

    }
}
