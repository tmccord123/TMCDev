// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileSourceFileTypeDTO.cs" company="TMC">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileSourceFileTypeDTO,
//   Author		: TMC
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for File Source File Type DTO,
    /// Author		: TMC
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
