using JGNet.Common;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.DBEntity;
using JGNet.Core.Dev.InteractEntity;
using JGNet.Core.InteractEntity;
using CJBasic;
using CJPlus.Rapid;
using CJPlus.Serialization;
using System;
using System.Collections.Generic;

using System.Text;


namespace JGNet.ForManage
{
    public class ServerProxy: Common.ServerProxy
    {
        public ServerProxy(IRapidPassiveEngine _engine) : base(_engine)
        {
        }

        /// <summary>
        /// 销售货物
        /// </summary>
        /// <param name="retailCostume"></param>
        /// <returns></returns>
        public InteractResult RetailCostume(RetailCostume retailCostume)
        {
            byte[] request = SerializeHelper.ResultToSerialize(retailCostume);
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.RetailCostume, request);

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取一个店铺信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Shop GetOneShop(string id)
        {
            byte[] request = SerializeHelper.ResultToSerialize(SerializeHelper.StringToByteArray(id));
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetOneShop, request);

            return CompactPropertySerializer.Default.Deserialize<Shop>(response, 0);
        }
         
        /// <summary>
        /// 获取所有店铺
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Shop> GetAllShop()
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetAllShop, null);

            return CompactPropertySerializer.Default.Deserialize<List<Shop>>(response, 0);
        }

        /// <summary>
        /// 获取该店铺所有开启的促销活动
        /// </summary>
        /// <param name="shopId"></param>
        /// <returns></returns>
        public List<SalesPromotion> GetOpenSalesPromotionList(string shopId)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetOpenSalesPromotionList, SerializeHelper.StringToByteArray(shopId));

            return CompactPropertySerializer.Default.Deserialize<List<SalesPromotion>>(response, 0);
        }

        /// <summary>
        /// 退货
        /// </summary>
        /// <param name="retailCostume"></param>
        /// <returns></returns>
        public InteractResult RefundCostume(RefundCostume refundCostume)
        {
            byte[] request = SerializeHelper.ResultToSerialize(refundCostume);
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.RefundCostume, request);

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取销售单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RetailCostume GetOneRetailCostume(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetOneRetailCostume, SerializeHelper.StringToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<RetailCostume>(response, 0);
        }


        /// <summary>
        /// 获取充值赠送规则
        /// </summary>
        /// <returns></returns>
        public RechargeDonateRule GetRechargeDonateRule(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetRechargeDonateRule, SerializeHelper.IntToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<RechargeDonateRule>(response, 0);
        }

        /// <summary>
        /// 获取该店铺所有的促销活动
        /// </summary>
        /// <param name="salesPromotionID"></param>
        /// <returns></returns>
        public SalesPromotion GetOneSalesPromotion(string salesPromotionID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetOneSalesPromotion, SerializeHelper.StringToByteArray(salesPromotionID));

            return CompactPropertySerializer.Default.Deserialize<SalesPromotion>(response, 0);
        }

        /// <summary>
        /// 补货申请
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult ReplenishCostume(ReplenishCostume para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.ReplenishCostume, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 自动补货
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<ReplenishDetail> AutoReplenishCostume(AutoReplenishCostumePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.AutoReplenishCostume, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<ReplenishDetail>>(response, 0);
        }

        /// <summary>
        /// 获取盘点单
        /// </summary>
        /// <param name="checkStoreOrderID"></param>
        /// <returns></returns>
        public CheckStoreOrder GetCheckStoreOrder(string checkStoreOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetCheckStoreOrder, SerializeHelper.StringToByteArray(checkStoreOrderID));

            return CompactPropertySerializer.Default.Deserialize<CheckStoreOrder>(response, 0);
        }

        /// <summary>
        /// 获取供应商信息
        /// </summary>
        /// <returns></returns>
        public List<Supplier> GetAllSupplier()
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetAllSupplier, null);

            return CompactPropertySerializer.Default.Deserialize<List<Supplier>>(response, 0);
        }

        /// <summary>
        /// 获取所有会员
        /// </summary>
        /// <returns></returns>
        public List<Member> GetAllMember()
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetAllMember, null);

            return CompactPropertySerializer.Default.Deserialize<List<Member>>(response, 0);
        }

        /// <summary>
        /// 获取所有导购员
        /// </summary>
        /// <returns></returns>
        public List<Guide> GetAllGuide()
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetAllGuide, null);

            return CompactPropertySerializer.Default.Deserialize<List<Guide>>(response, 0);
        }

        /// <summary>
        /// 根据单据编号查询差异单信息
        /// </summary>
        /// <param name="shopID"></param>
        /// <returns></returns>
        public DifferenceOrder GetDifferenceOrder4ID(string shopID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetDifferenceOrder4ID, SerializeHelper.StringToByteArray(shopID));

            return CompactPropertySerializer.Default.Deserialize<DifferenceOrder>(response, 0);
        }

        /// <summary>
        /// 根据来源单据获取入库单
        /// </summary>
        /// <param name="sourceOrderID"></param>
        /// <returns></returns>
        public InboundOrder GetInboundOrder4SourceOrderID(string sourceOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetInboundOrder4SourceOrderID, SerializeHelper.StringToByteArray(sourceOrderID));

            return CompactPropertySerializer.Default.Deserialize<InboundOrder>(response, 0);
        }

        /// <summary>
        /// 根据来源单据获取出库单
        /// </summary>
        /// <param name="sourceOrderID"></param>
        /// <returns></returns>
        public OutboundOrder GetOutboundOrder4SourceOrderID(string sourceOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetOutboundOrder4SourceOrderID, SerializeHelper.StringToByteArray(sourceOrderID));

            return CompactPropertySerializer.Default.Deserialize<OutboundOrder>(response, 0);
        }


        /// <summary>
        /// 获取提前多少天到今天范围内的销售单。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<RetailOrder> GetRetailOrderAdvance(RetailOrderAdvancePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetRetailOrderAdvance, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<RetailOrder>>(response, 0);
        }

        /// <summary>
        /// 打卡
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public SignResult Sign(SignRecord para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.Sign, SerializeHelper.ResultToSerialize(para));

            return (SignResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 是否已经打卡
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public int IsSign(SignRecord para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.IsSign, SerializeHelper.ResultToSerialize(para));

            return SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 库存信息是否有记录。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public int IsCostumeStoreExist(CheckCostumeStore para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.IsCostumeStoreExist, SerializeHelper.ResultToSerialize(para));

            return SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取会员有效的电子优惠券列表
        /// </summary>
        /// <param name="memberID"></param>
        /// <returns></returns>
        public List<GiftTicket> GetValidGiftTickets(string memberID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetValidGiftTickets, SerializeHelper.StringToByteArray(memberID));

            return CompactPropertySerializer.Default.Deserialize<List<GiftTicket>>(response, 0);
        }

        /// <summary>
        /// 获取销售单id
        /// </summary>
        /// <returns></returns>
        public string GetRetailOrderID()
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetRetailOrderID, null);

            return SerializeHelper.ByteArrayToString(response);
        }

        /// <summary>
        /// 获取销售明细中的电子优惠券。
        /// </summary>
        /// <param name="giftTickets"></param>
        /// <returns></returns>
        public List<GiftTicket> GetGiftTicket4RetailDetail(string giftTickets)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetGiftTicket4RetailDetail, SerializeHelper.StringToByteArray(giftTickets));

            return CompactPropertySerializer.Default.Deserialize<List<GiftTicket>>(response, 0);
        }

        /// <summary>
        /// 检查服装是否有效。
        /// </summary>
        /// <param name="costumeIds"></param>
        /// <returns></returns>
        public InteractResult IsCostumeValid(List<string> costumeIds)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.IsCostumeValid, SerializeHelper.ResultToSerialize(costumeIds));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 补货挂单
        /// </summary>
        /// <param name="replenishCostume"></param>
        /// <returns></returns>
        public InteractResult HangUpReplenish(ReplenishCostume replenishCostume)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.HangUpReplenish, SerializeHelper.ResultToSerialize(replenishCostume));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取挂单状态的补货单。
        /// </summary>
        /// <param name="shopId"></param>
        /// <param name="guideID"></param>
        /// <returns></returns>
        public List<ReplenishOrder> GetHangUpReplenishOrders(string shopId, string guideID)
        {
            Parameter<string, string> para = new Parameter<string, string>(shopId, guideID);
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.GetHangUpReplenishOrders, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<ReplenishOrder>>(response, 0);
        }

        /// <summary>
        /// 删除挂单状态的补货单
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public InteractResult DeleteHangUpReplenishOrder(string orderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(PosInformationTypes.DeleteHangUpReplenishOrder, SerializeHelper.StringToByteArray(orderID));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
        /// <summary>
        /// 补全缺失的基础数据
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult CheckBaseData(List<CheckBaseDataPara> para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.CheckBaseData, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取店铺收款汇总
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public RetailSummary GetRetailSummary(GetRetailSummaryPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetRetailSummary, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<RetailSummary>(response, 0);
        }

        /// <summary>
        /// 获取售价管理信息。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<CostumePrice> GetShopCostumePrices(GetCostumePricesPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetShopCostumePrices, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<CostumePrice>>(response, 0);
        }

        /// <summary>
        /// 修改店铺库存吊牌价
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateShopCostumePrice(UpdateShopCostumePricePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateShopCostumePrice, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取采购汇总
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public PurchaseSummary GetPurchaseSummary(GetPurchaseSummaryPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPurchaseSummary, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<PurchaseSummary>(response, 0);
        }
         

        /// <summary>
        /// 自动生成款号id
        /// </summary>
        /// <returns></returns>
        public InteractResult GetAutoCostumeID()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetAutoCostumeID, null);

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
         

        /// <summary>
        /// 报损冲单
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public InteractResult CancelScrap(string orderID, string userId)
        {
            Parameter<string, string> para = new Parameter<string, string>(orderID, userId);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.CancelScrap, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }


        /// <summary>
        /// 采购进货冲单
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public InteractResult CancelPurchase(string orderID, string userId)
        {
            Parameter<string, string> para = new Parameter<string, string>(orderID, userId);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.CancelPurchase, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
         

        /// <summary>
        /// 采购退货冲单
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public InteractResult CancelReturn(string orderID, string userId)
        {
            Parameter<string, string> para = new Parameter<string, string>(orderID, userId);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.CancelReturn, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发发货冲单
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public InteractResult CancelPfDelivery(string orderID, string userId)
        {
            Parameter<string, string> para = new Parameter<string, string>(orderID, userId);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.CancelPfDelivery, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发退货冲单
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public InteractResult CancelPfReturn(string orderID, string userId)
        {
            Parameter<string, string> para = new Parameter<string, string>(orderID, userId);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.CancelPfReturn, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 禁用服装
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InteractResult DisableCostume(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DisableCostume, SerializeHelper.StringToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 新增充值规则
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertResultAndAutoID InsertRechargeDonateRule(RechargeDonateRule para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertRechargeDonateRule, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InsertResultAndAutoID>(response, 0);
        }

        /// <summary>
        /// 修改充值规则
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateRechargeDonateRuleResult UpdateRechargeDonateRule(RechargeDonateRule para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateRechargeDonateRule, SerializeHelper.ResultToSerialize(para));

            return (UpdateRechargeDonateRuleResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 新增促销活动
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertResult InsertSalesPromotion(SalesPromotion para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertSalesPromotion, SerializeHelper.ResultToSerialize(para));

            return (InsertResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改促销活动
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateSalesPromotion(SalesPromotion para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateSalesPromotion, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }
        
        /// <summary>
        /// 修改配置
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateParameterConfig(ParameterConfig para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateParameterConfig, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }
        
        /// <summary>
        /// 新增导购员
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult InsertGuide(Guide para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertGuide, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
 
        /// <summary>
        /// 修改导购员
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateGuide(Guide para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateGuide, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
        
        /// <summary>
        /// 修改供应商
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateSupplier(Supplier para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateSupplier, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

         
        /// <summary>
        /// 新增服装信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertCostumeResult InsertCostume(Costume para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertCostume, SerializeHelper.ResultToSerialize(para));

            return (InsertCostumeResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改服装信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateCostume(Costume para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateCostume, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除供应商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InteractResult DeleteSupplier(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteSupplier, SerializeHelper.StringToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除导购员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteGuide(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteGuide, SerializeHelper.StringToByteArray(id));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 逻辑删除促销活动
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteSalesPromotion(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteSalesPromotion, SerializeHelper.StringToByteArray(id));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 删除充值赠送规则
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteRechargeDonateRule(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteRechargeDonateRule, SerializeHelper.IntToByteArray(id));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取店铺列表
        /// </summary>
        /// <returns></returns>
        public List<Shop> GetShopList()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetShopList, null);

            return CompactPropertySerializer.Default.Deserialize<List<Shop>>(response, 0);
        }

        /// <summary>
        /// 根据id或者名称查询供应商信息
        /// </summary>
        /// <param name="idOrName"></param>
        /// <returns></returns>
        public List<Supplier> GetSupplierList4IDOrName(string idOrName)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetSupplierList4IDOrName, SerializeHelper.StringToByteArray(idOrName));

            return CompactPropertySerializer.Default.Deserialize<List<Supplier>>(response, 0);
        }

        /// <summary>
        /// 修改店铺的充值赠送规则
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateShopRechargeRuleID(List<UpdateShopRechargeRuleIDPara> para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateShopRechargeRuleID, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 补货发货
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult ReplenishOutbound(Outbound para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.ReplenishOutbound, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 新增颜色
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult InsertCostumeColor(CostumeColor para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertCostumeColor, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改颜色
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateCostumeColor(CostumeColor para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateCostumeColor, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
        
        /// <summary>
        /// 删除颜色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InteractResult DeleteCostumeColor(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteCostumeColor, SerializeHelper.StringToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
         
        /// <summary>
        /// 新增品牌
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult<int> InsertBrand(Brand para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertBrand, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult<int>>(response, 0);
        }

        /// <summary>
        /// 修改品牌
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateBrand(Brand para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateBrand, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除品牌
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InteractResult DeleteBrand(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteBrand, SerializeHelper.IntToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 新增服装分类
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult InsertBigCostumeClass(InsertCostumeClassPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertBigCostumeClass, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改服装大类。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateBigCostumeClass(UpdateBigClassPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateBigCostumeClass, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除服装分类
        /// </summary>
        /// <param name="bigClass"></param>
        /// <returns></returns>
        public InteractResult DeleteBigCostumeClass(int bigClassID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteBigCostumeClass, SerializeHelper.StringToByteArray(bigClassID.ToString()));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 促销活动已有商品参与
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IsSalesPromotionUseResult IsSalesPromotionUse(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.IsSalesPromotionUse, SerializeHelper.StringToByteArray(id));

            return (IsSalesPromotionUseResult)SerializeHelper.ByteArrayToInt(response);
        }
        
        /// <summary>
        /// 删除服装
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InteractResult DeleteCostume(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteCostume, SerializeHelper.StringToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 采购进货
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult PurchaseCostume(PurchaseCostume para)
        {
            byte[] request = SerializeHelper.ResultToSerialize(para);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.PurchaseCostume, request);

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 根据补货申请单信息，返回对应的库存信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<CostumeStore> GetCostumeStore4ReplenishInfo(CostumeStore4ReplenishInfoPara para)
        {
            byte[] request = SerializeHelper.ResultToSerialize(para);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetCostumeStore4ReplenishInfo, request);

            return CompactPropertySerializer.Default.Deserialize<List<CostumeStore>>(response, 0);
        }

        /// <summary>
        /// 采购退货（给供应商）
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult ReturnCostume(ReturnCostume para)
        {
            byte[] request = SerializeHelper.ResultToSerialize(para);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.ReturnCostume, request);

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取采购进货分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public PurchaseCostumePage GetPurchaseCostumePage(PurchaseCostumePagePara para)
        {
            byte[] request = SerializeHelper.ResultToSerialize(para);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPurchaseCostumePage, request);

            return CompactPropertySerializer.Default.Deserialize<PurchaseCostumePage>(response, 0);
        }

        /// <summary>
        /// 新增店铺
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        public InsertShopGetAutoCode InsertShop(Shop shop)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertShop, SerializeHelper.ResultToSerialize(shop));

            return CompactPropertySerializer.Default.Deserialize<InsertShopGetAutoCode>(response, 0);
        }

        /// <summary>
        /// 修改店铺
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        public UpdateShopResult UpdateShop(Shop shop)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateShop, SerializeHelper.ResultToSerialize(shop));

            return (UpdateShopResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 新增后台管理用户
        /// </summary>
        /// <param name="adminUser"></param>
        /// <returns></returns>
        public InteractResult InsertAdminUser(AdminUser adminUser)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertAdminUser, SerializeHelper.ResultToSerialize(adminUser));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改后台管理用户
        /// </summary>
        /// <param name="adminUser"></param>
        /// <returns></returns>
        public InteractResult UpdateAdminUser(AdminUser adminUser)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateAdminUser, SerializeHelper.ResultToSerialize(adminUser));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取总仓库存信息（分页），根据款号id，模糊查询
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public CostumeStore4GeneralStorePage GetCostumeStore4GeneralStorePage(CostumeStore4GeneralStorePagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetCostumeStore4GeneralStorePage, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<CostumeStore4GeneralStorePage>(response, 0);
        }

        /// <summary>
        /// 获取单商品的库存信息（所有店铺，精确查询）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CostumeStore> GetOneCostumeStoreInAllShop(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetOneCostumeStoreInAllShop, SerializeHelper.StringToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<List<CostumeStore>>(response, 0);
        }

        /// <summary>
        /// 获取采购退货分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public ReturnOrderPage GetReturnOrderPage(ReturnOrderPagePara para)
        {
            byte[] request = SerializeHelper.ResultToSerialize(para);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetReturnOrderPage, request);

            return CompactPropertySerializer.Default.Deserialize<ReturnOrderPage>(response, 0);
        }

        /// <summary>
        /// 删除后台管理用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteAdminUserResult DeleteAdminUser(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteAdminUser, SerializeHelper.StringToByteArray(id));

            return (DeleteAdminUserResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 今天之前的日报表是否手动结存
        /// </summary>
        /// <returns></returns>
        public IsDayReportManualConfirmResult IsLastDayReportManualConfirm(string shopID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.IsLastDayReportManualConfirm, SerializeHelper.StringToByteArray(shopID));

            return (IsDayReportManualConfirmResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取今天之前未手动结存的日报。
        /// </summary>
        /// <param name="shopID"></param>
        /// <returns></returns>
        public DayReport GetLastDayReport(string shopID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetLastDayReport, SerializeHelper.StringToByteArray(shopID));

            return CompactPropertySerializer.Default.Deserialize<DayReport>(response, 0);
        }
        
        /// <summary>
        /// 报损
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult Scrap(ScrapCostume para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.Scrap, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取报损单明细。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ScrapDetail> GetScrapDetails(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetScrapDetails, SerializeHelper.StringToByteArray(id));

            return CompactPropertySerializer.Default.Deserialize<List<ScrapDetail>>(response, 0);
        }

        /// <summary>
        /// 在途库存
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<TransitCostumeStore> TransitCostumeStore(TransitCostumeStorePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.TransitCostumeStore, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<TransitCostumeStore>>(response, 0);
        }

        /// <summary>
        /// 检查某一款某一颜色库存是否为0
        /// </summary>
        /// <param name="costumeID"></param>
        /// <param name="colorName"></param>
        /// <returns></returns>
        public InteractResult IsCostumeStoreCountZero(string costumeID, string colorName)
        {
            Parameter<string, string> para = new Parameter<string, string>(costumeID, colorName);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.IsCostumeStoreCountZero, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 禁用店铺
        /// </summary>
        /// <param name="shopId"></param>
        /// <returns></returns>
        public InteractResult DisableShop(string shopId)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DisableShop, SerializeHelper.StringToByteArray(shopId));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改批发客户往来账
        /// </summary>
        /// <param name="pfAccountRecord"></param>
        /// <returns></returns>
        public InteractResult UpdatePfAccountRecord(UpdatePfAccountRecordPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdatePfAccountRecord, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除批发客户往来账
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InteractResult DeletePfAccountRecord(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeletePfAccountRecord, SerializeHelper.StringToByteArray(id.ToString()));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改供应商往来账
        /// </summary>
        /// <param name="pfAccountRecord"></param>
        /// <returns></returns>
        public InteractResult UpdateSupplierAccountRecord(UpdateSupplierAccountRecordPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateSupplierAccountRecord, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除供应商往来账
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InteractResult DeleteSupplierAccountRecord(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteSupplierAccountRecord, SerializeHelper.StringToByteArray(id.ToString()));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 根据品牌 名称/编号 模糊查询。
        /// </summary>
        /// <param name="idOrName"></param>
        /// <returns></returns>
        public List<Brand> GetBrands4IdOrName(string idOrName)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetBrands4IdOrName, SerializeHelper.StringToByteArray(idOrName));

            return CompactPropertySerializer.Default.Deserialize<List<Brand>>(response, 0);
        }

        /// <summary>
        /// 根据色号/名称模糊查询颜色
        /// </summary>
        /// <param name="idOrName"></param>
        /// <returns></returns>
        public List<CostumeColor> GetCostumeColor4IDOrName(string idOrName)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetCostumeColor4IDOrName, SerializeHelper.StringToByteArray(idOrName));

            return CompactPropertySerializer.Default.Deserialize<List<CostumeColor>>(response, 0);
        }

        /// <summary>
        /// 新增小类
        /// </summary>
        /// <param name="bigClass"></param>
        /// <param name="smallClass"></param>
        /// <param name="orderNo"></param>
        /// <returns></returns>
        public InteractResult InsertSmallClass(InsertSmallClassPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertSmallClass, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改小类
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateSmallClass(UpdateSmallClassPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateSmallClass, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 新增次小类
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult InsertSubSmallClass(InsertSubSmallClassPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertSubSmallClass, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改次小类
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateSubSmallClass(UpdateSubSmallClassPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateSubSmallClass, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除次小类
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult DeleteSubSmallClass(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteSubSmallClass, SerializeHelper.StringToByteArray(id.ToString()));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除季节
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public InteractResult DeleteSeason(string season)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteSeason, SerializeHelper.StringToByteArray(season));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改季节
        /// </summary>
        /// <param name="oldSeason"></param>
        /// <param name="newSeason"></param>
        /// <returns></returns>
        public InteractResult UpdateSeason(string oldSeason, string newSeason)
        {
            Parameter<string, string> para = new Parameter<string, string>(oldSeason, newSeason);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateSeason, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 检查款号尺码库存是否为0
        /// </summary>
        /// <param name="costumeID"></param>
        /// <param name="sizeName"></param>
        /// <returns></returns>
        public InteractResult CheckCostumeSize(string costumeID, string sizeGroupName, List<string> sizeNames)
        {
            Parameter<string, string, List<string>> para = new Parameter<string, string, List<string>>(costumeID, sizeGroupName, sizeNames);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.CheckCostumeSize, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取某一月所有店铺的营业月报。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<MonthBenefitReport> GetAllShopMonthBenefitReport4ReportMonth(GetReportsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetAllShopMonthBenefitReport4ReportMonth, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<MonthBenefitReport>>(response, 0);
        }

        /// <summary>
        /// 获取畅滞排行榜各店铺信息。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<SalesQuantityRanking> GetSalesQuantityRankings(SalesQuantityRankingsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetSalesQuantityRankings, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<SalesQuantityRanking>>(response, 0);
        }

        /// <summary>
        /// 新增月销售任务。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertMonthTaskResult InsertMonthTask(MonthTask para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertMonthTask, SerializeHelper.ResultToSerialize(para));

            return (InsertMonthTaskResult)SerializeHelper.ByteArrayToInt(response);
        }


        /// <summary>
        /// 新增供应商往来账
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult InsertSupplierAccountRecord(SupplierAccountRecord para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertSupplierAccountRecord, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 上传服装图片
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public void UploadCostumePhoto(UploadCostumePhotoPara para)
        {
            this.engine.CustomizeOutter.SendBlob(null, ManageInformationTypes.UploadCostumePhoto, SerializeHelper.ResultToSerialize(para), 2 * 1024 * 1024);
        }

        /// <summary>
        /// 获取供应商往来账分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public SupplierAccountRecordPage GetSupplierAccountRecordPage(SupplierAccountRecordPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetSupplierAccountRecordPage, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<SupplierAccountRecordPage>(response, 0);
        }

        /// <summary>
        /// 获取 供应商往来账 详情
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public SupplierAccountRecordDetailInfo GetSupplierAccountRecordDetailInfo(string para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetSupplierAccountRecordDetailInfo, SerializeHelper.StringToByteArray(para));
            return CompactPropertySerializer.Default.Deserialize<SupplierAccountRecordDetailInfo>(response, 0);
        }

        /// <summary>
        /// 获取 运营信息
        /// </summary>
        /// <returns></returns>
        public OperationInfo GetOperationInfo()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetOperationInfo, null);
            return CompactPropertySerializer.Default.Deserialize<OperationInfo>(response, 0);
        }
        
        /// <summary>
        /// 将图片上传到腾讯云。
        /// </summary>
        /// <param name="photoData"></param>
        public void UploadPhotoToCos(PhotoData photoData)
        {
            this.engine.CustomizeOutter.SendBlob(null, ManageInformationTypes.UploadPhotoToCos, SerializeHelper.ResultToSerialize(photoData), 2 * 1024 * 1024);
        }

        /// <summary>
        /// 将腾讯云的图片删除
        /// </summary>
        /// <param name="photoName"></param>
        /// <returns></returns>
        public DeleteResult DeletePhotoToCos(string photoName)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeletePhotoToCos, SerializeHelper.StringToByteArray(photoName));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改图片显示的顺利
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateDisplayIndexs(List<UpdateDisplayIndex> para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateDisplayIndexs, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 将线上商城的宣传海报图片上传到腾讯云
        /// </summary>
        /// <param name="photoData"></param>
        public void UploadPosterImageToCos(PosterImage posterImage)
        {
            this.engine.CustomizeOutter.SendBlob(null, ManageInformationTypes.UploadPosterImageToCos, SerializeHelper.ResultToSerialize(posterImage), 2 * 1024 * 1024);
        }

        /// <summary>
        /// 将线上商城的宣传海报图片从腾讯云删除
        /// </summary>
        /// <param name="photoName"></param>
        /// <returns></returns>
        public DeleteResult DeletePosterImageToCos(DeletePosterImagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeletePosterImageToCos, SerializeHelper.ResultToSerialize(para));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 新增 电子优惠券类别
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertResult InsertGiftTicketTemplate(GiftTicketTemplate giftTicketTemplate)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertGiftTicketTemplate, SerializeHelper.ResultToSerialize(giftTicketTemplate));

            return (InsertResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改 电子优惠券类别
        /// </summary>
        /// <param name="giftTicketTemplate"></param>
        /// <returns></returns>
        public UpdateResult UpdateGiftTicketTemplate(GiftTicketTemplate giftTicketTemplate)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateGiftTicketTemplate, SerializeHelper.ResultToSerialize(giftTicketTemplate));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 删除 电子优惠券类别
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteGiftTicketTemplate(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteGiftTicketTemplate, SerializeHelper.IntToByteArray(id));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }


        /// <summary> 
        /// 设置服装使用电子优惠券情况
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public UpdateResult UpdateCostumeGiftTicket(CostumeGiftTicketInfo info)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateCostumeGiftTicket, SerializeHelper.ResultToSerialize(info));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }
        
        /// <summary>
        /// 获取 电子优惠券类别分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public GiftTicketTemplatePage GetGiftTicketTemplatePage(GiftTicketTemplatePagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetGiftTicketTemplatePage, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<GiftTicketTemplatePage>(response, 0);
        }

        /// <summary>
        /// 获取 进销存日报 分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<InventoryDayReport> GetInventoryDayReports(InventoryDayReportsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetInventoryDayReports, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<InventoryDayReport>>(response, 0);
        }

        /// <summary>
        /// 获取 商品价格区间简报
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult<List<PriceRangeReport>> GetPriceRangeReports(GetPriceRangeReportsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPriceRangeReports, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InteractResult<List<PriceRangeReport>>>(response, 0);
        }

        /// <summary>
        /// 获取 各店铺商品价格区间简报
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<PriceRangeReport> GetShopPriceRangeReport(GetShopPriceRangeReportPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetShopPriceRangeReport, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<PriceRangeReport>>(response, 0);
        }

        /// <summary>
        /// 获取 导购端回访会员功能的参数设置。
        /// </summary>
        /// <returns></returns>
        internal GuideReturnVisitPara GetGuideReturnVisitPara()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetGuideReturnVisitPara, null);
            return CompactPropertySerializer.Default.Deserialize<GuideReturnVisitPara>(response, 0);
        }

        /// <summary>
        /// 修改 导购端回访会员功能的参数设置。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateGuideReturnVisitPara(GuideReturnVisitPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateGuideReturnVisitPara, SerializeHelper.ResultToSerialize(para));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }
        
        /// <summary>
        /// 获取 库存分析。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<CostumeStoreAnalysisData> GetCostumeStoreAnalysis(GetCostumeStoreAnalysisPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetCostumeStoreAnalysis, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<List<CostumeStoreAnalysisData>>(response, 0);
        }

        /// <summary>
        /// 修改服装分类序号
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateCostumeClassOrderNo(List<CostumeClassOrderNo> para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateCostumeClassOrderNo, SerializeHelper.ResultToSerialize(para));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 根据来源单据编号获取供应商往来账详情信息
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public List<BoundDetail> GetDetail4SupplierAccountRecord(string orderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetDetail4SupplierAccountRecord, SerializeHelper.StringToByteArray(orderID));
            return CompactPropertySerializer.Default.Deserialize<List<BoundDetail>>(response, 0);
        }

        /// <summary>
        /// 判断一款衣服库存是否为0
        /// </summary>
        /// <param name="costumeID"></param>
        /// <returns></returns>
        public WebResponseObj<bool> IsCostumeStoreZero(string costumeID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.IsCostumeStoreZero, SerializeHelper.StringToByteArray(costumeID));
            return CompactPropertySerializer.Default.Deserialize<WebResponseObj<bool>>(response, 0);
        }

        /// <summary>
        /// 修改服装是否有效
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateCostumeValid(UpdateCostumeValidPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateCostumeValid, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 期初库存录入
        /// </summary>
        /// <param name="costumeStores"></param>
        /// <returns></returns>
        public InteractResult InsertCostumeStores(CreateCostumeStore createCostumeStore)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertCostumeStores, SerializeHelper.ResultToSerialize(createCostumeStore));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取库存信息
        /// </summary>
        /// <returns></returns>
        public CostumeStoreInfoSum GetCostumeStores(string shopID, string costumeId, int brandID)
        {
            Parameter<string, string, int> para = new Parameter<string, string, int>(shopID, costumeId, brandID);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetCostumeStores, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<CostumeStoreInfoSum>(response, 0);
        }

        /// <summary>
        /// 隐藏起初建仓功能
        /// </summary>
        /// <returns></returns>
        public InteractResult HideCreateStore()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.HideCreateStore, null);
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 删除某个大类下的指定小类
        /// </summary>
        /// <returns></returns>
        public InteractResult DeleteSmallClass(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteSmallClass, SerializeHelper.StringToByteArray(id.ToString()));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
        
        /// <summary>
        /// 批发客户充值。
        /// </summary>
        /// <param name="pfCustomerRechargeRecord"></param>
        /// <returns></returns>
        public InteractResult InsertPfCustomerRechargeRecord(PfCustomerRechargeRecord pfCustomerRechargeRecord)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertPfCustomerRechargeRecord, SerializeHelper.ResultToSerialize(pfCustomerRechargeRecord));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发发货
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public InteractResult PfDelivery(PfInfo info)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.PfDelivery, SerializeHelper.ResultToSerialize(info));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发退货
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public InteractResult PfReturn(PfInfo info)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.PfReturn, SerializeHelper.ResultToSerialize(info));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取 批发客户库存分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public PfCustomerStorePage GetPfCustomerStorePage(GetPfCustomerStorePagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfCustomerStorePage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<PfCustomerStorePage>(response, 0);
        }

        /// <summary>
        /// 批发客户销售
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public InteractResult PfCustomerRetail(PfCustomerRetailInfo info)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.PfCustomerRetail, SerializeHelper.ResultToSerialize(info));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发客户销售单分页查询
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public CustomerRetailPage GetCustomerRetailPage(GetCustomerRetailPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetCustomerRetailPage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<CustomerRetailPage>(response, 0);
        }

        /// <summary>
        /// 获取批发客户销售单明细
        /// </summary>
        /// <param name="pfCustomerRetailOrderID"></param>
        /// <returns></returns>
        public List<PfCustomerRetailDetail> GetPfCustomerRetailDetails(string pfCustomerRetailOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfCustomerRetailDetails, SerializeHelper.StringToByteArray(pfCustomerRetailOrderID));
            return CompactPropertySerializer.Default.Deserialize<List<PfCustomerRetailDetail>>(response, 0);
        }

        /// <summary>
        /// 修改批发客户销售
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public InteractResult UpdatePfCustomerRetail(PfCustomerRetailInfo info)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdatePfCustomerRetail, SerializeHelper.ResultToSerialize(info));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
        
        /// <summary>
        /// 批发客户期初库存录入
        /// </summary>
        /// <param name="pfCustomerStores"></param>
        /// <returns></returns>
        public InteractResult InsertPfCostumeStores(CreatePfCostumeStore createPfCostumeStore)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertPfCostumeStores, SerializeHelper.ResultToSerialize(createPfCostumeStore));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取批发客户期初库存信息
        /// </summary>
        /// <returns></returns>
        public List<PfCustomerStore> GetPfCostumeStores(string pfCustomerID, string costumeID, int brandID)
        {
            Parameter<string, string, int> para = new Parameter<string, string, int>(pfCustomerID, costumeID, brandID);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfCostumeStores, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<List<PfCustomerStore>>(response, 0);
        }

        /// <summary>
        /// 批发客户往来账记账
        /// </summary>
        /// <param name="pfAccountRecord"></param>
        /// <returns></returns>
        public InteractResult InsertPfAccountRecord(PfAccountRecord pfAccountRecord)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertPfAccountRecord, SerializeHelper.ResultToSerialize(pfAccountRecord));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取批发客户库存信息
        /// </summary>
        /// <param name="pfCustomerID"></param>
        /// <returns></returns>
        public PfCostumeStoreInfo GetPfCostumeStoreInfo(string pfCustomerID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfCostumeStoreInfo, SerializeHelper.StringToByteArray(pfCustomerID));
            return CompactPropertySerializer.Default.Deserialize<PfCostumeStoreInfo>(response, 0);
        }

        /// <summary>
        /// 获取客户往来账明细分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public PfAccountRecordPage GetPfAccountRecordPage(GetPfAccountRecordPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfAccountRecordPage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<PfAccountRecordPage>(response, 0);
        }

        /// <summary>
        /// 获取服装颜色id
        /// </summary>
        /// <returns></returns>
        public InteractResult GetCostumeColorId()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetCostumeColorId, null);
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }


        /// <summary>
        /// 获取导购员id
        /// </summary>
        /// <returns></returns>
        public InteractResult GetGuideId()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetGuideId, null);
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取批发客户余额变化分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public PfCustomerBalanceRecordPage GetPfCustomerBalanceRecordPage(GetPfCustomerBalanceRecordPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfCustomerBalanceRecordPage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<PfCustomerBalanceRecordPage>(response, 0);
        }
        
        /// <summary>
        /// 获取客户往来账明细（发货，退货，线上订单付款）
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public List<PfOrderDetail> GetPfAccountRecordDetails(string orderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfAccountRecordDetails, SerializeHelper.StringToByteArray(orderID));
            return CompactPropertySerializer.Default.Deserialize<List<PfOrderDetail>>(response, 0);
        }

        /// <summary>
        /// 获取批发客户id。
        /// </summary>
        /// <returns></returns>
        public InteractResult GetPfCustomerId()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfCustomerId, null);
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取批发客户库存信息
        /// </summary>
        /// <param name="costumeID"></param>
        /// <returns></returns>
        public List<CostumeItem> GetPfCustomerStores(string pfCustomerID, string costumeID)
        {
            Parameter<string, string> para = new Parameter<string, string>(pfCustomerID, costumeID);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetPfCustomerStores, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<List<CostumeItem>>(response, 0);
        }

        /// <summary>
        /// 删除批发客户销售单
        /// </summary>
        /// <param name="pfOrderId"></param>
        /// <returns></returns>
        public InteractResult DeletePfCustomerRetailOrder(string pfCustomerRetailOrderId)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeletePfCustomerRetailOrder, SerializeHelper.StringToByteArray(pfCustomerRetailOrderId));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改展示的尺码
        /// </summary>
        /// <param name="showSizeName"></param>
        /// <returns></returns>
        public InteractResult UpdateShowSizeName(List<string> showSizeNames)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateShowSizeName, SerializeHelper.ResultToSerialize(showSizeNames));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取批发客户商品批发价格
        /// </summary>
        /// <param name="pfCustomerId"></param>
        /// <param name="costumeID"></param>
        /// <returns></returns>
        public WebResponseObj<decimal> GetCostumePfPrice(string pfCustomerId, string costumeID)
        {
            Parameter<string, string> para = new Parameter<string, string>(pfCustomerId, costumeID);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetCostumePfPrice, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<WebResponseObj<decimal>>(response, 0);
        }

        /// <summary>
        /// 批发发货挂单
        /// </summary>
        /// <param name="pfInfo"></param>
        /// <returns></returns>
        public InteractResult HangUpPfDelivery(PfInfo pfInfo)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.HangUpPfDelivery, SerializeHelper.ResultToSerialize(pfInfo));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发退货挂单
        /// </summary>
        /// <param name="pfInfo"></param>
        /// <returns></returns>
        public InteractResult HangUpPfReturn(PfInfo pfInfo)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.HangUpPfReturn, SerializeHelper.ResultToSerialize(pfInfo));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发退货挂单
        /// </summary>
        /// <param name="pfInfo"></param>
        /// <returns></returns>
        public InteractResult HangUpPurchase(PurchaseCostume purchaseCostume)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.HangUpPurchase, SerializeHelper.ResultToSerialize(purchaseCostume));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发退货挂单
        /// </summary>
        /// <param name="pfInfo"></param>
        /// <returns></returns>
        public InteractResult HangUpReturn(ReturnCostume returnCostume)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.HangUpReturn, SerializeHelper.ResultToSerialize(returnCostume));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取挂单的采购单
        /// </summary>
        /// <returns></returns>
        public List<PurchaseOrder> GetHangUpPurchases(GetHangUpPurchasesPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetHangUpPurchases, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<List<PurchaseOrder>>(response, 0);
        }

        /// <summary>
        /// 删除挂单的采购单
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public InteractResult DeleteHangUpPurchase(string orderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteHangUpPurchase, SerializeHelper.StringToByteArray(orderID));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取挂单的批发单
        /// </summary>
        /// <returns></returns>
        public List<PfOrder> GetHangUpPfs(GetHangUpPfsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetHangUpPfs, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<List<PfOrder>>(response, 0);
        }

        /// <summary>
        /// 删除挂单的批发单
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public InteractResult DeleteHangUpPf(string orderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteHangUpPf, SerializeHelper.StringToByteArray(orderID));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取佣金抽成比例
        /// </summary>
        /// <returns></returns>
        public WebResponseObj<int> GetCommissionRatio()
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.GetCommissionRatio, null);
            return CompactPropertySerializer.Default.Deserialize<WebResponseObj<int>>(response, 0);
        }

        /// <summary>
        /// 修改佣金抽成比例
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InteractResult UpdateCommissionRatio(int value)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.UpdateCommissionRatio, SerializeHelper.IntToByteArray(value));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取分销人员分页信息
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DistributorPage GetDistributorPage(GetDistributorPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.GetDistributorPage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<DistributorPage>(response, 0);
        }

        /// <summary>
        /// 新增分销人员
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public InteractResult InsertDistributor(Distributor value)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.InsertDistributor, SerializeHelper.ResultToSerialize(value));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取线下客户
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public PfCustomerPage GetPfCustomerPage4Distributor(GetPfCustomerPage4DistributorPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.GetPfCustomerPage4Distributor, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<PfCustomerPage>(response, 0);
        }

        /// <summary>
        /// 修改分销人员信息
        /// </summary>
        /// <param name="distributorId"></param>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public UpdateResult UpdateDistributor(string distributorId, string name, string pwd)
        {
            Parameter<string, string, string> para = new Parameter<string, string, string>(distributorId, name, pwd);
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.UpdateDistributor, SerializeHelper.ResultToSerialize(para));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 根据 客户编号/名称 模糊查询客户
        /// </summary>
        /// <param name="idOrName"></param>
        /// <returns></returns>
        public List<Distributor> GetPfCustomersLike(string idOrName)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.GetPfCustomersLike, SerializeHelper.StringToByteArray(idOrName));
            return CompactPropertySerializer.Default.Deserialize<List<Distributor>>(response, 0);
        }

        /// <summary>
        /// 录入回款金额
        /// </summary>
        /// <param name="idOrName"></param>
        /// <returns></returns>
        public InsertResult InsertPfAccountRecord4Fx(PfAccountRecord pfAccountRecord)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.InsertPfAccountRecord4Fx, SerializeHelper.ResultToSerialize(pfAccountRecord));
            return (InsertResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取 分销人员提款申请记录 分页信息。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public DistributorWithdrawRecordPage GetDistributorWithdrawRecordPage(GetDistributorWithdrawRecordPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.GetDistributorWithdrawRecordPage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<DistributorWithdrawRecordPage>(response, 0);
        }

        /// <summary>
        /// 提现管理付款
        /// </summary>
        /// <param name="distributorWithdrawRecordId"></param>
        /// <returns></returns>
        public InteractResult PayDistributorWithdrawRecord(int distributorWithdrawRecordId)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.PayDistributorWithdrawRecord, SerializeHelper.IntToByteArray(distributorWithdrawRecordId));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 取消提现申请
        /// </summary>
        /// <param name="distributorWithdrawRecordId"></param>
        /// <returns></returns>
        public InteractResult CancelDistributorWithdrawRecord(int distributorWithdrawRecordId)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.CancelDistributorWithdrawRecord, SerializeHelper.IntToByteArray(distributorWithdrawRecordId));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取分销人员id
        /// </summary>
        /// <returns></returns>
        public InteractResult GetDistributorID()
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.GetDistributorID, null);
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 导入商品信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult ImportPfInfos(List<ImportPfInfosPara> para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.ImportPfInfos, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        } 

        /// <summary>
        /// 将图片上传到腾讯云结果
        /// </summary>
        /// <param name="costumeID"></param>
        /// <returns></returns>
        public InteractResult UploadPhotoToCosResult(string costumeID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(DistributionInformationTypes.UploadPhotoToCosResult, SerializeHelper.StringToByteArray(costumeID));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }
    }
}