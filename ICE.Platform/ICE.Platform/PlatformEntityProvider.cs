using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform
{
    using System.Threading.Tasks;
    using Core;

    public class PlatformEntityProvider : IPlatformDataProvider
    {
        public Task<IEnumerable<E>> Read<E>(string entityId) where E : IPlatformEntity
        {
            throw new NotImplementedException();
        }
    }
}
