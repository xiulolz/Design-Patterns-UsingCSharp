using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interface.Extends
{
    /// <summary>
    /// 正常收費類別
    /// </summary>
    public class CashNormal : ICash
    {
        /// <summary>
        /// 正常收費，所以原價返回
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double AcceptCash(double money)
        {
            return money;
        }
    }
}
