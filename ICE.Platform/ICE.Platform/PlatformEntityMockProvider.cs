using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform
{
    using System.Threading.Tasks;
    using Core;
    using Entities;

    public class PlatformEntityMockProvider : IPlatformDataProvider
    {
        public async Task<IEnumerable<E>> Read<E>(string entityId) where E : IPlatformEntity
        {
            var collection = new List<Case>();

            await Task.Delay(0);

            if (typeof(E) == typeof(Case))
            {
                collection.Add(new Case()
                {
                    CreatedBy = "Lionel"
                });

                return (IEnumerable<E>)collection;
            }
            else
            {
                return new List<E>();
            }
        }
    }
}
