using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitSample
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public decimal Add(int number1, int number2)
        {
            var result = number1 + number2;

            return result;
        }

        public decimal Subtract(int number1, int number2)
        {
            var result = number1 - number2;

            return result;
        }

        public decimal Divide(int number1, int number2)
        {
            //if (number2 == 0)
            //{
            //    throw new Exception("Not allow divide by 0");
            //}

            var result = (decimal)number1 / (decimal)number2;

            return result;
        }
    }
}
