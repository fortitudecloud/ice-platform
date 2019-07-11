using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ICE.Platform
{
    using System.Threading.Tasks;
    using Core;
    using Entities;

    public class PlatformEntityProvider : DbContext, IPlatformDataProvider
    {
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemCost> ItemCost { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Subscriber> Subscriber { get; set; }
        public virtual DbSet<PaymentGroup> PaymentGroup { get; set; }

        public PlatformEntityProvider() { }

        public PlatformEntityProvider(DbContextOptions<PlatformEntityProvider> options) : base(options) { }

        public Task<E> Read<E>(string entityId) where E : class, IPlatformEntity
        {
            DbSet<E> set;

            // TODO: replace will logger and exception handler
            try
            {
                set = this.Set<E>();
            } catch(Exception e)
            {
                throw new Exception("Unable to create DbSet for Entity: " + typeof(E).Name, e);
            }
            
            return Task.Run<E>(() => HandleGet(() => set.Single(e => e.Id == entityId)));
        }

        public async Task<IList<E>> Query<E>(string rawQuery) where E : class, IPlatformEntity
        {
            DbSet<E> set;
            
            try
            {
                set = this.Set<E>();

                // TODO: escape SQL injection here

                var sql = string.Format("SELECT * FROM {0} WHERE {1}", GetEntityTargetName<E>(), rawQuery);

#pragma warning disable EF1000 // Possible SQL injection vulnerability.
                var result = await set.FromSql(string.Format(sql)).ToListAsync();
#pragma warning restore EF1000 // Possible SQL injection vulnerability.                

                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Unable to read records Entity: " + typeof(E).Name, e);
            }            
        }

        public async Task<E> Create<E>(E entityObject) where E : class, IPlatformEntity
        {
            DbSet<E> set;

            // TODO: replace will logger and exception handler
            try
            {
                set = this.Set<E>();

                var result = await set.AddAsync(entityObject);

                return result.Entity;
            }
            catch (Exception e)
            {
                throw new Exception("Unable to create entity: " + typeof(E).Name, e);
            }            
        }

        public async Task<E> Delete<E>(string entityId) where E : class, IPlatformEntity
        {
            DbSet<E> set;

            // TODO: replace will logger and exception handler
            try
            {
                set = this.Set<E>();

                var entity = await this.Read<E>(entityId);

                var result = set.Remove(entity);

                return result.Entity;
            }
            catch (Exception e)
            {
                throw new Exception("Unable to delete entity: " + typeof(E).Name, e);
            }
        }

        public async Task Commit()
        {
            var result = await this.SaveChangesAsync();
        }

        private E HandleGet<E>(Func<E> func)
        {
            E result;

            try
            {
                result = func();
            } catch (InvalidOperationException e)
            {
                result = default(E);
            }

            return result;
        }       

        public string GetEntityTargetName<E>()
        {
            var entityType = typeof(E);

            if (entityType.GetCustomAttributes(typeof(TableAttribute), true).Length > 0)
            {
                var meta = (TableAttribute)entityType.GetCustomAttributes(typeof(TableAttribute), true)[0];

                return meta.Name;
            }

            return entityType.Name;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseOracle(
                    @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=ICD1)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ICD1)));User ID=ice;Password=ice;" // DEV
                    //@"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=ICA1)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ICA1)));User ID=ice;Password=Ic=_u$er;" // UAT
                    //@"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=ICL1)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ICL1)));User ID=ice;Password=Ic=_u$er;" // PROD
                , (options) =>
                {
                    options.UseOracleSQLCompatibility("11");
                });

        
    }
}
