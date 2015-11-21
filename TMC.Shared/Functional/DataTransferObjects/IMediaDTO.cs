
using System;

namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.//todo
    /// </summary>
    public interface IMediaDTO : IDTO
    {
        long ListingMediaId { get; set; }
        long ListingId { get; set; }
        long FileId { get; set; }
        string FileName { get; set; }
        string ServerFileName { get; set; }

        DateTime CreatedOn { get; set; }
        long CreatedBy { get; set; }
        DateTime UpdatedOn { get; set; }
        long UpdatedBy { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; } 
    }
}
