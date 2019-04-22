using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Rest
{
    using ICE.Platform;
    using ICE.Platform.Entities;

    public class MockDAL : IPlatformDAL
    {
        public async Task<IEnumerable<E>> Read<E>(string entityId) where E : IPlatformEntity
        {
            var collection = new List<Case>();

            await Task.Delay(0);

            if(typeof(E) == typeof(Case))
            {
                collection.Add(new Case()
                {
                    CreatedBy = "Lionel"
                });

                return (IEnumerable < E > )collection;
            } else
            {
                return new List<E>();
            }            
        }
    }
}
