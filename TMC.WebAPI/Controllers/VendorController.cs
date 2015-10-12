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

    public class TrimmedDTO : ITrimmedDTO
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
    }

    public interface ITrimmedDTO
    {
        string Name { get; set; }
        int RollNo { get; set; }
    }

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
            var listingItemViewModel = new ListingViewModel();
            ListingContactItemViewModel listingContact = new ListingContactItemViewModel();
            listingContact.ContactNumber = "9988765432";
            listingContact.ListingContactTypeId = (int)ListingContactType.Landline;
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
                    var lstExpenseGroupStatusses = JsonConvert.DeserializeObject<ListingViewModel>(egsContent);
                    listingItemViewModel = lstExpenseGroupStatusses; 
                }
                else
                {
                    return Content("An error occurred.");
                }
            }

            return View("AddEditListing", listingItemViewModel);
        }

        /// <summary>
        /// Adds listing 
        /// </summary>
        /// <param name="listingViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddEditListing(ListingViewModel listingViewModel)
        {
           var client = TMCHttpClient.GetClient();
            listingViewModel.VendorId = 1;
           JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            string serializedItemToCreate = JsonConvert.SerializeObject(listingViewModel, settings);

            var response = await client.PostAsync("api/listing",new StringContent(serializedItemToCreate,
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
