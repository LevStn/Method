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
        public static int FindTheNumberOfPositiveNumbersWhoseSquareIsLessThan(int a)
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
            return result;
        }
        public static int GetGreatestDivisorOtherThanOriginalNumber(int a)
        {
            int remainder = 1;
            int result = 0;
            for (int i = 1; i < a; i++)
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

            if (b < a)
            {
                tmp = b;
                b = a;
                a = tmp;
            }
            for (int i = a; i <= b; i++)

                if (i % 7 == 0)
                {
                    result += i;
                }
            return result;
        }
        public static int OrdinalNumberOfFibonacciNumber(int n)
        {
            if (n<0)
            {
                throw new Exception("n can’t <0");
            }
            int firstNumbFib = 0;
            int secondNumbFib = 1;
            for (int i = 0; i < n; i++)
            {
                firstNumbFib = firstNumbFib + secondNumbFib;
                secondNumbFib = firstNumbFib - secondNumbFib;
            }
            return firstNumbFib;
        }
        public static int FindTheGreatestCommonDivisorUsingTheEuclideanAlgorithm ( int numbA, int numbB)
        {
            numbA=Math.Abs(numbA);
            numbB=Math.Abs(numbB);  
            while ( numbA != numbB)
            {
                

                if (numbA == 0|| numbB== 0)
                {
                    throw new Exception("variable numbB and numbA can’t == 0");
                }
                else if (numbA>numbB)
                {
                   numbA = numbA - numbB;
                }
                else
                {
                   numbB = numbB - numbA;
                }
            }
            return numbB;
        }
        
        public static double FindNumberThatIsACubeOfANumberByTheMethodOfHalfDivision(double n)
        {
            double left = 0;
            double right = n;
            double tmp = 0;

            while (left * left * left != n && right * right * right != n)
            {
                tmp = (left + right) / 2;

                if (tmp * tmp * tmp >= n)
                {
                    right = tmp;
                }
                else
                {
                    left = tmp;
                }
            }
            return right;
        }

        public static int FindTheNumberOfOddDigit(int numbA)
        {
            int tmp;

            int numberOfodd = 0;

            while (numbA != 0)
            {
                tmp = numbA % 10;
                numbA /= 10;


                if (tmp % 2 != 0)
                {
                    numberOfodd++;
                }
            }
            return numberOfodd;
        }

        public static int GetMirroredNumber (int inputNumb)
        {
            int result = 0;
            while (inputNumb > 0)
            {
                int tmp = inputNumb % 10;
                inputNumb = inputNumb / 10;

                result = result * 10;
                result = tmp + result;
            }
            return result;

        }
        /*public static void FFFF (int n, out int even, out int notEven)
        {
            int tmp;
            int remainder;
            int even;
            int notEven;
            for (int i = 1; i <= n; i++)
            {
                tmp = i;
                even = 0;
                notEven = 0;
                while (tmp != 0)
                {
                    remainder = tmp % 10;
                    tmp = tmp / 10;

                    if (remainder % 2 == 0)
                    {
                        even = even + remainder;
                    }
                    else
                    {
                        notEven = notEven + remainder;
                    }
                }
                if (even > notEven)
                {
                    Console.WriteLine(i);

                }

            }*/

        public static string  FindTheSameDigitInNumbers (int numbFirst,int numbSecond)
        {
            int tmp1;
            int secondNumber;
            int tmp2;
            numbFirst = Math.Abs(numbFirst);
            numbSecond = Math.Abs(numbSecond);
            bool isEqualNumber = false;
            string yes = "ДА";
            string no = "НЕТ";
            while (numbFirst > 1)
            {
                tmp1 = numbFirst % 10;
                secondNumber = numbSecond;
                while (secondNumber >= 1)
                {
                    tmp2 = secondNumber / 10;
                    if (tmp1 == tmp2)
                    {
                        isEqualNumber = true;
                    }

                    secondNumber = secondNumber / 10;
                }
                numbFirst = numbFirst / 10;
            }
            if (isEqualNumber)
            {
                return yes;
            }
            else
            {
                return no;
            }









        }
    }
}
