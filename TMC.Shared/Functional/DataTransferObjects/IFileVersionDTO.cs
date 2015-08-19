// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileVersionDTO.cs" company="Nagarro">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileVersionDTO,
//   Author		: Nagarro
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    using System;

    /// <summary>
    /// Defines a contract for File Version DTO,
    /// Author		: Nagarro
    /// </summary>
    public interface IFileVersionDTO : IDTO
    {
        /// <summary>
        /// Gets or sets file version id
        /// </summary>
        long FileVersionId { get; set; }

        /// <summary>
        /// Gets or sets file id for file version
        /// </summary>
        int FileId { get; set; }

        /// <summary>
        /// Gets or sets original file name
        /// </summary>
        string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or sets file name by which file is saved at server
        /// </summary>
        string ServerFileName { get; set; }

        /// <summary>
        /// Gets or sets server path where file is saved
        /// </summary>
        string ServerPath { get; set; }

        /// <summary>
        /// Gets or sets file extension type id
        /// </summary>
        int FileExtensionTypeId { get; set; }

        /// <summary>
        /// Gets or sets type id of file extension
        /// </summary>
        IFileExtensionTypeDTO FileExtensionType { get; set; }

        /// <summary>
        /// Gets or sets whether file record is active or not
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets detail of user by whom file is created
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets date time when file is being created
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets detail of user by whom file is last updated
        /// </summary>
        string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets date time when file is being last updated
        /// </summary>
        DateTime UpdatedOn { get; set; }
    }
}
