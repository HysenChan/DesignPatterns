using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CashContext
    {
        private CashSuper cs=null;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    CashNormal cashNormal = new CashNormal();
                    cs = cashNormal;
                    break;
                case "满300减100":
                    CashReturn cashReturn= new CashReturn("300", "100");
                    cs = cashReturn;
                    break;
                case "打八折":
                    CashRebate cashRebate = new CashRebate("0.8");
                    cs = cashRebate;
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
