using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Shared
{
    public enum NotificationType
    {
        /// <summary>
        /// Undefined
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Email notice
        /// </summary>
        [QualifiedTypeName("TMC.Shared.dll", "TMC.Shared.EmailNotification")]
        Email = 1,

        /// <summary>
        /// SMS notice
        /// </summary>
        [QualifiedTypeName("TMC.Shared.dll", "TMC.Shared.SMSNotice")]
        SMS = 2
    }
}