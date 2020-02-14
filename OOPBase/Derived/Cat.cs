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

        public override string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵,";
            }

            return "我的名字为" + name + " " + result;
        }
    }
}
