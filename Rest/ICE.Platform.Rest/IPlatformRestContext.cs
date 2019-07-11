using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;

    public interface IPlatformRestContext : IPlatformContext
    {
        IDictionary<Type, object> ContextCache { get; }

        IPlatformDataProvider DataProvider { get; }

        IServiceProvider Container { get; }

        void Register<E>(IPlatformSet<E> set) where E : class, IPlatformEntity;
    }
}
