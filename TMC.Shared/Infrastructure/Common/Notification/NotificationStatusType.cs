using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotificationStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        Initiated = 0,

        /// <summary>
        /// 
        /// </summary>
        InProgress = 1,

        /// <summary>
        /// 
        /// </summary>
        Sent = 2,

        /// <summary>
        /// 
        /// </summary>
        Failed = 3,

        /// <summary>
        /// 
        /// </summary>
        Deferred = 4,

        /// <summary>
        /// 
        /// </summary>
        SentWithErrors = 5,
    }
}