using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Triggers
{
    using System.Threading.Tasks;
    using Entities;

    public partial class CaseTrigger
    {
        IService service;
        public CaseTrigger(IService service)
        {
            this.service = service;
        }

        public override Task BeforeCreate(IEnumerable<Case> objects)
        {
            throw new NotImplementedException();
        }
    }

    public interface IService { }

    [Injectable(typeof(IService))]
    public class ServiceTime : IService { }
}
