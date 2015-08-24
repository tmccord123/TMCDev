using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    using System.Collections.Generic;

    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "UserDTO", Namespace = "TMC.DTOModel")]
    [EntityMapping("TMC.Entities.EntityModels.UserDTO", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.ViewModels.UserViewModel", MappingType.TotalExplicit)]
    public class UserDTO : DTOBase, IUserDTO
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
