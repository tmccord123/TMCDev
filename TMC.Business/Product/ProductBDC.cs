
namespace TMC.Business
{
    #region Namespaces

    using System;
    using System.Collections.Generic;

    using TMC.Shared;


    #endregion

    /// <summary>
    /// Class ProjectEmployeeBDC.
    /// </summary>
    public class ProductBDC : BDCBase, IProductBDC
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBDC"/> class.
        /// </summary>
        public ProductBDC()
            : base(BDCType.Product)
        { }

        #endregion

        #region Public Methods

        public OperationResult<IList<IProductDTO>> GetAllProducts()
        {

            OperationResult<IList<IProductDTO>> operationResult = null;
            try
            {
                var productDAC = (IProductDAC)DACFactory.Instance.Create(DACType.Product);
                var products = productDAC.ReadAllProducts();

                operationResult = products != null
                                                      ? OperationResult<IList<IProductDTO>>.CreateSuccessResult(products)
                                                      : OperationResult<IList<IProductDTO>>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IList<IProductDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IList<IProductDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult;
            //return PersistSvr<Order>.GetAll().ToList();
        }
        #endregion
    }
}
