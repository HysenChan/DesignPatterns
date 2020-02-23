using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class FactoryMethodPatternMain
    {
        static void Main(string[] args)
        {
            LeiFeng leiFeng = new Undergraduate();
            leiFeng.BuyRice();
            leiFeng.Sweep();
            leiFeng.Wash();

            Console.ReadKey();
        }
    }
}
