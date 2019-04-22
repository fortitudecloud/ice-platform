using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform
{
    using Entities;

    public interface IPlatformContext
    {
        IPlatformSet<Case> Cases { get; }

        IPlatformSet<E> GetSet<E>(IPlatformTrigger<E> trigger = null) where E : IPlatformEntity;
        IPlatformDAL GetDAL();
    }
}
