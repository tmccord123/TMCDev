using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{
    public class ContactViewModel : ViewModelBase
    {
        public long ListingContactId { get; set; }
        public decimal ContactNo { get; set; }
        public short ContactTypeId { get; set; } 
    }
}