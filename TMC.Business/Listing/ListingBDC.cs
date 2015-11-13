
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
    public class ListingBDC : BDCBase, IListingBDC
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TMC.Business.ListingBDC"/> class.
        /// </summary>
        public ListingBDC()
            : base(BDCType.Listing)
        { }

        #endregion

        #region Public Methods

        /// <summary>
        /// The get listings.
        /// </summary>
        /// <param name="cityId">
        /// The city Id.
        /// </param>
        /// <param name="placeId">
        /// The place Id.
        /// </param>
        /// <param name="categoryId">
        /// The category Id.
        /// </param>
        /// <returns>
        /// List of listings <see cref="IList"/>.
        /// </returns>
        public OperationResult<IList<IListingDTO>> GetListings(int cityId, string placeId, int categoryId)
        {
            OperationResult<IList<IListingDTO>> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);
                var listings = listingDAC.ReadListings(cityId, placeId, categoryId);

                operationResult = listings != null
                                                      ? OperationResult<IList<IListingDTO>>.CreateSuccessResult(listings)
                                                      : OperationResult<IList<IListingDTO>>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Listing.ErrorMessages.FailedToFetchListings));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IList<IListingDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IList<IListingDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult; 
        }

        public OperationResult<IListingDTO> GetlistingById(int listingId)
        {
            OperationResult<IListingDTO> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);
                var listing = listingDAC.GetListingById(listingId);

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

        public OperationResult<IListingDTO> GetContactsByListingId(int listingId)
        {
            OperationResult<IListingDTO> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);
                var listing = listingDAC.GetContactsByListingId(listingId);

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

        public OperationResult<IListingDTO> GetCategoriesByListingId(int listingId)
        {
            OperationResult<IListingDTO> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);
                var listing = listingDAC.GetCategoriesByListingId(listingId);

                operationResult = listing != null
                                                      ? OperationResult<IListingDTO>.CreateSuccessResult(listing)
                                                      : OperationResult<IListingDTO>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));//todo

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

        public OperationResult<IListingDTO> GetServiceLocationsByListingId(int listingId)
        {
            OperationResult<IListingDTO> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);
                var listing = listingDAC.GetServiceLocationsByListingId(listingId);

                operationResult = listing != null
                                                      ? OperationResult<IListingDTO>.CreateSuccessResult(listing)
                                                      : OperationResult<IListingDTO>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));//todo

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

        public OperationResult<IListingDTO> GetPaymentModesByListingId(int listingId)
        {
            OperationResult<IListingDTO> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);
                var listing = listingDAC.GetPaymentModesByListingId(listingId);

                operationResult = listing != null
                                                      ? OperationResult<IListingDTO>.CreateSuccessResult(listing)
                                                      : OperationResult<IListingDTO>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));//todo

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

        public OperationResult<IListingDTO> GetMediasByListingId(int listingId)
        {
            OperationResult<IListingDTO> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);
                var listing = listingDAC.GetMediasByListingId(listingId);

                operationResult = listing != null
                                                      ? OperationResult<IListingDTO>.CreateSuccessResult(listing)
                                                      : OperationResult<IListingDTO>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));//todo

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

        public OperationResult<IList<IListingDTO>> GetListingsByUserId(int userId)
        {
            OperationResult<IList<IListingDTO>> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);
                var listings = listingDAC.GetListingsByUserId(userId);

                operationResult = listings != null
                                                      ? OperationResult<IList<IListingDTO>>.CreateSuccessResult(listings)
                                                      : OperationResult<IList<IListingDTO>>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Listing.ErrorMessages.FailedToFetchListings));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IList<IListingDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IList<IListingDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult;
        }

        /// <summary>
        /// The get categories.
        /// </summary>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        public OperationResult<IList<ICategoryDTO>> GetCategories()
        {
            OperationResult<IList<ICategoryDTO>> operationResult = null;
            try
            {
                var commonDAC = (ICommonDAC)DACFactory.Instance.Create(DACType.Common);
                var categories = commonDAC.ReadCategories();

                operationResult = categories != null
                                                      ? OperationResult<IList<ICategoryDTO>>.CreateSuccessResult(categories)
                                                      : OperationResult<IList<ICategoryDTO>>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Common.ErrorMessages.FailedToFetchCategories));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IList<ICategoryDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IList<ICategoryDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult;
        }

        public OperationResult<IListingDTO> CreateListing(IListingDTO listingDto)
        {
            OperationResult<IListingDTO> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);

                var resultListingDto = listingDto.ListingId > 0
                  ? listingDAC.UpdateListing(listingDto)
                  : listingDAC.CreateListing(listingDto); 
                operationResult = resultListingDto != null
                                                      ? OperationResult<IListingDTO>.CreateSuccessResult(resultListingDto)
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


        public OperationResult<long> CreateListingCategory(ICategoryDTO categoryDto)
        {
            OperationResult<long> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);

                var resultListing =  listingDAC.CreateListingCategory(categoryDto);
                operationResult = resultListing != null
                                                      ? OperationResult<long>.CreateSuccessResult(resultListing)
                                                      : OperationResult<long>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<long>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);//todo
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<long>.CreateErrorResult(ex.Message, ex.StackTrace);//todo
            }
            return operationResult;
        }

        public OperationResult<int> AddUpdateListingPaymentModes(IListingPaymentModesDTO paymentModes)
        {
            OperationResult<int> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);

                var resultListing = listingDAC.AddUpdateListingPaymentModes(paymentModes);
                operationResult = resultListing != null
                                                      ? OperationResult<int>.CreateSuccessResult(resultListing)
                                                      : OperationResult<int>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<int>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);//todo
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<int>.CreateErrorResult(ex.Message, ex.StackTrace);//todo
            }
            return operationResult;
        }

        public OperationResult<long> CreateListingServiceLocation(IServiceLocationDTO serviceLocationDto)
        {
            OperationResult<long> operationResult = null;
            try
            {
                var listingDAC = (IListingDAC)DACFactory.Instance.Create(DACType.Listing);

                var resultListing = listingDAC.CreateListingServiceLocation(serviceLocationDto);
                operationResult = resultListing != null
                                                      ? OperationResult<long>.CreateSuccessResult(resultListing)
                                                      : OperationResult<long>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));//todo

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<long>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);//todo
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<long>.CreateErrorResult(ex.Message, ex.StackTrace);//todo
            }
            return operationResult;
        }

        #endregion
    }
}
