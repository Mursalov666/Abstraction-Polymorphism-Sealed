using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal sealed class Multiplication : Calculation
    {
        internal override int Operate(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
