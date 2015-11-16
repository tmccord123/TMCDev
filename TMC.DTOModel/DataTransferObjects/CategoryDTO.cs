
namespace TMC.DTOModel
{
    using System;
    using System.Runtime.Serialization;

    using TMC.Shared;

    /// <summary>
    /// Contract for Category DTO.
    /// </summary>
    [DataContract(Name = "CategoryDTO", Namespace = "TMC.DTOModel1")]
    [EntityMapping("EntityDataModel.EntityModels.Category", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.ViewModels.CategoryViewModel", MappingType.TotalExplicit)]
    public class CategoryDTO : DTOBase, ICategoryDTO
    {

        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "CategoryId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "CategoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Name")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ShortName")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ShortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Description")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the popularity.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Popularity")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Popularity")]
        public int? Popularity { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingId")]
        public long ListingId { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingCategoryId")]
        public long ListingCategoryId { get; set; }
    }
}
