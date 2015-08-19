// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileSourceDTO.cs" company="Nagarro">
//   
// </copyright>
// <summary>
//   Defines a contract for interface IFileSourceDTO,
//   Author		: Nagarro
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    using System;

    /// <summary>
    /// Defines a contract for File Source DTO,
    /// Author		: Nagarro
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
