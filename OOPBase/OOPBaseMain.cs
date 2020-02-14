using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class OOPBaseMain
    {
        private static Animal[] arrayAnimals;

        static void Main(string[] args)
        {
            SignUp();
            DisplayVedio();
            Console.ReadLine();
        }

        private static void DisplayVedio()
        {
            foreach (var item in arrayAnimals)
            {
                Console.WriteLine(item.Shout());
            }
        }

        private static void SignUp()
        {
            arrayAnimals = new Animal[5];
            arrayAnimals[0] = new Cat("Cat1");
            arrayAnimals[1] = new Dog("Dog1");
            arrayAnimals[2] = new Cat("Cat2");
            arrayAnimals[3] = new Dog("Dog2");
            arrayAnimals[4] = new Cat("Cat3");
        }
    }
}
