
namespace TMC.Shared
{
    using System.Collections.Generic;

    public interface IVendorFacade : IFacade
    {
        OperationResult<IUserDTO> GetVendorById(int vendorId);

    }
}