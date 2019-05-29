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
        Task Publish(T message);
    }
}
