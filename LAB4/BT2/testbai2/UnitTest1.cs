using NUnit.Framework;

namespace PowerCalculator.Tests
{
    [TestFixture]
    public class PowerTests
    {
        [TestCase(5, 0, 1)]
        [TestCase(2, 3, 8)]
        [TestCase(10, 1, 10)]
        public void Power_PositiveExponent_ReturnCorrectValue(
            double baseValue,
            int exponent,
            double expected)
        {
            // Act
            var result = PowerHelper.Power(baseValue, exponent);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, -2, 0.25)]
        [TestCase(4, -1, 0.25)]
        public void Power_NegativeExponent_ReturnFraction(
            double baseValue,
            int exponent,
            double expected)
        {
            // Act
            var result = PowerHelper.Power(baseValue, exponent);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001));
        }

        [TestCase(-2, 3, -8)]
        [TestCase(-2, 2, 4)]
        public void Power_NegativeBase_ReturnCorrectSign(
            double baseValue,
            int exponent,
            double expected)
        {
            // Act
            var result = PowerHelper.Power(baseValue, exponent);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
