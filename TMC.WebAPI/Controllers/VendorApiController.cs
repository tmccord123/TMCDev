using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TMC.Shared;
using TMC.Web.Shared.ViewModels;
using TMC.Web.Shared;

namespace TMC.WebAPI.Controllers
{
    // call like this http://localhost:59974//api/vendor/1
    [System.Web.Http.RoutePrefix("api/vendor")]
    [EnableCors(origins: "http://localhost:55555", headers: "*", methods: "*")]
    public class VendorApiController : ApiController
    {
        [Route("{id:int}")] 
        public System.Web.Http.IHttpActionResult Get(int id, string fields = null)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.User);
            var vendorResult = userFacade.GetUserById(1); //todo 
            var vendorViewModel = new UserViewModel();
            if (vendorResult.IsValid())
            {
                //todo check if the data is valid
                var listingViewModel = new ListingViewModel();
                
               // var listingResult = listingFacade.GetlistingById(1);// todo

                // DTOConverter.FillViewModelFromDTO(listingViewModel, listingResult.Data );
               // DTOConverter.FillViewModelFromDTO(vendorViewModel, vendorResult.Data);
                vendorViewModel.AddressLine1 = vendorResult.Data.AddressLine1;
                vendorViewModel.AddressLine2 = vendorResult.Data.AddressLine2;
                vendorViewModel.UserName = vendorResult.Data.UserName;
                vendorViewModel.FirstName = vendorResult.Data.FirstName;
               // listingViewModel.Owner = vendorViewModel;
            }



            return Ok(vendorViewModel);


        }

      



    }
}
