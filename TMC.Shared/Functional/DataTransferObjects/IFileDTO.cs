// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileDTO.cs" company="TMC">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileDTO,
//   Author		: TMC
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
        long FileId { get; set; }
        long ListingId { get; set; }
        short FileExtensionId { get; set; }
        short FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets file title
        /// </summary>
        string FileTitle { get; set; }

        /// <summary>
        /// Gets or sets file description
        /// </summary>
        string Description { get; set; }
        string OriginalFileName { get; set; }
        string ServerFileName { get; set; }
        string ServerPath { get; set; }

         

        /// <summary>
        /// Gets or sets file type detail
        /// </summary>
        IFileTypeDTO FileType { get; set; }

       

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
        long UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets detail of user by whom file is created
        /// </summary>
        long CreatedBy { get; set; }
 
    }
}
