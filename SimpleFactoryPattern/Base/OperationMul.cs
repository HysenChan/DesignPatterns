﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class OperationMul:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}
