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
    
    public partial class ListingContact
    {
        public long ListingContactId { get; set; }
        public long ListingId { get; set; }
        public decimal ContactNo { get; set; }
        public short ContactTypeId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ContactType ContactType { get; set; }
        public virtual Listing Listing { get; set; }
    }
}