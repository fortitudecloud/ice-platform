using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    public interface IPlatformEventSubscriber
    {
        string EventId { get; }

        string Message { get; }

        IPlatformAction[] Actions { get; }
    }
}
