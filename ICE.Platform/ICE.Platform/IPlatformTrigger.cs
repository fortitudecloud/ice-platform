using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform
{
    public interface IPlatformTrigger<E> where E : IPlatformEntity
    {
        IPlatformContext Context { get; set; }

        IRequestMetadata Metadata { get; set; }

        Task BeforeCreate(IEnumerable<E> objects);

        Task AfterRead(IEnumerable<E> objects, Func<object> mutateResponse);
    }

    public interface IRequestMetadata
    {
        IDictionary<string, string> Headers { get; }
        IDictionary<string, string> Parameters { get; }
    }
}
