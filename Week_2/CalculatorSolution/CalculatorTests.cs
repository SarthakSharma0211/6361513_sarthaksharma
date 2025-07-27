using NUnit.Framework;
using CalcLibrary;

namespace CalcTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void Teardown()
        {
            calc = null;
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(1, -1, 0)]
        [TestCase(0, 0, 0)]
        public void Add_AddsTwoNumbers_ReturnsCorrectResult(int a, int b, int expected)
        {
            var result = calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
