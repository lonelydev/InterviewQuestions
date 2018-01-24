using NUnit.Framework;
using FactorialQuestion.Problem;

namespace FactorialTester.Tests
{
    [TestFixture]
    public class FactorialTester
    {
        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(120, 5)]
        public void FactorialRecursiveTest1(int expected, int input)
        {
            var factorial = Factorial.FactorialRecursive(input);
            Assert.AreEqual(expected, factorial);
        }

        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(120, 5)]
        public void FactorialRecursiveTest2(int expected, int input)
        {
            var factorial = Factorial.FactorialIterative(input);
            Assert.AreEqual(expected, factorial);
        }

        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(120, 5)]
        public void FactorialRecursiveTest3(int expected, int input)
        {
            var factorial = Factorial.FactorialRecursiveOptimized(input);
            Assert.AreEqual(expected, factorial);
        }
    }
}
