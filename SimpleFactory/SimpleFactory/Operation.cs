using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public interface Operation
    {
        /// <summary>
        /// 要運算的第一個數字
        /// </summary>
        public double Number1 { get; set; }

        /// <summary>
        /// 要運算的第二個數字
        /// </summary>
        public double Number2 { get; set; }

        /// <summary>
        /// 取得結果
        /// </summary>
        /// <returns></returns>
        public double GetResult();
    }
}
