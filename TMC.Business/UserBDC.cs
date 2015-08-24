﻿
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
                                              ResourceConstants.Training.TrainingPlan.Index.Messages
                                                               .FailedToFetchTrainingCompanies));

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
            //return PersistSvr<Order>.GetAll().ToList();
        }
        #endregion
    
 
}
}
