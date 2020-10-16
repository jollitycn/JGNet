using JGNet.Common;
using JGNet.Core;
using JGNet.Core.InteractEntity;
using ESPlus.Rapid;
using ESPlus.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JGNet.ForManage
{
    public class ServerProxy: Common.ServerProxy
    {
        public ServerProxy(IRapidPassiveEngine _engine) : base(_engine)
        {
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
        /// 查询充值规则列表
        /// </summary>
        /// <returns></returns>
        public List<RechargeDonateRule> GetRechargeDonateRuleList()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetRechargeDonateRuleList, null);

            return CompactPropertySerializer.Default.Deserialize<List<RechargeDonateRule>>(response, 0);
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
        /// 新增配置
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        //public InsertResult InsertParameterConfig(ParameterConfig para)
        //{
        //    byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertParameterConfig, SerializeHelper.ResultToSerialize(para));

        //    return (InsertResult)SerializeHelper.ByteArrayToInt(response);
        //}

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
        public InsertGuideResult InsertGuide(Guide para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertGuide, SerializeHelper.ResultToSerialize(para));

            return (InsertGuideResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改导购员
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateGuide(Guide para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateGuide, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 新增供应商
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertSupplierResult InsertSupplier(Supplier para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertSupplier, SerializeHelper.ResultToSerialize(para));

            return (InsertSupplierResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改供应商
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateSupplier(Supplier para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateSupplier, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 查询供应商列表
        /// </summary>
        /// <returns></returns>
        public List<Supplier> GetSupplierList()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetSupplierList, null);

            return CompactPropertySerializer.Default.Deserialize<List<Supplier>>(response, 0);
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
        public UpdateResult UpdateCostume(Costume para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateCostume, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 删除供应商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteSupplier(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteSupplier, SerializeHelper.StringToByteArray(id));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
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
        public ReplenishOutboundResult ReplenishOutbound(Outbound para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.ReplenishOutbound, SerializeHelper.ResultToSerialize(para));

            return (ReplenishOutboundResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 新增颜色
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertCostumeColorResult InsertCostumeColor(CostumeColor para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertCostumeColor, SerializeHelper.ResultToSerialize(para));

            return (InsertCostumeColorResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改颜色
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateCostumeColor(CostumeColor para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateCostumeColor, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 删除颜色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteCostumeColor(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteCostumeColor, SerializeHelper.StringToByteArray(id));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 新增品牌
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertResultAndAutoID InsertBrand(Brand para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertBrand, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<InsertResultAndAutoID>(response, 0);
        }

        /// <summary>
        /// 修改品牌
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateBrand(Brand para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateBrand, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 删除品牌
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteBrand(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteBrand, SerializeHelper.IntToByteArray(id));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 新增服装分类
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertCostumeClassResult InsertCostumeClass(CostumeClass para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertCostumeClass, SerializeHelper.ResultToSerialize(para));

            return (InsertCostumeClassResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改服装分类。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateCostumeClass(CostumeClass para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateCostumeClass, SerializeHelper.ResultToSerialize(para));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 删除服装分类
        /// </summary>
        /// <param name="bigClass"></param>
        /// <returns></returns>
        public DeleteResult DeleteCostumeClass(string bigClass)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteCostumeClass, SerializeHelper.StringToByteArray(bigClass));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
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
        /// 获取总仓店铺id
        /// </summary>
        /// <returns></returns>
        public string GetGeneralStoreShopID()
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetGeneralStoreShopID, null);

            return SerializeHelper.ByteArrayToString(response);
        }

        /// <summary>
        /// 逻辑删除服装
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteCostume(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.DeleteCostume, SerializeHelper.StringToByteArray(id));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 采购进货
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertResult PurchaseCostume(PurchaseCostume para)
        {
            byte[] request = SerializeHelper.ResultToSerialize(para);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.PurchaseCostume, request);

            return (InsertResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 根据补货单信息，返回对应的库存信息
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
        public InsertResult ReturnCostume(ReturnCostume para)
        {
            byte[] request = SerializeHelper.ResultToSerialize(para);
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.ReturnCostume, request);

            return (InsertResult)SerializeHelper.ByteArrayToInt(response);
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
        public InsertAdminResult InsertAdminUser(AdminUser adminUser)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertAdminUser, SerializeHelper.ResultToSerialize(adminUser));

            return (InsertAdminResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改后台管理用户
        /// </summary>
        /// <param name="adminUser"></param>
        /// <returns></returns>
        public UpdateResult UpdateAdminUser(AdminUser adminUser)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.UpdateAdminUser, SerializeHelper.ResultToSerialize(adminUser));

            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
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
        /// 根据哪一天日报查询除汇总外的所有的店铺日报
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<DayReport> GetDayReports4ReportDate(GetReportsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetDayReports4ReportDate, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<DayReport>>(response, 0);
        }

        /// <summary>
        /// 报损
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InsertResult Scrap(ScrapCostume para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.Scrap, SerializeHelper.ResultToSerialize(para));

            return (InsertResult)SerializeHelper.ByteArrayToInt(response); ;
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
        /// 获取月报信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<MonthReport> GetMonthReports(GetMonthReportPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetMonthReports, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<MonthReport>>(response, 0);
        }

        /// <summary>
        /// 根据哪一天月报查询除汇总外的所有的店铺月报
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<MonthReport> GetMonthReport4ReportMonth(GetReportsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetMonthReport4ReportMonth, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<MonthReport>>(response, 0);
        }

        /// <summary>
        /// 根据某一天获取所有店铺的营业日报
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public List<DayBenefitReport> GetAllShopDayBenefitReports4ReportDate(GetReportsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.GetAllShopDayBenefitReports4ReportDate, SerializeHelper.ResultToSerialize(para));

            return CompactPropertySerializer.Default.Deserialize<List<DayBenefitReport>>(response, 0);
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
        public InsertResult InsertSupplierAccountRecord(SupplierAccountRecord para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(ManageInformationTypes.InsertSupplierAccountRecord, SerializeHelper.ResultToSerialize(para));

            return (InsertResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取供应商往来账分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public void UploadCostumePhoto(UploadCostumePhotoPara para)
        {
            this.engine.CustomizeOutter.SendBlob(null, ManageInformationTypes.UploadCostumePhoto, SerializeHelper.ResultToSerialize(para), 10 * 1024 * 1024);
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
        
    }
}