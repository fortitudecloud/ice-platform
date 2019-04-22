﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Entities
{
    public class Case : IPlatformEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }    
}

namespace ICE.Platform.Triggers
{
    using Entities;
    public partial class CaseTrigger : PlatformTriggerBase<Case> { }
}
