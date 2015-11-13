
namespace TMC.Shared
{
    #region NameSpaces

    using System.Collections.Generic;

    #endregion
    /// <summary>
    /// File DAC interface.
    /// </summary>
    public interface IListingDAC : IDataAccessComponent
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
        IList<IListingDTO> ReadListings(int cityId, string placeId, int categoryId);
        IList<IListingDTO> GetListingsByUserId(int userId);

        IListingDTO GetListingById(int listingId);
        IListingDTO GetContactsByListingId(int listingId);
        IListingDTO GetCategoriesByListingId(int listingId);
        IListingDTO GetServiceLocationsByListingId(int listingId);
        IListingDTO GetPaymentModesByListingId(int listingId);
        IListingDTO GetMediasByListingId(int listingId);

        IListingDTO CreateListing(IListingDTO listingDto);
        long CreateListingCategory(ICategoryDTO categoryDto);
        long CreateListingServiceLocation(IServiceLocationDTO serviceLocationDto);
        int AddUpdateListingPaymentModes(IListingPaymentModesDTO categoryDto);

        IListingDTO UpdateListing(IListingDTO listingDto);

    }
}
