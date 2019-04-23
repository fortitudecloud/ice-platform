using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform
{
    public class MutationAttribute : Attribute
    {
        public MutationType Type { get; private set; }
        public MutationOperation Operation { get; private set; }
        public Type Entity { get; set; }

        public MutationAttribute(MutationType type, MutationOperation operation, Type entity)
        {
            this.Type = type;
            this.Operation = operation;
            this.Entity = entity;
        }
    }
}
