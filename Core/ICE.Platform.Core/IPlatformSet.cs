using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    /// <summary>
    /// An object representing an entities data repository and permitted actions
    /// </summary>
    /// <typeparam name="E">PlatformEntity type</typeparam>
    public interface IPlatformSet<E> where E : class, IPlatformEntity
    {
        /// <summary>
        /// Read a single record from the data repository
        /// </summary>
        /// <param name="entityId">Primary Key value</param>
        /// <returns></returns>
        Task<E> Read(string entityId);

        /// <summary>
        /// Create an object at the repository
        /// </summary>
        /// <param name="entityObject">Object matching a known entity type</param>
        /// <returns></returns>
        Task<E> Create(E entityObject);

        /// <summary>
        /// Reads a collection of records from the data repository
        /// </summary>
        /// <param name="rawQuery">Raw query language string</param>
        /// <returns></returns>
        Task<IList<E>> Query(string rawQuery);

        /// <summary>
        /// Deletes an object at the repository
        /// </summary>
        /// <param name="entityId">Primary key value</param>
        /// <returns></returns>
        Task<E> Delete(string entityId);
    }
}
