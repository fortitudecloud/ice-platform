﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    using Core.Structs;

    public interface IPlatformResourceFactory
    {
        //IPlatformResource Get(string resourceName);
        object Get(string resourceName);

        Task<object> GetRouteResult(object resourceInstance, string path, HttpMethod method);
    }
}
