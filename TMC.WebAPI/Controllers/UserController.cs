using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.Web.ViewModels;
using TMC.Web.Shared;
using TMC.WebAPI;


namespace TMC.Controllers
{
 

    public class UserController : Controller
    {
        
        public  async Task<ActionResult>  Index()
        {
            //var listingItemViewModel = new ListingViewModel();
            //ListingContactItemViewModel listingContact = new ListingContactItemViewModel();
            //listingContact.ContactNumber = "9988765432";
            //listingContact.ListingContactTypeId = (int)ListingContactType.Landline;
            //listingItemViewModel.ListingContacts.Contacts.Add(listingContact);
            //listingItemViewModel.ActionName = "AddEditListing";
            //listingItemViewModel.ControllerName = "Vendor";
            //listingItemViewModel.FormId = "listingForm";
            //if (id == 0)
            //{

            //}
            //else
            //{
            //    var client = TMCHttpClient.GetClient();
            //    HttpResponseMessage egsResponse = await client.GetAsync("api/listing/1");

            //    if (egsResponse.IsSuccessStatusCode)
            //    {
            //        string egsContent = await egsResponse.Content.ReadAsStringAsync();
            //        var lstExpenseGroupStatusses = JsonConvert.DeserializeObject<ListingViewModel>(egsContent);
            //        listingItemViewModel = lstExpenseGroupStatusses;
            //    }
            //    else
            //    {
            //        return Content("An error occurred.");
            //    }
            //}

            //return View("AddEditListing", listingItemViewModel);
            // fetch the user details here 
            // lets fill the data for the time being
           UserViewModel userViewModel = new UserViewModel();
            userViewModel.FirstName = "Mahi";
            userViewModel.LastName = "Kumar";
            userViewModel.Email = "abcd@gmail.com";
            userViewModel.AddressLine1 = "Palam Vihar";
            return View(userViewModel);
        }

        public async Task<ActionResult> AddEditRequirement(int id = 0)
        {
            var requirementViewModel = new RequirementViewModel();
            
            requirementViewModel.ActionName = "AddEditRequirement";
            requirementViewModel.ControllerName = "User";
            requirementViewModel.FormId = "RequirementForm";
            if (id == 0)
            {

            }
            else
            {
                var client = TMCHttpClient.GetClient();
                HttpResponseMessage egsResponse = await client.GetAsync("api/listing/1");

                if (egsResponse.IsSuccessStatusCode)
                {
                    string egsContent = await egsResponse.Content.ReadAsStringAsync();
                    var lstExpenseGroupStatusses = JsonConvert.DeserializeObject<RequirementViewModel>(egsContent);
                    requirementViewModel = lstExpenseGroupStatusses;
                }
                else
                {
                    return Content("An error occurred.");
                }
            }

            return View("AddEditRequirement", requirementViewModel);
        }
    }
}
