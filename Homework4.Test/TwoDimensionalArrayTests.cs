using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Homework4.Test
{
    public class TwoDimensionalArrayTests
    {

        [TestCase(TwoDMock.TDAMockType.Positive3X3, 0)]
        [TestCase(TwoDMock.TDAMockType.Negative3X3,-55 )]
        [TestCase(TwoDMock.TDAMockType.Positive4X4, 1)]
        [TestCase(TwoDMock.TDAMockType.Negative2X2, -5)]
        public void GetMinElementTest(TwoDMock.TDAMockType type, int expected)
        {
            int[,] array = TwoDMock.GetMock(type);
            int actual=TwoDimensionalArray.GetMinElement(array);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(TwoDMock.TDAMockType.Positive3X3, 5)]
        [TestCase(TwoDMock.TDAMockType.Negative3X3, -1)]
        [TestCase(TwoDMock.TDAMockType.Positive4X4, 8)]
        [TestCase(TwoDMock.TDAMockType.Negative2X2, -1)]
        public void GetMaxElementTest(TwoDMock.TDAMockType type, int expected)
        {
            int[,] array = TwoDMock.GetMock(type);
            int actual = TwoDimensionalArray.GetMaxElement(array);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(TwoDMock.TDAMockType.Positive3X3, new int[] { 2, 1 })]
        [TestCase(TwoDMock.TDAMockType.Positive4X4, new int[] { 2, 1 })]
        [TestCase(TwoDMock.TDAMockType.Negative3X3, new int[] { 2, 2 })]
        [TestCase(TwoDMock.TDAMockType.Negative2X2, new int[] { 1, 1 })]
        public void GetMinIndexTest(TwoDMock.TDAMockType type, int [] expected)
        {
            int[,] array = TwoDMock.GetMock(type);
            int[] actual = TwoDimensionalArray.GetMinIndex(array);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(TwoDMock.TDAMockType.Positive3X3, new int[] { 2, 2 })]
        [TestCase(TwoDMock.TDAMockType.Positive4X4, new int[] { 3, 3 })]
        [TestCase(TwoDMock.TDAMockType.Negative3X3, new int[] { 0, 0 })]
        [TestCase(TwoDMock.TDAMockType.Negative2X2, new int[] { 0, 0 })]    
        public void GetMaxIndexTest(TwoDMock.TDAMockType type, int[] expected)
        {
            int[,] array = TwoDMock.GetMock(type);
            int[] actual = TwoDimensionalArray.GetMaxIndex(array);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(TwoDMock.TDAMockType.Positive3X3,1)]
        [TestCase(TwoDMock.TDAMockType.Negative3X3, 1)]
        [TestCase(TwoDMock.TDAMockType.Positive4X4, 3)]
        [TestCase(TwoDMock.TDAMockType.Negative2X2, 1)]       
        public void FindElementThatIsLargerThanAllItsNeighborsTest(TwoDMock.TDAMockType type, int expected)
        {
            int[,] array = TwoDMock.GetMock(type);
            int actual = TwoDimensionalArray.FindElementThatIsLargerThanAllItsNeighbors(array);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(TwoDMock.TDAMockType.Positive3X3, TwoDMock.TDAMockType.Positive3X3Swap)]
        [TestCase(TwoDMock.TDAMockType.Positive4X4, TwoDMock.TDAMockType.Positive4X4Swap)]
        [TestCase(TwoDMock.TDAMockType.Negative3X3, TwoDMock.TDAMockType.Negative3X3Swap)]
        [TestCase(TwoDMock.TDAMockType.Negative2X2, TwoDMock.TDAMockType.Negative3X3Swap)]
        [TestCase(TwoDMock.TDAMockType.Empty, TwoDMock.TDAMockType.Empty)]
        public void ReflectionMainDiagonalTest(TwoDMock.TDAMockType type, TwoDMock.TDAMockType  expectedType)
        {

            int[,] array = TwoDMock.GetMock(type);
            int [,] expected = TwoDMock.GetMock(expectedType);
            int[,] actual = TwoDimensionalArray.ReflectionMainDiagonal(array);

        }


    }
}
