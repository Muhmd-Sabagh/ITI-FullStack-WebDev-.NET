namespace OOR
{
    class Point
    {
        int x, y;

        public int X
        {
            get { return x; }
            set
            {
                if (value < 0)
                    x = -value;
                else
                    x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set 
            {
                if (value < 0)
                    y = -value;
                else
                    y = value;
            }
        }

        public Point()
        {
            x = 0;
            y = 0;
            Console.WriteLine("Point default Ctor!!");
        }
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
            Console.WriteLine("Point 2Param Ctor!!");
        }
        public string Print()
        {
            return $"({x}, {y})";
        }
    }
}
