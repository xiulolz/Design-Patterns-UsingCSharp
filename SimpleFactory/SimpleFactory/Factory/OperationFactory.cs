using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 簡單工廠模式，降低類別耦合性
    /// </summary>
    public static class OperationFactory
    {
        /// <summary>
        /// 根據不同enum實體化不同物件
        /// </summary>
        /// <param name="operater"></param>
        /// <returns></returns>
        public static Operation CreateOperate(Operater operater)
        {
            Operation result = operater switch
            {
                Operater.Add => new OperationAdd(),
                Operater.Sub => new OperationSub(),
                Operater.Mul => new OperationMul(),
                Operater.Div => new OperationDiv(),
                _ => throw new Exception("不知名外星人")
            };
            return result;
        }
    }
}
