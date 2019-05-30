using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Notification pubilsher to the platform. E.g events to the platform event service bus
    /// </summary>
    public interface IPlatformPublisher<T>
    {
        /// <summary>
        /// Publishes the generic object to a designated subscriber source
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task Publish(T message);
    }
}
