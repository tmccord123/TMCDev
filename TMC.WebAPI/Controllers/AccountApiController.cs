using System;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.ModelBinding;
using TMC.Web.Controllers;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.Web.Shared.ViewModels;

namespace TMC.Web.Controllers.Api
{
    using System.Collections.Generic;
    using TMC.Web.Shared;
     
    [RoutePrefix("api/account")]
    [EnableCors(origins: "http://localhost:55555", headers: "*", methods: "*")]
    public class AccountApiController : ApiController
    {
        [Route("{id:int}")]
        public IHttpActionResult GetUserById(int id)//todo to be implemented if needed
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

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]UserViewModel userViewModel)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var userDto = (IUserDTO)DTOFactory.Instance.Create(DTOType.User);
                     
                    DTOConverter.FillDTOFromViewModel(userDto, userViewModel);
                    userDto.CreatedOn = DateTime.Now;
                    userDto.UpdatedOn = DateTime.Now;
                    userDto.CreatedBy = 1;
                    userDto.UpdatedBy = 1;
                    userDto.IsActive = true;
                    userDto.AreaId = "sdfjskldf-sdfsdf-sdf-123";//todo
                    var userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.User);
                    var userResult = userFacade.CreateUser(userDto); 
                    if (userResult.IsValid())
                    {
                        //ModelState.Remove("ListingId");
                        //userDto.ListingId = userResult.Data.ListingId;
                        //userViewModel.ListingId = userResult.Data.ListingId;
                        return Ok(userViewModel);
                    }
                    if (userViewModel == null)
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

         
    }
}
