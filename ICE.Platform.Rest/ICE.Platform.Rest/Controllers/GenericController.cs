using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Platform.Rest.Controllers
{
    using Filters;

    [Route("generic/{entity}")]
    [ApiController]
    [BeforeRequestFilter]
    public class GenericController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            return new JsonResult(new { status = true });
        }
    }
}