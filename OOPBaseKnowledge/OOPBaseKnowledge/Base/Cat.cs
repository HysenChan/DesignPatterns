using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBaseKnowledge
{
    class Cat:Animal
    {
        public Cat():base()
        { }

        public Cat(string name):base(name)
        { }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵,";
            }
        }
    }
}
