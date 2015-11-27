using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "Listing", Namespace = "TMC.DTOModel")]
    [EntityMapping("EntityDataModel.EntityModels.Listing", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.Shared.ViewModels.ListingViewModel", MappingType.TotalExplicit)]
    public class ListingDTO : DTOBase, IListingDTO
    {
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ListingId")]
        public long ListingId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "UserId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "UserId")]
        public int UserId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "BusinessName")]
        [EntityPropertyMapping(MappingDirectionType.Both, "BusinessName")]
        public string BusinessName { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "ContactPerson")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ContactPerson")]
        public string ContactPerson { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "ContactEmailId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ContactEmailId")]
        public string ContactEmailId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "YearStarted")]
        [EntityPropertyMapping(MappingDirectionType.Both, "YearStarted")]
        public short? YearStarted { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "Designation")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Designation")]
        public string Designation { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "Website")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Website")]
        public string Website { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "BusinessDays")]
        [EntityPropertyMapping(MappingDirectionType.Both, "BusinessDays")]
        public short BusinessDays { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "BusinessHours")]
        [EntityPropertyMapping(MappingDirectionType.Both, "BusinessHours")]
        public short BusinessHours { get; set; }
         
        public IListingContactsDTO ListingContacts { get; set; }
        public IListingCategoriesDTO ListingCategories { get; set; }
        public IListingServiceLocationsDTO ListingServiceLocations { get; set; }
        public IListingPaymentModesDTO ListingPaymentModes { get; set; }
        public IListingMediasDTO ListingMedias { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "CreatedOn")]
        [EntityPropertyMapping(MappingDirectionType.Both, "CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "CreatedBy")]
        [EntityPropertyMapping(MappingDirectionType.Both, "CreatedBy")]
        public long CreatedBy { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "UpdatedOn")]
        [EntityPropertyMapping(MappingDirectionType.Both, "UpdatedOn")]
        public DateTime UpdatedOn { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "UpdatedBy")]
        [EntityPropertyMapping(MappingDirectionType.Both, "UpdatedBy")]
        public long UpdatedBy { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsActive")] 
        public bool IsActive { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsDeleted")] 
        public bool IsDeleted { get; set; }
         
    }
}
