using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICE.Platform.Core;

namespace ICE.Platform.Rest
{
    public class PlatformActivator : IPlatformActivator
    {
        private IServiceProvider container;

        public PlatformActivator(IServiceProvider serviceProvider) => container = serviceProvider;

        public T NewInstance<T>(Type serviceType)
        {
            return (T)container.GetService(serviceType);
        }

        public IPlatformTrigger<E> GetDefaultTrigger<E>(IPlatformContext context) where E : class, IPlatformEntity
        {
            var publisher = (IPlatformEventPublisher)container.GetService(typeof(IPlatformEventPublisher));
            var subscriberFactory = (IPlatformEventSubscriberFactory)container.GetService(typeof(IPlatformEventSubscriberFactory));

            publisher.Context = context;
            subscriberFactory.Context = context;

            return new PlatformRestTrigger<E>(publisher, subscriberFactory);
        }
    }
}
