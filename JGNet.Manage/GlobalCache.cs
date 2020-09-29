using CCWin;
using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.ForManage;
using JGNet.Manage.Pages;
using CJBasic.Loggers;
using System;
using System.Collections.Generic;

using System.Reflection;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public class GlobalCache : CommonGlobalCache
    {

        public new static ForManage.ServerProxy ServerProxy
        {
            get
            {
                return (ForManage.ServerProxy)serverProxy;
            }
            set
            {
                serverProxy = value;
            }
        }
        protected static EMallServerProxy eMallServerProxy;
        public static ForManage.EMallServerProxy EMallServerProxy
        {
            get
            {
                return (ForManage.EMallServerProxy)eMallServerProxy;
            }
        }
        public static void CostumeGiftTicketInfo_OnChange(CostumeGiftTicketInfo info)
        {
            costumeGiftTicketInfo = info;
        }


        protected static List<Distributor> distributorList;
        public static List<Distributor> DistributorList { get { return distributorList; } }
        /// <summary>
        /// 新增供应商
        /// </summary>
        /// <param name="supplier"></param>
        public static void InsertDistributor(Distributor supplier)
        {
            if (supplier == null)
            {
                return;
            }
            GlobalCache.distributorList.Add(supplier);
        }
        /// <summary>
        /// 更新供应商
        /// </summary>
        /// <param name="supplier"></param>
        public static void UpdateDistributor(Distributor supplier)
        {
            if (supplier == null)
            {
                return;
            }
            Distributor oldSupplier = GlobalCache.distributorList?.Find(s => s.ID == supplier.ID);
            if (oldSupplier != null)
            {
                GlobalCache.distributorList?.Remove(oldSupplier);
            }
            GlobalCache.distributorList?.Add(supplier);
        }

        private static CosLoginInfo cosLoginInfo;
        public static CosLoginInfo CosLoginInfo { get { return cosLoginInfo; } }


        public static InsertResult RechargeDonateRule_OnInsert(RechargeDonateRule rule)
        {
            InsertResultAndAutoID result = ServerProxy.InsertRechargeDonateRule(rule);

            switch (result.InsertResult)
            {
                case InsertResult.Success:
                    rule.AutoID = result.AutoID;
                    if (GlobalCache.rechargeDonateRuleList == null)
                    {
                        GlobalCache.rechargeDonateRuleList = new List<RechargeDonateRule>();
                    }
                    GlobalCache.rechargeDonateRuleList?.Add(rule);
                    break;
                case InsertResult.Error:
                    break;
                default:
                    break;
            }
            return result.InsertResult;
        }



        public static InteractResult GuideList_OnInsert(Guide item)
        {
            InteractResult result = GlobalCache.ServerProxy.InsertGuide(item);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    GlobalCache.guideList = GlobalCache.ServerProxy.GetGuideList(string.Empty);
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;


        }



        internal static InteractResult GuideList_OnUpdate(Guide guide)
        {
            InteractResult result =
            GlobalCache.ServerProxy.UpdateGuide(guide);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    GlobalCache.guideList = GlobalCache.ServerProxy.GetGuideList(string.Empty);
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        internal static InteractResult EMall_OnUpdate(EMall curEMall)
        {
            InteractResult result = GlobalCache.EMallServerProxy.UpdateEMall(curEMall);
            return result;
        }

        internal static void UpdateCostumeColor(CostumeColor item)
        {
            if (item == null)
            {
                return;
            }
            CostumeColor oldBrand = CommonGlobalCache.costumeColorList?.Find(b => b.ID == item.ID);
            if (oldBrand != null)
            {
                CommonGlobalCache.costumeColorList?.Remove(oldBrand);
            }
            CommonGlobalCache.costumeColorList?.Add(item);
            CommonGlobalCache.costumeColorList?.Sort();
        }

        internal static DeleteResult GuideList_OnDelete(string id)
        {
            DeleteResult result = ServerProxy.DeleteGuide(id);
            switch (result)
            {
                case DeleteResult.Success:
                    GlobalCache.guideList = GlobalCache.ServerProxy.GetGuideList(string.Empty);
                    break;
                case DeleteResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        internal static InteractResult CostumeColor_OnRemove(string id)
        {
            InteractResult result = ServerProxy.DeleteCostumeColor(id);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    CostumeColor c = costumeColorList.Find(t => t.ID == id);
                    if (c != null)
                    {
                        costumeColorList.Remove(c);
                    }
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        internal static DeleteAdminUserResult AdminUser_OnRemove(string id)
        {
            DeleteAdminUserResult result = ServerProxy.DeleteAdminUser(id);
            switch (result)
            {
                case DeleteAdminUserResult.Success:
                    AdminUser c = adminUserList.Find(t => t.ID == id);
                    if (c != null)
                    {
                        adminUserList.Remove(c);
                    }
                    break;
                case DeleteAdminUserResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        internal static void OnUpatePfEmCostumeInfo(EmPfCostumeInfo curItem)
        {
            //Costume info = GlobalCache.costumeList.Find(t => t.ID == curItem.ID);
            //重新从数据库加载
            LoadCostumeInfo(curItem.ID);
            //    CJBasic.Helpers.ReflectionHelper.CopyProperty(curItem, info);
            //  Costume info2 = info;
        }

        internal static void OnUpateEmCostumeInfo(EmCostumeInfo curItem)
        {
            //  Costume info = GlobalCache.costumeList.Find(t => t.ID == curItem.ID);
            LoadCostumeInfo(curItem.ID);
            //   CJBasic.Helpers.ReflectionHelper.CopyProperty(curItem, info);
            //   Costume info2 = info;
        }

        internal static InteractResult AdminUser_OnInsert(AdminUser adminUser)
        {
            InteractResult result = GlobalCache.ServerProxy.InsertAdminUser(adminUser);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    if (GlobalCache.adminUserList == null)
                    {
                        GlobalCache.adminUserList = new List<AdminUser>();
                    }
                    GlobalCache.adminUserList.Add(adminUser);
                    break;
                default:
                    break;
            }
            return result;
        }

        internal static InteractResult Shop_OnDisable(string id)
        {
            InteractResult result = ServerProxy.DisableShop(id);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    //Shop c = ShopList.Find(t => t.ID == id);S
                    //if (c != null)
                    //{
                    //    ShopList.Remove(c);
                    //}
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }


        internal static InteractResult Supllier_OnRemove(string id)
        {
            InteractResult result = ServerProxy.DeleteSupplier(id);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    Supplier c = supplierList.Find(t => t.ID == id);
                    if (c != null)
                    {
                        supplierList.Remove(c);
                        GlobalCache.supplierList?.Sort();
                    }
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }


        internal static InteractResult AdminUser_OnUpdate(AdminUser curAdminUser)
        {
            InteractResult result = GlobalCache.ServerProxy.UpdateAdminUser(curAdminUser);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    AdminUser c = GlobalCache.adminUserList?.Find(t => t.ID == curAdminUser.ID);
                    if (c != null)
                    {
                        GlobalCache.adminUserList?.Remove(c);
                    }
                    GlobalCache.adminUserList?.Add(curAdminUser);
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }





        internal static InsertCostumeClassResult CostumeClassList_OnInsert(CostumeClass item)
        {
            InsertCostumeClassResult result = new InsertCostumeClassResult();//= GlobalCache.ServerProxy.InsertCostumeClass(item);
            //switch (result)
            //{
            //    case InsertCostumeClassResult.Success:
            //        if (GlobalCache.costumeClassList == null)
            //        {
            //            GlobalCache.costumeClassList = new List<CostumeClass>();
            //        }
            //        GlobalCache.costumeClassList.Add(item);
            //        break;
            //    case InsertCostumeClassResult.BigClassIsExist:
            //        break;
            //    case InsertCostumeClassResult.Error:
            //        break;
            //    default:
            //        break;
            //}
            return result;
        }

        internal static UpdateShopResult Shop_OnUpdate(Shop shop)
        {
            UpdateShopResult result = UpdateShopResult.Error;
            if (generalStoreShopID == shop.ID)
            {
                //原来就是总仓，不让改状态
                shop.IsGeneralStore = true;
            }
            else
            {
                //如果之前不是总仓现在是，那么更新原来的仓
                if (shop.IsGeneralStore)
                {

                    Shop store = GlobalCache.ShopList.Find(t => t.ID == generalStoreShopID);
                    if (store != null)
                    {
                        if (GlobalMessageBox.Show("总仓已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            store.IsGeneralStore = false;
                            UpdateShopResult updateShopResult = GlobalCache.ServerProxy.UpdateShop(store);
                            if (updateShopResult != UpdateShopResult.Success)
                            {

                                store.IsGeneralStore = true; return result;
                            }
                        }
                        else { return UpdateShopResult.GeneralStoreIsExist; }
                    }


                }
            }
            result = GlobalCache.ServerProxy.UpdateShop(shop);
            switch (result)
            {
                case UpdateShopResult.Success:
                    Shop c = GlobalCache.ShopList.Find(t => t.AutoCode == shop.AutoCode);
                    if (c != null)
                    {
                        GlobalCache.ShopList.Remove(c);
                    }
                    GlobalCache.ShopList.Add(shop);
                    if (shop.IsGeneralStore)
                    {
                        GlobalCache.currentShopID = GlobalCache.generalStoreShopID = shop.ID;
                    }
                    break;
                case UpdateShopResult.GeneralStoreIsExist:
                    break;
                case UpdateShopResult.Error:
                    break;
                default:
                    break;
            }

            return result;
        }





        internal static InsertShopResult Shop_OnInsert(Shop shop)
        {
            InsertShopResult result = InsertShopResult.GeneralStoreIsExist;
            //如果标识为总仓，则更新原有的默认仓库

            if (shop.IsGeneralStore && GlobalCache.ShopList != null && GlobalCache.ShopList.Count > 0)
            {
                // 

                Shop store = GlobalCache.GetShop(GlobalCache.GeneralStoreShopID);
                if (store != null)
                {
                    if (GlobalMessageBox.Show("总仓已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        store.IsGeneralStore = false;
                        UpdateShopResult updateShopResult = GlobalCache.ServerProxy.UpdateShop(store);
                        if (updateShopResult != UpdateShopResult.Success)
                        {

                            store.IsGeneralStore = true;
                            return result;
                        }
                    }
                    else { return result; }
                }
            }

            InsertShopGetAutoCode insertShopGetAutoCode = GlobalCache.ServerProxy.InsertShop(shop);
            result = insertShopGetAutoCode.InsertShopResult;
            switch (result)
            {
                case InsertShopResult.Success:
                    shop.AutoCode = insertShopGetAutoCode.AutoCode;
                    //if (GlobalCache.ShopList == null)
                    //{
                    //    GlobalCache.ShopList = new List<Shop>();
                    //}

                    //ShopList必须是属性，不要改成从字典GET
                    GlobalCache.ShopList.Add(shop);
                    if (shop.IsGeneralStore)
                    {

                        GlobalCache.currentShopID = GlobalCache.generalStoreShopID = shop.ID;
                    }
                    break;
                case InsertShopResult.GeneralStoreIsExist:
                    break;
                case InsertShopResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }



        internal static UpdateResult CostumeClassList_OnUpdate(CostumeClass item)
        {
            UpdateResult result = new UpdateResult();// GlobalCache.ServerProxy.UpdateCostumeClass(item);
            //switch (result)
            //{
            //    case UpdateResult.Success:
            //        CostumeClass c = GlobalCache.costumeClassList.Find(t => t.BigClass == item.BigClass);
            //        if (c != null)
            //        {
            //            GlobalCache.costumeClassList.Remove(c);
            //        }
            //        GlobalCache.costumeClassList.Add(item);

            //        break;
            //    case UpdateResult.Error:
            //        break;
            //    default:
            //        break;
            //}
            return result;
        }


        internal static InteractResult Supllier_OnInsert(Supplier item)
        {
            InteractResult result = GlobalCache.ServerProxy.InsertSupplier(item);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    if (GlobalCache.supplierList == null)
                    {
                        GlobalCache.supplierList = new List<Supplier>();
                    }
                    GlobalCache.supplierList.Insert(0, item);
                    GlobalCache.supplierList.Sort();
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;

        }


        internal static InteractResult Supplier_OnUpdate(Supplier curSupplier)
        {
            InteractResult result = ServerProxy.UpdateSupplier(curSupplier);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    Supplier supplier = GlobalCache.supplierList?.Find(t => t.ID == curSupplier.ID);
                    if (supplier != null) { GlobalCache.supplierList?.Remove(supplier); }
                    GlobalCache.supplierList?.Add(curSupplier);
                    GlobalCache.supplierList?.Sort();
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        internal static UpdateResult ParameterConfig_OnChange(String key, string paraValue)
        {
            ParameterConfig item = new ParameterConfig() { ParaKey = key, ParaValue = paraValue };
            UpdateResult result =
            GlobalCache.ServerProxy.UpdateParameterConfig(item);
            switch (result)
            {
                case UpdateResult.Success:
                    ParameterConfig pc = GlobalCache.parameterConfigList?.Find(t => t.ParaKey == item.ParaKey);
                    if (pc != null) { GlobalCache.parameterConfigList?.Remove(pc); }
                    GlobalCache.parameterConfigList?.Add(item);
                    ParameterConfig(item);
                    break;
                case UpdateResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        internal static InteractResult CostumeColor_OnInsert(CostumeColor item)
        {

            InteractResult result = GlobalCache.ServerProxy.InsertCostumeColor(item);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    if (GlobalCache.costumeColorList == null)
                    {
                        GlobalCache.costumeColorList = new List<CostumeColor>();
                    }
                    GlobalCache.costumeColorList?.Add(item);
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        public static void Initialize(string userID, ForManage.ServerProxy proxy, EMallServerProxy eMallServerProxy)
        {
            GlobalCache.ServerProxy = proxy;
            GlobalCache.eMallServerProxy = eMallServerProxy;
            GlobalCache.currentUserID = userID;

            GlobalCache.IniProgress += delegate { };
            GlobalCache.UpdateProgress += delegate { };
            GlobalCache.IniFailed += delegate { };
            GlobalCache.IniCompleted += delegate { };
            ReInitialize();
        }

        public static void ReInitialize()
        {
            CJBasic.CbGeneric cb = new CJBasic.CbGeneric(InitializeCache);
            cb.BeginInvoke(null, null);
        }

        /// <summary>
        /// 初始化缓存列表
        /// </summary>
        private static void InitializeCache()
        {
            try
            {
                int total = 19;
                int sleep = 20;
                CommonGlobalCache.iniProgress(total, "加载中……");
                #region 权限 
                CommonGlobalCache.updateProgress("权限");
                if (GlobalCache.currentUser == null)
                {
                    InteractResult<UserInfo> userInfo = GlobalCache.ServerProxy.GetUserInfo(CommonGlobalCache.CurrentUserID);
                    GlobalCache.currentUser = userInfo.Data;
                    GlobalCache.IsPos = GlobalCache.currentUser.Type == UserInfoType.Guide;
                }

                #endregion
                #region 用户信息

                CommonGlobalCache.updateProgress("用户信息");
                ////season 
                if (GlobalCache.adminUserList == null)
                {
                    GlobalCache.adminUserList = GlobalCache.ServerProxy.GetAllAdminUser();

                }
                #endregion
                #region 店铺信息
                CommonGlobalCache.updateProgress("店铺信息");
                if (GlobalCache.ShopList == null)
                {
                    GlobalCache.generalStoreShopID = GlobalCache.ServerProxy.GetGeneralStoreShopID();
                    GlobalCache.currentShopID = GlobalCache.currentUser.ShopId;
                    GlobalCache.ShopList = GlobalCache.ServerProxy.GetShopList();
                    //      GlobalCache.eMall = GlobalCache.EMallServerProxy.GetEMall();
                }
                #endregion
                #region 导购 
                CommonGlobalCache.updateProgress("导购");
                if (GlobalCache.guideList == null)
                {
                    List<Guide> guideList = GlobalCache.ServerProxy.GetGuideList(string.Empty);
                    GlobalCache.guideList = guideList;
                }
                #endregion

                #region 促销活动
                CommonGlobalCache.updateProgress("促销活动");
                if (salesPromotionList == null)
                {
                    GetSalesPromotionListPara getSalesPromotionListPara = new GetSalesPromotionListPara();
                    getSalesPromotionListPara.PromotionType = (int)PromotionTypeEnum.Null;
                    salesPromotionList = GlobalCache.ServerProxy.GetSalesPromotionList(getSalesPromotionListPara);
                }

                #endregion
                #region 充值规则
                CommonGlobalCache.updateProgress("充值规则");
                if (rechargeDonateRuleList == null)
                {
                    GlobalCache.rechargeDonateRuleList = GlobalCache.ServerProxy.GetRechargeDonateRuleList();
                    RechargeDonateRule rechargeDonateRule = GlobalCache.rechargeDonateRuleList[0];
                    if (rechargeDonateRule != null)
                    {
                        GlobalCache.RechargeDonateRule = rechargeDonateRule;
                    }
                }

                #endregion 
                #region 服装颜色
                CommonGlobalCache.updateProgress("服装颜色");
                if (GlobalCache.costumeColorList == null)
                {
                    GlobalCache.costumeColorList = GlobalCache.ServerProxy.GetCostumeColor();
                }

                #endregion
                #region 年份
                CommonGlobalCache.updateProgress("年份");
                List<int> list = YearHelper.GetYearList(DateTime.Now);
                foreach (int year in list)
                {
                    GlobalCache.yearList.Add(new ListItem<int>(year.ToString(), year));
                }
                #endregion
                #region 品牌
                CommonGlobalCache.updateProgress("品牌");
                if (GlobalCache.brandList == null)
                {
                    //  List<Brand> bList= GlobalCache.ServerProxy.GetBrand().FindAll(t=>t.IsDisable=false);
                    List<Brand> bList = GlobalCache.ServerProxy.GetEnableBrands().Data;
                    GlobalCache.brandList = bList;
                    GlobalCache.brandList?.Sort();
                }

                #endregion
                #region 菜单
                GlobalCache.Permissons = WinformUIUtil.GetAllTreeNodes(PermissonUtil.GetTreeNodes());
                GlobalCache.Permissons.Add(PermissonUtil.NewTreeNode(RolePermissionMenuEnum.工作台));
                if (CommonGlobalCache.CurrentUserID == SystemDefault.DefaultAdmin)
                {
                    GlobalCache.Permissons.Add(PermissonUtil.NewTreeNode(RolePermissionMenuEnum.管理员));
                }
                GlobalCache.Permissons.Add(PermissonUtil.NewTreeNode(RolePermissionMenuEnum.退出));

                #endregion
                #region 配置
                CommonGlobalCache.updateProgress("配置");
                if (GlobalCache.parameterConfigList == null)
                {
                    GlobalCache.parameterConfigList = GlobalCache.ServerProxy.GetAllParameterConfig();
                    SetParams();
                }
                #endregion
                #region 促销类型
                CommonGlobalCache.updateProgress("促销类型");
                if (GlobalCache.promotionTypeEnumList == null)
                {
                    List<ListItem<PromotionTypeEnum>> promotionTypeList = new List<ListItem<PromotionTypeEnum>>();
                    promotionTypeList.Add(new ListItem<PromotionTypeEnum>(GlobalUtil.COMBOBOX_ALL, PromotionTypeEnum.Null));
                    promotionTypeList.Add(new ListItem<PromotionTypeEnum>(EnumHelper.GetDescription(PromotionTypeEnum.MJ), PromotionTypeEnum.MJ));
                    promotionTypeList.Add(new ListItem<PromotionTypeEnum>(EnumHelper.GetDescription(PromotionTypeEnum.Discount), PromotionTypeEnum.Discount));
                    promotionTypeList.Add(new ListItem<PromotionTypeEnum>(EnumHelper.GetDescription(PromotionTypeEnum.YKJ), PromotionTypeEnum.YKJ));
                    GlobalCache.promotionTypeEnumList = promotionTypeList;
                }

                #endregion
                #region 供应商

                CommonGlobalCache.updateProgress("供应商");
                if (GlobalCache.supplierList == null)
                {
                    GlobalCache.supplierList = GlobalCache.ServerProxy.GetSupplierList();
                    GlobalCache.supplierList?.Sort();
                }
                #endregion


                if (GlobalCache.distributorMemberList == null)
                {
                    GlobalCache.distributorMemberList = (List<TreeModel>)CommonGlobalCache.ServerProxy.GetRetailDistributionTree().Data;
                    // GlobalCache.supplierList = GlobalCache.ServerProxy.GetSupplierList();
                }
                if (GlobalCache.distributorPFMemberList == null)
                {
                    GlobalCache.distributorPFMemberList = (List<TreeModel>)CommonGlobalCache.ServerProxy.GetPfDistributionTree().Data;
                    /*  GetDistributorPagePara para = new GetDistributorPagePara()
                      {
                          IdOrName = null,
                          PageIndex = 0,
                          PageSize = int.MaxValue
                      };
                      DistributorPage page = GlobalCache.ServerProxy.GetDistributorPage(para);
                      List<TreeModel> listM = new List<TreeModel>();
                      List<Distributor> Dlist =  page.Distributors as List<Distributor>;
                      foreach (Distributor item in Dlist)
                      {
                          TreeModel curModel = new TreeModel();
                          curModel.ID= item.ID;
                          curModel.AccruedCommission = item.AccruedCommission;
                          curModel.Name = item.Name;
                          listM.Add(curModel);
                      } 
                      GlobalCache.distributorPFMemberList = listM;*/




                    // GlobalCache.supplierList = GlobalCache.ServerProxy.GetSupplierList();
                }
                #region 服装信息
                CommonGlobalCache.updateProgress("服装信息");
                if (costumeList == null)
                {
                    LoadCostumeInfos(total, true);
                }
                //条形码
                #endregion
                #region 尺码组
                CommonGlobalCache.updateProgress("尺码组");
                if (sizeGroupList == null)
                {
                    sizeGroupList = GlobalCache.ServerProxy.GetAllSizeGroup();
                }
                #endregion
                #region COS
                CommonGlobalCache.updateProgress("COS");
                if (cosLoginInfo == null)
                {
                    GlobalCache.cosLoginInfo = GlobalCache.EMallServerProxy.GetCosLoginInfo();
                }
                #endregion

                #region 分销人员
                CommonGlobalCache.updateProgress("分销人员");
                if (GlobalCache.distributorList == null)
                {
                    GetDistributorPagePara para = new GetDistributorPagePara()
                    {
                        IdOrName = null,
                        PageIndex = 0,
                        PageSize = int.MaxValue
                    };
                    DistributorPage page = GlobalCache.ServerProxy.GetDistributorPage(para);
                    GlobalCache.distributorList = page.Distributors;
                }
                #endregion
                #region 批发
                CommonGlobalCache.updateProgress("批发");
                PfCustomerCache.Load();
                #endregion

                #region 商城
                CommonGlobalCache.updateProgress("商城");
                if (eMallMiniProgramImg == null)
                {
                    byte[] imageByte = GlobalCache.ServerProxy.GetEMallMiniProgramImg();
                    if (imageByte != null)
                    {
                        eMallMiniProgramImg = CCWin.SkinControl.ImageHelper.Convert(imageByte);
                    }
                }
                #endregion
                GlobalCache.updateProgress("");
                GlobalCache.iniCompleted();
            }
            catch (Exception ex)
            {
                CommonGlobalCache.iniFailed(ex);
            }
        }




        public static InteractResult CostumeColorList_OnChange(CostumeColor item)
        {
            InteractResult result = GlobalCache.ServerProxy.InsertCostumeColor(item);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    GlobalCache.costumeColorList = GlobalCache.ServerProxy.GetCostumeColor();
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        public static InteractResult Brand_OnRemove(int autoID)
        {
            InteractResult result = GlobalCache.ServerProxy.DeleteBrand(autoID);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    Brand b = GlobalCache.brandList.Find(t => t.AutoID == autoID);
                    if (b != null)
                    {
                        GlobalCache.brandList.Remove(b);
                    }
                    break;
                case ExeResult.Error:
                    break;
                default:
                    break;
            }
            return result;
        }

        internal static InsertResult BrandList_OnInsert(Brand item)
        {
            InteractResult<int> result = GlobalCache.ServerProxy.InsertBrand(item);
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    item.AutoID = result.Data;
                    if (GlobalCache.brandList == null)
                    {
                        GlobalCache.brandList = new List<Brand>();
                    }

                    if (!brandList.Exists(t => t.Name == item.Name))
                    {
                        GlobalCache.brandList.Add(item);
                    }
                    return InsertResult.Success;
                case ExeResult.Error:
                    return InsertResult.Error;
                default:
                    break;
            }
            return InsertResult.Error;
        }



        public static void UpdateBrandList(Brand item)
        {
            if (GlobalCache.brandList == null)
            {
                GlobalCache.brandList = new List<Brand>();
            }


            Brand brand = brandList.Find(t => t.AutoID == item.AutoID);
            if (brand != null)
            {
                GlobalCache.brandList.Remove(brand);
            }
            GlobalCache.brandList.Add(brand);
        }

        internal static List<CostumeClassInfo> GetCostumeClassList()
        {
            return GlobalCache.ServerProxy.GetCostumeClassList();
        }


        #region Initialize




        internal static SalesPromotion GetSalesPromotionFromAll(string salesPromotionID)
        {
            SalesPromotion result = salesPromotionList.Find(t => t.ID == salesPromotionID);
            return result;
        }

        #endregion


        //只获取该店铺关联的活动
        public static List<SalesPromotion> SalesPromotionEnableList(String shopID)
        {
            List<SalesPromotion> promotions = salesPromotionList?.FindAll(t => t.StartDate <= DateTime.Now && t.EndDate >= DateTime.Now && t.ShopIDList.Contains(shopID) && t.IsValid && t.Enabled && (PromotionTypeEnum)t.PromotionType != PromotionTypeEnum.YKJ);
            return promotions;
        }

        //只获取该店铺关联的活动
        public static List<SalesPromotion> SalesBuyoutPromotionEnableList
        {
            get
            {
                List<SalesPromotion> promotions = salesPromotionList?.FindAll(t => t.StartDate <= DateTime.Now && t.EndDate >= DateTime.Now && t.ShopIDList.Contains(CommonGlobalCache.currentShopID) && t.IsValid && t.Enabled && (PromotionTypeEnum)t.PromotionType == PromotionTypeEnum.YKJ);
                return promotions;
            }
        }
        public static List<SalesPromotion> SalesBuyoutPromotionEnableListByShop(String shopID)
        {
            List<SalesPromotion> promotions = salesPromotionList?.FindAll(t => t.StartDate.Date <= DateTime.Now.Date && t.EndDate.Date >= DateTime.Now.Date && t.ShopIDList.Contains(shopID) && t.IsValid && t.Enabled && (PromotionTypeEnum)t.PromotionType == PromotionTypeEnum.YKJ);
            return promotions;

        }
    }
}
