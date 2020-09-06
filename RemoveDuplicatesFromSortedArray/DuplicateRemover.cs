
namespace RemoveDuplicatesFromSortedArray
{
  public class DuplicateRemover
  {
    public int DuplicateRemoverSolution1(int[] nums)
    {
      /*
      * iterate through every element of the array. 
      * at every position, i of the array, check if the next element, j= i+1 is a duplicate
      * until we find it is not. 
      * set the next element as the newly found 
      * shift all elements to the left
      * a[i+1] = a[j]
      * nums => 1,1,2,2,3
      * First pass:
      * i = 0
      * j = 1,2
      * 
      * when j=2, swap elements at position i+1 and position j
      * nums => 1,2,1,2,3
      * 
      * Second:
      * i=1
      * j=2
      * nums[i] => 2, nums[j] => 1
      * j=3
      * nums[i] => 2, nums[j] => 2
      * j=4
      * nums[i] => 2, nums[j] => 3
      * 
      * 
      *
      */
      int i = 0;
      int lastElementPosition = nums.Length - 1;
      int lastSwappedValue = 0;
      while (i < lastElementPosition)
      {
        // until we find an element bigger than whats at i, keep looking
        int j = FindNextUniqueElementPosition(nums, i, lastSwappedValue);
        lastSwappedValue = SwapElementsInArray(nums, j, i + 1);
        if (j == lastElementPosition)
        {
          return i + 1;
        }
        i++;
      }
      return i;
    }

    private int FindNextUniqueElementPosition(int[] nums, int startIndex, int lastSwapped)
    {
      int j = startIndex + 1;
      while ((nums[j] <= nums[startIndex] || nums[j] <= lastSwapped) && j < nums.Length)
      {
        j++;
      }
      return j;
    }

    private int SwapElementsInArray(int[] nums, int sourceIndex, int destIndex)
    {
      int x = nums[destIndex];
      nums[destIndex] = nums[sourceIndex];
      nums[sourceIndex] = x;
      return nums[destIndex];
    }
  }
}
