
namespace TMC.Shared
{
    using System.Collections.Generic;

    /// <summary>
    /// The VendorBDC interface.
    /// </summary>
    public interface IListingBDC : IBusinessDomainComponent
    {
        /// <summary>
        /// The get listings.
        /// </summary>
        /// <param name="cityId">
        /// The city Id.
        /// </param>
        /// <param name="placeId">
        /// The place Id.
        /// </param>
        /// <param name="categoryId">
        /// The category Id.
        /// </param>
        /// <returns>
        /// List of listings <see cref="IList"/>.
        /// </returns>
        OperationResult<IList<IListingDTO>> GetListings(int cityId, string placeId, int categoryId);
       
    }
}