using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    /// <summary>
    /// 多态
    /// </summary>
    class Polymorphism
    {
        private static Animal[] arrayAnimals;

        static void Main1(string[] args)
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

    /// <summary>
    /// 接口
    /// </summary>
    class Interface
    {
        static void Main(string[] args)
        {
            MachineCat mCat = new MachineCat("叮当");
            HankDog hDog = new HankDog("汉克");

            IChange[] arrayChange = new IChange[2];
            arrayChange[0] = mCat;
            arrayChange[1] = hDog;

            Console.WriteLine(arrayChange[0].ChangeThing("时光门!"));
            Console.WriteLine(arrayChange[1].ChangeThing("二郎神!"));

            Console.ReadKey();
        }
    }
}
