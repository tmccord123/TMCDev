using System.Text.RegularExpressions;
using System;
using System.Reflection;
using System.Linq;

using TMC.Shared;
using System.Web;
using TMC.Shared.Factories;

namespace TMC.Shared
{
    /// <summary>
    /// Provides static utility methods for security
    /// Author : Nagarro
    /// </summary>
    public static class SecurityUtility
    {
        /// <summary>
        /// Returns user from the context.
        /// </summary>
        /// <returns></returns>
        public static IUserDTO LoggedInUser
        {
            get
            {
                IUserDTO retVal = null;

                if (HttpContext.Current.User != null && HttpContext.Current.User.Identity != null)
                {
                    retVal = ((JCCIdentity)HttpContext.Current.User.Identity).LoggedInUser;
                }

                return retVal;
            }
        }

        /// <summary>
        /// gets the username of logged in user
        /// </summary>
        public static string FullName
        {
            get
            {
                return LoggedInUser != null
                           ? (
                                 LoggedInUser.Individual != null
                                     ? LoggedInUser.Individual.FirstName + " " + LoggedInUser.Individual.LastName
                                     : LoggedInUser.UserName
                             )
                           : null;
            }
        }

        /// <summary>
        /// gets the username of logged in user
        /// </summary>
        public static string ActivityLogName
        {
            get
            {
                return LoggedInUser != null
                           ? LoggedInUser.UserID.ToString() + ":" + LoggedInUser.UserName
                           : null;
            }
        }

        /// <summary>
        /// gets the minimum rank for logged in user
        /// </summary>
        public static int MinimumRank
        {
            get
            {
                return LoggedInUser != null
                           ? LoggedInUser.MinimumRank
                           : 0;
            }
        }

        public static bool CheckEmployeeListAffiliateAuthorization(int clientId, int affiliationId)
        {
           /* bool retVal = false;

            var trainingFacade = (IEmployeeTrainingFacade)FacadeFactory.Instance.Create(FacadeType.EmployeeTraining);
            var employeePermission = trainingFacade.HasEmployeeListAccessForAffiliate(clientId, affiliationId);
            if (employeePermission.IsValid() && employeePermission.Data)
            {
                retVal = true;
            }

            return retVal;*/
            return true;
        }
    }
}