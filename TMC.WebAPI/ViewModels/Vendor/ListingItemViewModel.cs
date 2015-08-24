using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMC.ViewModels
{
    public class ListingItemViewModel
    {
        public int ListingId { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
        public string EmailId { get; set; }
        public string LandlineNo { get; set; }
        public string MobileNo { get; set; }
        public  int YearStarted { get; set; } 
    }
}