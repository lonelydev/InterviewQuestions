using NUnit.Framework;
using System.Collections.Generic;
using CTCI_LinkedList.Problems;

namespace CTCI_LinkedList.Tests
{
    [TestFixture]
    public class LinkedList_2Tester
    {
        [Test, TestCaseSource(typeof(LinkedList_2TestInput), "KthToTheLastElementInALinkedListTestCases")]
        public void LinkedList_2RecursiveRefConsoleWrite(List<int> inputList, int kToTheLastElementNumber, int expectedResult)
        {
            SinglyLinkedList node = LinkedListCreator.CreateSinglyLinkedListFromGenericList(inputList);
            int kToTheLastElementValue = 0;
            LinkedList_2.PrintKthElementRecursive(node, kToTheLastElementNumber, ref kToTheLastElementValue);
            Assert.AreEqual(expectedResult, kToTheLastElementValue);
        }
    }
}
