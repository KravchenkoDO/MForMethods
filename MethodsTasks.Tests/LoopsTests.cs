using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsTasks.Tests
{
    class LoopsTests
    {
        [TestCase(5, 3, 125)]
        [TestCase(5, -3, 0.008)]
        [TestCase(5, 0, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 125, 0)]
        //[TestCase(0, -5, 1)] This is normal

        public void ExponentiationTests(double numberAd, double numberBd, double expected)
        {
            double actual = Loops.Exponentiation(numberAd, numberBd);

            Assert.AreEqual(expected, actual, 0.001);
            //TODO: Write negative tests "Number A can not be equal to 0 when number B less then 0!!!"
        }

        [TestCase(250, new double[] {250, 500, 750, 1000 })]
        [TestCase(1000, new double[] { 1000 })]
        [TestCase(500, new double[] { 500, 1000 })]
        //[TestCase(0, new double[] { 0 })] 

        public void GetNumbersDividedByNumberATests(int numberAd, double [] expected)
        {
            double [] actual = Loops.GetNumbersDividedByNumberA(numberAd);

            Assert.AreEqual(expected, actual);
            //TODO: Write negative tests "Number A can not be equal to 0!!!"
        }

        [TestCase(125, 11)]
        [TestCase(144, 11)]
        [TestCase(2, 1)]

        public void FindCountPositiveIntegerElementsThatSquareLessThenNumberATests(double numberA, int expected)
        {
            int actual = Loops.FindCountPositiveIntegerElementsThatSquareLessThenNumberA(numberA);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(125, 25)]
        //[TestCase(1, 1)]
        [TestCase(-10, 5)]
        [TestCase(100, 50)]

        public void GetGreaterDividerTests(int numberA, int expected)
        {
            int actual = Loops.GetGreaterDivider(numberA);

            Assert.AreEqual(expected, actual);
            //TODO: write negative test argumentException
        }




    }
}
