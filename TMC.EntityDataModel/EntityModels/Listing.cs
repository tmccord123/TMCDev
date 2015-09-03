//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDataModel.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Listing
    {
        public Listing()
        {
            this.ListingContact = new HashSet<ListingContact>();
            this.ListingLocation = new HashSet<ListingLocation>();
            this.ListingMedia = new HashSet<ListingMedia>();
            this.ListingPaymentMode = new HashSet<ListingPaymentMode>();
        }
    
        public long ListingId { get; set; }
        public long VendorId { get; set; }
        public string BusinessName { get; set; }
        public Nullable<short> YearStarted { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmailId { get; set; }
        public string Designation { get; set; }
        public string Website { get; set; }
        public short BusinessDays { get; set; }
        public short BusinessHours { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<ListingContact> ListingContact { get; set; }
        public virtual ICollection<ListingLocation> ListingLocation { get; set; }
        public virtual ICollection<ListingMedia> ListingMedia { get; set; }
        public virtual ICollection<ListingPaymentMode> ListingPaymentMode { get; set; }
    }
}
