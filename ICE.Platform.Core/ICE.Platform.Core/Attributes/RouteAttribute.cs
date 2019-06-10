using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core.Attributes
{
    using Structs;

    [AttributeUsage(AttributeTargets.Method)]
    public class RouteAttribute : Attribute
    {
        public HttpMethod Method { get; set; }

        public string Signature { get; set; }

        public RouteAttribute(HttpMethod method, string signature)
        {
            this.Method = method;
            this.Signature = signature;
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class HttpGetAttribute : RouteAttribute
    {
        public HttpGetAttribute(string signature) : base(HttpMethod.GET, signature) { }
    }
}
