using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TMC.Shared;
using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{
    public class ListingContactsViewModel : ViewModelBase
    {
        public ListingContactsViewModel()
        {
            Contacts = new List<ListingContactItemViewModel>();

        }
        public List<ListingContactItemViewModel> Contacts { get; set; }
    }
}