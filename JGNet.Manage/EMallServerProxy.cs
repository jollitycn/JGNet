using JGNet.Common;
using JGNet.Core;
using JGNet.Core.Dev.InteractEntity;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using CJBasic;
using CJPlus.Rapid;
using CJPlus.Serialization;
using System;
using System.Collections.Generic;

using System.Text;


namespace JGNet.ForManage
{
    public class EMallServerProxy
    {
        protected IRapidPassiveEngine engine;

        public EMallServerProxy(IRapidPassiveEngine _engine) 
        {
            this.engine = _engine;
        }
        
        /// <summary>
        /// 获取线上商城信息
        /// </summary>
        /// <returns></returns>
        public EMall GetEMall()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEMall, null);
            return CompactPropertySerializer.Default.Deserialize<EMall>(response, 0);
        }

        /// <summary>
        /// 获取线上商城商场logo
        /// </summary>
        /// <returns></returns>
        public byte[] GetEMallLogo()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEMallLogo, null);

            return response;
        }

        /// <summary>
        /// 修改线上商城信息。
        /// </summary>
        /// <returns></returns>
        public InteractResult UpdateEMall(EMall eMall)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateEMall, SerializeHelper.ResultToSerialize(eMall));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        ///  修改线上商城商场logo
        /// </summary>
        /// <returns></returns>
        public void UpdateEMallLogo(UpdateEMallLogoPara para)
        {
            this.engine.CustomizeOutter.SendBlob(null, EMallInformationTypes.UpdateEMallLogo, SerializeHelper.ResultToSerialize(para), 2 * 1024 * 1024);
        }

        /// <summary>
        /// 获取上架商品
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public EmCostumePage GetEmCostumePage(GetEmCostumePagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmCostumePage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<EmCostumePage>(response, 0);
        }

        /// <summary>
        /// 是否在线上商城中作为店主推荐
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult UpdateEmRecommand(UpdateEmRecommandPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateEmRecommand, SerializeHelper.ResultToSerialize(para));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }
        
        /// <summary>
        /// 下架
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UpdateResult UpdateEmShowOnlineIsFalse(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateEmShowOnlineIsFalse, SerializeHelper.StringToByteArray(id));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public EmCostumeInfo GetEmCostumeInfo(GetEmCostumePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmCostumeInfo, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<EmCostumeInfo>(response, 0);
        }

        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpateEmCostumeInfo(EmCostumeInfo para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpateEmCostumeInfo, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 上架
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult ShelvesEmCostumeInfo(EmCostumeInfo para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.ShelvesEmCostumeInfo, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取cos登陆信息
        /// </summary>
        /// <returns></returns>
        public CosLoginInfo GetCosLoginInfo()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetCosLoginInfo, null);
            return CompactPropertySerializer.Default.Deserialize<CosLoginInfo>(response, 0);
        }
        
        /// <summary>
        /// 查询线上订单管理列表分页
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal EmOrderPage GetEmOrderPage(GetEmOrderPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmOrderPage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<EmOrderPage>(response, 0);
        }

        /// <summary>
        /// 新增运费模版
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal InsertResult InsertCarriageCost(CarriageCost para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.InsertCarriageCost, SerializeHelper.ResultToSerialize(para));
            return (InsertResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取运费模板分页信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal CarriageCostTemplatePage GetCarriageCostTemplatePage(CarriageCostTemplatePagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetCarriageCostTemplatePage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<CarriageCostTemplatePage>(response, 0);
        }
        
        /// <summary>
        /// 删除运费模版
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal InteractResult DeleteCarriageCostTemplate(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.DeleteCarriageCostTemplate, SerializeHelper.IntToByteArray(id));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 修改运费模版
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal UpdateResult UpdateCarriageCost(CarriageCost para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateCarriageCost, SerializeHelper.ResultToSerialize(para));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取运费模板详细信息。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal CarriageCost GetCarriageCost(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetCarriageCost, SerializeHelper.IntToByteArray(id));
            return CompactPropertySerializer.Default.Deserialize<CarriageCost>(response, 0);
        }
        
        /// <summary>
        /// 发货
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal InteractResult EmOutbound(EmOutboundPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.EmOutbound, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取物流信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal List<DataInfo> GetLogistics(GetLogisticsPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetLogistics, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<List<DataInfo>>(response, 0);
        }

        /// <summary>
        /// 获取 线上销售单明细。
        /// </summary>
        /// <param name="emRetailOrderID"></param>
        /// <returns></returns>
        internal List<EmRetailDetail> GetEmRetailDetail(string emRetailOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmRetailDetail, SerializeHelper.StringToByteArray(emRetailOrderID));
            return CompactPropertySerializer.Default.Deserialize<List<EmRetailDetail>>(response, 0);
        }

        /// <summary>
        /// 获取 快递公司信息列表
        /// </summary>
        /// <returns></returns>
        internal List<EmExpressCompany> GetAllEmExpressCompany()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetAllEmExpressCompany, null);
            return CompactPropertySerializer.Default.Deserialize<List<EmExpressCompany>>(response, 0);
        }

        /// <summary>
        /// 修改 快递公司信息
        /// </summary>
        /// <param name="emExpressCompany"></param>
        /// <returns></returns>
        internal UpdateResult UpdateEmExpressCompany(EmExpressCompany emExpressCompany)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateEmExpressCompany, SerializeHelper.ResultToSerialize(emExpressCompany));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取 启用的快递公司列表
        /// </summary>
        /// <returns></returns>
        internal List<EmExpressCompany> GetEnabledEmExpressCompanys()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEnabledEmExpressCompanys, null);
            return CompactPropertySerializer.Default.Deserialize<List<EmExpressCompany>>(response, 0);
        }

        /// <summary>
        /// 拒绝退款。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal RefundResult RefusedRefund(RefusedRefundPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.RefusedRefund, SerializeHelper.ResultToSerialize(para));
            return (RefundResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 同意退款
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal RefundResult AgreeRefund(AgreeRefundPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.AgreeRefund, SerializeHelper.ResultToSerialize(para));
            return (RefundResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 获取有效运费模板列表
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal List<EmCarriageCostTemplate> GetValidCarriageCostTemplates()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetValidCarriageCostTemplates, null);
            return CompactPropertySerializer.Default.Deserialize<List<EmCarriageCostTemplate>>(response, 0);
        }

        /// <summary>
        /// 查询线上退货订单管理列表分页
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal EmRefundOrderPage GetEmRefundOrderPage(GetEmOrderPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmRefundOrderPage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<EmRefundOrderPage>(response, 0);
        }

        /// <summary>
        /// 确认退款
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        internal RefundResult ConfirmRefund(ConfirmRefundPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.ConfirmRefund, SerializeHelper.ResultToSerialize(para));
            return (RefundResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 下架的商品重新上架
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UpdateResult UpdateEmShowOnlineIsTrue(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateEmShowOnlineIsTrue, SerializeHelper.StringToByteArray(id));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }
        
        /// <summary>
        /// 获取 线上退货单明细。
        /// </summary>
        /// <param name="emRetailOrderID"></param>
        /// <returns></returns>
        internal List<EmRefundDetail> GetEmRefundDetails(string emRefundOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmRefundDetails, SerializeHelper.StringToByteArray(emRefundOrderID));
            return CompactPropertySerializer.Default.Deserialize<List<EmRefundDetail>>(response, 0);
        }

        /// <summary>
        /// 根据id获取线上销售单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal EmRetailOrder GetOneEmRetailOrder(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetOneEmRetailOrder, SerializeHelper.StringToByteArray(id));
            return CompactPropertySerializer.Default.Deserialize<EmRetailOrder>(response, 0);
        }

        /// <summary>
        /// 获取退款详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal List<EmRefundTrackInfo> GetEmRefundTrackInfos(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmRefundTrackInfos, SerializeHelper.StringToByteArray(id));
            return CompactPropertySerializer.Default.Deserialize<List<EmRefundTrackInfo>>(response, 0);
        }

        /// <summary>
        /// 获取退货地址
        /// </summary>
        /// <returns></returns>
        internal List<EmRefundAddress> GetEmRefundAddressList()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmRefundAddressList, null);
            return CompactPropertySerializer.Default.Deserialize<List<EmRefundAddress>>(response, 0);
        }

        /// <summary>
        /// 新增退货地址
        /// </summary>
        /// <param name="emRefundAddress"></param>
        /// <returns></returns>
        public InsertResult InsertEmRefundAddress(EmRefundAddress emRefundAddress)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.InsertEmRefundAddress, SerializeHelper.ResultToSerialize(emRefundAddress));
            return (InsertResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 修改退货地址。
        /// </summary>
        /// <param name="emRefundAddress"></param>
        /// <returns></returns>
        public UpdateResult UpdateEmRefundAddress(EmRefundAddress emRefundAddress)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateEmRefundAddress, SerializeHelper.ResultToSerialize(emRefundAddress));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 删除退货地址。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeleteResult DeleteEmRefundAddress(int id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.DeleteEmRefundAddress, SerializeHelper.IntToByteArray(id));
            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 模糊查询线上销售单id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<EmRetailOrder> GetEmRetailOrderIdLike(string id)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmRetailOrderIdLike, SerializeHelper.StringToByteArray(id));
            return CompactPropertySerializer.Default.Deserialize<List<EmRetailOrder>>(response, 0);
        }

        /// <summary>
        /// 获取线上退货单物流信息
        /// </summary>
        /// <param name="emRefundOrderID"></param>
        /// <returns></returns>
        public EmRetailOrder GetEmRefundOrderLogistics(string emRefundOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmRefundOrderLogistics, SerializeHelper.StringToByteArray(emRefundOrderID));
            return CompactPropertySerializer.Default.Deserialize<EmRetailOrder>(response, 0);
        }

        /// <summary>
        /// 获取线上订单销售各状态单数。
        /// </summary>
        /// <returns></returns>
        public EmOrderCount4State GetEmOrderCount4State()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmOrderCount4State, null);
            return CompactPropertySerializer.Default.Deserialize<EmOrderCount4State>(response, 0);
        }

        /// <summary>
        /// 修改小程序码或小程序二维码 图片 （打印小票用）。
        /// </summary>
        /// <param name="para"></param>
        public void UpdateEMallMiniProgramImg(UpdateEMallPhotoPara para)
        {
            this.engine.CustomizeOutter.SendBlob(null, EMallInformationTypes.UpdateEMallMiniProgramImg, SerializeHelper.ResultToSerialize(para), 2 * 1024 * 1024);
        }

        /// <summary>
        /// 获取线上批发商品
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public EmPfCostumePage GetEmPfCostumePage(GetEmPfCostumePagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmPfCostumePage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<EmPfCostumePage>(response, 0);
        }

        /// <summary>
        /// 设置服装是否是新品
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult IsCostumeNew(string costumeID, bool isNew)
        {
            Parameter<string, bool> para = new Parameter<string, bool>(costumeID, isNew);
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.IsCostumeNew, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 设置服装是否是推荐
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult IsCostumeHot(string costumeID, bool isHot)
        {
            Parameter<string, bool> para = new Parameter<string, bool>(costumeID, isHot);
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.IsCostumeHot, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发下架。
        /// </summary>
        /// <param name="costumeID"></param>
        /// <returns></returns>
        public InteractResult UpdateOnlinePfIsFalse(string costumeID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateOnlinePfIsFalse, SerializeHelper.StringToByteArray(costumeID));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发商品上架
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public InteractResult ShelvesEmPfCostumeInfo(ShelvesEmPfInfoPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.ShelvesEmPfCostumeInfo, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取批发商品信息。。(上传图片和线上商城的一致，上传成功后，重新获取信息，确保图片已上传)
        /// </summary>
        /// <param name="costumeId"></param>
        /// <returns></returns>
        public EmPfCostumeInfo GetEmPfCostumeInfo(string costumeId)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEmPfCostumeInfo, SerializeHelper.StringToByteArray(costumeId));
            return CompactPropertySerializer.Default.Deserialize<EmPfCostumeInfo>(response, 0);
        }

        /// <summary>
        /// 修改批发商品。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public InteractResult UpdateShelvesEmPfCostumeInfo(ShelvesEmPfInfoPara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateShelvesEmPfCostumeInfo, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取批发订货单分页信息。
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public PfCustomerOrderPage GetPfCustomerOrderPage(GetPfCustomerOrderPagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetPfCustomerOrderPage, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<PfCustomerOrderPage>(response, 0);
        }
        
        /// <summary>
        /// 作废批发订货单
        /// </summary>
        /// <param name="pfCustomerOrderID"></param>
        /// <returns></returns>
        public InteractResult InvalidPfCustomerOrder(string pfCustomerOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.InvalidPfCustomerOrder, SerializeHelper.StringToByteArray(pfCustomerOrderID));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 批发订货单发货
        /// </summary>
        /// <param name="details"></param>
        /// <returns></returns>
        public InteractResult PfCustomerOrderDelivery(string pfCustomerOrderID, string adminUserID, List<PfCustomerDetail> details)
        {
            Parameter<string, string, List<PfCustomerDetail>> para = new Parameter<string, string, List<PfCustomerDetail>>(pfCustomerOrderID, adminUserID, details);
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.PfCustomerOrderDelivery, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 获取批发订货单详情。
        /// </summary>
        /// <param name="pfCustomerOrderID"></param>
        /// <returns></returns>
        public PfCustomerDetails GetPfCustomerDetails(string pfCustomerOrderID)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetPfCustomerDetails, SerializeHelper.StringToByteArray(pfCustomerOrderID));
            return CompactPropertySerializer.Default.Deserialize<PfCustomerDetails>(response, 0);
        }

        /// <summary>
        /// 获取线上批发商城商场logo
        /// </summary>
        /// <returns></returns>
        public byte[] GetPfEMallLogo()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetPfEMallLogo, null);

            return response;
        } 
        /// <summary>
        ///  修改线上批发商城商场logo
        /// </summary>
        /// <returns></returns>
        public void UpdatePfEMallLogo(UpdateEMallLogoPara para)
        {
            this.engine.CustomizeOutter.SendBlob(null, EMallInformationTypes.UpdatePfEMallLogo, SerializeHelper.ResultToSerialize(para), 2 * 1024 * 1024);
        }

        /// <summary>
        /// 取消批发订货单
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public InteractResult CancelPfCustomerOrder(string pfCustomerOrderId)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.CancelPfCustomerOrder, SerializeHelper.StringToByteArray(pfCustomerOrderId));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 设置批发发货单物流信息。
        /// </summary>
        /// <param name="pfOrderId"></param>
        /// <param name="expressCompany"></param>
        /// <param name="expressOrderID"></param>
        /// <returns></returns>
        public InteractResult SetPfOrderExpressInfo(string pfOrderId, string expressCompany, string expressOrderID)
        {
            Parameter<string, string, string> para = new Parameter<string, string, string>(pfOrderId, expressCompany, expressOrderID);
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.SetPfOrderExpressInfo, SerializeHelper.ResultToSerialize(para));
            return CompactPropertySerializer.Default.Deserialize<InteractResult>(response, 0);
        }

        /// <summary>
        /// 将线上批发商城的宣传海报图片上传到腾讯云
        /// </summary>
        /// <param name="photoData"></param>
        public void UploadPfPosterImageToCos(PosterImage posterImage)
        {
            this.engine.CustomizeOutter.SendBlob(null, EMallInformationTypes.UploadPfPosterImageToCos, SerializeHelper.ResultToSerialize(posterImage), 2 * 1024 * 1024);
        }

        /// <summary>
        /// 将线上批发商城的宣传海报图片从腾讯云删除
        /// </summary>
        /// <param name="photoName"></param>
        /// <returns></returns>
        public DeleteResult DeletePfPosterImageToCos(DeletePosterImagePara para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.DeletePfPosterImageToCos, SerializeHelper.ResultToSerialize(para));

            return (DeleteResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 将图片上传到腾讯云。
        /// </summary>
        /// <param name="photoData"></param>
        public void UploadPfPhotoToCos(PhotoData photoData)
        {
            this.engine.CustomizeOutter.SendBlob(null, EMallInformationTypes.UploadPfPhotoToCos, SerializeHelper.ResultToSerialize(photoData), 2 * 1024 * 1024);
        }

        /// <summary>
        /// 获取待发货、部分发货的批发订货单各有多少笔
        /// </summary>
        /// <returns></returns>
        public PfCustomerOrderCount GetPfCustomerOrderCount()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetPfCustomerOrderCount, null);
            return CompactPropertySerializer.Default.Deserialize<PfCustomerOrderCount>(response, 0);
        }
    }
}
