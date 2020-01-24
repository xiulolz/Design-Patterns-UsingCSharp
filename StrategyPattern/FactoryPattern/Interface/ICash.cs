using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interface
{
    /// <summary>
    /// 現金收取介面
    /// </summary>
    public interface ICash
    {
        /// <summary>
        /// 收取現金方法
        /// </summary>
        /// <param name="money">原價</param>
        /// <returns>現價</returns>
        public double AcceptCash(double money);
    }
}
