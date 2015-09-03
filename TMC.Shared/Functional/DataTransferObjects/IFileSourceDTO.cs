// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileSourceDTO.cs" company="TMC">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileSourceDTO,
//   Author		: TMC
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    using System;

    /// <summary>
    /// Defines a contract for File Source DTO,
    /// Author		: TMC
    /// </summary>
    public interface IFileSourceDTO : IDTO
    {
        /// <summary>
        /// Gets or sets file source id
        /// </summary>
        int FileSourceId { get; set; }

        /// <summary>
        /// Gets or sets file source name
        /// </summary>
        string FileSourceName { get; set; }
    }
}
