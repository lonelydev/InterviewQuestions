using System.Collections.Generic;
using System.Linq;

namespace OverlappingRectanglesQuestion
{
    public class RectangleCoordinates
    {
        private Point leftTop;
        private Point rightBottom;

        public Point LeftTop { get { return leftTop; } }
        public Point RightBottom { get { return rightBottom; } }


        public RectangleCoordinates(List<string> coordinates)
        {
            var listOfIntCoords = coordinates.Select(c => int.Parse(c)).ToList();

            leftTop = new Point(listOfIntCoords[0], listOfIntCoords[1]);
            rightBottom = new Point(listOfIntCoords[2], listOfIntCoords[3]);
        }

        public RectangleCoordinates(List<int> coordinates)
        {
            leftTop = new Point(coordinates[0], coordinates[1]);
            rightBottom = new Point(coordinates[2], coordinates[3]);
        }
    }
}
