
using System.Collections.Generic;

namespace TMC.Shared
{
    /// <summary>
    /// The VendorBDC interface.
    /// </summary>
    public interface IVendorBDC : IBusinessDomainComponent
    {
        OperationResult<IListingDTO> GetlistingById(int listingId);
        OperationResult<IList<IListingDTO>> GetlistingsByVendorId(int vendorId);
        OperationResult<IListingDTO> CreateListing(IListingDTO listingDto);
    }
}