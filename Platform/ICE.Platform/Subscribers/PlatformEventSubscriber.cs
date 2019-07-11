using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Subscribers
{
    using Core;
    using Core.Attributes;
    using Entities;

    //[Injectable(typeof(IPlatformEventSubscriber))]
    public class PlatformEventSubscriber : IPlatformEventSubscriber
    {
        public IPlatformAction[] Actions { get; internal set; }

        public string Message { get; internal set; }

        public string EventId { get; internal set; }
    }
}
