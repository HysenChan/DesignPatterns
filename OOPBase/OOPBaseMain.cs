using System;
using System.Collections;
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
        static void Main2(string[] args)
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

    /// <summary>
    /// 集合
    /// </summary>
    partial class Assembly
    {
        static IList arrayAnimal;//==ArrayList arrayAnimal;
        public static void InstanceArrayList()
        {

            arrayAnimal = new ArrayList();
            arrayAnimal.Add(new Cat("Cat1"));
            arrayAnimal.Add(new Dog("Dog1"));
            arrayAnimal.Add(new Cat("Cat2"));
            arrayAnimal.Add(new Dog("Dog2"));

            Console.WriteLine(arrayAnimal.Count);
        }

        private static void ShoutArrayList()
        {
            foreach (Animal item in arrayAnimal)
            {
                Console.WriteLine(item.Shout());
            }
        }

        static void Main3(string[] args)
        {
            InstanceArrayList();
            ShoutArrayList();
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 泛型
    /// </summary>
    class Generic
    {
        static IList<Animal> arrayListAnimal;//==List<Animal> arrayListAnimal;
        public static void InstanceArrayList()
        {

            arrayListAnimal = new List<Animal>();
            arrayListAnimal.Add(new Cat("Cat1"));
            arrayListAnimal.Add(new Dog("Dog1"));
            arrayListAnimal.Add(new Cat("Cat2"));
            arrayListAnimal.Add(new Dog("Dog2"));

            Console.WriteLine(arrayListAnimal.Count);
        }

        private static void ShoutArrayList()
        {
            foreach (Animal item in arrayListAnimal)
            {
                Console.WriteLine(item.Shout());
            }
        }

        static void Main(string[] args)
        {
            InstanceArrayList();
            ShoutArrayList();
            Console.ReadKey();
        }
    }
}
