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
            Contacts = new List<ContactViewModel>();
            NewContact = new ContactViewModel();

        }
        public List<ContactViewModel> Contacts { get; set; }
        public ContactViewModel NewContact { get; set; }
    }
}