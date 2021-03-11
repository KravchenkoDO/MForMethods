using NUnit.Framework;

namespace MForMethods.Tests
{
    public class VariableTests
    { 
        [TestCase(0.0d,2.0d,2.0d)]
        public void FindExpressionValueTests(double numberAd, double numberBd, double expected)
        {
            double actual = Variables.FindExpressionValue(numberAd, numberBd);
            Assert.AreEqual(expected, actual);
        }
    }
}