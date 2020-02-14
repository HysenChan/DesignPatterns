using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class Dog : Animal
    {
        public Dog() : base()
        { }

        public Dog(string name) : base(name)
        { }

        protected override string getShoutSound()
        {
            return "汪";
        }
    }
}
