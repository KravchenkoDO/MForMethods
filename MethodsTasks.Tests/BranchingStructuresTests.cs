using System;
using System.Collections.Generic;
using System.Text;
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
        public void SumOrMultiplyOrSubstractionTests(int numberA, int numberB, int expected)
        {
            int actual = BranchingStructures.SumOrMultiplyOrSubstraction(numberA, numberB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,2,3, new double [] {1,2,3})]
        [TestCase(1,1,1, new double[] { 1, 1, 1 })]
        [TestCase(3,2,1, new double[] { 1, 2, 3 })]
        [TestCase(2,2,1, new double[] { 1, 2, 2 })]
        [TestCase(3.6d, 3.5d, 3.4d , new double[] { 3.4d, 3.5d, 3.6d })]
        [TestCase( 3.4d, 3.5d, 3.6d , new double[] { 3.4d, 3.5d, 3.6d })]
        [TestCase(0, 0, 0, new double[] { 0, 0, 0 })]
        public void OutputInAscendingOrderTests(double numberAd, double numberBd, double numberCd, double [] expected)
        {
            double[] actual = BranchingStructures.OutputInAscendingOrder(numberAd, numberBd, numberCd);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(1,1,1)]
        [TestCase(-1, 1, 2)]
        [TestCase(-1, -10, 3)]
        [TestCase(1, -1, 4)]
        [TestCase(-100500, 0, 0)]

        public void DefiningQuarterOnCoordinatePlaneTests(int X, int Y, int expected)
        {
            int actual = BranchingStructures.DefiningQuarterOnCoordinatePlane(X, Y);

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

        [TestCase(10,15,5, new double [] {-0.5d, -1d})]
        [TestCase(10, 12, 2, new double[] { -0.2d, -1d })]
        [TestCase(12, 6, 0, new double[] { 0d, -0.5d })]

        public void SolveQuadraticEquationTests(int numberA, int numberB, int numberC, double [] expected)
        {
            double[] actual = BranchingStructures.SolveQuadraticEquation(numberA, numberB, numberC);

            Assert.AreEqual(expected, actual);
        }
    }
}
