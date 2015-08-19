// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileExtensionTypeDTO.cs" company="Nagarro">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileExtensionTypeDTO,
//   Author		: Nagarro
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for File Extension Type DTO,
    /// Author		: Nagarro
    /// </summary>
    public interface IFileExtensionTypeDTO : IDTO
    {
        /// <summary>
        /// Gets or sets file extension type id
        /// </summary>
        int FileExtensionTypeId { get; set; }

        /// <summary>
        /// Gets or sets file extension type name
        /// </summary>
        string FileExtensionTypeName { get; set; }

        /// <summary>
        /// Gets or sets file extension display name
        /// </summary>
        string FileExtensionDisplayName { get; set; }

        /// <summary>
        /// Gets or sets file content type
        /// </summary>
        string FileContentType { get; set; }

        /// <summary>
        /// Gets or sets file extension Is active or not
        /// </summary>
        bool IsActive { get; set; }
    }
}
