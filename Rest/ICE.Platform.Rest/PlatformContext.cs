using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace ICE.Platform.Rest
{
    using Core;

    public class PlatformContext : IPlatformRestContext
    {
        //private IDictionary<Type, object> contextCache;
        //private IPlatformDataProvider provider;
        //private IServiceProvider diProvider;

        public IDictionary<Type, object> ContextCache { get; internal set; }

        public IPlatformDataProvider DataProvider { get; internal set; }

        public IServiceProvider Container { get; internal set; }

        //public IPlatformSet<Case> Cases => this.GetSet<Case>();

        //public PlatformContext(IPlatformDataProvider provider)
        //{
        //    this.contextCache = new Dictionary<Type, object>();
        //    this.provider = provider;            
        //}

        public PlatformContext(IServiceProvider container)
        {
            //this.diProvider = diProvider;
            //this.contextCache = new Dictionary<Type, object>();
            //this.provider = (IPlatformDataProvider)diProvider.GetService(typeof(IPlatformDataProvider));

            this.Container = container;
            this.ContextCache = new Dictionary<Type, object>();
            this.DataProvider = (IPlatformDataProvider)Container.GetService(typeof(IPlatformDataProvider));
        }

        public void Register<E>(IPlatformSet<E> set) where E : class, IPlatformEntity
        {
            if (this.ContextCache.ContainsKey(typeof(E))) return;

            this.ContextCache.Add(typeof(E), set);
        }        

        public IPlatformSet<E> Set<E>() where E : class, IPlatformEntity
        {
            if (!this.ContextCache.ContainsKey(typeof(E)))
            {
                // Get custom trigger for entity

                var trigger = (IPlatformTrigger<E>)this.Container.GetService(typeof(IPlatformTrigger<E>));

                if (trigger != null)
                {
                    new PlatformSet<E>(trigger, this);
                }
                else
                {
                    // Use default platform trigger 

                    var activator = (IPlatformActivator)Container.GetService(typeof(IPlatformActivator));

                    trigger = activator.GetDefaultTrigger<E>(this);

                    new PlatformSet<E>(trigger, this);
                }
            }

            return (IPlatformSet<E>)this.ContextCache[typeof(E)];
        }

        public T Set<T>(Type entityType)
        {
            MethodInfo setInfo = this.GetType().GetMethod("Set", new Type[] { });
            MethodInfo setGenericInfo = setInfo.MakeGenericMethod(entityType);
            return (T)setGenericInfo.Invoke(this, null);
        }

        public IPlatformDataProvider GetProvider()
        {
            return this.DataProvider;
        }

        public Task Save()
        {
            return this.DataProvider.Commit();
        }
    }
}
