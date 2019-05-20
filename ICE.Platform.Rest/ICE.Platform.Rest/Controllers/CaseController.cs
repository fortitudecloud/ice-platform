using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICE.Platform.Rest.Controllers
{
    using Core;
    using Entities;

    public class CaseController : RestControllerBase<Case>
    {
        public CaseController(IPlatformContext context) : base(context) { }
    }
}