namespace OOR
{
    class Rectangle : Geoshape
    {
        public Rectangle() { Console.WriteLine("Rectangle default Ctor!!"); }
        public Rectangle(double _dim1, double _dim2) : base(_dim1, _dim2) { Console.WriteLine("Rectangle 2Param Ctor!!"); }
    }
}
