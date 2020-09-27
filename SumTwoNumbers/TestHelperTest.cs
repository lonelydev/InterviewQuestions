using NUnit.Framework;
using System.Collections.Generic;

namespace SumTwoNumbers
{
    [TestFixture]
    public class TestHelperTest
    {
        [TestCaseSource(typeof(TestHelperTestData), "ListNodeCreatorTestCaseInputAndExpectations")]
        public bool CreateListNodeTest(string numValue, ListNode resultNode)
        {
            var reverseNumberList = TestHelper.CreateListNode(numValue);
            return TestHelper.AreNodesEqual(reverseNumberList, resultNode);
        }
    }

    public class TestHelperTestData
    {
        public static IEnumerable<TestCaseData> ListNodeCreatorTestCaseInputAndExpectations
        {
            get
            {
                var resultNode = new ListNode(4, new ListNode(2, new ListNode(3)));
                yield return new TestCaseData("423", resultNode).Returns(true);

                resultNode = new ListNode(1, new ListNode(2));
                yield return new TestCaseData("12", resultNode).Returns(true);

                resultNode = new ListNode(0);
                yield return new TestCaseData("0", resultNode).Returns(true);

                resultNode = new ListNode(1);
                var x = resultNode; 
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(0);
                x = x.next;
                x.next = new ListNode(1);
                yield return new TestCaseData("1000000000000000000000000000001", resultNode).Returns(true);
            }
        }
    }
}
