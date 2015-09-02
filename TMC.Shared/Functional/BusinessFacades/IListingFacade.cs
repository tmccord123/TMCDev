
namespace TMC.Shared
{
    using System.Collections.Generic;

    public interface IListingFacade : IFacade
    {
        OperationResult<IListingDTO> GetlistingById(int listingId);
        OperationResult<IList<IListingDTO>> GetlistingsByVendorId(int vendorId);
    }
}