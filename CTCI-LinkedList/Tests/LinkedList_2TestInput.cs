using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace CTCI_LinkedList.Tests
{
    public class LinkedList_2TestInput
    {
        public static IEnumerable KthToTheLastElementInALinkedListTestCases
        {
            get
            {
                yield return 
                    new TestCaseData(
                        new List<int> { 13, 12, 15}, //list of elements
                        2, //kth the last element
                        12); //expected value

                yield return
                    new TestCaseData(
                        new List<int> { 13, 12, 15 }, //list of elements
                        1, //kth the last element
                        15); //expected value

                yield return
                    new TestCaseData(
                        new List<int> { 13, 12, 15 }, //list of elements
                        3, //kth the last element
                        13); //expected value

                yield return
                    new TestCaseData(
                        new List<int> { 13,12 },
                        2, 13);

                yield return
                    new TestCaseData(
                        new List<int> { 5, 25, 15, 9, 16, 12, 17, 18, 21},
                        3, 
                        17);
            }            
        }
    }
}
