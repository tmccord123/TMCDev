
using System;

namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.//todo
    /// </summary>
    public interface IServiceLocationDTO : IDTO
    {
        long ListingServiceLocationId { get; set; }
        int CityId { get; set; }
        string CityName { get; set; }
        long ListingId { get; set; }

        //todo need to check for a general way to keep this
/*        DateTime CreatedOn { get; set; }
        long CreatedBy { get; set; }
        DateTime UpdatedOn { get; set; }
        long UpdatedBy { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; } */
    }
}
