using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for internal notice,
    /// Author: Nagarro
    /// </summary>
    public interface IInternalNotification : INotification
    {
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        int ID { get; }
    }
}