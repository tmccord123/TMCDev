﻿using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using Newtonsoft.Json;
using System.Net.Http;

namespace TMC.Web.Shared.Common.Extensions
{
    public class JsonPolyModelBinder : IModelBinder
    {
        readonly JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            var content = actionContext.Request.Content;
            string json = content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeObject(json, bindingContext.ModelType, settings);
            bindingContext.Model = obj;
            return true;
        }
    }
}
