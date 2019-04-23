using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform
{
    public abstract class PlatformTriggerBase<E> : IPlatformTrigger<E> where E : IPlatformEntity
    {
        public IPlatformContext Context { get; set; }
        public IRequestMetadata Metadata { get; set; }

        public Task AfterRead(IEnumerable<E> objects, Action<object> mutateResponse)
        {
            if (objects.Count() == 1) mutateResponse(resp => resp = objects.First());

            return Task.Delay(0);
        }

        public virtual Task BeforeCreate(IEnumerable<E> objects)
        {
            return Task.Delay(0);
        }
    }
}
