using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.Web.ViewModels;

namespace TMC.Web.Controllers.Api
{
    //http://www.asp.net/web-api/overview/advanced/sending-html-form-data,-part-2
    public class UploadApiController : ApiController
    {
        /*public async Task<HttpResponseMessage> PostFormData()
        {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                // Read the form data.
                await Request.Content.ReadAsMultipartAsync(provider);

                // This illustrates how to get the file names.
                foreach (MultipartFileData file in provider.FileData)
                {
                    Trace.WriteLine(file.Headers.ContentDisposition.FileName);
                    Trace.WriteLine("Server file path: " + file.LocalFileName);
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }*/

        public HttpResponseMessage Post()
        {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<MediaViewModel>();
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var serverFileName = Guid.NewGuid() + "_" + postedFile.FileName;
                    var filePath = HttpContext.Current.Server.MapPath("~/Content/img/ListingMedia/" + serverFileName);
                    var listingFacade = (IListingFacade)FacadeFactory.Instance.Create(FacadeType.Listing);
                    var fileDto = (IFileDTO)DTOFactory.Instance.Create(DTOType.File);
                    fileDto.FileExtensionId = 3;
                    fileDto.FileTypeId = 1;
                    fileDto.ListingId = 20;//todo
                    fileDto.Description = "";
                    fileDto.FileTitle = "";
                    fileDto.OriginalFileName = postedFile.FileName; 
                    fileDto.ServerFileName =serverFileName;
                    fileDto.ServerPath = "ListingMedia";//todo
                    var listingResult = listingFacade.CreateListingMedia(fileDto);
                    if (listingResult.IsValid())
                    {
                        MediaViewModel mediaViewModel = new MediaViewModel();
                        mediaViewModel.FileName = listingResult.Data.FileName;
                        mediaViewModel.ListingId = fileDto.ListingId;
                        mediaViewModel.ListingMediaId = listingResult.Data.ListingMediaId;
                        mediaViewModel.FileId = listingResult.Data.FileId;
                        postedFile.SaveAs(filePath);
                        docfiles.Add(mediaViewModel);
                    }
                    
                }
                result = Request.CreateResponse(HttpStatusCode.Created, docfiles);
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return result;
        }

    }
}