using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Interface for consuming resource instances
    /// </summary>
    public interface IPlatformResource
    {
        object Body { get; set; }
    }

    /// <summary>
    /// Allows the registration of unique resource implementations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPlatformResource<T> : IPlatformResource
    {
    }
}
