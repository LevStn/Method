using System;
using NUnit.Framework;

namespace Homework4.Test
{
    public class HWArrayClassTests
    {

        [TestCase(new int[] { 1, 6, 5 }, 1)]
        [TestCase(new int[] { -1, -2, -3 }, -3)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 1, 1, 1 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, null)]
        public void GetMinElementArrayTest(int[] firstArray, int expected)
        {
            
            int actual = HWArrayClass.GetMinElementArray(firstArray);

            Assert.AreEqual(expected, actual);

        }


       


        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { -1, -2, -3 }, -1)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 1, 1, 1 }, 1)]
        [TestCase(new int[] { 0 }, 0)]      
        public void GetMaxElementArrayTest(int[] firstArray, int expected)
        {
            int actual = HWArrayClass.GetMaxElementArray(firstArray);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { -1, -2, -3 }, 2)]
        [TestCase(new int[] { 0, 0, 0 }, 2)]
        [TestCase(new int[] { 1, 0, 1, 5 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, null)]
        public void GetIndexMinElementArrayTest(int[] firstArray, int expected)
        {
            int actual = HWArrayClass.GetIndexMinElementArray(firstArray);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { -1, -2, -3 }, 0)]
        [TestCase(new int[] { 0, 0, 0 }, 2)]
        [TestCase(new int[] { 1, 0, 1, 3 }, 3)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, null)]
        public void GetIndexMaxElementArrayTest(int[] firstArray, int expected)
        {
            int actual = HWArrayClass.GetIndexMaxElementArray(firstArray);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { -1, -2, -3, 3 }, 1)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 1, 0, 1, 3 }, 3)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] {  }, null)]
        public void SumOfElementsArrayTest(int[] firstArray, int expected)
        {
            int actual = HWArrayClass.SumOfElementsArray(firstArray);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 22, 500, 3 }, new int[] { 3, 500, 22 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseArrayTest(int[] array, int[] expected)
        {
            int[] actual = HWArrayClass.ReverseArray(array);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { -1, -2, -3, 3 }, 3)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 1, 0, 4, 6 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] {  }, null)]
        public void NumberOfOddElementsTest(int[] firstArray, int expected)
        {
            int actual = HWArrayClass.NumberOfOddElements(firstArray);

            Assert.AreEqual(expected, actual);

        }

        


        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, }, new int[] { 4, 5, 3, 1, 2 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseHalfArrayTest(int[] array, int[] expected)
        {
            int[] actual = HWArrayClass.ReverseHalfArray(array);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(new int[] { 6, 10, 3, 4 }, new int[] { 3, 4, 6, 10 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortArrayAscendingInsertTest(int[] array, int[] expected)
        {
            int[] actual = HWArrayClass.SortArrayAscendingInsert(array);

            Assert.AreEqual(expected, actual);
        }




        [TestCase(new int[] { 6, 10, 3, 4 }, new int[] { 10, 6, 4, 3 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortArrayBubbleDescendingTest(int[] array, int[] expected)
        {
            int [] actual = HWArrayClass.SortArrayBubbleDescending(array);

            Assert.AreEqual (expected, actual);
        }
    }
}
