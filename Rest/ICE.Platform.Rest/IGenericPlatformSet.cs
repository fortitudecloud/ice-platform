using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;

    public interface IGenericPlatformSet
    {
        Task<dynamic> Read(string entityId);

        Task<dynamic> Query(string rawQuery);

        Task<dynamic> Create(object entityObject);

        Task<dynamic> Delete(string entityId);
    }
}
