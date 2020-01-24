using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class OperationDiv : Operation
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public double GetResult()
        {
            double result = 0;
            result = Number1 / Number2;
            return result;
        }
    }
}
