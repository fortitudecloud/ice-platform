using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core.Attributes
{
    /// <summary>
    /// Declares this class as an injectable service
    /// </summary>
    public class InjectableAttribute : Attribute
    {
        public Type Interface { get; private set; }

        /// <summary>
        /// Make this class injectable using the interface passed
        /// </summary>
        /// <param name="type">interface for this service</param>
        public InjectableAttribute(Type type) : base()
        {
            this.Interface = type;
        }
    }
}
