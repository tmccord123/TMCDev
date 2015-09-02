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
            var vendorBDC = (IVendorBDC) BDCFactory.Instance.Create(BDCType.Vendor);
            return vendorBDC.GetlistingById(listingId);
        }

        public OperationResult<IList<IListingDTO>> GetlistingsByVendorId(int vendorId)
        {

            var vendorBDC = (IVendorBDC)BDCFactory.Instance.Create(BDCType.Vendor);
            return vendorBDC.GetlistingsByVendorId(vendorId);
        }
    }
}