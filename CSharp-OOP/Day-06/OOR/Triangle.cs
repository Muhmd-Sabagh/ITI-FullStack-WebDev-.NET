namespace OOR
{
    class Triangle : Geoshape
    {
        public Triangle() { Console.WriteLine("Tiangle default Ctor!!"); }
        public Triangle(double _base, double height) : base(_base, height) { Console.WriteLine("Triangle 2Param Ctor!!"); }
        
        // Overriding
        public double CalcArea()
        {
            return 0.5 * Dim1 * Dim2;
        }
    }
}
