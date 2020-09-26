using NUnit.Framework;
using System.Collections.Generic;

namespace SumTwoNumbers
{
    [TestFixture]
    public class Tests
    {
        [TestCaseSource(typeof(TwoLinkedListSumTestCases), "SolutionTestCaseInputAndExpectations")]
        public bool SumTwoLinkedListNumbersTest(ListNode ln1, ListNode ln2, ListNode resultNode)
        {
            var sumOfTwoListNodes = new Solution().AddTwoNumbers(ln1, ln2);
            return AreNodesEqual(sumOfTwoListNodes, resultNode);
        }

        [TestCaseSource(typeof(TwoLinkedListSumTestCases), "ListNodeCreatorTestCaseInputAndExpectations")]
        public bool CreateListNodeTest(int num, ListNode resultNode)
        {
            var reverseNumberList =  Solution.CreateListNode(num);
            return AreNodesEqual(reverseNumberList, resultNode);
        }

        private static bool AreNodesEqual(ListNode ln1, ListNode ln2)
        {
            var list1 = ln1;
            var list2 = ln2;

            while (list1 != null && list2 != null)
            {
                if (!list1.Equals(list2))
                {
                    return false;
                }

                list1 = list1.next;
                list2 = list2.next;
            }
            return true;
        }
    }

    public class TwoLinkedListSumTestCases
    {
        public static IEnumerable<TestCaseData> SolutionTestCaseInputAndExpectations
        {
            get
            {
                var listNode1 = Solution.CreateListNode(243);
                var listNode2 = Solution.CreateListNode(564);
                var resultNode = Solution.CreateListNode(807);
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = Solution.CreateListNode(1);
                listNode2 = Solution.CreateListNode(2);
                resultNode = Solution.CreateListNode(3);
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = Solution.CreateListNode(12);
                listNode2 = Solution.CreateListNode(13);
                resultNode = Solution.CreateListNode(25);
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = Solution.CreateListNode(0);
                listNode2 = Solution.CreateListNode(0);
                resultNode = Solution.CreateListNode(0);
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = Solution.CreateListNode(9);
                listNode2 = Solution.CreateListNode(9999999991);
                resultNode = Solution.CreateListNode(10000000000);
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                //listNode1 = Solution.CreateListNode(465);
                //listNode2 = Solution.CreateListNode(1000000000000000000000000000001);
                //resultNode = Solution.CreateListNode(1000000000000000000000000000466);
                //yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);
            }
        }

        public static IEnumerable<TestCaseData> ListNodeCreatorTestCaseInputAndExpectations
        {
            get
            {
                var resultNode = new ListNode(4, new ListNode(2, new ListNode(3)));
                yield return new TestCaseData(324, resultNode).Returns(true);

                resultNode = new ListNode(2, new ListNode(1));
                yield return new TestCaseData(12, resultNode).Returns(true);

                resultNode = new ListNode(0);
                yield return new TestCaseData(0, resultNode).Returns(true);
            }
        }
    }
}
