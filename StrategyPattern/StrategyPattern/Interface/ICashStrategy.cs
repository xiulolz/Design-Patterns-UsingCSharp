using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface
{
    /// <summary>
    /// 策略模式
    /// </summary>
    public interface ICashStrategy
    {
        /// <summary>
        /// 收取現金的方法
        /// </summary>
        /// <returns></returns>
        public double AcceptCash(double money);
    }
}
