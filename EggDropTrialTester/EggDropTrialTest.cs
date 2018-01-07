using EggDropTrialQuestion;
using NUnit.Framework;

namespace EggDropTrialTester
{
    [TestFixture]
    public class EggDropTrialTest
    {
        [Test]
        public void EggDropRecursionTest_1()
        {
            var minNumberOfTrials = new EggDropSolverRecursive().FindOptimalNumberOfDrops(2, 10);
            Assert.AreEqual(4, minNumberOfTrials);
        }

        [Test]
        public void EggDropDynamicProgrammingTest_1()
        {
            var minNumberOfTrials = new EggDropSolverDynamicProgramming().FindOptimalNumberOfDrops(2, 100);
            Assert.AreEqual(14, minNumberOfTrials);
        }
    }
}
