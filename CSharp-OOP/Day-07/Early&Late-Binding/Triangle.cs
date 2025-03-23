namespace Early_Late_Binding
{
    class Triangle : Geoshape
    {
        public Triangle() { Console.WriteLine("Tiangle default Ctor!!"); }
        public Triangle(double _base, double height) : base(_base, height) { Console.WriteLine("Triangle 2Param Ctor!!"); }

        // With and without Open Close Principle
        public override double CalcArea()
        {
            return 0.5 * dim1 * dim2;
        }
        public double CArea()
        {
            return 0.5 * dim1 * dim2;
        }
    }
}
