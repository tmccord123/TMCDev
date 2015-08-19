using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for email notice,
    /// Author: Nagarro
    /// </summary>
    public interface IEmailNotification : INotification
    {
        /// <summary>
        /// Gets or sets From.
        /// </summary>
        /// <value>From.</value>
        string FromAddress { get; set; }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        /// <value>To.</value>
        string ToAddresses { get; set; }

        /// <summary>
        /// Gets or sets Cc.
        /// </summary>
        /// <value>Cc.</value>
        string CcAddresses { get; set; }

        /// <summary>
        /// Gets or sets Bcc.
        /// </summary>
        /// <value>Cc.</value>
        string BccAddresses { get; set; }

        /// <summary>
        /// Gets or sets Subject.
        /// </summary>
        /// <value>Subject.</value>
        string Subject { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        /// <value>Subject.</value>
        string Body { get; set; }

        /// <summary>
        /// Gets DispatchStatus.
        /// </summary>
        /// <value>DispatchStatus.</value>
        EmailDispatchStatus DispatchStatus { get; }
    }
}