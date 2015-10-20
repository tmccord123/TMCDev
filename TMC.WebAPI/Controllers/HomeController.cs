using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

using Newtonsoft.Json;

using TMC.Web.ViewModels;
using TMC.Web;
namespace TMC.Web.Controllers
{
  

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <param name="permalink">
        /// The permalink.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public async Task<ActionResult> Index(string permalink)
        {
            var client = TMCHttpClient.GetClient();

            var model = new HomeViewModel();

            //HttpResponseMessage citiesResponse = await client.GetAsync("api/cityapi/");
            HttpResponseMessage categoriesResponse = await client.GetAsync("api/category");
            //if (citiesResponse.IsSuccessStatusCode && categoriesResponse.IsSuccessStatusCode)
            if (categoriesResponse.IsSuccessStatusCode)
            {
                //    //string citiesContent = await citiesResponse.Content.ReadAsStringAsync();
                //    //var cities = JsonConvert.DeserializeObject<List<CityViewModel>>(citiesContent);

                string categoriesContent = await categoriesResponse.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<List<CategoryViewModel>>(categoriesContent);

                //    //model.Cities = cities;
                model.TopCategories = categories;
                model.ControllerName = "HomeController";
                model.CitySaytHome = new CitySaytViewModel();
                model.CitySaytHome.ControlId = "ddlCitiesHome";
                model.CitySaytHome.HtmlFieldPrefix = "CitySaytHome";               
                model.CitySaytHome.SelectCallBack = "";

                model.PlaceSaytHome = new PlaceSaytViewModel();
                model.PlaceSaytHome.ControlId = "ddlPlacesHome";
                model.PlaceSaytHome.HtmlFieldPrefix = "PlaceSaytHome";
                model.PlaceSaytHome.SelectCallBack = "";
                model.PlaceSaytHome.SelectedCityDetailsId = model.CitySaytHome.SelectedCityDetailsFieldId;

                model.CategorySaytHome = new CategorySaytViewModel();
                model.CategorySaytHome.ControlId = "ddlCategoriesHome";
                model.CategorySaytHome.HtmlFieldPrefix = "CategorySaytHome";
                model.CategorySaytHome.SelectCallBack = ""; 
            }
            else
            {
                return Content("An error occurred.");
            }
            return View("Index", model);
        }
    }
}