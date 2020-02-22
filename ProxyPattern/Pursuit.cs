using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Pursuit
    {
        SchoolGirl schoolGirl;

        public Pursuit(SchoolGirl schoolGirl)
        {
            this.schoolGirl = schoolGirl;
        }

        public void GiveDolls()
        {
            Console.WriteLine(schoolGirl.Name+"送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(schoolGirl.Name + "送你花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(schoolGirl.Name + "送你巧克力");
        }
    }
}
