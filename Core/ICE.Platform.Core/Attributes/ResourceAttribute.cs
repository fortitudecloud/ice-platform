using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ResourceAttribute : Attribute
    {
        public string Name { get; set; }

        public ResourceAttribute(string name) => this.Name = name;
    }
}
