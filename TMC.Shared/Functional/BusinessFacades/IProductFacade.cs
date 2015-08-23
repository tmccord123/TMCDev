
namespace TMC.Shared
{
    using System.Collections.Generic;

    public interface IProductFacade : IFacade
    {
        OperationResult<IList<IProductDTO>> GetAllProducts();

    }
}