using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.ViewModels;
using TMC.Web.Shared;
using TMC.WebAPI;


namespace TMC.Controllers
{


    public class VendorController : Controller
    {
        // POST: /User/Create
        [HttpPost]
        public JsonResult Create(ProductItemViewModel product)
        {
            return Json("Response from Create");
        }
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

        public async Task<ActionResult> AddEditListing(int id = 0)
        {
            var listingItemViewModel = new ListingItemViewModel();
            ListingContactViewModel listingContact = new ListingContactViewModel();
            listingContact.ContactNumber = "9988765432";
            listingContact.ContactTypeId = ListingContactType.Landline;
            listingItemViewModel.ListingContacts.Contacts.Add(listingContact);
            listingItemViewModel.ActionName = "AddEditListing";
            listingItemViewModel.ControllerName = "Vendor";
            listingItemViewModel.FormId = "listingForm";
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
                    var lstExpenseGroupStatusses = JsonConvert.DeserializeObject<ListingItemViewModel>(egsContent);
                    listingItemViewModel = lstExpenseGroupStatusses; 
                }
                else
                {
                    return Content("An error occurred.");
                }
            }

            return View("AddEditListing", listingItemViewModel);
        }

        [HttpPost]
        public async Task<ActionResult> AddEditListing(ListingItemViewModel listingViewModel)
        {
            var client = TMCHttpClient.GetClient();
            //var listingDTO = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
            //DTOConverter.FillDTOFromViewModel(listingDTO, listingViewModel);


            // todo
            var trimmedlistingViewModel = new ListingItemViewModel1();
            trimmedlistingViewModel.BusinessName = listingViewModel.BusinessName;
            trimmedlistingViewModel.ContactEmailId = listingViewModel.ContactEmailId;
            trimmedlistingViewModel.ContactPerson = listingViewModel.ContactPerson;
            trimmedlistingViewModel.ListingId = 1;
            trimmedlistingViewModel.VendorId = 2;
          //  var serializedItemToCreate = JsonConvert.SerializeObject(trimmedlitingViewModel);

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            string serializedItemToCreate = JsonConvert.SerializeObject(trimmedlistingViewModel, typeof(ITrimmedListingDTO), settings);

            var response = await client.PostAsync("api/listing",
              new StringContent(serializedItemToCreate,
              System.Text.Encoding.Unicode, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("An error occurred");
            }

            return View("AddEditListing", listingViewModel);
        }
    }
}
