using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Common contract supplied to allow object manipulation
    /// </summary>
    public interface IPlatformMutation
    {
        /// <summary>
        /// Determines is the object should be mutated based on rules
        /// </summary>
        /// <returns></returns>
        bool Condition();
        /// <summary>
        /// Mutates the input object and returns a value
        /// </summary>
        /// <param name="input">Original object</param>
        /// <returns>Mutated object</returns>
        Task<object> Mutate(object input);
    }
}
