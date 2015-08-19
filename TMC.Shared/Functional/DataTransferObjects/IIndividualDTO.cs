
using System;
using TMC.Shared;

namespace TMC.Shared
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines a contract for Individual DTO,
    /// Author		: Nagarro
    /// </summary>
    public interface IIndividualDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the Individual Id
        /// </summary>
        int IndividualID { get; set; }

        /// <summary>
        /// Gets or sets the Organization Location Id
        /// </summary>
        int OrganizationLocationId { get; set; }

        /// <summary>
        /// Gets or sets the Name Title
        /// </summary>
        string NameTitle { get; set; }

        /// <summary>
        /// Gets or sets the First Name
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Last Name
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Primary Email
        /// </summary>
        string PrimaryEmail { get; set; }

        /// <summary>
        /// Gets or sets the Secondary Email
        /// </summary>
        string SecondaryEmail { get; set; }

        /// <summary>
        /// Gets or sets the Job title
        /// </summary>
        string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the Office phone
        /// </summary>
        string OfficePhone { get; set; }

        /// <summary>
        /// Gets or sets the Home Phone
        /// </summary>
        string HomePhone { get; set; }

        /// <summary>
        /// Gets or sets the Cellular Phone
        /// </summary>
        string CellularPhone { get; set; }

        /// <summary>
        /// Gets or sets the Created date
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the Updated date
        /// </summary>
        DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the Updated by
        /// </summary>
        string UpdatedBy { get; set; }

        /// <summary>
        /// Gets the Full Name
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// Gets or sets the individual contact types.
        /// </summary>
        IList<IIndividualContactTypeDTO> IndividualContactTypes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is primary contact.
        /// </summary>
        bool IsPrimaryContact { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether override primary contact.
        /// </summary>
        bool OverridePrimaryContact { get; set; }

        /// <summary>
        /// OfficeDirectLine
        /// </summary>
        string OfficeDirectLine { get; set; }
    }
}
