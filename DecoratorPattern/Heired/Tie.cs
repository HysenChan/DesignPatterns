using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternPerson
{
    class Tie:Finery
    {
        public override void Show()
        {
            Console.WriteLine("领带");
            base.Show();
        }
    }
}
