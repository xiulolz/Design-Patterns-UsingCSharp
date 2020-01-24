using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interface.Extends
{
    /// <summary>
    /// 打折收費類別
    /// </summary>
    public class CashRebate : ICash
    {
        private double fMoneyRebate = 1d;

        /// <summary>
        /// 打折收費，初始化時必須輸入折扣率
        /// </summary>
        /// <param name="moneyRebate">打折率(如八折：0.8)</param>
        public CashRebate(double moneyRebate)
        {
            fMoneyRebate = moneyRebate;
        }

        /// <summary>
        /// 折扣後價格
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double AcceptCash(double money)
        {
            return money * fMoneyRebate;
        }
    }
}
