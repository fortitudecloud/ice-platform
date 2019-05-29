using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Platform.Rest.Controllers
{
    using ICE.Platform.Core;
    using Filters;

    [Route("api/rest/{entity}")]
    [ApiController]
    [EntityResourceFilter]
    [HttpMutationFilter]
    public class RestController : ControllerBase, IRestController
    {
        public IGenericPlatformSet Set { get { return Context.Set<IGenericPlatformSet>(Entity); } }

        public IPlatformContext Context { get; set; }        

        public Type Entity => (Type)HttpContext.Items["Entity"];

        public RestController(IPlatformContext context) => this.Context = context;

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var result = await this.Set.Read(id);

            if (((IEnumerable<object>)result).Count() == 0) return NotFound();

            return new ObjectResult(((IEnumerable<object>)result).FirstOrDefault());
        }                
    }
}