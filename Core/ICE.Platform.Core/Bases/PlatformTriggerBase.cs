using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core.Bases
{
    /// <summary>
    /// Common Trigger abstraction for Trigger handling
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public abstract class PlatformTriggerBase<E> : IPlatformTrigger<E> where E : class, IPlatformEntity
    {
        static string OnCreateFormattedString = "On{0}Create";

        public IPlatformContext Context { get; set; }        

        private IPlatformEventPublisher EventPublisher { get; set; }

        private IPlatformEventSubscriberFactory EventSubscriberFactory { get; set; }

        public PlatformTriggerBase(IPlatformEventPublisher eventPublisher, IPlatformEventSubscriberFactory eventSubscriberFactory)
        {
            this.EventPublisher = eventPublisher;
            this.EventSubscriberFactory = eventSubscriberFactory;
        }

        public virtual Task BeforeCreate(IEnumerable<E> objects)
        {
            foreach(var _object in objects)
            {
                _object.CreatedBy = _object.CreatedBy ?? "anonymous";
                _object.CreatedDate = DateTime.Now;
                _object.LastModifiedBy = _object.LastModifiedBy ?? "anonymous";
                _object.LastModifiedDate = DateTime.Now;
            }

            return Task.Delay(0);
        }

        public async virtual Task AfterCreate(IEnumerable<E> objects)
        {
            // Feed the event service bus the DB trigger

            try
            {
                if(EventPublisher != null)
                {
                    await EventPublisher.Publish(GetEventName(OnCreateFormattedString), objects);
                }                
            }
            catch (Exception e)
            {
                // TODO: implement a logging service for processing these requests (IPlatformLogger)
                throw e;
            }

            // Notify event subscribers of event

            try
            {
                if(EventSubscriberFactory != null)
                {
                    var subscribers = await EventSubscriberFactory.GetSubscribers(GetEventName(OnCreateFormattedString));

                    foreach (var subscriber in subscribers)
                    {
                        await EventSubscriberFactory.Execute(subscriber);
                    }
                }                
            }
            catch (Exception e)
            {
                // TODO: implement a logging service for processing these requests (IPlatformLogger)
                throw e;
            }
        }

        protected string GetEventName(string formattedString)
        {
            return string.Format(formattedString, this.Context.GetProvider().GetEntityTargetName<E>());
        }        
    }
}
