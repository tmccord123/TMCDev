
namespace TMC.WebAPI.Controllers
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using Newtonsoft.Json;

    using TMC.ViewModels;
    using TMC.WebAPI;

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
            }
            else
            {
                return Content("An error occurred.");
            }
            return View("Index", model);
        }
    }
}