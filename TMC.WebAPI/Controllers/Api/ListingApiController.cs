using System;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using TMC.Shared;
using TMC.Web.ViewModels;
using TMC.Web.Shared.Common.Extensions;

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
            var listingViewModel = new ListingViewModel();
            if (listingResult.IsValid())
            {
                listingViewModel.ContactEmailId = listingResult.Data.ContactEmailId;
                listingViewModel.BusinessName = listingResult.Data.BusinessName;
                listingViewModel.ContactPerson = listingResult.Data.ContactPerson;

            }
            return Ok(listingViewModel);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post([ModelBinder(typeof(JsonPolyModelBinder))]ITrimmedListingDTO expenseGroup)
        {
            try
            {
                if (expenseGroup == null)
                {
                    return BadRequest();
                }

                /*// try mapping & saving
                var eg = _expenseGroupFactory.CreateExpenseGroup(expenseGroup);

                var result = _repository.InsertExpenseGroup(eg);
                if (result.Status == RepositoryActionStatus.Created)
                {
                    // map to dto
                    var newExpenseGroup = _expenseGroupFactory.CreateExpenseGroup(result.Entity);
                    return Created<DTO.ExpenseGroup>(Request.RequestUri
                        + "/" + newExpenseGroup.Id.ToString(), newExpenseGroup);
                }*/

                return BadRequest();

            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
        
        /*[working one] [Route("")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]TrimmedListingDTO expenseGroup)
        {
            try
            {
                if (expenseGroup == null)
                {
                    return BadRequest();
                }

                /#1#/ try mapping & saving
                var eg = _expenseGroupFactory.CreateExpenseGroup(expenseGroup);

                var result = _repository.InsertExpenseGroup(eg);
                if (result.Status == RepositoryActionStatus.Created)
                {
                    // map to dto
                    var newExpenseGroup = _expenseGroupFactory.CreateExpenseGroup(result.Entity);
                    return Created<DTO.ExpenseGroup>(Request.RequestUri
                        + "/" + newExpenseGroup.Id.ToString(), newExpenseGroup);
                }#1#

                return BadRequest();

            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }*/
    }
}
