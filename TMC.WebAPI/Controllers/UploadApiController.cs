using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using TMC.Shared;
using TMC.Shared.Factories;
using TMC.Web.Shared.ViewModels;

namespace TMC.Web.Controllers.Api
{
    //http://www.asp.net/web-api/overview/advanced/sending-html-form-data,-part-2
    //todo put proper route names
     [EnableCors(origins: "http://localhost:55555", headers: "*", methods: "*")]
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
                        mediaViewModel.ServerFileName = listingResult.Data.ServerFileName;
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

        /// <summary>
        /// Return the image as Byte Array through the HttpResponseMessage object  
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="ext"></param>
        /// <returns></returns>
        [Route("Bytes/{fileName}/{ext}")]
        public HttpResponseMessage GetMedia(string fileName, string ext)
        {
            //S1: Construct File Path
            //var filePath = Path.Combine("~/Content/img/ListingMedia/", fileName);
             var filePath = HttpContext.Current.Server.MapPath("~/Content/img/ListingMedia/" + fileName);
            if (!File.Exists(filePath)) //Not found then throw Exception
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            HttpResponseMessage Response = new HttpResponseMessage(HttpStatusCode.OK);

            //S2:Read File as Byte Array
            byte[] fileData = File.ReadAllBytes(filePath);

            if (fileData == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            //S3:Set Response contents and MediaTypeHeaderValue
            Response.Content = new ByteArrayContent(fileData);
            Response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

            return Response;
        }

    }
}