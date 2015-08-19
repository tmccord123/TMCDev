using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace TMC.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmailDispatchStatus
    {
        /// <summary>
        /// Export 
        /// </summary>
        NotDone = 0,

        /// <summary>
        /// 
        /// </summary>
        Success = 1,

        /// <summary>
        /// 
        /// </summary>
        NoEmailId = 2,

        /// <summary>
        /// 
        /// </summary>
        InvalidEmailId = 3,

        /// <summary>
        /// 
        /// </summary>
        Failure = 4,
    }

    public enum EmailTemplate
    {
        /// <summary>
        ///  
        /// </summary>
        NoTemplate = 0,

        /// <summary>
        /// Email template id 4 for JCCSems
        /// </summary>
        ForgotPassword = 4,

        /// <summary>
        ///  Email template id 5 for JCCSems
        /// </summary>
        UserCreation = 5,

        /// <summary>
        ///  Email template id 6 for JCCSems
        /// </summary>
        ResetPassword = 6,

         /// <summary>
        ///  Email template id 7 for JCCSems
        /// </summary>
        AddtionalDetails = 7,

        /// <summary>
        ///  Email template id 8 for JCCSems
        /// </summary>
        CompanySubscription = 8,

        /// <summary>
        ///  Email template id 9 for JCCSems
        /// </summary>
        EndAffiliation = 9,

        /// <summary>
        /// Email template id 10 for JCCSems
        /// </summary>
        AcceptSubscription = 10,

        /// <summary>
        /// Email template id 11 for JCCSems
        /// </summary>
        RejectSubscription = 11,
        
        /// <summary>
        ///  Email template id 12 for JCCSems
        /// </summary>
        ApproveCompanySubscription = 12,

        /// <summary>
        ///  Email template id 13 for JCCSems
        /// </summary>
        DeclineCompanySubscription = 13,

        /// <summary>
        ///  Email template id 14 for JCCSems
        /// </summary>
        NewAffiliationRequestToNonSubscriber = 14,

        /// <summary>
        ///  Email template id 15 for JCCSems
        /// </summary>
        NewAffiliationRequestToSubscriber = 15,

        /// <summary>
        ///  Email template id 16 for JCCSems
        /// </summary>
        AcceptAffiliation = 16,

        /// <summary>
        ///  Email template id 17 for JCCSems
        /// </summary>
        DeclineAffiliation = 17,

        /// <summary>
        ///  Email template id 18 for JCCSems
        /// </summary>
        EndMyAffiliation = 18
    }
}