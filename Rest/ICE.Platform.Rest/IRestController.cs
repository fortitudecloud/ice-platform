using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;

    public interface IRestController
    {
        IPlatformRestContext Context { get; set; }        

        IGenericPlatformSet Set { get; }

        Type Entity { get; }        
    }
}
