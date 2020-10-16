using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace CJBasic.CJBasic.Helpers
{
    public class ManagementHelper
    {
        /// <summary>
        /// 获取网卡物理地址
        /// </summary>
        /// <returns></returns>
        public static string getMacAddr_Local()
        {
            string madAddr = null;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc2 = mc.GetInstances();
            foreach (ManagementObject mo in moc2)
            {
                if (Convert.ToBoolean(mo["IPEnabled"]) == true)
                {
                    madAddr = mo["MacAddress"].ToString();
                    madAddr = madAddr.Replace(':', '-');
                }
                mo.Dispose();
            }
            return madAddr;
        }
    }
}
