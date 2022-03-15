using NUnit.Framework;

namespace Homework4.Test
{
    public class HW2ClassTests
    {
        [TestCase(3, 2, 5)]
        [TestCase(3, 0, 3)]
        [TestCase(0, 3, -3)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(5, 5, 25)]
        [TestCase(1, 2, -1)]
        [TestCase(5, 10, -5)]
        [TestCase(5, 10, -5)]
        public void CompareTwoValuesAndPerformAMathematicalCharacteristicDependingOnTheComparisonTest(double a, double b, double expected)
        {
            double actual = HW2Class.CompareTwoValuesAndPerformAMathematicalCharacteristicDependingOnTheComparison(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(0, 0, "Ноль")]
        [TestCase(1, 1, "Первая координатная четверть")]
        [TestCase(-2, 3, "Вторая координатная четверть")]
        [TestCase(-1, -10, "Третья координатная четверть")]
        [TestCase(1, -111, "Четвертая координатная четверть")]
        [TestCase(1, 0, "Точка лежит на положительной полуоси абсцисс")]
        [TestCase(-2, 0, "Точка лежит на отрицательной полуоси абсцисс")]
        [TestCase(0, 10, "Точка леждит на положительной полуоси ординат")]
        [TestCase(0, -11, "Точка лежит на отрицательной полуоси ординат")]

        public void GetQuarterBasedOnTwoCoordinatesTest(double x, double y, string expected)

        {

            string actual = HW2Class.GetQuarterBasedOnTwoCoordinates(x, y);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(3, 2, 1, new int[] { 1, 2, 3 })]
        [TestCase(3, 1, 2, new int[] { 1, 2, 3 })]
        [TestCase(1, 2, 3, new int[] { 1, 2, 3 })]
        [TestCase(1, 3, 2, new int[] { 1, 2, 3 })]
        [TestCase(2, 3, 1, new int[] { 1, 2, 3 })]
        [TestCase(2, 1, 3, new int[] { 1, 2, 3 })]
        public void GetNumbersInAscendingOrderTest(int a, int b, int c, int[] expected)
        {



            int[] actual = HW2Class.GetNumbersInAscendingOrder(a, b, c);

            Assert.AreEqual(expected, actual);

        }
        //4
        //4
        //4
        //4

        [TestCase(10,"Десять")]
        [TestCase(20, "Двадцать")]
        [TestCase(30, "Тридцать")]
        [TestCase(40, "Сорок")]
        [TestCase(50, "Пятьдесят")]
        [TestCase(60, "Шестьдесят")]
        [TestCase(70, "Семьдесят")]
        [TestCase(80, "Восемьдесят")]
        [TestCase(90, "Девяносто")]
        [TestCase(95, "Девяносто пять")]
        [TestCase(21, "Двадцать один")]
        [TestCase(12, "Двенадцать")]
        [TestCase(11, "Одинадцать")]
        [TestCase(13, "Тринадцать")]
        [TestCase(14, "Четырнадцать")]
        [TestCase(15, "Пятнадцать")]
        [TestCase(16, "Шестнадцать")]
        [TestCase(17, "Семьнадцать")]
        [TestCase(18, "Восемнадцать")]
        [TestCase(19, "Девятнадцать")]
        [TestCase(22, "Двадцать два")]
        [TestCase(23, "Двадцать три")]
        [TestCase(24, "Двадцать четыре")]
        [TestCase(35, "Тридцать пять")]
        [TestCase(36, "Тридцать шесть")]
        [TestCase(47, "Сорок семь")]
        [TestCase(58, "Пятьдесят восемь")]
        [TestCase(59, "Пятьдесят девять")]
        [TestCase(63, "Шестьдесят три")]
        [TestCase(71, "Семьдесят один")]
        [TestCase(88, "Восемьдесят восемь")]
        [TestCase(99, "Девяносто девять")]


        public void ConvertingTwoDigitNumberToLettersTest(int numb, string expected)
        {
             string actual=HW2Class.ConvertingTwoDigitNumberToLetters(numb);
            
            Assert.AreEqual(expected, actual);
        }



    }
}






  

