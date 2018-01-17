using System.Collections;
using NUnit.Framework;

namespace ArrayPairSumK
{
    [TestFixture]
    public class CountPairsWithSumTester
    {
        [Test, TestCaseSource(typeof(CountPairsWithSumTesterInput), "IntArrayAndSumK")]
        public int TestCountOfPairsWithSums(int[] array, int sum)
        {
            return CountPairsWithSumSolver.CountNumberPairsWithSumK(array, sum);
        }
    }

    public class CountPairsWithSumTesterInput
    {
        public static IEnumerable IntArrayAndSumK
        {
            get
            {
                yield return new TestCaseData(new int[] { 10, 15, 25, 15, 30, 5 }, 35).Returns(2);
                yield return new TestCaseData(new int[] { 1, 5, 7, -1, 5 }, 6).Returns(3);
                yield return new TestCaseData(new int[] { 1, 1, 1, 1 }, 2).Returns(6);
                yield return new TestCaseData(new int[] {10, 12, 10, 15, -1, 7, 6,
                   5, 4, 2, 1, 1, 1}, 11).Returns(9);

            }
        }
    }
}
