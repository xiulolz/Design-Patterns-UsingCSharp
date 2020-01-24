using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interface.Extends
{
    /// <summary>
    /// 紅利收費類別
    /// </summary>
    public class CashReturn : ICash
    {
        private double fMoneyCondition = 0.0d;
        private double fMoneyReturn = 0.0d;

        /// <summary>
        /// 紅利收費，初始化時必須輸入紅利條件和紅利值，比如滿300送100，則moneyCondition為300，moneyReturn為100
        /// </summary>
        /// <param name="moneyCondition"></param>
        /// <param name="moneyReturn"></param>
        public CashReturn(double moneyCondition, double moneyReturn)
        {
            fMoneyCondition = moneyCondition;
            fMoneyReturn = moneyReturn;
        }

        public double AcceptCash(double money)
        {
            double result = money;

            // 若大於紅利條件則需要減去紅利值
            if (money >= fMoneyCondition)
            {
                result = money - Math.Floor(money / fMoneyCondition) * fMoneyReturn;
            }

            return result;
        }
    }
}
