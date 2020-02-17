using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class StrategyPatternMain
    {
        static double total = 0d;
        
        private static void Strategy()
        {
            Console.WriteLine("请输入收费标准：");
            string inputType = Console.ReadLine();
            CashContext cashContext = new CashContext(inputType);
            
            double totalPrices = 0d,price = 130d, num = 3d; 
            totalPrices = cashContext.GetResult(price* num);
            total += totalPrices;
            Console.WriteLine("单价为：{0}，数量：{1}，总价：{2}",price,num,total);
        }

        static void Main(string[] args)
        {
            Strategy();
            Console.ReadLine();
        }
    }
}
