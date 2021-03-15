//using I’m_Getting_Too_Old_For_This_Shit;

using System;
using NUnit.Framework;

namespace MethodsTasks.Tests
{
    class BranchingStructuresTests
    {
        [TestCase(5,5,25)]
        [TestCase(11,7,18)]
        [TestCase(11,0,11)]
        [TestCase(0,5,-5)]
        [TestCase(0, 0, 0)]
        public void SumOrMultiplyOrSubtractionTests(int numberA, int numberB, int expected)
        {
            int actual = BranchingStructures.SumOrMultiplyOrSubtraction(numberA, numberB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,2,3, new double [] {1,2,3})]
        [TestCase(1,1,1, new double[] { 1, 1, 1 })]
        [TestCase(3d,2d,1d, new[] { 1d, 2d, 3d })]
        [TestCase(2,2,1, new double[] { 1, 2, 2 })]
        public void OutputInAscendingOrderTests(double numberAd, double numberBd, double numberCd, double [] expected)
        {
            double[] actual = BranchingStructures.OutputInAscendingOrder(numberAd, numberBd, numberCd);
            Assert.AreEqual(expected, actual);   
        }

        [TestCase(1,1,1)]
        [TestCase(-1, 1, 2)]
        [TestCase(-1, -10, 3)]
        [TestCase(1, -1, 4)]
        [TestCase(-100500, 0, 0)]
        [TestCase(0, -100500, 0)]


        public void DefiningQuarterOnCoordinatePlaneTests(int x, int y, int expected)
        {
            int actual = BranchingStructures.DefiningQuarterOnCoordinatePlane(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(10,"Ten")]
        [TestCase(99, "Ninety Nine")]
        [TestCase(15, "Fifteen")]
        [TestCase(25, "Twenty Five")]
        public void OutputNumberInWordsTests(int numberInt, string expected)
        {
            string actual = BranchingStructures.OutputNumberInWords(numberInt);

            Assert.AreEqual(expected,actual);
        }
        [TestCase(100)]
        [TestCase(9)]
        public void OutputNumberInWords_WhenNumberLessThen10OrGreaterThen99_ArgumentOutOfRangeReturned(int numberInt)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BranchingStructures.OutputNumberInWords(numberInt));
        }
        [TestCase(10,15,5, new[] {-0.5d, -1d})]
        [TestCase(10, 12, 2, new[] { -0.2d, -1d })]
        [TestCase(12, 6, 0, new[] { 0d, -0.5d })]
        [TestCase(2, 7, -15, new[] { 1.5d, -5d })]
        [TestCase(5, 9, 4, new[] { -0.8d, -1d })]
        [TestCase(1, -12, 36, new[] { 6d , 0})]
        [TestCase(16, 8, 1, new[] { -0.25d , 0})]

        public void SolveQuadraticEquationTests(int numberA, int numberB, int numberC, double [] expected)
        {
            double[] actual = BranchingStructures.SolveQuadraticEquation(numberA, numberB, numberC);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(5,1,6)]
        public void SolveQuadraticEquation_WhenDiscriminantLessThen0_ArgumentExceptionReturned(int numberA, int numberB,
            int numberC)
        {
            Assert.Throws<ArgumentException>(
                () => BranchingStructures.SolveQuadraticEquation(numberA, numberB, numberC));
        }

    }
}



