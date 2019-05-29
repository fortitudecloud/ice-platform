using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Platform.Rest
{
    using ICE.Platform.Core;

    [Route("api/old/[controller]")]
    [ApiController]
    public abstract class RestControllerBase<E> : ControllerBase, IRestController where E : IPlatformEntity
    {
        protected IPlatformSet<E> Set { get; private set; }       
        
        public IPlatformContext Context { get; set; }

        public Type Entity => typeof(E);

        IGenericPlatformSet IRestController.Set { get => throw new NotImplementedException(); }

        public RestControllerBase(IPlatformContext context)
        {
            this.Set = context.Set<E>();
            this.Context = context;
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
