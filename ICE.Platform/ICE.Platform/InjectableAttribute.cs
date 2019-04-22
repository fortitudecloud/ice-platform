﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform
{
    public class InjectableAttribute : Attribute
    {        
        public Type Interface { get; private set; }
        
        public InjectableAttribute(Type type) : base()
        {
            this.Interface = type;
        }
    }
}
