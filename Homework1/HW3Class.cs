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
        public static void FindTheNumberOfPositiveNumbersWhoseSquareIsLessThan(int a)
        {
            int result = 0;
            for (int i = 1; i < a; i++)
            {
                int square = i * i;
                if (square < a)
                {
                    result = square / i;
                }

            }
            Console.WriteLine(result);
        }
        public static int GetGreatestDivisorOtherThanOriginalNumber(int a)
        {
            int remainder = 1;
            int result = 0;
            for(int i=1; i<a; i++)
            {
                remainder = a % i;
                if (remainder == 0)
                {
                    result = +i;
                }
                
            }
            return result;
        }
        public static int GetSumOfNumbersFromTheRangeThatAreDivisibleWithoutARemainderBy7(int a, int b)
        {
            int tmp;
            int result = 0;

            if(b<a)
            {
                tmp = b;
                b = a;
                a = tmp;
            }
            for (int i=a;i<=b; i++)

                if (i%7==0)
                {
                    result += i;
                }
            return result;
        }

    }
}
