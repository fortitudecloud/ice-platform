using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    public interface IPlatformHttpMutation : IPlatformMutation
    {
        IDictionary<string, string> Headers { get; set; }
        IDictionary<string, string> Parameters { get; set; }
        string Method { get; set; }
        IPlatformContext Context { get; set; }
    }
}
