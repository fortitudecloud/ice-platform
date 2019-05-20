using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    public interface IPlatformEntity
    {
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string LastModifiedBy { get; set; }
        DateTime LastModifiedDate { get; set; }
    }
}
