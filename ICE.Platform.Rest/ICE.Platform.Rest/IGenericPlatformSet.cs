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
    }
}
