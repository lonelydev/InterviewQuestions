using NUnit.Framework;

namespace RotateByKSteps
{
  [TestFixture]
  public class RotaterTests
  {
    private Rotater rotater;

    [SetUp]
    public void Setup()
    {
      rotater = new Rotater();
    }


    //[TestCase(new int[] { 1, 1, 3 }, 1, ExpectedResult = new int[] { 3, 1, 1 })]
    //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, ExpectedResult = new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    public int[] Test_Rotate_1(int[] nums, int steps)
    {
      rotater.Rotate_Solution_1(nums, steps);
      return nums;
    }

    [TestCase(new int[] { 1, 1, 3 }, 1, ExpectedResult = new int[] { 3, 1, 1 })]
    [TestCase(new int[] { -1, -100, 3, 99 }, 2, ExpectedResult = new int[] { 3, 99, -1, -100 })]
    [TestCase(new int[] { -1, -100, 3, 99 }, 6, ExpectedResult = new int[] { 3, 99, -1, -100 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, ExpectedResult = new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 10, ExpectedResult = new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    public int[] Test_Rotate_2(int[] nums, int steps)
    {
      rotater.Rotate_Solution_2(nums, steps);
      return nums;
    }
  }
}
