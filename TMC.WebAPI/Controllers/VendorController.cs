using System.Collections.Generic;
using System.Web.Mvc;
using TMC.Shared;
using TMC.ViewModels;


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
    }
}
