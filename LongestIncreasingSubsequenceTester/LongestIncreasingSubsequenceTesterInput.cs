using System.Collections;
using NUnit.Framework;

namespace LongestIncreasingSubsequenceTester
{
    public class LongestIncreasingSubsequenceTesterInput
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 10, 22, 9, 33, 21, 50, 41, 60, 80 }, 9)
                    .Returns(6).SetName("6 element sequence");
                yield return new TestCaseData(new int[] { 10, 12, 13, 20, 21, 29, 35, 42, 50 }, 9)
                    .Returns(9).SetName("Longest sequence is the size of the input");
                yield return new TestCaseData(new int[] { 10, 9 }, 1).Returns(1).SetName("Just one element sequences");
            }
        }
    }
}
