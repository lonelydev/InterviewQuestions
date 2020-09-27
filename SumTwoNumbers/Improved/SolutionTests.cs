using NUnit.Framework;

namespace SumTwoNumbers.Improved
{
    [TestFixture]
    public class SolutionTests
    {
        private Solution _solution = new Solution();
        [TestCaseSource(typeof(SolutionTestCases), "SolutionTestCaseInputAndExpectations")]
        public bool SumTwoLinkedListNumbersTest(ListNode ln1, ListNode ln2, ListNode resultNode)
        {
            var sumOfTwoListNodes = _solution.AddTwoNumbers(ln1, ln2);
            return TestHelper.AreNodesEqual(sumOfTwoListNodes, resultNode);
        }
    }
}
