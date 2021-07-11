using NUnit.Framework;
using System.Collections;
using System.Linq;

namespace PermMissingElem
{
    [TestFixture]
    public class SolutionTests
    {
        [Test, TestCaseSource(nameof(TestData))]
        public int Test(int[] input)
        {
            var solution = new Solution();
            return solution.Solve(input);
        }

        public static IEnumerable TestData
        {
            get
            {
                yield return new TestCaseData(new int[] { 2, 3, 1, 5 }).Returns(4);

                yield return new TestCaseData(new int[] { 1, 2, 4, 5, 6 }).Returns(3);

                yield return new TestCaseData(new int[] { 2, 3, 4, 5, 6 }).Returns(1);

                yield return new TestCaseData(new int[] { 2, 3 }).Returns(1);

                yield return new TestCaseData(new int[] { 2 }).Returns(1);

                var largeInput = Enumerable.Range(1, 100002).Where(i => i != 1001).ToArray();
                yield return new TestCaseData(largeInput).Returns(1001).SetName("Large input");
            }
        }
    }
}