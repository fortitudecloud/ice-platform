using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Rest
{
    using ICE.Platform;
    using ICE.Platform.Entities;

    public class PlatformContext : IPlatformContext
    {
        private IDictionary<Type, object> contextCache;
        private IPlatformDAL platformDAL;

        public IPlatformSet<Case> Cases => this.GetSet<Case>();

        public PlatformContext(IPlatformDAL platformDAL)
        {
            this.contextCache = new Dictionary<Type, object>();
            this.platformDAL = platformDAL;
        }

        internal void Register<E>(IPlatformSet<E> set) where E : IPlatformEntity
        {
            if (this.contextCache.ContainsKey(typeof(E))) return;

            this.contextCache.Add(typeof(E), set);
        }

        public IPlatformSet<E> GetSet<E>(IPlatformTrigger<E> trigger = null) where E : IPlatformEntity
        {
            if (!this.contextCache.ContainsKey(typeof(E)))
            {
                if (trigger != null) new PlatformSet<E>(trigger, this);
                else new PlatformSet<E>(this);
            }

            return (IPlatformSet<E>)this.contextCache[typeof(E)];
        }

        public IPlatformDAL GetDAL()
        {
            return platformDAL;
        }
    }
}
