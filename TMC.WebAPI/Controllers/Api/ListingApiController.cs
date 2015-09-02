using System.Web.Http;
using TMC.Shared;
using TMC.ViewModels;

namespace TMC.WebAPI.Controllers.Api
{
    // call like this http://localhost:59974//api/vendorapi/1
    [System.Web.Http.RoutePrefix("api/listing")]
    public class ListingApiController : ApiController
    {
        public IHttpActionResult Get(int id, string fields = null)
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
