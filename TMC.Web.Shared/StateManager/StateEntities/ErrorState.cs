using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Represents error information.
    /// </summary>
    public class ErrorState : StateEntityBase
    {
        public string ErrorMessage { get; set; }

        public string StackTrace { get; set; }
    }
}