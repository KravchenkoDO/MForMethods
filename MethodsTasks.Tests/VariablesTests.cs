//using I?m_Getting_Too_Old_For_This_Shit;

using System;
using NUnit.Framework;
namespace MethodsTasks.Tests
{
    public class VariablesTests
    {

        [TestCase(-1, 4, 2.2d)]
        [TestCase(3.2d, 1.5d, -10.735d)]
        [TestCase(0, -5, -5)]
        [TestCase(-10, -5, -5)]
        public void FindExpressionValueTests(double numberAd, double numberBd, double expected)
        {
            double actual = Variables.FindExpressionValue(numberAd, numberBd);

            Assert.AreEqual(expected, actual, 0.001d);
        }
        [TestCase(12,12)]
        [TestCase(0.9,0.9)]
        [TestCase(2.5, 2.5)]
        [TestCase(0, 0)]
        public void FindExpressionValue_WhenAEqualToB_ArgumentExceptionReturned (double numberAd, double numberBd)
        {
            try
            {
                Variables.FindExpressionValue(numberAd, numberBd);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Pass();
            }
            Assert.Fail();

        }

        [TestCase(0.0d, 5, 5, 0.0d)]
        [TestCase(11.0d, 20d, 20d, 11d)]
        [TestCase(0d, 0d, 0d, 0d)]
        [TestCase(30d, 10d, 10d, 30d)]
        public void SwapNumbersTests(double numberAd, double numberBd, double expectedA, double expectedB)
        {
            Variables.SwapNumbers(ref numberAd, ref numberBd);
            double actualA = numberAd;
            double actualB = numberBd;

            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedA, actualA);
        }

        [TestCase(0.0d, 5, new double []{0d,0d})]
        [TestCase(10d, 3, new double[] { 3.33d, 1d })]
        [TestCase(12d, 1, new double[] { 12d, 0d })]
        [TestCase(3d, 3, new double[] { 1d, 0d })]
        public void DivideTwoNumbersAndReminderOfTheDivisionTests(double numberAd, double numberBd, double[] expected)
        {
            double [] actual = Variables.DivideTwoNumbersAndReminderOfTheDivision(numberAd, numberBd);

            for (int i = 0; i < actual.Length; i ++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.01d);
            }
        }
        [TestCase(12,0)]
        public void DivideTwoNumbersAndReminderOfTheDivision_WhenBEqualToZero_DividiByZeroExceptionReturned(double numberAd, double numberBd)
        {
            try
            {
                Variables.DivideTwoNumbersAndReminderOfTheDivision(numberAd, numberBd);
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2,5,5,0)]
        [TestCase(10,-4,-6, -0.2d)]
        [TestCase(9, 3, 6, 0.333)]
        [TestCase(0.35d, 1.5d, 5.0d, 10)]
        public void SolveLinearEquationTests(double numberAd, double numberBd, double numberCd, double expected)
        {
            double actual = Variables.SolveLinearEquation(numberAd, numberBd, numberCd);

            Assert.AreEqual(expected, actual, 0.001d);
        }

        [TestCase(0,5,2)]
        public void SolveLinearEquation_WhenAEqualToZero_DivideByZeroReturned(double numberAd, double numberBd,
            double numberCd)
        {
            try
            {
                Variables.SolveLinearEquation(numberAd, numberBd, numberCd);
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


        [TestCase (1,3,4,3, new double[] {0d, 3d })]
        [TestCase(10, 15, 8, 5, new double[] { 5d, -35d })]
        [TestCase(-1, -6, 1, 2, new double[] { 4d, -2d })]
        [TestCase(6, 0, 0, 6, new double[] { -1d, 6d })]

        public void DeriveEquationOfStraightLinePassingThroughPointsTests(double abscissaA, double ordinateA, double abscissaB, double ordinateB, double [] expected)
        {
            double[] actual = Variables.DeriveEquationOfStraightLinePassingThroughPoints(abscissaA, ordinateA, abscissaB, ordinateB);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.01d);
            }
        }

        [TestCase(2,4,2,-5)]
        public void
            DeriveEquationOfStraightLinePassingThroughPoints_WhenXOfPoinAEqualToXOfPoinB_ArgumentExveptionReturned(
                double abscissaA, double ordinateA, double abscissaB, double ordinateB)
        {
            try
            {
                Variables.DeriveEquationOfStraightLinePassingThroughPoints(abscissaA, ordinateA, abscissaB, ordinateB);
            }
            catch (ArgumentException e)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}