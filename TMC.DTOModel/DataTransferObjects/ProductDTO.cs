using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    using System.Collections.Generic;

    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "EmailInfoDTO", Namespace = "TMC.DTOModel")]
    [EntityMapping("TMC.Entities.EntityModels.EmailInfo", MappingType.TotalExplicit)]
    [Serializable]
    public class ProductDTO : DTOBase , IProductDTO
    {
        /// <summary>
        /// Get or set Action Id.
        /// </summary>
        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public int ProductId { get; set; }  
        
        /// <summary>
        /// Get or set Action Id.
        /// </summary>
        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public string  Name { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public string SeoTitle { get; set; }
        
        /// <summary>
        /// Get or set Action Name.
        /// </summary>
        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public string SiteURL { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public string ImageURL { get; set; }

        /// <summary>
        /// Get or set Description.
        /// </summary>
        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public string Description { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public string Content { get; set; }

        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public string ContentText { get; set; }

  

        /// <summary>
        /// gets or sets the state of the object.
        /// </summary>
        /// <value>The state of the object.</value>        
        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public ObjectStateType ObjectState { get; set; }

        /// <summary>
        /// gets the unique ID.
        /// </summary>
        /// <value>The unique ID.</value>        
        [DataMember]
        [EntityPropertyMapping(MappingDirectionType.Both, "EmailInfoId")]
        public Guid? UniqueID { get; set; }
       
    }
}
