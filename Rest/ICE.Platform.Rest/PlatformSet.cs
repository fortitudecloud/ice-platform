using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;

    public class PlatformSet<E> : IPlatformSet<E>, IGenericPlatformSet where E : class, IPlatformEntity
    {
        private IPlatformRestContext context;
        private IPlatformTrigger<E> trigger;        

        public PlatformSet(IPlatformRestContext context)
        {
            this.context = context;

            //if (this.context.GetType() == typeof(PlatformContext))
            //{
            //    ((PlatformContext)this.context).Register(this);
            //}

            this.context.Register(this);
        }

        public PlatformSet(IPlatformTrigger<E> trigger, IPlatformRestContext context) : this(context)
        {
            this.trigger = trigger;
            this.trigger.Context = this.context;
        }

        public async Task<E> Create(E entityObject)
        {
            var entity = await context.GetProvider().Create<E>(entityObject);

            try
            {
                await this.trigger.BeforeCreate(new List<E>() { entity });

                entity.Id = entity.Id.ToUpper();

                await context.Save();

                await this.trigger.AfterCreate(new List<E>() { entity });

            } catch(Exception e)
            {
                return default(E);
            }

            return entity;
        }        

        public Task<E> Read(string entityId)
        {
            return context.GetProvider().Read<E>(entityId);
        }

        public Task<IList<E>> Query(string rawQuery)
        {
            return context.GetProvider().Query<E>(rawQuery);
        }

        public Task<E> Delete(string entityId)
        {
            return context.GetProvider().Delete<E>(entityId);
        }

        #region Generic method wrappers
        async Task<dynamic> IGenericPlatformSet.Read(string entityId)
        {
            var resultTask = await this.Read(entityId);

            return resultTask;
        }

        async Task<dynamic> IGenericPlatformSet.Create(object entityObject)
        {
            var resultTask = await this.Create(Deserialize(entityObject));

            return resultTask;
        }

        async Task<dynamic> IGenericPlatformSet.Query(string rawQuery)
        {
            var resultTask = await this.Query(rawQuery);

            return resultTask;
        }

        async Task<dynamic> IGenericPlatformSet.Delete(string entityId)
        {
            var resultTask = await this.Delete(entityId);

            return resultTask;
        }
        #endregion

        private E Deserialize(object entityObject)
        {
            var serializedEntity = Newtonsoft.Json.JsonConvert.SerializeObject(entityObject);
            var deserializedEntity = Newtonsoft.Json.JsonConvert.DeserializeObject<E>(serializedEntity);

            return deserializedEntity;
        }        
    }
}
