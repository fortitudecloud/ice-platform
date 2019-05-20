using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    public interface IPlatformTrigger<E> where E : IPlatformEntity
    {
        IPlatformContext Context { get; set; }

        Task BeforeCreate(IEnumerable<E> objects);
    }
}
