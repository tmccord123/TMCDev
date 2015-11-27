
namespace TMC.DTOModel
{
    using System;
    using System.Runtime.Serialization;

    using TMC.Shared;

    /// <summary>
    /// Contract for ServiceLocation DTO.
    /// </summary>
    [DataContract(Name = "ServiceLocationDTO", Namespace = "TMC.DTOModel")]
    [EntityMapping("EntityDataModel.EntityModels.ListingServiceLocation", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.Shared.ViewModels.ServiceLocationViewModel", MappingType.TotalExplicit)]
    public class ServiceLocationDTO : DTOBase, IServiceLocationDTO
    {

        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "CityId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "CityId")]
        public int CityId { get; set; }  
        
        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "CityName")]
        public string CityName { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ListingId")]
        public long ListingId { get; set; }

        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingServiceLocationId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ListingServiceLocationId")]
        public long ListingServiceLocationId { get; set; }
    }
}
