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
        [TestCase(3d,2d,1d, new double[] { 1d, 2d, 3d })]
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
            //TODO: Write negative tests "Argument Exception"
        }

        [TestCase(10,15,5, new double [] {-0.5d, -1d})]
        [TestCase(10, 12, 2, new double[] { -0.2d, -1d })]
        [TestCase(12, 6, 0, new double[] { 0d, -0.5d })]
        [TestCase(2, 7, -15, new double[] { 1.5d, -5d })]
        [TestCase(5, 9, 4, new double[] { -0.8d, -1d })]
        [TestCase(1, -12, 36, new double[] { 6d , 0})]
        [TestCase(16, 8, 1, new double[] { -0.25d , 0})]

        public void SolveQuadraticEquationTests(int numberA, int numberB, int numberC, double [] expected)
        {
            double[] actual = BranchingStructures.SolveQuadraticEquation(numberA, numberB, numberC);

            Assert.AreEqual(expected, actual);
            //TODO: Write negative tests "Discriminant must be greater or equal to 0"
        }
    }
}



