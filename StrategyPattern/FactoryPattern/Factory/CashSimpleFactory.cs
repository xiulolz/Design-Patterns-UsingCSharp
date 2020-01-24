using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interface;
using FactoryPattern.Interface.Extends;

namespace FactoryPattern.Factory
{
    public static class CashSimpleFactory
    {
        /// <summary>
        /// 簡單工廠pattern
        /// </summary>
        /// <returns></returns>
        public static ICash CreateCashFactory(CashType cashType)
        {
            ICash instance = cashType switch
            {
                CashType.Normal => new CashNormal(),
                CashType.Rebate => new CashRebate(0.8),
                CashType.Return => new CashReturn(300,100),
                _ => throw new Exception("不知名外星人")
            };
            return instance;
        }
    }
}
