using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform
{
    public interface IPlatformDAL
    {
        Task<IEnumerable<E>> Read<E>(string entityId) where E : IPlatformEntity;
    }
}
