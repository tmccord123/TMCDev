using System;
using TMC.Shared;
using TMC.Web.Shared;

namespace TMC.Web.Shared.ViewModels
{
    public class ListingViewModel : ViewModelBase
    {
        public ListingViewModel()
        {
            ListingContacts = new ListingContactsViewModel();
            ListingCategories = new ListingCategoriesViewModel();
            ListingServiceLocations = new ListingServiceLocationsViewModel();
            ListingPaymentModes = new ListingPaymentModesViewModel();
            ListingMedias = new ListingMediasViewModel();
        }
        public long ListingId { get; set; }
        public int UserId { get; set; }
        public string BusinessName { get; set; }
        public short? YearStarted { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmailId { get; set; }
        public string Designation { get; set; }
        public string Website { get; set; }
        public short BusinessDays { get; set; }
        public short BusinessHours { get; set; }
        public ListingContactsViewModel ListingContacts { get; set; }
        public ListingCategoriesViewModel ListingCategories { get; set; }
        public ListingServiceLocationsViewModel ListingServiceLocations { get; set; }
        public ListingPaymentModesViewModel ListingPaymentModes { get; set; }
        public ListingMediasViewModel ListingMedias { get; set; } 
    }
}