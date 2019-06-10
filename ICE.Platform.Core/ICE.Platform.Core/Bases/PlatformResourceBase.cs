using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;

namespace ICE.Platform.Core.Bases
{
    using Core.Structs;
    using Core.Attributes;

    public abstract class PlatformResourceBase : IPlatformResourceFactory
    {
        private string routeSegment = @"({\w+}|\w+)";

        public abstract object Get(string resourceName);

        /// <summary>
        /// Returns the action to execute for the successfully matched route
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Task<object> GetRouteResult(object resourceInstance, string path, HttpMethod method)
        {
            var localRoute = path.Substring(path.IndexOf("/") + 1);

            var segmentCount = localRoute.Split("/").Length;                        

            // Get route matching the method and pattern

            var routeMethod = GetRoute(resourceInstance.GetType(), method, localRoute);

            if(routeMethod != null)
            {
                return (Task<object>)routeMethod.Item1.Invoke(resourceInstance, routeMethod.Item2);
            }

            return null;
        }

        /// <summary>
        /// Replaces parameters with expressions
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        private string ReplaceParamWithPattern(string param)
        {
            if(param.Contains("{"))
            {
                return routeSegment;
            }

            return param;
        }

        private Tuple<MethodInfo, object[]> GetRoute(Type resourceType, HttpMethod httpMethod, string localRoute)
        {
            foreach(var method in resourceType.GetMethods())
            {
                if (method.GetCustomAttributes(typeof(RouteAttribute), true).Length > 0)
                {
                    var meta = (RouteAttribute)method.GetCustomAttributes(typeof(RouteAttribute), true)[0];

                    if (meta.Method == httpMethod)
                    {
                        var pattern = @"^" + string.Join(@"/", meta.Signature.Split(@"/").Select(s => ReplaceParamWithPattern(s))) + @"$";

                        if (Regex.IsMatch(meta.Signature, pattern))
                        {
                            // Form the parameters to call this method

                            var segments = meta.Signature.Split(@"/");

                            var paramList = new List<string>();

                            for (var i = 0; i < segments.Length; i++)
                            {
                                if(segments[i].Contains(@"{"))
                                {
                                    paramList.Add(localRoute.Split(@"/")[i]);
                                }
                            }

                            return new Tuple<MethodInfo, object[]>(method, paramList.ToArray());
                        }
                    }
                }
            }

            return null;
        }        
    }
}
