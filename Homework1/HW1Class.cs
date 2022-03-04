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
                throw new Exception("Значение b не может == 0");
            }
            result = a / b;
            remainder = a % b;
        }  




        public static int GetTheResultOfEquation(int a, int b)
        {


            int result = (5 * a + (b * b)) / (b - a);

            return result;
        }




        public static void GetTheResultOfLinearEquation4()
        {
            int a;
            int b;
            int c;
            int result;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            result = SolvingLinearEquation4(a, b, c);

            Console.WriteLine(result);

        }
        public static int SolvingLinearEquation4(int a, int b, int c)
        {


            int result = (c - b) / 2;

            return result;
        }


        public static string EquationOfaStraightLineIn4Coordinates()
        {

            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double pointA = (y1 - y2) / (x1 - x2);
            double pointB = y2 - pointA * x2;

            string ResultA = Convert.ToString(pointA);
            string ResultB = Convert.ToString(pointB);
            string result = ($"{ResultA}   {ResultB}");
            return result;
        }


    }



}
