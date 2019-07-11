using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Contract object for dealing with the platforms data source
    /// </summary>
    public interface IPlatformDataProvider
    {
        /// <summary>
        /// Read a single record from the data source
        /// </summary>
        /// <typeparam name="E">PlatformEntity respository to target</typeparam>
        /// <param name="entityId">Primary Key value</param>
        /// <returns></returns>
        Task<E> Read<E>(string entityId) where E : class, IPlatformEntity;

        /// <summary>
        /// Creates a single record at the repository
        /// </summary>
        /// <typeparam name="E">PlatformEntity respository to target</typeparam>
        /// <param name="entityObject">Object matching a known entity type</param>
        /// <returns></returns>
        Task<E> Create<E>(E entityObject) where E : class, IPlatformEntity;

        /// <summary>
        /// Reads a collection of records from the data source
        /// </summary>
        /// <typeparam name="E">PlatformEntity respository to target</typeparam>
        /// <param name="rawQuery">Raw query language string</param>
        /// <returns></returns>
        Task<IList<E>> Query<E>(string rawQuery) where E : class, IPlatformEntity;

        /// <summary>
        /// Removes a single record from the data source
        /// </summary>
        /// <typeparam name="E">PlatformEntity respository to target</typeparam>
        /// <param name="entityId">Primary Key value</param>
        /// <returns></returns>
        Task<E> Delete<E>(string entityId) where E : class, IPlatformEntity;

        /// <summary>
        /// Saves changes held by this object
        /// </summary>
        /// <returns></returns>
        Task Commit();

        /// <summary>
        /// Gets the literal repository name from the data source. E.g. Table name for SQL db's (Possible schema too).
        /// </summary>
        /// <typeparam name="E">PlatformEntity respository to target</typeparam>
        /// <returns></returns>
        string GetEntityTargetName<E>();
    }
}
