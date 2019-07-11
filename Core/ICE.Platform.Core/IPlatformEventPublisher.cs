using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    public interface IPlatformEventPublisher
    {
        /// <summary>
        /// Current executing context
        /// </summary>
        IPlatformContext Context { get; set; }
        /// <summary>
        /// Publish message to the ESB
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        Task Publish<T>(string eventName, IEnumerable<T> message) where T : class, IPlatformEntity;
    }
}
