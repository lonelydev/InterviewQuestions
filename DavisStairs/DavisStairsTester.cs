using System.Collections;
using NUnit.Framework;

namespace DavisStairs
{
    [TestFixture]
    public class DavisStairsTester
    {
        [Test, TestCaseSource(typeof(DavisStairsTester), "RecursiveTestInput")]
        public int DavisStairsRecursiveTester(int numberOfSteps)
        {
            return DavisStairClimbSolver.NumberOfWaysToClimbStepsRecursive(numberOfSteps);
        }

        public static IEnumerable RecursiveTestInput
        {
            get
            {
                yield return new TestCaseData(3).Returns(4);
                yield return new TestCaseData(2).Returns(2);
                yield return new TestCaseData(1).Returns(1);
                yield return new TestCaseData(0).Returns(0);
                yield return new TestCaseData(4).Returns(8);
                yield return new TestCaseData(5).Returns(15);
                yield return new TestCaseData(6).Returns(30);
            }
        }
    }
}
