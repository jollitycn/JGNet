using JGNet.Manage;
using System;
using System.Collections.Generic;

using System.Text;


namespace JGNet.Manage
{
    [Serializable]
    public class HangedOrderBag: CJBasic.Serialization.AgileConfiguration
    {
        /// <summary>
        /// 挂单明细列表
        /// </summary>
        public List<HangedOrder> HangedOrderList { get; set; }

        private int maxHangedCount = 10;
        /// <summary>
        /// 最大可挂单的数量
        /// </summary>
        public int MaxHangedCount
        {
            get { return this.maxHangedCount; }
            set { this.maxHangedCount = value; }
        }


    }


    [Serializable]
    public class HangedOrder 
    {
        public String SizeDisplayName { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
        public string MemberID { get; set; }

        /// <summary>
        /// 会员姓名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal TotalMoney { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 导购ID
        /// </summary>
        public string GuideID { get; set; }


        public string GuideName
        {
            get
            {
                if (this.GuideID=="-1")
                {
                    return "无";
                }
                return GlobalCache.GetUserName(this.GuideID);
            }
        }

        /// <summary>
        /// 挂单明细列表
        /// </summary>
        public List<RetailDetail> DetailList { get; set; }

        private DateTime createTime = DateTime.Now;
        /// <summary>
        /// 挂单时间
        /// </summary>
        public DateTime CreateTime
        {
            get { return this.createTime; }
            set { this.createTime = value; }
        }

    }

 
}
