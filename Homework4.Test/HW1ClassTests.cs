using NUnit.Framework;
using System;

namespace Homework4.Test
{
    public class HW1ClassTests
    {


        [TestCase(7, 3, new int[] { 2,1})]
        [TestCase(0, 3, new int[] { 0, 0 })]
        [TestCase(6, 3, new int[] { 2, 0 })]
        [TestCase(-6, 2, new int[] { -3, 0 })]
        [TestCase(1, 1, new int[] { 1, 0 })]
        [TestCase(-1, -1, new int[] { 1, 0 })]
        public void GetResultDevisionWithRemaiderTest(int a, int b, int[] expected)
        {

            int[] actual = HW1Class.GetResultDevisionWithRemaider(a, b);

            Assert.AreEqual(expected, actual);
            
        }


        [TestCase(7, 0)]
        [TestCase(-7, 0)]
        [TestCase(0, 0)]
        public void AddTest_WhenBIsEqual0_ShouldThrowExeption(int a, int b)
        {
            Assert.Throws<Exception>(() => HW1Class.GetResultDevisionWithRemaider(a, b));
        }




        [TestCase(4, 5, 45)]
        [TestCase(0, 5, 5)]
        [TestCase(5, 0, -5)]
        [TestCase(1, 2, 9)]
        [TestCase(2, 1, -11)]
        [TestCase(-2, -1, -9)]
        public void GetTheResultOfEquationTest(int a, int b, int expected)

        {
            int actual=HW1Class.GetTheResultOfEquation(a, b);

            Assert.AreEqual(expected, actual);

        }


        [TestCase(7, 7)]
        [TestCase(-7, -7)]
        [TestCase(0, 0)]
        public void AddTest_WhenAIsEqualB_ShouldThrowExeption(int a, int b)
        {
            Assert.Throws<Exception>(() => HW1Class.GetTheResultOfEquation(a, b));
        }

             


        [TestCase("one", "two","two","one")]
        [TestCase("1", "2", "2", "1")]
        [TestCase("12", "23", "23", "12")]
        [TestCase("ONE", "TWO", "TWO", "ONE")]
        public void SwapTheContentsOfTwoVariablesTest( string a,  string b,string expectedA, string expectedB)
        {
            HW1Class.SwapTheContentsOfTwoVariables(ref a, ref b);

            Assert.AreEqual(expectedA,a);
            Assert.AreEqual(expectedB,b);
        }




        [TestCase(1, 2, 3,  1)]
        [TestCase(10, 5, 15, 1)]
        [TestCase(10, 0, 15, 1.5)]
        [TestCase(1, 0, -20, -20)]
        [TestCase(-20, 20, 0, 1)]
        public  void GetTheResultOfLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual=HW1Class.GetTheResultOfLinearEquation(a, b, c);

            Assert.AreEqual(actual, expected);

        }


        [TestCase(0, 7, 7)]
        [TestCase(0, -7, -7)]
        [TestCase(0, 0, 0)]
        public void AddTest_WhenAIsEqual0_ShouldThrowExeption(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => HW1Class.GetTheResultOfLinearEquation(a, b, c));
        }





        [TestCase(0, 0, 5, 0, 0, 0)]
        [TestCase(0, 2, 5, 1, -5, 25)]
        [TestCase(0, 3, 5, 3, 0, 3)]
        [TestCase(6, 25, 3.5, 5, 8, -23)]
        public  void GetTheSolutionOfTheLinearEquationStraightLineIn4CoordinatesTest(double x1, double y1, double x2, double y2,
             double pointA,  double pointB )
        {
            
            HW1Class.GetTheSolutionOfTheLinearEquationStraightLineIn4Coordinates(x1, y1, x2, y2, out pointA, out pointB);
            double expectedA= pointA;
            double expectedB = pointB;

            Assert.AreEqual(expectedA, pointA);
            Assert.AreEqual(expectedB, pointB);

        }



        [TestCase(0, 0, 0, 0, 0, 0)]
        [TestCase(-5, -5, -5, -5, -5, -5)]
        [TestCase(5, 5, 5, 5, 5, 5)]       
        public void AddTest_WhenX1IsEqualX2_ShouldThrowExeption(double x1, double y1, double x2, double y2,
             double pointA, double pointB)
        {


            Assert.Throws<Exception>(() => HW1Class.GetTheSolutionOfTheLinearEquationStraightLineIn4Coordinates(x1, y1, x2, y2, out pointA, out pointB));
        }

    }
}