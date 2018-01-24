using System.Collections;
using NUnit.Framework;


namespace LinkedListMergeSortTester
{    
    internal class IntArrayMergeSortTestInput
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 10, 22, 9, 33, 21, 50, 41, 60, 80 })
                    .Returns(new int[] { 9, 10, 21, 22, 33, 41, 50, 60, 80 }).SetName("The standard unsorted");
                yield return new TestCaseData(new int[] { 99, 89, 79, 69, 59, 49, 39, 29, 19, 9 })
                    .Returns(new int[] { 9, 19, 29, 39, 49, 59, 69, 79, 89, 99 }).SetName("Another unsorted"); ;
                yield return new TestCaseData(new int[] { 1, 9, 5, 12, 4, 7, 35, 24, 15, 19, 22, 33, 23, 8, 6, 3 })
                    .Returns(new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 12, 15, 19, 22, 23, 24, 33, 35 }).SetName("The ultimate unsorted"); ;
                yield return new TestCaseData(new int[] { 10, 12, 13, 20, 21, 29, 35, 42, 50 })
                    .Returns(new int[] { 10, 12, 13, 20, 21, 29, 35, 42, 50 }).SetName("Sorted input");
                yield return new TestCaseData(new int[] { 10 }).Returns(new int[] { 10 }).SetName("Just one element");
                yield return new TestCaseData(new int[] { 1, 1, 1, 1, 1, 1 }).Returns(new int[] { 1, 1, 1, 1, 1, 1 }).SetName("Duplicate elements only");
                yield return new TestCaseData(new int[] { 10, 22, 9, 80, 33, 21, 50, 9, 41, 10, 60, 80 })
                    .Returns(new int[] { 9, 9, 10, 10, 21, 22, 33, 41, 50, 60, 80, 80 }).SetName("The standard unsorted with duplicates");

            }
        }
    }
}
