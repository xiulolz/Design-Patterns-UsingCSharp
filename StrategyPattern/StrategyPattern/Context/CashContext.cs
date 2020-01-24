using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interface;
using StrategyPattern.Interface.Extends;

namespace StrategyPattern.Context
{
    /// <summary>
    /// 策略模式
    /// </summary>
    public class CashContext
    {
        private ICashStrategy fStragtegy;

        /// <summary>
        /// strategy
        /// </summary>
        /// <param name="strategy"></param>
        public CashContext(ICashStrategy strategy)
        {
            fStragtegy = strategy;
        }

        /// <summary>
        /// strategy+factory
        /// </summary>
        /// <param name="type"></param>
        public CashContext(string type, double moneyRebate = 1, double moneyCondition = 300, double moneyReturn = 100)
        {
            fStragtegy = type switch
            {
                "Normal" => new CashNormal(),
                "Rebate" => new CashRebate(moneyRebate),
                "Return" => new CashReturn(moneyCondition, moneyReturn),
                _ => throw new Exception("不知名的外星人")
            };
        }

        /// <summary>
        /// 策略模式必須萃取出這些演算法中的公共功能。
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double GetResult(double money)
        {
            return fStragtegy.AcceptCash(money);
        }
    }
}
