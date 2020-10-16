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
    public class EMallServerProxy
    {
        protected IRapidPassiveEngine engine;

        public EMallServerProxy(IRapidPassiveEngine _engine) 
        {
            this.engine = _engine;
        }
        
        /// <summary>
        /// 获取线上店铺信息
        /// </summary>
        /// <returns></returns>
        public EMall GetEMall()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEMall, null);
            return CompactPropertySerializer.Default.Deserialize<EMall>(response, 0);
        }

        /// <summary>
        /// 获取线上店铺商场logo
        /// </summary>
        /// <returns></returns>
        public byte[] GetEMallLogo()
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.GetEMallLogo, null);

            return response;
        }

        /// <summary>
        /// 修改线上店铺信息。
        /// </summary>
        /// <returns></returns>
        public UpdateResult UpdateEMall(EMall eMall)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpdateEMall, SerializeHelper.ResultToSerialize(eMall));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        ///  修改线上店铺商场logo
        /// </summary>
        /// <returns></returns>
        public void UpdateEMallLogo(UpdateEMallLogoPara para)
        {
            this.engine.CustomizeOutter.SendBlob(null, EMallInformationTypes.UpdateEMallLogo, SerializeHelper.ResultToSerialize(para), 10 * 1024 * 1024);
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
        public UpdateResult UpateEmCostumeInfo(EmCostumeInfo para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.UpateEmCostumeInfo, SerializeHelper.ResultToSerialize(para));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
        }

        /// <summary>
        /// 上架
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public UpdateResult ShelvesEmCostumeInfo(EmCostumeInfo para)
        {
            byte[] response = this.engine.CustomizeOutter.Query(EMallInformationTypes.ShelvesEmCostumeInfo, SerializeHelper.ResultToSerialize(para));
            return (UpdateResult)SerializeHelper.ByteArrayToInt(response);
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
    }
}
