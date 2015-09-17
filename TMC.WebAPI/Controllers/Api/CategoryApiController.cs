
namespace TMC.WebAPI.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using TMC.Shared;
    using TMC.ViewModels;
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
        public IHttpActionResult Get(string searchStr)
        {
            var commonFacade = (ICommonFacade)FacadeFactory.Instance.Create(FacadeType.Common);
            var searchString = searchStr.ToLower();
            var categoriesResult = commonFacade.GetCategories();
            var categories = new List<CategoryViewModel>();
            
            if (categoriesResult.IsValid() && categoriesResult.Data != null)
            {
                var searchResult = categoriesResult.Data.Where(c => c.Name.ToLower().Contains(searchString));
                foreach (var categoryDTO in searchResult)
                {
                    var category = new CategoryViewModel();
                    category.CategoryId = categoryDTO.CategoryId;
                    category.Popularity = categoryDTO.Popularity;
                    category.Name = categoryDTO.Name;
                    category.ShortName = categoryDTO.ShortName;
                   
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
        public IHttpActionResult Get()
        {
            var commonFacade = (ICommonFacade)FacadeFactory.Instance.Create(FacadeType.Common);
          
            var categoriesResult = commonFacade.GetCategories();
            var categories = new List<CategoryViewModel>();

            if (categoriesResult.IsValid() && categoriesResult.Data != null)
            {
                var searchResult = categoriesResult.Data.Where(c => c.Popularity == 1);
                foreach (var categoryDTO in searchResult)
                {
                    var category = new CategoryViewModel();
                    category.CategoryId = categoryDTO.CategoryId;
                    category.Popularity = categoryDTO.Popularity;
                    category.Name = categoryDTO.Name;
                    category.ShortName = categoryDTO.ShortName;

                    categories.Add(category);
                }
            }

            return Ok(categories);
        }
    }
}
