// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFolderDTO.cs" company="Nagarro">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFolderDTO,
//   Author		: Nagarro
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    using System;

    /// <summary>
    /// Defines a contract for Folder DTO,
    /// Author		: Nagarro
    /// </summary>
    public interface IFolderDTO : IDTO
    {
        /// <summary>
        /// Gets or sets folder id
        /// </summary>
        int FolderId { get; set; }

        /// <summary>
        /// Gets or sets folder name
        /// </summary>
        string FolderName { get; set; }

        /// <summary>
        /// Gets or sets description for folder
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets parent folder for current folder if any
        /// </summary>
        string ParentFolderId { get; set; }

        /// <summary>
        /// Gets or sets whether folder is active or not
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets date time when folder is being created
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets date time when folder is being last updated
        /// </summary>
        DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets detail of user by whom folder is last updated
        /// </summary>
        string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets detail of user by whom folder is created
        /// </summary>
        string CreatedBy { get; set; }
    }
}
