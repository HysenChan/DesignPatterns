using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class Mouse
    {
        private string name;
        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run(object sender,CatShoutEventArgs args)
        {
            Console.WriteLine("老猫{0}来了，{1}快跑",args.Name,name);
        }
    }
}
