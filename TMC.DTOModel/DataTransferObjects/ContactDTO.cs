using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    /// <summary>
    /// Contract for ListingContact DTO.
    /// </summary>
    [DataContract(Name = "ListingContact", Namespace = "TMC.DTOModel")]
    [EntityMapping("EntityDataModel.EntityModels.ListingContact", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.Shared.ViewModels.ContactViewModel", MappingType.TotalExplicit)]
    public class ContactDTO : DTOBase, IContactDTO
    {
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingContactId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ListingContactId")]
        public long ListingContactId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "ContactNo")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ContactNo")]
        public decimal ContactNo { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "ContactTypeId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ContactTypeId")]
        public short ContactTypeId { get; set; } 

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
