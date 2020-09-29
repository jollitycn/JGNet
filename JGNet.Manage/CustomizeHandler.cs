using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.InteractEntity;
using JGNet.Core.MyEnum;
using CJBasic;
using CJPlus.Application.CustomizeInfo;
using CJPlus.Serialization;
using System;
using System.Collections.Generic;

using System.Text;


namespace JGNet.Manage
{
    public class CustomizeHandler : ICustomizeHandler
    {
        private void InformationForm_LinkClicked(bool isShowWorkTabPage)
        {
            ((MainForm)GlobalUtil.MainForm).BuildWorkDeskTabPage();
        }

        public byte[] HandleQuery(string sourceUserID, int informationType, byte[] info)
        {
            return null;
        }

        public void HandleInformation(string sourceUserID, int informationType, byte[] info)
        {
            GlobalUtil.WriteLog("收到通知" + informationType);

            #region 充值规则更改
            if (NoticeInformationTypes.UpdateRechargeDonateRule == informationType)
            {
                RechargeDonateRule rechargeDonateRule = CompactPropertySerializer.Default.Deserialize<RechargeDonateRule>(info, 0);
                GlobalCache.UpdateRechargeDonateRule(rechargeDonateRule);
            }
            else if (NoticeInformationTypes.DeleteRechargeDonateRule == informationType)
            {
                GlobalCache.DeleteRechargeDonateRule();
            }
            else if (NoticeInformationTypes.UpdateShopRechargeRuleID == informationType)
            {
                RechargeDonateRule rechargeDonateRule = CompactPropertySerializer.Default.Deserialize<RechargeDonateRule>(info, 0);
                GlobalCache.UpdateShopRechargeRuleID(rechargeDonateRule);
            }

            #endregion

            #region 系统配置更改

            else if (NoticeInformationTypes.UpdateParameterConfig == informationType)
            {
                ParameterConfig c = CompactPropertySerializer.Default.Deserialize<ParameterConfig>(info, 0);
                GlobalCache.ParameterConfig(c);
            }
            else if (NoticeInformationTypes.UpdateParameterConfigs == informationType)
            {
                List<ParameterConfig> collection = CompactPropertySerializer.Default.Deserialize<List<ParameterConfig>>(info, 0);
                foreach (var item in collection)
                {
                    GlobalCache.ParameterConfig(item);
                }
            }

            #endregion

            #region 导购员信息更改
            else if (NoticeInformationTypes.UpdateGuide == informationType)
            {
                Guide guide = CompactPropertySerializer.Default.Deserialize<Guide>(info, 0);
                GlobalCache.UpdateGuide(guide);
            }
            else if (NoticeInformationTypes.InsertGuide == informationType)
            {
                Guide guide = CompactPropertySerializer.Default.Deserialize<Guide>(info, 0);
                GlobalCache.InsertGuide(guide);
            }
            else if (NoticeInformationTypes.DeleteGuide == informationType)
            {
                string guideID = Encoding.UTF8.GetString(info);
                GlobalCache.DeleteGuide(guideID);
            }
            else if (NoticeInformationTypes.DeleteGuides == informationType)
            {
                List<String> guideIDs = CompactPropertySerializer.Default.Deserialize<List<String>>(info, 0);
                foreach (var guideID in guideIDs)
                {
                    GlobalCache.DeleteGuide(guideID);
                }
            }
            #endregion

            #region 促销活动更改

            else if (NoticeInformationTypes.InsertSalesPromotion == informationType)
            {
                SalesPromotion salesPromotion = CompactPropertySerializer.Default.Deserialize<SalesPromotion>(info, 0);
                GlobalCache.InsertSalesPromotion(salesPromotion);
            }
            else if (NoticeInformationTypes.DeleteSalesPromotion == informationType)
            {
                string salesPromotionID = Encoding.UTF8.GetString(info);
                GlobalCache.DeleteSalesPromotion(salesPromotionID);
            }

            else if (NoticeInformationTypes.UpdateSalesPromotion == informationType)
            {
                SalesPromotion salesPromotion = CompactPropertySerializer.Default.Deserialize<SalesPromotion>(info, 0);
                GlobalCache.UpdateSalesPromotion(salesPromotion);
            }
            #endregion

            #region 品牌配置更改
            else if (NoticeInformationTypes.InsertBrand == informationType)
            {
                Brand brand = CompactPropertySerializer.Default.Deserialize<Brand>(info, 0);
                GlobalCache.InsertBrand(brand);
            }
            else if (NoticeInformationTypes.UpdateBrand == informationType)
            {
                Brand brand = CompactPropertySerializer.Default.Deserialize<Brand>(info, 0);
                GlobalCache.UpdateBrand(brand);
            }
            else if (NoticeInformationTypes.DeleteBrand == informationType)
            {
                int brandID = BitConverter.ToInt32(info, 0);
                GlobalCache.DeleteBrand(brandID);
            }
            #endregion

            #region 服装信息更改

            //新增服装
            else if (NoticeInformationTypes.InsertCostume == informationType)
            {
                Costume costume = CompactPropertySerializer.Default.Deserialize<Costume>(info, 0);
                GlobalCache.InsertCostume(costume);
            }
            //服装信息更改
            else if (NoticeInformationTypes.UpdateCostume == informationType)
            {
                Costume costume = CompactPropertySerializer.Default.Deserialize<Costume>(info, 0);
                GlobalCache.UpdateCostume(costume);
            }
            else if (NoticeInformationTypes.DeleteCostume == informationType)
            {
                string costumeID = Encoding.UTF8.GetString(info);
                GlobalCache.DeleteCostume(costumeID);
            }
            else if (NoticeInformationTypes.InsertCostumes == informationType)
            {
                List<Costume> costumes = CompactPropertySerializer.Default.Deserialize<List<Costume>>(info, 0);
                foreach (var costume in costumes)
                {
                    GlobalCache.InsertCostume(costume);
                }
            }
            else if (NoticeInformationTypes.UpdateCostumes == informationType)
            {
                List<Costume> costumes = CompactPropertySerializer.Default.Deserialize<List<Costume>>(info, 0);
                foreach (var costume in costumes)
                {
                    GlobalCache.UpdateCostume(costume);
                }
            }
            else if (NoticeInformationTypes.UpdateCostumeValid == informationType)
            {
                UpdateCostumeValidPara result = CompactPropertySerializer.Default.Deserialize<UpdateCostumeValidPara>(info, 0);
                GlobalCache.UpdateCostumeValid(result);
            }
            else if (NoticeInformationTypes.InsertCostumeStores == informationType)
            {
                GlobalCache.LoadCostumeInfos();
            }

            #endregion

            #region 管理员信息更改
            //新增管理员
            else if (NoticeInformationTypes.InsertAdminUser == informationType)
            {
                AdminUser adminUser = CompactPropertySerializer.Default.Deserialize<AdminUser>(info, 0);
                GlobalCache.InsertAdminUser(adminUser);
            }
            //管理员信息更改
            else if (NoticeInformationTypes.UpdateAdminUser == informationType)
            {
                AdminUser adminUser = CompactPropertySerializer.Default.Deserialize<AdminUser>(info, 0);
                GlobalCache.UpdateAdminUser(adminUser);
            }
            #endregion

            #region 供应商信息更改
            //新增供应商
            else if (NoticeInformationTypes.InsertSupplier == informationType)
            {
                Supplier supplier = CompactPropertySerializer.Default.Deserialize<Supplier>(info, 0);
                GlobalCache.InsertSupplier(supplier);
            }
            else if (NoticeInformationTypes.ImportSupplier == informationType)
            {
                List<Supplier> suppliers = CompactPropertySerializer.Default.Deserialize<List<Supplier>>(info, 0);
                if (suppliers != null)
                {
                    foreach (var supplier in suppliers)
                    {
                        GlobalCache.InsertSupplier(supplier);
                    }
                }
            }
            //供应商信息更改
            else if (NoticeInformationTypes.UpdateSupplier == informationType)
            {
                Supplier supplier = CompactPropertySerializer.Default.Deserialize<Supplier>(info, 0);
                GlobalCache.UpdateSupplier(supplier);
            }
            //删除供应商
            else if (NoticeInformationTypes.DeleteSupplier == informationType)
            {
                string supplierID = Encoding.UTF8.GetString(info);
                GlobalCache.DeleteSupplier(supplierID);
            }
            #endregion

            #region 店铺更改
            //新增店铺
            else if (NoticeInformationTypes.InsertShop == informationType)
            {
                Shop shop = CompactPropertySerializer.Default.Deserialize<Shop>(info, 0);
                GlobalCache.InsertShop(shop);
            }
            //店铺信息更改
            else if (NoticeInformationTypes.UpdateShop == informationType)
            {
                Shop shop = CompactPropertySerializer.Default.Deserialize<Shop>(info, 0);
                GlobalCache.UpdateShop(shop);
            }
            else if (NoticeInformationTypes.DisableShop == informationType)
            {
                String shopID = Encoding.UTF8.GetString(info);
                GlobalCache.DisableShop(shopID);
            }
            else if (NoticeInformationTypes.DeleteShop == informationType)
            {
                String shopID = Encoding.UTF8.GetString(info);
                GlobalCache.RemoveShop(shopID);
            }
            //Todo:

            #endregion
            else if (NoticeInformationTypes.InsertDifferenceOrder == informationType)
            {
                int result = SerializeHelper.ByteArrayToInt(info);

                DifferenceOrderPagePara checkOrderPagePara = new DifferenceOrderPagePara()
                {
                    OrderID = null,
                    CostumeID = null,
                    IsOpenDate = true,
                    IsOnlyGetOut = true,
                    StartDate = new CJBasic.Date("1900-01-01"),
                    EndDate = new CJBasic.Date(DateTime.Now),
                    PageIndex = 0,
                    PageSize = 1000,
                    ShopID = CommonGlobalCache.CurrentShopID,
                    OrderPrefixType = ValidateUtil.CheckEmptyValue(OrderPrefix.AllocateOrder),
                    DifferenceOrderConfirmed = DifferenceOrderConfirmed.False,

                };

                DifferenceOrderPage checkOrderListPage = CommonGlobalCache.ServerProxy.GetDifferenceOrderPage(checkOrderPagePara);

                ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有"+ checkOrderListPage.DifferenceOrderList.Count+ "张差异单待处理，请及时处理！" + "#"+ informationType);
            }
 #region 新的补货申请单待处理通知
                else if (NoticeInformationTypes.ReplenishOutbound == informationType)
                {
                ReplenishCostumePagePara pageParaReplenish = new ReplenishCostumePagePara()
                {
                    CostumeID = null,
                    ReplenishOrderID = null,
                    IsOpenDate = true,
                    StartDate = new CJBasic.Date("1900-01-01"),
                    EndDate = new CJBasic.Date(DateTime.Now),
                    PageIndex = 0,
                    PageSize = 10000,
                    ShopID = CommonGlobalCache.CurrentShopID,
                    ReplenishOrderState = ReplenishOrderState.NotProcessing,
                    BrandID = -1

                };
                ReplenishCostumePage listPageReplenish = CommonGlobalCache.ServerProxy.GetReplenishCostumePage(pageParaReplenish);

                ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有"+ listPageReplenish .ReplenishOrderList.Count+ "张待发货的补货申请单待处理，请及时处理！" + "#" + informationType);
                }
            else if (NoticeInformationTypes.AllocateOutbound == informationType)
            {
                int result = SerializeHelper.ByteArrayToInt(info);
                if (GlobalCache.GetParameter(ParameterConfigKey.AllocateInDirectly)?.ParaValue == "1")
                {
                    ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有新的调拨单已入库！");
                }
                else
                {

                    GetAllocateOrdersPara pagePara = new GetAllocateOrdersPara()
                    {
                        AllocateOrderID = null,
                        AllocateOrderState = AllocateOrderState.Normal,
                        CostumeID = null,
                        EndDate = new CJBasic.Date(DateTime.Now),
                        StartDate = new CJBasic.Date("1900-01-01"),
                        ShopID = "",
                        Type = AllocateOrderType.All,
                        PageIndex = 0,
                        PageSize = 20,
                        ReceiptState = ReceiptState.WaitReceipt,
                        LockShop = PermissonUtil.HasPermission(RolePermissionMenuEnum.调拨单查询, RolePermissionEnum.查看_只看本店),
                        DestShopID = CommonGlobalCache.CurrentShopID,
                        SourceShopID = "",

                    };

                    InteractResult<AllocateOrderPage> listPage = CommonGlobalCache.ServerProxy.GetAllocateOrders(pagePara);
                    ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有"+ listPage .Data.AllocateOrderList.Count+ "张调拨单待处理，请及时处理！"+"#"+informationType);
                }
            }
            else if (NoticeInformationTypes.ReplenishCostume == informationType)
            {
                int result = SerializeHelper.ByteArrayToInt(info);
                ReplenishCostumePagePara  pageParaReplenish = new ReplenishCostumePagePara()
                {
                    CostumeID =null,
                    ReplenishOrderID = null,
                   IsOpenDate =true,
                    StartDate = new CJBasic.Date("1900-01-01"),
                    EndDate = new CJBasic.Date(DateTime.Now),
                    PageIndex = 0,
                    PageSize = 10000,
                    ShopID = CommonGlobalCache.CurrentShopID,
                    ReplenishOrderState = ReplenishOrderState.NotProcessing,
                    BrandID = -1

                };
                ReplenishCostumePage listPageReplenish = CommonGlobalCache.ServerProxy.GetReplenishCostumePage(pageParaReplenish);
                
                ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有补货申请单待处理，请及时处理！" + "#" + informationType);
            }
  #endregion
                #region 盘点已审核通知
                else if (NoticeInformationTypes.CheckStorePass == informationType)
                {
                    GlobalUtil.WriteLog("盘点已审核通知");
                    ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您的盘点单已审核，请及时查收！" + "#" + informationType);
                   // GlobalUtil.MainForm.OnStoreStateChanged(false);

                }
                #endregion
                #region 盘点退回通知
              /*  else if (NoticeInformationTypes.CancelCheckStore == informationType)
                {
                    GlobalUtil.WriteLog("盘点退回通知");
                    ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您的盘点单被退回，请及时查收！" + "#" + informationType);

                } */
                #endregion
                #region 补货申请单/调拨单冲单通知
                else if (NoticeInformationTypes.OverrideOrder == informationType)
                {
                    string result = String.Empty;
                    if (info != null)
                    {
                        result = Encoding.UTF8.GetString(info);
                    }
                    GlobalUtil.WriteLog("补货申请单/或调拨单" + result + "冲单通知");

                    ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您的" + GlobalUtil.OrderType(result) + "单" + result + "被冲单，请及时查收！" + "#" + informationType);
                }
                #endregion
                #region 补货申请单取消
                else if (NoticeInformationTypes.CancelReplenish == informationType)
                {
                    string result = String.Empty;
                    if (info != null)
                    {
                        result = Encoding.UTF8.GetString(info);
                    }
                    GlobalUtil.WriteLog("补货申请单" + result + "取消通知");

                    ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您的" + GlobalUtil.OrderType(result) + "单" + result + "被取消，请及时查收！" + "#" + informationType);
                }
                #endregion
            else if (NoticeInformationTypes.NewEmRefundOrder == informationType)
            {
                int result = SerializeHelper.ByteArrayToInt(info);

                GetEmOrderPagePara EmReturnpagePara = new GetEmOrderPagePara()
                {
                    OrderID = null,
                    StartDate = new CJBasic.Date("1900-01-01"),
                    EndDate = new CJBasic.Date(DateTime.Now),
                    PageIndex = 0,
                    PageSize = 1000,
                    MemberPhoneOrName = null,
                    CostumeIDOrName = null,
                    OrderState = EmRetailOrderState.All,

                    RefundStatus = RefundStatus.Refunding,
                };

                EmOrderPage EmReturnlistPage = CommonGlobalCache.ServerProxy.GetEmOrderPage(EmReturnpagePara);

                int rows = EmReturnlistPage.ResultList.FindAll(t => t.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.RefundApplication) || t.RefundStateName == EmRetailOrder.GetRefundState(RefundStateEnum.Refunding)).Count;

                ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有"+ rows + "张线上退货待处理，请及时处理！" + "#" + informationType);
            }
            else if (NoticeInformationTypes.NewEmRetailOrder == informationType)
            {
                int result = SerializeHelper.ByteArrayToInt(info);
                GetEmOrderPagePara EmpagePara = new GetEmOrderPagePara()
                {
                    OrderID = null,
                    StartDate = new CJBasic.Date("1900-01-01"),
                    EndDate = new CJBasic.Date(DateTime.Now),
                    PageIndex = 0,
                    PageSize = 1000,
                    MemberPhoneOrName = null,
                    CostumeIDOrName = null,
                    OrderState = EmRetailOrderState.WaitDelivery,
                    RefundStatus = RefundStatus.NotSelect,
                };

                EmOrderPage EmlistPage = CommonGlobalCache.ServerProxy.GetEmOrderPage(EmpagePara); 

                ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有"+ EmlistPage .ResultList.Count+ "张线上订单待处理，请及时处理！" + "#" + informationType);
            }
            #region 批发客户信息更改
            //新增供应商
            else if (NoticeInformationTypes.InsertPfCustomer == informationType)
            {
                PfCustomer supplier = CompactPropertySerializer.Default.Deserialize<PfCustomer>(info, 0);
                PfCustomerCache.InsertPfCustomer(supplier);
            }
            else if (NoticeInformationTypes.ImportPfCustomer == informationType)
            {
                List<PfCustomer> suppliers = CompactPropertySerializer.Default.Deserialize<List<PfCustomer>>(info, 0);
                foreach (var supplier in suppliers)
                {
                    PfCustomerCache.InsertPfCustomer(supplier);
                }
            }
            //供应商信息更改
            else if (NoticeInformationTypes.UpdatePfCustomer == informationType)
            {
                PfCustomer supplier = CompactPropertySerializer.Default.Deserialize<PfCustomer>(info, 0);
                PfCustomerCache.UpdatePfCustomer(supplier);
            }
            //删除供应商
            else if (NoticeInformationTypes.DeletePfCustomer == informationType)
            {
                string supplierID = Encoding.UTF8.GetString(info);
                PfCustomerCache.DeletePfCustomer(supplierID);
            }
            #endregion  
            #region 盘点待处理通知
            else if (NoticeInformationTypes.InsertCheckStore == informationType)
            {

                GlobalUtil.WriteLog("盘点待处理通知");
                CheckStoreOrderPagePara checkPagePara = new CheckStoreOrderPagePara()
                {
                    CheckStoreOrderID = null,
                    IsOpenDate = true,
                    StartDate = new CJBasic.Date("1900-01-01"),
                    EndDate = new CJBasic.Date(DateTime.Now),
                    PageIndex = 0,
                    PageSize = 1000,
                    //ShopID = CommonGlobalCache.CurrentShopID,
                    CostumeID = null,
                    State = CheckStoreOrderState.PendingReview,
                };

                CheckStoreOrderPage ChecklistPage = CommonGlobalCache.ServerProxy.GetCheckStoreOrderPage(checkPagePara);

                ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有"+ ChecklistPage .CheckStoreOrderList.Count+ "张盘点单待审核，请及时处理！" + "#" + informationType);

            }
            #endregion
            #region 盘点退回通知
            else if (NoticeInformationTypes.CancelCheckStore == informationType)
            {
                GlobalUtil.WriteLog("盘点退回通知");
                ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您的盘点单被退回，请及时处理！" + "#" + informationType);
            }
            #endregion 
            #region 盘点取消通知
            else if (NoticeInformationTypes.CancelCheckStoreTask == informationType)
            {
                GlobalUtil.WriteLog("盘点取消通知");
                ((MainForm)GlobalUtil.MainForm).OnNewInfomation("您有盘点已取消！");
            }
            #endregion 
            else if (NoticeInformationTypes.EnabledSizeGroup == informationType)
            {
                EnabledSizeGroupPara sizeGroup = CompactPropertySerializer.Default.Deserialize<EnabledSizeGroupPara>(info, 0);
                GlobalCache.EnabledSizeGroup(sizeGroup);
            }
            else if (NoticeInformationTypes.InsertSizeGroup == informationType)
            {
                SizeGroup sizeGroup = CompactPropertySerializer.Default.Deserialize<SizeGroup>(info, 0);
                GlobalCache.InsertSizeGroup(sizeGroup);
            }
            else if (NoticeInformationTypes.UpdateSizeGroup == informationType)
            {
                SizeGroup sizeGroup = CompactPropertySerializer.Default.Deserialize<SizeGroup>(info, 0);
                GlobalCache.UpdateSizeGroup(sizeGroup);
            }
            else if (NoticeInformationTypes.DeleteSizeGroup == informationType)
            {
                String SizeGroupName = Encoding.UTF8.GetString(info);
                GlobalCache.DeleteSizeGroup(SizeGroupName);
            }
            else if (NoticeInformationTypes.UpdateSizeNames == informationType)
            {
                UpdateSizeNamesInfo sizeNameInfo = CompactPropertySerializer.Default.Deserialize<UpdateSizeNamesInfo>(info, 0);
                GlobalCache.UpdateSizeNames(sizeNameInfo);
            }else if (NoticeInformationTypes.InsertDistributor == informationType)
            {
                Distributor supplier = CompactPropertySerializer.Default.Deserialize<Distributor>(info, 0);
                GlobalCache.InsertDistributor(supplier);
            }
            else if (NoticeInformationTypes.UpdateDistributor == informationType)
            {
                Distributor supplier = CompactPropertySerializer.Default.Deserialize<Distributor>(info, 0);
                GlobalCache.UpdateDistributor(supplier);
            }
            #region 批发客户信息更改
            //新增供应商
            else if (NoticeInformationTypes.InsertPfCustomer == informationType)
            {
                PfCustomer supplier = CompactPropertySerializer.Default.Deserialize<PfCustomer>(info, 0);
                PfCustomerCache.InsertPfCustomer(supplier);
            }
            //供应商信息更改
            else if (NoticeInformationTypes.UpdatePfCustomer == informationType)
            {
                PfCustomer supplier = CompactPropertySerializer.Default.Deserialize<PfCustomer>(info, 0);
                PfCustomerCache.UpdatePfCustomer(supplier);
            }
            //删除供应商
            else if (NoticeInformationTypes.DeletePfCustomer == informationType)
            {
                string supplierID = Encoding.UTF8.GetString(info);
                PfCustomerCache.DeletePfCustomer(supplierID);
            }
			 else if (NoticeInformationTypes.SendAnnounce == informationType)
                {
                    int result = SerializeHelper.ByteArrayToInt(info);
                    Announce announce = CompactPropertySerializer.Default.Deserialize<Announce>(info, 0);
                    //1：发布中，2：已完成，3：已取消
                    AnnounceState state = (AnnounceState)announce.State;

                    switch (state)
                    {
                        case AnnounceState.Finished:
                        case AnnounceState.Cancel:
                            ((MainForm)GlobalUtil.MainForm).SendAnnounce(state);
                            break;
                        case AnnounceState.Releasing:
                            CommonGlobalCache.SystemUpdateMessage = announce.AnnounceContent;
                            ((MainForm)GlobalUtil.MainForm).OnNewInfomation("系统升级公告\r\n尊敬的客户：\r\n" + announce.AnnounceContent);
                            ((MainForm)GlobalUtil.MainForm).SendAnnounce(state);
                            break;
                        default:
                            break;
                    }
                }
                else if (NoticeInformationTypes.NoticeClose == informationType)
                {

                    ((MainForm)GlobalUtil.MainForm).DoClose();
                    //  System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                }
            #endregion



        }
    }
}
