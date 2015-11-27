using System;
using System.Collections.Generic; 
using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{
    public class ListingServiceLocationsViewModel : ViewModelBase
    {
        public ListingServiceLocationsViewModel()
        {
            ServiceLocations = new List<ServiceLocationViewModel>();
            NewServiceLocation = new ServiceLocationViewModel();
        }
        public List<ServiceLocationViewModel> ServiceLocations { get; set; }
        public ServiceLocationViewModel NewServiceLocation { get; set; }
        public CitySaytViewModel CitySaytListing { get; set; }
    }
}