using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Resources
{
    using Core;
    using Core.Structs;
    using Core.Attributes;

    [Resource("dog")]
    public class Dog
    {
        private IPlatformContext context;

        public Dog(IPlatformContext context) => this.context = context;
        
        [HttpGet("{name}")]
        public async Task<object> Get(string name)
        {
            await Task.Delay(0);

            return new { DogName = name };
        }
    }
}
