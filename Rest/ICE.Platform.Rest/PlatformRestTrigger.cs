using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;
    using Core.Bases;

    public class PlatformRestTrigger<E> : PlatformTriggerBase<E> where E : class, IPlatformEntity
    {        
        public PlatformRestTrigger(IPlatformEventPublisher eventPublisher, IPlatformEventSubscriberFactory eventSubscriberFactory)
            :base(eventPublisher, eventSubscriberFactory) { }
    }
}
