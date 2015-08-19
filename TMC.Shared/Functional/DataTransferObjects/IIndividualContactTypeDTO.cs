using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Shared
{
    /// <summary>
    /// Individual Contact Type DTO interface.
    /// </summary>
    public interface IIndividualContactTypeDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the Individual contact type Id
        /// </summary>
        int IndividualContactTypeId { get; set; }

        /// <summary>
        /// Gets or sets the Individual Id
        /// </summary>
        int IndividualId { get; set; }

        /// <summary>
        /// Gets or sets the Contact Type Id
        /// </summary>
        int ContactTypeId { get; set; }

        /// <summary>
        /// Gets or sets the Contact Type Name
        /// </summary>
        string ContactTypeName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is active.
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is primary.
        /// </summary>
        bool IsPrimary { get; set; }
    }
}
