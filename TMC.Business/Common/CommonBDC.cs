
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
    public class CommonBDC : BDCBase, ICommonBDC
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TMC.Business.ProductBDC"/> class.
        /// </summary>
        public CommonBDC()
            : base(BDCType.Common)
        { }

        #endregion

        #region Public Methods

        /// <summary>
        /// The get cities.
        /// </summary>
        /// <returns>
        /// The <see cref="OperationResult"/>.
        /// </returns>
        public OperationResult<IList<ICityDTO>> GetCities()
        {
            OperationResult<IList<ICityDTO>> operationResult = null;
            try
            {
                var commonDAC = (ICommonDAC)DACFactory.Instance.Create(DACType.Common);
                var cities = commonDAC.ReadCities();

                operationResult = cities != null
                                                      ? OperationResult<IList<ICityDTO>>.CreateSuccessResult(cities)
                                                      : OperationResult<IList<ICityDTO>>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Common.ErrorMessages.FailedToFetchCities));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IList<ICityDTO>>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IList<ICityDTO>>.CreateErrorResult(ex.Message, ex.StackTrace);
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
        
        #endregion
    }
}
