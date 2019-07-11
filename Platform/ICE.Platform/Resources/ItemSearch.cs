using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ICE.Platform.Resources
{
    using Core;
    using Core.Structs;
    using Core.Attributes;
    using Entities;

    [Resource("items")]
    public class ItemSearch
    {
        private IPlatformContext context;

        public ItemSearch(IPlatformContext context) => this.context = context;

        [HttpGet("{name}")]
        public async Task<object> Get(string name)
        {
            var items = await context.Set<Item>().Query(string.Format("ItemName = '{0}'", name));

            return items.FirstOrDefault();
        }
    }
}
