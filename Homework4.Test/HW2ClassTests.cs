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




    }
}






  

