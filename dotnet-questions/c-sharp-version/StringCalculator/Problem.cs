using System;
using NUnit.Framework;

namespace c_sharp_version.StringCalculator
{
    [TestFixture]
    public class Problem
    {
        [Test]
        public void Add_WhenGivenNoNumbers_ReturnsZero()
        {
            var result = Calculator.Add("");

            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        [TestCase("10")]
        [Test]
        public void Add_WhenGivenOneNumber_ReturnsThatNumber(string value)
        {
            var result = Calculator.Add(value);
            Assert.That(result, Is.EqualTo(Convert.ToInt32(value)));
        }

        [TestCase("6,7", 13)]
        [TestCase("3,5", 8)]
        [Test]
        public void Add_WhenGivenTwoNumbers_AddNumbersTogether(string twoNumbers, int expected)
        {
            var result = Calculator.Add(twoNumbers);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("1\n2", 3)]
        [TestCase("3\n7", 10)]
        [Test]
        public void Add_WhenGivenNewLinesBetweenNumbers_TreatsNewLineAsDelimiter(string value, int expected)
        {
            var result = Calculator.Add(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("\\:\n1:3", 4)]
        [TestCase("\\-\n7-7", 14)]
        [Test]
        public void Add_WhenGivenTwoSlashesAtBeginning_UsesDelimiterAfterSlashesInsteadOfComma(string value, int expected)
        {
            var result = Calculator.Add(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Add_WhenGivenNegativeNumbers_ThrowsExceptionSayingNegativesArentAllowed()
        {
            Assert.Throws<ArgumentException>(() => Calculator.Add("-1"));
        }
    }
}