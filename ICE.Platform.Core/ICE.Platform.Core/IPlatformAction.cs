using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    /// <summary>
    /// A delegate class handler for platform related concerns (Event consuming, etc)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPlatformAction<T>
    {
        Task ActionHandler(T message);
    }
}
