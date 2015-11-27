
namespace TMC.Web.Shared.ViewModels
{
    using TMC.Web.Shared;

    /// <summary>
    /// The ServiceArea  view model.
    /// </summary>
    public class PaymentModeViewModel : ViewModelBase
    {
        public long ListingPaymentModeId { get; set; }

        public long ListingId { get; set; }

        public short PaymentModeId { get; set; }
    }
}