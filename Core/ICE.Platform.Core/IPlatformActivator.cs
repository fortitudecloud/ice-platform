using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    public interface IPlatformActivator
    {
        T NewInstance<T>(Type serviceType);

        IPlatformTrigger<E> GetDefaultTrigger<E>(IPlatformContext context) where E : class, IPlatformEntity;
    }
}
