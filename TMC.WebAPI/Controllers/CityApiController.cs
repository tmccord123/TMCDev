
using System.Web.Http.Cors;

namespace TMC.WebAPI.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Linq;

    using TMC.Shared;
    using TMC.Web.Shared.ViewModels;
    using TMC.Web.Shared;

    // <summary>
    /// The city api controller.
    /// </summary>
    [RoutePrefix("api/city")]
    [EnableCors(origins: "http://localhost:55555", headers: "*", methods: "*")]
    public class CityApiController : ApiController
    {
        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="IHttpActionResult"/>.
        /// </returns>
        [Route("{searchStr}")] 
        public IHttpActionResult GetCitiesByString(string searchStr)
        {
            var searchString = searchStr.ToLower();
            var citiesResult = CacheMethods.FetchAllCities();
            var cities = new List<CityViewModel>();
            
            if (citiesResult != null)
            {
                var searchResult = citiesResult.Where(c => c.Name.ToLower().Contains(searchString));
                foreach (var cityDTO in searchResult)
                {
                        var city = new CityViewModel();
                        DTOConverter.FillViewModelFromDTO(city, cityDTO);
                        cities.Add(city);
                }
               
            }
            
            return Ok(cities);


        }


    }
}
