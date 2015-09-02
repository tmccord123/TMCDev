using System;
using TMC.Web.Shared;

namespace TMC.ViewModels
{
    public class ListingItemViewModel : ViewModelBase
    {
        public int ListingId { get; set; }
        public int VendorId { get; set; }
        public string BusinessName { get; set; }
        public DateTime YearStarted { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmailId { get; set; }
        public string Designation { get; set; }
        public string Website { get; set; }
        public int BusinessDays { get; set; }
        public int BusinessHours { get; set; }
        public UserViewModel Owner { get; set; }
        public UserViewModel ListingContact { get; set; }
        public UserViewModel ListingLocation { get; set; }
        public UserViewModel ListingMedia { get; set; }
        public UserViewModel ListingPaymentMode { get; set; }
    }
}