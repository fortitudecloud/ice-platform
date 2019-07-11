using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    public interface IPlatformEventSubscriberFactory
    {
        IPlatformContext Context { get; set; }

        Task<IEnumerable<IPlatformEventSubscriber>> GetSubscribers(string eventName);

        Task Execute(IPlatformEventSubscriber subscriber);
    }
}
