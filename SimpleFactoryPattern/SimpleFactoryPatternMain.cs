using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class SimpleFactoryPatternMain
    {
        static void Main(string[] args)
        {
            try
            {
                Operation oper;

                Console.WriteLine("请输入数字A：");
                string strNumberA = Console.ReadLine();

                Console.WriteLine("请输入运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                oper = OperationFactory.createOperate(strOperate);

                Console.WriteLine("请输入数字B：");
                string strNumberB = Console.ReadLine();

                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);

                double strResult = oper.GetResult();
                Console.WriteLine("结果是：" + strResult);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
