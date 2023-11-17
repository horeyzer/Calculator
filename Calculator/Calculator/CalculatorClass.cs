using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorClass
    {
        public int number1;
        public int number2;
         public int Sum()
        {
            return number1 + number2;
        }
        public int Subtract()
        {
            return number1 - number2;
        }
        public int Multiply()
        {
            return number1 * number2;
        }
        public int Divide()
        {
            return number1 / number2;
        }
        public int Modulus()
        {
            return number1 % number2;
        }
        public int Power()
        {
            return (int)Math.Pow(number1, number2);
        }
        public int Factoctoriel()
        {
            int f = 1;
            for (int i = number1; i > 0; i--)
            {
                f = f * i;
            }
            return f;
        }


    }
}
