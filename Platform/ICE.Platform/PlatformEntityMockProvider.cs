using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ICE.Platform
{
    using System.Threading.Tasks;
    using Core;
    using Entities;

    public class PlatformEntityMockProvider : IPlatformDataProvider
    {
        public async Task<E> Read<E>(string entityId) where E : class, IPlatformEntity
        {
            var collection = new List<Item>();

            await Task.Delay(0);

            if (typeof(E) == typeof(Item))
            {
                collection.Add(new Item()
                {
                    Id = "ItemId1",
                    ItemName = "Item One",
                    CreatedBy = "lhickey",
                    CreatedDate = DateTime.Now,
                    LastModifiedBy = "lhickey",
                    LastModifiedDate = DateTime.Now
                });
                collection.Add(new Item()
                {
                    Id = "ItemId2",
                    ItemName = "Item Two",
                    CreatedBy = "lhickey",
                    CreatedDate = DateTime.Now,
                    LastModifiedBy = "lhickey",
                    LastModifiedDate = DateTime.Now
                });
                collection.Add(new Item()
                {
                    Id = "ItemId3",
                    ItemName = "Item Three",
                    CreatedBy = "lhickey",
                    CreatedDate = DateTime.Now,
                    LastModifiedBy = "lhickey",
                    LastModifiedDate = DateTime.Now
                });



                return (E)((IEnumerable<E>)collection.Where(i => i.Id == entityId)).First();
            }
            else
            {
                return default(E);
            }
        }

        public Task<E> Create<E>(E entityObject) where E : class, IPlatformEntity
        {
            throw new NotImplementedException();
        }

        public Task<IList<E>> Query<E>(string rawQuery) where E : class, IPlatformEntity
        {
            throw new NotImplementedException();
        }

        public string GetEntityTargetName<E>()
        {
            throw new NotImplementedException();
        }

        public Task Commit()
        {
            throw new NotImplementedException();
        }

        public Task<E> Delete<E>(string entityId) where E : class, IPlatformEntity
        {
            throw new NotImplementedException();
        }
    }
}
