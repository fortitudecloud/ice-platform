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
        /// Represents the "signal" being raised. 
        /// Signal: An event signature used to describe the event raised
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Serialized object containing the event message or context
        /// </summary>
        string Message { get; set; }
    }
}
