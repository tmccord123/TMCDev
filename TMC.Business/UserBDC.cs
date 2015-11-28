

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
    public class UserBDC : BDCBase, IUserBDC
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TMC.Business.ProductBDC"/> class.
        /// </summary>
        public UserBDC()
            : base(BDCType.User)
        { }

        #endregion

        #region Public Methods

        public OperationResult<IUserDTO> GetUserById(int userId)
        {

            OperationResult<IUserDTO> operationResult = null;
            try
            {
                var userDAC = (IUserDAC)DACFactory.Instance.Create(DACType.User);
                var user = userDAC.GetUserById(userId);

                operationResult = user != null
                                                      ? OperationResult<IUserDTO>.CreateSuccessResult(user)
                                                      : OperationResult<IUserDTO>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.User.ErrorMessages.FailedToFetchUser));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IUserDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IUserDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult; 
        }



        public OperationResult<long> CreateUser(IUserDTO userDto)
        {
            OperationResult<long> operationResult = null;
            try
            {
                var userDAC = (IUserDAC)DACFactory.Instance.Create(DACType.User);

                var resultUserDto = userDto.UserId > 0
                  ? userDAC.UpdateUser(userDto)
                  : userDAC.CreateUser(userDto);
                operationResult = resultUserDto != null
                                                      ? OperationResult<long>.CreateSuccessResult(resultUserDto)
                                                      : OperationResult<long>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.Vendor.ErrorMessages.FailedToFetchListing));//todo messages

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<long>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<long>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult;
        }

        public OperationResult<IUserDTO> GetClientById(int clientId)
        {

            OperationResult<IUserDTO> operationResult = null;
            try
            {
                var userDAC = (IUserDAC)DACFactory.Instance.Create(DACType.User);
                var user = userDAC.GetUserById(clientId);

                operationResult = user != null
                                                      ? OperationResult<IUserDTO>.CreateSuccessResult(user)
                                                      : OperationResult<IUserDTO>.CreateFailureResult(
                                                       ResourceUtility.GetCaptionFor(
                                              ResourceConstants.User.ErrorMessages.FailedToFetchUser));

            }
            catch (DACException dacEx)
            {
                operationResult = OperationResult<IUserDTO>.CreateErrorResult(dacEx.Message, dacEx.StackTrace);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                operationResult = OperationResult<IUserDTO>.CreateErrorResult(ex.Message, ex.StackTrace);
            }
            return operationResult; 
        }


        #endregion
    
 
}
}
