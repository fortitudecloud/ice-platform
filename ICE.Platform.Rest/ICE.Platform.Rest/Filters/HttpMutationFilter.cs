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
            if(context.Controller.GetType().IsAssignableFrom(typeof(IRestController)))
            {
                var restController = ((IRestController)context.Controller);

                var mutations = Platform.GetMutationList(restController.Entity, MutationType.HttpResponse);

                if(mutations.Count() > 0 && context.Result.GetType() == typeof(ObjectResult))
                {
                    var input = ((ObjectResult)context.Result);
                    object mutatedResult = input.Value;

                    foreach(var mutation in mutations)
                    {
                        var m = (IPlatformHttpMutation)Activator.CreateInstance(mutation);
                        m.Context = restController.Context;
                        m.Headers = context.HttpContext.Request.Headers.ToDictionary(a => a.Key, a => a.Value.ToString());
                        m.Parameters = context.HttpContext.Request.Query.ToDictionary(a => a.Key, a => a.Value.ToString());
                        m.Method = context.HttpContext.Request.Method;
                        mutatedResult = m.Mutate(input).Result;
                    }

                    context.Result = new ObjectResult(mutatedResult);
                }
            }
        }
    }
}
