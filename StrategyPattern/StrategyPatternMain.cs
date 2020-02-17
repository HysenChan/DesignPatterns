using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class StrategyPatternMain
    {
        static void Main(string[] args)
        {
            CashSuper cashSuper = CashFactory.createCashAccept("满300减100");
            double totalPrices = 0d;
            double total=0d,price = 130d, num = 3d;
            totalPrices = cashSuper.acceptCash(price * num);
            total += totalPrices;
            Console.WriteLine("单价为：{0}，数量：{1}，总价：{2}",price,num,total);
            Console.ReadLine();
        }
    }
}
