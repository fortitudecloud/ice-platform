using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;

    public interface IRestController
    {
        IPlatformContext Context { get; set; }

        Type Entity { get; }
    }
}
