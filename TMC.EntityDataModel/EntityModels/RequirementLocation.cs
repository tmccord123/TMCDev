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
    
    public partial class RequirementLocation
    {
        public long RequirementLocationId { get; set; }
        public long RequirementId { get; set; }
        public int CityId { get; set; }
        public string AreaId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        public virtual Requirement Requirement { get; set; }
    }
}