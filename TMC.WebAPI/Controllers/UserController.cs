using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.Web.ViewModels;
using TMC.Web.Shared;
using TMC.Web;


namespace TMC.Web.Controllers
{
 

    public class UserController : Controller
    {
        
        public  async Task<ActionResult>  Index()
        {
            var client = TMCHttpClient.GetClient();
            var userId = 3;
            HttpResponseMessage egsResponse = await client.GetAsync("api/listing/GetListingsByUserId/" + userId);//todo
            List<ListingViewModel> listingViewModels = new List<ListingViewModel>();
            if (egsResponse.IsSuccessStatusCode)
            {
                string egsContent = await egsResponse.Content.ReadAsStringAsync();
                var lstExpenseGroupStatusses = JsonConvert.DeserializeObject<List<ListingViewModel>>(egsContent);
                listingViewModels = lstExpenseGroupStatusses;
            }
            else
            {
                return Content("An error occurred.");
            }
           UserViewModel userViewModel = new UserViewModel();
            userViewModel.FirstName = "Mahi";
            userViewModel.LastName = "Kumar";
            userViewModel.Email = "abcd@gmail.com";
            userViewModel.AddressLine1 = "Palam Vihar";
            userViewModel.Listings = listingViewModels;
            
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
