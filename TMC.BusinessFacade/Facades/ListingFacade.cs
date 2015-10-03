﻿namespace TMC.BusinessFacade
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
            var vendorBDC = (IVendorBDC) BDCFactory.Instance.Create(BDCType.Vendor);
            return vendorBDC.GetlistingById(listingId);
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
    }
}