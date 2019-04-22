using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform
{
    public interface IPlatformSet<E> where E : IPlatformEntity
    {
        Task<IEnumerable<E>> Read(string entityId);
    }
}
