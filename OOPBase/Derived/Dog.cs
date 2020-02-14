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

        public override string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "汪,";
            }

            return "我的名字为" + name + " " + result;
        }
    }
}
