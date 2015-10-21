using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TMC.Shared;
using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{

    public class UserViewModel : ViewModelBase
    {
        public UserViewModel()
        {
            Listings = new List<ListingViewModel>();
            Requirements = new List<RequirementViewModel>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
      
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int CityId { get; set; }
        public string AreaId { get; set; }
        public int PinCode { get; set; }
        public Int16 UserTypeId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
         
 

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public List<ListingViewModel> Listings { get; set; }
        public List<RequirementViewModel> Requirements { get; set; }
    }


    public class UserViewModelBkp : ViewModelBase
    {
        public UserViewModelBkp()
        {
            Listings = new List<ListingViewModel>();
            Requirements = new List<RequirementViewModel>();
        }
        public int UserId { get; set; }


        public string FullName {
            get
            {
                return FirstName + " " + LastName;
            }
        }
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

        public List<ListingViewModel> Listings { get; set; }
        public List<RequirementViewModel> Requirements { get; set; }
    
        public string UserName { get; set; }

      
        public string Password { get; set; }

        
        public DateTime? LockedDt { get; set; }

        
        public short? LockedInd { get; set; }

        
        public short? UserStatus { get; set; }

        
        public short? ForceUserUpdateInd { get; set; }

        
        public bool IsJCCPlanActive { get; set; }

       
        public short? UserPasswordUpdatedCnt { get; set; }

        public DateTime? UserPasswordUpdatedDt { get; set; }

        public DateTime UpdatedDt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime CreatedDt { get; set; }

        public int? IndividualId { get; set; }

        public IIndividualDTO Individual { get; set; }

        public bool IsInvalidUser { get; set; }

        public int MinimumRank { get; set; }
        public bool? AllowAllCompanies { get; set; }
    }
}