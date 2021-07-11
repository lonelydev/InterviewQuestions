namespace PermMissingElem
{
    public class Solution
    {
        public int Solve(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var actualSum = 0;
            var max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                actualSum += A[i];
            }
            var expectedSum = (max * (max + 1)) / 2;
            return expectedSum - actualSum;
        }
    }
}