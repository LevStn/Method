using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class HW2Class
    {
        public static double CompareTwoValuesAndPerformAMathematicalCharacteristicDependingOnTheComparison(double a, double b)
        {
            double result;
            if (a > b)
            {
                result = a + b;
            }

            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;

        }
        public static string GetQuarterBasedOnTwoCoordinates (double x, double y)
        {
            string result;
            if (x > 0 && y > 0)
            {
                result = "Первая координатная четверть";
            }
            else if (x > 0 && y > 0)
            {
                result = "Четвертая координатная четверть";
            }
            else if (x < 0 && y > 0)
            {
                result = "Вторая координатная четверть";
            }
            else if (x < 0 && y < 0)
            {
                result = "Третья координатная четверть";
            }
            else if (x < 0 && y == 0)
            {
                result = "Точка лежит на отрицательной полуоси абсцисс";
            }
            else if (x > 0 && y == 0)
            {
                result = "Точка лежит на положительной полуоси абсцисс";
            }
            else if (x == 0 && y < 0)
            {
                result = "Точка лежит на отрицательной полуоси ординат";
            }
            else if (x == 0 && y > 0)

            {
                result = "Точка леждит на положительной полуоси ординат";
            }

            else
            {
                result = "Ноль";
            }

                return result; 
        }
        public static string GetNumbersInAscendingOrder(double a, double b, double c)
        {
            string result;
            if (a > b && a > c && b > c)
            {
                result = "${ c, b, a }";

            }
            else if (a > b && a > c && b < c)
            {
                result = "${b, c, a}";
            }
            else if (a > b && a < c && b < c)
            {
                result = "${b, a, c}";
            }
            else if (a > c && b > c && b > a)
            {
                result = "${c, a, b }";
            }
            else if (a < b && a < c && b > c)
            {
                result = "${a, c, b}";
            }
            else if (a < b && a < c && b > c)
            {
                result = "${a, b, c}";
            }
            else
                throw new Exception("The numbers cannot be equal to each other");

            return result;
        }


    }
}