using System.Collections.Generic;

namespace FibonacciQuestion.Problem
{
    /// <summary>
    /// Write a piece of code to create a Fibonacci sequence using recursion.
    /// Write a piece of code to create a Fibonacci sequence using the iterative method.
    /// The Fibonacci Sequence is the series of numbers:
    /// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
    /// The next number is found by adding up the two numbers before it.
    /// The 2 is found by adding the two numbers before it(1+1)
    /// The 3 is found by adding the two numbers before it(1+2),
    /// And the 5 is (2+3),
    /// and so on!
    /// So to get Fibonacci series upto n, we start from 0, 1 and then go on to 
    /// add most recent numbers in the list
    /// element[1] = element[0] + 1
    /// element[2] = element[1] + element[0]
    /// element[3] = element[2] + element[1]
    /// Some interesting learning for those learning recursion:
    /// https://www.youtube.com/watch?v=dxyYP3BSdcQ
    /// https://www.youtube.com/watch?v=wLRuAg0ZHt0
    /// https://youtu.be/7t_pTlH9HwA
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// returns list of series upto n numbers
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<int> FibonacciSequencer(int n)
        {
            var fibonacciSequence = new List<int>();
            int i = 0;
            while (i < n)
            {
                if (i < 1)
                {
                    fibonacciSequence.Add(0);
                }
                else if (i == 1)
                {
                    fibonacciSequence.Add(i);
                }
                else
                {
                    fibonacciSequence.Add(fibonacciSequence[i - 1] + fibonacciSequence[i - 2]);
                }
                i++;
            }
            return fibonacciSequence;
        }

        public static double FibonacciSequenceIterative(int n)
        {
            double a = 0;
            double b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        /// <summary>
        /// This is a horrendous performing fibonacci function
        /// It recursively calls itself twice each time. 
        /// Could cause stack overflow
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double FibonacciRecursive(double n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        /// <summary>
        /// To optimize a recursive fibonacci function - Uses tail recursion to re-use stack frames
        /// This re-use of stack frames make it faster than the previous recursive implementation
        /// In other words compilers generally would optimize it as if it were written iteratively. 
        /// </summary>
        /// <param name="term"></param>
        /// <param name="val"></param>
        /// <param name="prev"></param>
        /// <returns></returns>
        public static double FibonacciOptimizedRecursive(int term, double val = 1, double prev = 0)
        {
            if (term == 0) return prev;
            if (term == 1) return val;
            return FibonacciOptimizedRecursive(term - 1, val + prev, val);
        }
    }
}
