using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core.Bases
{
    public abstract class HttpMutationBase : IPlatformHttpMutation
    {
        public IDictionary<string, string> Headers { get; set; }
        public IDictionary<string, string> Parameters { get; set; }
        public string Method { get; set; }
        public IPlatformContext Context { get; set; }

        public abstract Task<object> Mutate(object input);
    }
}
