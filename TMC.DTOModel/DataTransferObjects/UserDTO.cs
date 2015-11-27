using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{ 

    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "User", Namespace = "TMC.DTOModel")]
    [EntityMapping("EntityDataModel.EntityModels.User", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.Shared.ViewModels.UserViewModel", MappingType.TotalExplicit)]
    public class UserDTO : DTOBase, IUserDTO
    {

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "UserId")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "UserId")]
        public int UserId { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "UserName")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "UserName")]
        public string UserName { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "AddressLine1")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "AddressLine1")]
        public string AddressLine1 { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "AddressLine2")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "AddressLine2")]
        public string AddressLine2 { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "CityId")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "CityId")]
        public int CityId { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "AreaId")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "AreaId")]
        public string AreaId { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "PinCode")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "PinCode")]
        public int PinCode { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "UserTypeId")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "UserTypeId")]
        public Int16 UserTypeId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

         [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "CreatedOn")]
        [EntityPropertyMapping(MappingDirectionType.Both, "CreatedOn")]
        public DateTime CreatedOn { get; set; }

         [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "CreatedBy")]
        [EntityPropertyMapping(MappingDirectionType.Both, "CreatedBy")]
        public long CreatedBy { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "UpdatedOn")]
        [EntityPropertyMapping(MappingDirectionType.Both, "UpdatedOn")]
        public DateTime UpdatedOn { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "UpdatedBy")]
        [EntityPropertyMapping(MappingDirectionType.Both, "UpdatedBy")]
        public long UpdatedBy { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsActive")]
        [EntityPropertyMapping(MappingDirectionType.Both, "IsActive")]
        public bool IsActive { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsDeleted")]
        [EntityPropertyMapping(MappingDirectionType.Both, "IsDeleted")]
        public bool IsDeleted { get; set; }
    }


    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "UserDTO", Namespace = "TMC.DTOModel")]
    [EntityMapping("TMC.Entities.EntityModels.UserDTO", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.Shared.ViewModels.UserViewModel", MappingType.TotalExplicit)]
    public class UserDTOBkp : DTOBase, IUserDTOBkp
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Int16 UserTypeId { get; set; }
        public string Email { get; set; }
        public Int16 CountryId { get; set; }
        public Int16 StateId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int AreaId { get; set; }
        public int PinCode { get; set; }
        public int CityId { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "jcc_user_id")]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "UserId")]
        public int UserId { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "UserName")]
        [EntityPropertyMapping(MappingDirectionType.Both, "user_name")]
        public string UserName { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "user_password")]
        public string Password { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "locked_dt")]
        public DateTime? LockedDt { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "locked_ind")]
        public short? LockedInd { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "user_status")]
        public short? UserStatus { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "force_user_update_ind")]
        public short? ForceUserUpdateInd { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "jccplan_isactive")]
        public bool IsJCCPlanActive { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "user_password_updated_cnt")]
        public short? UserPasswordUpdatedCnt { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "user_password_updated_dt")]
        public DateTime? UserPasswordUpdatedDt { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "updated_dt")]
        public DateTime UpdatedDt { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "updated_by")]
        public string UpdatedBy { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "created_dt")]
        public DateTime CreatedDt { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "individual_id")]
        public int? IndividualId { get; set; }

        [DataMember]
        public IIndividualDTO Individual { get; set; }

        [DataMember]
        public bool IsInvalidUser { get; set; }

        [DataMember]
        public int MinimumRank { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "semsv2_all_organizations")]
        public bool? AllowAllCompanies { get; set; }
    }
}
