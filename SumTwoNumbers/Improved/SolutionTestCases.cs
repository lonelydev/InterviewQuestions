using NUnit.Framework;
using System.Collections.Generic;

namespace SumTwoNumbers.Improved
{
    public class SolutionTestCases
    {
        public static IEnumerable<TestCaseData> SolutionTestCaseInputAndExpectations
        {
            get
            {
                var listNode1 = TestHelper.CreateListNode("243");
                var listNode2 = TestHelper.CreateListNode("564");
                var resultNode = TestHelper.CreateListNode("708");
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = TestHelper.CreateListNode("1");
                listNode2 = TestHelper.CreateListNode("2");
                resultNode = TestHelper.CreateListNode("3");
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = TestHelper.CreateListNode("12");
                listNode2 = TestHelper.CreateListNode("13");
                resultNode = TestHelper.CreateListNode("25");
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = TestHelper.CreateListNode("0");
                listNode2 = TestHelper.CreateListNode("0");
                resultNode = TestHelper.CreateListNode("0");
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                //listNode1 = TestHelper.CreateListNode("9");
                //listNode2 = TestHelper.CreateListNode("19999999999");
                //resultNode = TestHelper.CreateListNode("000000000001");
                //yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = TestHelper.CreateListNode("9");
                listNode2 = TestHelper.CreateListNode("199");
                resultNode = TestHelper.CreateListNode("0001");
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);

                listNode1 = TestHelper.CreateListNode("564");
                listNode2 = TestHelper.CreateListNode("1000000000000000000000000000001");
                resultNode = TestHelper.CreateListNode("6640000000000000000000000000001");
                yield return new TestCaseData(listNode1, listNode2, resultNode).Returns(true);
            }
        }
    }
}
