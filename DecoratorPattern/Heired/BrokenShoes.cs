using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternPerson
{
    class BrokenShoes:Finery
    {
        public override void Show()
        {
            Console.WriteLine("破球鞋");
            base.Show();
        }
    }
}
