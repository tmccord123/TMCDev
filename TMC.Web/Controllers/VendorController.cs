using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.Web.Shared.ViewModels;
using TMC.Web.Shared;
using TMC.Web;


namespace TMC.Web.Controllers
{
    public class VendorController : Controller
    {
        
        public ActionResult Index()
        {


            /*var productFacade = (IProductFacade)FacadeFactory.Instance.Create(FacadeType.Product);
            IList<IProductDTO> products = new List<IProductDTO>();
            var blogModels = new ProductViewModel();
            blogModels.Products = new List<ProductItemViewModel>();
            var productsData = productFacade.GetAllProducts(); 
            if (productsData.IsValid())
            {
                products = productsData.Data;
                foreach (var blogDto in products)
                {
                    var blogModel = new ProductItemViewModel();
                    blogModel.Description = blogDto.Description;
                    blogModel.Name = blogDto.Name;
                    blogModel.SeoTitle = blogDto.SeoTitle;
                    blogModel.ImageURL = blogDto.ImageURL;

                    blogModels.Products.Add(blogModel);
                }
            }
              return View(blogModels);
             */

            return View();
        }

        [Authorize]
        public async Task<ActionResult> AddEditListing(int id = 0)
        {
            var listingViewModel = new ListingViewModel();
            ContactViewModel listingContact = new ContactViewModel();
            listingContact.ContactNo = 9988765432;
            listingContact.ContactTypeId = (int)ListingContactType.Landline;
            listingViewModel.ListingContacts.Contacts.Add(listingContact);
            listingViewModel.ActionName = "AddEditListing";
            listingViewModel.ControllerName = "Vendor";
            listingViewModel.FormId = "listingForm";
            listingViewModel.FormSuccessCallBack = "addEditListing.onAddEditListingSuccessCallBack";
            // var client = TMCHttpClient.GetClient(User.AccessToken());
            var client = TMCHttpClient.GetClient();
            if (id > 0)
            {
                HttpResponseMessage contentResponse = await client.GetAsync("api/listing/" + id);
                if (contentResponse.IsSuccessStatusCode)
                {
                    string content = await contentResponse.Content.ReadAsStringAsync();
                    var cotentResult = JsonConvert.DeserializeObject<ListingViewModel>(content);
                    listingViewModel = cotentResult;
                }
                else
                {
                    return Content("An error occurred while fetching the data.");
                }
                
                //listing contacts
                HttpResponseMessage contentContactsResponse = await client.GetAsync("api/listing/" + id+"/contacts");
                if (contentContactsResponse.IsSuccessStatusCode)
                {
                    string content = await contentContactsResponse.Content.ReadAsStringAsync();
                    var cotentResult = JsonConvert.DeserializeObject<ListingViewModel>(content);
                    listingViewModel.ListingContacts = cotentResult.ListingContacts;
                }
            }



            //listing category 
            listingViewModel.ListingCategories.CategorySaytListing = new CategorySaytViewModel();
            listingViewModel.ListingCategories.CategorySaytListing.ControlId = "ddlAddCategories";
            //todo get the url from here 
            //listingViewModel.ListingCategories.CategorySaytListing.AjaxGetUrl = "";
            listingViewModel.ListingCategories.CategorySaytListing.HtmlFieldPrefix = "CategorySaytHome";
            listingViewModel.ListingCategories.CategorySaytListing.SelectCallBack = "addEditListing.onSelectedCategoryCallBack"; 

            //listing Service Area
            listingViewModel.ListingServiceLocations.CitySaytListing = new CitySaytViewModel();
            listingViewModel.ListingServiceLocations.CitySaytListing.ControlId = "ddlAddCities"; 
            listingViewModel.ListingServiceLocations.CitySaytListing.HtmlFieldPrefix = "CirySaytListingServiceArea";
            listingViewModel.ListingServiceLocations.CitySaytListing.SelectCallBack = "addEditListing.onSelectedAddCityCallBack"; 
           //todo sometimes the city api call it was going to make is like this vendor/api/coty/{searchStr} so breaks , need to have a look
            // listingViewModel.ListingServiceLocations.CitySaytListing.AjaxGetUrl 
           //     = Url.RouteUrl("DefaultApi", new { httproute="", controller="city"  }); 


            return View("AddEditListing", listingViewModel);
        }

        /// <summary>
        /// Adds listing 
        /// </summary>
        /// <param name="listingViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddEditListing(ListingViewModel listingViewModel)
        {
            ActionResult result = null;
            var client = TMCHttpClient.GetClient();
            listingViewModel.UserId = 3;
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            string serializedItemToCreate = JsonConvert.SerializeObject(listingViewModel, settings);

            var response = await client.PostAsync("api/listing", new StringContent(serializedItemToCreate,
            System.Text.Encoding.Unicode, "application/json"));
            
            if (response.IsSuccessStatusCode)
            {

                string content = response.Content.ReadAsStringAsync().Result;
                var contentResult = JsonConvert.DeserializeObject<ListingViewModel>(content);
                result = OperationResult<long>.CreateSuccessResult(contentResult.ListingId, "success").ToJsonResult();
            }
            else
            {
                //result = Content("An error occurred");
                //ModelState.AddModelError("Website", "invalid Website address");
                result = PartialView("_EditListing", listingViewModel);
            }
            return result;
        }
    }
}
