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
    
    public partial class Vendor
    {
        public Vendor()
        {
            this.Listing = new HashSet<Listing>();
            this.VendorServiceLocation = new HashSet<VendorServiceLocation>();
        }
    
        public long VendorId { get; set; }
        public long UserId { get; set; }
    
        public virtual ICollection<Listing> Listing { get; set; }
        public virtual ICollection<VendorServiceLocation> VendorServiceLocation { get; set; }
    }
}