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
                Console.WriteLine("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.WriteLine("请输入运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.WriteLine("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                strResult = Convert.ToString(Operation.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));
                Console.WriteLine("结果是：" + strResult);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("你输入的有错：" + ex.Message);
            }
        }
    }
}
