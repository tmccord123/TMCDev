
namespace TMC.Shared
{
    using System.Collections.Generic;

    public interface IListingFacade : IFacade
    {
        OperationResult<IListingDTO> GetlistingById(int listingId);
        OperationResult<IListingDTO> GetContactsByListingId(int listingId);
        OperationResult<IList<IListingDTO>> GetlistingsByVendorId(int vendorId);
        
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
        
        OperationResult<IList<IListingDTO>> GetListingsByUserId(int useId);

        OperationResult<IListingDTO> CreateListing(IListingDTO listingDto);
    }
}
