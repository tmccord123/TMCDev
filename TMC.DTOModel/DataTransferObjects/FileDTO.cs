using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "File", Namespace = "TMC.DTOModel")]
    [EntityMapping("EntityDataModel.EntityModels.File", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.Shared.ViewModels.FileViewModel", MappingType.TotalExplicit)]
    public class FileDTO : DTOBase, IFileDTO
    {
        [ViewModelPropertyMapping(MappingDirectionType.Both, "FileId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "FileId")]
        public long FileId { get; set; }
        public long ListingId { get; set; }

        public short FileExtensionId { get; set; }
        public short FileTypeId { get; set; }
        public string FileTitle { get; set; }
        public string Description { get; set; }
        public string OriginalFileName { get; set; }
        public string ServerFileName { get; set; }
        public string ServerPath { get; set; }
        public IFileTypeDTO FileType { get; set; }
        

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
