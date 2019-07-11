using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ICE.Platform.Rest.Filters
{
    using Core;
    using Core.Structs;

    public class HttpMutationFilter : ResultFilterAttribute, IResultFilter
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var restController = context.Controller as IRestController;

            if (restController != null)
            {
                var mutations = Platform.GetMutationList(restController.Entity, MutationType.HttpResponse);

                if(mutations.Count() > 0 && context.Result.GetType() == typeof(JsonResult))
                {
                    var input = ((JsonResult)context.Result);
                    object mutatedResult = input.Value;

                    foreach(var mutation in mutations)
                    {                        
                        var m = (IPlatformHttpMutation)restController.Context.Container.GetService(mutation);                        

                        m.Context = restController.Context;
                        m.Headers = context.HttpContext.Request.Headers.ToDictionary(a => a.Key, a => a.Value.ToString());
                        m.Parameters = context.HttpContext.Request.Query.ToDictionary(a => a.Key, a => a.Value.ToString());
                        m.Method = context.HttpContext.Request.Method;

                        if (!m.Condition()) continue;

                        mutatedResult = m.Mutate(input.Value).Result;
                    }

                    context.Result = new JsonResult(mutatedResult);
                }
            }
        }
    }
}
