namespace OOR
{

    class Line
    {
        Point start;
        Point end;

        public Point Start { get { return start; } set { start = value; } }
        public Point End { get { return end; } set { end = value; } }
        public Line()
        {
            start = new Point();
            end = new Point();
            Console.WriteLine("Line default Ctor!!");
        }
        public Line(int x1, int y1, int x2, int y2)
        {
            start = new Point();
            end = new Point();
            start.X = x1;
            start.Y = y1;
            end.X = x2;
            end.Y = y2;
            Console.WriteLine("Line 4Param Ctor!!");
        }
        public void SetStart(int _x, int _y)
        {
            start.X = _x;
            start.Y = _y;
        }
        public void SetEnd(int _x, int _y)
        {
            end.X = _x;
            end.Y = _y;
        }
        public string Print()
        {
            return $"Line start point ({start.X}, {start.Y}), end point ({end.X}, {end.Y})";
        }
    }

    class CompTriangle
    {
        Point top;
        Point bottomRight;
        Point bottomLeft;

        public Point Top { get { return top; } set { top = value; } }
        public Point BottomRight { get { return bottomRight; } set { bottomRight = value; } }
        public Point BottomLeft { get { return bottomLeft; } set { bottomLeft = value; } }
        public CompTriangle()
        {
            top = new Point();
            bottomRight = new Point();
            bottomLeft = new Point();
            Console.WriteLine("Tirangle default Ctor!!");
        }
        public CompTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            top = new Point();
            bottomRight = new Point();
            bottomLeft = new Point();
            top.X = x1;
            top.Y = y1;
            bottomRight.X = x2;
            bottomRight.Y = y2;
            bottomLeft.X = x3;
            bottomLeft.Y = y3;
            Console.WriteLine("Tirangle 6Param Ctor!!");
        }
    }

}
