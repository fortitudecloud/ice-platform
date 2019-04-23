using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform
{
    public interface IPlatformMutation
    {
        IDictionary<string, string> Headers { get; set; }

        IDictionary<string, string> Parameters { get; set; }

        IPlatformContext Context { get; set; }

        /// <summary>
        /// States whether the mutable input is part of a collection
        /// </summary>
        bool IsCollection { get; set; }

        /// <summary>
        /// Changes the input parameters value
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<object> Mutate(object input);
    }

    public enum MutationType
    {
        Response = 0,
        Request
    }

    public enum MutationOperation
    {
        Create = 0,
        Read,
        Update,
        Delete
    }
}
