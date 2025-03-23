namespace OOR
{
    class AggRectangle
    {
        Point upperLeft;
        Point lowerRight;

        public Point UpperLeft { get { return upperLeft; } set { upperLeft = value; } }
        public Point LowerRight { get { return lowerRight; } set { lowerRight = value; } }

        public AggRectangle()
        {
            // Just to make sure
            upperLeft = null;
            lowerRight = null;
            Console.WriteLine("Rectangle default Ctor!!");
        }
        public AggRectangle(Point _upperLeft, Point _lowerRight)
        {
            upperLeft = _upperLeft;
            lowerRight = _lowerRight;
            Console.WriteLine("Rectangle 2Param Ctor!!");
        }

    }
}
