using NUnit.Framework;
using System;

namespace Homework4.Test
{
    public class HW3ClassTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 2, 9)]
        [TestCase(10, 1, 10)]
        [TestCase(0, 2, 0)]
        [TestCase(0, 0, 1)]
        [TestCase(2, 0, 1)]
        [TestCase(-222, 0, 1)]
        [TestCase(-2, 2, 4)]
        [TestCase(-2, 3, -8)]
        public void RaiseTheNumberToTheDegreeOfTheSecondNumberTest(int a, int b, int expected)
        {
            int actual = HW3Class.RaiseTheNumberToTheDegreeOfTheSecondNumber(a, b);

            Assert.AreEqual(expected, actual);

        }




        [TestCase(1000 , new int[] { 1000 })]
        [TestCase(500, new int[] { 500,1000 })]
        [TestCase(-500, new int[] { 500, 1000 })]
        [TestCase(-125, new int[] {125, 250, 375, 500, 625, 750, 875, 1000 })]
        public void GetAllNumbersThatAreDivisibleByTheNumberATest(int a, int [] expected)
        {
            int[] actual = HW3Class.GetAllNumbersThatAreDivisibleByTheNumberA(a);

            Assert.AreEqual(expected,actual);

        }


        [TestCase(0)]       
        public void AddTest_WhenAIsEqual0_ShouldThrowExeption(int a)
        {
           
            Assert.Throws<Exception>(() => HW3Class.GetAllNumbersThatAreDivisibleByTheNumberA(a));

        }




        [TestCase(1, 0)]
        [TestCase(0, 0)]
        [TestCase(2, 1)]
        [TestCase(8, 2)]
        [TestCase(27, 5)]
        [TestCase(-52151, 0)]
        public void FindTheNumberOfPositiveNumbersWhoseSquareIsLessThanTest(int a, int expected)
        {
            int actual = HW3Class.FindTheNumberOfPositiveNumbersWhoseSquareIsLessThan(a);

            Assert.AreEqual(expected, actual);

        }




        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(25, 5)]
        [TestCase(-25, 25)]
        [TestCase(-500, 500)]
        public void GetGreatestDivisorOtherThanOriginalNumberTest(int a, int expected)
        {
            int actual = HW3Class.GetGreatestDivisorOtherThanOriginalNumber(a);

            Assert.AreEqual(expected, actual); 

        }


        [TestCase(0)]
        [TestCase(1)]
        public void AddTest_WhenAIsEqual0or1_ShouldThrowExeption(int a)
        {

            Assert.Throws<Exception>(() => HW3Class.GetGreatestDivisorOtherThanOriginalNumber(a));

        }




        [TestCase(1, 7, 7)]
        [TestCase(1, 27, 42)]
        [TestCase(28, 1, 70)]
        [TestCase(0, 36, 105)]
        [TestCase(-7, 7, 0)]
        [TestCase(-14, 7, -14)]
        [TestCase(-14, 0, -21)]
        [TestCase(-21, 7, -35)]
        [TestCase(0, 0, 0)]
        [TestCase(-7, -1, -7)]
        public void GetSumOfNumbersFromTheRangeThatAreDivisibleWithoutARemainderBy7Test(int a, int b, int expected)
        {
            int actual = HW3Class.GetSumOfNumbersFromTheRangeThatAreDivisibleWithoutARemainderBy7(a, b);

               Assert.AreEqual(expected, actual);
        }




        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(8, 21)]
        [TestCase(18, 2584)]
        public void OrdinalNumberOfFibonacciNumberTest(int n, int expected)
        {
            int actual = HW3Class.OrdinalNumberOfFibonacciNumber(n);

            Assert.AreEqual(expected, actual);

        }


        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void AddTest_WhenNIsEqual0OrLess0_ShouldThrowExeption(int n)
        {

            Assert.Throws<Exception>(() => HW3Class.OrdinalNumberOfFibonacciNumber(n));

        }




        [TestCase(2, 8, 2)]
        [TestCase(3, 9, 3)]
        [TestCase(28, 7, 7)]
        [TestCase(25, 15, 5)]
        [TestCase(-300, 36, 12)]
        [TestCase(27, 27, 27)]
        public void FindTheGreatestCommonDivisorUsingTheEuclideanAlgorithmTest (int numbA, int numbB, int expected)
        {
            int actual=HW3Class.FindTheGreatestCommonDivisorUsingTheEuclideanAlgorithm(numbA, numbB);

            Assert.AreEqual(actual, expected);
        }


        [TestCase(0, 0)]
        [TestCase(0, -1)]
        [TestCase(1, 0)]
        public void AddTest_WhenNumbAOrNumbBIsEqual0_ShouldThrowExeption(int numbA, int numbB)
        {

            Assert.Throws<Exception>(() => HW3Class.FindTheGreatestCommonDivisorUsingTheEuclideanAlgorithm(numbA, numbB));

        }




        [TestCase(28,3)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-28, -3)]
        [TestCase(1000, 10)]
        public void FindNumberThatIsACubeOfANumberByTheMethodOfHalfDivisionTest(double n, double expected)
        {
            double actual =HW3Class.FindNumberThatIsACubeOfANumberByTheMethodOfHalfDivision(n);

            Assert.AreEqual(expected, actual, 0.5);
        }




        [TestCase(123, 2)]
        [TestCase(0, 0)]
        [TestCase(246, 0)]
        [TestCase(-333, 3)]
        [TestCase(333, 3)]
        [TestCase(12, 1)]
        public void FindTheNumberOfOddDigitTest(int numbA, int expected)
        {
            int actual = HW3Class.FindTheNumberOfOddDigit(numbA);

            Assert.AreEqual(expected, actual);

        }




        [TestCase(00, 00)]
        [TestCase(111, 111)]
        [TestCase(123,321)]
        [TestCase(422222, 222224)]
        [TestCase(467985, 589764)]
        [TestCase(1, 1)]
        [TestCase(12345, 54321)]
        [TestCase(12345, 54321)]
        public void GetMirroredNumberTest(int inputNumb, int expected)
        {

            int actual=HW3Class.GetMirroredNumber(inputNumb);

            Assert.AreEqual(expected, actual);

        }


        [TestCase(-1)]
        [TestCase(-22)]
        [TestCase(-100)]
        public void AddTest_WhenInputNumbLess0_ShouldThrowExeption(int inputNumb)
        {
            Assert.Throws<Exception>(() => HW3Class.GetMirroredNumber(inputNumb));

        }




        [TestCase(23,new int[] {2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22 })]
        [TestCase(10, new int[] { 2, 4, 6, 8 })]
        [TestCase(2, new int[] { 2 })]
        [TestCase(2, new int[] { 2, })]
        [TestCase(8, new int[] { 2, 4, 6, 8 })]
        public void GetRangeOfNumbersSumOfEvenNumbersGreaterThanOddNumbersTest(int n, int [] expected)
        {
            int [] actual=HW3Class.GetRangeOfNumbersSumOfEvenNumbersGreaterThanOddNumbers(n);

            Assert.AreEqual(expected, actual);

        }


        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-5)]
        public void AddTest_WhenNEqualOrLess1_ShouldThrowExeption(int n)
        {
            Assert.Throws<Exception>(() => HW3Class.GetRangeOfNumbersSumOfEvenNumbersGreaterThanOddNumbers(n));

        }




        [TestCase(123, 1564,"ДА")]
        [TestCase(26541, 1, "ДА")]
        [TestCase(26541, 66666, "ДА")]
        [TestCase(5, 5, "ДА")]
        [TestCase(2541, 66666, "НЕТ")]
        [TestCase(1, 2, "НЕТ")]
        [TestCase(2978, 1454444, "НЕТ")]
        [TestCase(-222, -211, "ДА")]       
        public void FindTheSameDigitInNumbersTest(int numbFirst, int numbSecond, string expected)
        {
            
            string actual = HW3Class.FindTheSameDigitInNumbers(numbFirst, numbSecond);
            Assert.AreEqual (expected, actual);
        }


        [TestCase(0, 0)]
        [TestCase(123, 0)]
        [TestCase(0, 1564)]
        public void AddTest_WhenNumbFirstOrNumbSecondisEqualNull_ShouldThrowExeprion(int numbFirst, int numbSecond)
        {

            Assert.Throws<Exception>(() => HW3Class.FindTheSameDigitInNumbers(numbFirst, numbSecond));
        }


    }
}
