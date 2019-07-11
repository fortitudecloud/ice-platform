using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    public interface IPlatformSubscriber
    {
        string Message { get; }

        IPlatformAction[] Actions { get; }
    }

    /// <summary>
    /// Event Consumer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPlatformSubscriber<T> : IPlatformEntity
    {
        /// <summary>
        /// Collection of consumer actions to occur on event being raised
        /// </summary>
        IPlatformAction<T>[] Action { get; set; }        
        /// <summary>
        /// The user that activated the event
        /// </summary>
        string ActivatedBy { get; set; }
        /// <summary>
        /// The date and time the subscription was activated. Prevents consuming past events
        /// </summary>
        DateTime? ActivatedAt { get; set; }
    }
}
