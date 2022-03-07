﻿using System;
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
        public static string SloveTheSquareEquation(double a, double b, double c)
        {
            if(a==0|| b==0 )
            {
                throw new Exception("a can’t ==0, b can’t ==0");
            }
            string result;
            double discriminant = (b * b) - 4 * a * c;
            double rootD = Math.Sqrt(discriminant);
            double x1 = (-b + rootD) / (2 * a);
            double x2 = (-b - rootD) / (2 * a);
            if (discriminant > 0)
            {
                result = ($"X(1)={x1} x(2)={x2}");
            }
            else if (discriminant == 0)
            {
                result = ($"X={ -b / (2 * a)}");
            }
            else
            {
                result = "Нет корней";
            }

            return result;
        }


    
        public static string ConvertingTwoDigitNumberToLetters(int numb)
        {
            int oneNumb = numb % 10;
            int decade = numb / 10;
            int upToTwenty = numb / 1;

            string totalDecade = "";

            if(numb<10 || numb>99)
            {
                throw new Exception("numb can’t be unambiguous, numb can’t be three-digit");

            }
            switch (decade)
            {
                case 1:
                    totalDecade += "Десять";
                    break;
                case 2:
                    totalDecade += "Двадцать";
                    break;
                case 3:
                    totalDecade += "Тридцать";
                    break;
                case 4:
                    totalDecade += "Сорок";
                    break;
                case 5:
                    totalDecade += "Пятьдесят";
                    break;
                case 6:
                    totalDecade += "Шестьдесят";
                    break;
                case 7:
                    totalDecade += "Семьдесят";
                    break;
                case 8:
                    totalDecade += "Восемьдесят";
                    break;
                case 9:
                    totalDecade += "Девяносто";
                    break;




            }
            switch (oneNumb)
            {
                case 1:
                    totalDecade += " один";
                    break;
                case 2:
                    totalDecade += " два";
                    break;
                case 3:
                    totalDecade += " три";
                    break;
                case 4:
                    totalDecade += " четыре";
                    break;
                case 5:
                    totalDecade += " пять";
                    break;
                case 6:
                    totalDecade += " шесть";
                    break;
                case 7:
                    totalDecade += " семь";
                    break;
                case 8:
                    totalDecade += " восемь";
                    break;
                case 9:
                    totalDecade += " девять";
                    break;
            }
            switch (upToTwenty)
            {
                case 11:
                    totalDecade = "Одинадцать";
                    break;
                case 12:
                    totalDecade = "Двенадцать";
                    break;
                case 13:
                    totalDecade = "Тринадцать";
                    break;
                case 14:
                    totalDecade = "Четырнадцать";
                    break;
                case 15:
                    totalDecade += "Пятнадцать";
                    break;
                case 16:
                    totalDecade = "Шестнадцать";
                    break;
                case 17:
                    totalDecade = "Семьнадцать";
                    break;
                case 18:
                    totalDecade = "Восемнадцать";
                    break;
                case 19:
                    totalDecade = "Девятнадцать";
                    break;
            }

            return totalDecade;
        }

    }
}