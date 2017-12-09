namespace OverlappingRectanglesQuestion
{
    public class PairOfRectangleCoordinates
    {
        private RectangleCoordinates first;
        private RectangleCoordinates second;

        public RectangleCoordinates First { get { return first; } }
        public RectangleCoordinates Second { get { return second; } }

        public PairOfRectangleCoordinates(RectangleCoordinates one, RectangleCoordinates two)
        {
            first = one;
            second = two;
        }
    }
}
