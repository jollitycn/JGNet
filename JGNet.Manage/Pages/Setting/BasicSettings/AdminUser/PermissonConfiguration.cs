using System;
using System.Collections.Generic;

using System.Text;


namespace JGNet.Common
{
   /// <summary>
   /// 所有权限
   /// </summary>
    public class PermissonConfiguration : CJBasic.Serialization.AgileConfiguration
    { 
        public String Version { get; set; }
        public List<String> Names{ get; set; }
    }

}
