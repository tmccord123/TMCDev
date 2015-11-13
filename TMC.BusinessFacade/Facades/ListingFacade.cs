namespace TMC.BusinessFacade
{
    using System.Collections.Generic;
    using System.Data;

    using TMC.Shared;

    /// <summary>
    /// The user facade.
    /// </summary>
    public class ListingFacade : FacadeBase, IListingFacade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFacade"/> class.
        /// </summary>
        public ListingFacade()
            : base(FacadeType.Listing)
        {

      
        }

        public OperationResult<IListingDTO> GetlistingById(int listingId)
        {
            var vendorBDC = (IListingBDC) BDCFactory.Instance.Create(BDCType.Listing);
            return vendorBDC.GetlistingById(listingId);
        }

        public OperationResult<IListingDTO> GetContactsByListingId(int listingId)
        {
            var vendorBDC = (IListingBDC) BDCFactory.Instance.Create(BDCType.Listing);
            return vendorBDC.GetContactsByListingId(listingId);
        }

        public OperationResult<IListingDTO> GetCategoriesByListingId(int listingId)
        {
            var vendorBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return vendorBDC.GetCategoriesByListingId(listingId);
        }

        public OperationResult<IListingDTO> GetServiceLocationsByListingId(int listingId)
        {
            var vendorBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return vendorBDC.GetServiceLocationsByListingId(listingId);
        }

        public OperationResult<IListingDTO> GetPaymentModesByListingId(int listingId)
        {
            var vendorBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return vendorBDC.GetPaymentModesByListingId(listingId);
        }

        public OperationResult<IListingDTO> GetMediasByListingId(int listingId)
        {
            var vendorBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return vendorBDC.GetMediasByListingId(listingId);
        }


        public OperationResult<IListingDTO> CreateListing(IListingDTO  listingDto)
        {
            var listingBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return listingBDC.CreateListing(listingDto);
        }

        public OperationResult<long> CreateListingCategory(ICategoryDTO categoryDto)
        {
            var listingBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return listingBDC.CreateListingCategory(categoryDto);
        }

        public OperationResult<IListingPaymentModesDTO> AddUpdateListingPaymentModes(IListingPaymentModesDTO paymentModes)
        {
            var listingBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return listingBDC.AddUpdateListingPaymentModes(paymentModes);
        }
 


        public OperationResult<long> CreateListingServiceLocation(IServiceLocationDTO serviceLocationDto)
        {
            var listingBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return listingBDC.CreateListingServiceLocation(serviceLocationDto);
        }

        public OperationResult<IList<IListingDTO>> GetlistingsByVendorId(int vendorId)
        {

            var vendorBDC = (IVendorBDC)BDCFactory.Instance.Create(BDCType.Vendor);
            return vendorBDC.GetlistingsByVendorId(vendorId);
        }

        /// <summary>
        /// The get listings.
        /// </summary>
        /// <param name="cityId">
        /// The city id.
        /// </param>
        /// <param name="placeId">
        /// The place id.
        /// </param>
        /// <param name="categoryId">
        /// The category id.
        /// </param>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        public OperationResult<IList<IListingDTO>> GetListings(int cityId, string placeId, int categoryId)
        {
            var listingBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return listingBDC.GetListings(cityId, placeId, categoryId);
        }

        /// <summary>
        /// The get listings.
        /// </summary>
        /// <param name="userId">
        /// The User id.
        /// </param>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        public OperationResult<IList<IListingDTO>> GetListingsByUserId(int userId)
        {
            var listingBDC = (IListingBDC)BDCFactory.Instance.Create(BDCType.Listing);
            return listingBDC.GetListingsByUserId(userId);
        }
    }
}