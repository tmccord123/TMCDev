
using System;

namespace TMC.Shared
{
    /// <summary>
    /// The CityDTO interface.//todo
    /// </summary>
    public interface IPaymentModeDTO : IDTO
    {
        long ListingPaymentModeId { get; set; }
        long ListingId { get; set; }
        short PaymentModeId { get; set; }

        DateTime CreatedOn { get; set; }
        long CreatedBy { get; set; }
        DateTime UpdatedOn { get; set; }
        long UpdatedBy { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; } 
    }
}
