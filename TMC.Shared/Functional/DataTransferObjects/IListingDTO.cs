
using System;
namespace TMC.Shared
{
    public interface IListingDTO : IDTO
    {
        int ListingId { get; set; }
        int VendorId { get; set; }
        string BusinessName { get; set; }
        string ContactPerson { get; set; }
        string ContactEmailId { get; set; } 
        //string CompanyName { get; set; } 
        //string City { get; set; }
        //int PinCode { get; set; }
        //string EmailId { get; set; }
        //string LandlineNo { get; set; }
        //string MobileNo { get; set; }
        //int YearStarted { get; set; } 
       
    }

    public class TrimmedListingDTO  
    {
        public int ListingId { get; set; }
        public int VendorId { get; set; }
        public string BusinessName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmailId { get; set; } 
        //string CompanyName { get; set; } 
        //string City { get; set; }
        //int PinCode { get; set; }
        //string EmailId { get; set; }
        //string LandlineNo { get; set; }
        //string MobileNo { get; set; }
        //int YearStarted { get; set; } 
       
    }

    public interface ITrimmedListingDTO
    {
        int ListingId { get; set; }
        int VendorId { get; set; }
        string BusinessName { get; set; }
        string ContactPerson { get; set; }
        string ContactEmailId { get; set; }
        //string CompanyName { get; set; } 
        //string City { get; set; }
        //int PinCode { get; set; }
        //string EmailId { get; set; }
        //string LandlineNo { get; set; }
        //string MobileNo { get; set; }
        //int YearStarted { get; set; } 

    }
}
