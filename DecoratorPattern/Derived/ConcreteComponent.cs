﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体抽象的操作");
        }
    }
}
