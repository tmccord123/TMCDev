
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
    public class VendorBDC : BDCBase, IVendorBDC
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TMC.Business.ProductBDC"/> class.
        /// </summary>
        public VendorBDC()
            : base(BDCType.Vendor)
        { }

        #endregion

        #region Public Methods

        public OperationResult<IListingDTO> GetlistingById(int listingId)
        {
            OperationResult<IListingDTO> operationResult = null;
            try
            {
                var vendorDAC = (IVendorDAC)DACFactory.Instance.Create(DACType.Vendor);
                var listing = vendorDAC.GetListingById(listingId);

                operationResult = listing != null
                                                      ? OperationResult<IListingDTO>.CreateSuccessResult(listing)
                                                      : OperationResult<IListingDTO>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IListingDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IListingDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult; 
        }

        public OperationResult<IList<IListingDTO>> GetlistingsByVendorId(int vendorId)
        {
            throw new NotImplementedException();
        }     
        
        #endregion


      
    }
}
