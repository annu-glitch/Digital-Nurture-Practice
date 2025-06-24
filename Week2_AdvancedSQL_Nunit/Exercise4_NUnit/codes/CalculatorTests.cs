using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture] //contains all test methods
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]   //runs before each test
        public void init()
        {
            _calculator = new Calculator();
            TestContext.WriteLine("Setup created");
        }

        [TearDown] ///runs after each test
        public void CleanUp()
        {
            TestContext.WriteLine("TearDown: Test Complete");
        }

        [Test]
        public void Add_TwoPositiveNums_ReturnSum()   //no parameter required
        {
            int result = _calculator.add(24, 26);
            Assert.That(result, Is.EqualTo(50));
        }

        [TestCase(-1, -1, -2)]   //tests for multiple inputs
        [TestCase(9, 10, 19)]
        [TestCase(2, 3, 5)]
        [TestCase(5, 5, 10)]
        [TestCase(-10, 1, -9)]

        public void Add_MultipleNums_ReturnSum(int x, int y, int expected)   //parameters required
        {
            int result = _calculator.add(x, y);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("This test is ignored for demonstration")]
        public void Add_IgnoreThisTest()
        {
            Assert.Fail("This test is ignored and should not run.");
        }

    }
}
