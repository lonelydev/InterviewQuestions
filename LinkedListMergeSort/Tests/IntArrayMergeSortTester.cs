using NUnit.Framework;
using LinkedListMergeSort.Problem;

namespace LinkedListMergeSortTester.Tests
{
    [TestFixture]
    public class IntArrayMergeSortTester
    {
        [Test, TestCaseSource(typeof(IntArrayMergeSortTestInput), "TestCases")]
        public int[] TestArrayMergeSort1(int[] inputArray)
        {
            ArrayMergeSorter.MergeSortIntArray(inputArray);
            return inputArray;
        }
    }
}
