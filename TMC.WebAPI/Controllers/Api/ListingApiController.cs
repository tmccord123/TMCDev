using System.Web.Http;
using TMC.Shared;
using TMC.ViewModels;

namespace TMC.WebAPI.Controllers.Api
{
    //http://www.asp.net/web-api/overview/web-api-routing-and-actions/create-a-rest-api-with-attribute-routing
    [System.Web.Http.RoutePrefix("api/listing")]// this is the base http://localhost:59974/api/listing
    public class ListingApiController : ApiController
    {
        [Route("{id:int}")]  // call like this http://localhost:59974/api/listing/1
        //[Route("{id:int}/details")] // call like this http://localhost:59974/api/listing/1/details
        public IHttpActionResult Getsdfdf(int id, string fields = null)// Hey the name of the method not necessarily to be Get only 
            //you can give any name starting with "Get" as it is using the route attribute here
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetlistingById(id);
            var listingViewModel = new ListingItemViewModel();
            if (listingResult.IsValid())
            {
                listingViewModel.ContactEmailId = listingResult.Data.EmailId;
                listingViewModel.BusinessName = listingResult.Data.CompanyName;
                listingViewModel.ContactPerson = listingResult.Data.ContactPerson;

            }
            return Ok(listingViewModel);
        }
    }
}
