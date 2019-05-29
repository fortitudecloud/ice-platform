using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ICE.Platform.Rest.Filters
{
    public class EntityResourceFilter : Attribute, IResourceFilter
    {
        const string EntityKey = "entity";

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            // Get the entity for this resource

            var keyIndex = -1;

            for (int i = 0; i < context.RouteData.Values.Keys.Count; i++)
            {
                if (context.RouteData.Values.Keys.ToArray()[i] == EntityKey)
                {
                    keyIndex = i;
                }
            }

            if(keyIndex == -1)
            {
                // Fail
            }

            var entityName = context.RouteData.Values.Values.ToArray()[keyIndex].ToString();

            // Find the entity type from the implementation

            var entityType = Platform.Core.Platform.GetEntityForName(entityName);

            if(entityType == null)
            {
                // Fail
            }

            context.HttpContext.Items.Add("Entity", entityType);
        }
    }
}
