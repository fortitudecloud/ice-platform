using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Platform event object. Used to publish events to the ESB (event service bus)
    /// </summary>
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
