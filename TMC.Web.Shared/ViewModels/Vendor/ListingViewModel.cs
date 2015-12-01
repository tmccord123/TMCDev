using System;
using TMC.Shared;
using TMC.Web.Shared;

namespace TMC.Web.Shared.ViewModels
{
    public class ListingParametersViewModel 
    { 
        public string PlaceId { get; set; } 
        public int CategoryId { get; set; } 
        public int CityId { get; set; }
        public int PageIndex { get; set; } 
        public int PageSize { get; set; }
        public string SortBy { get; set; } 
    }
}