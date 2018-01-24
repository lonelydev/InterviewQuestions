using NUnit.Framework;
using LongestIncreasingSubsequenceQuestion.Problem;
namespace LongestIncreasingSubsequenceTester.Tests
{
    public class LongestIncreasingSubsequenceTester
    {
        [Test, TestCaseSource(typeof(LongestIncreasingSubsequenceTesterInput), "TestCases")]
        public int Test(int[] inputArray, int arraySize)
        {
            return LongestIncreasingSubsequence
                .GetSizeOfLongestIncreasingSubsequence(inputArray, arraySize);
        }
    }
}
