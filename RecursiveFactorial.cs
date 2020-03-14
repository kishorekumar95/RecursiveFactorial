using System;
using System.Collections.Generic;
using System.Text;

namespace RecursiveFactorial_Test
{
    public class RecursiveFactorial
    {
        public static int FindNthFactorial(int number)
        {

            if(number > 0)
            {
                return FindNthFactorial(number - 1) * number;
            }
            else if (number < 0)
            {
                return System.Math.Abs(FindNthFactorial(number + 1) * number) * -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
