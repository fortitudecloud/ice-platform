using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace ICE.Platform.Rest.Controllers
{
    using ICE.Platform.Core;
    using Filters;

    [Route("api/rest/{entity}")]
    [ApiController]
    [EntityResourceFilter]
    [HttpMutationFilter]
    [EnableCors]
    public class RestController : ControllerBase, IRestController
    {
        public IGenericPlatformSet Set { get { return Context.Set<IGenericPlatformSet>(Entity); } }

        public IPlatformRestContext Context { get; set; }        

        public Type Entity => (Type)HttpContext.Items["Entity"];

        public RestController(IPlatformRestContext context) => this.Context = context;

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var result = await this.Set.Read(id);            

            if (result == null) return NotFound();
            
            return new JsonResult(result);
        }     

        [HttpGet]
        public async Task<ActionResult> Query(string rawQuery)
        {
            var result = await this.Set.Query(rawQuery);

            if (result == null) return BadRequest();

            return new JsonResult(result);
        }
        
        [HttpPost]
        public async Task<ActionResult> Post(object entityObject)
        {
            var result = await this.Set.Create(entityObject);

            if (result == null) return BadRequest();

            // set status code to created
            return new JsonResult(result);
        }    
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var result = await this.Set.Delete(id);

            if (result == null) return NotFound();
                        
            return new JsonResult(result);
        }
    }
}