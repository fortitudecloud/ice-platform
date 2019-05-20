using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;

    public class PlatformContext : IPlatformContext
    {
        private IDictionary<Type, object> contextCache;
        private IPlatformDataProvider provider;
        private IServiceProvider diProvider;

        //public IPlatformSet<Case> Cases => this.GetSet<Case>();

        //public PlatformContext(IPlatformDataProvider provider)
        //{
        //    this.contextCache = new Dictionary<Type, object>();
        //    this.provider = provider;            
        //}

        public PlatformContext(IServiceProvider diProvider)
        {
            this.diProvider = diProvider;
            this.contextCache = new Dictionary<Type, object>();
            this.provider = (IPlatformDataProvider)diProvider.GetService(typeof(IPlatformDataProvider));
        }

        internal void Register<E>(IPlatformSet<E> set) where E : IPlatformEntity
        {
            if (this.contextCache.ContainsKey(typeof(E))) return;

            this.contextCache.Add(typeof(E), set);
        }        

        public IPlatformSet<E> Set<E>() where E : IPlatformEntity
        {
            if (!this.contextCache.ContainsKey(typeof(E)))
            {
                var trigger = (IPlatformTrigger<E>)this.diProvider.GetService(typeof(IPlatformTrigger<E>));

                if (trigger != null) new PlatformSet<E>(trigger, this);
                else new PlatformSet<E>(this);
            }

            return (IPlatformSet<E>)this.contextCache[typeof(E)];
        }

        public IPlatformDataProvider GetProvider()
        {
            return this.provider;
        }
    }
}
