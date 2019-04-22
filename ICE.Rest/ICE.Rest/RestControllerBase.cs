using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Rest
{
    using ICE.Platform;

    [Route("api/rest/[controller]")]
    [ApiController]
    public abstract class RestControllerBase<E> : ControllerBase where E : IPlatformEntity
    {
        protected IPlatformSet<E> Set { get; private set; }        

        public RestControllerBase(IPlatformContext context)
        {
            this.Set = context.GetSet<E>();
        }

        public RestControllerBase(IPlatformTrigger<E> trigger, IPlatformContext context) 
        {            
            this.Set = context.GetSet<E>(trigger);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<E>> Get(string id)
        {
            var result = await this.Set.Read(id);

            if (result.Count() == 0) return NotFound();

            return result.FirstOrDefault();
        }
    }
}
