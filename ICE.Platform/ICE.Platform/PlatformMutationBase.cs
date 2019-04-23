using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform
{
    public abstract class PlatformMutationBase : IPlatformMutation
    {
        public IDictionary<string, string> Headers { get; set; }
        public IDictionary<string, string> Parameters { get; set; }
        public IPlatformContext Context { get; set; }
        public bool IsCollection { get; set; }

        public abstract Task<object> Mutate(object input);
    }
}
