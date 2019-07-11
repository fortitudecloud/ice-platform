using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core.Bases
{
    /// <summary>
    /// Http Mutation class abstraction
    /// </summary>
    public abstract class HttpMutationBase : IPlatformHttpMutation
    {
        public IDictionary<string, string> Headers { get; set; }
        public IDictionary<string, string> Parameters { get; set; }
        public string Method { get; set; }
        public IPlatformContext Context { get; set; }

        public abstract bool Condition();

        public abstract Task<object> Mutate(object input);
    }
}
