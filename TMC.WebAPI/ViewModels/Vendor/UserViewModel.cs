using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMC.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Int16 UserTypeId { get; set; }

        public string Email { get; set; }
        public Int16 CountryId { get; set; }
        public Int16 StateId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public int AreaId { get; set; }
        public int PinCode { get; set; }
        public int CityId { get; set; }
    }
}