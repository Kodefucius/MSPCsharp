using System;
using ImbaCalculator;
using NUnit.Framework;

namespace ImbaCalculatorTests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void TestShouldAddTwoNumbers()
        {
            int a = 1;
            int b = 3;
            var calculator = new Calculator();
            int c = calculator.Add(a, b);
            Assert.That(5, Is.EqualTo(c));
        }
        [Test]
        public void TestShouldMultiplyTwoNumbers()
        {
            var random = new Random();
            int a = random.Next();
            int b = random.Next();
            var calculator = new Calculator();
            int c = calculator.Multiply(a, b);
            Assert.That(a*b,Is.EqualTo(c));
        }
    }
}