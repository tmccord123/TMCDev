
using System;
namespace TMC.Shared
{
    public interface IListingDTO : IDTO
    {
        int ListingId { get; set; }
        string CompanyName { get; set; }
        string ContactPerson { get; set; }
        string City { get; set; }
        int PinCode { get; set; }
        string EmailId { get; set; }
        string LandlineNo { get; set; }
        string MobileNo { get; set; }
        int YearStarted { get; set; } 
       
    }
}
