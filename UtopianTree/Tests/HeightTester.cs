using System.Collections;
using NUnit.Framework;
using UtopianTree;

namespace UtopianTreeTester
{
    [TestFixture]
    public class HeightTester
    {
        [Test, TestCaseSource(typeof(UtopianTreeHeightInput), "TestGrowthCycles")]
        public int HeightCalculateTest(int growthCycles)
        {
            return HeightCalculator.HeightFinder(growthCycles);
        }
    }

    public class UtopianTreeHeightInput
    {
        public static IEnumerable TestGrowthCycles
        {
            get
            {
                yield return new TestCaseData(2).Returns(3).SetName("Height after 2 cycles");
                yield return new TestCaseData(3).Returns(6).SetName("Height after 3 cycles");
                yield return new TestCaseData(6).Returns(15).SetName("Height after 6 cycles");
                yield return new TestCaseData(10).Returns(63).SetName("Height after 10 cycles");
                yield return new TestCaseData(20).Returns(2047).SetName("Height after 20 cycles");
            }
        }
    }
}
