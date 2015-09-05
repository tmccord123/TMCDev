
namespace TMC.Shared
{
    using System.Collections.Generic;

    /// <summary>
    /// The VendorBDC interface.
    /// </summary>
    public interface ICommonBDC : IBusinessDomainComponent
    {
        /// <summary>
        /// The get cities.
        /// </summary>
        /// <returns>
        /// Fetch list of cities <see cref="OperationResult"/>.
        /// </returns>
        OperationResult<IList<ICityDTO>> GetCities();
        
    }
}