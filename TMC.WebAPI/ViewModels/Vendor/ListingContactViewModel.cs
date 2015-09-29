using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TMC.Shared;
using TMC.Web.Shared;

namespace TMC.ViewModels
{
    public class ListingContactViewModel : ViewModelBase
    {
        public string ContactNumber { get; set; }
        public ListingContactType ContactTypeId { get; set; } 
    }
}