using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core.Attributes
{
    using Structs;

    /// <summary>
    /// Declares the class as a mutation handler
    /// </summary>
    public class MutationAttribute : Attribute
    {
        public Type Entity { get; set; }
        public MutationType Type { get; set; }

        /// <summary>
        /// PlatformEntity mutation of a certain type
        /// </summary>
        /// <param name="entity">PlatformEntity the mutation acts on</param>
        /// <param name="type">The type of mutation to occur</param>
        public MutationAttribute(Type entity, MutationType type)
        {
            this.Entity = entity;
            this.Type = type;
        }
    }
}
