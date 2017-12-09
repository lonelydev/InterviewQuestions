using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OverlappingRectanglesQuestion
{
    public class OverlappingRectangles
    {
        public static void Main(string[] args)
        {
            var numOfTest = Console.ReadLine();
            int numberOfTest = 0;
            int.TryParse(numOfTest, out numberOfTest);
            var listOfRectangleCoordinatePairs = new List<PairOfRectangleCoordinates>();
            var regex = new Regex(@"\s");
            while (numberOfTest > 0)
            {
                var firstRectangleCoordinates = Console.ReadLine();
                var secondRectangleCoordinates = Console.ReadLine();
                var firstListOfCoordinates = regex.Split(firstRectangleCoordinates).ToList();
                if (firstListOfCoordinates.Count() != 4) throw new InvalidOperationException("Requires at least 2 pairs of x,y coordinates");                
                var secondListOfCoordinates = regex.Split(secondRectangleCoordinates).ToList();
                if (secondListOfCoordinates.Count() != 4) throw new InvalidOperationException("Requires at least 2 pairs of x,y coordinates");
                listOfRectangleCoordinatePairs.Add(
                    new PairOfRectangleCoordinates(
                        new RectangleCoordinates(firstListOfCoordinates),
                        new RectangleCoordinates(secondListOfCoordinates)
                        )
                    );
                numberOfTest--;
            }
            foreach(var pair in listOfRectangleCoordinatePairs)
            {
                Console.WriteLine(DoRectanglesOverlap(pair));
            }
        }

        /// <summary>
        /// Following is a simpler approach. Two rectangles do not overlap if one of the following conditions is true.
        /// 1) One rectangle is above top edge of other rectangle.
        /// 2) One rectangle is on left side of left edge of other rectangle.
        /// </summary>
        /// <param name="pair"></param>
        /// <returns></returns>
        public static int DoRectanglesOverlap(PairOfRectangleCoordinates pair)
        {
            if (pair.First.LeftTop.X > pair.Second.RightBottom.X || pair.Second.LeftTop.X > pair.First.RightBottom.X)
                return 0;

            if (pair.First.LeftTop.Y < pair.Second.RightBottom.Y || pair.Second.LeftTop.Y < pair.First.RightBottom.Y)
                return 0;

            return 1;
        }
    }
}
