using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Platform.Rest.Controllers
{
    [Route("api/resource/{*url}")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(string id)
        {
            // TODO: perform regex match on the "url" RouteData value to the 
            // routes defined on the custom resources to determine the correct method to call

            // e.g. regex
            // url: 'dog/123'
            // regex: '\w+/\w+'

            return new ObjectResult(new
            {
                status = 200
            });
        }
    }
}