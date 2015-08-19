// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileDTO.cs" company="Nagarro">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileDTO,
//   Author		: Nagarro
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    using System;
    using System.Web;

    /// <summary>
    /// The FileDTO interface.
    /// </summary>
    public interface IFileDTO : IDTO
    {
        /// <summary>
        /// Gets or sets file id
        /// </summary>
        int FileId { get; set; }

        /// <summary>
        /// Gets or sets file title
        /// </summary>
        string FileTitle { get; set; }

        /// <summary>
        /// Gets or sets file description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets file type id
        /// </summary>
        int? FileSourceFileTypeId { get; set; }

        /// <summary>
        /// Gets or sets file type detail
        /// </summary>
        IFileTypeDTO FileType { get; set; }

        /// <summary>
        /// Gets or sets folder id
        /// </summary>
        int? FolderId { get; set; }

        /// <summary>
        /// Gets or sets folder detail
        /// </summary>
        IFolderDTO Folder { get; set; }

        /// <summary>
        /// Gets or sets whether file is active or not
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets date time when file is being created
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets date time when file is being last updated
        /// </summary>
        DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets detail of user by whom file is last updated
        /// </summary>
        string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets detail of user by whom file is created
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the file version DTO.
        /// </summary>
        IFileVersionDTO FileVersionDTO { get; set; }

        /// <summary>
        /// Gets or sets the posted file.
        /// </summary>
        HttpPostedFileBase PostedFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is actual file updated.
        /// </summary>
        bool IsActualFileUpdated { get; set; }
    }
}
