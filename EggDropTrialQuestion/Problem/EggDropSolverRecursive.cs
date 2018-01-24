using System;

namespace EggDropTrialQuestion.Problem
{
    /// <summary>
    /// This is a recursion based solution for finding 
    /// the optimal number of egg drops required to find the highest floor from where 
    /// an egg can be dropped safely without cracking.
    /// This is the slowest performing solution. Keep that in mind when you choose values for 
    /// testing this solution
    /// </summary>
    public class EggDropSolverRecursive : IOptimalEggDropTrials
    {
        /// <summary>
        /// If the egg breaks:
        ///   * the problem then reduces to numberOfEggs - 1, numberOfFloors - 1
        /// 
        /// If the egg doesn't break:
        ///   * The problem then continues with the same number of eggs. The number of floors remaining is what matters. 
        ///   This becomes numberOfFloors - currentFloor
        ///   
        /// This is a very slow solution as there are several recursive calls and many of them repeated calls for the same values. 
        /// </summary>
        /// <param name="numberOfEggs"></param>
        /// <param name="numberOfFloors"></param>
        /// <returns></returns>
        public int FindOptimalNumberOfDrops(int numberOfEggs, int numberOfFloors)
        {
            // the base case
            if (numberOfFloors == 0 || numberOfFloors == 1 || numberOfEggs == 1)
            {
                return numberOfFloors;
            }
            //set 
            var minimum = int.MaxValue;

            //find it for every floor
            for (int floor=1; floor<=numberOfFloors; floor++)
            {
                minimum = Math.Min(minimum, 
                    (1 + Math.Max(FindOptimalNumberOfDrops(numberOfEggs, numberOfFloors - floor),
                    FindOptimalNumberOfDrops(numberOfEggs - 1, floor - 1))
                    ));
            }
            return minimum;
        }
    }
}
