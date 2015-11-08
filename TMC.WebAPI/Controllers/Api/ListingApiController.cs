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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                    var listingContactViewModel = new ContactViewModel();
                    DTOConverter.FillViewModelFromDTO(listingContactViewModel, listingContact);
                    listingViewModel.ListingContacts.Contacts.Add(listingContactViewModel);
                }
            }
            return Ok(listingViewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id:int}/categories")]
        public IHttpActionResult GetListingCategories(int id)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetCategoriesByListingId(id);
            var listingViewModel = new ListingViewModel();
            if (listingResult.IsValid() && listingResult.Data.ListingCategories != null)
            {
                foreach (var listingCategory in listingResult.Data.ListingCategories.Categories)
                {
                    var listingCategoryViewModel = new CategoryViewModel();
                    DTOConverter.FillViewModelFromDTO(listingCategoryViewModel, listingCategory);
                    listingViewModel.ListingCategories.Categories.Add(listingCategoryViewModel);
                }
            }
            return Ok(listingViewModel.ListingCategories);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id:int}/serviceLocations")]
        public IHttpActionResult GetListingServiceAreas(int id)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetServiceLocationsByListingId(id);
            var listingViewModel = new ListingViewModel();
            if (listingResult.IsValid() && listingResult.Data.ListingServiceLocations != null)
            {
                foreach (var listingServiceArea in listingResult.Data.ListingServiceLocations.ServiceLocations)
                {
                    var listingServiceAreaViewModel = new ServiceLocationViewModel();
                    DTOConverter.FillViewModelFromDTO(listingServiceAreaViewModel, listingServiceArea);
                    listingViewModel.ListingServiceLocations.ServiceLocations.Add(listingServiceAreaViewModel);
                }
            } 
            return Ok(listingViewModel.ListingServiceLocations);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id:int}/paymentmodes")]
        public IHttpActionResult GetListingPaymentModes(int id)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetPaymentModesByListingId(id);
            var listingViewModel = new ListingViewModel();
            if (listingResult.IsValid() && listingResult.Data.ListingPaymentModes != null)
            {
                foreach (var listingPaymentMode in listingResult.Data.ListingPaymentModes.PaymentModes)
                {
                    var listingPaymentModeViewModel = new PaymentModeViewModel();
                    DTOConverter.FillViewModelFromDTO(listingPaymentModeViewModel, listingPaymentMode);
                    listingViewModel.ListingPaymentModes.PaymentModes.Add(listingPaymentModeViewModel);
                }
            }
            return Ok(listingViewModel.ListingPaymentModes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id:int}/medias")]
        public IHttpActionResult GetListingMedias(int id)
        {
            var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
            var listingResult = listingFacade.GetMediasByListingId(id);
            var listingViewModel = new ListingViewModel();
            if (listingResult.IsValid() && listingResult.Data.ListingMedias != null)
            {
                foreach (var listingMedia in listingResult.Data.ListingMedias.Medias)
                {
                    var listingMediaViewModel = new MediaViewModel();
                    DTOConverter.FillViewModelFromDTO(listingMediaViewModel, listingMedia);
                    listingViewModel.ListingMedias.Medias.Add(listingMediaViewModel);
                }
            }
            return Ok(listingViewModel.ListingMedias);
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

        [Route("{cityId:int}/{categoryId:int}/{placeId?}")]
        public IHttpActionResult GetListings(int cityId, int categoryId, string placeId = null)
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

        #region POST Methods
        [Route("addCategory")]
        [HttpPost]
        public IHttpActionResult Post(CategoryViewModel categoryViewModel)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var categoryDto = (ICategoryDTO)DTOFactory.Instance.Create(DTOType.Category);
                    DTOConverter.FillDTOFromViewModel(categoryDto, categoryViewModel);
                    var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
                    var listingResult = listingFacade.CreateListingCategory(categoryDto); 
                    if (listingResult.IsValid())
                    {
                        ModelState.Remove("ListingId");
                        categoryViewModel.ListingCategoryId = listingResult.Data;
                        return Ok(categoryViewModel);
                    }
                    if (categoryViewModel == null)
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

        [Route("addServiceLocation")]
        [HttpPost]
        public IHttpActionResult Post(ServiceLocationViewModel serviceLocationViewModel)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var serviceLocationDto = (IServiceLocationDTO)DTOFactory.Instance.Create(DTOType.ServiceLocation);
                    DTOConverter.FillDTOFromViewModel(serviceLocationDto, serviceLocationViewModel);
                    var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
                    var listingResult = listingFacade.CreateListingServiceLocation(serviceLocationDto);
                    if (listingResult.IsValid())
                    {
                        ModelState.Remove("ListingId");
                        serviceLocationViewModel.ListingServiceLocationId = listingResult.Data;
                        return Ok(serviceLocationViewModel);
                    }
                    if (serviceLocationViewModel == null)
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
      
        #endregion
    }
}
