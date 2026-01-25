using NUnit.Framework;
using System;

namespace testbai3
{
    [TestFixture]
    public class RadixUnitTests
    {
        /* ---------- Constructor Tests ---------- */

        [Test]
        public void Constructor_NumberIsNegative_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Radix(-5));
        }

        [Test]
        public void Constructor_NumberIsPositive_CreateSuccessfully()
        {
            Assert.DoesNotThrow(() => new Radix(10));
        }

        /* ---------- ConvertDecimalToAnother Tests ---------- */

        [Test]
        public void Convert_ToBinary_ReturnCorrectResult()
        {
            var radix = new Radix(10);
            var result = radix.ConvertDecimalToAnother(2);

            Assert.That(result, Is.EqualTo("1010"));
        }

        [Test]
        public void Convert_ToOctal_ReturnCorrectResult()
        {
            var radix = new Radix(8);
            var result = radix.ConvertDecimalToAnother(8);

            Assert.That(result, Is.EqualTo("10"));
        }

        [Test]
        public void Convert_ToHexadecimal_ReturnCorrectResult()
        {
            var radix = new Radix(255);
            var result = radix.ConvertDecimalToAnother(16);

            Assert.That(result, Is.EqualTo("FF"));
        }

        [Test]
        public void Convert_NumberIsZero_ReturnZero()
        {
            var radix = new Radix(0);
            var result = radix.ConvertDecimalToAnother(2);

            Assert.That(result, Is.EqualTo("0"));
        }

        [Test]
        public void Convert_RadixLessThan2_ThrowException()
        {
            var radix = new Radix(10);

            Assert.Throws<ArgumentException>(() => radix.ConvertDecimalToAnother(1));
        }

        [Test]
        public void Convert_RadixGreaterThan16_ThrowException()
        {
            var radix = new Radix(10);

            Assert.Throws<ArgumentException>(() => radix.ConvertDecimalToAnother(20));
        }
    }
}
