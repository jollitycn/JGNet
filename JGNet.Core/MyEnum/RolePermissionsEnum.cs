using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CErp.Core.MyEnum
{
    public enum RolePermissionsEnum
    {
        [Description("设置")]
        SetUp = 1000,
        
        [Description("规则设置")]
        RulesSetUp = 1100,
        
    }
}
