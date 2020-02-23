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
            //TODO:简单工厂的实例化时会有重复代码，后面会用工厂方法类
            LeiFeng v1 = SimpleFactory.CreateLeiFeng("社区志愿者");
            LeiFeng v2 = SimpleFactory.CreateLeiFeng("社区志愿者");
            LeiFeng s1 = SimpleFactory.CreateLeiFeng("学雷锋的大学生");

            v1.Wash();
            v2.Sweep();
            s1.BuyRice();

            Console.ReadKey();
        }
    }
}
