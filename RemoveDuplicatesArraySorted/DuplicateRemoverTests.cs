using NUnit.Framework;

namespace RemoveDuplicatesArraySorted
{
  [TestFixture]
  public class DuplicateRemoverTests
  {
    private DuplicateRemover duplicateRemover { get; set; }

    [SetUp]
    public void Setup()
    {
      duplicateRemover = new DuplicateRemover();
    }

    [TestCase(new int[] { 1, 1, 3 }, ExpectedResult = 2)]
    [TestCase(new int[] { 1, 1, 2, 2, 3 }, ExpectedResult = 3)]
    [TestCase(new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = 1)]
    [TestCase(new int[] { 1, 1, 1, 1, 2 }, ExpectedResult = 2)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 5)]
    [TestCase(new int[] { 1, 2, 3, 4, 4 }, ExpectedResult = 4)]
    [TestCase(new int[] { }, ExpectedResult = 0)]
    [TestCase(new int[] { -1, 0, 0, 0, 0, 3, 3 }, ExpectedResult = 3)]
    public int Test_1_DuplicateRemoverSolution1(int[] nums)
    {
      return duplicateRemover.DuplicateRemoverSolution1(nums);
    }

    [TestCase(new int[] { 1, 1, 3 }, ExpectedResult = new int[] { 1, 3 })]
    [TestCase(new int[] { 1, 1, 2, 2, 3 }, ExpectedResult = new int[] { 1, 2, 3 })]
    [TestCase(new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = new int[] { 1 })]
    [TestCase(new int[] { 1, 1, 1, 1, 2 }, ExpectedResult = new int[] { 1, 2 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 4 }, ExpectedResult = new int[] { 1, 2, 3, 4 })]
    [TestCase(new int[] { }, ExpectedResult = new int[] { })]
    [TestCase(new int[] { -1, 0, 0, 0, 0, 3, 3 }, ExpectedResult = new int[] { -1, 0, 3 })]
    public int[] Test_2_DuplicateRemoverSolution1(int[] nums)
    {
      var lengthOfSortedUniqueElementsArray = duplicateRemover.DuplicateRemoverSolution1(nums);
      return GetUniqueElementsArray(nums, lengthOfSortedUniqueElementsArray);
    }



    [TestCase(new int[] { 1, 1, 3 }, ExpectedResult = 2)]
    [TestCase(new int[] { 1, 1, 2, 2, 3 }, ExpectedResult = 3)]
    [TestCase(new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = 1)]
    [TestCase(new int[] { 1, 1, 1, 1, 2 }, ExpectedResult = 2)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 5)]
    [TestCase(new int[] { 1, 2, 3, 4, 4 }, ExpectedResult = 4)]
    [TestCase(new int[] { }, ExpectedResult = 0)]
    [TestCase(new int[] { -1, 0, 0, 0, 0, 3, 3 }, ExpectedResult = 3)]
    public int Test_1_DuplicateRemoverSolution2(int[] nums)
    {
      return duplicateRemover.DuplicateRemoverSolution2(nums);
    }

    [TestCase(new int[] { 1, 1, 3 }, ExpectedResult = new int[] { 1, 3 })]
    [TestCase(new int[] { 1, 1, 2, 2, 3 }, ExpectedResult = new int[] { 1, 2, 3 })]
    [TestCase(new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = new int[] { 1 })]
    [TestCase(new int[] { 1, 1, 1, 1, 2 }, ExpectedResult = new int[] { 1, 2 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 4 }, ExpectedResult = new int[] { 1, 2, 3, 4 })]
    [TestCase(new int[] { }, ExpectedResult = new int[] { })]
    [TestCase(new int[] { -1, 0, 0, 0, 0, 3, 3 }, ExpectedResult = new int[] { -1, 0, 3 })]
    public int[] Test_2_DuplicateRemoverSolution2(int[] nums)
    {
      var lengthOfSortedUniqueElementsArray = duplicateRemover.DuplicateRemoverSolution2(nums);
      return GetUniqueElementsArray(nums, lengthOfSortedUniqueElementsArray);
    }

    private static int[] GetUniqueElementsArray(int[] nums, int lengthOfSortedUniqueElementsArray)
    {
      var arr = new int[lengthOfSortedUniqueElementsArray];
      for (int i = 0; i < lengthOfSortedUniqueElementsArray; i++)
      {
        arr[i] = nums[i];
      }
      return arr;
    }
  }
}
