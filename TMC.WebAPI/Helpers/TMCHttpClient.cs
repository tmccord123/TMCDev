using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using TMC.Shared;
using GlobalConstants = TMC.Web.Shared.GlobalConstants;

namespace TMC.WebAPI
{
    public static class TMCHttpClient
    {

        public static HttpClient GetClient(string requestedVersion = null)
        {
           
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(GlobalConstants.TMCAPI);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            if (requestedVersion != null)
            {
                // through a custom request header
                //client.DefaultRequestHeaders.Add("api-version", requestedVersion);

                // through content negotiation
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.expensetrackerapi.v" 
                        + requestedVersion + "+json"));
            }


            return client;
        }
    }
}