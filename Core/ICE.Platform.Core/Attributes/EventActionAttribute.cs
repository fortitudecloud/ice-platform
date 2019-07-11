using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core.Attributes
{
    /// <summary>
    /// Declares a class as a handler for event consumers
    /// </summary>
    public class EventActionAttribute : Attribute
    {
        /// <summary>
        /// Friendly name given to the event action handler
        /// </summary>
        public string Name { get; set; }

        public EventActionAttribute(string name)
        {
            this.Name = name;
        }
    }
}
