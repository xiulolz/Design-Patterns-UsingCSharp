using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class OperationAdd: Operation
    {
        private double fNumber1 = 0;
        public double Number1 
        {
            get { return fNumber1; } set { fNumber1 = value; } 
        }
        public double Number2 { get; set; }

        public double GetResult()
        {
            double result = 0;
            result = Number1 + Number2;
            return result;
        }
    }
}
