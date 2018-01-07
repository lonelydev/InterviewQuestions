using System;

namespace EggDropTrialQuestion
{
    /// <summary>
    /// This is a dynamic programming and memoization based solution for finding 
    /// the optimal number of egg drops required to find the highest floor from where 
    /// an egg can be dropped safely without cracking
    /// </summary>
    public class EggDropSolverDynamicProgramming : IOptimalEggDropTrials
    {
        /// <summary>
        /// Using Dynamic programming with memoization makes the solution faster than the traditional recursive 
        /// implementation. 
        /// THe reason is memoization of course. Storing results of once calculated result into an array and not having
        /// to repeat the calculation again. 
        /// </summary>
        /// <param name="numberOfEggs"></param>
        /// <param name="numberOfFloors"></param>
        /// <returns></returns>
        public int FindOptimalNumberOfDrops(int numberOfEggs, int numberOfFloors)
        {
            // let us populate the array of results with the base cases
            // the base cases will not change - they are the same as the ones 
            // we determined in the recursive solution
            // where there is only one floor remaining = we drop the egg once = 1
            // when there are 0 floors then we don't drop the egg at all = 0
            // when there is just one egg then we return the number of floors as 
            // we have test it for that many floors anyway

            // i know that in c# multi dimensional arrays have a weird syntax
            var optimalNumberOfDrops = new int[numberOfEggs+1, numberOfFloors+1];
            // for any number of eggs if there are 0||1 floors, then initialize
            // number of drops as the number of floors
            for (var numOfEggs = 0; numOfEggs <= numberOfEggs; numOfEggs++)
            {
                //if you don't have eggs to drop, you just can't do a drop test no matter what floor you are on!
                switch (numOfEggs)
                {
                    case 0:
                        for (int floor = 0; floor <= numberOfFloors; floor++)
                        {
                            optimalNumberOfDrops[numOfEggs, floor] = 0;
                        }
                        break;
                    case 1:
                        // if numOfEggs == 1 then 
                        // there will be as many drops as there are floors 
                        for (int floor = 0; floor <= numberOfFloors; floor++)
                        {
                            optimalNumberOfDrops[numOfEggs, floor] = floor;
                        }
                        break;
                    default:
                        // for any number of eggs, if there are no floors, then you obviously have nothing to test
                        // so set them all to zero.
                        optimalNumberOfDrops[numOfEggs, 0] = 0;
                        break;
                }
            }
            // now that we have our array of results initialized, let's get to work with the rest of the calculations
            // we have to find number of drops when number of eggs > 1 and number of floors >= 1
            for(int numOfEggs = 2; numOfEggs <= numberOfEggs; numOfEggs++)
            {
                for(int floor=1; floor <= numberOfFloors; floor++)
                {
                    var minimum = int.MaxValue;
                    for(int remainingFloor = 1; remainingFloor<=floor; remainingFloor++)
                    {
                        //Evaluates 1+min{max(numeggs[i][j-x],numeggs[i-1][x-1])), for x:1,2,3...j-1,j}
                        minimum = Math.Min(minimum,
                        (1 + Math.Max(optimalNumberOfDrops[numOfEggs, floor - remainingFloor],
                        FindOptimalNumberOfDrops(numOfEggs - 1, remainingFloor - 1))));
                    }                    
                    optimalNumberOfDrops[numOfEggs, floor] = minimum;
                }
            }
            return optimalNumberOfDrops[numberOfEggs, numberOfFloors];
        }
    }
}
