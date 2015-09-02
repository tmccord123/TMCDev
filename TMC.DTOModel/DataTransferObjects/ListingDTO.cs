using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
     

    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    [DataContract(Name = "ListingDTO", Namespace = "TMC.DTOModel")]
    [EntityMapping("TMC.Entities.EntityModels.ListingDTO", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.ViewModels.ListingViewModel", MappingType.TotalExplicit)]
    public class ListingDTO : DTOBase, IListingDTO
    {


        public int ListingId { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
        public string EmailId { get; set; }
        public string LandlineNo { get; set; }
        public string MobileNo { get; set; }
        public int YearStarted { get; set; } 
         
    }
}
