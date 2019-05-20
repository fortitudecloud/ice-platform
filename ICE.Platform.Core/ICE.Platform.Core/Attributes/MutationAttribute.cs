using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core.Attributes
{
    using Structs;

    public class MutationAttribute : Attribute
    {
        public Type Entity { get; set; }
        public MutationType Type { get; set; }

        public MutationAttribute(Type entity, MutationType type)
        {
            this.Entity = entity;
            this.Type = type;
        }
    }
}
