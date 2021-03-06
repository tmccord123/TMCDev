﻿
namespace TMC.Shared
{
    #region NameSpaces

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// File DAC interface.
    /// </summary>
    public interface ICommonDAC : IDataAccessComponent
    {
        /// <summary>
        /// The get cities.
        /// </summary>
        /// <returns>
        /// List of cities <see cref="IList"/>.
        /// </returns>
        IList<ICityDTO> ReadCities();

        /// <summary>
        /// The get categories.
        /// </summary>
        /// <returns>
        /// Fetch list of categories <see cref="IList"/>.
        /// </returns>
        IList<ICategoryDTO> ReadCategories();
    }
}
