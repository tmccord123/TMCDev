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
        public long ListingId { get; set; }
        public int VendorId { get; set; }
        public string BusinessName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmailId { get; set; }

        public short? YearStarted { get; set; }
        public string Designation { get; set; }
        public string WebSite { get; set; }
        public short BusinessDays { get; set; }
        public short BusinessHours { get; set; }

        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public string UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
         
    }
}
