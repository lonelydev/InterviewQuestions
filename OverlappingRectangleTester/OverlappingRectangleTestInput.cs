using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OverlappingRectanglesQuestion;

namespace OverlappingRectangleTester
{
    public class OverlappingRectangleTestInput
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return 
                    new TestCaseData(new PairOfRectangleCoordinates(
                        new RectangleCoordinates(new List<int> { 0, 10, 10, 0 }), 
                        new RectangleCoordinates(new List<int> { 5, 5, 15, 0 })))
                        .Returns(1)
                        .SetName("They overlap!");

                yield return
                    new TestCaseData(new PairOfRectangleCoordinates(
                        new RectangleCoordinates(new List<int> { 0, 2, 1, 1 }),
                        new RectangleCoordinates(new List<int> { -2, -3, 0, 2 })))
                        .Returns(0)
                        .SetName("They don't overlap!");
            }
        }
    }
}
