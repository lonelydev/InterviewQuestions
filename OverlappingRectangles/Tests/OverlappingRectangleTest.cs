using NUnit.Framework;
using OverlappingRectanglesQuestion.Problem;

namespace OverlappingRectangleTester.Tests
{
    [TestFixture]
    public class OverlappingRectangleTest
    {
        [Test, TestCaseSource(typeof(OverlappingRectangleTestInput), "TestCases")]
        public int DoRectanglesOverlap(PairOfRectangleCoordinates pair)
        {
            return OverlappingRectangles.DoRectanglesOverlap(pair);
        }
    }
}
