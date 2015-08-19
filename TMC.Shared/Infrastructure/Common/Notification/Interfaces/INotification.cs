using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for a notice,
    /// Author: Nagarro
    /// </summary>
    public interface INotification
    {
        /// <summary>
        /// Gets the type of the notice.
        /// </summary>
        /// <value>The type of the notice.</value>
        NotificationType NotificationType { get; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        NotificationStatusType Status { get; }

        /// <summary>
        /// Initializes the dispatching process.
        /// </summary>
        void PreDispatch();

        /// <summary>
        /// Validates and dispatches this notice.
        /// </summary>
        void Dispatch();

        /// <summary>
        /// Posts process the notice after dispatching.
        /// </summary>
        void PostDispatch();

        /// <summary>
        /// Determines whether this instance is valid.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </returns>
        bool IsValid();
    }
}