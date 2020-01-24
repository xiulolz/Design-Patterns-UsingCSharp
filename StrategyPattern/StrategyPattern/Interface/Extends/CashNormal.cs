using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface.Extends
{
    public class CashNormal : ICashStrategy
    {
        public double AcceptCash(double money)
        {
            return money;
        }
    }
}
