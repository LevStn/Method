using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    static class HW1Class
    {
        public static void GetResultDevisionWithRemaider(int a,  int b, out int result, out int remainder)
        {
            
            if (b == 0)
            {
                throw new Exception("variable b can’t == 0");
            }
            result = a / b;
            remainder = a % b;
        }  




        public static int GetTheResultOfEquation(int a, int b)
        {
            if(b==a)
            {
                throw new Exception("a can’t == b");
            }

            int result = (5 * a + (b * b)) / (b - a);

            return result;
        }


        public static void SwapTheContentsOfTwoVariables(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
       
        public static int GetTheResultOfLinearEquation(int a, int b, int c)
        {


            int result = (c - b) / 2;

            return result;
        }


        public static void GetTheSolutionOfTheLinearEquationStraightLineIn4Coordinates(double x1, double y1, double x2,double y2,
            out double pointA, out double pointB)
        {

            
            pointA = (y1 - y2) / (x1 - x2);
            pointB = y2 - pointA * x2;
                    
        }
    }
}
