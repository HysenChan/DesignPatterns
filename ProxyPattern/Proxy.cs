using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Proxy:IGiveGift
    {
        Pursuit pursuit;

        public Proxy(SchoolGirl schoolGirl)
        {
            pursuit = new Pursuit(schoolGirl);
        }

        public void GiveDolls()
        {
            pursuit.GiveDolls();
        }

        public void GiveFlowers()
        {
            pursuit.GiveFlowers();
        }

        public void GiveChocolate()
        {
            pursuit.GiveChocolate();
        }
    }
}
