using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TMC.Shared;
using TMC.Web.Shared;

namespace TMC.ViewModels
{
    public class ListingContactsViewModel : ViewModelBase
    {
        public ListingContactsViewModel()
        {
            Contacts = new List<ListingContactViewModel>();

        }
        public List<ListingContactViewModel> Contacts { get; set; }
    }
}