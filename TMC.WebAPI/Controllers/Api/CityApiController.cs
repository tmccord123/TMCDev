﻿
namespace TMC.WebAPI.Controllers.Api
{
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Linq;

    using TMC.Shared;
    using TMC.ViewModels;
    using TMC.Web.Shared;

    /// <summary>
    /// The city api controller.
    /// </summary>
    [RoutePrefix("api/city")]
    public class CityApiController : ApiController
    {
        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="IHttpActionResult"/>.
        /// </returns>
        public IHttpActionResult Get(string searchStr)
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
                        //DTOConverter.FillViewModelFromDTO(city, cityDTO);
                        city.CityId = cityDTO.CityId;
                        city.IsPopular = cityDTO.IsPopular;
                        city.Name = cityDTO.Name;
                        city.Lat = cityDTO.Lat;
                        city.Long = cityDTO.Long;
                        city.StateId = cityDTO.StateId;
                        city.PopulationClass = cityDTO.PopulationClass;
                        cities.Add(city);
                }
               
            }
            
            return Ok(cities);


        }


    }
}
