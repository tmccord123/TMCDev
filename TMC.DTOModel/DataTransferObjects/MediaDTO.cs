using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "Media", Namespace = "TMC.DTOModel")]
    [EntityMapping("EntityDataModel.EntityModels.Media", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.ViewModels.MediaViewModel", MappingType.TotalExplicit)]
    public class MediaDTO : DTOBase, IMediaDTO
    {
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingMediaId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ListingMediaId")]
        public long ListingMediaId { get; set; }

        public long ListingId { get; set; }
        public long FileId { get; set; }
        public string FileName { get; set; }
        

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
