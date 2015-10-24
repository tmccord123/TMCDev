
using System;
namespace TMC.Shared
{
    public interface IListingDTO : IDTO
    {
        long ListingId { get; set; }
        int UserId { get; set; }
        string BusinessName { get; set; }
        string ContactPerson { get; set; }
        string ContactEmailId { get; set; }

        short? YearStarted { get; set; }
        string Designation { get; set; }
        string Website { get; set; }
        short BusinessDays { get; set; }
        short BusinessHours { get; set; }
        IListingContactsDTO ListingContacts { get; set; }
        IListingCategoriesDTO ListingCategories { get; set; }
        IListingServiceAreasDTO ListingServiceAreas { get; set; }
        IListingPaymentModesDTO ListingPaymentModes { get; set; }
        IListingMediasDTO ListingMedias { get; set; }

        DateTime CreatedOn { get;set; }
        long CreatedBy { get;set; }
        DateTime UpdatedOn { get; set; }
        long UpdatedBy { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; } 
    } 
}
