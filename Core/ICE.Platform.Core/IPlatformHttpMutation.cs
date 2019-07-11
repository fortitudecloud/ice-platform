using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Common contract supplied to allow HTTP response object manipulation
    /// </summary>
    public interface IPlatformHttpMutation : IPlatformMutation
    {
        /// <summary>
        /// HTTP Headers contained on the request 
        /// </summary>
        IDictionary<string, string> Headers { get; set; }
        /// <summary>
        /// HTTP Parameters contained on the request
        /// </summary>
        IDictionary<string, string> Parameters { get; set; }
        /// <summary>
        /// HTTP Method contained on the request
        /// </summary>
        string Method { get; set; }
        /// <summary>
        /// Current executing platform context
        /// </summary>
        IPlatformContext Context { get; set; }
    }
}
