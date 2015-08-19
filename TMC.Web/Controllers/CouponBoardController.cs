using System.Collections.Generic;
using System.Web.Mvc;
using TMC.Data;
using TMC.Shared;
using TMC.ViewModels;


namespace TMC.Controllers
{
    
    
    public class CouponBoardController : Controller
    {
        // POST: /User/Create
        [HttpPost]
        public JsonResult Create(ProductItemViewModel product)
        {
            return Json("Response from Create");
        }
        public ActionResult Index(string permalink)
        {
           /* var blogDAC = new BlogDAC();
            List<BlogDTO> blogs = new List<BlogDTO>();
            BlogViewModels blogModels = new BlogViewModels();
            blogModels.Blogs = new List<BlogViewModel>();
            blogs = blogDAC.ReadAllBlogs();
            foreach (var blogDto in blogs)
            {
                var blogModel = new BlogViewModel();
                blogModel.Description = blogDto.Description;
                blogModels.Blogs.Add(blogModel);
            }*/

            var productDAC = new ProductDAC();
            List<IProductDTO> products = new List<IProductDTO>();
            ProductViewModel blogModels = new ProductViewModel();
            blogModels.Products = new List<ProductItemViewModel>();
            products = productDAC.ReadAllProducts();
            foreach (var blogDto in products)
            {
                var blogModel = new ProductItemViewModel();
                blogModel.Description = blogDto.Description;
                blogModel.Name = blogDto.Name;
                blogModel.SeoTitle = blogDto.SeoTitle;
                blogModel.ImageURL = blogDto.ImageURL;

                blogModels.Products.Add(blogModel);
            }


            return View(blogModels);
        }
    }
}
