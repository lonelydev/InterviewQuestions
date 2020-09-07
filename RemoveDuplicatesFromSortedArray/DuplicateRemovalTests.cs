using NUnit.Framework;

namespace RemoveDuplicatesFromSortedArray
{
  [TestFixture]
  public class DuplicateRemovalTests
  {
    private DuplicateRemover duplicateRemover { get; set; }

    [SetUp]
    public void Setup()
    {
      duplicateRemover = new DuplicateRemover();
    }

    [TestCase(new int[] { 1, 1, 3 }, ExpectedResult = 2)]
    [TestCase(new int[] { 1, 1, 2, 2, 3 }, ExpectedResult = 3)]

    public int Test_DuplicateRemoverSolution1(int[] nums)
    {
      return duplicateRemover.DuplicateRemoverSolution1(nums);
    }
  }
}
