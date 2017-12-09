using System;

namespace LongestIncreasingSubsequenceQuestion
{
    public class LongestIncreasingSubsequence
    {
        public static void Main(string[] args)
        {
            var inputArray = new int[] { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
            var lengthOfLongestInS = GetSizeOfLongestIncreasingSubsequence(inputArray, 9);
            Console.WriteLine(lengthOfLongestInS);
        }

        public static int GetSizeOfLongestIncreasingSubsequence(int[] arr, int sizeOfArray)
        {
            var lengthOfIncSubsequence = new int[sizeOfArray];

            //1 element sequence is the smallest sequence
            for (int i = 0; i < sizeOfArray; i++)
                lengthOfIncSubsequence[i] = 1;

            for (int i = 1; i < sizeOfArray; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //not entirely sure why the second condition is performed.
                    if (arr[i] > arr[j] && lengthOfIncSubsequence[i] < lengthOfIncSubsequence[j] + 1)
                    {
                        lengthOfIncSubsequence[i] = lengthOfIncSubsequence[j] + 1;
                    }
                }
            }
            var max = 0;
            for (int i = 0; i < lengthOfIncSubsequence.Length; i++)
            {
                if (max < lengthOfIncSubsequence[i])
                    max = lengthOfIncSubsequence[i];
            }
            return max;
        }
    }
}
