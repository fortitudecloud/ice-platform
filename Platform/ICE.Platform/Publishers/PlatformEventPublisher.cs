using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ICE.Platform.Publishers
{    
    using Core;    
    using Core.Attributes;
    using Entities;

    [Injectable(typeof(IPlatformEventPublisher))]
    public class PlatformEventPublisher : IPlatformEventPublisher
    {
        public IPlatformContext Context { get; set; }

        public async Task Publish<T>(string eventName, IEnumerable<T> message) where T : class, IPlatformEntity
        {
            var events = Context.Set<Event>();
            var subscribers = Context.Set<Subscriber>();

            var eventSubs = await subscribers.Query(string.Format("EventName = '{0}'", eventName));

            foreach(var subs in eventSubs)
            {
                await events.Create(new Event()
                {
                    Name = eventName,
                    Message = JsonConvert.SerializeObject(message),
                    SubscriberId = subs.Id
                });
            }

            await Context.Save();
        }
    }
}
