//using I’m_Getting_Too_Old_For_This_Shit;
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

        [TestCase(250, new double[] {250, 500, 750, 1000})]
        [TestCase(1000, new double[] {1000})]
        [TestCase(500, new double[] {500, 1000})]
        //[TestCase(0, new double[] { 0 })] 

        public void GetNumbersDividedByNumberATests(int numberAd, double[] expected)
        {
            double[] actual = Loops.GetNumbersDividedByNumberA(numberAd);

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

        [TestCase(15, 49, 175)]
        [TestCase(0, 7, 7)]
        [TestCase(7, 0, 7)]
        [TestCase(0, 6, 0)]
        [TestCase(1, 8, 7)]
        [TestCase(14, 1, 21)]
        public void GetSumNumbersFromAToBThatDividedBySevenTests(int numberA, int numberB, int expected)
        {
            int actual = Loops.GetSumNumbersFromAToBThatDividedBySeven(numberA, numberB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 8)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(12, 144)]

        public void FindNumberFibonacciTests(int numberN, int expected)
        {
            int actual = Loops.FindNumberFibonacci(numberN);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, 121, 11)]
        [TestCase(39, 13, 13)]
        [TestCase(325, 72, 1)]
        [TestCase(5, 1, 1)]
        [TestCase(-18, 21, 3)]

        public void FindGreatestCommonDividerByEvclidAlgorithmTests(int numberA, int numberB, int expected)
        {
            int actual = Loops.FindGreatestCommonDividerByEvclidAlgorithm(numberA, numberB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(125, 5)]
        [TestCase(27, 3)]
        [TestCase(4096, 16)]

        public void FindNumberByHalfDivisionMethodTests(int numberN, long expected)
        {
            long actual = Loops.FindNumberByHalfDivisionMethod(numberN);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(12346, 2)]
        [TestCase(35791913, 8)]
        [TestCase(0, 0)]
        [TestCase(246802, 0)]

        public void CountOddNumeralsOfNumberTests(int numberA, int expected)
        {
            int actual = Loops.CountOddNumeralsOfNumber(numberA);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(123456020, 020654321)]
        [TestCase(1220, 221)]
        [TestCase(20105215, 51250102)]
        [TestCase(3333, 3333)]

        public void FindMirrorNumberTests(int numberN, int expected)
        {
            int actual = Loops.FindMirrorNumber(numberN);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(16, new double[] {2, 4, 6, 8, 12, 14, 16})]
        [TestCase(2, new double[] {2})]
        [TestCase(13, new double[] {2, 4, 6, 8, 12})]


        public void FindNumbersWhereSumEvenNumeralsGreaterThenSumOddNumeralsTests(int numberN, double[] expected)
        {
            double[] actual = Loops.FindNumbersWhereSumEvenNumeralsGreaterThenSumOddNumerals(numberN);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(124,356, "NO")]
        [TestCase(1024, 3560, "YES")]
        [TestCase(124, 6780, "NO")]

        public void HaveTheSameNumeralsTests(int numberA, int numberB, string expected)
        {
            string actual = Loops.HaveTheSameNumerals(numberA, numberB);

            Assert.AreEqual(expected, actual);
        }




    }
}
