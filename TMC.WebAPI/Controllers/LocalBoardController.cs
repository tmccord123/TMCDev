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

        private IProductDTO getProductDTO(ProductItemViewModel productMaster, bool creatingProduct)
        {
            IProductDTO product = (IProductDTO)DTOFactory.Instance.Create(DTOType.Product);
            try
            {

                product.ProductId = 1;
                product.Name = "Pay TTm";// productMaster.Title.Trim();
                product.Content = productMaster.Content.Trim();
                product.ContentText = productMaster.ContentText;
                if (creatingProduct)
                {
                    //product.CreatedBy = this.LoggedInUserID; 
                }
                /*   else
                   {
                       help.ModifiedBy = this.LoggedInUserID;
                       if (!string.IsNullOrEmpty(helpMaster.HelpCode))
                          help.HelpCode = helpMaster.HelpCode.Trim();
                   } */

            }
            catch (Exception ex)
            {
                //ExceptionManager.HandleException(ex);
            }
            return product;//
        }




        [HttpPost]
        public JsonResult CreateHelp(ProductItemViewModel productMaster)
        {
            //OperationResult<long> createHelpResult = null;
            ActionResult actionResult = null;
            IProductDTO helpDTO = this.getProductDTO(productMaster, true);

            // helpDTO.ModifiedBy = this.LoggedInUserID;

            //HelpVersionWorkFlowStep workflowStep=(HelpVersionWorkFlowStep)Enum.Parse(typeof(HelpVersionWorkFlowStep), helpMaster.VersionWorkflowStep);
            //helpDTO.VersionWorkflowStep = workflowStep == HelpVersionWorkFlowStep.CHECKINANDAPPROVE ? HelpVersionWorkflowStatus.PENDINGFORAPPROVALBYCLIENTADMIN : HelpVersionWorkflowStatus.PENDINGFORAPPROVALBYSITEADMIN;

            IProductDAC producManager = (IProductDAC)DACFactory.Instance.Create(DACType.Product);
            var result = producManager.CreateProduct(helpDTO);
            /*if (createHelpResult != null && createHelpResult.IsValid())
            {
                ProductSettings productSettings = new ProductSettings(this.ProductID, this.LoggedInSiteID, this.LanguageID, true);
                helpResult = helpManager.GetHelpInformation(createHelpResult.Data, productSettings, this.LoggedInUserID, HelpVersion.Default);
                if (helpResult != null && helpResult.IsValid())
                {
                    helpDTO = helpResult.Data;
                    HelpTreeNode helpNode = new HelpTreeNode();
                    if (helpDTO.Title.Length > 20)
                    {
                        helpNode.title = helpDTO.Title.Substring(0, 18) + "..";
                    }
                    else
                    {
                        helpNode.title = helpDTO.Title;
                    }
                    helpNode.tooltip = helpDTO.Title;
                    helpNode.isFolder = helpDTO.IsFolder;
                    helpNode.key = helpDTO.HelpMasterID.ToString();

                    helpNode.prevKey = prevHelpMasterID.ToString();
                    helpNode.absolutePath = helpDTO.HelpAbsolutePath;

                    helpNode.canEdit = helpDTO.CreatedBy == this.LoggedInUserID ||
                                           this.UserRole == UserRole.Administrator ||
                                           this.UserRole == UserRole.SuperClientAdministrator;

                    helpDTO = GetUserDetails(helpDTO);

                    createHelpModel.HelpMasterId = helpDTO.HelpMasterID;
                    createHelpModel.JsonHelpTreeNode = JsonUtility.Serialize(helpNode);



                    finalOperationResult = OperationResult<CreateHelpModel>.CreateSuccessResult(createHelpModel);
                    actionResult = SmartView<CreateHelpModel>(finalOperationResult);
                }
                else
                {
                    finalOperationResult = OperationResult<CreateHelpModel>.CreateFailureResult("Error while getting help information.");
                    actionResult = SmartView<CreateHelpModel>(finalOperationResult);
                }*/

            //}
            /*   else
               {
                   finalOperationResult = OperationResult<CreateHelpModel>.CreateFailureResult("Help could not be created");
                   actionResult = SmartView<CreateHelpModel>(finalOperationResult);
               }*/

            return Json(true);// actionResult;
        }

    }
}
