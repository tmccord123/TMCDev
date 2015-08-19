// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileSourceFileTypeDTO.cs" company="Nagarro">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileSourceFileTypeDTO,
//   Author		: Nagarro
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for File Source File Type DTO,
    /// Author		: Nagarro
    /// </summary>
    public interface IFileSourceFileTypeDTO : IDTO
    {
        /// <summary>
        /// Gets or sets file source file type id
        /// </summary>
        int FileSourceFileTypeId { get; set; }

        /// <summary>
        /// Gets or sets file type id
        /// </summary>
        string FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets file source id
        /// </summary>
        int FileSourceId { get; set; }
    }
}
