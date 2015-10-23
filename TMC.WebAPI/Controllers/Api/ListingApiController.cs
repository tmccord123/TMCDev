using System;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using TMC.Web.Controllers;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.Web.ViewModels;

namespace TMC.Web.Controllers.Api
{
    using System.Collections.Generic;
    using TMC.Web.Shared;

    //http://www.asp.net/web-api/overview/web-api-routing-and-actions/create-a-rest-api-with-attribute-routing
    [RoutePrefix("api/listing")]// this is the base http://localhost:59974/api/listing
    public class ListingApiController : ApiController
    {
        [Route("{id:int}")]  // call like this http://localhost:59974/api/listing/1
        //[Route("{id:int}/details")] // call like this http://localhost:59974/api/listing/1/details
        // Hey the name of the method not necessarily to be Get only you can give any name starting with "Get" as it is using the route attribute here
        public IHttpActionResult GetListingById(int id)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetlistingById(id);
            var listingViewModel = new ListingViewModel();
            if (listingResult.IsValid())
            {
                DTOConverter.FillViewModelFromDTO(listingViewModel, listingResult.Data);
            }
            return Ok(listingViewModel);
        }

        [Route("{id:int}/contacts")]
        public IHttpActionResult GetListingContacts(int id)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetContactsByListingId(id);
            var listingViewModel = new ListingViewModel();
            if (listingResult.IsValid() && listingResult.Data.ListingContacts != null)
            {
                foreach (var listingContact in listingResult.Data.ListingContacts.Contacts)
                {
                    var listingContactViewModel = new ListingContactViewModel();
                    DTOConverter.FillViewModelFromDTO(listingContactViewModel, listingContact);
                    listingViewModel.ListingContacts.Contacts.Add(listingContactViewModel);
                }
            }
            return Ok(listingViewModel);
        }


        [Route("{id:int}/categories")]
        public IHttpActionResult GetListingCategories(int id)
        {
            /*var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetContactsByListingId(id);
            var listingViewModel = new ListingViewModel();
            if (listingResult.IsValid() && listingResult.Data.ListingContacts != null)
            {
                foreach (var listingContact in listingResult.Data.ListingContacts.Contacts)
                {
                    var listingContactViewModel = new ListingContactViewModel();
                    DTOConverter.FillViewModelFromDTO(listingContactViewModel, listingContact);
                    listingViewModel.ListingContacts.Contacts.Add(listingContactViewModel);
                }
            }*/
            List<CategoryViewModel> listingCategories = new List<CategoryViewModel>();
            CategoryViewModel category = new CategoryViewModel();
            category.Name = "category 1";
            listingCategories.Add(category);
            category = new CategoryViewModel();
            category.Name = "category 2";
            listingCategories.Add(category);

            category = new CategoryViewModel();
            category.Name = "category 3";
            listingCategories.Add(category);
            return Ok(listingCategories);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]ListingViewModel listingViewModel)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
                    DTOConverter.FillDTOFromViewModel(listingDto, listingViewModel);
                    var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
                    var listingResult = listingFacade.CreateListing(listingDto);
                    // ModelState.AddModelError("BusinessName", "Business name error occurred");
                    if (listingResult.IsValid())
                    {
                        ModelState.Remove("ListingId");
                        listingDto.ListingId = listingResult.Data.ListingId;
                        listingViewModel.ListingId = listingResult.Data.ListingId;
                        return Ok(listingViewModel);
                    }
                    if (listingViewModel == null)
                    {
                        return BadRequest();
                    }

                    return BadRequest(ModelState);

                }
                catch (Exception)
                {
                    return InternalServerError();
                }
            }
            else
            {
                return BadRequest(ModelState);

            }

        }

        ////[Route("expenses/{id}")]
        //[Route("{id:int}")]
        //public IHttpActionResult Put(int id, [FromBody]ListingViewModel listingViewModel)
        //{
        //    try
        //    {
        //        if (listingViewModel == null)
        //        {
        //            return BadRequest();
        //        }

        //        var listingDto = (IListingDTO)DTOFactory.Instance.Create(DTOType.Listing);
        //        DTOConverter.FillDTOFromViewModel(listingDto, listingViewModel);
        //        var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
        //        var listingResult = listingFacade.CreateListing(listingDto);
        //        if (listingResult.IsValid())
        //        {
        //            ModelState.Remove("ListingId");
        //            listingDto.ListingId = listingResult.Data.ListingId;
        //            listingViewModel.ListingId = listingResult.Data.ListingId;
        //            return Ok(listingViewModel);
        //        }
        //        return BadRequest();
        //    }
        //    catch (Exception)
        //    {
        //        return InternalServerError();
        //    }
        //}

        [Route("{cityId:int}/{categoryId:int}/{placeId}")]
        public IHttpActionResult GetListings(int cityId, int categoryId, string placeId)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetListings(cityId, placeId, categoryId);
            var allListings = new List<ListingViewModel>();
            if (listingResult.IsValid())
            {
                foreach (var listing in listingResult.Data)
                {
                    var listingViewModel = new ListingViewModel();
                    DTOConverter.FillViewModelFromDTO(listingViewModel, listing);
                    allListings.Add(listingViewModel);
                }
            }
            return Ok(allListings);
        }

        /// <summary>
        /// This is the overridden api route,
        /// This is accesed like this /api/listing/GetListingsByUserId/2
        /// This we can used when the same api rooute is used more than once like GetListingsByUserId/GetListingsByVendorId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [Route("GetListingsByUserId/{userId:int}")]
        public IHttpActionResult GetListingsByUserId(int userId)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetListingsByUserId(userId);
            var allListings = new List<ListingViewModel>();
            if (listingResult.IsValid())
            {
                foreach (var listing in listingResult.Data)
                {
                    var listingViewModel = new ListingViewModel();
                    DTOConverter.FillViewModelFromDTO(listingViewModel, listing);
                    allListings.Add(listingViewModel);
                }
            }
            return Ok(allListings);
        }
    }
}
