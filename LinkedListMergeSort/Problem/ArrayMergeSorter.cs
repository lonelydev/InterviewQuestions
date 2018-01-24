namespace LinkedListMergeSort.Problem
{
    public class ArrayMergeSorter
    {
        /// <summary>
        /// an example of merge sort of integer arrays first
        /// </summary>
        /// <param name="array"></param>
        public static void MergeSortIntArray(int[] inputArray)
        {
            var size = inputArray.Length;
            if (size < 2)
                return;
            var middle = size / 2;
            var leftArraySize = middle;
            var rightArraySize = size - middle;
            var leftArray = new int[middle];
            var rightArray = new int[rightArraySize];
            for(int i=0; i <middle; i++)
            {
                leftArray[i] = inputArray[i];
            }
            //start from the middle
            for(int i=middle; i < size; i++)
            {
                rightArray[i - middle] = inputArray[i];
            }
            MergeSortIntArray(leftArray);
            MergeSortIntArray(rightArray);
            MergeArrays(leftArray, rightArray, inputArray);
        }

        /// <summary>
        /// Replaces elements in dest array with merged result of source1 and source2
        /// </summary>
        /// <param name="source1"></param>
        /// <param name="source2"></param>
        /// <param name="dest"></param>
        private static void MergeArrays(int[] source1, int[] source2, int[] dest)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < source1.Length && j < source2.Length)
            {
                if (source1[i] < source2[j])
                {
                    dest[k++] = source1[i++];
                }
                else
                {
                    dest[k++] = source2[j++];
                }
            }
            //now fill in the remaining
            while (i < source1.Length)
            {
                dest[k++] = source1[i++];
            }
            while (j < source2.Length)
            {
                dest[k++] = source2[j++];
            }
        }
    }
}
