// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileTypeDTO.cs" company="Nagarro">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileTypeDTO,
//   Author		: Nagarro
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    using System;

    /// <summary>
    /// Defines a contract for File Type DTO,
    /// Author		: Nagarro
    /// </summary>
    public interface IFileTypeDTO : IDTO
    {
        /// <summary>
        /// Gets or sets file type id
        /// </summary>
        int FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets file type name
        /// </summary>
        string FileTypeName { get; set; }

        /// <summary>
        /// Gets or sets file type display name
        /// </summary>
        string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of file type
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// File Source File Type mapping Id
        /// </summary>
        int FileSourceFileTypeId { get; set; }
    }
}
