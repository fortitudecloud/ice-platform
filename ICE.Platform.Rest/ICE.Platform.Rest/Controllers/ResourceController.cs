using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Platform.Rest.Controllers
{
    using Core;

    [Route("api/resource/{*url}")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private IPlatformResourceFactory factory;

        private string UrlParam
        {
            get
            {
                return this.RouteData.Values.Values.Select(v => v.ToString()).ToArray()[0];
            }
        }

        private string ResourceName
        {
            get
            {                
                return this.UrlParam.Substring(0, this.UrlParam.IndexOf(@"/"));
            }
        }

        private string RouteParam
        {
            get
            {
                return this.UrlParam.Substring(this.UrlParam.IndexOf(@"/") + 1);
            }
        }

        public ResourceController(IPlatformResourceFactory factory) => this.factory = factory;

        [HttpGet]
        public ActionResult Get()
        {
            var resource = factory.Get(this.ResourceName);

            if (resource == null) return new StatusCodeResult(404);

            var routeTask = factory.GetRouteResult(resource, this.RouteParam, Core.Structs.HttpMethod.GET);

            if (routeTask == null) return new StatusCodeResult(404);            

            return new ObjectResult(routeTask.Result);
        }        
    }
}