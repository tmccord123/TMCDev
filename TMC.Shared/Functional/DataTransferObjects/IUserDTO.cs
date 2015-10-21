
using System;
namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for User DTO,
    /// Author		: TMC
    /// </summary>
    public interface IUserDTO : IDTO
    {
        int UserId { get; set; }
        string UserName { get; set; }

        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        int CityId { get; set; }
        int AreaId { get; set; }
        int PinCode { get; set; }
        Int16 UserTypeId { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }

        DateTime CreatedOn { get; set; }
        long CreatedBy { get; set; }
        DateTime UpdatedOn { get; set; }
        long UpdatedBy { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; }
    }

    /// <summary>
    /// Defines a contract for User DTO,
    /// Author		: TMC
    /// </summary>
    public interface IUserDTOBkp : IDTO
    {
        /// <summary>
        /// Gets or sets the User Id.
        /// </summary>
        int UserId { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        Int16 UserTypeId { get; set; }

        string Email { get; set; }
        Int16 CountryId { get; set; }
        Int16 StateId { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }

        int AreaId { get; set; }
        int PinCode { get; set; }
        int CityId { get; set; }



        // Account Details Section

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
        /// 
        /// 
        IIndividualDTO Individual { get; set; }

        /// <summary>
        /// Gets or sets the minimum rank.
        /// </summary>
        int MinimumRank { get; set; }
    }
}
