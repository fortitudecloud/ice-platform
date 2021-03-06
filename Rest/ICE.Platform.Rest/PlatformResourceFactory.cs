﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICE.Platform.Rest
{
    using Core;
    using Core.Attributes;
    using Core.Bases;

    public class PlatformResourceFactory : PlatformResourceFactoryBase
    {
        private IServiceProvider serviceProvider;

        public PlatformResourceFactory(IServiceProvider container) => this.serviceProvider = container;

        public override object Get(string resourceName)
        {
            foreach (var resource in Platform.GetResourceList())
            {
                var meta = (ResourceAttribute)resource.GetCustomAttributes(typeof(ResourceAttribute), true)[0];

                if (meta.Name.ToLower() == resourceName.ToLower())
                {
                    var instance = serviceProvider.GetService(resource);

                    return instance;
                }
            }

            return null;
        }
    }
}
