using NUnit.Framework;
using System.Collections.Generic;
using CTCI_LinkedList.Problems;

namespace CTCI_LinkedList.Tests
{
    [TestFixture]
    public class LinkedList_1Tester
    {
        [Test(Description = "Remove Duplicates from an unsorted LinkedList with the help of a buffer data structure"), 
            TestCaseSource(typeof(LinkedList_1TestInput), "UnsortedLinkedListTestData")]
        public void TestRemovalOfDuplicatesWithBuffer(List<int> inputList, string expected)
        {
            SinglyLinkedList node = LinkedListCreator.CreateSinglyLinkedListFromGenericList(inputList);
            LinkedList_1.RemoveDuplicates(node);
            Assert.AreEqual(expected, SinglyLinkedList.ToString(node));
        }

        [Test(Description = "Remove Duplicates from an unsorted LinkedList without the help of a buffer data structure"), 
            TestCaseSource(typeof(LinkedList_1TestInput), "UnsortedLinkedListTestData")]
        public void TestRemovalOfDuplicatesWithoutBuffer(List<int> inputList, string expected)
        {
            SinglyLinkedList node = LinkedListCreator.CreateSinglyLinkedListFromGenericList(inputList);
            LinkedList_1.RemoveDuplicatesWithoutBuffer(node);
            Assert.AreEqual(expected, SinglyLinkedList.ToString(node));
        }
    }
}
