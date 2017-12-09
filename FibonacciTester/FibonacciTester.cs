using System.Collections.Generic;
using NUnit.Framework;
using FibonacciQuestion;

namespace FibonacciQuestionTester
{
    [TestFixture]
    public class FibonacciTester
    {
        [Test]
        public void FibonacciTester1()
        {
            var fib1 = Fibonacci.FibonacciSequencer(10);
            var fSeqExpected = new List<int>
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34
            };
            Assert.AreEqual(fSeqExpected, fib1);
        }

        [Test]
        public void FibonacciTester2()
        {
            var fib1 = Fibonacci.FibonacciSequencer(15);
            var fSeqExpected = new List<int>
            {
                0, 1, 1,
                2, 3, 5,
                8, 13, 21,
                34, 55, 89,
                144, 233, 377
            };
            Assert.AreEqual(fSeqExpected, fib1);
        }

        [Test]
        public void FibonacciTester3()
        {
            var fib1 = Fibonacci.FibonacciSequenceIterative(15);
            Assert.AreEqual(610, fib1);
        }


        [Test]
        public void FibonacciTester4()
        {
            var fib1 = Fibonacci.FibonacciSequenceIterative(20);
            Assert.AreEqual(6765, fib1);
        }

        [Test]
        public void FibonacciTester5()
        {
            var fib1 = Fibonacci.FibonacciSequenceIterative(47);
            Assert.AreEqual(2971215073, fib1);
        }

        [Test]
        public void FibonacciTester6()
        {
            var fib1 = Fibonacci.FibonacciRecursive(15);
            Assert.AreEqual(610, fib1);
        }


        [Test]
        public void FibonacciTester7()
        {
            var fib1 = Fibonacci.FibonacciRecursive(20);
            Assert.AreEqual(6765, fib1);
        }

        /// <summary>
        /// Uncomment and try running to see how long the inefficient recursive fibonacci takes.
        /// Takes quite a long time.
        /// </summary>
        //[Test]
        public void FibonacciTester8()
        {
            var fib1 = Fibonacci.FibonacciRecursive(47);
            Assert.AreEqual(2971215073, fib1);
        }

        [Test]
        public void FibonacciTester9()
        {
            var fib1 = Fibonacci.FibonacciOptimizedRecursive(15);
            Assert.AreEqual(610, fib1);
        }


        [Test]
        public void FibonacciTester10()
        {
            var fib1 = Fibonacci.FibonacciOptimizedRecursive(20);
            Assert.AreEqual(6765, fib1);
        }

        [Test]
        public void FibonacciTester11()
        {
            var fib1 = Fibonacci.FibonacciOptimizedRecursive(47);
            Assert.AreEqual(2971215073, fib1);
        }

        [Test]
        public void FibonacciTester12()
        {
            var fib1 = Fibonacci.FibonacciOptimizedRecursive(0);
            Assert.AreEqual(0, fib1);
        }

        [Test]
        public void FibonacciTester13()
        {
            var fib1 = Fibonacci.FibonacciOptimizedRecursive(1);
            Assert.AreEqual(1, fib1);
        }

        [Test]
        public void FibonacciTester14()
        {
            var fib1 = Fibonacci.FibonacciOptimizedRecursive(2);
            Assert.AreEqual(1, fib1);
        }

        [Test]
        public void FibonacciTester15()
        {
            var fib1 = Fibonacci.FibonacciOptimizedRecursive(5);
            Assert.AreEqual(5, fib1);
        }
    }
}
