using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    public interface IPlatformContext
    {
        IPlatformSet<E> Set<E>() where E : IPlatformEntity;
        T Set<T>(Type entityType);
        IPlatformDataProvider GetProvider();
    }
}
