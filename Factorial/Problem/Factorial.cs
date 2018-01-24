namespace FactorialQuestion.Problem
{
    public class Factorial
    {
        /// <summary>
        /// Calculate factorial
        /// if (n == 1) return 1;
        /// if (n==0) return 1;
        /// factorial(n) =  n * factorial(n-1);
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FactorialRecursive(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            return (n * FactorialRecursive(n - 1));
        }

        /// <summary>
        /// Although this is tail recursion, I don't think .NET currently supports optimization 
        /// of such a method.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="factorial"></param>
        /// <returns></returns>
        public static int FactorialRecursiveOptimized(int n, int factorial = 1)
        {
            if (n == 0 || n == 1) return factorial;
            return FactorialRecursiveOptimized(n - 1, n * factorial);
        }

        /// <summary>
        /// An iterative take on factorial solution
        /// factorial = n * n-1 * n-2 * n-3
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FactorialIterative(int n)
        {
            if (n == 0 || n == 1) return 1;
            int iterator = n;
            int factorial = 1;
            while (iterator > 1)
            {
                factorial = factorial * iterator;
                iterator--;
            }
            return factorial;
        }
    }
}
