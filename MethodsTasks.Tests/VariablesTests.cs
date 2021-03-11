using NUnit.Framework;
namespace MethodsTasks.Tests
{
    public class VariablesTests
    {

        [TestCase(0, 5, 5)]
        [TestCase(1, 2, 9)]
        [TestCase(0, -5, -5)]
        [TestCase(-10, -5, -5)]
        public void FindExpressionValueTests(double numberAd, double numberBd, double expected)
        {
            //Given
            double actual = Variables.FindExpressionValue(numberAd, numberBd);
            //When

            //Than
            Assert.AreEqual(expected, actual);
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
        [TestCase(12d, 5, new double[] { 2.4d, 2d })]
        [TestCase(12d, 1, new double[] { 12d, 0d })]
        [TestCase(3d, 3, new double[] { 1d, 0d })]
        public void DivideTwoNumbersAndReminderOfTheDivisionTests(double numberAd, double numberBd, double[] expected)
        {
            double [] actual = Variables.DivideTwoNumbersAndReminderOfTheDivision(numberAd, numberBd);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,5,5,0)]
        public void SolveLinearEquationTests(double numberAd, double numberBd, double numberCd, double expected)
        {
            double actual = Variables.SolveLinearEquation(numberAd, numberBd, numberCd);

            Assert.AreEqual(expected, actual);
        }
        
        [TestCase (1,3,4,3, new double[] {0d, 3d })]
        [TestCase(10, 15, 8, 5, new double[] { 5d, -35d })]
        [TestCase(-1, -6, 1, 2, new double[] { 4d, -2d })]
        [TestCase(6, 0, 0, 6, new double[] { -1d, 6d })]

        public void DeriveEquationOfStraightLinePassingThroughPointsTests(double abscissaA, double ordinateA, double abscissaB, double ordinateB, double [] expected)
        {
            double[] actual = Variables.DeriveEquationOfStraightLinePassingThroughPoints(abscissaA, ordinateA, abscissaB, ordinateB);

            Assert.AreEqual(expected, actual);
        }
    }
}