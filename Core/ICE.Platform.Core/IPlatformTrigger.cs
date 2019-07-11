using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Generic contract for dealing with platform changes
    /// </summary>
    /// <typeparam name="E">PlatformEntity changing</typeparam>
    public interface IPlatformTrigger<E> where E : IPlatformEntity
    {
        /// <summary>
        /// The current executing platform context during this pipeline
        /// </summary>
        IPlatformContext Context { get; set; }
        /// <summary>
        /// Before change hook
        /// </summary>
        /// <param name="objects">Collection of entity objects that are about to change</param>
        /// <returns></returns>
        Task BeforeCreate(IEnumerable<E> objects);
        /// <summary>
        /// After change hook
        /// </summary>
        /// <param name="objects">Collection of entity objects that have just changed</param>
        /// <returns></returns>
        Task AfterCreate(IEnumerable<E> objects);
    }
}
