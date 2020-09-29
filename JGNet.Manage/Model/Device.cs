using JGNet.Manage;
using System;
using System.Collections.Generic;

using System.Text;


namespace JGNet.Manage
{
    [Serializable]
    public class Device: CJBasic.Serialization.AgileConfiguration
    {
        /// <summary>
        /// 挂单明细列表
        /// </summary>
        public List<Camera> CameraList { get; set; }

        public String Name { get; set; }
        public String Model { get; set; }
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


    [Serializable]
    public class Camera
    {
        public String Name { get; set; }
        public String Type { get; set; }
        public String Channel { get; set; } 

    }

 
}
