using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    public interface IPlatformEvent : IPlatformEntity
    {
        /// <summary>
        /// Represents the signal being raised
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Large serialized object containing the event message
        /// </summary>
        string Message { get; set; }
    }
}
