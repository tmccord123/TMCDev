using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TMC.Shared;
using TMC.ViewModels;
using TMC.Web.Shared;

namespace TMC.WebAPI.Controllers.Api
{
    // call like this http://localhost:59974/api/PlaceAutoCompleteApi?searchParams=28.459497,77.026634,20000,palam
  //  [RoutePrefix("api/vendor")]PlaceAutoCompleteApi
    public class PlaceAutoCompleteApiController : ApiController
    {
        public IHttpActionResult Get(string searchParams)
        {
             var jsonAutoCompleteResult = string.Empty;
            string lattitude = searchParams.Split(',')[0];
            string longitude = searchParams.Split(',')[1];
            string radius = searchParams.Split(',')[2];
            string name = searchParams.Split(',')[3];
            using (var webClient  = new WebClient())
            {
              
                // for gurgaon lat = 28.459497, long = 77.026634, radius = 2000
                //   cord api Key AIzaSyDyZlIZ3v25T8uJbaGjemnzUgKLTDMHaWY
                string mapApiUri =
                    "https://maps.googleapis.com/maps/api/place/autocomplete/json?input=[NAME]&types=[TYPES]&location=[LAT],[LONG]&radius=[RADIUS]&key=[APIKEY]";
                mapApiUri = mapApiUri.Replace("[LAT]", lattitude);
                mapApiUri = mapApiUri.Replace("[LONG]", longitude);
                mapApiUri = mapApiUri.Replace("[RADIUS]", radius);
                mapApiUri = mapApiUri.Replace("[NAME]", name);
                mapApiUri = mapApiUri.Replace("[TYPES]", "geocode");
                mapApiUri = mapApiUri.Replace("[APIKEY]", "AIzaSyDyZlIZ3v25T8uJbaGjemnzUgKLTDMHaWY");//TODO TO BE KEPT IN CONFIG
                // attempt to download JSON data as a string
                try
                {
                    jsonAutoCompleteResult = webClient.DownloadString(mapApiUri);
                }
                catch (Exception)
                {
                    
                }
             
            }


            return Ok(JObject.Parse(jsonAutoCompleteResult));


        }


    }
}
