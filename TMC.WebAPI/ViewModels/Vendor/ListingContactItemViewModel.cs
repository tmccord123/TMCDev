using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TMC.Shared;
using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{
    public class ListingContactItemViewModel : ViewModelBase
    {
        public string ContactNumber { get; set; }
        public int ListingContactTypeId { get; set; } 
    }
}