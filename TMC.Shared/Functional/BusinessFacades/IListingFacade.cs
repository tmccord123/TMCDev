
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
        OperationResult<IMediaDTO> CreateListingMedia(IFileDTO fileDto);
        OperationResult<long> CreateListingCategory(ICategoryDTO categoryDto);
        OperationResult<long> CreateListingServiceLocation(IServiceLocationDTO categoryDto);
        OperationResult<int> AddUpdateListingPaymentModes(IListingPaymentModesDTO paymentModes);
        OperationResult<IListingDTO> GetCategoriesByListingId(int listingId);
        OperationResult<IListingDTO> GetServiceLocationsByListingId(int listingId);
        OperationResult<IListingDTO> GetPaymentModesByListingId(int listingId);
        OperationResult<IListingDTO> GetMediasByListingId(int listingId);
        OperationResult<string> DeleteListingMedia(long listingMediaid);
        OperationResult<bool> DeleteListingCategory(long listingCategoryId);
        OperationResult<bool> DeleteListingServiceLocation(long listingServiceLocationId); 
    }
}
