using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class HW3Class
    {
        public static int RaiseTheNumberToTheDegreeofTheSecondNumber(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
        public static int GetAllNumbersThatAreDivisibleByTheNumberA(int a)
        {
            int result = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    result = +i;
                    Console.WriteLine(result);
                }
            }
            return result;
        }




    }
}
