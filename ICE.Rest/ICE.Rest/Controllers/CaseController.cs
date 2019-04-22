using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Rest.Controllers
{
    using ICE.Platform;
    using ICE.Platform.Entities;

    public class CaseController : RestControllerBase<Case>
    {        
        public CaseController(IPlatformTrigger<Case> trigger, IPlatformContext context) : base(trigger, context) { }
    }
}