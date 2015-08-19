using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.WebPages;
using Microsoft.Ajax.Utilities;
using TMC.Data;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.ViewModels;


namespace TMC.Controllers
{
    
    
    public class CouponsController : Controller
    {
          
        //[Route("seo/Coupons/{permalink}")]
        public ActionResult Index(string seoParam)
        {
        
            var seoTitle = Request.RawUrl.Replace("/Coupons/", "");

            var productDAC = new ProductDAC();
            var productDto = productDAC.ReadProductBySeoTitle(seoTitle);
            var productItemModel = new ProductItemViewModel();
            productItemModel.Description = productDto.Description;
            productItemModel.Name = productDto.Name;
            productItemModel.Content = productDto.Content;
            productItemModel.SeoTitle = productDto.SeoTitle;
            productItemModel.ImageURL = productDto.ImageURL;

            if (seoTitle.IsNullOrWhiteSpace() || productItemModel.SeoTitle.IsNullOrWhiteSpace() || seoTitle == "Index")
            {
                return RedirectToAction("FourOhFour", "Other");
            }


            return View(productItemModel);
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

            ProductDAC producManager = new ProductDAC();
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
