
namespace TMC.Shared
{
    using System.Collections.Generic;

    /// <summary>
    /// The CommonFacade interface.
    /// </summary>
    public interface ICommonFacade : IFacade
    {
        /// <summary>
        /// The get cities.
        /// </summary>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        OperationResult<IList<ICityDTO>> GetCities();

        /// <summary>
        /// The get categories.
        /// </summary>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        OperationResult<IList<ICategoryDTO>> GetCategories();
    }
}