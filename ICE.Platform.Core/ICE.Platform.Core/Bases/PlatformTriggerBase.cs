using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core.Bases
{
    public abstract class PlatformTriggerBase<E> : IPlatformTrigger<E> where E : IPlatformEntity
    {
        public IPlatformContext Context { get; set; }

        public virtual Task BeforeCreate(IEnumerable<E> objects)
        {
            return Task.Delay(0);
        }
    }
}
