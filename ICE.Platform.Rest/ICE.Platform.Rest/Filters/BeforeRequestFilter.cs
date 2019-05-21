using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest.Filters
{
    public class BeforeRequestFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // noop
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            // noop
        }        

    }
}
