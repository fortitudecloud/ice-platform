using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{

    /// <summary>
    /// Provides active pipeline context for platform operations
    /// </summary>
    public interface IPlatformContext
    {
        /// <summary>
        /// Recuits a PlatformSet object from this context
        /// </summary>
        /// <typeparam name="E">PlatformEntity Type</typeparam>
        /// <returns></returns>
        IPlatformSet<E> Set<E>() where E : class, IPlatformEntity;
        /// <summary>
        /// Recruits a generic PlatformSet object from this context
        /// </summary>
        /// <typeparam name="T">Casted entityType</typeparam>
        /// <param name="entityType">PlatformEntity Type</param>
        /// <returns></returns>
        T Set<T>(Type entityType);
        /// <summary>
        /// Gets an instance of the platforms data provider service
        /// </summary>
        /// <returns></returns>
        IPlatformDataProvider GetProvider();
        /// <summary>
        /// Save context changes
        /// </summary>
        Task Save();
    }
}
