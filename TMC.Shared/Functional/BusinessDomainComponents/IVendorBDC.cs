
using System.Collections.Generic;

namespace TMC.Shared
{
    /// <summary>
    /// The VendorBDC interface.
    /// </summary>
    public interface IVendorBDC : IBusinessDomainComponent
    {
        
        OperationResult<IList<IListingDTO>> GetlistingsByVendorId(int vendorId);
     
    }
}