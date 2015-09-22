using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using TMC.Shared;
using TMC.ViewModels;
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

        public async Task<ActionResult> AddEditListing()
        {
            var client = TMCHttpClient.GetClient();

            var model = new ListingItemViewModel();

            HttpResponseMessage egsResponse = await client.GetAsync("api/listing/1");

            if (egsResponse.IsSuccessStatusCode)
            {
                string egsContent = await egsResponse.Content.ReadAsStringAsync();
                var lstExpenseGroupStatusses = JsonConvert.DeserializeObject<ListingItemViewModel>(egsContent);
                model = lstExpenseGroupStatusses;

                model.ActionName = "AddEditListing";
                model.ControllerName = "VendorController";
                model.FormId = "listingForm";

            }
            else
            {
                return Content("An error occurred.");
            }
            return View("AddEditListing", model);
        }

        [HttpPost]
         public async Task<ActionResult> AddEditListing(ListingItemViewModel listingViewModel)
        {
            var client = TMCHttpClient.GetClient();

            return View("AddEditListing", listingViewModel);
        }
    }
}
