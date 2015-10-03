using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    using System.Collections.Generic;

    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "CityDTO", Namespace = "TMC.DTOModel")]
    [EntityMapping("TMC.Entities.EntityModels.CityDTO", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.ViewModels.CityViewModel", MappingType.TotalExplicit)]
    public class CityDTO : DTOBase, ICityDTO
    {

        /// <summary>
        /// Gets or sets the city id.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "CityId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "CityId")]
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Name")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the state id.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "StateId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "StateId")]
        public int StateId { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Lat")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Lat")]
        public string Lat { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "Long")]
        [EntityPropertyMapping(MappingDirectionType.Both, "Long")]
        public string Long { get; set; }

        /// <summary>
        /// Gets or sets the pin code.
        /// </summary>
        //[DataMember]
        //[ViewModelPropertyMapping(MappingDirectionType.Both, "PinCode")]
        //[EntityPropertyMapping(MappingDirectionType.Both, "PinCode")]
        //public int PinCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is popular.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsPopular")]
        [EntityPropertyMapping(MappingDirectionType.Both, "IsPopular")]
        public bool IsPopular { get; set; }

        /// <summary>
        /// Gets or sets the population class.
        /// </summary>
        [DataMember]
        [ViewModelPropertyMapping(MappingDirectionType.Both, "PopulationClass")]
        [EntityPropertyMapping(MappingDirectionType.Both, "PopulationClass")]
        public short PopulationClass { get; set; }

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// Gets or sets the CombinedCityDetails.
        /// </summary>
        public int CombinedCityDetails { get; set; }
    }
}
