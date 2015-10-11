
namespace TMC.WebAPI.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using TMC.Shared;
    using TMC.Web.ViewModels;
    using TMC.Web.Shared;

    /// <summary>
    /// The category api controller.
    /// </summary>
    [RoutePrefix("api/category")]
    public class CategoryApiController : ApiController
    {
        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="IHttpActionResult"/>.
        /// </returns>
        [Route("{searchStr}")] 
        public IHttpActionResult GetCategoriesByString(string searchStr)
        {
            var searchString = searchStr.ToLower();
            var categoriesResult = CacheMethods.FetchAllCategories();
            var categories = new List<CategoryViewModel>();
            
            if (categoriesResult != null)
            {
                var searchResult = categoriesResult.Where(c => c.Name.ToLower().Contains(searchString));
                foreach (var categoryDTO in searchResult)
                {
                    var category = new CategoryViewModel();
                    DTOConverter.FillViewModelFromDTO(category, categoryDTO);
                   
                    categories.Add(category);
                }
            }

            return Ok(categories);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="IHttpActionResult"/>.
        /// </returns>
        [Route("")]
        public IHttpActionResult GetPopularCategories()
        {
            var categoriesResult = CacheMethods.FetchAllCategories();
            var categories = new List<CategoryViewModel>();

            if (categoriesResult != null)
            {
                var searchResult = categoriesResult.Where(c => c.Popularity == 1);
                foreach (var categoryDTO in searchResult)
                {
                    var category = new CategoryViewModel();
                    DTOConverter.FillViewModelFromDTO(category, categoryDTO);
                    categories.Add(category);
                }
            }

            return Ok(categories);
        }
    }
}
