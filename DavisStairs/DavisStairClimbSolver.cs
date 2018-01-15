namespace DavisStairs
{
    public class DavisStairClimbSolver
    {
        public static int NumberOfWaysToClimbStepsRecursive(int n)
        {
            if (n == 0)
                return 0;
            //base case when 1 step
            if (n == 1 || n == 2)
            {
                return n;
            }
            var totalNumberOfWays = 1;
            totalNumberOfWays += NumberOfWaysToClimbStepsRecursive(n - 1) + NumberOfWaysToClimbStepsRecursive(n - 2) + NumberOfWaysToClimbStepsRecursive(n - 3);
            return totalNumberOfWays;
        }
    }
}
