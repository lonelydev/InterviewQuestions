using System.Collections.Generic;

namespace ArrayPairSumK
{
    public class CountPairsWithSumSolver
    {
        /// <summary>
        /// An interesting solution to finding the number of pairs that add upto a sum 
        /// Create a map of the element and its occurrences in the array. Requires one full traversal of the array
        /// initialize a counter.
        /// Traverse the array again but this time, check if the map contains a key sum-element . If it does then increase counter. 
        /// That means you've found a pair. 
        /// Now you don't want to count cases where 2 * element is sum, so you exclude it by decrementing the counter that was added. 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static int CountNumberPairsWithSumK(int[] array, int sum)
        {
            var mapOfNumberCounts = new Dictionary<int, int>();
            //create a map of numbers and their counts
            foreach(var element in array)
            {
                if (mapOfNumberCounts.ContainsKey(element))
                {
                    mapOfNumberCounts[element] = mapOfNumberCounts[element] + 1;
                }
                else
                {
                    mapOfNumberCounts.Add(element, 1);
                }                
            }
            int doubleCounter = 0;
            //now iterate again and see if there sum-element exists in the hashmap
            foreach(var element in array)
            {
                if (mapOfNumberCounts.ContainsKey(sum - element))
                {
                    doubleCounter += mapOfNumberCounts[sum - element];
                }

                // if we are adding the same number
                // soo decrease the counter
                if (sum - element == element)
                {
                    doubleCounter--;
                }
            }
            return doubleCounter / 2;
        }
    }
}
