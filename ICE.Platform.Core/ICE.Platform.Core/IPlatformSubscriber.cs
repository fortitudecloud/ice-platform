using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Event Consumer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPlatformSubscriber<T> : IPlatformEntity
    {
        /// <summary>
        /// Abstract class for actioning the request based on ActionType
        /// </summary>
        IPlatformAction<T> Action { get; set; }
        /// <summary>
        /// Type of platform action to occur on event consumption
        /// </summary>
        string ActionType { get; set; }
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
