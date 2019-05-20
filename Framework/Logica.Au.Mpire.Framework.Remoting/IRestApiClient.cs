using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Au.Mpire.Framework.Remoting
{
    /// <summary>
    /// Interface used to consume REST API
    /// </summary>
    public interface IRestApiClient
    {
        /// <summary>
        /// Gets a single record
        /// </summary>
        /// <typeparam name="T">Custom response object</typeparam>
        /// <param name="entityId">Primary Key ID on the table</param>
        /// <returns></returns>
        T Read<T>(string entityId);
    }
}
