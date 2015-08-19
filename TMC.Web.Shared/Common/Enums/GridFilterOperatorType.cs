using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace TMC.Web.Shared
{
    
    public enum GridFilterOperatorType
    {
        None = 0,

        Contains = 1,

        Isequalto = 2,

        Isbefore = 3,

        Isafter = 4
    }
}