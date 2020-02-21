using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternPerson
{
    class BitTrouser:Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }
}
