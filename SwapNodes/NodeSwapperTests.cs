using NUnit.Framework;
using System.Collections.Generic;

namespace SwapNodes
{
    [TestFixture]
    public class NodeSwapperTests
    {
        [TestCaseSource(typeof(LinkedListSwapTestCases), "TestCaseInputAndExpectations")]
        public string SwapNodesTest(LinkedList list, int x, int y)
        {
            list.SwapNodes(x, y);
            return list.ToString();
        }

        [Test]
        public void ToStringTest()
        {
            var list = new LinkedList(new int[] { 45 });
            Assert.AreEqual(list.ToString(), "|Data:45|next:null|");
        }
    }

    public class LinkedListSwapTestCases
    {
        public static IEnumerable<TestCaseData> TestCaseInputAndExpectations
        {
            get
            {
                var inputLinkedList = new LinkedList(new int[] { 1, 2, 3, 4 });
                var afterSwap = new LinkedList(new int[] { 1, 3, 2, 4 });
                yield return new TestCaseData(inputLinkedList, 2, 3).Returns(afterSwap.ToString());

                inputLinkedList = new LinkedList(new int[] { 1, 2, 5, 3, 4 });
                afterSwap = new LinkedList(new int[] { 1, 3, 5, 2, 4 });
                yield return new TestCaseData(inputLinkedList, 2, 3).Returns(afterSwap.ToString());
                
                inputLinkedList = new LinkedList(new int[] { 1 });
                afterSwap = new LinkedList(new int[] { 1 });
                yield return new TestCaseData(inputLinkedList, 2, 3).Returns(afterSwap.ToString());

                yield return new TestCaseData(inputLinkedList, 1, 1).Returns(afterSwap.ToString());

                inputLinkedList = new LinkedList(new int[] { 1, 2, 5, 3, 4 });
                afterSwap = new LinkedList(new int[] { 4, 2, 5, 3, 1 });
                yield return new TestCaseData(inputLinkedList, 1, 4).Returns(afterSwap.ToString());

            }
        }
    }
}
