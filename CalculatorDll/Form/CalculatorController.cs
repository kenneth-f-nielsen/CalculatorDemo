using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDll.Form
{
    public class CalculatorController
    {
        public double Add(double first, double second)
        {
            return first+second;
        }
        public double Subtract(double first , double second)
        {
            return first - second;
        }
        public double Multiply(double first , double second)
        {
            return first * second;
        }
        public double Divide(double first , double second)
        {
            return first / second;
        }
    }
}
