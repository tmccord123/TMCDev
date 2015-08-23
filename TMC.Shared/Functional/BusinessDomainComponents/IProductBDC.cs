using System.Collections.Generic;
using System.Data;
namespace TMC.Shared
{
   

    /// <summary>
    /// The AffiliationBDC interface.
    /// </summary>
    public interface IProductBDC : IBusinessDomainComponent
    {
        OperationResult<IList<IProductDTO>> GetAllProducts();
    }
}