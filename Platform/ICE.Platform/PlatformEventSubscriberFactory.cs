using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ICE.Platform
{
    using Core;
    using Core.Bases;
    using Core.Attributes;
    using Entities;
    using Subscribers;

    [Injectable(typeof(IPlatformEventSubscriberFactory))]
    public class PlatformEventSubscriberFactory : IPlatformEventSubscriberFactory
    {
        public IPlatformContext Context { get; set; }

        private IPlatformActivator Activator { get; set; }

        public PlatformEventSubscriberFactory(IPlatformActivator activator)
        {
            this.Activator = activator;
        }

        public async Task<IEnumerable<IPlatformEventSubscriber>> GetSubscribers(string eventName)
        {
            var eventSubscribers = new List<PlatformEventSubscriber>();

            var eventSet = Context.Set<Event>();

            var events = await eventSet.Query(string.Format("Name = '{0}'", eventName));

            if (events.Count == 0) return eventSubscribers;

            // Build subscribers

            var subscriberSet = Context.Set<Subscriber>();

            string subscriberIds = string.Join("','", events.Select(e => e.SubscriberId).ToArray());

            var subscribers = await subscriberSet.Query(string.Format("SubscriberId IN ('{0}')", subscriberIds));
                
            foreach(var _event in events)
            {
                var subscriber = subscribers.FirstOrDefault(s => s.Id == _event.SubscriberId);

                if (subscriber == null) continue;

                // Build actioners TODO: make array here

                var actionType = Platform.GetType(subscriber.ActionType);

                if (actionType == null) continue;

                var subscriberAction = this.Activator.NewInstance<IPlatformAction>(actionType);

                if (subscriberAction == null) continue;

                var eventSub = new PlatformEventSubscriber()
                {
                    EventId = _event.Id,
                    Actions = new List<IPlatformAction>() { subscriberAction }.ToArray(),
                    Message = _event.Message
                };

                eventSubscribers.Add(eventSub);
            }

            return eventSubscribers;
        }

        public async Task Execute(IPlatformEventSubscriber subscriber)
        {
            var eventSet = Context.Set<Event>();

            try
            {
                foreach (var action in subscriber.Actions)
                {                    
                    await action.ActionHandler(subscriber.Message);                    
                }

                await eventSet.Delete(subscriber.EventId);

                await Context.Save();

            } catch (Exception e)
            {
                throw new Exception("Unable to complete subscriber action", e);
            }            
        }
    }
}
