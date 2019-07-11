using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Actioners
{
    using System.Threading.Tasks;
    using Core;
    using Core.Attributes;

    [Injectable(typeof(SubActioner))]
    public class SubActioner : IPlatformAction
    {
        public Task ActionHandler(object message)
        {
            var myMessage = message;

            return Task.Delay(0);
        }
    }
}
