using System;
using System.Collections.Generic; 
using TMC.Web.Shared;

namespace TMC.Web.Shared.ViewModels
{
    public class ListingPaymentModesViewModel : ViewModelBase
    {
        public ListingPaymentModesViewModel()
        {
            PaymentModes = new List<PaymentModeViewModel>();
            NewPaymentMode = new PaymentModeViewModel();
        }
        public List<PaymentModeViewModel> PaymentModes { get; set; }
        public PaymentModeViewModel NewPaymentMode { get; set; }
    }
}