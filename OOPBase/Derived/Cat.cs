using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class Cat:Animal
    {
        public Cat():base()
        { }

        public Cat(string name):base(name)
        { }

        protected override string getShoutSound()
        {
            return "喵";
        }
    }
}
