using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TMC.Shared;
using TMC.Web.Shared.ViewModels;
using TMC.Web.Shared;

namespace TMC.WebAPI.Controllers
{
    // call like this http://localhost:59974/api/PlaceAutoCompleteApi?searchParams=28.459497,77.026634,20000,palam
    [RoutePrefix("api/placeAutoComplete")]
    [EnableCors(origins: "http://localhost:55555", headers: "*", methods: "*")]
    public class PlaceAutoCompleteApiController : ApiController
    {
        [Route("{searchParams}")] 
        public IHttpActionResult Get(string searchParams)
        {
             var jsonAutoCompleteResult = string.Empty;
            string lattitude = searchParams.Split(',')[0];
            string longitude = searchParams.Split(',')[1];
            string radius = searchParams.Split(',')[2];
            string name = searchParams.Split(',')[3];
            //todo
            if (radius == "0")
            {
                radius = "5000";
            }

            using (var webClient  = new WebClient())
            {
              
                // for gurgaon lat = 28.459497, long = 77.026634, radius = 2000
                //   cord api Key AIzaSyDyZlIZ3v25T8uJbaGjemnzUgKLTDMHaWY
                string mapApiUri =
                    "https://maps.googleapis.com/maps/api/place/autocomplete/json?input=[NAME]&types=[TYPES]&location=[LAT],[LONG]&radius=[RADIUS]&key=[APIKEY]";
                string mapApiUri2 =
                    "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=[LAT],[LONG]&radius=[RADIUS]&name=[NAME]&key=[APIKEY]";   
                string mapApiUri1 =
                    "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=[LAT],[LONG]&radius=[RADIUS]&types=[TYPES]&name=[NAME]&key=[APIKEY]";
                //  "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=28.459497,77.026638&radius=5000&types=establishment&name=palam&key=AIzaSyDyZlIZ3v25T8uJbaGjemnzUgKLTDMHaWY"
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
