using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace CTCI_LinkedList
{
    public class LinkedList_1TestInput
    {
        public static IEnumerable UnsortedLinkedListTestData
        {
            get
            {
                yield return 
                    new TestCaseData(
                        new List<int> { 90, 10, 8, 15, 8, 20, 85, 77, 89, 91, 90 }, 
                        "90->10->8->15->20->85->77->89->91->NULL");

                yield return
                    new TestCaseData(
                        new List<int> { 13, 10, 8, 15, 15, 10, 85, 77, 91, 77, 13 },
                        "13->10->8->15->85->77->91->NULL");

                yield return
                    new TestCaseData(
                        new List<int> { 13, 10, 8, 10, 15, 85, 85, 77, 91, 13, 91 },
                        "13->10->8->15->85->77->91->NULL");

                yield return
                    new TestCaseData(
                        new List<int> { 13, 13, 13, 13, 10, 13, 13, 10, 13, 13 },
                        "13->10->NULL");

                yield return
                    new TestCaseData(
                        new List<int> { 13, 13, 13, 13, 13 },
                        "13->NULL");
            }            
        }
    }
}
