using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.WebPages;
using Microsoft.Ajax.Utilities;

using TMC.Shared;
using TMC.Shared.Factories;
using TMC.Web.ViewModels;


namespace TMC.Web.Controllers
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using TMC.Web;

    public class LocalBoardController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <param name="cityName">
        /// The city name.
        /// </param>
        /// <param name="categoryName">
        /// The category name.
        /// </param>
        /// <param name="cityId">
        /// The city id.
        /// </param>
        /// <param name="categoryId">
        /// The category id.
        /// </param>
        /// <param name="placeId">
        /// The place id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<ActionResult> Index(string cityName, string categoryName, int? cityId, int? categoryId, string placeId)
        {
            var model = new LocalBoardViewModel();
            model.SeoTitle = Request.RawUrl.Replace("/LocalBoard/", "");
            if (!String.IsNullOrWhiteSpace(cityName) && !String.IsNullOrWhiteSpace(categoryName))
            {
                model.SearchResultHeading =
                    ResourceUtility.GetCaptionFor(ResourceConstants.Listing.Labels.LocalBoardSearchHeading)
                                   .Replace(model.CategoryPlaceHolder, categoryName)
                                   .Replace(model.CityPlaceHolder, cityName);
                model.TrendHeading = ResourceUtility.GetCaptionFor(ResourceConstants.Listing.Labels.LocalBoardTrendsHeading)
                                   .Replace(model.PlacePlaceHolder, cityName);
            }
            var client = TMCHttpClient.GetClient();
            var listingUrl = "api/listing" + "/" + cityId.ToString() + "/" + categoryId.ToString() + "/" + placeId;
            HttpResponseMessage listingResponse = await client.GetAsync(listingUrl);
            if (listingResponse.IsSuccessStatusCode)
            {
                string categoriesContent = await listingResponse.Content.ReadAsStringAsync();
                var listings = JsonConvert.DeserializeObject<List<ListingViewModel>>(categoriesContent);

                model.Listings = listings;
                model.ControllerName = "LocalBoard";
            }
            else
            {
                return Content("An error occurred.");
            }

            return View(model);
        }

        public async Task<ActionResult> GetListingsData(int cityId, int categoryId, string placeId, int pageIndex, int pageSize)
        {
            var retVal = new List<ListingViewModel>();
            var client = TMCHttpClient.GetClient();
            var listingUrl = "api/listing" + "/" + cityId.ToString() + "/" + categoryId.ToString() + "/" + placeId;
            HttpResponseMessage listingResponse = await client.GetAsync(listingUrl);
            if (listingResponse.IsSuccessStatusCode)
            {
                string categoriesContent = await listingResponse.Content.ReadAsStringAsync();
                retVal = JsonConvert.DeserializeObject<List<ListingViewModel>>(categoriesContent);

            }
            else
            {
                return Content("An error occurred.");
            }
            return PartialView("_ListingSearchResults", retVal);
        }
         
    }
}
