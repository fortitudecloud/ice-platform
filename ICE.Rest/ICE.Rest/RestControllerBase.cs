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
        private IDictionary<string, string> headers;

        private IDictionary<string, string> Headers
        {
            get
            {
                if (headers == null)
                {
                    headers = new Dictionary<string, string>();
                    
                }

                return headers;
            }
        }

        protected IPlatformSet<E> Set { get; private set; }

        private IPlatformContext context;

        public RestControllerBase(IPlatformContext context)
        {
            this.Set = context.GetSet<E>();
            this.context = context;
        }

        public RestControllerBase(IPlatformTrigger<E> trigger, IPlatformContext context) 
        {            
            this.Set = context.GetSet<E>(trigger);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<E>> Get(string id)
        {
            var result = await this.Set.Read(id);

            var mutations = Platform.GetMutationList<E>(MutationType.Response, MutationOperation.Read);

            if(mutations.Count() == 0)
            {
                if (result.Count() == 0) return NotFound();

                return result.FirstOrDefault();
            }

            object mutatedResult = result;

            foreach(var mutation in mutations)
            {
                var m = (IPlatformMutation)Activator.CreateInstance(mutation);
                m.Context = this.context;
                m.Headers = this.HttpContext.Request.Headers.ToDictionary(a => a.Key, a => a.Value.ToString());
                m.Parameters = this.HttpContext.Request.Query.ToDictionary(a => a.Key, a => a.Value.ToString());
                m.IsCollection = false;
                mutatedResult = await m.Mutate(mutatedResult);
            }

            return Ok(mutatedResult);
        }        
    }
}
