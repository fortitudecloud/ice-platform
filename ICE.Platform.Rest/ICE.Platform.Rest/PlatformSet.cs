using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;

    public class PlatformSet<E> : IPlatformSet<E> where E : IPlatformEntity
    {
        IPlatformContext context;
        IPlatformTrigger<E> trigger;

        public PlatformSet(IPlatformContext context)
        {
            this.context = context;

            if (this.context.GetType() == typeof(PlatformContext))
            {
                ((PlatformContext)this.context).Register(this);
            }
        }

        public PlatformSet(IPlatformTrigger<E> trigger, IPlatformContext context) : this(context)
        {
            this.trigger = trigger;
            this.trigger.Context = this.context;
        }

        public Task<IEnumerable<E>> Read(string entityId)
        {
            return context.GetProvider().Read<E>(entityId);
        }
    }
}
