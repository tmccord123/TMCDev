
namespace TMC.BusinessFacade
{
    using System.Collections.Generic;

    using TMC.Shared;
    using TMC.Shared.Factories;

    /// <summary>
    /// The user facade.
    /// </summary>
    public class ProductFacade : FacadeBase, IProductFacade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFacade"/> class.
        /// </summary>
        public ProductFacade()
            : base(FacadeType.Product)
        {
        }

        /// <summary>
        /// The get all products.
        /// </summary>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        public OperationResult<IList<IProductDTO>> GetAllProducts()
        {
            var productBDC = (IProductBDC)BDCFactory.Instance.Create(BDCType.Product);
            return productBDC.GetAllProducts();
        }
    }
}