
using System;
namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for User DTO,
    /// Author		: Nagarro
    /// </summary>
    public interface IUserDTO : IDTO
    {
        /// <summary>
        /// Gets or sets the User Id.
        /// </summary>
        int UserID { get; set; }

        /// <summary>
        /// Gets or sets the User Name.
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Gets or sets the locked date.
        /// </summary>
        DateTime? LockedDt { get; set; }

        /// <summary>
        /// Gets or sets the user locked.
        /// </summary>
        short? LockedInd { get; set; }

        /// <summary>
        /// Gets or sets the User status.
        /// </summary>
        short? UserStatus { get; set; }

        /// <summary>
        /// Gets or sets the Force user update.
        /// </summary>
        short? ForceUserUpdateInd { get; set; }

        /// <summary>
        /// Gets or sets the Is Plan active.
        /// </summary>
        bool IsJCCPlanActive { get; set; }

        /// <summary>
        /// Gets or sets the user password updated count.
        /// </summary>
        short? UserPasswordUpdatedCnt { get; set; }

        /// <summary>
        /// Gets or sets the user password updated date.
        /// </summary>
        DateTime? UserPasswordUpdatedDt { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        DateTime UpdatedDt { get; set; }

        /// <summary>
        /// Gets or sets the update by.
        /// </summary>
        string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the Created date.
        /// </summary>
        DateTime CreatedDt { get; set; }

        /// <summary>
        /// Gets or sets the Individual Id.
        /// </summary>
        int? IndividualId { get; set; }

        /// <summary>
        /// Gets or sets the Individual User information.
        /// </summary>
        IIndividualDTO Individual { get; set; }

        /// <summary>
        /// Gets or sets the Individual User.
        /// </summary>
        bool IsInvalidUser { get; set; }

        /// <summary>
        /// Gets or sets the minimum rank.
        /// </summary>
        int MinimumRank { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow all companies].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow all companies]; otherwise, <c>false</c>.
        /// </value>
        bool? AllowAllCompanies { get; set; }
    }
}
