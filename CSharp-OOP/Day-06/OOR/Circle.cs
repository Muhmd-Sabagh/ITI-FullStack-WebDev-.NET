namespace OOR
{
    class Circle : Geoshape
    {
        public Circle() { Console.WriteLine("Circle default Ctor!!"); }
        public Circle(double radius) : base(radius){ Console.WriteLine("Circle 1Param Ctor!!"); }

        // Overriding
        public double CalcArea()
        {
            return Math.PI * Dim1 * Dim1;
        }
    }
}
