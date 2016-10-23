using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDll.Form
{
    public class CalculatorController
    {
        public CalculatorController()
        {
            
        }
        public T Add<T>(T first,T second)
        {
            return first + second;
        }
    }
}
