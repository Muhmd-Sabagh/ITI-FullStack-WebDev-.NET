namespace OOR
{
    class Square : Geoshape
    {
        public Square() { Console.WriteLine("Square default Ctor!!"); }
        public Square(double dim) : base(dim) { Console.WriteLine("Square 1Param Ctor!!"); }
    }
}
