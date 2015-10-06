using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
     

    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "ListingDTO", Namespace = "TMC.DTOModel")]
    [EntityMapping("TMC.Entities.EntityModels.Listing", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.ViewModels.ListingViewModel", MappingType.TotalExplicit)]
    public class ListingDTO : DTOBase, IListingDTO
    {
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingId")]
        public long ListingId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "VendorId")]
        public int VendorId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "BusinessName")]
        public string BusinessName { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "ContactPerson")]
        public string ContactPerson { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "ContactEmailId")]
        public string ContactEmailId { get; set; }


        [ViewModelPropertyMapping(MappingDirectionType.Both, "YearStarted")]
        public short? YearStarted { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "Designation")]
        public string Designation { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "WebSite")]
        public string WebSite { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "BusinessDays")]
        public short BusinessDays { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "BusinessHours")]
        public short BusinessHours { get; set; }
         
        public IListingContactsDTO ListingContacts { get; set; }


        [ViewModelPropertyMapping(MappingDirectionType.Both, "CreatedOn")]
        public string CreatedOn { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "CreatedBy")]
        public string CreatedBy { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "UpdatedOn")]
        public string UpdatedOn { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "UpdatedBy")]
        public string UpdatedBy { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsActive")]
        public string IsActive { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsDeleted")]
        public string IsDeleted { get; set; }
         
    }
}
