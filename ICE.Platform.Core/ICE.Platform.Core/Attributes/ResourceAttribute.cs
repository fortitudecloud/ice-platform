using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core.Attributes
{
    public class ResourceAttribute : Attribute
    {
        public string Url { get; set; }

        public ResourceAttribute(string url) => this.Url = url;
    }
}
