using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Core
{
    public interface IPlatformMutation
    {
        Task<object> Mutate(object input);
    }
}
