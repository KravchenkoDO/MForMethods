using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace MethodsTasks.Tests
{
    class OneDimentionalArraysTests
    {
        [TestCase(new double [] {1, 5, 8, 3 }, 1)]
        [TestCase(new double[] { 0, 6, 8, 2 }, 0)]
        [TestCase(new double[] { 9, 9, 9, 9 }, 9)]
        [TestCase(new double[] { 0, 2, 8, 0 }, 0)]
        public void FindMinValueTests(double[] array, double expected)
        {
            double actual = OneDimentionalArrays.FindMinValue(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 5, 8, 3 }, 0)]
        [TestCase(new double[] { 3, 6, 0, 2 }, 2)]
        [TestCase(new double[] { 9, 9, 9, 9 }, 0)]
        [TestCase(new double[] { 4, 2, 8, 0 }, 3)]
        public void FindIndexOfMinValueTests(double[] array, int expected)
        {
            int actual = OneDimentionalArrays.FindIndexOfMinValue(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 5, 2, 3 }, 5)]
        [TestCase(new double[] { 8, 6, 2, 2 }, 8)]
        [TestCase(new double[] { 9, 9, 9, 9 }, 9)]
        [TestCase(new double[] { 0, 0, 0, 0 }, 0)]
        public void FindMaxValueTests(double[] array, double expected)
        {
            double actual = OneDimentionalArrays.FindMaxValue(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 5, 8, 3 }, 2)]
        [TestCase(new double[] { 3, 6, 0, 2 }, 1)]
        [TestCase(new double[] { 9, 9, 9, 9 }, 0)]
        [TestCase(new double[] { 4, 2, 8, 9 }, 3)]
        public void FindIndexOfMaxValueTests(double[] array, int expected)
        {
            int actual = OneDimentionalArrays.FindIndexOfMaxValue(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 5, 8, 3 }, 8)]
        [TestCase(new double[] { 3, 6, 0, 2 }, 8)]
        [TestCase(new double[] { 9, 9, 9, 9 }, 18)]
        [TestCase(new double[] { 4, 2, 8, 9 , 5, 9}, 20)]
        public void SumElementsWithOddIndexTests(double[] array, double expected)
        {
            double actual = OneDimentionalArrays.SumElementsWithOddIndex(array);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new double[] { 1, 5, 8, 3 }, new double[] { 3, 8, 5, 1 })]
        [TestCase(new double[] { 2, 2, 8, 8 }, new double[] { 8, 8, 2, 2 })]
        [TestCase(new double[] { 1, 1, 1, 1 }, new double[] { 1, 1, 1, 1 })]
        [TestCase(new double[] { 0, 1, 8, 3 }, new double[] { 3, 8, 1, 0 })]

        public void ReverseTests(double[] array, double [] expected)
        {
            OneDimentionalArrays.Reverse(ref array);
            double [] actual = array;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 5, 8, 3 }, 3)]
        [TestCase(new double[] { 2, 2, 8, 8 }, 0)]
        [TestCase(new double[] { 1, 1, 1, 1 }, 4)]
        [TestCase(new double[] { 0, 1, 8, 3 }, 2)]

        public void CountOddElementsTests(double[] array, int expected)
        {
            int actual = OneDimentionalArrays.CountOddElements(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 2, 3, 4, 5}, new double[] { 4, 5, 3, 1, 2 })]
        [TestCase(new double[] { 0, 0, 0, 0 }, new double[] { 0, 0, 0, 0 })]
        [TestCase(new double[] { 1, 1, 5, 1, 1 }, new double[] { 1, 1, 5, 1, 1 })]
        [TestCase(new double[] { 0, 1, 8, 7, 3 }, new double[] { 7, 3, 8, 0, 1 })]

        public void ReverseHalfTests(double[] array, double[] expected)
        {
            OneDimentionalArrays.ReverseHalf(ref array);
            double[] actual = array;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 2, 3, 4, 5 }, true, new double[] { 1, 2, 3, 4, 5 })]
        [TestCase(new double[] { 0, 0, 0, 0 }, false,new double[] { 0, 0, 0, 0 })]
        [TestCase(new double[] { 0, 0, 0, 0 }, true, new double[] { 0, 0, 0, 0 })]
        [TestCase(new double[] { 5, 3, 2, 1 , 7}, false, new double[] { 7, 5, 3, 2, 1 })]

        public void SortBubbleTests(double[] array, bool ascending, double[] expected)
        {
            OneDimentionalArrays.SortBubble(ref array, ascending);
            double[] actual = array;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 2, 3, 4, 5 }, true, new double[] { 1, 2, 3, 4, 5 })]
        [TestCase(new double[] { 0, 0, 0, 0 }, false, new double[] { 0, 0, 0, 0 })]
        [TestCase(new double[] { 0, 0, 0, 0 }, true, new double[] { 0, 0, 0, 0 })]
        [TestCase(new double[] { 5, 3, 2, 1, 7 }, false, new double[] { 7, 5, 3, 2, 1 })]

        public void SortSortSelectTests(double[] array, bool ascending, double[] expected)
        {
            OneDimentionalArrays.SortSelect(ref array, ascending);
            double[] actual = array;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 2, 3, 4, 5 }, true, new double[] { 1, 2, 3, 4, 5 })]
        [TestCase(new double[] { 0, 0, 0, 0 }, false, new double[] { 0, 0, 0, 0 })]
        [TestCase(new double[] { 0, 0, 0, 0 }, true, new double[] { 0, 0, 0, 0 })]
        [TestCase(new double[] { 5, 3, 2, 1, 7 }, false, new double[] { 7, 5, 3, 2, 1 })]

        public void SortInsertTests(double[] array, bool ascending, double[] expected)
        {
            OneDimentionalArrays.SortInsert(ref array, ascending);
            double[] actual = array;

            Assert.AreEqual(expected, actual);
        }

    }
}
