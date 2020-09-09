namespace RotateByKSteps
{
  public class Rotater
  {
    /// <summary>
    /// This solution is a fail
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public void Rotate_Solution_1(int[] nums, int k)
    {
      for (int i = (nums.Length - 1); i >= k; i--)
      {
        var swapPosition = GetSwapPosition(i, k, nums.Length);
        int temp = nums[swapPosition];
        nums[swapPosition] = nums[i];
        nums[i] = temp;
      }
    }

    private int GetSwapPosition(int currentPosition, int steps, int length)
    {
      return (currentPosition + steps) % length;
    }

    /// <summary>
    /// O(n) solution - it works
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public void Rotate_Solution_2(int[] nums, int k)
    {
      /*
       * if k>nums.Length then mod it by Length to do actual rotations
       * create temporary array of 
       */
      if (k > nums.Length)
      {
        k %= nums.Length;
      }
      var otherSide = new int[k];
      var otherCounter = 0;
      // create a temporary array containing elements that will overflow from 
      // right side to the left. 
      for(int i=(nums.Length - k); i < nums.Length; i++)
      {
        otherSide[otherCounter++] = nums[i];
      }
      // shift all elements that can be shifted within the arrays size
      for (int i = (nums.Length - k); i > 0; i--)
      {
        nums[i - 1 + k] = nums[i - 1];
      }

      // fill in the left most elements using the temporary array.
      for(int i=0; i < k; i++)
      {
        nums[i] = otherSide[i];
      }
    }
  }
}
