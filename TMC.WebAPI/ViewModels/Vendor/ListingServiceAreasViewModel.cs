using System;
using System.Collections.Generic; 
using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{
    public class ListingServiceAreasViewModel : ViewModelBase
    {
        public ListingServiceAreasViewModel()
        {
            ServiceAreas = new List<ServiceAreaViewModel>();
            NewServiceArea = new ServiceAreaViewModel();
        }
        public List<ServiceAreaViewModel> ServiceAreas { get; set; }
        public ServiceAreaViewModel NewServiceArea { get; set; }
    }
}