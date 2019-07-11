using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    public interface IPlatformAction
    {
        Task ActionHandler(object message);        
    }

    /// <summary>
    /// A delegate class handler for platform related concerns (Event consuming, field updating, etc)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPlatformAction<T>
    {
        /// <summary>
        /// Executes an action
        /// </summary>
        /// <param name="message">Context object. Used to process this action</param>
        /// <returns></returns>
        Task ActionHandler(T message);
    }
}
