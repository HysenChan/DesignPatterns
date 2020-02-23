using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class ProxyPatternMain
    {
        static void Main(string[] args)
        {
            SchoolGirl schoolGirl = new SchoolGirl();
            schoolGirl.Name = "夏兰";

            Proxy proxy = new Proxy(schoolGirl);
            proxy.GiveChocolate();
            proxy.GiveDolls();
            proxy.GiveFlowers();

            Console.ReadKey();
        }
    }
}
